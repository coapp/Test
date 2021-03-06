#Script to download, build, and perform initial tests on the CoApp codebase.

#$isDebug = $False;

$path_root = "C:\CoApp-TestRun";
$CoApp_root = $path_root+"\CoApp";
New-Item -type directory -path $CoApp_root;
#The VMs have been taking longer than expected to collect their IP addresses
Start-Sleep -s 2;
$Web = new-object System.Net.WebClient;
$URL = "http://virmitio.com/coapp_read-only.txt";
$Web.DownloadFile($URL,($CoApp_root+"\coapp-src.cmd"));

Set-Location $CoApp_root;
.\coapp-src.cmd all;
####.\coapp-src.cmd test;


##### [kill mkSpec and mkProject]  Remove this area when these projects are fixed.
#####
Remove-Item -Path ($CoApp_root+"\solution\coapp-tools.sln") -Force;
$URL = "http://virmitio.com/coapp-tools.sln";
$Web.DownloadFile($URL,($CoApp_root+"\solution\coapp-tools.sln"));
#####
##### END [kill mkSpec and mkProject]


#Find MSBuild.exe
$CC = Get-ChildItem -path ((Get-Item -path env:systemroot).Value + "\Microsoft.NET\Framework64\v4.*") -recurse -include msbuild.exe
if (!$CC) 
{ #If we didn't find it...
    $CC = Get-ChildItem -path ((Get-Item -path env:systemroot).Value + "\Microsoft.NET\Framework\v4.*") -recurse -include msbuild.exe
    if (!$CC) 
    { #If we STILL didn't find it...
        eventcreate /l Application /so "Build Script" /t Error /id 500 /d "Unable to locate MSBuild.exe.  Should be in a subdirectory of ((Get-Item -path env:systemroot).Value + "\Microsoft.NET\")"
        Write-Port 'Unable to locate MSBuild.exe.
Build script is halting with errors.
'
        return # Didn't find the build command.  Bail out.
    }
}

#invoke the actual build process
Write-Output '+++ Beginning main build...
';
Write-Port '+++ Beginning main build...
';
Invoke-Expression ($CC.ToString()+" "+$CoApp_root+"\solution\coapp-tools.sln > .\Build.txt 2>&1");
$output = Get-Content .\Build.txt;
foreach ($S in $output)
{
    [byte]$B = 0x0A;
    if ($S -eq "")
        {Write-Port -Byte $B;}
    else
        {Write-Port $S;}
}

#build the test suite
####Write-Port $port '+++ Beginning Test build...
####';
####Invoke-Expression ($CC.ToString()+" /property:SolutionDir="+$CoApp_root+"\solution\ "+$CoApp_root+"\Test\CoApp\Toolkit\Test.CoApp.Toolkit.csproj  > .\Test_build.txt 2>&1")
####Get-Content .\Test_build.txt | Write-Port $port;




