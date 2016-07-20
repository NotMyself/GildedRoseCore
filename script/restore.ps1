Get-ChildItem ./src/ -r -depth 5 |
    Where-Object { $_.FullName -match 'project\.json$' } |
    ForEach-Object { dotnet restore $_.DirectoryName }