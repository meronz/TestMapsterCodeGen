using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TestMapsterCodeGen.Client;
using TestMapsterCodeGen.Client.Components;
using TestMapsterCodeGen.Client.Mappers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register the codegen mappers
builder.Services.AddAllMappersInAssembly(typeof(IMyContractMapper).Assembly, "TestMapsterCodeGen.Client.Mappers");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();


