Import-Module WebAdministration

$CurrentPath = "C:\Deployments\Current"
$BackupRoot = "C:\Deployments\Backups"
$AppPoolName = "EmployeeManagementPool"

$LatestBackup = Get-ChildItem $BackupRoot -Directory |
                Sort-Object Name -Descending |
                Select-Object -First 1

if ($null -eq $LatestBackup) {
    Write-Host "No backup found."
    exit 1
}

$BackupPath = $LatestBackup.FullName

Write-Host "===================================="
Write-Host "Starting Rollback Process..."
Write-Host "Current Path : $CurrentPath"
Write-Host "Backup Path  : $BackupPath"
Write-Host "App Pool     : $AppPoolName"
Write-Host "===================================="

Write-Host "Stopping IIS Application Pool..."
Stop-WebAppPool -Name $AppPoolName
Start-Sleep -Seconds 5

Write-Host "Removing current deployment files..."
Remove-Item "$CurrentPath\*" -Recurse -Force

Write-Host "Restoring previous version from backup..."
Copy-Item "$BackupPath\*" "$CurrentPath" -Recurse -Force

Write-Host "Starting IIS Application Pool..."
Start-WebAppPool -Name $AppPoolName
Start-Sleep -Seconds 5
Write-Host "Validating application after rollback..."

$response = Invoke-WebRequest "http://localhost:8080" -UseBasicParsing

if ($response.StatusCode -eq 200) {
    Write-Host "Rollback completed successfully."
}
else {
    Write-Host "Rollback validation failed."
    exit 1
}