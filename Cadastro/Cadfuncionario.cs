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
    public partial class Cadfuncionario : Form
    {
        public Cadfuncionario()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=Macaco\SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");
        SqlCommand cm = new SqlCommand();

        public void limparCampos()
        {
            txtcpffunc.Text = "";
            txtnomefunc.Text = "";
            txttelfunc.Text = "";
            txtsal.Text = "";
            txtemail.Text = "";
        }

        private void Cadfuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnlimparfunc_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btninserirfunc_Click(object sender, EventArgs e)
        {
            try
            {
                string nomef = txtnomefunc.Text;
                string telf = txttelfunc.Text;
                string emailf = txtemail.Text;
                string cpff = txtcpffunc.Text;
                string salf = txtsal.Text;
                string sexof = cmbsexo.Text;
                cn.Open();//ABRINDO A CONEXÃO COM O BANCO DE DADOS
                SqlCommand cm = new SqlCommand("insert into funcionario(nome,telefone,salario,email,cpf,sexo)values('" + nomef + "','" + telf + "','" + salf + "','" + emailf + "','" + cpff + "','" + sexof + "')");
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                MessageBox.Show("Dados cadastrados com sucesso");
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
