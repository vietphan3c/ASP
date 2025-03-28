using Microsoft.EntityFrameworkCore;
using PhanVanViet.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Thêm DbContext vào DI Container TRƯỚC khi gọi `builder.Build()`
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
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

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run(); // 🔹 `app.Run()` phải là lệnh cuối cùng!
