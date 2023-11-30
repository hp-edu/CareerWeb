using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerWeb.Models.Job
{
    public class JobPosting
    {
        public int ID { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Summary { get; set; }
        public string Qualification { get; set; }
        public string Description { get; set; }
        public string AddtionalRequrement { get; set; }
        public string PayBenefit { get; set; }
        public List<int> QuestionnaireIDs { get; set; }
    }
}
