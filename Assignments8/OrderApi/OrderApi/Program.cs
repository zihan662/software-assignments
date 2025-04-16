using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using OrderApp;
namespace OrderApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //把DbContext加入到容器
            builder.Services.AddDbContext<OrderContext>(opt => opt.UseMySQL("Server=localhost;" +
                "Database=orderdb;User=root;Password=278596662"));
            builder.Services.AddScoped<OrderService>();
            builder.Services.AddScoped<OrderService>(provider =>
                         new OrderService(provider.GetRequiredService<OrderContext>())) ;
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

            app.Run();
        }
    }
}
