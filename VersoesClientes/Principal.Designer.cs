namespace VersoesClientes
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.TxtExec = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.MenuGeral = new System.Windows.Forms.MenuStrip();
            this.MenuParam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.mkCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lblUsu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.MenuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Executavel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Script";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manager";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(705, 20);
            this.txtNome.TabIndex = 1;
            // 
            // TxtExec
            // 
            this.TxtExec.Location = new System.Drawing.Point(214, 40);
            this.TxtExec.Name = "TxtExec";
            this.TxtExec.Size = new System.Drawing.Size(121, 20);
            this.TxtExec.TabIndex = 2;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(341, 40);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(120, 20);
            this.txtHost.TabIndex = 3;
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(467, 40);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(120, 20);
            this.txtScript.TabIndex = 4;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(594, 40);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(127, 20);
            this.txtManager.TabIndex = 5;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(402, 444);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(59, 23);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(532, 444);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(59, 23);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(597, 444);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(59, 23);
            this.btExibir.TabIndex = 9;
            this.btExibir.Text = "Exibir";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AllowUserToResizeRows = false;
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(12, 105);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(708, 333);
            this.dgClientes.TabIndex = 11;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // MenuGeral
            // 
            this.MenuGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuParam,
            this.loginToolStripMenuItem});
            this.MenuGeral.Location = new System.Drawing.Point(0, 0);
            this.MenuGeral.Name = "MenuGeral";
            this.MenuGeral.Size = new System.Drawing.Size(729, 24);
            this.MenuGeral.TabIndex = 15;
            this.MenuGeral.Text = "menuStrip1";
            // 
            // MenuParam
            // 
            this.MenuParam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivos,
            this.MenuUsuarios});
            this.MenuParam.Name = "MenuParam";
            this.MenuParam.Size = new System.Drawing.Size(105, 20);
            this.MenuParam.Text = "Parametrizações";
            // 
            // MenuArquivos
            // 
            this.MenuArquivos.Name = "MenuArquivos";
            this.MenuArquivos.Size = new System.Drawing.Size(146, 22);
            this.MenuArquivos.Text = "Arquivos";
            this.MenuArquivos.Click += new System.EventHandler(this.MenuArquivos_Click);
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(146, 22);
            this.MenuUsuarios.Text = "Editar usuário";
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.loginToolStripMenuItem.Text = "Trocar de Login";
            this.loginToolStripMenuItem.ToolTipText = "Trocar de usuário";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CNPJ";
            // 
            // mkCNPJ
            // 
            this.mkCNPJ.BackColor = System.Drawing.Color.White;
            this.mkCNPJ.Location = new System.Drawing.Point(15, 40);
            this.mkCNPJ.Mask = "00.000.000/0000-00";
            this.mkCNPJ.Name = "mkCNPJ";
            this.mkCNPJ.Size = new System.Drawing.Size(196, 20);
            this.mkCNPJ.TabIndex = 0;
            this.mkCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(467, 444);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(59, 23);
            this.btConsultar.TabIndex = 7;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(662, 444);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(59, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(14, 449);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(0, 13);
            this.lblUsu.TabIndex = 17;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 476);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.mkCNPJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.TxtExec);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuGeral);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.MenuGeral;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versões em Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.MenuGeral.ResumeLayout(false);
            this.MenuGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox TxtExec;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.MenuStrip MenuGeral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mkCNPJ;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ToolStripMenuItem MenuParam;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivos;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label lblUsu;
    }
}

