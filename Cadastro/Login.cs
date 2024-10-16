using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cadastro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=Macaco\SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");
        SqlCommand cm = new SqlCommand();

        private void Login_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
            cn.Open();
            cn.Close();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string strSQL = "select * from login where senha ='" + txtsenha.Text + "' and usuario ='" + txtusuario.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(strSQL, cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Menu frm = new Menu();
                    frm.Show();
                }
                else
                {

                    MessageBox.Show("erro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                cn.Close();
            }
        }
      }
  }

