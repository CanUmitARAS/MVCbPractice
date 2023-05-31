using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCbPractice.Data;

namespace MVCbPractice.Configuration
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<UrunlerDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Diğer hizmet yapılandırmalarını buraya ekleyebilirsiniz
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Uygulama yapılandırma işlemlerini burada gerçekleştirin

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Diğer middleware ve yönlendirme ayarlarını buraya ekleyebilirsiniz
        }
    }
}
