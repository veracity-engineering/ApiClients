# Veracity API Clients
API client packages generated with AutoRest from [Veracity API portal](https://api-portal.veracity.com/).

# Getting Started
	
```csharp
var client = new DataValidatorApiClient(default);
var schemas = await client.Schema.GetSchemaListAsync(new Guid("workspaceId"));
```