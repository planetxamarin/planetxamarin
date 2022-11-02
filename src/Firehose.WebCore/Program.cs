using Firehose.Web.Infrastructure;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<NewCombinedFeedSource>();

var members = Assembly.GetCallingAssembly().GetTypes()
	.Where(type => typeof(IAmACommunityMember).IsAssignableFrom(type) && !type.IsInterface);

foreach (var member in members)
	builder.Services.AddSingleton(typeof(IAmACommunityMember), member);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.WebHost.ConfigureKestrel(serverOptions =>
{
	serverOptions.AllowSynchronousIO = true;
});

builder.Services.Configure<IISServerOptions>(options => 
{
	options.AllowSynchronousIO = true;
});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
