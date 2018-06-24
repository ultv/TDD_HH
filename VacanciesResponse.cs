using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HH
{
    /// <summary>
    /// Информация о вакансии и количество вакансий.
    /// </summary>
    class VacanciesResponse
    {
        public VacancyInfo [] Items { get; set; }
        public int Found { get; set; }
        public int Per_page { get; set; }
    }
}
