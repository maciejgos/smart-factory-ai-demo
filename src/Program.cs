using Microsoft.SemanticKernel;
using Microsoft.Extensions.Configuration;

var builder = Kernel.CreateBuilder();

// Load configuration from user-secrets
var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

string endpoint = configuration["AzureOpenAI:Endpoint"] ?? string.Empty;
string apiKey = configuration["AzureOpenAI:ApiKey"] ?? string.Empty;
if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(apiKey))
{
    Console.WriteLine("Please set the Azure OpenAI endpoint and API key in user secrets.");
    Environment.Exit(1);
}

builder.AddAzureOpenAIChatCompletion("gpt-4o", endpoint, apiKey);
var kernel = builder.Build();