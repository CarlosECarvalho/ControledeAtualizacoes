using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VersoesClientes.DBOperations
{
    class Editar
    {
        public Conexao Bd = new Conexao();
        public SqlCommand comando;
        string StrSQL;

        public void EditarAtz(int ID, string Exec, string Host, string Script, string Manager)
        {
            try 
	        {	        
		        string strSql = "UPDATE ATUALIZACAO SET VEREXEC = @VEREXEC, VERHOST = @VERHOST, VERSCRIPT = @VERSCRIPT, VERMANAG = @VERMANAG WHERE ID = @ID";

                    comando = new SqlCommand(strSql, Bd.Abrir());

                    comando.Parameters.AddWithValue("@ID", ID);
                    comando.Parameters.AddWithValue("@VEREXEC", Exec);
                    comando.Parameters.AddWithValue("@VERHOST", Host);
                    comando.Parameters.AddWithValue("@VERSCRIPT", Script);
                    comando.Parameters.AddWithValue("@VERMANAG", Manager);
                    comando.Parameters.AddWithValue("@DATAATZ", DateTime.Now);

                    comando.ExecuteNonQuery();

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

        public void EditarEmpresa(string oCNPJ, string CNPJ, string Nome)
        {
            try 
	        {	        
		        string strSql = "UPDATE ATUALIZACAO SET CNPJ = @CNPJ, NOME = @NOME WHERE CNPJ = @oCNPJ";

                    comando = new SqlCommand(strSql, Bd.Abrir());

                    comando.Parameters.AddWithValue("@CNPJ", CNPJ);
                    comando.Parameters.AddWithValue("@NOME", Nome);
                    comando.Parameters.AddWithValue("@oCNPJ", oCNPJ);
                    
                    comando.ExecuteNonQuery();
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
