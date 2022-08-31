using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VersoesClientes
{
    public class Inserir
    {
        public Conexao Bd = new Conexao();
        public SqlCommand comando;
        string strSql;

        public void Insere(string CNPJ, string Nome, string Exec, string Host, string Script, string Manager)
        {
            try
            {
                strSql = "INSERT INTO ATUALIZACAO (CNPJ, NOME, VEREXEC, VERHOST, VERSCRIPT, VERMANAG, DATAATZ) VALUES (@CNPJ, @NOME, @VEREXEC, @VERHOST, @VERSCRIPT, @VERMANAG, @DATAATZ)";

                comando = new SqlCommand(strSql, Bd.Abrir());

                comando.Parameters.AddWithValue("@CNPJ", CNPJ);
                comando.Parameters.AddWithValue("@NOME", Nome);
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
                comando = null;
                strSql = null;
            }
        }

        public void InsereCaminho (string Exec, string Host, string Script, string Man)
        {
            try
            {
                strSql = "INSERT INTO CAMINHOS (CamExec, CamHost, CamScr ,CamMan , DataAlt) VALUES (@EXEC, @HOST, @SCR, @MAN, @DATA)";

                comando = new SqlCommand(strSql, Bd.Abrir());

                comando.Parameters.AddWithValue("@EXEC", Exec);
                comando.Parameters.AddWithValue("@HOST", Host);
                comando.Parameters.AddWithValue("@SCR", Script);
                comando.Parameters.AddWithValue("@MAN", Man);
                comando.Parameters.AddWithValue("@DATA", DateTime.Now);

                comando.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Bd.Fechar();
                comando = null;
                strSql = null;
            }
            
        }
    }
}
