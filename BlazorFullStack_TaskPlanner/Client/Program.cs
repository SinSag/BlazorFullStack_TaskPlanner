global using BlazorFullStack_TaskPlanner.Shared;
using BlazorFullStack_TaskPlanner.Client.Services.TaskPlannerService;
using BlazorFullStack_TaskPlanner.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITaskPlannerService, TaskPlannerService>();

await builder.Build().RunAsync();
