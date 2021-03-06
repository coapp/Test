
#VHD fork routine
Function Fork-VHD
{
    param(
        [parameter(Mandatory = $true, ValueFromPipeline = $true)]
        $Base,
        [parameter(Mandatory = $true)]
        $Child
    )
    process {
        $VHD_Service =  Get-WmiObject -Namespace ROOT\virtualization -Query "Select * from Msvm_ImageManagementService";
        $VHD_Service.CreateDifferencingVirtualHardDisk($Child, $Base);
    }
}

#Provisions a new VM and returns the VM object
Function Provision-VM
{
    param(
        [parameter(Mandatory = $true)]
        [string]$Name, #Name of new VM
        [parameter(Mandatory = $true)]
        [string]$VHD, #Source VHD to base the new VM on
        
        [long]$Mem=1GB, #Amount of RAM for the VM.  Please include MB or GB when passing.  Will default to 1GB.
        [int][validateRange(1,4)]$CPU=1, #Number of CPUs to assign to the VM.  Will default to 1.
        [int][validateRange(1,100)]$CPU_max=100 #Maximum allowed percentage of assigned CPU cycles to use.  Will default to 100.
    )
    process {
        $tmp = New-VM -Name $Name; # Make a new VM and save the reference to it.
        $VOID = Set-VMMemory $tmp $Mem; # Assign 1GB of RAM to the new VM.
        $VOID = Set-VMCPUCount $tmp $CPU ($CPU_max * 1000); # Give the new VM 1 processor, and limit the VM to only 100% of that processor.  (100000 == 100.000%)
        # old method was 'copy'
        #copy ((Get-VhdDefaultPath)+'\base\'+$VHD) ((Get-VhdDefaultPath)+'\'+$Name+".vhd") -Force; # Copy the base HD image into the working directory, overwriting if necessary.
        Fork-VHD ((Get-VhdDefaultPath)+'\base\'+$VHD) ((Get-VhdDefaultPath)+'\'+$Name+'.vhd');
        $VOID = Add-VMDisk $tmp 0 0 ((Get-VhdDefaultPath)+'\'+$Name+".vhd"); # Attach the copied drive to the VM.
        Add-Type -AssemblyName system.core; # Add the .NET assembley we need to work with named pipes.
        $VOID = Set-VMSerialPort $tmp 2 ("\\.\pipe\"+$tmp.VMElementName+"_IO_Pipe"); # Make a new pipe and attach it to the VM on COM1
        $VOID = Add-VMNIC $tmp "External #1" -Legacy; # Add the NIC for internet access (Legacy to support the Home OS's).
        $tmp;
    }
}

#Provisions a new VM and returns the VM object
Function Unprovision-VM
{
    param(
        [parameter(Mandatory = $true)]
        $VM
        )
    process{
        if ($VM -is [String]) { $VM = Get-VM -Name $VM -Server .}
        Stop-VM $VM -force;
        Start-Sleep -s 5;
        Remove-Item ((Get-VhdDefaultPath)+'\'+($VM.ElementName)+".vhd") -Force;
        Remove-VM $VM -Force;
    }
}
