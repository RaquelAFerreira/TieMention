using TieMention.Web.Components;
using TieMention.Application.Interfaces;
using TieMention.Api.Controllers;
using TieMention.Infrastructure;
using TieMention.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using TieMention.Application.Mentions.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configuração do banco de dados com PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

// Registro do repositório genérico
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Registro do MediatR (um só é suficiente para toda a aplicação)
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetMentionHandler>());

// Registro do controller API (caso esteja servindo API junto do WebApp)
builder.Services.AddControllers();

// ✅ HttpClient configurado com endereço base da API
builder.Services.AddHttpClient("TieMentionApi", client =>
{
    client.BaseAddress = new Uri("https://localhost:5000/"); // ajuste para a porta real da API
});

// ✅ HttpClient padrão que será injetado com @inject HttpClient Http
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("TieMentionApi"));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAntiforgery();

// ✅ Se você for usar a API diretamente no mesmo app (caso da API REST estar integrada)
app.MapControllers();

// Blazor Interactive (WebApp)
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();