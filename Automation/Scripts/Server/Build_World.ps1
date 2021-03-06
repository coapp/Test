#Script to download, build, and perform initial tests on the CoApp codebase.

$path_root = "C:\CoApp-TestRun";
$CoApp_root = $path_root+"\CoApp";
New-Item -type directory -path $CoApp_root;
$Web = new-object System.Net.WebClient;
$URL = "https://github.com/downloads/fearthecowboy/coapp/coapp-src.cmd";
$Web.DownloadFile($URL,($CoApp_root+"\coapp-src.cmd"));
Set-Location $CoApp_root;
.\coapp-src.cmd all;
.\coapp-src.cmd test;

#Find MSBuild.exe
$CC = Get-ChildItem -path ((Get-Item -path env:systemroot).Value + "\Microsoft.NET\Framework64\v4.*") -recurse -include msbuild.exe
if (!$CC) 
{ #If we didn't find it...
    $CC = Get-ChildItem -path ((Get-Item -path env:systemroot).Value + "\Microsoft.NET\Framework\v4.*") -recurse -include msbuild.exe
    if (!$CC) 
    { #If we STILL didn't find it...
        eventcreate /l Application /so "Build Script" /t Error /id 500 /d "Unable to locate MSBuild.exe.  Should be in a subdirectory of ((Get-Item -path env:systemroot).Value + "\Microsoft.NET\")"
        return # Didn't find the build command.  Bail out.
    }
}

#invoke the actual build process
Invoke-Expression ($CC.ToString()+" "+$CoApp_root+"\solution\coapp-tools.sln")



#build the test suite
Invoke-Expression ($CC.ToString()+" "+$CoApp_root+"\solution\coapp-tools-test.sln")
