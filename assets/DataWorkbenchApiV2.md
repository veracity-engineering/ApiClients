# Data Workbench API v2


```yaml

input-file: DataWorkbenchApiV2.json

use-extension:
  '@cuteribs/autorest.csharp': latest

csharp: 
  namespace: DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2
  override-client-name: DataWorkbenchApiV2Client
  output-folder: ../src/DNV.ApiClients.Veracity.DataPlatform.DataWorkbenchApiV2
  clear-output-folder: true

directive:
- from: openapi-document
  debug: true
  where: $.paths..[?(@.operationId=='Schemas_GetSchemaVersionById')]
  transform: |
    $.responses['200'].content = {"application/json": {"schema": {"$ref": "#/components/schemas/SchemaVersionReadDto"}}};

```