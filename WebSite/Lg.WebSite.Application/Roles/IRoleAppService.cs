using System.Threading.Tasks;
using Abp.Application.Services;
using Lg.WebSite.Roles.Dto;

namespace Lg.WebSite.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
