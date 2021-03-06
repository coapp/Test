Function Get-WmiNameSpace($namespace, $computer)
{
 Get-WmiObject -class __NameSpace -computer $computer -namespace $namespace -ErrorAction "SilentlyContinue" |
 Foreach-Object -Process {
   $subns = Join-Path -Path $_.__namespace -ChildPath $_.name
   $subns
   $script:i ++
   Get-WmiNameSpace -namespace $subNS -computer $computer
 }
}

$script:i = 0
$namespace = "root"
$computer = "LocalHost"
"Obtaining WMI Namespaces from $computer ..."
Get-WmiNameSpace -namespace $namespace -computer $computer
"There are $script:i namespaces on $computer."
