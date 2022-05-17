using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_01.View.CadastroCliente
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void validaCpf()
        {
            if (string.IsNullOrWhiteSpace(tbxCPF.Text))
            {
                MessageBox.Show("CPF É Obrigatório", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCPF.Focus();
                tbxCPF.SelectAll();
                return;
            }
            string cpfInformar = tbxCPF.Text.Replace(".", "").Replace("-", "");


            if (cpfInformar.Length != 11)
            {

                lblResul.Text =  "Informe seu CPF com 11 digitos.";
                lblResul.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformar.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            int dv1 = (int)soma % 11;

            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }
            if (!cpfInformar.Substring(9, 1).Equals(dv1.ToString()))
            {
                lblResul.Text = "Informe um CPF Válido.";
                lblResul.ForeColor = Color.Red;
                return;
            }

            cpf = cpf + dv1.ToString();
            valorRef = 11;
            soma = 0;

            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            int dv2 = (int)soma % 11;

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            if (!cpfInformar.Substring(10, 1).Equals(dv2.ToString()))
            {
                lblResul.Text = "Informe um CPF Válido.";
                lblResul.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResul.Text = "CPF Válido";
                lblResul.ForeColor = Color.Green;
                return;
            }

        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            validaCpf();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblResul_Click(object sender, EventArgs e)
        {

        }
    }
}
