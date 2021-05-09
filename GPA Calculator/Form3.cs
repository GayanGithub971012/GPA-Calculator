using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form3 : Form
    {
        public Form2 form2;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form2.AddMarks(cmbYear.SelectedIndex, txtCoursecode.Text, txtGrade.Text, Int16.Parse(txtCredit.Text));
            txtCoursecode.Text = "";
            txtCredit.Text = "";
            txtGrade.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = 0;
        }
    }
}
