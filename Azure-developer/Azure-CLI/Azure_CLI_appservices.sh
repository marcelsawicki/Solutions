marcel [ ~ ]$ az group create --location westeurope --name myResourceGroup
{
  "id": "/subscriptions/a926dda8-0e55-4242-80be-77585c5aaaba/resourceGroups/myResourceGroup",
  "location": "westeurope",
  "managedBy": null,
  "name": "myResourceGroup",
  "properties": {
    "provisioningState": "Succeeded"
  },
  "tags": null,
  "type": "Microsoft.Resources/resourceGroups"
}

marcel [ ~ ]$ az appservice plan create --name webapp13 --resource-group myResourceGroup --sku FREE
{
  "elasticScaleEnabled": false,
  "extendedLocation": null,
  "freeOfferExpirationTime": null,
  "geoRegion": "West Europe",
  "hostingEnvironmentProfile": null,
  "hyperV": false,
  "id": "/subscriptions/a926dda8-0e55-4242-80be-77585c5aaaba/resourceGroups/myResourceGroup/providers/Microsoft.Web/serverfarms/webapp13",
  "isSpot": false,
  "isXenon": false,
  "kind": "app",
  "kubeEnvironmentProfile": null,
  "location": "westeurope",
  "maximumElasticWorkerCount": 1,
  "maximumNumberOfWorkers": 0,
  "name": "webapp13",
  "numberOfSites": 0,
  "numberOfWorkers": 0,
  "perSiteScaling": false,
  "provisioningState": "Succeeded",
  "reserved": false,
  "resourceGroup": "myResourceGroup",
  "sku": {
    "capabilities": null,
    "capacity": 0,
    "family": "F",
    "locations": null,
    "name": "F1",
    "size": "F1",
    "skuCapacity": null,
    "tier": "Free"
  },
  "spotExpirationTime": null,
  "status": "Ready",
  "subscription": "a926dda8-0e55-4242-80be-77585c5aaaba",
  "tags": null,
  "targetWorkerCount": 0,
  "targetWorkerSizeId": 0,
  "type": "Microsoft.Web/serverfarms",
  "workerTierName": null,
  "zoneRedundant": false
}

