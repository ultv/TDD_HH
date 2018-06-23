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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetVacanties_Click(object sender, EventArgs e)
        {
            string url = "https://api.hh.ru/vacancies";

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

            for(int i = 0; i < 20; i++)
            {
                textBoxVacncies.AppendText(vacanciesResponse.Items[i].Name + "\n");
            }
            
        }
    }
}
