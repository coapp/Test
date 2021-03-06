
#function for writing strings to a serial port
#
# packet format is:  [value] -                   [desc]                         -  [size]
#                       k    -  size of (size of message byte array), in bytes  -  1 byte
#                       n    -  size of message byte array, in bytes            -  k bytes
#                       m    -  message byte array                              -  n bytes
Function Write-Port
{
    param(
        [parameter(Mandatory = $true)]
        [System.IO.Ports.SerialPort]$Port,
        [parameter(Mandatory = $true)]
        [string]$String
    )
    process {
        [byte[]]$temp = StringToBytes $String;
        $size = $temp.Length;
        [byte[]]$size_bytes = [System.BitConverter]::GetBytes($size);
        [byte]$sos = $size_bytes.Length;
        $Port.Write($sos,0,1);
        $Port.Write($size_bytes,0,$sos);
        $Port.Write($temp);
    }
}

