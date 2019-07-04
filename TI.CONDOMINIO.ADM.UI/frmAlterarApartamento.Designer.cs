namespace TI.CONDOMINIO.ADM.UI
{
    partial class frmAlterarApartamento
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
            this.btnSelecionarAssinaturaDig = new System.Windows.Forms.Button();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionarAssinaturaDig
            // 
            this.btnSelecionarAssinaturaDig.BackColor = System.Drawing.Color.White;
            this.btnSelecionarAssinaturaDig.Location = new System.Drawing.Point(382, 118);
            this.btnSelecionarAssinaturaDig.Name = "btnSelecionarAssinaturaDig";
            this.btnSelecionarAssinaturaDig.Size = new System.Drawing.Size(89, 25);
            this.btnSelecionarAssinaturaDig.TabIndex = 21;
            this.btnSelecionarAssinaturaDig.Text = "Salvar";
            this.btnSelecionarAssinaturaDig.UseVisualStyleBackColor = false;
            this.btnSelecionarAssinaturaDig.Click += new System.EventHandler(this.btnSelecionarAssinaturaDig_Click);
            // 
            // txtAndar
            // 
            this.txtAndar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAndar.Location = new System.Drawing.Point(161, 90);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(310, 22);
            this.txtAndar.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "*Nº ANDAR:";
            // 
            // txtBloco
            // 
            this.txtBloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBloco.Location = new System.Drawing.Point(161, 62);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(310, 22);
            this.txtBloco.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "*Nº BLOCO:";
            // 
            // txtApartamento
            // 
            this.txtApartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApartamento.Location = new System.Drawing.Point(161, 34);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(310, 22);
            this.txtApartamento.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "*Nº APARTAMENTO:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.Location = new System.Drawing.Point(161, 6);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(310, 22);
            this.txtEmpresa.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "EMPRESA:";
            // 
            // frmAlterarApartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 147);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionarAssinaturaDig);
            this.Controls.Add(this.txtAndar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBloco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarApartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Dados Apartamento";
            this.Load += new System.EventHandler(this.frmAlterarApartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarAssinaturaDig;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label1;
    }
}