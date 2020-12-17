using Application.UseCases.GetUser;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Modules
{
    public static class UseCasesExtension
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            _ = services.AddTransient<IGetUser, GetUserUseCase>();
            return services;
        }
    }
}
