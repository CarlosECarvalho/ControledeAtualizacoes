using System;
using System.Data.SqlClient;
using System.Drawing;
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
        Editar edit = new Editar();
        Excluir exclui = new Excluir();
        DialogResult result = DialogResult.None;
        string oCNPJ, oNome, oExe, oScr, oHost, oMan;
        int index = -1;
        DataGridViewRow select;

        public Form1()
        {
            InitializeComponent();
            mkCNPJ.ReadOnly = true;
            TxtExec.ReadOnly = true;
            txtScript.ReadOnly = true;
            txtHost.ReadOnly = true;
            txtManager.ReadOnly = true;
            txtNome.ReadOnly = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0 && mkCNPJ.Text.Length > 0 && index > -1)
            {
              string id = select.Cells[0].Value.ToString();
              exclui.Remover(Convert.ToInt32(id));
              consulta.ExibirTodos(dgClientes);
            }
            else { MessageBox.Show("Você não informou dados suficientes"); }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0 && mkCNPJ.Text.Length > 0)
            { insert.Insere(mkCNPJ.Text, txtNome.Text, TxtExec.Text, txtHost.Text, txtScript.Text, txtManager.Text);}
            else { MessageBox.Show("Você não informou dados suficientes"); }
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            consulta.ExibirTodos(dgClientes);
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0)
            { consulta.ExibirEmpresa(dgClientes, txtNome.Text); }
            else { MessageBox.Show("Você não informou dados suficientes"); }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgClientes.SelectedRows.Count > -1 && dgClientes.SelectedRows[0].Index != dgClientes.SelectedRows.Count - 2) 
                {

                    index = e.RowIndex;
                    select = dgClientes.Rows[index];
                    mkCNPJ.Text = select.Cells[1].Value.ToString();
                    TxtExec.Text = select.Cells[3].Value.ToString();
                    txtScript.Text = select.Cells[5].Value.ToString();
                    txtHost.Text = select.Cells[4].Value.ToString();
                    txtManager.Text = select.Cells[6].Value.ToString();
                    txtNome.Text = select.Cells[2].Value.ToString();

                    mkCNPJ.ReadOnly = true;
                    TxtExec.ReadOnly = true;
                    txtScript.ReadOnly = true;
                    txtHost.ReadOnly = true;
                    txtManager.ReadOnly = true;
                    txtNome.ReadOnly = true;

                    mkCNPJ.BackColor = Color.White;
                    TxtExec.BackColor = Color.White;
                    txtScript.BackColor = Color.White;
                    txtHost.BackColor = Color.White;
                    txtManager.BackColor = Color.White;
                    txtNome.BackColor = Color.White;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            
            try
            {                    
                if (result == DialogResult.None)
                {
                    if (index > -1)
                    {
                        result = MessageBox.Show("Você está editando os dados da Empresa?\n\nSim - Somente CNPJ e Empresa poderão ser alterados.\n\nNão - Somente dados desta atualização poderão ser alterados.", "Atenção", MessageBoxButtons.YesNo);
                        oCNPJ = mkCNPJ.Text;
                        oNome = txtNome.Text;
                        oExe = TxtExec.Text;
                        oScr = txtScript.Text;
                        oHost = txtHost.Text;
                        oMan = txtManager.Text;
                    }
                    else
                    {
                        MessageBox.Show("Você não selecionou um registro!");
                        goto fim;
                    }
                }
                if (result == DialogResult.Yes)
                {
                    TxtExec.Enabled = false;
                    txtScript.Enabled = false;
                    txtHost.Enabled = false;
                    txtManager.Enabled = false;
                    mkCNPJ.ReadOnly = false;
                    txtNome.ReadOnly = false;
                    
                    if (mkCNPJ.Enabled == false && txtNome.Enabled == false)
                    {
                        mkCNPJ.Enabled = true;
                        txtNome.Enabled = true;
                        result = DialogResult.None;
                    }
                    if (mkCNPJ.Text != oCNPJ || txtNome.Text != oNome)
                    {
                        DialogResult res = DialogResult.None;
                        res = MessageBox.Show("Deseja salvar as alterações?\nTodos os registros desta empresa serão modificados.","Atenção", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.OK)
                        {
                            edit.EditarEmpresa(oCNPJ, mkCNPJ.Text, txtNome.Text);
                            consulta.ExibirTodos(dgClientes);
                            result = DialogResult.None;
                            mkCNPJ.ReadOnly = true;
                            txtNome.ReadOnly = true;
                            TxtExec.Enabled = true;
                            txtScript.Enabled = true;
                            txtHost.Enabled = true;
                            txtManager.Enabled = true;
                        }
                    }
                }
                else
                {
                    mkCNPJ.Enabled = false;
                    txtNome.Enabled = false;
                    TxtExec.ReadOnly = false;
                    txtScript.ReadOnly = false;
                    txtHost.ReadOnly = false;
                    txtManager.ReadOnly = false;
                    if (TxtExec.Enabled == false && txtScript.Enabled == false && txtManager.Enabled == false)
                    {
                        TxtExec.Enabled = true;
                        txtScript.Enabled = true;
                        txtHost.Enabled = true;
                        txtManager.Enabled = true;
                        
                    } if (TxtExec.Text != oExe || txtScript.Text != oScr || txtHost.Text != oHost || txtManager.Text != oMan)
                    {
                        DialogResult res = DialogResult.None;
                        res = MessageBox.Show("Deseja salvar as alterações?\nEste registro de atualização será modificado.", "Atenção", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.OK)
                        {
                            index++;
                            edit.EditarAtz(index, TxtExec.Text, txtHost.Text, txtScript.Text, txtManager.Text);
                            consulta.ExibirTodos(dgClientes);
                            result = DialogResult.None;
                            mkCNPJ.Enabled = true;
                            txtNome.Enabled = true;
                            TxtExec.ReadOnly = true;
                            txtScript.ReadOnly = true;
                            txtHost.ReadOnly = true;
                            txtManager.ReadOnly = true;

                        }
                    }
                    
                }
            fim:;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DialogResult res = DialogResult.None;
            }
        }
    }
}
