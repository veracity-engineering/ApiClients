<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main(string[] args)
{
	var filePath = args?[0];
	var text = await File.ReadAllTextAsync(filePath);
	var json = JObject.Parse(text);
	var tokensRemovalList = new List<JToken>();

	#region adjust operation Id format

	foreach (var operationId in json.SelectTokens("$.paths..operationId"))
	{
		(operationId.Parent as JProperty).Value = operationId.Value<string>().Replace("v1-0", string.Empty);
	}

	#endregion adjust operation Id format
	
	#region add x-ms-enum
	
	foreach(var contentType in json.SelectTokens("$.components.schemas.*.enum"))
	{
		var obj = contentType.Parent.Parent as JObject;

		if (obj == null || obj.Properties().Any(p => p.Name == "x-ms-enum")) continue;

		var objName = ((JProperty)obj.Parent).Name;
		obj.Add(
			new JProperty("x-ms-enum", 
				new JObject(
					new JProperty("name", objName),
					new JProperty("modelAsString", false)
				)
			)
		);
	}
	
	#endregion add x-ms-enum

		#region remove unneccesary content types

		foreach (var contentType in json.SelectTokens("$.paths..requestBody.content.*"))
		{
			if ((contentType.Parent as JProperty).Name != "application/json") tokensRemovalList.Add(contentType.Parent);
		}

		foreach (var contentType in json.SelectTokens("$.paths..responses.*.content.*"))
		{
			if ((contentType.Parent as JProperty).Name != "application/json") tokensRemovalList.Add(contentType.Parent);
		}

		#endregion remove unneccesary content types

		#region remove error responses

		foreach (var contentType in json.SelectTokens("$.paths..responses.*"))
		{
			var propertyName = (contentType.Parent as JProperty).Name;

			if (propertyName == "default" || propertyName[0] == '4' || propertyName[0] == '5') tokensRemovalList.Add(contentType.Parent);
		}

		#endregion

	// remove properties
	foreach (var p in tokensRemovalList) p.Remove();

	File.WriteAllText(filePath, json.ToString());
}

// You can define other methods, fields, classes and namespaces here
