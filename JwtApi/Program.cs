using System.Text;
using JwtApi.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(ot=>{
    ot.RequireHttpsMetadata = false;
    ot.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer ="http://localhost",
        ValidAudience = "http://localhost",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("gfjh3kjdhfkj3hfkj3hfjk3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hfkj3hf")),
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
    };
});

builder.Services.AddDbContext<UserContext>(opt =>{
    opt.UseSqlite("Data Source= userdb");
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
