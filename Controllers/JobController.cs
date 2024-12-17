using Domain;
using Infrostructure;
using Infrostructure.Response;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController(IJobService jobService): ControllerBase
{
    async Task<Response<bool>> Create(Job job)
    {
        return await jobService.Create(job);
    }

    async Task<Response<List<Job>>> GetAll()
    {
        return await jobService.GetAll();
    }

    async Task<Response<Job>> GetBuId(int id)
    {
        return await jobService.GetBuId(id);
    }

    async Task<Response<bool>> Update(Job job)
    {
        return await jobService.Update(job);
    }

    async Task<Response<bool>> Delete(int id)
    {
        return await jobService.Delete(id);
    }

    async Task<Response<decimal>> GetAVGSelary()
    {
        return await jobService.GetAVGSelary();
    }

    async Task<Response<List<Job>>> GetTenLastJobByCreated()
    {
        return await jobService.GetTenLastJobByCreated();
    }

    async Task<Response<Job>> GetByMaxSalary()
    {
        return await jobService.GetByMaxSalary();
    }

    async Task<Response<Job>> GetByMinSalary()
    {
        return await jobService.GetByMinSalary();
    }
}