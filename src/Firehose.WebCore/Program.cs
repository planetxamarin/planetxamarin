using Firehose.Web.Infrastructure;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.SystemWebAdapters;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSystemWebAdapters();
builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddSingleton<NewCombinedFeedSource>();

var members = Assembly.GetCallingAssembly().GetTypes()
	.Where(type => typeof(IAmACommunityMember).IsAssignableFrom(type) && !type.IsInterface);

foreach (var member in members)
	builder.Services.AddSingleton(typeof(IAmACommunityMember), member);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseSystemWebAdapters();

app.MapDefaultControllerRoute();
app.MapReverseProxy();

app.Run();
