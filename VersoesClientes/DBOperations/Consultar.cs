using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace VersoesClientes.DBOperations
{
    public class Consultar
    {
        Conexao Bd = new Conexao();
        SqlDataAdapter DA;
        SqlDataReader DR;
        DataSet DS;
        SqlCommand comando = new SqlCommand();
        string StrSql;

        public void ExibirTodos(DataGridView dgClientes)
        {//exibe todas as atualizações registradas
            try
            {
                StrSql = "SELECT * FROM ATUALIZACAO";
                DS = new DataSet();
                DA = new SqlDataAdapter(StrSql, Bd.Abrir());

                DA.Fill(DS);
                if (DS.Tables.ToString().Length > -1)
                {
                    dgClientes.DataSource = DS.Tables[0];
                } else { MessageBox.Show("Não há nenhum registro."); }

            }
            finally
            {
                Bd.Fechar(); 
            }
        }

        public void ExibirEmpresa(DataGridView dgClientes, string Nome)
        {//exibe todos os dados de atualizações da empresa selecionada
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

        public void BuscaCam(Control Exec, Control Host, Control Script, Control Man)
        {//função que retorna o caminho informado para os arquivos de atualização
            try
            {
                StrSql = "SELECT * FROM CAMINHOS";
                DA = new SqlDataAdapter(StrSql, Bd.Abrir());
                DataSet DS = new DataSet();
                DA.Fill(DS);
            
                Exec.Text = DS.Tables[0].Rows[0].ItemArray[0].ToString();
                Host.Text = DS.Tables[0].Rows[0].ItemArray[1].ToString();
                Script.Text = DS.Tables[0].Rows[0].ItemArray[2].ToString();
                Man.Text = DS.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            finally
            {
                Bd.Fechar();
                DA = null;
                DS = null;
            }
        }

        public void UltVer(Control Exec, Control Host, Control Script, Control Man)
        {// funcao que retorna a versão atual para a tela principal do programa
            try
            {
                StrSql = "SELECT * FROM CAMINHOS";
                DA = new SqlDataAdapter(StrSql, Bd.Abrir());
                DataSet DS = new DataSet();
                DA.Fill(DS);

                string VerExec, VerHost, VerScr, VerMan;//coloco os caminhos dos arquivos nas variáveis que irão exibir a versão atual
                VerExec = DS.Tables[0].Rows[0].ItemArray[0].ToString().ToUpper();
                VerHost = DS.Tables[0].Rows[0].ItemArray[1].ToString().ToUpper();
                VerScr = DS.Tables[0].Rows[0].ItemArray[2].ToString().ToUpper();
                VerMan = DS.Tables[0].Rows[0].ItemArray[3].ToString().ToUpper();
                //faco o corte das informações que necessito para mostrar nos campos para o usuário.
                Exec.Text = CortaString(VerExec);
                Host.Text = CortaString(VerHost);
                Script.Text = CortaString(VerScr);
                Man.Text = CortaString(VerMan);

                string CortaString(string s)
                {
                    string[] sub = s.Split('\\'); //divido a string pelo caminho de pasta
                    int pos = sub.Length - 1;
                    int index = sub[pos].IndexOf("VER"); //corto a subsring com o nome do caminho a partir da informação da versão
                    string ver = sub[pos].Substring(index);
                    index = ver.Length;
                    ver = ver.Remove(index - 4); //removo a informação do formato do executável para limpar a informação que será exibida
                    return ver;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Bd.Fechar();
                DA = null;
                DS = null;
            }

            
        }

        public void NomeUsuario(ComboBox combo)
        {
            try
            {

                StrSql = "SELECT * FROM USUARIO";
                DS = new DataSet();
                DA = new SqlDataAdapter(StrSql, Bd.Abrir());

                DA.Fill(DS);
                
                if (DS.Tables.ToString().Length > -1)
                {
                    combo.DataSource = DS.Tables[0];
                }
            }
            catch (Exception Ex)
            {
                if (DS.Tables.Count < 1)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            finally
            {
                Bd.Fechar();
                DA = null;
                DS = null;
            }
        }

        public bool StatusUsuario(string nome, CheckBox check)
        {
            try
            {

                StrSql = "SELECT * FROM USUARIO WHERE NOMEUSU = @NOME";
                DS = new DataSet();
                comando = new SqlCommand(StrSql, Bd.Abrir());
                comando.Connection = Bd.Abrir();
                comando.Parameters.AddWithValue("@NOME", nome.ToUpper());
                DA = new SqlDataAdapter(comando);

                DA.Fill(DS);
                string value = DS.Tables[0].Rows[0].ItemArray[3].ToString();

                if (DS.Tables.ToString().Length > -1)
                {
                    if (value == "S")
                    {
                        return check.Checked = true;
                    }
                    else {
                        return check.Checked = false;
                    }
                } else
                {
                    MessageBox.Show("Registro não encontrado.");
                    return check.Checked = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return check.Checked = false;
            }
            finally
            {
                Bd.Fechar();
                DA = null;
                DS = null;
            }
        }

        public string UsuarioExiste(string nome)
        {
            string nomeUsu;
            try
            {
                StrSql = "SELECT * FROM USUARIO WHERE NOMEUSU = @NOME";
                DS = new DataSet();
                comando = new SqlCommand(StrSql, Bd.Abrir());
                comando.Connection = Bd.Abrir();
                comando.Parameters.AddWithValue("@NOME", nome.ToUpper());
                DA = new SqlDataAdapter(comando);

                DA.Fill(DS);
                nomeUsu = DS.Tables[0].Rows[0].ItemArray[1].ToString().Trim();

                return nomeUsu;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Não há linha na posição 0.")
                    return nomeUsu = string.Empty;

                MessageBox.Show(ex.Message, "Erro de verificação!");
                return nomeUsu = string.Empty;
            }
            finally
            {
                Bd.Fechar();
                DA = null;
                DS = null;
            }

        }

        public int IdUsu (string nome)
        {
            int IdUsu;
            try
            {
                StrSql = "SELECT * FROM USUARIO WHERE NOMEUSU = @NOME";
                DS = new DataSet();
                comando = new SqlCommand(StrSql, Bd.Abrir());
                comando.Connection = Bd.Abrir();
                comando.Parameters.AddWithValue("@NOME", nome.ToUpper());
                DA = new SqlDataAdapter(comando);

                DA.Fill(DS);
                IdUsu = Convert.ToInt32( DS.Tables[0].Rows[0].ItemArray[0].ToString());
                return IdUsu;
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de verificação!");
                return IdUsu = 0;
               
            }
            finally
            {
                Bd.Fechar();
                DA = null;
                DS = null;
            }
        }
    }
}