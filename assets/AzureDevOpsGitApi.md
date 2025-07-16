# Azure DevOps Git Api


```yaml

input-file: AzureDevOpsGitApi.json

use-extension:
  '@cuteribs/autorest.csharp': latest

csharp: 
  namespace: DNV.ApiClients.Veracity.AzureDevOps.GitApi
  override-client-name: AzureDevOpsGitApiClient
  output-folder: ../src/DNV.ApiClients.Veracity.AzureDevOps.GitApi
  clear-output-folder: true

#directive:
```