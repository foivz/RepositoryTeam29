namespace VeterinarskaStanicaProjekt
{
    partial class FormaUnosUsluge
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivUsluge = new System.Windows.Forms.TextBox();
            this.textBoxCijenaUsluge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv usluge :";
            // 
            // textBoxNazivUsluge
            // 
            this.textBoxNazivUsluge.Location = new System.Drawing.Point(105, 24);
            this.textBoxNazivUsluge.Name = "textBoxNazivUsluge";
            this.textBoxNazivUsluge.Size = new System.Drawing.Size(192, 20);
            this.textBoxNazivUsluge.TabIndex = 1;
            // 
            // textBoxCijenaUsluge
            // 
            this.textBoxCijenaUsluge.Location = new System.Drawing.Point(105, 63);
            this.textBoxCijenaUsluge.Name = "textBoxCijenaUsluge";
            this.textBoxCijenaUsluge.Size = new System.Drawing.Size(192, 20);
            this.textBoxCijenaUsluge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena usluge :";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(214, 104);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(83, 29);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseCompatibleTextRendering = true;
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // FormaUnosUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 145);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxCijenaUsluge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivUsluge);
            this.Controls.Add(this.label1);
            this.Name = "FormaUnosUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos usluge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivUsluge;
        private System.Windows.Forms.TextBox textBoxCijenaUsluge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodaj;
    }
}