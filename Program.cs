global using System.ComponentModel.DataAnnotations;
global using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using WSGYG63.Models.Token;
using WSGYG63.Shared.Functions;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "WSGYG63",
        Description = "WebService Comfama",
        Contact = new OpenApiContact
        {
            Name = "Sistemas G&G",
        }
    });

    string? filePath = Path.Combine(AppContext.BaseDirectory, "WSGYG63.xml");

    if (File.Exists(filePath))
        opt.IncludeXmlComments(filePath);
    else
    {
        StreamWriter CreateFile = new StreamWriter(filePath);
        CreateFile.Close();
        opt.IncludeXmlComments(filePath);
    }
});

builder.Services.Configure<GlobalToken>(async x =>
{
    string host = builder.Configuration["Comfama:host"] + "/OAuth_APIM/GenerateToken";
    x.UrlToken = host;

    TokenParams token = builder.Configuration.GetSection("Comfama:token").Get<TokenParams>();

    Dictionary<string, string?>? requestDict = new ModelToDictionary().Trasform<TokenParams>(token);
    x.DataToGetToken = requestDict;

    Task<TokenResponse> resp = new Http().GetToken<TokenResponse>(host, token.client_id, requestDict);
    
    if (resp != null)
    {
        try
        {
            resp.Wait();

            if (resp.Result != null)
            {
                x.DateExpire = new RefreshToken().refresh(resp.Result.ExpiresIn);
                x.AccessToken = resp.Result.AccessToken;
            }
        }
        catch (Exception) { }
    }
});

WebApplication app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();