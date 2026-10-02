namespace firstassign
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
            lblFood1 = new Label();
            txtfood1 = new TextBox();
            txtfood2 = new TextBox();
            lblFood2 = new Label();
            txtpricefood1 = new TextBox();
            lblPrice1 = new Label();
            txtpricefood2 = new TextBox();
            lblPrice2 = new Label();
            txtamounttips = new TextBox();
            lblAmountTips = new Label();
            calculate = new Button();
            clearbtn = new Button();
            closebtn = new Button();
            lblsales = new Label();
            lblsalestext = new Label();
            lbltips = new Label();
            lbltipsamount = new Label();
            lbltotal = new Label();
            lbltotalamount = new Label();
            lblnet = new Label();
            lblnetamount = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // lblFood1
            // 
            lblFood1.AutoSize = true;
            lblFood1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFood1.Location = new Point(69, 21);
            lblFood1.Name = "lblFood1";
            lblFood1.Size = new Size(171, 28);
            lblFood1.TabIndex = 0;
            lblFood1.Text = "ENTER FOOD 1 : ";
            // 
            // txtfood1
            // 
            txtfood1.Location = new Point(247, 25);
            txtfood1.Name = "txtfood1";
            txtfood1.Size = new Size(312, 27);
            txtfood1.TabIndex = 1;
            // 
            // txtfood2
            // 
            txtfood2.Location = new Point(246, 91);
            txtfood2.Name = "txtfood2";
            txtfood2.Size = new Size(312, 27);
            txtfood2.TabIndex = 5;
            // 
            // lblFood2
            // 
            lblFood2.AutoSize = true;
            lblFood2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFood2.Location = new Point(70, 82);
            lblFood2.Name = "lblFood2";
            lblFood2.Size = new Size(171, 28);
            lblFood2.TabIndex = 4;
            lblFood2.Text = "ENTER FOOD 2 : ";
            // 
            // txtpricefood1
            // 
            txtpricefood1.Location = new Point(247, 58);
            txtpricefood1.Name = "txtpricefood1";
            txtpricefood1.Size = new Size(312, 27);
            txtpricefood1.TabIndex = 3;
            // 
            // lblPrice1
            // 
            lblPrice1.AutoSize = true;
            lblPrice1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice1.Location = new Point(69, 54);
            lblPrice1.Name = "lblPrice1";
            lblPrice1.Size = new Size(163, 28);
            lblPrice1.TabIndex = 2;
            lblPrice1.Text = "ENTER price 1 : ";
            // 
            // txtpricefood2
            // 
            txtpricefood2.Location = new Point(246, 135);
            txtpricefood2.Name = "txtpricefood2";
            txtpricefood2.Size = new Size(312, 27);
            txtpricefood2.TabIndex = 7;
            // 
            // lblPrice2
            // 
            lblPrice2.AutoSize = true;
            lblPrice2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice2.Location = new Point(69, 135);
            lblPrice2.Name = "lblPrice2";
            lblPrice2.Size = new Size(163, 28);
            lblPrice2.TabIndex = 6;
            lblPrice2.Text = "ENTER price 2 : ";
            // 
            // txtamounttips
            // 
            txtamounttips.Location = new Point(281, 217);
            txtamounttips.Name = "txtamounttips";
            txtamounttips.Size = new Size(312, 27);
            txtamounttips.TabIndex = 9;
            // 
            // lblAmountTips
            // 
            lblAmountTips.AutoSize = true;
            lblAmountTips.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountTips.Location = new Point(69, 216);
            lblAmountTips.Name = "lblAmountTips";
            lblAmountTips.Size = new Size(206, 28);
            lblAmountTips.TabIndex = 8;
            lblAmountTips.Text = "ENTER amount tips: ";
            // 
            // calculate
            // 
            calculate.Location = new Point(96, 266);
            calculate.Name = "calculate";
            calculate.Size = new Size(94, 29);
            calculate.TabIndex = 10;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(209, 266);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(94, 29);
            clearbtn.TabIndex = 11;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // closebtn
            // 
            closebtn.Location = new Point(324, 266);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(94, 29);
            closebtn.TabIndex = 12;
            closebtn.Text = "close";
            // 
            // lblsales
            // 
            lblsales.AutoSize = true;
            lblsales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsales.Location = new Point(105, 312);
            lblsales.Name = "lblsales";
            lblsales.Size = new Size(136, 28);
            lblsales.TabIndex = 13;
            lblsales.Text = "SALES-TEXT :";
            lblsales.Click += lblsales_Click;
            // 
            // lblsalestext
            // 
            lblsalestext.AutoSize = true;
            lblsalestext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsalestext.Location = new Point(291, 312);
            lblsalestext.Name = "lblsalestext";
            lblsalestext.Size = new Size(0, 28);
            lblsalestext.TabIndex = 14;
            // 
            // lbltips
            // 
            lbltips.AutoSize = true;
            lbltips.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltips.Location = new Point(105, 352);
            lbltips.Name = "lbltips";
            lbltips.Size = new Size(162, 28);
            lbltips.TabIndex = 15;
            lbltips.Text = "TIPS-AMOUNT :";
            // 
            // lbltipsamount
            // 
            lbltipsamount.AutoSize = true;
            lbltipsamount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltipsamount.Location = new Point(291, 352);
            lbltipsamount.Name = "lbltipsamount";
            lbltipsamount.Size = new Size(0, 28);
            lbltipsamount.TabIndex = 16;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(92, 398);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(175, 28);
            lbltotal.TabIndex = 17;
            lbltotal.Text = "TOTAL-AMOUNT:";
            // 
            // lbltotalamount
            // 
            lbltotalamount.AutoSize = true;
            lbltotalamount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalamount.Location = new Point(291, 398);
            lbltotalamount.Name = "lbltotalamount";
            lbltotalamount.Size = new Size(0, 28);
            lbltotalamount.TabIndex = 18;
            // 
            // lblnet
            // 
            lblnet.AutoSize = true;
            lblnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnet.Location = new Point(125, 431);
            lblnet.Name = "lblnet";
            lblnet.Size = new Size(160, 28);
            lblnet.TabIndex = 19;
            lblnet.Text = "NET-AMOUNT :";
            // 
            // lblnetamount
            // 
            lblnetamount.AutoSize = true;
            lblnetamount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnetamount.Location = new Point(291, 431);
            lblnetamount.Name = "lblnetamount";
            lblnetamount.Size = new Size(0, 28);
            lblnetamount.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 313);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 27);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 352);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(281, 398);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 27);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(297, 435);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(312, 27);
            textBox4.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblnetamount);
            Controls.Add(lblnet);
            Controls.Add(lbltotalamount);
            Controls.Add(lbltotal);
            Controls.Add(lbltipsamount);
            Controls.Add(lbltips);
            Controls.Add(lblsalestext);
            Controls.Add(lblsales);
            Controls.Add(closebtn);
            Controls.Add(clearbtn);
            Controls.Add(calculate);
            Controls.Add(txtamounttips);
            Controls.Add(lblAmountTips);
            Controls.Add(txtpricefood2);
            Controls.Add(lblPrice2);
            Controls.Add(txtfood2);
            Controls.Add(lblFood2);
            Controls.Add(txtpricefood1);
            Controls.Add(lblPrice1);
            Controls.Add(txtfood1);
            Controls.Add(lblFood1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFood1;
        private TextBox txtfood1;
        private Label lblPrice1;
        private TextBox txtpricefood1;
        private Label lblFood2;
        private TextBox txtfood2;
        private Label lblPrice2;
        private TextBox txtpricefood2;
        private Label lblAmountTips;
        private TextBox txtamounttips;
        private Button calculate;
        private Button clearbtn;
        private Button closebtn;
        private Label lblsales;
        private Label lblsalestext;
        private Label lbltips;
        private Label lbltipsamount;
        private Label lbltotal;
        private Label lbltotalamount;
        private Label lblnet;
        private Label lblnetamount;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}