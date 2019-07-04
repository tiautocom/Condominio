namespace TI.CONDOMINIO.ADM.UI
{
    partial class frmListarApartamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomeTitular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvApartamento = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQtde = new System.Windows.Forms.ToolStripStatusLabel();
            this.colAlt = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumApto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumANDAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartamento)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeTitular
            // 
            this.txtNomeTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeTitular.Location = new System.Drawing.Point(104, 12);
            this.txtNomeTitular.Name = "txtNomeTitular";
            this.txtNomeTitular.ReadOnly = true;
            this.txtNomeTitular.Size = new System.Drawing.Size(497, 22);
            this.txtNomeTitular.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "*EMPRESA:";
            // 
            // dgvApartamento
            // 
            this.dgvApartamento.AllowUserToAddRows = false;
            this.dgvApartamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvApartamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApartamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvApartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlt,
            this.colDel,
            this.colId,
            this.colIdPessoa,
            this.colnumApto,
            this.colNumANDAR,
            this.colNumBloco,
            this.colAtivo});
            this.dgvApartamento.Location = new System.Drawing.Point(7, 40);
            this.dgvApartamento.Name = "dgvApartamento";
            this.dgvApartamento.ReadOnly = true;
            this.dgvApartamento.RowHeadersVisible = false;
            this.dgvApartamento.Size = new System.Drawing.Size(594, 339);
            this.dgvApartamento.TabIndex = 9;
            this.dgvApartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartamento_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblQtde});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Quantodade de Aptos:";
            // 
            // lblQtde
            // 
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(25, 17);
            this.lblQtde.Text = "000";
            // 
            // colAlt
            // 
            this.colAlt.HeaderText = "";
            this.colAlt.Image = global::TI.CONDOMINIO.ADM.UI.Properties.Resources.update;
            this.colAlt.Name = "colAlt";
            this.colAlt.ReadOnly = true;
            this.colAlt.Width = 50;
            // 
            // colDel
            // 
            this.colDel.HeaderText = "";
            this.colDel.Image = global::TI.CONDOMINIO.ADM.UI.Properties.Resources.close_icon;
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Width = 50;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colIdPessoa
            // 
            this.colIdPessoa.DataPropertyName = "IdPessoa";
            this.colIdPessoa.HeaderText = "IdPessoa";
            this.colIdPessoa.Name = "colIdPessoa";
            this.colIdPessoa.ReadOnly = true;
            this.colIdPessoa.Visible = false;
            // 
            // colnumApto
            // 
            this.colnumApto.DataPropertyName = "NumApto";
            this.colnumApto.HeaderText = "Nº APARTAMENTO";
            this.colnumApto.Name = "colnumApto";
            this.colnumApto.ReadOnly = true;
            this.colnumApto.Width = 190;
            // 
            // colNumANDAR
            // 
            this.colNumANDAR.DataPropertyName = "NumAndar";
            this.colNumANDAR.HeaderText = "Nº ANDAR";
            this.colNumANDAR.Name = "colNumANDAR";
            this.colNumANDAR.ReadOnly = true;
            // 
            // colNumBloco
            // 
            this.colNumBloco.DataPropertyName = "NumBloco";
            this.colNumBloco.HeaderText = "Nº BLOCO";
            this.colNumBloco.Name = "colNumBloco";
            this.colNumBloco.ReadOnly = true;
            this.colNumBloco.Width = 130;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "Ativo";
            this.colAtivo.HeaderText = "ATIVO";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 70;
            // 
            // frmListarApartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 404);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvApartamento);
            this.Controls.Add(this.txtNomeTitular);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarApartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Apartamentos";
            this.Load += new System.EventHandler(this.frmListarApartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartamento)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeTitular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvApartamento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblQtde;
        private System.Windows.Forms.DataGridViewImageColumn colAlt;
        private System.Windows.Forms.DataGridViewImageColumn colDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumApto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumANDAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumBloco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
    }
}