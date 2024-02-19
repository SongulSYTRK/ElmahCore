using ElmahCore.Mvc;
using ElmahCore.Sql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddElmah<SqlErrorLog>(options =>
{
    options.ConnectionString = @"Server=.;Database=ElmahCoreDb;Integrated Security=True;";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseElmah();
app.MapControllers();

app.Run();
