namespace BibliotecaManager.Forms
{
    partial class ClientiForm
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
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(627, 237);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(143, 45);
            this.btnElimina.TabIndex = 0;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(332, 237);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(150, 45);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(23, 237);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(157, 45);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 219);
            this.dataGridView1.TabIndex = 3;
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnElimina);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}