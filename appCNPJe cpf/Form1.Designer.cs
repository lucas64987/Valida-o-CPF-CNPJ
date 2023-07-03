namespace appCNPJe_cpf
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rbtncpf = new System.Windows.Forms.RadioButton();
            this.Rbtncnpj = new System.Windows.Forms.RadioButton();
            this.Lblentrada = new System.Windows.Forms.Label();
            this.TxtCampoEntrada = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCANCELAR = new System.Windows.Forms.Button();
            this.Lblgerador = new System.Windows.Forms.Label();
            this.Btncpf = new System.Windows.Forms.Button();
            this.Btncnpj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rbtncpf
            // 
            this.Rbtncpf.AutoSize = true;
            this.Rbtncpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtncpf.Location = new System.Drawing.Point(54, 32);
            this.Rbtncpf.Name = "Rbtncpf";
            this.Rbtncpf.Size = new System.Drawing.Size(75, 29);
            this.Rbtncpf.TabIndex = 0;
            this.Rbtncpf.TabStop = true;
            this.Rbtncpf.Text = "CPF";
            this.Rbtncpf.UseVisualStyleBackColor = true;
            // 
            // Rbtncnpj
            // 
            this.Rbtncnpj.AutoSize = true;
            this.Rbtncnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtncnpj.Location = new System.Drawing.Point(188, 32);
            this.Rbtncnpj.Name = "Rbtncnpj";
            this.Rbtncnpj.Size = new System.Drawing.Size(89, 29);
            this.Rbtncnpj.TabIndex = 1;
            this.Rbtncnpj.TabStop = true;
            this.Rbtncnpj.Text = "CNPJ";
            this.Rbtncnpj.UseVisualStyleBackColor = true;
            // 
            // Lblentrada
            // 
            this.Lblentrada.AutoSize = true;
            this.Lblentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblentrada.Location = new System.Drawing.Point(12, 113);
            this.Lblentrada.Name = "Lblentrada";
            this.Lblentrada.Size = new System.Drawing.Size(106, 25);
            this.Lblentrada.TabIndex = 2;
            this.Lblentrada.Text = "entrada :";
            // 
            // TxtCampoEntrada
            // 
            this.TxtCampoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCampoEntrada.Location = new System.Drawing.Point(119, 113);
            this.TxtCampoEntrada.Name = "TxtCampoEntrada";
            this.TxtCampoEntrada.Size = new System.Drawing.Size(311, 29);
            this.TxtCampoEntrada.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Location = new System.Drawing.Point(146, 161);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(90, 32);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCANCELAR
            // 
            this.BtnCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCANCELAR.Location = new System.Drawing.Point(242, 161);
            this.BtnCANCELAR.Name = "BtnCANCELAR";
            this.BtnCANCELAR.Size = new System.Drawing.Size(112, 32);
            this.BtnCANCELAR.TabIndex = 5;
            this.BtnCANCELAR.Text = "cancelar";
            this.BtnCANCELAR.UseVisualStyleBackColor = true;
            this.BtnCANCELAR.Click += new System.EventHandler(this.BtnCANCELAR_Click);
            // 
            // Lblgerador
            // 
            this.Lblgerador.AutoSize = true;
            this.Lblgerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblgerador.Location = new System.Drawing.Point(114, 238);
            this.Lblgerador.Name = "Lblgerador";
            this.Lblgerador.Size = new System.Drawing.Size(271, 25);
            this.Lblgerador.TabIndex = 7;
            this.Lblgerador.Text = "gerador de CPF e CNPJ:";
            // 
            // Btncpf
            // 
            this.Btncpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncpf.Location = new System.Drawing.Point(119, 288);
            this.Btncpf.Name = "Btncpf";
            this.Btncpf.Size = new System.Drawing.Size(120, 34);
            this.Btncpf.TabIndex = 8;
            this.Btncpf.Text = "gerar cpf";
            this.Btncpf.UseVisualStyleBackColor = true;
            this.Btncpf.Click += new System.EventHandler(this.Btncpf_Click);
            // 
            // Btncnpj
            // 
            this.Btncnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncnpj.Location = new System.Drawing.Point(274, 288);
            this.Btncnpj.Name = "Btncnpj";
            this.Btncnpj.Size = new System.Drawing.Size(120, 34);
            this.Btncnpj.TabIndex = 9;
            this.Btncnpj.Text = "gerar cnpj";
            this.Btncnpj.UseVisualStyleBackColor = true;
            this.Btncnpj.Click += new System.EventHandler(this.Btncnpj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(495, 334);
            this.Controls.Add(this.Btncnpj);
            this.Controls.Add(this.Btncpf);
            this.Controls.Add(this.Lblgerador);
            this.Controls.Add(this.BtnCANCELAR);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtCampoEntrada);
            this.Controls.Add(this.Lblentrada);
            this.Controls.Add(this.Rbtncnpj);
            this.Controls.Add(this.Rbtncpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "validação de CPF e CNPJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rbtncpf;
        private System.Windows.Forms.RadioButton Rbtncnpj;
        private System.Windows.Forms.Label Lblentrada;
        private System.Windows.Forms.TextBox TxtCampoEntrada;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCANCELAR;
        private System.Windows.Forms.Label Lblgerador;
        private System.Windows.Forms.Button Btncpf;
        private System.Windows.Forms.Button Btncnpj;
    }
}

