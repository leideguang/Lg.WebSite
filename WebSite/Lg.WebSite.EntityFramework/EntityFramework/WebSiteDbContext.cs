using System.Data.Common;
using Abp.Zero.EntityFramework;
using Lg.WebSite.Authorization.Roles;
using Lg.WebSite.MultiTenancy;
using Lg.WebSite.Users;

namespace Lg.WebSite.EntityFramework
{
    public class WebSiteDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WebSiteDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WebSiteDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WebSiteDbContext since ABP automatically handles it.
         */
        public WebSiteDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WebSiteDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
