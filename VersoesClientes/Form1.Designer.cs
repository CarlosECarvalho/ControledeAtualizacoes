namespace VersoesClientes
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.mkCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
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
            this.txtNome.Size = new System.Drawing.Size(409, 20);
            this.txtNome.TabIndex = 5;
            // 
            // TxtExec
            // 
            this.TxtExec.Location = new System.Drawing.Point(214, 40);
            this.TxtExec.Name = "TxtExec";
            this.TxtExec.Size = new System.Drawing.Size(121, 20);
            this.TxtExec.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(341, 40);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(120, 20);
            this.txtHost.TabIndex = 2;
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(467, 40);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(120, 20);
            this.txtScript.TabIndex = 3;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(594, 40);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(127, 20);
            this.txtManager.TabIndex = 4;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(430, 76);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(59, 23);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(547, 76);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(59, 23);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(606, 76);
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
            this.dgClientes.TabIndex = 10;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // MenuGeral
            // 
            this.MenuGeral.Location = new System.Drawing.Point(0, 0);
            this.MenuGeral.Name = "MenuGeral";
            this.MenuGeral.Size = new System.Drawing.Size(732, 24);
            this.MenuGeral.TabIndex = 15;
            this.MenuGeral.Text = "menuStrip1";
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
            this.btConsultar.Location = new System.Drawing.Point(488, 76);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(59, 23);
            this.btConsultar.TabIndex = 7;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(665, 76);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(59, 23);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
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
            this.MainMenuStrip = this.MenuGeral;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versões em Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
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
    }
}

