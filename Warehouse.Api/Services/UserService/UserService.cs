using Warehouse.Api.Models;

namespace Warehouse.Api.Services.UserService;

public class UserService: IUserService
{

    private static readonly List<User> users = new()
    {
        new User
        {
            Id = 1, Code = "1111", Name = "User1", Surname = "User1"
        },
        new User
        {
            Id = 2, Code = "2222", Name = "User2", Surname = "User2"
        }

    };
    public async Task<ServiceResponse<List<User>>> getAllUsers()
    {
        var serviceResponse = new ServiceResponse<List<User>>();
        serviceResponse.Data = users;

        return serviceResponse;
    }

    public async Task<ServiceResponse<User>> getByCode(string code)
    {
        var user = users.FirstOrDefault(u => u.Code == code);
        var serviceResponse = new ServiceResponse<User>();
        serviceResponse.Data = user;

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<User>>> AddUser(string code)
    {
        users.Add(new User { Id = 3, Code = code });
        var serviceResponse = new ServiceResponse<List<User>>();
        serviceResponse.Data = users;
 
        return serviceResponse;
    }
}