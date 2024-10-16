using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btncadcliente_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btnconcliente_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.Show();
        }

        private void btnfuncionario_Click(object sender, EventArgs e)
        {
            Cadfuncionario cad = new Cadfuncionario();
            cad.Show();
        }

        private void btnconfun_Click(object sender, EventArgs e)
        {
            consulfunc con = new consulfunc();
            con.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadfuncionario cad = new Cadfuncionario();
            cad.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulfunc con = new consulfunc();
            con.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto p = new frmProduto();
            p.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consulpro cs = new consulpro();
            cs.Show();
        }
    }
}
