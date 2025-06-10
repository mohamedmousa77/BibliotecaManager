namespace BibliotecaManager.Forms
{
    partial class ModificaAutoreForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblCasaEditrice = new System.Windows.Forms.Label();
            this.lblGradimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtCasaEditrice = new System.Windows.Forms.TextBox();
            this.numGradimento = new System.Windows.Forms.NumericUpDown();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGradimento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(12, 45);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(55, 13);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(120, 42);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(200, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // lblCasaEditrice
            // 
            this.lblCasaEditrice.AutoSize = true;
            this.lblCasaEditrice.Location = new System.Drawing.Point(12, 75);
            this.lblCasaEditrice.Name = "lblCasaEditrice";
            this.lblCasaEditrice.Size = new System.Drawing.Size(73, 13);
            this.lblCasaEditrice.TabIndex = 4;
            this.lblCasaEditrice.Text = "Casa Editrice:";
            // 
            // txtCasaEditrice
            // 
            this.txtCasaEditrice.Location = new System.Drawing.Point(120, 72);
            this.txtCasaEditrice.Name = "txtCasaEditrice";
            this.txtCasaEditrice.Size = new System.Drawing.Size(200, 20);
            this.txtCasaEditrice.TabIndex = 2;
            // 
            // lblGradimento
            // 
            this.lblGradimento.AutoSize = true;
            this.lblGradimento.Location = new System.Drawing.Point(12, 105);
            this.lblGradimento.Name = "lblGradimento";
            this.lblGradimento.Size = new System.Drawing.Size(64, 13);
            this.lblGradimento.TabIndex = 6;
            this.lblGradimento.Text = "Gradimento:";
            // 
            // numGradimento
            // 
            this.numGradimento.Location = new System.Drawing.Point(120, 102);
            this.numGradimento.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numGradimento.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numGradimento.Name = "numGradimento";
            this.numGradimento.Size = new System.Drawing.Size(60, 20);
            this.numGradimento.TabIndex = 3;
            this.numGradimento.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnConferma
            // 
            this.btnConferma.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConferma.Location = new System.Drawing.Point(120, 140);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(90, 30);
            this.btnConferma.TabIndex = 4;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(230, 140);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(90, 30);
            this.btnAnnulla.TabIndex = 5;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // ModificaAutoreForm
            // 
            this.AcceptButton = this.btnConferma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnulla;
            this.ClientSize = new System.Drawing.Size(344, 190);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.numGradimento);
            this.Controls.Add(this.lblGradimento);
            this.Controls.Add(this.txtCasaEditrice);
            this.Controls.Add(this.lblCasaEditrice);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaAutoreForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifica Autore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificaAutoreForm_FormClosing);
            this.Load += new System.EventHandler(this.ModificaAutoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGradimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblCasaEditrice;
        private System.Windows.Forms.Label lblGradimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtCasaEditrice;
        private System.Windows.Forms.NumericUpDown numGradimento;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
    }
}