namespace projAtendimento
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lbSenhas = new System.Windows.Forms.ListBox();
            this.btnListSenhas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdGuiches = new System.Windows.Forms.Label();
            this.btnAddGuiche = new System.Windows.Forms.Button();
            this.btnAtendimentos = new System.Windows.Forms.Button();
            this.lbAtendimentos = new System.Windows.Forms.ListBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(64, 33);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(84, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lbSenhas
            // 
            this.lbSenhas.FormattingEnabled = true;
            this.lbSenhas.Location = new System.Drawing.Point(12, 62);
            this.lbSenhas.Name = "lbSenhas";
            this.lbSenhas.Size = new System.Drawing.Size(199, 225);
            this.lbSenhas.TabIndex = 1;
            // 
            // btnListSenhas
            // 
            this.btnListSenhas.Location = new System.Drawing.Point(64, 293);
            this.btnListSenhas.Name = "btnListSenhas";
            this.btnListSenhas.Size = new System.Drawing.Size(97, 23);
            this.btnListSenhas.TabIndex = 2;
            this.btnListSenhas.Text = "Listar Senhas";
            this.btnListSenhas.UseVisualStyleBackColor = true;
            this.btnListSenhas.Click += new System.EventHandler(this.btnListSenhas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(238, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qtd Guichês";
            // 
            // lblQtdGuiches
            // 
            this.lblQtdGuiches.AutoSize = true;
            this.lblQtdGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblQtdGuiches.Location = new System.Drawing.Point(270, 150);
            this.lblQtdGuiches.Name = "lblQtdGuiches";
            this.lblQtdGuiches.Size = new System.Drawing.Size(32, 36);
            this.lblQtdGuiches.TabIndex = 4;
            this.lblQtdGuiches.Text = "0";
            // 
            // btnAddGuiche
            // 
            this.btnAddGuiche.Location = new System.Drawing.Point(242, 219);
            this.btnAddGuiche.Name = "btnAddGuiche";
            this.btnAddGuiche.Size = new System.Drawing.Size(84, 23);
            this.btnAddGuiche.TabIndex = 5;
            this.btnAddGuiche.Text = "Adicionar";
            this.btnAddGuiche.UseVisualStyleBackColor = true;
            this.btnAddGuiche.Click += new System.EventHandler(this.btnAddGuiche_Click);
            // 
            // btnAtendimentos
            // 
            this.btnAtendimentos.Location = new System.Drawing.Point(423, 293);
            this.btnAtendimentos.Name = "btnAtendimentos";
            this.btnAtendimentos.Size = new System.Drawing.Size(185, 23);
            this.btnAtendimentos.TabIndex = 8;
            this.btnAtendimentos.Text = "Listar Atendimentos";
            this.btnAtendimentos.UseVisualStyleBackColor = true;
            this.btnAtendimentos.Click += new System.EventHandler(this.btnAtendimentos_Click);
            // 
            // lbAtendimentos
            // 
            this.lbAtendimentos.FormattingEnabled = true;
            this.lbAtendimentos.Location = new System.Drawing.Point(371, 62);
            this.lbAtendimentos.Name = "lbAtendimentos";
            this.lbAtendimentos.Size = new System.Drawing.Size(310, 225);
            this.lbAtendimentos.TabIndex = 7;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(585, 33);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(84, 23);
            this.btnChamar.TabIndex = 6;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guiche:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(432, 33);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(137, 20);
            this.txtGuiche.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtendimentos);
            this.Controls.Add(this.lbAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnAddGuiche);
            this.Controls.Add(this.lblQtdGuiches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListSenhas);
            this.Controls.Add(this.lbSenhas);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox lbSenhas;
        private System.Windows.Forms.Button btnListSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdGuiches;
        private System.Windows.Forms.Button btnAddGuiche;
        private System.Windows.Forms.Button btnAtendimentos;
        private System.Windows.Forms.ListBox lbAtendimentos;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuiche;
    }
}

