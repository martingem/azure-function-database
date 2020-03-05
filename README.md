# azure-function-database

Azure Function with Entity Framework + DI

# Components
- Microsoft.Extensions.DependencyInjection 3.1.2 (latest)
- Microsoft.Azure.Functions.Extensions 1.0.0 (latest)
- Microsoft.NET.Sdk.Functions 3.0.4 (latest)

# What I tried

| Version | Issue |
| ------- | ----- |
| Microsoft.NET.Sdk.Functions 3.0.4 | Microsoft.Extensions.DependencyInjection.Abstractions: Unable to resolve service for type 'AzureFunction.Contexts.TestContext' while attempting to activate 'AzureFunction.TestFunction'. |
| Microsoft.NET.Sdk.Functions 3.0.3 | N/A |

local.settings.json unchanged from:
```json
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet"
    }
}
```
