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

namespace Cadastro;

public partial class Consulta : Form
{
    public Consulta()
    {
        InitializeComponent();
    }
    SqlConnection cn = new SqlConnection(@"Data Source=Macaco\SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");
    SqlCommand cm = new SqlCommand();
    DataTable dt = new DataTable();
    public void limparCampos()
    {
        txtcpf.Text = "";
    }

    private void btnlimpar_Click(object sender, EventArgs e)
    {
        limparCampos();
    }

    public void btnpesquisar_Click(object sender, EventArgs e)
    {
        try
        {
            string cpf = txtcpf.Text;
            cn.Open();//ABRINDO A CONEXÃO COM O BANCO DE DADOS
            string strSQL = "select * from cliente where cpf = '" + txtcpf.Text + "'";
            cm.Connection = cn;
            cm.CommandText = strSQL;
            SqlDataAdapter da = new SqlDataAdapter(strSQL,cn);
            SqlCommandBuilder bd = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcliente.DataSource = dt;
            limparCampos();
            cn.Close();//FECHANDO A CONEXÃO COM O BANCO DE DADOS
        }
        catch (Exception erro)
        {
            MessageBox.Show(erro.Message);
            cn.Close();

        }
    }

    private void btnsair_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}

