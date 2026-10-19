namespace RoomBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.Label();
            this.txtnights = new System.Windows.Forms.Label();
            this.txtguests = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txthight = new System.Windows.Forms.RadioButton();
            this.txtnormal = new System.Windows.Forms.RadioButton();
            this.txtstandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbreakfast = new System.Windows.Forms.CheckBox();
            this.Btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1203, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Room Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(82, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(207, 32);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "Guest Name : ";
            // 
            // txtage
            // 
            this.txtage.AutoSize = true;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.Color.Black;
            this.txtage.Location = new System.Drawing.Point(111, 91);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(182, 32);
            this.txtage.TabIndex = 3;
            this.txtage.Text = "Guest Age : ";
            // 
            // txtnights
            // 
            this.txtnights.AutoSize = true;
            this.txtnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnights.ForeColor = System.Drawing.Color.Black;
            this.txtnights.Location = new System.Drawing.Point(23, 132);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(272, 32);
            this.txtnights.TabIndex = 4;
            this.txtnights.Text = "Number Of Nights :";
            // 
            // txtguests
            // 
            this.txtguests.AutoSize = true;
            this.txtguests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguests.ForeColor = System.Drawing.Color.Black;
            this.txtguests.Location = new System.Drawing.Point(23, 179);
            this.txtguests.Name = "txtguests";
            this.txtguests.Size = new System.Drawing.Size(266, 32);
            this.txtguests.TabIndex = 5;
            this.txtguests.Text = "Number Of Guest :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 41);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 41);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 41);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(299, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 41);
            this.textBox4.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtnights);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtguests);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 239);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txthight);
            this.groupBox2.Controls.Add(this.txtnormal);
            this.groupBox2.Controls.Add(this.txtstandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // txthight
            // 
            this.txthight.AutoSize = true;
            this.txthight.ForeColor = System.Drawing.Color.Black;
            this.txthight.Location = new System.Drawing.Point(368, 46);
            this.txthight.Name = "txthight";
            this.txthight.Size = new System.Drawing.Size(107, 36);
            this.txthight.TabIndex = 14;
            this.txthight.TabStop = true;
            this.txthight.Text = "Hight";
            this.txthight.UseVisualStyleBackColor = true;
            // 
            // txtnormal
            // 
            this.txtnormal.AutoSize = true;
            this.txtnormal.ForeColor = System.Drawing.Color.Black;
            this.txtnormal.Location = new System.Drawing.Point(207, 46);
            this.txtnormal.Name = "txtnormal";
            this.txtnormal.Size = new System.Drawing.Size(132, 36);
            this.txtnormal.TabIndex = 13;
            this.txtnormal.TabStop = true;
            this.txtnormal.Text = "Normal";
            this.txtnormal.UseVisualStyleBackColor = true;
            // 
            // txtstandard
            // 
            this.txtstandard.AutoSize = true;
            this.txtstandard.ForeColor = System.Drawing.Color.Black;
            this.txtstandard.Location = new System.Drawing.Point(29, 46);
            this.txtstandard.Name = "txtstandard";
            this.txtstandard.Size = new System.Drawing.Size(159, 36);
            this.txtstandard.TabIndex = 12;
            this.txtstandard.TabStop = true;
            this.txtstandard.Text = "Standard";
            this.txtstandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbreakfast);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Options";
            // 
            // txtbreakfast
            // 
            this.txtbreakfast.AutoSize = true;
            this.txtbreakfast.ForeColor = System.Drawing.Color.Black;
            this.txtbreakfast.Location = new System.Drawing.Point(32, 47);
            this.txtbreakfast.Name = "txtbreakfast";
            this.txtbreakfast.Size = new System.Drawing.Size(510, 36);
            this.txtbreakfast.TabIndex = 16;
            this.txtbreakfast.Text = "Breakfast (10 Per Guest Per night) ";
            this.txtbreakfast.UseVisualStyleBackColor = true;
            // 
            // Btncalculate
            // 
            this.Btncalculate.ForeColor = System.Drawing.Color.Black;
            this.Btncalculate.Location = new System.Drawing.Point(179, 576);
            this.Btncalculate.Name = "Btncalculate";
            this.Btncalculate.Size = new System.Drawing.Size(151, 43);
            this.Btncalculate.TabIndex = 16;
            this.Btncalculate.Text = "Calculate";
            this.Btncalculate.UseVisualStyleBackColor = true;
            this.Btncalculate.Click += new System.EventHandler(this.Btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(377, 576);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 43);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(569, 576);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(115, 43);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Booking Details"});
            this.listBox1.Location = new System.Drawing.Point(670, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 468);
            this.listBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1203, 673);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.Btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtage;
        private System.Windows.Forms.Label txtnights;
        private System.Windows.Forms.Label txtguests;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton txthight;
        private System.Windows.Forms.RadioButton txtnormal;
        private System.Windows.Forms.RadioButton txtstandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox txtbreakfast;
        private System.Windows.Forms.Button Btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

