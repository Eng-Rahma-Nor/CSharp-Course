namespace RoomBooking
{
    partial class Form4
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
            this.lblname = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtcourses = new System.Windows.Forms.TextBox();
            this.lblcourses = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.lblfee = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtoutname = new System.Windows.Forms.TextBox();
            this.txtoutid = new System.Windows.Forms.TextBox();
            this.txtoutcourses = new System.Windows.Forms.TextBox();
            this.txtoutlevel = new System.Windows.Forms.TextBox();
            this.txtouttransport = new System.Windows.Forms.TextBox();
            this.txtoutdiscount = new System.Windows.Forms.TextBox();
            this.txtoutfee = new System.Windows.Forms.TextBox();
            this.txtoutfinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Fee System";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(81, 109);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(313, 32);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Enter Student Name : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(479, 119);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(254, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(479, 166);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(254, 22);
            this.txtid.TabIndex = 6;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(99, 166);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(251, 32);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Enter Student Id :";
            // 
            // txtcourses
            // 
            this.txtcourses.Location = new System.Drawing.Point(484, 218);
            this.txtcourses.Name = "txtcourses";
            this.txtcourses.Size = new System.Drawing.Size(254, 22);
            this.txtcourses.TabIndex = 8;
            // 
            // lblcourses
            // 
            this.lblcourses.AutoSize = true;
            this.lblcourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourses.Location = new System.Drawing.Point(44, 218);
            this.lblcourses.Name = "lblcourses";
            this.lblcourses.Size = new System.Drawing.Size(386, 32);
            this.lblcourses.TabIndex = 7;
            this.lblcourses.Text = "Enter Number Of Courses : ";
            // 
            // txtlevel
            // 
            this.txtlevel.Location = new System.Drawing.Point(484, 280);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(254, 22);
            this.txtlevel.TabIndex = 10;
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllevel.Location = new System.Drawing.Point(129, 280);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(272, 32);
            this.lbllevel.TabIndex = 9;
            this.lbllevel.Text = "Enter Study Level :";
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(484, 355);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(254, 22);
            this.txtfee.TabIndex = 12;
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfee.Location = new System.Drawing.Point(129, 345);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(221, 32);
            this.lblfee.TabIndex = 11;
            this.lblfee.Text = "Transport Fee :";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalculate.Location = new System.Drawing.Point(71, 424);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(127, 47);
            this.btncalculate.TabIndex = 13;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclear.Location = new System.Drawing.Point(279, 424);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 47);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(470, 424);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(127, 47);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtoutname
            // 
            this.txtoutname.Location = new System.Drawing.Point(49, 517);
            this.txtoutname.Name = "txtoutname";
            this.txtoutname.Size = new System.Drawing.Size(300, 22);
            this.txtoutname.TabIndex = 16;
            // 
            // txtoutid
            // 
            this.txtoutid.Location = new System.Drawing.Point(50, 556);
            this.txtoutid.Name = "txtoutid";
            this.txtoutid.Size = new System.Drawing.Size(300, 22);
            this.txtoutid.TabIndex = 17;
            // 
            // txtoutcourses
            // 
            this.txtoutcourses.Location = new System.Drawing.Point(50, 600);
            this.txtoutcourses.Name = "txtoutcourses";
            this.txtoutcourses.Size = new System.Drawing.Size(300, 22);
            this.txtoutcourses.TabIndex = 18;
            // 
            // txtoutlevel
            // 
            this.txtoutlevel.Location = new System.Drawing.Point(50, 648);
            this.txtoutlevel.Name = "txtoutlevel";
            this.txtoutlevel.Size = new System.Drawing.Size(300, 22);
            this.txtoutlevel.TabIndex = 19;
            // 
            // txtouttransport
            // 
            this.txtouttransport.Location = new System.Drawing.Point(387, 517);
            this.txtouttransport.Name = "txtouttransport";
            this.txtouttransport.Size = new System.Drawing.Size(300, 22);
            this.txtouttransport.TabIndex = 20;
            // 
            // txtoutdiscount
            // 
            this.txtoutdiscount.Location = new System.Drawing.Point(387, 566);
            this.txtoutdiscount.Name = "txtoutdiscount";
            this.txtoutdiscount.Size = new System.Drawing.Size(300, 22);
            this.txtoutdiscount.TabIndex = 21;
            // 
            // txtoutfee
            // 
            this.txtoutfee.Location = new System.Drawing.Point(387, 612);
            this.txtoutfee.Name = "txtoutfee";
            this.txtoutfee.Size = new System.Drawing.Size(300, 22);
            this.txtoutfee.TabIndex = 22;
            // 
            // txtoutfinal
            // 
            this.txtoutfinal.Location = new System.Drawing.Point(387, 648);
            this.txtoutfinal.Name = "txtoutfinal";
            this.txtoutfinal.Size = new System.Drawing.Size(300, 22);
            this.txtoutfinal.TabIndex = 23;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 749);
            this.Controls.Add(this.txtoutfinal);
            this.Controls.Add(this.txtoutfee);
            this.Controls.Add(this.txtoutdiscount);
            this.Controls.Add(this.txtouttransport);
            this.Controls.Add(this.txtoutlevel);
            this.Controls.Add(this.txtoutcourses);
            this.Controls.Add(this.txtoutid);
            this.Controls.Add(this.txtoutname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.txtlevel);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.txtcourses);
            this.Controls.Add(this.lblcourses);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtcourses;
        private System.Windows.Forms.Label lblcourses;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Label lblfee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtoutname;
        private System.Windows.Forms.TextBox txtoutid;
        private System.Windows.Forms.TextBox txtoutcourses;
        private System.Windows.Forms.TextBox txtoutlevel;
        private System.Windows.Forms.TextBox txtouttransport;
        private System.Windows.Forms.TextBox txtoutdiscount;
        private System.Windows.Forms.TextBox txtoutfee;
        private System.Windows.Forms.TextBox txtoutfinal;
    }
}