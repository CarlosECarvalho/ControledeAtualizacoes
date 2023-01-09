namespace VersoesClientes
{
    partial class Arquivos
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
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblScript = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblInforme = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtCamExec = new System.Windows.Forms.TextBox();
            this.CamExec = new System.Windows.Forms.Button();
            this.CamHost = new System.Windows.Forms.Button();
            this.txtCamHost = new System.Windows.Forms.TextBox();
            this.txtCamScr = new System.Windows.Forms.TextBox();
            this.CamScr = new System.Windows.Forms.Button();
            this.txtCamMan = new System.Windows.Forms.TextBox();
            this.CamEdoc = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(13, 40);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(142, 16);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão do Executável:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(13, 66);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(104, 16);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Versão do Host:";
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScript.Location = new System.Drawing.Point(13, 92);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(110, 16);
            this.lblScript.TabIndex = 2;
            this.lblScript.Text = "Versão do Script:";
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan.Location = new System.Drawing.Point(13, 118);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(165, 16);
            this.lblMan.TabIndex = 3;
            this.lblMan.Text = "Versão do Manager Edoc:";
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(12, 9);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(254, 20);
            this.lblInforme.TabIndex = 4;
            this.lblInforme.Text = "Informe os caminhos dos arquivos:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtCamExec
            // 
            this.txtCamExec.Location = new System.Drawing.Point(162, 36);
            this.txtCamExec.Name = "txtCamExec";
            this.txtCamExec.Size = new System.Drawing.Size(306, 20);
            this.txtCamExec.TabIndex = 5;
            // 
            // CamExec
            // 
            this.CamExec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CamExec.Location = new System.Drawing.Point(474, 36);
            this.CamExec.Name = "CamExec";
            this.CamExec.Size = new System.Drawing.Size(44, 23);
            this.CamExec.TabIndex = 6;
            this.CamExec.Text = ".\\..\\.";
            this.CamExec.UseVisualStyleBackColor = true;
            this.CamExec.Click += new System.EventHandler(this.CamExec_Click);
            // 
            // CamHost
            // 
            this.CamHost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CamHost.Location = new System.Drawing.Point(474, 62);
            this.CamHost.Name = "CamHost";
            this.CamHost.Size = new System.Drawing.Size(44, 20);
            this.CamHost.TabIndex = 7;
            this.CamHost.Text = ".\\..\\.";
            this.CamHost.UseVisualStyleBackColor = true;
            this.CamHost.Click += new System.EventHandler(this.CamHost_Click);
            // 
            // txtCamHost
            // 
            this.txtCamHost.Location = new System.Drawing.Point(162, 62);
            this.txtCamHost.Name = "txtCamHost";
            this.txtCamHost.Size = new System.Drawing.Size(306, 20);
            this.txtCamHost.TabIndex = 8;
            // 
            // txtCamScr
            // 
            this.txtCamScr.Location = new System.Drawing.Point(162, 88);
            this.txtCamScr.Name = "txtCamScr";
            this.txtCamScr.Size = new System.Drawing.Size(306, 20);
            this.txtCamScr.TabIndex = 10;
            // 
            // CamScr
            // 
            this.CamScr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CamScr.Location = new System.Drawing.Point(474, 88);
            this.CamScr.Name = "CamScr";
            this.CamScr.Size = new System.Drawing.Size(44, 20);
            this.CamScr.TabIndex = 9;
            this.CamScr.Text = ".\\..\\.";
            this.CamScr.UseVisualStyleBackColor = true;
            this.CamScr.Click += new System.EventHandler(this.CamScr_Click);
            // 
            // txtCamMan
            // 
            this.txtCamMan.Location = new System.Drawing.Point(184, 114);
            this.txtCamMan.Name = "txtCamMan";
            this.txtCamMan.Size = new System.Drawing.Size(284, 20);
            this.txtCamMan.TabIndex = 12;
            // 
            // CamEdoc
            // 
            this.CamEdoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CamEdoc.Location = new System.Drawing.Point(474, 114);
            this.CamEdoc.Name = "CamEdoc";
            this.CamEdoc.Size = new System.Drawing.Size(44, 20);
            this.CamEdoc.TabIndex = 11;
            this.CamEdoc.Text = ".\\..\\.";
            this.CamEdoc.UseVisualStyleBackColor = true;
            this.CamEdoc.Click += new System.EventHandler(this.CamEdoc_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(474, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(44, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Arquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 146);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCamMan);
            this.Controls.Add(this.CamEdoc);
            this.Controls.Add(this.txtCamScr);
            this.Controls.Add(this.CamScr);
            this.Controls.Add(this.txtCamHost);
            this.Controls.Add(this.CamHost);
            this.Controls.Add(this.CamExec);
            this.Controls.Add(this.txtCamExec);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblMan);
            this.Controls.Add(this.lblScript);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblVersao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Arquivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblScript;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtCamExec;
        private System.Windows.Forms.Button CamExec;
        private System.Windows.Forms.Button CamHost;
        private System.Windows.Forms.TextBox txtCamHost;
        private System.Windows.Forms.TextBox txtCamScr;
        private System.Windows.Forms.Button CamScr;
        private System.Windows.Forms.TextBox txtCamMan;
        private System.Windows.Forms.Button CamEdoc;
        private System.Windows.Forms.Button btnSalvar;
    }
}