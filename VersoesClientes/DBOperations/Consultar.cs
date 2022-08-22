using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VersoesClientes.DBOperations
{
    public class Consultar
    {
        Conexao Bd = new Conexao();
        SqlDataAdapter DA;
        SqlDataReader DR;
        SqlCommand comando = new SqlCommand();
        string StrSql;

        public void ExibirTodos(DataGridView dgClientes)
        {
            try
            {
                StrSql = "SELECT * FROM ATUALIZACAO";

                DataSet DS = new DataSet();
                Bd = new Conexao();
                DA = new SqlDataAdapter(StrSql, Bd.Abrir());

                DA.Fill(DS);

                dgClientes.DataSource = DS.Tables[0];
            }
            finally
            {
                Bd.Fechar(); 
            }
        }

        public void ExibirEmpresa(DataGridView dgClientes, string Nome)
        {
            try
            {
                StrSql = "SELECT * FROM ATUALIZACAO WHERE NOME = @NOME ORDER BY DATAATZ DESC";
                Bd = new Conexao();
                comando = new SqlCommand(StrSql, Bd.Abrir());
                comando.Connection = Bd.Abrir();
                comando.Parameters.AddWithValue("@NOME", Nome);

                DataSet DS = new DataSet();

                DA = new SqlDataAdapter(comando);
                
                DA.Fill(DS);

                dgClientes.DataSource = DS.Tables[0];
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Bd.Fechar();
            }
        }
    }
}
