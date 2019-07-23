using System;
using EasyInject.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace EasyInject.Extensions.DependencyInjection
{
    public static class Extensions
    {
        public static void AddEasyInjectSegment<T>(this IServiceCollection serviceCollection) 
            where T:Segment
        {
            var instance = Activator.CreateInstance<T>();
            serviceCollection.AddEasyInjectSegment(instance);
        }

        public static void AddEasyInjectSegment(this IServiceCollection serviceCollection, Segment segment)
        {
            foreach (var keyValuePair in segment._types)
            {
                serviceCollection.AddScoped(keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
