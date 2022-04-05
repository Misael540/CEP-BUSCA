using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busca_CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CEP = (string)textCep.Text;

            var requisicaoWeb = WebRequest.CreateHttp("https://viacep.com.br/ws/" + CEP + "/json/");
            requisicaoWeb.Method = "GET";

            try
            {
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();

                    StreamReader reader = new StreamReader(streamDados);

                    object objResponse = reader.ReadToEnd();

                    var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());

                    if (post.CEP != string.Empty)
                    {
                        cep.Text = post.CEP;
                        rua.Text = post.Logradouro;
                        comple.Text = post.Complemento;
                        bairro.Text = post.Bairro;
                        cidade.Text = post.Localidade;
                        uf.Text = post.UF;
                        ddd.Text = post.DDD;
                        ibge.Text = post.IBGE;

                        status.Text = "CEP Encontrado!";
                        status.ForeColor = Color.Green;

                    }
                    else
                    {
                        status.Text = "CEP Não Encontrado!";
                        status.ForeColor = Color.Red;

                    }

                    streamDados.Close();
                    resposta.Close();
                }
            }
            catch
            {
                status.Text = "CEP Não Encontrado!";
                status.ForeColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = "CEP: " + cep.Text + " \n";
            texto += "Rua: " + rua.Text + " \n";
            texto += "Complemento: " + comple.Text + " \n";
            texto += "Bairro: " + bairro.Text + " \n";
            texto += "Cidade: " + cidade.Text + " \n";
            texto += "UF: " + uf.Text + " \n";
            texto += "DDD: " + ddd.Text + " \n";
            texto += "IBGE: " + ibge.Text + " \n";

            Clipboard.SetText(texto);

            MessageBox.Show("Texto Copiado!");
        }
    }
}
