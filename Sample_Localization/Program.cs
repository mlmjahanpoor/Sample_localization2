using Sample_Localization.Localizations;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddLocalization(options => options.SetResources()); // 1


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseRequestLocalization(LocalizationConfig.Config()); //2

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
