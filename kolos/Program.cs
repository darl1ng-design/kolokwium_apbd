var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// builder.Services.AddDbContext<DatabaseContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("localDB")) );
//
// builder.Services.AddScoped<IDBService, DbService>();
var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();