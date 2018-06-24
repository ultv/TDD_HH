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
        public string Ulyanovsk = "";
        public string IT = "";
        public string SimbirSoft = "";
        VacanciesResponse vacanciesResponse;
        int numPage = 0;
        int found = 0;
        int numChecked = 0;

        public Form1()
        {
            InitializeComponent();
            vacanciesResponse = CreateRequest(numPage);

            found = vacanciesResponse.Found;
            labelCountVacancies.Text += found.ToString();
            PrintInfo();

        }
        

        private void PrintInfo()
        {
            int count = 20;
            found = vacanciesResponse.Found;            

            if (found <= count)
            {
                count = found;
                buttonNextPage.Enabled = false;
            }
            else
            {
                buttonNextPage.Enabled = true;
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

        /// <summary>
        /// Формирование адреса по параметрам поиска.
        /// </summary>
        /// <returns></returns>
        private string CreateUrl(int page)
        {
            string url = AllVacancies + "?page=" + page.ToString() + Ulyanovsk + IT + SimbirSoft;                 

            return url;
        }


        /// <summary>
        /// Выполнение запроса.
        /// </summary>
        /// <returns>Возвращает ответ.</returns>
        private VacanciesResponse CreateRequest(int page)
        {            
            string url = CreateUrl(page);

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

            return vacanciesResponse;
        }


        /// <summary>
        /// Переход по выбранному адресу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxVacancies_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            richTextBoxVacancies.Clear();
            buttonPrevPage.Enabled = true;
            vacanciesResponse = CreateRequest(++numPage);
            PrintInfo();
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            NumberVacancy = NumberVacancy - 40;
            if(NumberVacancy < 1)
            {
                buttonPrevPage.Enabled = false;
            }
            richTextBoxVacancies.Clear();                        
            vacanciesResponse = CreateRequest(--numPage);
            PrintInfo();            
        }


        private void checkBoxUlyanovsk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 

            if (checkBox.Checked == true)
            {
                numChecked++;
                Ulyanovsk = "&area=98";
                SelectInit();
            }
            else
            {
                Ulyanovsk = "";
                InitOrClear();
            }
        }

        private void checkBoxIT_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked == true)
            {
                numChecked++;
                IT = "&industry=7";
                SelectInit();
            }
            else
            {
                IT = "";
                InitOrClear();
            }
        }

        private void checkBoxSimbirSoft_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked == true)
            {
                numChecked++;
                SimbirSoft = "&text=Симбирсофт";
                SelectInit();
            }
            else
            {                
                SimbirSoft = "";
                InitOrClear();              
            }
        }

        private void SelectInit()
        {            
            richTextBoxVacancies.Clear();
            buttonPrevPage.Enabled = false;
            numPage = 0;
            NumberVacancy = 0;
            vacanciesResponse = CreateRequest(numPage);
            labelSelectVacancies.Enabled = true;
            labelSelectVacancies.Text = "Критериям поиска соответствуют : " + vacanciesResponse.Found;
            PrintInfo();
        }

        private void SelectClear()
        {
            richTextBoxVacancies.Clear();
            buttonPrevPage.Enabled = false;
            numPage = 0;
            NumberVacancy = 0;
            vacanciesResponse = CreateRequest(numPage);
            labelSelectVacancies.Text = "Критериям поиска соответствуют : ";
            labelSelectVacancies.Enabled = false;            
            PrintInfo();
        }

        private void InitOrClear()
        {
            numChecked--;

            if (numChecked == 0)
            {
                SelectClear();
            }
            else
            {
                SelectInit();
            }
        }
    }
}
