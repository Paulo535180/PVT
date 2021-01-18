using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using PVT.Domain.Interface;
using PVT.Service.Data;
using PVT.Service.Repository;
using System.Data;

namespace PVT.UI.Admin
{
    public class Startup
    {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddMvc().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();

            services.Configure<CookiePolicyOptions>(options => { options.CheckConsentNeeded = context => true; options.MinimumSameSitePolicy = SameSiteMode.None; });
           
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {

                options.AccessDeniedPath = new PathString("/Login/Index");
                options.LoginPath = new PathString("/Login/Index");
                options.LogoutPath = new PathString("/Login/Index");
            });

            services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            }).AddRazorRuntimeCompilation();


            string connection = Configuration.GetConnectionString("ConnDB");
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IDbConnection>(conn => new SqlConnection(connection));

            services.AddScoped<ISetorRepository, SetorRepository>();
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
            services.AddScoped<IAulaRepository, AulaRepository>();
            services.AddScoped<ITipoAulaRepository, TipoAulaRepository>();
            services.AddScoped<IUsuarioGestorRepository, UsuarioGestorRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
