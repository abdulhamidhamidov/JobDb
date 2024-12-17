using Domain;
using Infrostructure;
using Infrostructure.Response;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    async Task<Response<bool>> Create(User user)
    {
        return await userService.Create(user);
    }

    async Task<Response<List<User>>> GetAll()
    {
        return await userService.GetAll();
    }

    async Task<Response<User>> GetBuId(int id)
    {
        return await userService.GetBuId(id);
    }

    async Task<Response<bool>> Update(User user)
    {
        return await userService.Update(user);
    }

    async Task<Response<bool>> Delete(int id)
    {
        return await userService.Delete(id);
    }
}