using FusionZoho.ServiceFusionAPI;
using FusionZoho.ServiceFusionAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace FusionZoho.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FusionJobsController : ControllerBase
    {
        

        private readonly ILogger<FusionJobsController> _logger;
        private readonly IJobService _serviceFusionAPI;

        public FusionJobsController(ILogger<FusionJobsController> logger,ServiceFusionAPI.IJobService serviceFusionAPI)
        {
            _logger = logger;
            _serviceFusionAPI= serviceFusionAPI;
        }

        [HttpGet(Name = "GetOpenJobs/{page}")]
       
        public async Task<JobViewList> GetOpenJobs(int page)
        {
             var jobs =await _serviceFusionAPI.GetOpenJobsAsync(page);
            return jobs;
        }
        [HttpGet(Name = "GetJob/{jobId}")]

        public async Task<JobView> GetJob(int jobId)
        {
            var job = await _serviceFusionAPI.GetJob(jobId);
            return job;
        }



        [HttpGet(Name = "GetAllOpenJobs")]
        public async Task<List<JobView>> GetAllOpenJobsAsync()
        {
            var jobs = await _serviceFusionAPI.GetAllOpenJobsAsync();
            return jobs;
        }

      
    }
}