using Microsoft.EntityFrameworkCore;
using W8.Context;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<W7Context>(options => options.UseSqlServer("Name=ConnectionStrings:Default"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
//dotnet new tool-manifest

//dotnet tool install dotnet-ef --version 8.0.0
//dotnet ef migrations add Init

//dotnet ef database update


//zawsze dodawaj w kontekscie
//1. Students group - student wiele do wiele
//jesli w tabelce jest cos oprócz kluczy obcych trzeba ręcznie zrobić model

//2. Studies - student jeden do wiele
// jeden student jest przypisany do jednych studiów a studia do wielu studentów

//3. generowanie dziedziczenia Employe