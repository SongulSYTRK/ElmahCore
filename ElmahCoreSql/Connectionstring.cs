using ElmahCore.Mvc;
using ElmahCore.Sql;
using Microsoft.Extensions.DependencyInjection;

namespace ElmahCoreSql
{
    public class Connectionstring
    {
        private static void AddElmahCore(IServiceCollection services)
        {
            services.AddElmah<SqlErrorLog>(options =>
            {
                options.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=WebAPICoreTutorial;user id=WebAPICoreTutorialUser;password=superpassword;";
            });
        }
    }
}