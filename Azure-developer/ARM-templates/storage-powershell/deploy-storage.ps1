$rg='arm-introduction-01'
New-AzResourceGroup -Name $rg -Location northeurope -Force

New-AzResourceGroupDeployment -Name 'storage1s' -ResourceGroupName $rg -TemplateFile '01-storage.json'