using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VersoesClientes.DBOperations;

namespace VersoesClientes
{
    public partial class Form1 : Form
    {
        SqlCommand comando = new SqlCommand();
        Conexao Bd = new Conexao();
        Consultar consulta = new Consultar();
        Inserir insert = new Inserir();

        public Form1()
        {
            InitializeComponent();
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            insert.Insere(mkCNPJ.Text, txtNome.Text, TxtExec.Text, txtHost.Text, txtScript.Text, txtManager.Text);
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            consulta.ExibirTodos(dgClientes);
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            consulta.ExibirEmpresa(dgClientes, txtNome.Text);
            
        }
    }
}
