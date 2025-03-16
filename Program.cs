using Enquiry.API.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// 2. added the class service then added 3 table in model folder
builder.Services.AddDbContext<EnquiryDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Data")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();
// Added Cors here and to use it enable it into controllers
builder.Services.AddCors(options=>{

    options.AddPolicy(name: "AllowCors",
        builder =>
        {
            builder.WithOrigins("https://localhost:4209","http://localhost:4200")
            .AllowCredentials()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(); // used CORS
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
