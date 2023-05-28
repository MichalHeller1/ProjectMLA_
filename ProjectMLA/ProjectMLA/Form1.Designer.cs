namespace ProjectMLA
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
            BeasleyChe = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            TextPay = new Label();
            gift = new Button();
            Bag = new Button();
            DoritosChe = new CheckBox();
            M = new Label();
            LIsMakeing = new Label();
            BDoch = new Button();
            SuspendLayout();
            // 
            // BeasleyChe
            // 
            BeasleyChe.AutoSize = true;
            BeasleyChe.ForeColor = Color.Coral;
            BeasleyChe.Location = new Point(204, 100);
            BeasleyChe.Margin = new Padding(4, 5, 4, 5);
            BeasleyChe.Name = "BeasleyChe";
            BeasleyChe.Size = new Size(80, 29);
            BeasleyChe.TabIndex = 1;
            BeasleyChe.Text = "ביסלי";
            BeasleyChe.UseVisualStyleBackColor = true;
            BeasleyChe.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.Coral;
            checkBox3.Location = new Point(204, 142);
            checkBox3.Margin = new Padding(4, 5, 4, 5);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "במבה";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.Coral;
            checkBox4.Location = new Point(204, 183);
            checkBox4.Margin = new Padding(4, 5, 4, 5);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(81, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "צ'יפס";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(907, 598);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 4;
            button1.Text = "לתשלום";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = Color.Coral;
            checkBox5.Location = new Point(204, 227);
            checkBox5.Margin = new Padding(4, 5, 4, 5);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(145, 29);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "שוקולד אגוזים";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = Color.DarkCyan;
            checkBox6.Location = new Point(204, 382);
            checkBox6.Margin = new Padding(4, 5, 4, 5);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(77, 29);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "קולה";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = Color.DarkCyan;
            checkBox7.Location = new Point(204, 423);
            checkBox7.Margin = new Padding(4, 5, 4, 5);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(83, 29);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "אקסל";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = Color.DarkCyan;
            checkBox8.Location = new Point(204, 465);
            checkBox8.Margin = new Padding(4, 5, 4, 5);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(127, 29);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "מיץ תפוזים ";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // TextPay
            // 
            TextPay.AutoSize = true;
            TextPay.Location = new Point(617, 440);
            TextPay.Name = "TextPay";
            TextPay.Size = new Size(22, 25);
            TextPay.TabIndex = 9;
            TextPay.Text = "0";
            // 
            // gift
            // 
            gift.Location = new Point(777, 59);
            gift.Name = "gift";
            gift.Size = new Size(205, 34);
            gift.TabIndex = 10;
            gift.Text = "אריזת מתנה";
            gift.UseVisualStyleBackColor = true;
            gift.Click += gift_Click;
            // 
            // Bag
            // 
            Bag.Location = new Point(777, 124);
            Bag.Name = "Bag";
            Bag.Size = new Size(205, 34);
            Bag.TabIndex = 11;
            Bag.Text = "שקית";
            Bag.UseVisualStyleBackColor = true;
            Bag.Click += Bag_Click;
            // 
            // DoritosChe
            // 
            DoritosChe.AutoSize = true;
            DoritosChe.Location = new Point(204, 59);
            DoritosChe.Name = "DoritosChe";
            DoritosChe.Size = new Size(97, 29);
            DoritosChe.TabIndex = 12;
            DoritosChe.Text = "Doritos";
            DoritosChe.UseVisualStyleBackColor = true;
            DoritosChe.CheckedChanged += DoritosChe_CheckedChanged;
            // 
            // M
            // 
            M.AutoSize = true;
            M.Location = new Point(523, 598);
            M.Name = "M";
            M.Size = new Size(17, 25);
            M.TabIndex = 13;
            M.Text = " ";
            // 
            // LIsMakeing
            // 
            LIsMakeing.AutoSize = true;
            LIsMakeing.Location = new Point(943, 523);
            LIsMakeing.Name = "LIsMakeing";
            LIsMakeing.Size = new Size(17, 25);
            LIsMakeing.TabIndex = 14;
            LIsMakeing.Text = " ";
            LIsMakeing.Click += LIsMakeing_Click;
            // 
            // BDoch
            // 
            BDoch.Location = new Point(30, 594);
            BDoch.Name = "BDoch";
            BDoch.Size = new Size(112, 34);
            BDoch.TabIndex = 15;
            BDoch.Text = "print doch to file";
            BDoch.UseVisualStyleBackColor = true;
            BDoch.Click += BDoch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(BDoch);
            Controls.Add(LIsMakeing);
            Controls.Add(M);
            Controls.Add(DoritosChe);
            Controls.Add(Bag);
            Controls.Add(gift);
            Controls.Add(TextPay);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(BeasleyChe);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Doritos;
        private CheckBox BeasleyChe;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Label TextPay;
        private Button gift;
        private Button Bag;
        private CheckBox DoritosChe;
        private Label M;
        private Label LIsMakeing;
        private Button BDoch;
    }
}