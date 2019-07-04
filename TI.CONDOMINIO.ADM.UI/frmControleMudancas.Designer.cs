namespace TI.CONDOMINIO.ADM.UI
{
    partial class frmControleMudancas
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
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPesquisas = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colSel = new System.Windows.Forms.DataGridViewImageColumn();
            this.colIdMudanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumTorre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdTorre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicioMudanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFimMudanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSel,
            this.colIdMudanca,
            this.colData,
            this.colNumTorre,
            this.colBloco,
            this.colIdPeriodo,
            this.colIdTorre,
            this.colApto,
            this.colHoraInicio,
            this.colHoraFim,
            this.colLado,
            this.colPeriodo,
            this.colDesStatus,
            this.colInicioMudanca,
            this.colFimMudanca});
            this.dgvAgenda.GridColor = System.Drawing.Color.Bisque;
            this.dgvAgenda.Location = new System.Drawing.Point(2, 31);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.Size = new System.Drawing.Size(1130, 580);
            this.dgvAgenda.TabIndex = 0;
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisasToolStripMenuItem,
            this.txtPesquisas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisasToolStripMenuItem
            // 
            this.pesquisasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.apartamentosToolStripMenuItem,
            this.blocosToolStripMenuItem});
            this.pesquisasToolStripMenuItem.Name = "pesquisasToolStripMenuItem";
            this.pesquisasToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.pesquisasToolStripMenuItem.Text = "Pesquisas";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // apartamentosToolStripMenuItem
            // 
            this.apartamentosToolStripMenuItem.Name = "apartamentosToolStripMenuItem";
            this.apartamentosToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.apartamentosToolStripMenuItem.Text = "Apartamentos";
            // 
            // blocosToolStripMenuItem
            // 
            this.blocosToolStripMenuItem.Name = "blocosToolStripMenuItem";
            this.blocosToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.blocosToolStripMenuItem.Text = "Blocos";
            // 
            // txtPesquisas
            // 
            this.txtPesquisas.Name = "txtPesquisas";
            this.txtPesquisas.Size = new System.Drawing.Size(1000, 24);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // colSel
            // 
            this.colSel.HeaderText = "";
            this.colSel.Image = global::TI.CONDOMINIO.ADM.UI.Properties.Resources.check_icon;
            this.colSel.Name = "colSel";
            this.colSel.ReadOnly = true;
            this.colSel.Width = 40;
            // 
            // colIdMudanca
            // 
            this.colIdMudanca.DataPropertyName = "IdMudanca";
            this.colIdMudanca.HeaderText = "CÓDIGO";
            this.colIdMudanca.Name = "colIdMudanca";
            this.colIdMudanca.ReadOnly = true;
            this.colIdMudanca.Visible = false;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "Data";
            this.colData.HeaderText = "DATA";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colNumTorre
            // 
            this.colNumTorre.DataPropertyName = "NumTorre";
            this.colNumTorre.HeaderText = "Nº TORRE";
            this.colNumTorre.Name = "colNumTorre";
            this.colNumTorre.ReadOnly = true;
            // 
            // colBloco
            // 
            this.colBloco.DataPropertyName = "Bloco";
            this.colBloco.HeaderText = "BLOCO";
            this.colBloco.Name = "colBloco";
            this.colBloco.ReadOnly = true;
            // 
            // colIdPeriodo
            // 
            this.colIdPeriodo.DataPropertyName = "IdPeriodo";
            this.colIdPeriodo.HeaderText = "COD. PERIODO";
            this.colIdPeriodo.Name = "colIdPeriodo";
            this.colIdPeriodo.ReadOnly = true;
            this.colIdPeriodo.Visible = false;
            // 
            // colIdTorre
            // 
            this.colIdTorre.DataPropertyName = "IdTorre";
            this.colIdTorre.HeaderText = "COD.TORRE";
            this.colIdTorre.Name = "colIdTorre";
            this.colIdTorre.ReadOnly = true;
            this.colIdTorre.Visible = false;
            // 
            // colApto
            // 
            this.colApto.DataPropertyName = "Apto";
            this.colApto.HeaderText = "APTOº";
            this.colApto.Name = "colApto";
            this.colApto.ReadOnly = true;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.DataPropertyName = "HorarioInicio";
            this.colHoraInicio.HeaderText = "H. INICIO";
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            // 
            // colHoraFim
            // 
            this.colHoraFim.DataPropertyName = "HoraFim";
            this.colHoraFim.HeaderText = "H.FIM";
            this.colHoraFim.Name = "colHoraFim";
            this.colHoraFim.ReadOnly = true;
            // 
            // colLado
            // 
            this.colLado.DataPropertyName = "Lado";
            this.colLado.HeaderText = "LADO";
            this.colLado.Name = "colLado";
            this.colLado.ReadOnly = true;
            // 
            // colPeriodo
            // 
            this.colPeriodo.DataPropertyName = "Periodo";
            this.colPeriodo.HeaderText = "PERIODO";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.ReadOnly = true;
            this.colPeriodo.Width = 130;
            // 
            // colDesStatus
            // 
            this.colDesStatus.DataPropertyName = "DescStatus";
            this.colDesStatus.HeaderText = "STATUS";
            this.colDesStatus.Name = "colDesStatus";
            this.colDesStatus.ReadOnly = true;
            this.colDesStatus.Width = 250;
            // 
            // colInicioMudanca
            // 
            this.colInicioMudanca.DataPropertyName = "Inicio";
            this.colInicioMudanca.HeaderText = "H.INICIO MUDANÇA";
            this.colInicioMudanca.Name = "colInicioMudanca";
            this.colInicioMudanca.ReadOnly = true;
            this.colInicioMudanca.Visible = false;
            // 
            // colFimMudanca
            // 
            this.colFimMudanca.DataPropertyName = "Final";
            this.colFimMudanca.HeaderText = "H.FIM MUDANÇA";
            this.colFimMudanca.Name = "colFimMudanca";
            this.colFimMudanca.ReadOnly = true;
            this.colFimMudanca.Visible = false;
            // 
            // frmControleMudancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 636);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmControleMudancas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Mudanças - Portaria";
            this.Load += new System.EventHandler(this.frmControleMudancas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisas;
        private System.Windows.Forms.DataGridViewImageColumn colSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMudanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumTorre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTorre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicioMudanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFimMudanca;
    }
}