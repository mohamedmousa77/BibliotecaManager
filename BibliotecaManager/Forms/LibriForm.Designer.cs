namespace BibliotecaManager.Forms
{
    partial class LibriForm
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(21, 228);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(159, 58);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(304, 228);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(166, 58);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(621, 228);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(167, 58);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 210);
            this.dataGridView1.TabIndex = 3;
            // 
            // LibriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAggiungi);
            this.Name = "LibriForm";
            this.Text = "LibriForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}