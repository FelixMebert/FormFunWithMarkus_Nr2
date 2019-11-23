namespace FormFunWithMarkus_Nr2
{
    partial class Form2
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
            this.cbFanta = new System.Windows.Forms.ComboBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.lbFanta = new System.Windows.Forms.Label();
            this.lbWeizen = new System.Windows.Forms.Label();
            this.cbWeizen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFanta
            // 
            this.cbFanta.FormattingEnabled = true;
            this.cbFanta.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbFanta.Location = new System.Drawing.Point(34, 33);
            this.cbFanta.Name = "cbFanta";
            this.cbFanta.Size = new System.Drawing.Size(46, 24);
            this.cbFanta.TabIndex = 0;
            this.cbFanta.SelectedIndexChanged += new System.EventHandler(this.cbFanta_SelectedIndexChanged);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(359, 397);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(80, 31);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // lbFanta
            // 
            this.lbFanta.AutoSize = true;
            this.lbFanta.Location = new System.Drawing.Point(86, 40);
            this.lbFanta.Name = "lbFanta";
            this.lbFanta.Size = new System.Drawing.Size(44, 17);
            this.lbFanta.TabIndex = 2;
            this.lbFanta.Text = "Fanta";
            // 
            // lbWeizen
            // 
            this.lbWeizen.AutoSize = true;
            this.lbWeizen.Location = new System.Drawing.Point(86, 70);
            this.lbWeizen.Name = "lbWeizen";
            this.lbWeizen.Size = new System.Drawing.Size(55, 17);
            this.lbWeizen.TabIndex = 4;
            this.lbWeizen.Text = "Weizen";
            // 
            // cbWeizen
            // 
            this.cbWeizen.FormattingEnabled = true;
            this.cbWeizen.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbWeizen.Location = new System.Drawing.Point(34, 63);
            this.cbWeizen.Name = "cbWeizen";
            this.cbWeizen.Size = new System.Drawing.Size(46, 24);
            this.cbWeizen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fanta";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(34, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(445, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 31);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbWeizen);
            this.Controls.Add(this.cbWeizen);
            this.Controls.Add(this.lbFanta);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.cbFanta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFanta;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label lbFanta;
        private System.Windows.Forms.Label lbWeizen;
        private System.Windows.Forms.ComboBox cbWeizen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnBack;
    }
}