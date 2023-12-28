using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerWeb.Models.Job
{
    public class JobPosting : JobSummary
    {
        public string Summary { get; set; }
        public string Qualification { get; set; }
        public string Description { get; set; }
        public string AddtionalRequrement { get; set; }
        public string PayBenefit { get; set; }
        public int[] QuestionnaireID { get; set; }
    }
}
