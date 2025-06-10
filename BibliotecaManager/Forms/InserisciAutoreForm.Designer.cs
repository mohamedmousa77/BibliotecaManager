namespace BibliotecaManager.Forms
{
    partial class InserisciAutoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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

            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 12);
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            // 
            // lblCognome
            // 
            this.lblCognome.Location = new System.Drawing.Point(12, 45);
            this.lblCognome.Size = new System.Drawing.Size(100, 23);
            this.lblCognome.Text = "Cognome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(120, 42);
            this.txtCognome.Size = new System.Drawing.Size(200, 23);
            // 
            // lblCasaEditrice
            // 
            this.lblCasaEditrice.Location = new System.Drawing.Point(12, 75);
            this.lblCasaEditrice.Size = new System.Drawing.Size(100, 23);
            this.lblCasaEditrice.Text = "Casa Editrice:";
            // 
            // txtCasaEditrice
            // 
            this.txtCasaEditrice.Location = new System.Drawing.Point(120, 72);
            this.txtCasaEditrice.Size = new System.Drawing.Size(200, 23);
            // 
            // lblGradimento
            // 
            this.lblGradimento.Location = new System.Drawing.Point(12, 105);
            this.lblGradimento.Size = new System.Drawing.Size(100, 23);
            this.lblGradimento.Text = "Gradimento:";
            // 
            // numGradimento
            // 
            this.numGradimento.Location = new System.Drawing.Point(120, 102);
            this.numGradimento.Size = new System.Drawing.Size(60, 23);
            this.numGradimento.Minimum = 1;
            this.numGradimento.Maximum = 5;
            this.numGradimento.Value = 3;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(120, 140);
            this.btnConferma.Size = new System.Drawing.Size(90, 30);
            this.btnConferma.Text = "Conferma";
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(230, 140);
            this.btnAnnulla.Size = new System.Drawing.Size(90, 30);
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // InserisciAutoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 190);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCasaEditrice);
            this.Controls.Add(this.txtCasaEditrice);
            this.Controls.Add(this.lblGradimento);
            this.Controls.Add(this.numGradimento);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnAnnulla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserisciAutoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserisci Autore";
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