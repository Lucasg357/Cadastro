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
    public partial class consulfunc : Form
    {
        public consulfunc()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            txtcpffunc.Text = "";
        }
        SqlConnection cn = new SqlConnection(@"Data Source=Macaco\SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");
        private void btnpesquisarfunc_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql= "select * from funcionario where cpf = '" + txtcpffunc.Text + "'";
                SqlCommand cm = new SqlCommand(strSql,cn);
                SqlDataAdapter da = new SqlDataAdapter(strSql,cn);
                SqlCommandBuilder bd = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvfunc.DataSource = dt;
                limparCampos();
                cn.Close();//FECHANDO A CONEXÃO COM O BANCO DE DADOS
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cn.Close();

            }
        }
    }
}
