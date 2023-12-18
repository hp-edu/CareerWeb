using CareerWeb.Models.Job;

namespace CareerWeb.UI.Services
{
    public class JobService
    {
        public List<JobPosting> JobPostings = new List<JobPosting>();

        public JobService()
        {
            JobPostings.Add(new JobPosting()
            {
                ID = 1,
                JobTitle = "Backend Developer",
                Department = "Core Team",
                Location = "Toronto, ON",
                Description = @"As an Operations Expert, you and your team have the incredible responsibility of ensuring products
take the final step in the supply chain: getting into customers' hands. You're in charge of the store's
entire inventory - products, parts, tools, supplies, and everything else. You make sure your team has
the support, knowledge, and resources required to maintain product availability, complete inventory
tasks, and keep the stockroom organized as new products arrive. You're in constant contact with the
management and leadership teams, sharing data about the status of products and parts. And when
exciting new products arrive, you're the first to open them up and present them to the entire store
team. Uju makes the products, but you make it happen by being ready to place our products in
customers' hands.",
                Qualification = "<ul><li>Good programmer</li><li>Good communicator</li><li>Eager to learn</li></ul>",
                QuestionnaireIDs = new List<int>() { 1, 2, 3 },
                Summary = @"Do you love how it feels to make someone’s day?  As an Operations Expert, you know better than
anyone else the satisfaction of getting the latest Uju product into your hands. So it’s up to you to
make sure customers are just as satisfied. By guiding and mentoring your team, you help keep pace
with changing demands and make sure every product and demo machine is where it should be. At the
end of the day, it’s your organizational skills and dedication that are at the heart of what the Uju Store
does — connecting people to the products they love.",
                AddtionalRequrement = @"<ul><li>You can manage and meet multiple inventory deadlines each week.</li><li>You’re willing to observe guidelines to allow secure access to products and movement through the stockroom.</li><li>You’ll need to be flexible with your schedule. Your work hours will be based on business needs.</li ></ul> ",
                PayBenefit = @"At Uju, base pay is one part of our total compensation package and is determined within a range.
This provides the opportunity to progress as you grow and develop within a role. Your base pay will
depend on your skills, qualifications, experience, and location.<br/>Uju employees also have the opportunity to become an Uju shareholder through participation in
Uju’s discretionary employee stock programs. Uju employees are eligible for discretionary
restricted stock unit awards, and can purchase Uju stock at a discount if voluntarily participating in
Uju’s Employee Stock Purchase Plan. You’ll also receive benefits including: Comprehensive
medical and dental coverage, retirement benefits, a range of discounted products and free services,
and for formal education related to advancing your career at Uju, reimbursement for certain
educational expenses — including tuition. Additionally, this role might be eligible for discretionary
bonuses or commission payments as well as relocation. Learn more about Uju Benefits.<br/>For information about pay, if you are interested in roles located in one of our California, Colorado,
New York or Washington locations click here to select a store and view pay information.<br/>",
                PostedAt = new DateTime(2023, 11, 11)
            });
            JobPostings.Add(new JobPosting()
            {
                ID = 2,
                JobTitle = "Database Developer",
                Department = "DB Team",
                Location = "Seoul, Korea",
                Description = @"As an Operations Expert, you and your team have the incredible responsibility of ensuring products
take the final step in the supply chain: getting into customers' hands. You're in charge of the store's
entire inventory - products, parts, tools, supplies, and everything else. You make sure your team has
the support, knowledge, and resources required to maintain product availability, complete inventory
tasks, and keep the stockroom organized as new products arrive. You're in constant contact with the
management and leadership teams, sharing data about the status of products and parts. And when
exciting new products arrive, you're the first to open them up and present them to the entire store
team. Uju makes the products, but you make it happen by being ready to place our products in
customers' hands.",
                Qualification = "<ul><li>Good programmer</li><li>Good communicator</li><li>Eager to learn</li></ul>",
                QuestionnaireIDs = new List<int>() { 1, 2, 3 },
                Summary = @"Do you love how it feels to make someone’s day?  As an Operations Expert, you know better than
anyone else the satisfaction of getting the latest Uju product into your hands. So it’s up to you to
make sure customers are just as satisfied. By guiding and mentoring your team, you help keep pace
with changing demands and make sure every product and demo machine is where it should be. At the
end of the day, it’s your organizational skills and dedication that are at the heart of what the Uju Store
does — connecting people to the products they love.",
                AddtionalRequrement = @"<ul><li>You can manage and meet multiple inventory deadlines each week.</li><li>You’re willing to observe guidelines to allow secure access to products and movement through the stockroom.</li><li>You’ll need to be flexible with your schedule. Your work hours will be based on business needs.</li ></ul> ",
                PayBenefit = @"At Uju, base pay is one part of our total compensation package and is determined within a range.
This provides the opportunity to progress as you grow and develop within a role. Your base pay will
depend on your skills, qualifications, experience, and location.<br/>Uju employees also have the opportunity to become an Uju shareholder through participation in
Uju’s discretionary employee stock programs. Uju employees are eligible for discretionary
restricted stock unit awards, and can purchase Uju stock at a discount if voluntarily participating in
Uju’s Employee Stock Purchase Plan. You’ll also receive benefits including: Comprehensive
medical and dental coverage, retirement benefits, a range of discounted products and free services,
and for formal education related to advancing your career at Uju, reimbursement for certain
educational expenses — including tuition. Additionally, this role might be eligible for discretionary
bonuses or commission payments as well as relocation. Learn more about Uju Benefits.<br/>For information about pay, if you are interested in roles located in one of our California, Colorado,
New York or Washington locations click here to select a store and view pay information.<br/>",
                PostedAt = new DateTime(2023, 10, 1)
            });
            JobPostings.Add(new JobPosting()
            {
                ID = 3,
                JobTitle = "Frontend Developer",
                Department = "UI Team",
                Location = "Ottawa, ON",
                Description = @"As an Operations Expert, you and your team have the incredible responsibility of ensuring products
take the final step in the supply chain: getting into customers' hands. You're in charge of the store's
entire inventory - products, parts, tools, supplies, and everything else. You make sure your team has
the support, knowledge, and resources required to maintain product availability, complete inventory
tasks, and keep the stockroom organized as new products arrive. You're in constant contact with the
management and leadership teams, sharing data about the status of products and parts. And when
exciting new products arrive, you're the first to open them up and present them to the entire store
team. Uju makes the products, but you make it happen by being ready to place our products in
customers' hands.",
                Qualification = "<ul><li>Good programmer</li><li>Good communicator</li><li>Eager to learn</li></ul>",
                QuestionnaireIDs = new List<int>() { 1, 2, 3 },
                Summary = @"Do you love how it feels to make someone’s day?  As an Operations Expert, you know better than
anyone else the satisfaction of getting the latest Uju product into your hands. So it’s up to you to
make sure customers are just as satisfied. By guiding and mentoring your team, you help keep pace
with changing demands and make sure every product and demo machine is where it should be. At the
end of the day, it’s your organizational skills and dedication that are at the heart of what the Uju Store
does — connecting people to the products they love.",
                AddtionalRequrement = @"<ul><li>You can manage and meet multiple inventory deadlines each week.</li><li>You’re willing to observe guidelines to allow secure access to products and movement through the stockroom.</li><li>You’ll need to be flexible with your schedule. Your work hours will be based on business needs.</li ></ul> ",
                PayBenefit = @"At Uju, base pay is one part of our total compensation package and is determined within a range.
This provides the opportunity to progress as you grow and develop within a role. Your base pay will
depend on your skills, qualifications, experience, and location.<br/>Uju employees also have the opportunity to become an Uju shareholder through participation in
Uju’s discretionary employee stock programs. Uju employees are eligible for discretionary
restricted stock unit awards, and can purchase Uju stock at a discount if voluntarily participating in
Uju’s Employee Stock Purchase Plan. You’ll also receive benefits including: Comprehensive
medical and dental coverage, retirement benefits, a range of discounted products and free services,
and for formal education related to advancing your career at Uju, reimbursement for certain
educational expenses — including tuition. Additionally, this role might be eligible for discretionary
bonuses or commission payments as well as relocation. Learn more about Uju Benefits.<br/>For information about pay, if you are interested in roles located in one of our California, Colorado,
New York or Washington locations click here to select a store and view pay information.<br/>",
                PostedAt = new DateTime(2023, 9, 3)
            });
        }

        public List<JobSummary> GetJobList()
        {
            return JobPostings.Select(o => new JobSummary()
            {
                ID = o.ID,
                JobTitle = o.JobTitle,
                Department = o.Department,
                Location = o.Location,
                PostedAt = o.PostedAt
            }).ToList();
        }

        public JobPosting GetJobPosting(int id)
        {
            return JobPostings.SingleOrDefault(o => o.ID == id);
        }
    }
}
