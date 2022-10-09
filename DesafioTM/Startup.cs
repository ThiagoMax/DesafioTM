using DesafioTM.Business;
using DesafioTM.Business.Implementation;
using DesafioTM.Business.Purchases;
using DesafioTM.Business.Tickets;
using DesafioTM.Business.User;
using DesafioTM.Model.Context;
using DesafioTM.Repository;
using DesafioTM.Repository.Generic;
using DesafioTM.Repository.Implementation;
using DesafioTM.Repository.Purchases;
using DesafioTM.Repository.Tickets;
using DesafioTM.Repository.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DesafioTM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            services.AddAutoMapper(typeof(Startup));
            
            services.AddScoped<IEvent, EventBusinessImp>();
            services.AddScoped<IEventRepository, EventRepositoryImp>();
            
            services.AddScoped<IUsers, UsersBusinessImp>();
            services.AddScoped<IUsersRepository, UsersRepositoryImp>();

            services.AddScoped<IPurchase, PurchaseBusinessImp>();
            services.AddScoped<IPurchaseRepository, PurchaseRepositoryImp>();

            services.AddScoped<ITicket, TicketBusinessImp>();
            services.AddScoped<ITicketRepository, TicketRepositoryImp>();

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