marcel [ ~ ]$ az webapp create --name webapp13app  --resource-group myResourceGroup --plan webapp13
{
  "availabilityState": "Normal",
  "clientAffinityEnabled": true,
  "clientCertEnabled": false,
  "clientCertExclusionPaths": null,
  "clientCertMode": "Required",
  "cloningInfo": null,
  "containerSize": 0,
  "customDomainVerificationId": "E78E79D080456F976BCCD14424397A0130679712BD9177E4112E55C036FF1C2C",
  "dailyMemoryTimeQuota": 0,
  "defaultHostName": "webapp13app.azurewebsites.net",
  "enabled": true,
  "enabledHostNames": [
    "webapp13app.azurewebsites.net",
    "webapp13app.scm.azurewebsites.net"
  ],
  "extendedLocation": null,
  "ftpPublishingUrl": "ftp://waws-prod-am2-389.ftp.azurewebsites.windows.net/site/wwwroot",
  "hostNameSslStates": [
    {
      "hostType": "Standard",
      "ipBasedSslResult": null,
      "ipBasedSslState": "NotConfigured",
      "name": "webapp13app.azurewebsites.net",
      "sslState": "Disabled",
      "thumbprint": null,
      "toUpdate": null,
      "toUpdateIpBasedSsl": null,
      "virtualIp": null
    },
    {
      "hostType": "Repository",
      "ipBasedSslResult": null,
      "ipBasedSslState": "NotConfigured",
      "name": "webapp13app.scm.azurewebsites.net",
      "sslState": "Disabled",
      "thumbprint": null,
      "toUpdate": null,
      "toUpdateIpBasedSsl": null,
      "virtualIp": null
    }
  ],
  "hostNames": [
    "webapp13app.azurewebsites.net"
  ],
  "hostNamesDisabled": false,
  "hostingEnvironmentProfile": null,
  "httpsOnly": false,
  "hyperV": false,
  "id": "/subscriptions/a926dda8-0e55-4242-80be-77585c5aaaba/resourceGroups/myResourceGroup/providers/Microsoft.Web/sites/webapp13app",
  "identity": null,
  "inProgressOperationId": null,
  "isDefaultContainer": null,
  "isXenon": false,
  "keyVaultReferenceIdentity": "SystemAssigned",
  "kind": "app",
  "lastModifiedTimeUtc": "2022-09-02T10:57:31.536666",
  "location": "West Europe",
  "maxNumberOfWorkers": null,
  "name": "webapp13app",
  "outboundIpAddresses": "20.73.237.224,20.73.115.38,20.73.115.185,20.73.115.206,20.73.116.7,20.73.116.58,20.50.2.32",
  "possibleOutboundIpAddresses": "20.73.237.224,20.73.115.38,20.73.115.185,20.73.115.206,20.73.116.7,20.73.116.58,20.73.116.79,20.73.117.20,20.73.118.82,20.73.118.139,20.73.118.226,20.73.118.228,20.73.118.249,20.73.119.14,20.73.119.41,20.73.119.56,20.73.119.89,20.76.58.151,20.76.58.168,20.71.75.130,20.76.58.189,20.76.58.236,20.76.58.243,20.76.59.23,20.76.59.54,20.76.59.65,20.76.59.73,20.71.18.168,20.71.19.104,20.71.19.174,20.50.2.32",
  "publicNetworkAccess": null,
  "redundancyMode": "None",
  "repositorySiteName": "webapp13app",
  "reserved": false,
  "resourceGroup": "myResourceGroup",
  "scmSiteAlsoStopped": false,
  "serverFarmId": "/subscriptions/a926dda8-0e55-4242-80be-77585c5aaaba/resourceGroups/myResourceGroup/providers/Microsoft.Web/serverfarms/webapp13",
  "siteConfig": {
    "acrUseManagedIdentityCreds": false,
    "acrUserManagedIdentityId": null,
    "alwaysOn": false,
    "antivirusScanEnabled": null,
    "apiDefinition": null,
    "apiManagementConfig": null,
    "appCommandLine": null,
    "appSettings": null,
    "autoHealEnabled": null,
    "autoHealRules": null,
    "autoSwapSlotName": null,
    "azureMonitorLogCategories": null,
    "azureStorageAccounts": null,
    "connectionStrings": null,
    "cors": null,
    "customAppPoolIdentityAdminState": null,
    "customAppPoolIdentityTenantState": null,
    "defaultDocuments": null,
    "detailedErrorLoggingEnabled": null,
    "documentRoot": null,
    "elasticWebAppScaleLimit": 0,
    "experiments": null,
    "fileChangeAuditEnabled": null,
    "ftpsState": null,
    "functionAppScaleLimit": null,
    "functionsRuntimeScaleMonitoringEnabled": null,
    "handlerMappings": null,
    "healthCheckPath": null,
    "http20Enabled": false,
    "http20ProxyFlag": null,
    "httpLoggingEnabled": null,
    "ipSecurityRestrictions": [
      {
        "action": "Allow",
        "description": "Allow all access",
        "headers": null,
        "ipAddress": "Any",
        "name": "Allow all",
        "priority": 2147483647,
        "subnetMask": null,
        "subnetTrafficTag": null,
        "tag": null,
        "vnetSubnetResourceId": null,
        "vnetTrafficTag": null
      }
    ],
    "ipSecurityRestrictionsDefaultAction": null,
    "javaContainer": null,
    "javaContainerVersion": null,
    "javaVersion": null,
    "keyVaultReferenceIdentity": null,
    "limits": null,
    "linuxFxVersion": "",
    "loadBalancing": null,
    "localMySqlEnabled": null,
    "logsDirectorySizeLimit": null,
    "machineKey": null,
    "managedPipelineMode": null,
    "managedServiceIdentityId": null,
    "metadata": null,
    "minTlsCipherSuite": null,
    "minTlsVersion": null,
    "minimumElasticInstanceCount": 0,
    "netFrameworkVersion": null,
    "nodeVersion": null,
    "numberOfWorkers": 1,
    "phpVersion": null,
    "powerShellVersion": null,
    "preWarmedInstanceCount": null,
    "publicNetworkAccess": null,
    "publishingPassword": null,
    "publishingUsername": null,
    "push": null,
    "pythonVersion": null,
    "remoteDebuggingEnabled": null,
    "remoteDebuggingVersion": null,
    "requestTracingEnabled": null,
    "requestTracingExpirationTime": null,
    "routingRules": null,
    "runtimeADUser": null,
    "runtimeADUserPassword": null,
    "scmIpSecurityRestrictions": [
      {
        "action": "Allow",
        "description": "Allow all access",
        "headers": null,
        "ipAddress": "Any",
        "name": "Allow all",
        "priority": 2147483647,
        "subnetMask": null,
        "subnetTrafficTag": null,
        "tag": null,
        "vnetSubnetResourceId": null,
        "vnetTrafficTag": null
      }
    ],
    "scmIpSecurityRestrictionsDefaultAction": null,
    "scmIpSecurityRestrictionsUseMain": null,
    "scmMinTlsVersion": null,
    "scmType": null,
    "sitePort": null,
    "storageType": null,
    "supportedTlsCipherSuites": null,
    "tracingOptions": null,
    "use32BitWorkerProcess": null,
    "virtualApplications": null,
    "vnetName": null,
    "vnetPrivatePortsCount": null,
    "vnetRouteAllEnabled": null,
    "webSocketsEnabled": null,
    "websiteTimeZone": null,
    "winAuthAdminState": null,
    "winAuthTenantState": null,
    "windowsFxVersion": null,
    "xManagedServiceIdentityId": null
  },
  "slotSwapStatus": null,
  "state": "Running",
  "storageAccountRequired": false,
  "suspendedTill": null,
  "tags": null,
  "targetSwapSlot": null,
  "trafficManagerHostNames": null,
  "type": "Microsoft.Web/sites",
  "usageState": "Normal",
  "virtualNetworkSubnetId": null,
  "vnetContentShareEnabled": false,
  "vnetImagePullEnabled": false,
  "vnetRouteAllEnabled": false
}


