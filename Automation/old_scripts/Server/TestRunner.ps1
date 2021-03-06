#construct and run the VM to the spec provided
Function Run-Test {
    param(
        [parameter(Mandatory = $true)]
        $Name, # Name of the VM.
        [parameter(Mandatory = $true)]
        $Base, # The base VHD to use.
        [parameter(Mandatory = $true)]
        $Script,
        $Mem,
        $CPU,
        $Limit,
        $Out_Path = '.\'
    )
    process {
        $cmdLine = "Provision-VM -Name `"$Name`" -VHD `"$Base`"";
        if (!(!$Mem)) { $cmdLine += " -Mem $Mem"; }
        if (!(!$CPU)) { $cmdLine += " -CPU $CPU"; }
        if (!(!$Limit)) { $cmdLine += " -CPU_max $Limit"; }
        $VM = Invoke-Expression $cmdLine;
        Start-VM $VM; # Start up the VM.
        
        # Make a new connection to the pipe called '<VM-Name>_IO_Pipe'
        $pipe = New-Pipe ($Name+"_IO_Pipe");
        #need to be patient here to collect the initial message
        Start-Sleep -s 8; #This is a guess based upon emperical evidence
        
        [string]$msg = Read-Pipe $pipe;
        "'$msg'";
        if (!($msg.Equals('VM'))) {
            #First message was not what we expected.  Bail out.
            "Invalid initial Pipe message.  Exiting.";
            $pipe.Close();
            Unprovision-VM $VM;
            return;
        }
        
        ##Normal script flow##
        #Does the script file exist?
        if (!(Test-Path $Script)) {
            #No script file, bail out.
            "No script at specified location.  Exiting.";
            $pipe.Close();
            Unprovision-VM $VM;
            return;
        }
        
        #Read in the script file provided
        $Client_Script = Get-Content $Script;
        
        #Send the script to run
        #Write-Pipe $pipe $Client_Script;
        foreach ($line in $Client_Script)
            {Write-Pipe $pipe ($line + '
');}

        #Send the notice for end of this instruction set
        Write-Pipe $pipe '^^^EOF^^^';
        
        #Read and record from the pipe until the VM says it's done.
        $msg = "___ Begin VM Output File  ---  $Name ___`n"
        $msg;
        Add-Content -Path ($Out_Path+'\'+$Name+".log") -Value $msg;
        do{
            $msg = Read-Pipe $pipe;
            $msg;
            Add-Content -Path ($Out_Path+'\'+$Name+".log") -Value $msg;
        }while (!($msg.Contains('^^^TERM^^^')))
        
        
        #VM is still waiting for further instructions.
        #Ask the VM to shutdown (because I'm like that).
#        Write-Pipe $pipe 'Shutdown /f /s /t 0';
#        "Shutting down VM...";
        
        #Wait 5 seconds for the VM to shut down (I'm patient, but not very).
#        Start-Sleep -s 5;
        
        #Nuke the VM and return to parent.
        "Normal Exit.";
        $pipe.Close();
#        Unprovision-VM $VM;
        return;

    }
}

