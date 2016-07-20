Push-Location ./src/GildedRoseCore.Console/
try 
{
    dotnet run  | Write-Output
}
finally 
{
    Pop-Location
}