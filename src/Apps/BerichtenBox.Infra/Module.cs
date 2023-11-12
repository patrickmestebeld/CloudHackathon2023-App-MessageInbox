using BerichtenBox.Infra.Services;
using BerichtenBox.Infra.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace BerichtenBox.Infra;

public static class Module
{
    public static IServiceCollection AddInfraServices(this IServiceCollection services)
    {
        return services
            .AddSingleton<IMessageStore, MessageStore>()
            .AddTransient<ITslMessageValidator, TslMessageValidator>();
    }
}