Examples from AI knowledge base:
az webapp deployment source config --branch master --manual-integration --name MyWebApp --repo-url https://github.com/Azure-Samples/function-image-upload-resize --resource-group MyResourceGroup
Manage deployment from git or Mercurial repositories. (autogenerated)

az webapp deployment source config --branch master --manual-integration --name MyWebApp --repo-url https://github.com/Azure-Samples/function-image-upload-resize --resource-group MyResourceGroup --slot staging
Manage deployment from git or Mercurial repositories. (autogenerated)

https://docs.microsoft.com/en-US/cli/azure/webapp/deployment/source#az_webapp_deployment_source_config
Read more about the command in reference docs


marcel [ ~ ]$ az webapp deployment source config --name webapp13app --resource-group myResourceGroup --repo-url "https://github.com/marcelsawicki/WebStore" --branch master --manual-integration
Repository 'GetSiteSourceControl' operation failed with System.Net.WebException: The remote server returned an error: (403) Forbidden.
   at System.Net.HttpWebRequest.EndGetResponse(IAsyncResult asyncResult)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.Web.Hosting.Administration.Utilities.WebRequestHelper.<GetResponseAsyncWithTimeout>d__9.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.Web.Hosting.Administration.SiteRepositoryProvider.TrackerContext.<GetResponseAsync>d__41.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.Web.Hosting.Administration.SiteRepositoryProvider.<GetSettingAsync>d__32.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.Web.Hosting.Administration.ExternalSiteRepositoryProvider.<GetSiteSourceControl>d__4.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.Web.Hosting.Administration.WebCloudController.<>c__DisplayClass325_0.<<GetSiteSourceControl>b__0>d.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.Web.Hosting.AsyncHelper.RunSync[TResult](Func`1 func)
   at Microsoft.Web.Hosting.Administration.WebCloudController.GetSiteSourceControl(String subscriptionName, String webspaceName, String name).
   
   
marcel [ ~ ]$ az webapp deployment user set --user-name marcelsawicki --password ********
{
  "id": null,
  "kind": null,
  "name": "web",
  "publishingPassword": null,
  "publishingPasswordHash": null,
  "publishingPasswordHashSalt": null,
  "publishingUserName": "marcelsawicki",
  "scmUri": null,
  "type": "Microsoft.Web/publishingUsers/web"
}


marcel [ ~ ]$ az webapp deployment source config --name webapp13app --resource-group myResourceGroup --repo-url "https://github.com/marcelsawicki/WebStore" --branch master --manual-integration
{
  "branch": "master",
  "deploymentRollbackEnabled": false,
  "gitHubActionConfiguration": null,
  "id": "/subscriptions/a926dda8-0e55-4242-80be-77585c5aaaba/resourceGroups/myResourceGroup/providers/Microsoft.Web/sites/webapp13app/sourcecontrols/web",
  "isGitHubAction": false,
  "isManualIntegration": true,
  "isMercurial": false,
  "kind": null,
  "location": "West Europe",
  "name": "webapp13app",
  "repoUrl": "https://github.com/marcelsawicki/WebStore",
  "resourceGroup": "myResourceGroup",
  "type": "Microsoft.Web/sites/sourcecontrols"
}