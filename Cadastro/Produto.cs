using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=Macaco\SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");
        private void btninserirpro_Click(object sender, EventArgs e)
        {
            string descricao = txtdescricao.Text;
            string valor = mdtvalor.Text;
            try
            {
                cn.Open();
                string str = "insert into produto(descricao,valor)values('" + descricao + "','" + valor + "')";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastrado");
                cn.Close();
            }
            catch
            {
            }
        }

        private void btnlimparpro_Click(object sender, EventArgs e)
        {
            txtdescricao.Text = "";
            mdtvalor.Text = "";
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
