using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace VersoesClientes
{
    public class Conexao
    {
        private static string DtSource;
        private static string DtBase ;
        private static string User;
        private static string PWord;
        SqlConnection con = new SqlConnection();

        //construtor
        public Conexao()
        {
            DtSource = "CADU-DESK\\SQL2017";
            DtBase = "AtzSAG";
            User = "sa";
            PWord = "708015";
            
            con.ConnectionString = "Data Source=" + DtSource + ";Initial Catalog=" + DtBase + ";Persist Security Info=True;User ID=" + User + ";Password=" + PWord + ""; ;
        }

        //Conectar
        public SqlConnection Abrir()
        {
            try
            {
                if (con.State ==  ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch (Exception ex)
            {

                throw ex;
            }   
        }

        //desconectar
        public void Fechar()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
