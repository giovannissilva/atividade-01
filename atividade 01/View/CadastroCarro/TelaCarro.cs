using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_01.View.CadastroCarro
{
    public partial class TelaCarro : Form
    {
        public TelaCarro()
        {
            InitializeComponent();
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Dados()
        {
            if (string.IsNullOrWhiteSpace(cbxMarca.Text))
            {
                MessageBox.Show("Marca é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxMarca.Focus();
                cbxMarca.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxCarro.Text))
            {
                MessageBox.Show("Carro é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCarro.Focus();
                cbxCarro.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbxCor.Text))
            {
                MessageBox.Show("Cor é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCor.Focus();
                cbxCor.SelectAll();
                return;
            }
            else
            {
                MessageBox.Show("Carro Cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is ComboBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Dados();
            LimparTela();
        }
    }
}
