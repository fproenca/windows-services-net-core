# Project .Net Core Worker run as Windows Services

Build:

dotnet publish -r win-x64 -c Release [--self-contained] -o <destination_path>

Install service via PowerShell:

New-Service -Name <service_name> -Path <exe_path>

Start-Service -Name <service_name>

Get-Service -Name <service_name>
