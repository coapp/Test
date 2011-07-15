#Server script for running tests
if (!(Get-Module CoApp_Tests))
{Import-Module '.\CoApp_Tests.psd1'}

#helper function to receive the next designated packet from the client
Function Server_Read
{
    param(
        [parameter(Mandatory = $true)]
        $pipe
    )
    process {
        $sos = $pipe.ReadByte();
        [byte[]]$size_bytes = 0,0,0,0,0,0,0,0;
        for ($i = 0; i -lt $sos; i++)
            {$size_bytes[8-$i] = $pipe.ReadByte();}
#        $misc = $pipe.Read($size_bytes,8-$sos,$sos);
        $misc = [Array]::Reverse($size_bytes)
        $size = [System.BitConverter]::ToInt64($size_bytes,0);
        [byte[]]$msg_bytes = @();
        for ($i = 0; $i -lt $size; $i++)
            {$msg_bytes += $pipe.ReadByte();}
        BytesToString $msg_bytes;
    }
}

Function Write-Pipe
{
    param(
        [parameter(Mandatory = $true)]
        [System.IO.Pipes.NamedPipeClientStream]$Pipe,
        [parameter(Mandatory = $true)]
        [string]$String
    )
    process {
        [byte[]]$temp = StringToBytes ($String + '^^^EOF^^^');
        $Pipe.Write($temp,0,$temp.Length);
    }
}

$VM = Provision-VM -Name "TempTestVM" -VHD ((Get-VhdDefaultPath)+"\base\Win7-HomeBasic-base.vhd") -CPU_max 50

Start-VM $VM; # Start up the VM.

$pipe = New-Object system.IO.Pipes.NamedPipeClientStream($tmp.VMElementName+"_IO_Pipe"); # Attach a new stream to the pipe called '<VM-Name>_IO_Pipe'
$pipe.Connect(); # Need to remember to actually connect to the pipe before using it...

$msg = Server_Read $pipe;


