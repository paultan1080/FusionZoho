using FusionZoho.ServiceFusionAPI.Models;

namespace FusionZoho.ServiceFusionAPI
{
    public interface IJobService
    {
        Task<string> GetAccessTokenAsync();
        Task<JobViewList> GetOpenJobsAsync(int page = 1, int perpage = 50);

        Task<JobView> GetJob(int jobId);

        Task<List<JobView>> GetAllOpenJobsAsync();
        System.Threading.Tasks.Task SetAccessToken();

    }
}