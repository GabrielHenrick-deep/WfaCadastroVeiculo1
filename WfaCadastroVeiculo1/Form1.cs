using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WfaCadastroVeiculo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GerarListViewOninus();
            pictureBoxImage.Image = Properties.Resources.branco;
        }

        private void rbOnibus_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxImage.Image = Properties.Resources.onibus1;
            masked_Placa.Mask = "AAA-0000";
            label_ano.Text = "Ano";
            label_qtdAE.Text = "Qtd Assentos";
        }

        private void rb_Truck_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxImage.Image = Properties.Resources.Truck1;
            masked_Placa.Mask = "AAA-0000";
            label_ano.Text = "Ano";
            label_qtdAE.Text = "Qtd Eixos";
        }

        private void button_cad_Click(object sender, EventArgs e)
        {
            bool recebeValidacao = validaInformacao();
            if(rbOnibus.Checked == true && recebeValidacao == true ) 
            {
                Veiculo bus = new Onibus(masked_Placa.Text, Convert.ToInt32(tb_ano.Text), Convert.ToInt32(tb_qtdAE.Text));
                string[] veicluos = new string[5];
                veicluos[0] = Convert.ToString(masked_Placa.Text);
                veicluos[1] = tb_ano.Text;
                veicluos[2] = tb_qtdAE.Text;
                veicluos[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:c}", bus.Alugar());
                listView1.Items.Add(new ListViewItem(veicluos));
                MessageBotao();
                
            }
            else if(rb_Truck.Checked == true && recebeValidacao == true)
            {
                Veiculo truk = new Caminhao(Convert.ToString(masked_Placa.Text), Convert.ToInt32(tb_ano.Text), Convert.ToInt32(tb_qtdAE.Text));
                string[] truks = new string[5];
                truks[0] = masked_Placa.Text;
                truks[1] = tb_ano.Text;
                truks[3] = tb_qtdAE.Text;
                truks[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:c}", truk.Alugar());
                listView1.Items.Add(new ListViewItem(truks));
                MessageBotao();
                
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            masked_Placa.Text = string.Empty;
            tb_ano.Text = string.Empty;
            tb_qtdAE.Text = string.Empty;
            
        }

        private void tb_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 202)
            {
                e.Handled = true;
            }
        }

        private void tb_qtdAE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar != 8 && e.KeyChar != 202)
            { e.Handled = true; }
        }
        private void MessageBotao()
        {
            MessageBox.Show("Dados Cadastrados com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MessageBotao(string nomeLabel)
        {
            MessageBox.Show("Voce deve Informar o " + nomeLabel + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool validaInformacao()
        {
            bool validaInfo = true;
            if(masked_Placa.MaskCompleted == false)
            {
                MessageBotao(label_placa.Text);
            }
            else if(tb_ano.Text.Trim() == string.Empty)
            {
                MessageBotao(label_ano.Text);
                validaInfo = false;
            }
            else if(tb_qtdAE.Text.Trim() == string.Empty)
            {
                MessageBotao(label_qtdAE.Text);
                validaInfo = false;
            }
            return validaInfo;
        }
       public void GerarListViewOninus()
        {
            listView1.Columns.Add("Placa", 90).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Ano", 90).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Assentos", 90).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Eixo", 90).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Diária", 90).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;
        }
    }
}
