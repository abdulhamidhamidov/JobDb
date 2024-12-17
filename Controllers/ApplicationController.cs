using Domain;
using Infrostructure;
using Infrostructure.Response;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]
public class ApplicationController(IApplicationService applicationService): ControllerBase
{
    async Task<Response<bool>> Create(Application application)
    {
        return await applicationService.Create(application);
    }

    async Task<Response<List<Application>>> GetAll()
    {
        return await applicationService.GetAll();
    }

    async Task<Response<Application>> GetBuId(int id)
    {
        return await applicationService.GetBuId(id);
    }

    async Task<Response<bool>> Update(Application application)
    {
        return await applicationService.Update(application);
    }

    async Task<Response<bool>> Delete(int id)
    {
        return await applicationService.Delete(id);
    }

    async Task<Response<List<Application>>> GetAllByStatus(string status)
    {
        return await applicationService.GetAllByStatus(status);
    }

    async Task<Response<int>> CountApplicationByUserId(int userId)
    {
        return await applicationService.CountApplicationByUserId(userId);
    }

    async Task<Response<List<Application>>> GetFifeLastApplicationByJobId(int jobId)
    {
        return await applicationService.GetFifeLastApplicationByJobId(jobId);
    }
}