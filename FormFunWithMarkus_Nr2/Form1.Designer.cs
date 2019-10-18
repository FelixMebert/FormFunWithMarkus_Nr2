namespace FormFunWithMarkus_Nr2
{
    partial class Form1
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
            this.cBGertränkeart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBSorte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSumme = new System.Windows.Forms.TextBox();
            this.cBAnzahl = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBGertränkeart
            // 
            this.cBGertränkeart.FormattingEnabled = true;
            this.cBGertränkeart.Items.AddRange(new object[] {
            "Softdrinks",
            "Fruchtsaft",
            "Wasser",
            "Bier",
            "Energie Drink"});
            this.cBGertränkeart.Location = new System.Drawing.Point(8, 64);
            this.cBGertränkeart.Name = "cBGertränkeart";
            this.cBGertränkeart.Size = new System.Drawing.Size(121, 24);
            this.cBGertränkeart.TabIndex = 0;
            this.cBGertränkeart.SelectedIndexChanged += new System.EventHandler(this.cBGertränkeart_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Getränkeart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorte";
            // 
            // cBSorte
            // 
            this.cBSorte.FormattingEnabled = true;
            this.cBSorte.Location = new System.Drawing.Point(8, 111);
            this.cBSorte.Name = "cBSorte";
            this.cBSorte.Size = new System.Drawing.Size(121, 24);
            this.cBSorte.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anzahl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Summe";
            // 
            // tbSumme
            // 
            this.tbSumme.AccessibleDescription = "";
            this.tbSumme.AccessibleName = "";
            this.tbSumme.Enabled = false;
            this.tbSumme.Location = new System.Drawing.Point(317, 112);
            this.tbSumme.Name = "tbSumme";
            this.tbSumme.Size = new System.Drawing.Size(100, 22);
            this.tbSumme.TabIndex = 9;
            // 
            // cBAnzahl
            // 
            this.cBAnzahl.FormattingEnabled = true;
            this.cBAnzahl.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBAnzahl.Location = new System.Drawing.Point(8, 158);
            this.cBAnzahl.Name = "cBAnzahl";
            this.cBAnzahl.Size = new System.Drawing.Size(121, 24);
            this.cBAnzahl.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.AccessibleName = "";
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(165, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(341, 390);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(85, 23);
            this.btnSchließen.TabIndex = 12;
            this.btnSchließen.Text = "schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cBAnzahl);
            this.Controls.Add(this.tbSumme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBSorte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBGertränkeart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBGertränkeart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBSorte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSumme;
        private System.Windows.Forms.ComboBox cBAnzahl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSchließen;
    }
}

