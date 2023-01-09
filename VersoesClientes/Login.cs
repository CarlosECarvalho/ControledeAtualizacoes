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
using VersoesClientes.DBOperations;

namespace VersoesClientes
{
    public partial class Login : Form
    {
        Consultar consulta = new Consultar();
        public Login()
        {
            InitializeComponent();

        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            consulta.NomeUsuario(cmbUsu);
            cmbUsu.DisplayMember = "NomeUsu";//Defino qual campo eu quero exibir
            cmbUsu.Text = "";
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            string nome = cmbUsu.Text.ToUpper().Trim();
            if (nome.Length > 1 && nome != string.Empty) //verifico se o campo está vazio
            {
                nome = consulta.UsuarioExiste(nome);
                if (nome == cmbUsu.Text.ToUpper().Trim()) //verifico se o usuário retornado é o mesmo que está na combo
                {
                    MessageBox.Show("Este operador já existe.");
                }else
                {
                    Inserir insere = new Inserir();
                    insere.CadUsuario(cmbUsu.Text.ToUpper());
                    cmbUsu.Text = "";
                    consulta.NomeUsuario(cmbUsu);
                }
            }
            else
            {
                MessageBox.Show("O campo está vazio está vazio.");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = cmbUsu.Text.ToUpper().Trim();
            if (nome.Length > 1 && nome != string.Empty)
            {
                nome = consulta.UsuarioExiste(nome);
                if (nome == cmbUsu.Text.ToUpper().Trim())
                {
                    Login login = new Login();
                    Principal principal = new Principal(nome);
                    principal.Show();
                    
                }
                else
                {
                    MessageBox.Show("Operador não cadastrado.");
                }
                
            }
            else
            {
                MessageBox.Show("O campo está vazio está vazio.");
            }
        }
    }
}
