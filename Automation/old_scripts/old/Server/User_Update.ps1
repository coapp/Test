#Script to have clients auto-update to current script versions and reload them

$Web = new-object System.Net.WebClient;
$URL = 'http://virmitio.com/Scripts/Common/Byte_String.ps1';
$Web.DownloadFile($URL,('C:\Scripts\Common\Byte_String.ps1'));
$URL = 'http://virmitio.com/Scripts/Client/Client_Func.ps1';
$Web.DownloadFile($URL,('C:\Scripts\Client\Client_Func.ps1'));


Import-Module 'C:\Scripts\Common\Byte_String.ps1'
Import-Module 'C:\Scripts\Client\Client_Func.ps1'

Write-Output 'Update Complete...'
