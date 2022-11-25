namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.USDTextBot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EURTextBot = new System.Windows.Forms.TextBox();
            this.CHFTextBot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ammountplntextbox = new System.Windows.Forms.TextBox();
            this.plntextbox = new System.Windows.Forms.Label();
            this.radioUSD = new System.Windows.Forms.RadioButton();
            this.radioEUR = new System.Windows.Forms.RadioButton();
            this.radioCHF = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USDTextBot
            // 
            this.USDTextBot.Location = new System.Drawing.Point(101, 4);
            this.USDTextBot.Name = "USDTextBot";
            this.USDTextBot.Size = new System.Drawing.Size(96, 23);
            this.USDTextBot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurs USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kurs EUR";
            // 
            // EURTextBot
            // 
            this.EURTextBot.Location = new System.Drawing.Point(101, 33);
            this.EURTextBot.Name = "EURTextBot";
            this.EURTextBot.Size = new System.Drawing.Size(96, 23);
            this.EURTextBot.TabIndex = 5;
            // 
            // CHFTextBot
            // 
            this.CHFTextBot.Location = new System.Drawing.Point(101, 62);
            this.CHFTextBot.Name = "CHFTextBot";
            this.CHFTextBot.Size = new System.Drawing.Size(96, 23);
            this.CHFTextBot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kurs CHF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalkulator walut";
            // 
            // ammountplntextbox
            // 
            this.ammountplntextbox.Location = new System.Drawing.Point(32, 156);
            this.ammountplntextbox.Name = "ammountplntextbox";
            this.ammountplntextbox.Size = new System.Drawing.Size(92, 23);
            this.ammountplntextbox.TabIndex = 9;
            // 
            // plntextbox
            // 
            this.plntextbox.AutoSize = true;
            this.plntextbox.Location = new System.Drawing.Point(32, 138);
            this.plntextbox.Name = "plntextbox";
            this.plntextbox.Size = new System.Drawing.Size(59, 15);
            this.plntextbox.TabIndex = 10;
            this.plntextbox.Text = "Kwota (zł)";
            // 
            // radioUSD
            // 
            this.radioUSD.AutoSize = true;
            this.radioUSD.Location = new System.Drawing.Point(141, 156);
            this.radioUSD.Name = "radioUSD";
            this.radioUSD.Size = new System.Drawing.Size(47, 19);
            this.radioUSD.TabIndex = 11;
            this.radioUSD.TabStop = true;
            this.radioUSD.Text = "USD";
            this.radioUSD.UseVisualStyleBackColor = true;
            this.radioUSD.CheckedChanged += new System.EventHandler(this.radioUSD_CheckedChanged);
            this.radioUSD.Click += new System.EventHandler(this.Exchange);
            // 
            // radioEUR
            // 
            this.radioEUR.AutoSize = true;
            this.radioEUR.Location = new System.Drawing.Point(141, 181);
            this.radioEUR.Name = "radioEUR";
            this.radioEUR.Size = new System.Drawing.Size(46, 19);
            this.radioEUR.TabIndex = 12;
            this.radioEUR.TabStop = true;
            this.radioEUR.Text = "EUR";
            this.radioEUR.UseVisualStyleBackColor = true;
            this.radioEUR.Click += new System.EventHandler(this.Exchange);
            // 
            // radioCHF
            // 
            this.radioCHF.AutoSize = true;
            this.radioCHF.Location = new System.Drawing.Point(141, 206);
            this.radioCHF.Name = "radioCHF";
            this.radioCHF.Size = new System.Drawing.Size(48, 19);
            this.radioCHF.TabIndex = 13;
            this.radioCHF.TabStop = true;
            this.radioCHF.Text = "CHF";
            this.radioCHF.UseVisualStyleBackColor = true;
            this.radioCHF.Click += new System.EventHandler(this.Exchange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kwota w walucie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 81);
            this.button1.TabIndex = 16;
            this.button1.Text = "pobierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioCHF);
            this.Controls.Add(this.radioEUR);
            this.Controls.Add(this.radioUSD);
            this.Controls.Add(this.plntextbox);
            this.Controls.Add(this.ammountplntextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CHFTextBot);
            this.Controls.Add(this.EURTextBot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USDTextBot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox USDTextBot;
        private Label label1;
        private Label label2;
        private TextBox EURTextBot;
        private TextBox CHFTextBot;
        private Label label3;
        private Label label4;
        private TextBox ammountplntextbox;
        private Label plntextbox;
        private RadioButton radioUSD;
        private RadioButton radioEUR;
        private RadioButton radioCHF;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
    }
}