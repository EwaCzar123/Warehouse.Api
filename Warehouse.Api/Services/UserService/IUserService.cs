using Warehouse.Api.Models;

namespace Warehouse.Api.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> getAllUsers();
        Task<ServiceResponse<User>> getByCode(string code);
        Task<ServiceResponse<List<User>>> AddUser(string code);
    }

}
