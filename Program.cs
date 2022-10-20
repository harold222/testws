global using System.ComponentModel.DataAnnotations;
global using Microsoft.AspNetCore.Mvc;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    //var filePath = Path.Combine(AppContext.BaseDirectory, "WSGYG.xml");

    //if (File.Exists(filePath))
    //    opt.IncludeXmlComments(filePath);
    //else
    //{
    //    StreamWriter CreateFile = new StreamWriter(filePath);
    //    CreateFile.Close();
    //    opt.IncludeXmlComments(filePath);
    //}
});
// builder.Services.AddSingleton<IResponseHeader, HeaderResponse>();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
