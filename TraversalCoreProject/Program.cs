using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.CQRS.Results.DestinationResults;
using TraversalCoreProject.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging(x => 
{
    x.ClearProviders();

    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();
});

builder.Services.AddHttpClient();

// Add services to the container.
builder.Services.ContainerDependencies(); //Configurations

//CQRS-Based Configurations 
#region CQRS-Based Configurations
builder.Services.AddScoped<GetAllDestinationQueriesHandler>();
builder.Services.AddScoped<GetDestinationByIDQueriesHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<DeleteDestinationCommandHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();

builder.Services.AddMediatR(typeof(Program));
#endregion

//AutoMapper
#region AutoMapper

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.CustomValidator(); //Validator Configurations

#endregion

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityViewModel>();

builder.Services.AddControllersWithViews(); //.AddFluentValidation(); da kullanılabilir.
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();

    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();

var app = builder.Build();

#region Logger

var loggerFactory = app.Services.GetService<ILoggerFactory>();
loggerFactory.AddFile(builder.Configuration["Logging:LogFilePath"].ToString());

#endregion

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Adding Optional Error Page
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/", "?code={0}");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();