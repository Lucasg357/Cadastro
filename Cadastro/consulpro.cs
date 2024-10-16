using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class consulpro : Form
    {
        public consulpro()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=Macaco SQLEXPRESS;integrated security=SSPI;initial catalog= Cadastro");

        private void btnpesquisarfunc_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string strSql = "select * from produto where descricao='" + txtnomepro + "'";
                SqlCommand cmd = new SqlCommand(strSql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder bd = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpro.DataSource = dt;
                cn.Close();

            }
            catch {
                MessageBox.Show("erro");
            
            }
        }
    }
}
