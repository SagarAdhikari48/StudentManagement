using StudentManagement.Client;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StudentManagement.Client.Repository;
using StudentManagement.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped<IStudentRepository, StudentService>();
builder.Services.AddScoped<ICountryRepository, CountryService>();
// builder.Services.AddScoped<StudentService>();

await builder.Build().RunAsync();