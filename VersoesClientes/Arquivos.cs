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
    public partial class Arquivos : Form
    {
        OpenFileDialog opd = new OpenFileDialog();
        string camarq;
        public Arquivos()
        {
            InitializeComponent();
            Consultar consulta = new Consultar();
            consulta.BuscaCam(txtCamExec, txtCamHost, txtCamScr, txtCamMan);
        }

        private void CamExec_Click(object sender, EventArgs e)
        {
            txtCamExec.Clear();
            opd.Multiselect = true;
            opd.Title = "Selecione o caminho do Executável!";
            opd.InitialDirectory = @"C:\";
            opd.Filter = "Arquivos(*.rar;*.zip)|*.rar;*.zip|Todos(*.*)|*.*";
            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.FilterIndex = 2;
            opd.RestoreDirectory = true;
            opd.ReadOnlyChecked = true;
            opd.ShowReadOnly = true;

            DialogResult res = opd.ShowDialog();
            if(res == DialogResult.OK)
            {
                camarq = opd.FileName;
                txtCamExec.Text = camarq;
            }
        }

        private void CamHost_Click(object sender, EventArgs e)
        {
            txtCamHost.Clear();
            opd.Multiselect = true;
            opd.Title = "Selecione o caminho do Host!";
            opd.InitialDirectory = @"C:\";
            opd.Filter = "Arquivos(*.rar;*.zip)|*.rar;*.zip|Todos(*.*)|*.*";
            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.FilterIndex = 2;
            opd.RestoreDirectory = true;
            opd.ReadOnlyChecked = true;
            opd.ShowReadOnly = true;

            DialogResult res = opd.ShowDialog();
            if (res == DialogResult.OK)
            {
                camarq = opd.FileName;
                txtCamHost.Text = camarq;
            }
        }

        private void CamScr_Click(object sender, EventArgs e)
        {
            txtCamScr.Clear();
            opd.Multiselect = true;
            opd.Title = "Selecione o caminho do Script!";
            opd.InitialDirectory = @"C:\";
            opd.Filter = "Arquivos(*.rar;*.zip)|*.rar;*.zip|Todos(*.*)|*.*";
            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.FilterIndex = 2;
            opd.RestoreDirectory = true;
            opd.ReadOnlyChecked = true;
            opd.ShowReadOnly = true;

            DialogResult res = opd.ShowDialog();
            if (res == DialogResult.OK)
            {
                camarq = opd.FileName;
                txtCamScr.Text = camarq;
            }
        }

        private void CamEdoc_Click(object sender, EventArgs e)
        {
            txtCamMan.Clear();
            opd.Multiselect = true;
            opd.Title = "Selecione o caminho do ManagerEdoc!";
            opd.InitialDirectory = @"C:\";
            opd.Filter = "Arquivos(*.rar;*.zip)|*.rar;*.zip|Todos(*.*)|*.*";
            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            opd.FilterIndex = 2;
            opd.RestoreDirectory = true;
            opd.ReadOnlyChecked = true;
            opd.ShowReadOnly = true;

            DialogResult res = opd.ShowDialog();
            if (res == DialogResult.OK)
            {
                camarq = opd.FileName;
                txtCamMan.Text = camarq;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir insere = new Inserir();

            insere.InsereCaminho(txtCamExec.Text, txtCamHost.Text, txtCamScr.Text, txtCamMan.Text);
        }
    }
}
