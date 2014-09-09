namespace VeterinarskaStanicaProjekt
{
    partial class FormaUnosPregleda
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
            this.buttonUnos = new System.Windows.Forms.Button();
            this.label_vrijeme = new System.Windows.Forms.Label();
            this.textBox_vrijeme = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox_ljubimac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_napomena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVlasnik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(390, 165);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(84, 30);
            this.buttonUnos.TabIndex = 0;
            this.buttonUnos.Text = "Unesi";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // label_vrijeme
            // 
            this.label_vrijeme.AutoSize = true;
            this.label_vrijeme.Location = new System.Drawing.Point(218, 21);
            this.label_vrijeme.Name = "label_vrijeme";
            this.label_vrijeme.Size = new System.Drawing.Size(47, 13);
            this.label_vrijeme.TabIndex = 1;
            this.label_vrijeme.Text = "Vrijeme :";
            // 
            // textBox_vrijeme
            // 
            this.textBox_vrijeme.Location = new System.Drawing.Point(279, 18);
            this.textBox_vrijeme.Name = "textBox_vrijeme";
            this.textBox_vrijeme.Size = new System.Drawing.Size(81, 20);
            this.textBox_vrijeme.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // textBox_ljubimac
            // 
            this.textBox_ljubimac.Location = new System.Drawing.Point(279, 85);
            this.textBox_ljubimac.Name = "textBox_ljubimac";
            this.textBox_ljubimac.Size = new System.Drawing.Size(81, 20);
            this.textBox_ljubimac.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ljubimac :";
            // 
            // textBox_napomena
            // 
            this.textBox_napomena.Location = new System.Drawing.Point(279, 128);
            this.textBox_napomena.Name = "textBox_napomena";
            this.textBox_napomena.Size = new System.Drawing.Size(166, 20);
            this.textBox_napomena.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Napomena :";
            // 
            // textBoxVlasnik
            // 
            this.textBoxVlasnik.Location = new System.Drawing.Point(279, 49);
            this.textBoxVlasnik.Name = "textBoxVlasnik";
            this.textBoxVlasnik.Size = new System.Drawing.Size(81, 20);
            this.textBoxVlasnik.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vlasnik  :";
            // 
            // FormaUnosPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 207);
            this.Controls.Add(this.textBoxVlasnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_napomena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ljubimac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_vrijeme);
            this.Controls.Add(this.label_vrijeme);
            this.Controls.Add(this.buttonUnos);
            this.Name = "FormaUnosPregleda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos pregleda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Label label_vrijeme;
        private System.Windows.Forms.TextBox textBox_vrijeme;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox_ljubimac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_napomena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVlasnik;
        private System.Windows.Forms.Label label3;
    }
}