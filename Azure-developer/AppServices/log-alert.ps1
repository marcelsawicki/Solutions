$source = New-AzScheduledQueryRuleSource -Query 'Heartbeat | where TimeGenerated > age(1h)' -DataSourceId "contonso"

$schedule = New-AzScheduledQueryRuleSchedule -FrequencyInMinutes 60 -TimeWindowInMinutes 60

$triggerCondition = New-AzScheduledQueryRuleTriggerCondition -ThreshholdOperator "LessThan" -Threshold 5

$aznsActionGroup = New-AzScheduledQueryRuleAznsActionGroup -ActionGroup "contonso" -EmailSubject "Custom email subject" -CustomWebhookPayload "{ 'alert': '#alertrulename', 'IncludeSearchResults': 'true' }"

$alertingAction = New-AzScheduledQueryRuleAlertingAction -AznsAction $aznsActionGroup -Severity "3" -Trigger $triggerCondition


New-AzScheduledQueryRule -ResourceGroupName "contonso" -Location "eastus" -Action $alertingAction -Enabled $true -Description "Alert description" -Schedule $schedule -Source $source -Name "Alert Name"