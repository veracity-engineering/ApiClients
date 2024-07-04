# Veracity platform service V3


```yaml

input-file: ServicesApiV3.json

use-extension:
  '@cuteribs/autorest.csharp': latest

csharp: 
  namespace: DNV.ApiClients.Veracity.Identity.ServicesApiV3
  override-client-name: ServicesApiV3Client
  output-folder: ../src/DNV.ApiClients.Veracity.Identity.ServicesApiV3
  clear-output-folder: true

directive:
- from: swagger-document
  debug: false
  where: $
  transform: |
    $['consumes'] = ['application/json']
    $['produces'] = ['application/json']
- from: swagger-document
  debug: false
  where: $.paths.*[?(@.key!='parameters')]
  transform: |
    delete $['consumes']
    delete $['produces']
- from: swagger-document
  debug: false
  where: $.paths..responses
  transform: |
    const keys = Object.keys($);
    for(const key of keys) {
      console.log(key);
      if(parseInt(key) > 300) delete $[key];
    }
```