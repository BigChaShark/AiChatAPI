using AiChatAPI.Data;
using AiChatAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddScoped<AiService>();
builder.Services.AddScoped<RagService>();
builder.Services.AddScoped<DbQueryService>();

builder.Services.AddDbContext<APIAIContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<Saveone>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SaveOneConnection")));
var app = builder.Build();





app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    var config = context.RequestServices
        .GetRequiredService<IConfiguration>();

    var usernameConfig = config["BasicAuth:Username"];
    var passwordConfig = config["BasicAuth:Password"];

    if (!context.Request.Headers.TryGetValue("Authorization", out var authHeader))
    {
        context.Response.StatusCode = 401;
        context.Response.Headers["WWW-Authenticate"] = "Basic";
        await context.Response.WriteAsync("Missing Authorization header");
        return;
    }

    var auth = authHeader.ToString();
    if (!auth.StartsWith("Basic "))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Invalid Authorization type");
        return;
    }

    var encoded = auth.Substring("Basic ".Length).Trim();
    var decoded = System.Text.Encoding.UTF8.GetString(
        Convert.FromBase64String(encoded)
    );

    var parts = decoded.Split(':');
    if (parts.Length != 2)
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Invalid credential format");
        return;
    }

    var username = parts[0];
    var password = parts[1];

    if (username != usernameConfig || password != passwordConfig)
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Invalid username or password");
        return;
    }

    // ผ่าน auth
    context.Items["AuthUser"] = username;

    await next();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
