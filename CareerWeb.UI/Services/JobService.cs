using CareerWeb.Models.Job;
using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace CareerWeb.UI.Services
{
    public class JobService
    {
        private readonly HttpClient _httpClient;

        public JobService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<List<JobSummary>> GetJobList()
        {
            var response = await _httpClient.GetAsync("Job/jobs");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<JobSummary>>();
        }

        public async Task<JobPostingAPIReponse> GetJobPosting(int id)
        {
            var response = await _httpClient.GetAsync($"Job/job/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<JobPostingAPIReponse>();
        }
    }
}
