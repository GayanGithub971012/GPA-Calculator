using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace GPA_Calculator
{
    public partial class Form2 : Form
    {
        String stNo;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.form2 = this;
            form.Show();
        }

        public void SetStudentNo(String stno)
        {
            this.stNo = stno;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Display Stno on form load 
            lblStNo.Text = this.stNo;

            

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void AddMarks(int year, String course, String grade, int credit)
        {
            ListViewItem stMark = new ListViewItem(course, stlist.Groups[year]);
            stMark.SubItems.Add(credit+"");
            stMark.SubItems.Add(grade);
            stlist.Items.Add(stMark);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int noOfTotCredits = 0;
            Double subGPA = 0.0f;
            Double GPA;

            foreach(ListViewItem mark in stlist.Items)
            {
                
                noOfTotCredits += Int16.Parse(mark.SubItems[1].Text);
                subGPA += Int16.Parse(mark.SubItems[1].Text) * GetGradePoint(mark.SubItems[2].Text);

            }

            if (noOfTotCredits != 0)
            {
                GPA = subGPA / noOfTotCredits;
                MessageBox.Show("Current GPA is " + String.Format("{0:0.00}", GPA), "GPA");
                GenerateQR(GPA);
            }
        }

        private void GenerateQR(Double GPA)
        {
            string gpa = String.Format("{0:0.0000}", GPA);
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(gpa, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(data);
            picQR.Image = qRCode.GetGraphic(5);
        }

        private float GetGradePoint(string GPA)
        {
            float gradeGPA = 0.0f;
            String gpa = GPA.ToUpper();

            switch (gpa)
            {
                case "A":
                case "A+":
                    gradeGPA = 4.0f;
                    break;
                case "A-":
                    gradeGPA = 3.7f;
                    break;
                case "B+":
                    gradeGPA = 3.3f;
                    break;
                case "B":
                    gradeGPA = 3.0f;
                    break;
                case "B-":
                    gradeGPA = 2.7f;
                    break;
                case "C+":
                    gradeGPA = 2.3f;
                    break;
                case "C":
                    gradeGPA = 2.0f;
                    break;
                case "C-":
                    gradeGPA = 1.7f;
                    break;
                case "D+":
                    gradeGPA = 1.3f;
                    break;
                case "D":
                    gradeGPA = 1.0f;
                    break;
                case "E":
                    gradeGPA = 0;
                    break;
            }
            
            return gradeGPA;
        }
    }
}
