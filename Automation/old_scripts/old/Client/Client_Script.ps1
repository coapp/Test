#client-side operations script

#give myself a crazy huge screen buffer in case I need it...
$Buff = $host.UI.RawUI.BufferSize;
$Buff.Height = 8000;
$host.UI.RawUI.BufferSize = $Buff;

# Make myself a home so I know where I'll be
Set-Location C:\Scripts;

# Import the functions I need to make my life easier
Import-Module 'C:\Scripts\Common\Byte_String.ps1'
Import-Module 'C:\Scripts\Client\Client_Func.ps1'


#open COM1
$port = New-Object System.IO.Ports.SerialPort COM1;
$port.open();

#announce existance
Write-Port $port 'VM';

#Enter main command loop
while ($true)
{
    #read data until delimiter/EOF reached.  (EOF = '^^^EOF^^^',  end of line = '^^^DONE^^^')
    $run = $true;
    [string]$cmd = ';';
    while ($run)
    {
        if ($cmd.Contains('^^^EOF^^^')){ #did we reach the end of commands? 
                $run = $false;
                "EOF Received...";
            }
        else
        {
            if ($cmd -eq ';') #do I need a new command?
                { 
                    $cmd = $port.ReadTo('^^^DONE^^^');
                    Write-Host -Object $cmd -ForegroundColor Magenta;
                }
            else #no?  then run the command and flag that I need a new one
            {
                Invoke-Expression $cmd;
                $cmd = ';';
            }
        }
        
    }

    #announce completion of the script received (send '^^^TERM^^^')
    Write-Port $port '^^^TERM^^^';
}

