namespace TI.CONDOMINIO.ADM.UI
{
    partial class frmTipoDocumentoPesquisa
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
            this.gbxTipoDocumento = new System.Windows.Forms.GroupBox();
            this.txtDocs = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbxTipoDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTipoDocumento
            // 
            this.gbxTipoDocumento.Controls.Add(this.btnSalvar);
            this.gbxTipoDocumento.Controls.Add(this.txtDocs);
            this.gbxTipoDocumento.Location = new System.Drawing.Point(6, 7);
            this.gbxTipoDocumento.Name = "gbxTipoDocumento";
            this.gbxTipoDocumento.Size = new System.Drawing.Size(182, 95);
            this.gbxTipoDocumento.TabIndex = 0;
            this.gbxTipoDocumento.TabStop = false;
            this.gbxTipoDocumento.Text = "Tipo de Pesquisa";
            // 
            // txtDocs
            // 
            this.txtDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocs.Location = new System.Drawing.Point(7, 36);
            this.txtDocs.Name = "txtDocs";
            this.txtDocs.Size = new System.Drawing.Size(165, 26);
            this.txtDocs.TabIndex = 0;
            this.txtDocs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocs_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(97, 66);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmTipoDocumentoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(192, 105);
            this.Controls.Add(this.gbxTipoDocumento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoDocumentoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Documento";
            this.Load += new System.EventHandler(this.frmTipoDocumentoPesquisa_Load);
            this.gbxTipoDocumento.ResumeLayout(false);
            this.gbxTipoDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTipoDocumento;
        private System.Windows.Forms.MaskedTextBox txtDocs;
        private System.Windows.Forms.Button btnSalvar;
    }
}