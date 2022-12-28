using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

// Data base context
builder.Services.AddDbContext<ApplicationDBContext>();

//DI
//builder.Services.AddScoped<IEditorialRepository, EditorialRepository>();

//builder.Services.AddScoped<IEditorialService, EditorialService>();

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//busca en todo 
//builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
//    .ConfigureContainer<ContainerBuilder>(options => {
//        options.RegisterAssemblyTypes(Assembly.Load(""))
//        .AsImplementedInterfaces()
//        .InstancePerLifetimeScope();
//    });

//se especifica en que archivos
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(options => {
        options.RegisterAssemblyTypes(Assembly.Load("Infrastructure"))
        .Where(x => x.Name.EndsWith("Repository"))
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();
        options.RegisterAssemblyTypes(Assembly.Load("Application"))
        .Where(x => x.Name.EndsWith("Service"))
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();
    });

builder.Services.AddAutoMapper(Assembly.Load("Application"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
