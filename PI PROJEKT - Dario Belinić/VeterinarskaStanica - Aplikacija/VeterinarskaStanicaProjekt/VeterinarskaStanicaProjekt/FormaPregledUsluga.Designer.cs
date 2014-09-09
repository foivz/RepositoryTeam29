namespace VeterinarskaStanicaProjekt
{
    partial class FormaPregledUsluga
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
            this.dataGridViewUsluge = new System.Windows.Forms.DataGridView();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsluge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsluge
            // 
            this.dataGridViewUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsluge.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsluge.Name = "dataGridViewUsluge";
            this.dataGridViewUsluge.Size = new System.Drawing.Size(431, 357);
            this.dataGridViewUsluge.TabIndex = 0;
            // 
            // buttonUredi
            // 
            this.buttonUredi.Location = new System.Drawing.Point(12, 385);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(94, 35);
            this.buttonUredi.TabIndex = 1;
            this.buttonUredi.Text = "Uredi";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(126, 385);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(94, 35);
            this.buttonObrisi.TabIndex = 2;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // FormaPregledUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 437);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.dataGridViewUsluge);
            this.Name = "FormaPregledUsluga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled usluga";
            this.Load += new System.EventHandler(this.FormaPregledUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsluge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsluge;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Button buttonObrisi;
    }
}