using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testador.Objeto;

namespace Testador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebServiceSoapSoapClient objeto = new ServiceReference1.WebServiceSoapSoapClient();

            try
            {
                richTextBox1.AppendText(objeto.Consumindo());
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText(ex.Message + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teste();
        }

        private async void Teste()
        {
            string url = "https://localhost:44386/weatherforecast";

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };


            using (var client = new HttpClient())
            {
                try
                {
                    using (var response = await client.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                            IList<WeatherForecast> objeto = JsonConvert.DeserializeObject<WeatherForecast[]>(ProdutoJsonString).ToList();

                            richTextBox1.Text = JsonConvert.SerializeObject(objeto, settings) + "\n";

                        }
                        else
                        {
                            richTextBox1.AppendText("Não foi possível obter o produto : " + response.StatusCode + "\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    richTextBox1.AppendText(ex.Message + "\n");
                }
            }
        }
    }
}
