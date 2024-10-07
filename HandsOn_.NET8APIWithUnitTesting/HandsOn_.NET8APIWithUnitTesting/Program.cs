using HandsOn_.NET8APIWithUnitTesting.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Write your code here to add SingleTone service for IPatientRepository and PatientRepository

builder.Services.AddControllers();

//Write your code here to add SwaggerGen()

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
