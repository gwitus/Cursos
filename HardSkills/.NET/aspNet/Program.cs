using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

// Sempre que eu quizer lançar uma aplicação web vou utilizar um motor de aplicação
// Que recebe o nome de View Engine (Responsável por manipular as informações e dar o output)

// Razor tem 2 extensões, .cshtml e razor

// Em arquitetura MVC, o View utiliza-se do Razor

// Razor Page é uma forma de estruturar a aplicação

// Váriavel recebendo a aplicação web
var builder = WebApplication.CreateBuilder(args);
// Adiciona suporte para páginas Razor
// Variável para iniciar ambiente, dependendo se for Maui e etc é só substituir o Razor por ele
builder.Services.AddRazorPages();
var app = builder.Build();
// Passa para o compilador que a gente quer usar o HTTPS
app.UseHttpsRedirection();
// passando para o compilador que vamos trabalhar com arquivos estáticos
// Necessário criar a wwwroot - que é onde vai ficar os arquivos, como HTML, CSS e etc.
app.UseStaticFiles();

// Serve para auxiliar no mapeamento da página
// Possível editar a URL
app.UseRouting();
app.MapRazorPages();


app.Run();