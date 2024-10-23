# Veracity platform api v4


```yaml

input-file: PlatformApiV4.json

use-extension:
  '@cuteribs/autorest.csharp': latest

csharp: 
  namespace: DNV.ApiClients.Veracity.Identity.PlatformApiV4
  override-client-name: PlatformApiV4Client
  output-folder: ../src/DNV.ApiClients.Veracity.Identity.PlatformApiV4
  clear-output-folder: true

directive:
- from: openapi-document
  debug: false
  where: $.paths.*.*
  transform: |
    if($['operationId'].indexOf('.') > 1) {
      $['operationId'] = $['tags'][0] + '_' + $['operationId'].split('.')[1];
    }
- from: openapi-document
  debug: false
  where: $.components.schemas
  transform: |
    for(const key of Object.keys($)) {
      if(key.indexOf('.') > 0) {
        const newKey = key.split('.').pop();
        $[newKey] = $[key];
        $[key] = undefined;
      }
    }
- from: openapi-document
  debug: false
  where: $..*[?(@.$ref)]
  transform: |
    const ref = $['$ref'];
    const index = ref.indexOf('#/components/schemas/') + 21;
    const prefix = ref.substring(0, index);
    const schemaId = ref.substring(index);
    if(schemaId.indexOf('.') > 0) {
      const newRef = schemaId.split('.').pop();
      $['$ref'] = prefix + newRef;
    }
```