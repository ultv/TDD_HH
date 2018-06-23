using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HH
{
    class VacancySalary
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Currency { get; set; }

        public string SalaryFormat()
        {
            string result = "";
            string separator = "";

            if ((From != null) && (To != null))
            {
                separator = " - ";
            }

            return result = From + separator + To;
        }
    }
}
