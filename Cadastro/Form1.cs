using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        //COMANDO PARA A CONEXÃO COM O BANCO DE DADOS
        SqlConnection cn = new SqlConnection(@"Data Source=Macaco\SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");
        SqlCommand cm = new SqlCommand();

        public void limparCampos()
        {
            txtcpf.Text = "";
            txtemail.Text = "";
            txtnome.Text = "";
            txttel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {
            cn.Open();
            cn.Close();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtnome.Text;
                string tel = txttel.Text;
                string email = txtemail.Text;
                string cpf = txtcpf.Text;
                cn.Open();//ABRINDO A CONEXÃO COM O BANCO DE DADOS
                string strSQL = "insert into cliente(nome,telefone,email,cpf)values('" + nome +"','"+ tel +"','"+ email +"','"+ cpf +"')";
                cm.Connection = cn;
                cm.CommandText = strSQL;
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
