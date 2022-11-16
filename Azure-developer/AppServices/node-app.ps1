$gitrepo="https://github.com/marcelsawicki/WebStore/sportstore"
$webappname="SportStoreApp1"
$location="westeurope"

New-AzResourceGroup -Name myResourceGroup -Location $location

New-AzAppServicePlan -Name $webappname -Location $location -ResourceGroupName myResourceGroup -Tier Standard

New-AzWebApp -Name $webappname -Location $location -AppServicePlan $webappname -ResourceGroupName myResourceGroup

New-AzWebAppSlot -Name $webappname -ResourceGroupName myResourceGroup -Slot review

$PropertiesObject = @{ repoUrl="$gitrepo"; branch="master"; }

Set-AzResource -ProperyObject $PropertiesObject -ResourceGroupName myResourceGroup -ResourceType Microsoft.Web/sites/slots/sourcecontrols -ResourceName $webappname/review/web -ApiVersion 2015-08-01 -Force

Switch-AzWebAppSlot -Name $webappname -ResourceGroupName myResourceGroup -SourceSlotName review -DestinationSlotName production