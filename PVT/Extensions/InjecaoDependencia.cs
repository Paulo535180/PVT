using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PVT.Context;
using PVT.Interface;
using PVT.Repository;

namespace PVT.Extensions
{
    public static class InjecaoDependencia
    //{
    //    public static IServiceCollection injecao (this IServiceCollection service, IConfiguration configuration)
    //    {
    //        service.AddDbContext<MyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnDB")));

    //        service.AddScoped<IUsuarioRepository, UsuarioRepository>();
    //        service.AddScoped<ISetorRepository, SetorRepository>();
    //        //Vou colocar os meus Scopos Aqui//
    //        return service;
    //    } 
    //}
}
