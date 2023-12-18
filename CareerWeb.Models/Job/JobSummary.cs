﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerWeb.Models.Job
{
    public class JobSummary
    {
        public int ID { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public DateTime PostedAt { get; set; }

    }
}
