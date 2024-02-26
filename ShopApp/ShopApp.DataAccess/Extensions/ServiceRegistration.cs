using Microsoft.Extensions.DependencyInjection;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;

namespace ShopApp.DataAccess.Extensions
{
    public static class ServiceRegistration
    {

        public static void AddDataAccessRegistations(IServiceCollection services)
        {
            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
        }
    }
}
