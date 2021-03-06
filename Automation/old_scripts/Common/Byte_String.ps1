#Functions for conveniently converting between strings and byte-arrays

Function StringToBytes
{
    param(
        [parameter(Mandatory = $true, ValueFromPipeline = $true)]
        $IN
    )
    process {
        [System.Text.Encoding]::ASCII.GetBytes($IN);
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

