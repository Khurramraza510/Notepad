using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.FindForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "FIND";
            this.label1.Text = "Find";

            button1.Text = "Find Next";
            button2.Text = "Cancel";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
