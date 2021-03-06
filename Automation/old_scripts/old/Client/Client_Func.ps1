
#function for writing strings to a serial port
#
# packet format is:  [value] -                   [desc]                         -  [size]
#                       n    -  size of message byte array, in bytes            -  4 bytes
#                       m    -  message byte array                              -  n bytes
Function Write-Port
{
    param(
        [parameter(Mandatory = $true)]
        [System.IO.Ports.SerialPort]$Port,
        [parameter(Mandatory = $true, ValueFromPipeline = $true)]
        $String
    )
    process {
        if ($String -is [System.Array]){
            foreach ($s in $String){
                Write-Port $Port ([string]$s+'
');
            }
        }
        else{
            $temp = StringToBytes $String;
#            if ($temp.Length -gt ($Port.WriteBufferSize / 2)) {
#                Write-Port $Port ($String[0..(($String.Length / 2)-1)]);
#                Write-Port $Port ($String[($String.Length / 2)..($String.Length - 1)]);
#            }
#            else {
                if (!$String)
                    {$temp = [byte[]](@([byte]0x0A));}
#                else
                $temp += @([byte]0x1E);
                #$Port.Write([byte[]]$temp,0,$temp.Length);
                foreach ($B in $temp)
                    {
                        [byte[]]$data = {[byte]$B};
                        $Port.Write([byte[]]$Data,0,1);
                        Start-Sleep -m 2;
                    }
#            }
        }
    }
}

