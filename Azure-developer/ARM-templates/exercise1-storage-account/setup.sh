az login
az group create --name az204-arm-rg --location "westeurope"   
az  deployment group create --resource-group az204-arm-rg --template-file azuredeploy.json --parameters azuredeploy.parameters.json
az storage account show --resource-group az204-arm-rg --name az204storcctarm123acdfg
az group delete --name az204-arm-rg --no-wait