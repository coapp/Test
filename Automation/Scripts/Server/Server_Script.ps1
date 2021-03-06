#Server script for running tests

$Devs = Import-Csv .\Dev_VMs.csv;
$Clients = Import-Csv .\Client_VMs.csv;

$date = Get-Date;
$path = ((pwd).Path+'\'+$date.Month+'-'+$date.Day+'-'+$date.Year);
New-Item -type directory -path $path



#Do everything on the Dev VMs first (like building the software)
foreach ($D in $Devs) {
    $arg = @();
    $arg += $D.VM_Name;
    $arg += $D.Base_VHD;
    $arg += $D.Script_File;
    $arg += $D.Mem;
    $arg += $D.CPU_Count;
    $arg += $D.CPU_Limit;
    $arg += $path;
    Start-Job -FilePath .\Server_Job.ps1 -ArgumentList $arg;
}

#Perform all client-side actions
##foreach ($C in $Clients) {
#    $cmd = "Run-Test -Name $($C.VM_Name) -Base $($C.Base_VHD) -Script $($C.Script_File) -mem $($C.Mem) -CPU $($C.CPU_Count) -Limit $($C.CPU_Limit) -Out_Path $path";
#    Invoke-Expression $cmd;
##    $arg = @();
##    $arg += $C.VM_Name;
##    $arg += $C.Base_VHD;
##    $arg += $C.Script_File;
##    $arg += $C.Mem;
##    $arg += $C.CPU_Count;
##    $arg += $C.CPU_Limit;
##    $arg += $path;
##    Start-Job -FilePath .\Server_Job.ps1 -ArgumentList $arg;
##}

