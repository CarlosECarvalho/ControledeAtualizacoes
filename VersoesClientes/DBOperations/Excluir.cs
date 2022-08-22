using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersoesClientes.DBOperations
{
    public class Excluir
    {
        public Conexao Bd = new Conexao();
        public SqlCommand comando;
        string StrSQL;

        public void Remover(int ID)
        {
            try
            {
                StrSQL = "DELETE ATUALIZACAO WHERE ID = @ID";

                comando =new SqlCommand (StrSQL, Bd.Abrir());

                comando.Parameters.AddWithValue("@ID", ID);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso.");
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
