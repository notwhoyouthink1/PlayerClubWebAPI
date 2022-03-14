using Microsoft.EntityFrameworkCore;
using PlayerClubWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<PlayerClubContext>(opt =>
    opt.UseInMemoryDatabase("PlayerClub"));
var app = builder.Build();
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();