#helper function file for the server scripts

#helper function to create new named pipe connections (client connections)
Function New-Pipe {
    param(
        [parameter(Mandatory = $true)]
        [string]$Name
    )
    process {
        # Attach a new stream to the pipe
        $pipe = New-Object system.IO.Pipes.NamedPipeClientStream($Name);
        # Need to remember to actually connect to the pipe before returning it...
        $pipe.Connect();
        $pipe;
    }
}

#helper function to receive the next designated packet from the client
Function Read-Pipe {
    param(
        [parameter(Mandatory = $true)]
        $pipe
    )
    process {
        [byte[]]$msg_bytes = @();
        [byte]$B = $pipe.ReadByte();
        while ($B -ne 0x1E){
            $msg_bytes += $B;
            $B = $pipe.ReadByte();
        }
        BytesToString $msg_bytes;
        #Old method2
##        for ($I = 0; $I -lt (($pipe.InBufferSize)/4); $I++)
##            { $msg_bytes += [byte]0x00; }
##        $count = $pipe.Read($msg_bytes,0,$msg_bytes.Length);
##        BytesToString $msg_bytes[0..($count-1)];
        #Old method
#        [byte[]]$size_bytes = 0,0,0,0;
#        for ($i = 0; $i -lt 4; $i++)
#            {$size_bytes[3-$i] = $pipe.ReadByte();}
#        $misc = [Array]::Reverse($size_bytes)
#        $size = [System.BitConverter]::ToInt32($size_bytes,0);
#        [byte[]]$msg_bytes = @();
#        for ($i = 0; $i -lt $size; $i++)
#            {$msg_bytes += $pipe.ReadByte();}
#        BytesToString $msg_bytes;

    }
}

#helper function for writing to the pipe
Function Write-Pipe {
    param(
        [parameter(Mandatory = $true)]
        [System.IO.Pipes.NamedPipeClientStream]$Pipe,
        [parameter(Mandatory = $true, ValueFromPipeline = $true)]
        $msg
    )
    process {
        [byte[]]$temp = StringToBytes ($msg + '^^^DONE^^^');
        if (!$msg)
            {$temp = [byte[]](@([byte]0x0A)) + (StringToBytes '^^^DONE^^^');}
        $Pipe.Write($temp,0,$temp.Length);
    }
}

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
        
        #$up = '$port.Close(); $port.BaudRate = 115200; $port.WriteBufferSize = 4096; $port.ReadBufferSize = 8192; $port.Open();';
        #$up = '$port.Close(); $port.BaudRate = 9600; $port.WriteBufferSize = 16384; $port.ReadBufferSize = 8192; $port.Open();';
        #Write-Pipe $pipe $up;
        
        #Read in the client update script
        $Client_Script = Get-Content .\User_Update.ps1;
        #Send the update script
        foreach ($line in $Client_Script)
            {Write-Pipe $pipe ($line + '
');}
        
        
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

