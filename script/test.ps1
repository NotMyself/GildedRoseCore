Get-ChildItem ./src/ -r -depth 5 |
    Where-Object {$_.DirectoryName -like "*Tests" } |
    Where-Object { $_.FullName -match 'project\.json$' } |
    ForEach-Object { dotnet test $_.DirectoryName }