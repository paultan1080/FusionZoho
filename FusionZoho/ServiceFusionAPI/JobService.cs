using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using FusionZoho.ServiceFusionAPI.Models;
using Task = System.Threading.Tasks.Task;
using Newtonsoft.Json;

namespace FusionZoho.ServiceFusionAPI
{
    public class JobService : IJobService
    {
         HttpClient httpClient = new HttpClient();
        static string apiBaseUrl = "https://api.servicefusion.com/v1/";
        static string accessToken = "";
        static string grant_type = "client_credentials";
        static string client_id = "82ywTTJB2c8w1zZVuu";
        static string client_secret = "5gR9pCsYiVaDbb7M5335zn-YVvdOKwUr";
        static string order_filter = "Unscheduled,Scheduled,Dispatched,Delayed,On The Way,On Site,Started,Paused,Resumed,To be invoiced,Invoiced,Partially Completed";

        static string expand_views = "agents, custom_fields, pictures, documents, equipment, equipment.custom_fields, techs_assigned, tasks, notes, products, services, other_charges, labor_charges, expenses, payments, invoices, signatures, printable_work_order, visits, visits.techs_assigned";
        public JobService()
        {

        }

        public async Task SetAccessToken()
        {

            if (String.IsNullOrEmpty(accessToken))
            {
                var token = "";
                try
                {
                    token = await GetAccessTokenAsync();
                }
                catch (Exception ex)
                {
                    token = await GetAccessTokenAsync();

                }

                if (String.IsNullOrEmpty(token))
                {
                    //throw error
                }

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
        public async Task<string> GetAccessTokenAsync()
        {
            AuthToken authToken = new AuthToken();
            authToken.client_secret= client_secret;
            authToken.grant_type = grant_type;
            authToken.client_id = client_id;

            var json = JsonConvert.SerializeObject(authToken);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json"); 

            var response = await httpClient.PostAsync("https://api.servicefusion.com/oauth/access_token", stringContent);
            if (response.IsSuccessStatusCode) {
                var tokenObject = await response.Content.ReadFromJsonAsync<OAuthToken>();
                return tokenObject.access_token;
            }
         
            return "";

        }
        public async Task<List<JobStatusView>> GetJobStatus(int orderStatus)
        {
            await SetAccessToken();

            HttpResponseMessage response = await httpClient.GetAsync(apiBaseUrl + "job-statuses/" + orderStatus.ToString());

            if (response.IsSuccessStatusCode)
            {
                var jobViews = await response.Content.ReadFromJsonAsync<List<JobStatusView>>();
                return jobViews;
            }
            return new List<JobStatusView>();
        }


        public async Task<JobViewList> GetOpenJobsAsync(int page = 1,int perpage=25)
        {
            await SetAccessToken();

            HttpResponseMessage response = await httpClient.GetAsync(apiBaseUrl + "jobs?page="  +page  + "&per-page=" + perpage+"&expand=" + expand_views + "filters[status]=" + order_filter);

            if (response.IsSuccessStatusCode)
            {
                var str = await response.Content.ReadAsStringAsync();
                var jobView = await response.Content.ReadFromJsonAsync<JobViewList>();
                return jobView;
            }

            return new JobViewList();
        }

        public async Task<List<JobView>> GetAllOpenJobsAsync()
        {
            List<JobView> jobs=new List<JobView>();

            var jobViewList =await GetOpenJobsAsync(1,50);
            jobs.AddRange(jobViewList.items);
            var pageCount = jobViewList._meta.pageCount;
            var currentPage = jobViewList._meta.currentPage;

           while (currentPage != pageCount) {
                currentPage = currentPage + 1;
                jobViewList = await GetOpenJobsAsync(currentPage, 50);
                
             
                jobs.AddRange(jobViewList.items);
            }


            return jobs;
        }

        public async Task<JobView> GetJob(int jobId) {


            await SetAccessToken();
            HttpResponseMessage response = await httpClient.GetAsync(apiBaseUrl + "jobs/" + jobId.ToString());

            if (response.IsSuccessStatusCode)
            {
                var str = await response.Content.ReadAsStringAsync();
                var jobView = await response.Content.ReadFromJsonAsync<JobView>();
                return jobView;
            }
            return new JobView();
        }
    }
}
