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

namespace VersoesClientes
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter DA;
        SqlDataReader DR;
        string strSql;

        public Form1()
        {
            InitializeComponent();
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=CADU-DESK\\SQL2017;Initial Catalog=AtzSAG;Persist Security Info=True;User ID=sa;Password=708015");
                

                strSql = "INSERT INTO ATUALIZACAO (CNPJ, NOME, VEREXEC, VERHOST, VERSCRIPT, VERMANAG, DATAATZ) VALUES (@CNPJ, @NOME, @VEREXEC, @VERHOST, @VERSCRIPT, @VERMANAG, @DATAATZ)";

                comando = new SqlCommand(strSql, conexao);

                comando.Parameters.AddWithValue("@CNPJ", mkCNPJ.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@VEREXEC", TxtExec.Text);
                comando.Parameters.AddWithValue("@VERHOST", txtHost.Text);
                comando.Parameters.AddWithValue("@VERSCRIPT", txtScript.Text);
                comando.Parameters.AddWithValue("@VERMANAG", txtManager.Text);
                comando.Parameters.AddWithValue("@DATAATZ", DateTime.Now);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally{
                conexao.Close();
                conexao = null;
                comando = null;
            }
            
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=CADU-DESK\\SQL2017;Initial Catalog=AtzSAG;Persist Security Info=True;User ID=sa;Password=708015");

                strSql = "SELECT * FROM ATUALIZACAO";

                DataSet DS = new DataSet();

                DA = new SqlDataAdapter(strSql, conexao);

                conexao.Open();

                DA.Fill(DS);

                dgClientes.DataSource = DS.Tables[0];
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
            }
            
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=CADU-DESK\\SQL2017;Initial Catalog=AtzSAG;Persist Security Info=True;User ID=sa;Password=708015");

                strSql = "SELECT * FROM ATUALIZACAO WHERE NOME = @NOME ORDER BY DATAATZ DESC";

                comando = new SqlCommand(strSql, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);

                DataSet DS = new DataSet();

                DA = new SqlDataAdapter(comando);
                              
                conexao.Open();
                
                DA.Fill(DS);

                dgClientes.DataSource = DS.Tables[0];
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
            }
        }


      
    }
}
