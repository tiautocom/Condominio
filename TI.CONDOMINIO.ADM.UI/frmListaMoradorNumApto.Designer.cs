namespace TI.CONDOMINIO.ADM.UI
{
    partial class frmListaMoradorNumApto
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
            this.dgvMordor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMordor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMordor
            // 
            this.dgvMordor.AllowUserToAddRows = false;
            this.dgvMordor.AllowUserToDeleteRows = false;
            this.dgvMordor.BackgroundColor = System.Drawing.Color.White;
            this.dgvMordor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMordor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMordor.Location = new System.Drawing.Point(0, 0);
            this.dgvMordor.Name = "dgvMordor";
            this.dgvMordor.ReadOnly = true;
            this.dgvMordor.Size = new System.Drawing.Size(884, 480);
            this.dgvMordor.TabIndex = 0;
            // 
            // frmListaMoradorNumApto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 480);
            this.Controls.Add(this.dgvMordor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaMoradorNumApto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Morador";
            this.Load += new System.EventHandler(this.frmListaMoradorNumApto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMordor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMordor;
    }
}