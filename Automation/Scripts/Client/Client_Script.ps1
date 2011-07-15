#client-side operations script

# Make myself a home so I know where I'll be
New-Item -Type Directory -Path 'C:\Scripts\Run';
Set-Location C:\Scripts\Run;

# Import the functions I need to make my life easier
Import-Module '..\Common\Byte_String.ps1'
Import-Module '..\Client\Client_Func.ps1'


#open COM1
$port = New-Object System.IO.Ports.SerialPort COM1;
$port.open();

#announce existance
Write-Port $port 'VM';

#Enter main command loop
while ($true)
{
    #read data until delimiter/EOF reached.  (EOF = '^^^EOF^^^',  end of command = '^^^DONE^^^')
    $run = $true;
    $cmd = ';';
    while ($run)
    {
        if ($cmd -eq '^^^EOF^^^') #did we reach the end of commands?
            { $run = $false; }
        else
        {
            if ($cmd -eq ';') #do I need a new command?
                { $cmd = $port.ReadTo('^^^DONE^^^'); }
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

