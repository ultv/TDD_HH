using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace TDD_HH
{
    public partial class Form1 : Form
    {
        public int NumberVacancy { get; set; }
        string AllVacancies = "https://api.hh.ru/vacancies";
        public string Ulyanovsk = "&area=98";
        public string IT = "&industry=7";
        public string SimbirSoft = "&text=Симбирсофт";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetVacanties_Click(object sender, EventArgs e)
        {
            richTextBoxVacancies.Clear();

            string url = AllVacancies;

            if (checkBoxUlyanovsk.Checked || checkBoxIT.Checked || checkBoxSimbirSoft.Checked)
            {
                url = url + "?";

                if (checkBoxUlyanovsk.Checked)
                {
                    url = url + Ulyanovsk;
                }

                if (checkBoxIT.Checked)
                {
                    url = url + IT;
                }

                if (checkBoxSimbirSoft.Checked)
                {
                    url = url + SimbirSoft;
                }
            }
            
            HttpWebRequest httpWebrequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebrequest.Method = "GET";
            httpWebrequest.UserAgent = "User-Agent: api-test-agent";

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebrequest.GetResponse();

            string response;

            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }

            VacanciesResponse vacanciesResponse = JsonConvert.DeserializeObject<VacanciesResponse>(response);

            int found = vacanciesResponse.Found;

            labelCountVacancies.Text += found.ToString();

            int countPrint = Int32.Parse(textBoxCountPrint.Text);

        //    for(int count = 0; count < (countPrint / 20); count++)
            {

                int count = 20;

                if(found < count)
                {
                    count = found;
                }

                for (int i = 0; i < count; i++)
                {
                    NumberVacancy++;

                    richTextBoxVacancies.AppendText($"{NumberVacancy}. {vacanciesResponse.Items[i].Name}\n");

                    if (vacanciesResponse.Items[i].Salary != null)
                    {
                        richTextBoxVacancies.AppendText($"{vacanciesResponse.Items[i].Salary.SalaryFormat()}\n");
                    }
                    else
                    {
                        richTextBoxVacancies.AppendText("з/п не указана\n");
                    }

                    richTextBoxVacancies.AppendText($"{vacanciesResponse.Items[i].Employer.Name}\n");
                    richTextBoxVacancies.AppendText($"{vacanciesResponse.Items[i].Area.Name}\n");
                    richTextBoxVacancies.AppendText($"{vacanciesResponse.Items[i].Alternate_url}\n");
                    richTextBoxVacancies.AppendText("\n");

                }
            }
            
            
        }

        private void richTextBoxVacancies_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
