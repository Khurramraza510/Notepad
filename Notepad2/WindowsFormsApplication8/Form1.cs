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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.Text = "Khurram Raza";
            this.textBox1.Multiline = true;
            this.textBox1.Dock = DockStyle.Fill;
            this.textBox1.CharacterCasing = CharacterCasing.Normal;
            this.nORMALCaseToolStripMenuItem.Checked = true;
            this.menuStrip1.BackColor = Color.Purple;
            this.menuStrip1.ForeColor = Color.White;
            this.textBox1.BackColor = Color.PeachPuff;
            
            
            
        }

        private void openCntrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = op.FileName;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.wordToolStripMenuItem.CheckOnClick = true;
            if(this.wordToolStripMenuItem.CheckOnClick == true)     
            {this.textBox1.WordWrap=true;}
        }

        private void uPPERCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.uPPERCaseToolStripMenuItem.Checked = true;
            if (this.uPPERCaseToolStripMenuItem.Checked == true)
            {
                this.textBox1.CharacterCasing = CharacterCasing.Upper;
                this.nORMALCaseToolStripMenuItem.Checked = false;
                this.lowerCaseToolStripMenuItem.Checked = false;
            }

        }

        private void nORMALCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nORMALCaseToolStripMenuItem.Checked = true;
            if (this.nORMALCaseToolStripMenuItem.Checked == true)
            { this.textBox1.CharacterCasing = CharacterCasing.Normal;
            this.uPPERCaseToolStripMenuItem.Checked = false;
            this.lowerCaseToolStripMenuItem.Checked = false;
            }
        }

        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lowerCaseToolStripMenuItem.Checked = true;
            if (this.lowerCaseToolStripMenuItem.Checked == true)
            {
                this.textBox1.CharacterCasing = CharacterCasing.Lower;
                this.uPPERCaseToolStripMenuItem.Checked = false;
                this.nORMALCaseToolStripMenuItem.Checked = false;
           }
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This notepad is created by KHURRAM RAZA");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveCntrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();

            if (sd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = sd.FileName;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void textTransformToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fontDialog1.ShowDialog();
            this.textBox1.Font = this.fontDialog1.Font;
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;

            }
        }

        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog1.ShowDialog();
            this.textBox1.ForeColor = this.colorDialog1.Color;
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;
            }
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
