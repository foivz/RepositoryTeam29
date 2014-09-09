namespace VeterinarskaStanicaProjekt
{
    partial class FormaUrediUslugu
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
            this.buttonUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivUsluge = new System.Windows.Forms.TextBox();
            this.textBoxCijenaUsluge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelhelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUredi
            // 
            this.buttonUredi.Location = new System.Drawing.Point(214, 105);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(81, 29);
            this.buttonUredi.TabIndex = 0;
            this.buttonUredi.Text = "Uredi";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv usluge :";
            // 
            // textBoxNazivUsluge
            // 
            this.textBoxNazivUsluge.Location = new System.Drawing.Point(117, 33);
            this.textBoxNazivUsluge.Name = "textBoxNazivUsluge";
            this.textBoxNazivUsluge.Size = new System.Drawing.Size(178, 20);
            this.textBoxNazivUsluge.TabIndex = 2;
            // 
            // textBoxCijenaUsluge
            // 
            this.textBoxCijenaUsluge.Location = new System.Drawing.Point(117, 72);
            this.textBoxCijenaUsluge.Name = "textBoxCijenaUsluge";
            this.textBoxCijenaUsluge.Size = new System.Drawing.Size(178, 20);
            this.textBoxCijenaUsluge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena usluge :";
            // 
            // labelhelp
            // 
            this.labelhelp.AutoSize = true;
            this.labelhelp.Location = new System.Drawing.Point(13, 121);
            this.labelhelp.Name = "labelhelp";
            this.labelhelp.Size = new System.Drawing.Size(0, 13);
            this.labelhelp.TabIndex = 5;
            this.labelhelp.Visible = false;
            // 
            // FormaUrediUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 146);
            this.Controls.Add(this.labelhelp);
            this.Controls.Add(this.textBoxCijenaUsluge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivUsluge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUredi);
            this.Name = "FormaUrediUslugu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje usluge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivUsluge;
        private System.Windows.Forms.TextBox textBoxCijenaUsluge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelhelp;
    }
}