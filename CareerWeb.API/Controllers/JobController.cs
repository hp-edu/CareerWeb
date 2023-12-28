using CareerWeb.Models.Job;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Threading.Tasks;

namespace CareerWeb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly string _connectionString;

        public JobController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("PostgreSQL");
        }

        [HttpGet]
        [Route("jobs")]
        public IActionResult GetJobList()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = "SELECT id, jobtitle, department, joblocation, createdat FROM jobpostings";
                var jobSummaries = connection.Query<JobSummary>(sql).ToList();
                return Ok(jobSummaries);
            }
        }

        [HttpGet]
        [Route("job/{id}")]
        public IActionResult GetJobByID(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var parameter = new { jobID = id };
                
                string sql = "SELECT * FROM jobpostings WHERE id = @jobID;";
                var jobPostring = connection.Query<JobPosting>(sql,parameter).SingleOrDefault();

                sql = "SELECT qq.* FROM jobpostings jp INNER JOIN questionnairequestions qq ON qq.id = ANY(jp.questionnaireid) WHERE jp.id = @jobID;";
                var questions = connection.Query<QuestionnaireQuestions>(sql, parameter).ToList();

                sql = "SELECT qa.* FROM jobpostings jp\r\n\tINNER JOIN questionnaireanswers qa ON qa.questionid = ANY(jp.questionnaireid) WHERE jp.id = @jobID;";
                var answers = connection.Query<QuestionnaireAnswers>(sql, parameter);

                JobPostingAPIReponse jobDetailReponse = new JobPostingAPIReponse();
                jobDetailReponse.Detail = jobPostring;
                jobDetailReponse.Questions = questions;

                foreach (var question in jobDetailReponse.Questions)
                {
                    question.Answers = answers.Where(o => o.QuestionID == question.ID).ToList();
                }

                return Ok(jobDetailReponse);
            }
        }
    }
}