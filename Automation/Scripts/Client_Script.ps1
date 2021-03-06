#client-side operations script

#give myself a crazy huge screen buffer in case I need it...
$Buff = $host.UI.RawUI.BufferSize;
$Buff.Height = 8000;
$host.UI.RawUI.BufferSize = $Buff;

# Make myself a home so I know where I'll be
Set-Location C:\Scripts;

# Download the latest copy of the communication commandlets and import them.
$Web = new-object System.Net.WebClient;
$URL = 'http://virmitio.com/Scripts/CommonLib.dl_';
$Web.DownloadFile($URL,('C:\Scripts\CommonLib.dll'));
$URL = 'http://virmitio.com/Scripts/ClientLib.dl_';
$Web.DownloadFile($URL,('C:\Scripts\ClientLib.dll'));

Write-Host -Object 'Update complete...' -ForegroundColor Yellow;

# Import the functions I need to make my life easier
Import-Module 'C:\Scripts\CommonLib.dll';
Import-Module 'C:\Scripts\ClientLib.dll';

# Open COM2
Initialize-Port COM2

# Set a debug variable so I can enable/disable logging remotely
$isDebug = $true;

#announce existance
Write-Port 'VM';

#Enter main command loop
while ($true)
{
    $CommandString = '';
    #read data until delimiter/EOF reached.  (EOF = '^^^EOF^^^',  end of line = '^^^DONE^^^')
    $run = $true;
    [string]$cmd = ';';
    while ($run)
    {
        if ($cmd.Contains('^^^EOF^^^')){ #did we reach the end of commands? 
                $run = $false;
                "EOF Received.  Running recieved commands...";
                Invoke-Expression $CommandString;
            }
        else
        {
            if ($cmd -eq ';') #do I need a new command?
                { 
                    $cmd = Read-Port;
                    if ($isDebug)
                        { Write-Host -Object $cmd -ForegroundColor Magenta; }
                }
            else #no?  then run the command and flag that I need a new one
            {
                $CommandString += $cmd;
                $cmd = ';';
            }
        }
        
    }

    #announce completion of the script received (send '^^^TERM^^^')
    Write-Port '^^^TERM^^^';
}

