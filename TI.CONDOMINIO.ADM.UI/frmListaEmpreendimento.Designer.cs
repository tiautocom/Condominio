namespace TI.CONDOMINIO.ADM.UI
{
    partial class frmListaEmpreendimento
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
            this.dgvEmpreendimento = new System.Windows.Forms.DataGridView();
            this.colEdite = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNomeRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCpfCnpj = new System.Windows.Forms.RadioButton();
            this.rbEmpreendimento = new System.Windows.Forms.RadioButton();
            this.rbFantasia = new System.Windows.Forms.RadioButton();
            this.rbRazao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpreendimento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpreendimento
            // 
            this.dgvEmpreendimento.AllowUserToAddRows = false;
            this.dgvEmpreendimento.AllowUserToDeleteRows = false;
            this.dgvEmpreendimento.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpreendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpreendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEdite,
            this.colDelete,
            this.colNomeRazao,
            this.colFantasia,
            this.colCnpj,
            this.colTelefone});
            this.dgvEmpreendimento.Location = new System.Drawing.Point(9, 104);
            this.dgvEmpreendimento.Name = "dgvEmpreendimento";
            this.dgvEmpreendimento.ReadOnly = true;
            this.dgvEmpreendimento.RowHeadersVisible = false;
            this.dgvEmpreendimento.Size = new System.Drawing.Size(879, 399);
            this.dgvEmpreendimento.TabIndex = 20;
            // 
            // colEdite
            // 
            this.colEdite.HeaderText = "";
            this.colEdite.Name = "colEdite";
            this.colEdite.ReadOnly = true;
            this.colEdite.Width = 40;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 40;
            // 
            // colNomeRazao
            // 
            this.colNomeRazao.HeaderText = "RAZÃO SOCIAL";
            this.colNomeRazao.Name = "colNomeRazao";
            this.colNomeRazao.ReadOnly = true;
            this.colNomeRazao.Width = 400;
            // 
            // colFantasia
            // 
            this.colFantasia.HeaderText = "FANTASIA";
            this.colFantasia.Name = "colFantasia";
            this.colFantasia.ReadOnly = true;
            // 
            // colCnpj
            // 
            this.colCnpj.HeaderText = "CNPJ";
            this.colCnpj.Name = "colCnpj";
            this.colCnpj.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "TELEFONE";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCpfCnpj);
            this.groupBox1.Controls.Add(this.rbEmpreendimento);
            this.groupBox1.Controls.Add(this.rbFantasia);
            this.groupBox1.Controls.Add(this.rbRazao);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 89);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisas";
            // 
            // rbCpfCnpj
            // 
            this.rbCpfCnpj.AutoSize = true;
            this.rbCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpfCnpj.Location = new System.Drawing.Point(180, 54);
            this.rbCpfCnpj.Name = "rbCpfCnpj";
            this.rbCpfCnpj.Size = new System.Drawing.Size(65, 20);
            this.rbCpfCnpj.TabIndex = 3;
            this.rbCpfCnpj.TabStop = true;
            this.rbCpfCnpj.Text = "CNPJ";
            this.rbCpfCnpj.UseVisualStyleBackColor = true;
            // 
            // rbEmpreendimento
            // 
            this.rbEmpreendimento.AutoSize = true;
            this.rbEmpreendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpreendimento.Location = new System.Drawing.Point(180, 24);
            this.rbEmpreendimento.Name = "rbEmpreendimento";
            this.rbEmpreendimento.Size = new System.Drawing.Size(143, 20);
            this.rbEmpreendimento.TabIndex = 2;
            this.rbEmpreendimento.TabStop = true;
            this.rbEmpreendimento.Text = "Empreendimento";
            this.rbEmpreendimento.UseVisualStyleBackColor = true;
            // 
            // rbFantasia
            // 
            this.rbFantasia.AutoSize = true;
            this.rbFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFantasia.Location = new System.Drawing.Point(11, 54);
            this.rbFantasia.Name = "rbFantasia";
            this.rbFantasia.Size = new System.Drawing.Size(131, 20);
            this.rbFantasia.TabIndex = 1;
            this.rbFantasia.TabStop = true;
            this.rbFantasia.Text = "Nome Fantasia";
            this.rbFantasia.UseVisualStyleBackColor = true;
            // 
            // rbRazao
            // 
            this.rbRazao.AutoSize = true;
            this.rbRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRazao.Location = new System.Drawing.Point(11, 24);
            this.rbRazao.Name = "rbRazao";
            this.rbRazao.Size = new System.Drawing.Size(119, 20);
            this.rbRazao.TabIndex = 0;
            this.rbRazao.TabStop = true;
            this.rbRazao.Text = "Razão Social";
            this.rbRazao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(370, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 89);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campo de Pesquisas";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(10, 38);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(497, 26);
            this.txtPesquisar.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(659, 509);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 31);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(775, 509);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 31);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // frmListaEmpreendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 548);
            this.Controls.Add(this.dgvEmpreendimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaEmpreendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empreendimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpreendimento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpreendimento;
        private System.Windows.Forms.DataGridViewImageColumn colEdite;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCpfCnpj;
        private System.Windows.Forms.RadioButton rbEmpreendimento;
        private System.Windows.Forms.RadioButton rbFantasia;
        private System.Windows.Forms.RadioButton rbRazao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
    }
}