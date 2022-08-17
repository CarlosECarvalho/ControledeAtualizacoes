using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersoesClientes.DBOperations
{
    class Editar
    {
        public Conexao Bd = new Conexao();
        public SqlCommand comando;
        string StrSQL;

        public void EditarAtz()
        {
            string strSql = "UPDATE ATUALIZACAO SET VEREXEC = @VEREXEC, VERHOST = @VERHOST, VERSCRIPT = @VERSCRIPT, VERMANAG = @VERMANAG WHERE ID = @ID";

            comando = new SqlCommand(strSql, Bd.Abrir());

        }

        public void EditarEmpresa()
        {

        }
    }
}
