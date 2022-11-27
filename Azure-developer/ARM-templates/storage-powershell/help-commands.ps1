
Install-Module Az -AllowClobber
Get-InstalledModule
Connect-AzAccount

(Get-AzLog -CorrelationId 2c9ff0ac-0a43-4676-ac16-ce93fc8d0945).Properties.Content.Values

.\deploy-storage.ps1