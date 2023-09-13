using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoTasks;
using Repositories;
using Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//  The following service must be in scoped mode. Not clear why. Maybe because we inject an http client
// in the repository constructor.
builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddSingleton<State>();

await builder.Build().RunAsync();
