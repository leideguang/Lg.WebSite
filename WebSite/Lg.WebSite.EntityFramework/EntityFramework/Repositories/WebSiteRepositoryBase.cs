using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Lg.WebSite.EntityFramework.Repositories
{
    public abstract class WebSiteRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WebSiteDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WebSiteRepositoryBase(IDbContextProvider<WebSiteDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WebSiteRepositoryBase<TEntity> : WebSiteRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WebSiteRepositoryBase(IDbContextProvider<WebSiteDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
