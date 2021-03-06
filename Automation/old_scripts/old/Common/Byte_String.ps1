#Functions for conveniently converting between strings and byte-arrays

Function StringToBytes
{
    param(
        [parameter(Mandatory = $true, ValueFromPipeline = $true)]
        $IN
    )
    process {
        if ($IN -is [System.Array]){
            [byte[]]$out = @();
            foreach ($S in $IN) {
                $out += StringToBytes $S;
            #    [byte[]]$A = [System.Text.Encoding]::ASCII.GetBytes($S);
            #    $A += [byte]0x0A;
            #    $out += $A;
            }
            $out;
        }
        else {
            [System.Text.Encoding]::ASCII.GetBytes($IN);
        }
    }
}

Function BytesToString
{
    param(
        [parameter(Mandatory = $true, ValueFromPipeline = $true)]
        $IN
    )
    process {
        [System.Text.Encoding]::ASCII.GetString($IN);
    }
}

