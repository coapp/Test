#Script file for performing the inner jobs on the server

Set-Location C:\Tim_scripts\Server

if (!(Get-Module CoApp_Tests))
{Import-Module '.\CoApp_Tests.psd1'}

Run-Test -Name $args[0] -Base $args[1] -Script $args[2] -mem $args[3] -CPU $args[4] -Limit $args[5] -Out_Path $args[6];
