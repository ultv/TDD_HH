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
        int numberVacancy = 0;
        int foundVacancies = 0;
        int numPage = 0;        
        int numChecked = 0;
        string allVacancies = "https://api.hh.ru/vacancies";
        string Ulyanovsk = "";
        string IT = "";
        string SimbirSoft = "";                
        VacanciesResponse vacanciesResponse;

        public Form1()
        {
            InitializeComponent();

            vacanciesResponse = CreateRequest(numPage);
            foundVacancies = vacanciesResponse.Found;
            labelCountVacancies.Text += foundVacancies.ToString();
            PrintInfo();
        }
        
        /// <summary>
        /// Вывод списка вакансий.
        /// </summary>
        private void PrintInfo()
        {
            int count = vacanciesResponse.Per_page;
            foundVacancies = vacanciesResponse.Found;            

            if (foundVacancies <= count)
            {
                count = foundVacancies;
                buttonNextPage.Enabled = false;
            }
            else
            {
                buttonNextPage.Enabled = true;
            }

            if(vacanciesResponse.Items.Count() < count)
            {
                count = vacanciesResponse.Items.Count();
                buttonNextPage.Enabled = false;
            }

            for (int i = 0; i < count; i++)
            {
                numberVacancy++;

                richTextBoxVacancies.AppendText($"{numberVacancy}. {vacanciesResponse.Items[i].Name}\n");

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
        /// Формирование адреса с добавлением параметров.
        /// </summary>
        /// <param name="page">Принимает номер запрашиваемой страницы.</param>
        /// <returns>Возвращает адрес с передаваемыми параметрами.</returns>        
        private string CreateUrl(int page)
        {
            string url = allVacancies + "?page=" + page.ToString() + Ulyanovsk + IT + SimbirSoft;                 

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

        /// <summary>
        /// Нажатие на кнопку "Следующая страница".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            richTextBoxVacancies.Clear();
            buttonPrevPage.Enabled = true;
            vacanciesResponse = CreateRequest(++numPage);
            PrintInfo();
        }

        /// <summary>
        /// Нажатие на кнопку "Предыдущая страница."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            numberVacancy = numberVacancy - (vacanciesResponse.Per_page + vacanciesResponse.Items.Count());
            if(numberVacancy < 1)
            {
                buttonPrevPage.Enabled = false;
            }
            richTextBoxVacancies.Clear();                        
            vacanciesResponse = CreateRequest(--numPage);
            PrintInfo();            
        }

        /// <summary>
        /// Изменение критерия поиска "Ульяновск".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Изменение критерия поиска "IT".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Изменение критерия поиска "СимбирСофт".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// В случае выбора критерия поиска.
        /// </summary>
        private void SelectInit()
        {            
            richTextBoxVacancies.Clear();
            buttonPrevPage.Enabled = false;
            numPage = 0;
            numberVacancy = 0;
            vacanciesResponse = CreateRequest(numPage);
            labelSelectVacancies.Enabled = true;
            labelSelectVacancies.Text = "Критериям поиска соответствуют : " + vacanciesResponse.Found;
            PrintInfo();
        }

        /// <summary>
        /// В случае отмены всех критериев поиска.
        /// </summary>
        private void SelectClear()
        {
            richTextBoxVacancies.Clear();
            buttonPrevPage.Enabled = false;
            numPage = 0;
            numberVacancy = 0;
            vacanciesResponse = CreateRequest(numPage);
            labelSelectVacancies.Text = "Критериям поиска соответствуют : ";
            labelSelectVacancies.Enabled = false;            
            PrintInfo();
        }

        /// <summary>
        /// Действия при наличии или отсутствии критериев поиска.
        /// </summary>
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
