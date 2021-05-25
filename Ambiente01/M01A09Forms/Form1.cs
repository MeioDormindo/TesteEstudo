using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace M01A09Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnOK_ClickAsync(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int anoNasc = -1;
            int.TryParse(txtNasc.Text, out anoNasc);

            if (anoNasc > 0)
            {
                Random ger = new Random();
                anoNasc = DateTime.Now.Year - anoNasc;
                int inc = ger.Next(10000,999999);
                if (anoNasc >= 18)
                {
                    lblInc.Visible = false;
                    lblMsg.Text = "Aguarde um momento por favor! Estamos gerando sua incrição.";
                    lblMsg.Visible = true;
                    int salario = 2700;
                    
                    await Task.Delay(3000);

                    lblMsg.Text = $"Prazer {nome}! Voce tem {anoNasc} anos! Voce está concorrendo a uma vaga de {salario:C} por mês.";
                   
                    lblInc.Text =  $"O código da sua inscrição é {inc:x} ou {inc:e} ou {inc} gerado em " +
                        $"{DateTime.Now.Day}/{DateTime.Now.Month}/{ DateTime.Now.Year}:{ DateTime.Now.Hour}:"+
                        $"{ DateTime.Now.Minute}:{ DateTime.Now.Second}.";
                    lblInc.Visible = true;
                }
                else
                {
                    lblInc.Visible = false;
                    lblMsg.Text = "Aguarde um momento por favor! Estamos gerando sua incrição.";
                    lblMsg.Visible = true;

                    await Task.Delay(3000);
                    lblMsg.Text = $"Prazer {nome}! Voce tem {anoNasc} anos e precisa completar 18 anos para esta vaga.";
                    
                }
                
            }
            else
            {
                lblInc.Visible = false;
                lblMsg.Text = "Aguarde um momento por favor! Estamos gerando sua incrição.";
                lblMsg.Visible = true;

                await Task.Delay(3000);
                string erro = txtNasc.Text;
                lblMsg.Text = "Voce precisa digitar um ano valido, mas voce digitou: " +erro;
            }
            lblMsg.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
