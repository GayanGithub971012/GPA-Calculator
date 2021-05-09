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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtStudentNo.Text != "")
            {
                Form2 form2 = new Form2();
                form2.SetStudentNo(txtStudentNo.Text.ToString());
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Student no is required!", "Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            
        }
    }
}
