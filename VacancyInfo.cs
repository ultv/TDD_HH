using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HH
{
    class VacancyInfo
    {
        public string Name { get; set; }
        public VacancySalary Salary { get; set; }
        public VacancyEmployer Employer { get; set; }
        public VacancyArea Area { get; set; }
        public string Alternate_url { get; set; }
    }
}
