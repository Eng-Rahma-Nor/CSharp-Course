namespace RoomBooking
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtbuggage = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtgroupbox2 = new System.Windows.Forms.GroupBox();
            this.txtbusiness = new System.Windows.Forms.RadioButton();
            this.txtnormal = new System.Windows.Forms.RadioButton();
            this.txtfirst = new System.Windows.Forms.RadioButton();
            this.txtgroupbox1 = new System.Windows.Forms.GroupBox();
            this.txtinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.txtgroupbox2.SuspendLayout();
            this.txtgroupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline Ticket Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txtbuggage);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txttickets);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 153);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(297, 36);
            this.textBox4.TabIndex = 9;
            // 
            // txtbuggage
            // 
            this.txtbuggage.AutoSize = true;
            this.txtbuggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuggage.Location = new System.Drawing.Point(25, 148);
            this.txtbuggage.Name = "txtbuggage";
            this.txtbuggage.Size = new System.Drawing.Size(230, 25);
            this.txtbuggage.TabIndex = 8;
            this.txtbuggage.Text = "Baggage Weight (kg) :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 116);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 31);
            this.textBox3.TabIndex = 7;
            // 
            // txttickets
            // 
            this.txttickets.AutoSize = true;
            this.txttickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttickets.Location = new System.Drawing.Point(62, 111);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(200, 25);
            this.txttickets.TabIndex = 6;
            this.txttickets.Text = "Number of Tickets :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 27);
            this.textBox2.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.AutoSize = true;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(79, 78);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(176, 25);
            this.txtage.TabIndex = 4;
            this.txtage.Text = "Passenger age : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 32);
            this.textBox1.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(79, 45);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(196, 25);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "Passenger Name : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtgroupbox2
            // 
            this.txtgroupbox2.Controls.Add(this.txtbusiness);
            this.txtgroupbox2.Controls.Add(this.txtnormal);
            this.txtgroupbox2.Controls.Add(this.txtfirst);
            this.txtgroupbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgroupbox2.Location = new System.Drawing.Point(6, 255);
            this.txtgroupbox2.Name = "txtgroupbox2";
            this.txtgroupbox2.Size = new System.Drawing.Size(577, 114);
            this.txtgroupbox2.TabIndex = 3;
            this.txtgroupbox2.TabStop = false;
            this.txtgroupbox2.Text = "Travel Class";
            // 
            // txtbusiness
            // 
            this.txtbusiness.AutoSize = true;
            this.txtbusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusiness.Location = new System.Drawing.Point(374, 48);
            this.txtbusiness.Name = "txtbusiness";
            this.txtbusiness.Size = new System.Drawing.Size(182, 29);
            this.txtbusiness.TabIndex = 6;
            this.txtbusiness.TabStop = true;
            this.txtbusiness.Text = "Business Class";
            this.txtbusiness.UseVisualStyleBackColor = true;
            // 
            // txtnormal
            // 
            this.txtnormal.AutoSize = true;
            this.txtnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormal.Location = new System.Drawing.Point(206, 48);
            this.txtnormal.Name = "txtnormal";
            this.txtnormal.Size = new System.Drawing.Size(162, 29);
            this.txtnormal.TabIndex = 5;
            this.txtnormal.TabStop = true;
            this.txtnormal.Text = "Normal Class";
            this.txtnormal.UseVisualStyleBackColor = true;
            // 
            // txtfirst
            // 
            this.txtfirst.AutoSize = true;
            this.txtfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirst.Location = new System.Drawing.Point(64, 48);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(136, 29);
            this.txtfirst.TabIndex = 4;
            this.txtfirst.TabStop = true;
            this.txtfirst.Text = "First Class";
            this.txtfirst.UseVisualStyleBackColor = true;
            // 
            // txtgroupbox1
            // 
            this.txtgroupbox1.Controls.Add(this.txtinsurance);
            this.txtgroupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgroupbox1.Location = new System.Drawing.Point(12, 391);
            this.txtgroupbox1.Name = "txtgroupbox1";
            this.txtgroupbox1.Size = new System.Drawing.Size(577, 114);
            this.txtgroupbox1.TabIndex = 7;
            this.txtgroupbox1.TabStop = false;
            this.txtgroupbox1.Text = "Additional Options";
            // 
            // txtinsurance
            // 
            this.txtinsurance.AutoSize = true;
            this.txtinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinsurance.Location = new System.Drawing.Point(48, 51);
            this.txtinsurance.Name = "txtinsurance";
            this.txtinsurance.Size = new System.Drawing.Size(403, 29);
            this.txtinsurance.TabIndex = 0;
            this.txtinsurance.Text = "Add Travel Insurance ($25 Per Ticket)";
            this.txtinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(60, 539);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(102, 41);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(331, 539);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 41);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(201, 539);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 41);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Airline Booking Details"});
            this.listBox1.Location = new System.Drawing.Point(607, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 436);
            this.listBox1.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 622);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtgroupbox1);
            this.Controls.Add(this.txtgroupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtgroupbox2.ResumeLayout(false);
            this.txtgroupbox2.PerformLayout();
            this.txtgroupbox1.ResumeLayout(false);
            this.txtgroupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtage;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtbuggage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txttickets;
        private System.Windows.Forms.GroupBox txtgroupbox2;
        private System.Windows.Forms.RadioButton txtfirst;
        private System.Windows.Forms.RadioButton txtbusiness;
        private System.Windows.Forms.RadioButton txtnormal;
        private System.Windows.Forms.GroupBox txtgroupbox1;
        private System.Windows.Forms.CheckBox txtinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox listBox1;
    }
}