using EnvironmentsAndErrors.Data;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Serilog;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();

builder.Services.AddAuthorization(options =>
    options.FallbackPolicy = options.DefaultPolicy);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc4NTY3NEAzMjMzMmUzMDJlMzBSdVlLZnMvYTZNb3FNNTk0eTA4REVoalk2YnF1bHAzNTFFUnNxcythd3lZPQ==");

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Error");
    _ = app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

Log.CloseAndFlush();