using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using VersoesClientes.DBOperations;
using System.IO;

namespace VersoesClientes
{
    public partial class Principal : Form
    {
        SqlCommand comando = new SqlCommand();
        Conexao Bd = new Conexao();
        Consultar consulta = new Consultar();
        Inserir insert = new Inserir();
        Editar edit = new Editar();
        Excluir exclui = new Excluir();
        DialogResult result = DialogResult.None;
        string oCNPJ, oNome, oExe, oScr, oHost, oMan, uNome;
        int index = -1;
        DataGridViewRow select;
        FileSystemWatcher fso;
        Login login = new Login();

        public Principal(string nome)
        {
            InitializeComponent();
        
            //inicializo os campos apenas como leitura para evitar que insira novos registros acidentalmente.
            mkCNPJ.ReadOnly = true;
            TxtExec.ReadOnly = true;
            txtScript.ReadOnly = true;
            txtHost.ReadOnly = true;
            txtManager.ReadOnly = true;
            txtNome.ReadOnly = true;
            uNome = nome;
            consulta.UltVer(TxtExec, txtHost, txtScript, txtManager);
            lblUsu.Text= ($"Você está logado como: {nome}");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fso = new FileSystemWatcher(@"D:\Users\Cadu\Music")
            {// filtro os arquivos conforme o caminho informado na parametrização
                Filter = "*.rar",
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.CreationTime,
                EnableRaisingEvents = true
            };
            fso.Changed += OnActionOccurOnFolderPath;
            fso.Created += OnActionOccurOnFolderPath;
            fso.Deleted += OnActionOccurOnFolderPath;
            fso.Renamed += OnFileRenameOccur;


        }


        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > -1 && mkCNPJ.Text.Length > -1 && index > -1)// verifrico se o registro possui nome e CNPJ
            {
              string id = select.Cells[0].Value.ToString(); //obtenho o id da linha selecionada
              exclui.Remover(Convert.ToInt32(id));
              consulta.ExibirTodos(dgClientes);
            }
            else { MessageBox.Show("Você não informou dados suficientes.\nSelecione um registro para excluir."); }
        }

        private void MenuArquivos_Click(object sender, EventArgs e)
        {
            Arquivos arquivos = new Arquivos();
            arquivos.Show();
        }

        
            private void OnFileRenameOccur(object sender, RenamedEventArgs e)
            { //informo que houve mudanças no arquivo 
                MessageBox.Show("O arquivo foi renomeado!\nNome Anterior:" + e.OldName + "\nNome atual: " + e.Name);
            }

            private void OnActionOccurOnFolderPath(object sender, FileSystemEventArgs e)
            {
                    MessageBox.Show("O arquivo mudou!\n" + e.Name + "\n");
            }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Login login = new Login();
                login.Show();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            var cadastro = new Usuario();
            cadastro.Show();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {//habilito os campos para preenchimento
            mkCNPJ.ReadOnly = false;
            TxtExec.ReadOnly = false;
            txtScript.ReadOnly = false;
            txtHost.ReadOnly = false;
            txtManager.ReadOnly = false;
            txtNome.ReadOnly = false;
            btNovo.Text = "Salvar";

            if(mkCNPJ.Text.Length == 14 && txtNome.Text.Length != 0)
            {
                result = MessageBox.Show("             Você deseja salvar?", "Atenção", MessageBoxButtons.YesNo);
                if ( result == DialogResult.Yes)
                {//faço o insert, exibo a grade e bloqueio os botões para edição novamente.
                    

                    insert.InsereAtualizacao(mkCNPJ.Text, txtNome.Text, TxtExec.Text, txtHost.Text, txtScript.Text, txtManager.Text, uNome);
                    consulta.ExibirTodos(dgClientes);
                    mkCNPJ.ReadOnly = true;
                    TxtExec.ReadOnly = true;
                    txtScript.ReadOnly = true;
                    txtHost.ReadOnly = true;
                    txtManager.ReadOnly = true;
                    txtNome.ReadOnly = true;
                }
                else
                { MessageBox.Show("Abortado pelo usuário!"); }
                
            }
            
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
                if (dgClientes.SelectedRows.Count > -1) 
                {
                    //faço o carregamento dos registros no grid
                    index = e.RowIndex;//leio o indice no grid para preencher
                    select = dgClientes.Rows[index];
                    index = Convert.ToInt32( select.Cells[0].Value); //recebo o indice do id na tabela 
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
                if (result == DialogResult.None)//limpo o retorno da mensagem
                {
                    if (index > -1)
                    {//verifico se o usuário está editando o registro e salvo os dados da última versão para verificar se houve alteração posterior.
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
                {//bloqueio os campos de atualização para habilitar somente dados da empresa
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
                        result = DialogResult.None;//limpo a variável de resultado do dialogo
                    }
                    if (mkCNPJ.Text != oCNPJ || txtNome.Text != oNome)
                    {
                        DialogResult res = DialogResult.None;
                        res = MessageBox.Show("Deseja salvar as alterações?\nTodos os registros desta empresa serão modificados.","Atenção", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.OK)
                        {//insiro o registro e desabilito os campos para edição novamente
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
