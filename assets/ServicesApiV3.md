# Veracity platform service V3


```yaml

input-file: ServicesApi.json

use-extension:
  '@cuteribs/autorest.csharp': latest

csharp: 
  namespace: DNV.ApiClients.Veracity.Identity.ServicesApiV3
  override-client-name: ServicesApiV3Client
  output-folder: src/DNV.ApiClients.Veracity.Identity.ServicesApiV3
  clear-output-folder: true

directive:
- from: openapi-document
  debug: false
  where: $.components.schemas["Veracity.TenantManagement.Models.Requests.AffiliationTypes"]
  transform: |
    $.type = "string"
- from: openapi-document
  debug: false
  where: $.paths.*.*
  transform: |
    $.operationId = $.operationId.split('.')[1] ?? $.operationId
- from: openapi-document
  debug: false
  where: $..["$ref"]
  transform: |
    if ($.lastIndexOf('.') > $.lastIndexOf('/')) {
      const startIndex = $.lastIndexOf('#') + 1;
      let path = $.substring(startIndex);
      path = path.substring(0, path.lastIndexOf('/') + 1) + path.substring(path.lastIndexOf('.') + 1);
      $ = $.substring(0, startIndex) + path.split('_').join('U');
    }
- from: openapi-document
  where: $.components.schemas
  debug: false
  transform: |
    const keys = Object.keys($);
    for(const key of keys) {
      if(!key.includes('.')) continue;
      const newKey = key.substring(key.lastIndexOf('.') + 1).split('_').join('U');
      $[newKey] = $[key];
      delete $[key];
    }
- from: openapi-document
  debug: true
  where: $.paths.*.*
  transform: |
    const tag = $.tags[0];
    $.operationId = `${tag}_${$.operationId}`;

```