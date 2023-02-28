using MemberActivites.Infrastructure.Database;
using MemberActivites.Infrastructure.Repositories;
using MemberActivities.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivites.Infrastructure.Extension
{
    public static class UnitOfWorkExtension
    {
        public static IServiceCollection SetupUnitOfWork([NotNullAttribute] this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(f =>
            {
                var scopeFactory = f.GetRequiredService<IServiceScopeFactory>();
                var context = f.GetService<DatabaseContext>();

                return new UnitOfWork(
                    context,
                    new MemberRepository(context.Member)
                    );
            });

            return serviceCollection;

        }
    }
}
