using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_01.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lblGiovanni_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroCliente.TelaCliente CadastroCliente = new CadastroCliente.TelaCliente();
            CadastroCliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            CadastroCarro.TelaCarro CadastroCarro = new CadastroCarro.TelaCarro();
            CadastroCarro.ShowDialog();
        }

        private void btnTic_Click(object sender, EventArgs e)
        {
            Ticket.TelaTicket Ticket = new Ticket.TelaTicket();
            Ticket.ShowDialog();
        }
    }
}
