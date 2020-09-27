using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace GenericRepo
{
    public static class ServiceCollectionExtensions
    {

        public static void RegisterYourLibrary(this IServiceCollection services, ApplicationDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            services.AddSingleton<IUnitOfWork, UnitOfWork>(uow => new UnitOfWork(dbContext));
        }
    }
}
