using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersoesClientes.DBOperations;

namespace VersoesClientes
{
    public partial class Usuario : Form
    {
        Consultar consulta = new Consultar();

        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            consulta.NomeUsuario(cmbUsu);
            cmbUsu.DisplayMember = "NomeUsu";//Defino qual campo eu quero exibir
            cmbUsu.Text = "";
            ckHabilitado.Checked= false;
        }

        private void SelecionaUsu(object sender, EventArgs e)
        {
            bool status = Convert.ToBoolean( consulta.StatusUsuario(cmbUsu.Text.ToUpper().Trim(), ckHabilitado));
            cmbUsu.DisplayMember = "NomeUsu";//Defino qual campo eu quero exibir
            ckHabilitado.Checked = status;
        }
    }
}
