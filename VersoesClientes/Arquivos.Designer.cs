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
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(12, 58);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(143, 16);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão do Executável:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(12, 102);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(105, 16);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Versão do Host:";
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScript.Location = new System.Drawing.Point(12, 154);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(111, 16);
            this.lblScript.TabIndex = 2;
            this.lblScript.Text = "Versão do Script:";
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan.Location = new System.Drawing.Point(12, 202);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(166, 16);
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
            this.txtCamExec.Location = new System.Drawing.Point(162, 58);
            this.txtCamExec.Name = "txtCamExec";
            this.txtCamExec.Size = new System.Drawing.Size(282, 20);
            this.txtCamExec.TabIndex = 5;
            // 
            // Arquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 260);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
    }
}