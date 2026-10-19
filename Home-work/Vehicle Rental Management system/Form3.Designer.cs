namespace VehicleRentalSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.lblexperience = new System.Windows.Forms.Label();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Rental Management ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtexperience);
            this.groupBox1.Controls.Add(this.lblexperience);
            this.groupBox1.Controls.Add(this.txtdays);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lbldays);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(5, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer information ";
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(333, 184);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(270, 38);
            this.txtexperience.TabIndex = 8;
            // 
            // lblexperience
            // 
            this.lblexperience.AutoSize = true;
            this.lblexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexperience.ForeColor = System.Drawing.Color.Black;
            this.lblexperience.Location = new System.Drawing.Point(6, 193);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(303, 25);
            this.lblexperience.TabIndex = 7;
            this.lblexperience.Text = "Years Of Driving Experience : ";
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(319, 128);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(270, 38);
            this.txtdays.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(319, 81);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(270, 38);
            this.txtage.TabIndex = 6;
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.ForeColor = System.Drawing.Color.Black;
            this.lbldays.Location = new System.Drawing.Point(50, 139);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(233, 22);
            this.lbldays.TabIndex = 5;
            this.lbldays.Text = "Number Of Rental Days :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.Black;
            this.lblage.Location = new System.Drawing.Point(114, 90);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(169, 25);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "Customer Age : ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(319, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(270, 38);
            this.txtname.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(97, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(186, 25);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Customer Name : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.rdoluxury);
            this.groupBox2.Controls.Add(this.rdosuv);
            this.groupBox2.Controls.Add(this.rdoeconomy);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(5, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Type";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(394, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(183, 138);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(175, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoluxury.ForeColor = System.Drawing.Color.Black;
            this.rdoluxury.Location = new System.Drawing.Point(427, 47);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(103, 33);
            this.rdoluxury.TabIndex = 5;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseCompatibleTextRendering = true;
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosuv.ForeColor = System.Drawing.Color.Black;
            this.rdosuv.Location = new System.Drawing.Point(236, 47);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(67, 33);
            this.rdosuv.TabIndex = 4;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "suv";
            this.rdosuv.UseCompatibleTextRendering = true;
            this.rdosuv.UseVisualStyleBackColor = true;
            this.rdosuv.CheckedChanged += new System.EventHandler(this.rdosuv_CheckedChanged);
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoeconomy.ForeColor = System.Drawing.Color.Black;
            this.rdoeconomy.Location = new System.Drawing.Point(30, 47);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(131, 33);
            this.rdoeconomy.TabIndex = 3;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseCompatibleTextRendering = true;
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkinsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(5, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insurance Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.ForeColor = System.Drawing.Color.Black;
            this.chkinsurance.Location = new System.Drawing.Point(73, 46);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(419, 36);
            this.chkinsurance.TabIndex = 4;
            this.chkinsurance.Text = "Add insurance ($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.Blue;
            this.btncalculate.Location = new System.Drawing.Point(180, 703);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(142, 63);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "🧮  Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnclear.Location = new System.Drawing.Point(363, 703);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(149, 63);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "🧹 Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(532, 706);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(147, 60);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "🚪Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstresults
            // 
            this.lstresults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresults.ForeColor = System.Drawing.Color.Blue;
            this.lstresults.FormattingEnabled = true;
            this.lstresults.ItemHeight = 25;
            this.lstresults.Items.AddRange(new object[] {
            "Rental Information And Results"});
            this.lstresults.Location = new System.Drawing.Point(650, 78);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(457, 504);
            this.lstresults.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 799);
            this.Controls.Add(this.lstresults);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstresults;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}