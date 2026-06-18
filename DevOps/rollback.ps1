Import-Module WebAdministration

$CurrentPath = "C:\Deployments\Current"
$BackupPath = "C:\Deployments\Backups\$env:PREVIOUS_VERSION"
$AppPoolName = "EmployeeManagementPool"

Write-Host "===================================="
Write-Host "Starting Rollback Process..."
Write-Host "Current Path : $CurrentPath"
Write-Host "Backup Path  : $BackupPath"
Write-Host "App Pool     : $AppPoolName"
Write-Host "===================================="

Write-Host "Stopping IIS Application Pool..."
Stop-WebAppPool -Name $AppPoolName