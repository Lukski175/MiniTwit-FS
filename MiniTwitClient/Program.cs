using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MiniTwitClient;
using MiniTwitClient.Controllers;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.Web;
using MiniTwitClient.Authentication;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var js = builder.Services.BuildServiceProvider().GetRequiredService<IJSRuntime>();

var appConfig = await js.InvokeAsync<Config>("eval", "window.appConfig");

string apiEndpoint = appConfig?.ApiEndpoint ?? "https://localhost:7297"; // Fallback if not set

builder.Services.AddSingleton(sp => new HttpClient
{
    BaseAddress = new Uri(apiEndpoint)
});

builder.Services.AddSingleton<UserState>();

builder.Services.AddSingleton<MinitwitController>();


await builder.Build().RunAsync();

public class Config
{
    public string ApiEndpoint { get; set; }
}
