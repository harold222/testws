global using System.ComponentModel.DataAnnotations;
global using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "WSGYG",
        Description = "WebService Comfama",
        Contact = new OpenApiContact
        {
            Name = "Sistemas G&G",
        }
    });

    var filePath = Path.Combine(AppContext.BaseDirectory, "WSGYG.xml");

    if (File.Exists(filePath))
        opt.IncludeXmlComments(filePath);
    else
    {
        StreamWriter CreateFile = new StreamWriter(filePath);
        CreateFile.Close();
        opt.IncludeXmlComments(filePath);
    }
});
// builder.Services.AddSingleton<IResponseHeader, HeaderResponse>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();