namespace GPA_Calculator
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Year 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Year 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Year 3", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Year 4", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.lblStNo = new System.Windows.Forms.Label();
            this.stlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student No: ";
            // 
            // lblStNo
            // 
            this.lblStNo.AutoSize = true;
            this.lblStNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStNo.Location = new System.Drawing.Point(153, 21);
            this.lblStNo.Name = "lblStNo";
            this.lblStNo.Size = new System.Drawing.Size(132, 25);
            this.lblStNo.TabIndex = 3;
            this.lblStNo.Text = "##/####/###";
            // 
            // stlist
            // 
            this.stlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            listViewGroup1.Header = "Year 1";
            listViewGroup1.Name = "year1";
            listViewGroup2.Header = "Year 2";
            listViewGroup2.Name = "year2";
            listViewGroup3.Header = "Year 3";
            listViewGroup3.Name = "year3";
            listViewGroup4.Header = "Year 4";
            listViewGroup4.Name = "year4";
            this.stlist.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.stlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.stlist.HideSelection = false;
            this.stlist.Location = new System.Drawing.Point(17, 70);
            this.stlist.Name = "stlist";
            this.stlist.Size = new System.Drawing.Size(544, 359);
            this.stlist.TabIndex = 4;
            this.stlist.UseCompatibleStateImageBehavior = false;
            this.stlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Code";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Credit";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grade";
            this.columnHeader2.Width = 100;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnter.Location = new System.Drawing.Point(444, 21);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(117, 39);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "ADD";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(812, 21);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 39);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(567, 70);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(362, 359);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQR.TabIndex = 7;
            this.picQR.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 435);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.stlist);
            this.Controls.Add(this.lblStNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "GPA Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStNo;
        private System.Windows.Forms.ListView stlist;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}