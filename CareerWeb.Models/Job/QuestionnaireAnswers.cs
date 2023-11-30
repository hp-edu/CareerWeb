using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerWeb.Models.Job
{
    public class QuestionnaireAnswers
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int Order { get; set; }
        public string Answer { get; set; }
    }
}
