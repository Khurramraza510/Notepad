namespace WindowsFormsApplication8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCntrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCntrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPPERCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nORMALCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileToolStripMenuItem1,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openCntrlOToolStripMenuItem,
            this.saveCntrlSToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.newToolStripMenuItem.Text = "New                  Ctrl+N       ";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openCntrlOToolStripMenuItem
            // 
            this.openCntrlOToolStripMenuItem.Name = "openCntrlOToolStripMenuItem";
            this.openCntrlOToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.openCntrlOToolStripMenuItem.Text = "Open...              Cntrl+O";
            this.openCntrlOToolStripMenuItem.Click += new System.EventHandler(this.openCntrlOToolStripMenuItem_Click);
            // 
            // saveCntrlSToolStripMenuItem
            // 
            this.saveCntrlSToolStripMenuItem.Name = "saveCntrlSToolStripMenuItem";
            this.saveCntrlSToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.saveCntrlSToolStripMenuItem.Text = "Save                 Cntrl+S";
            this.saveCntrlSToolStripMenuItem.Click += new System.EventHandler(this.saveCntrlSToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 6);
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.toolStripMenuItem3,
            this.selectAllToolStripMenuItem1,
            this.timeDateToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem1.Text = "Edit";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.selectAllToolStripMenuItem.Text = "Cut             Ctrl+X";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteToolStripMenuItem.Text = "Copy          Ctrl+C";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.pasteToolStripMenuItem.Text = "Paste          Ctrl+V";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.deleteToolStripMenuItem1.Text = "Delete           Del";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.findToolStripMenuItem.Text = "Find...           Ctrl+F";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.findNextToolStripMenuItem.Text = "Find Next         F3";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.replaceToolStripMenuItem.Text = "Replace...      Ctrl+H";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.goToToolStripMenuItem.Text = "Go To...        Ctrl+G";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(192, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All          Ctrl+A";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // timeDateToolStripMenuItem
            // 
            this.timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            this.timeDateToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.timeDateToolStripMenuItem.Text = "Time/Date            F5";
            this.timeDateToolStripMenuItem.Click += new System.EventHandler(this.timeDateToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.textTransformToolStripMenuItem,
            this.fontStyleToolStripMenuItem,
            this.fontColourToolStripMenuItem});
            this.formatToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordToolStripMenuItem.Text = "Word Wrap";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // textTransformToolStripMenuItem
            // 
            this.textTransformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPPERCaseToolStripMenuItem,
            this.nORMALCaseToolStripMenuItem,
            this.lowerCaseToolStripMenuItem});
            this.textTransformToolStripMenuItem.Name = "textTransformToolStripMenuItem";
            this.textTransformToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textTransformToolStripMenuItem.Text = "Font";
            this.textTransformToolStripMenuItem.Click += new System.EventHandler(this.textTransformToolStripMenuItem_Click);
            // 
            // uPPERCaseToolStripMenuItem
            // 
            this.uPPERCaseToolStripMenuItem.Name = "uPPERCaseToolStripMenuItem";
            this.uPPERCaseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.uPPERCaseToolStripMenuItem.Text = "UPPER Case";
            this.uPPERCaseToolStripMenuItem.Click += new System.EventHandler(this.uPPERCaseToolStripMenuItem_Click);
            // 
            // nORMALCaseToolStripMenuItem
            // 
            this.nORMALCaseToolStripMenuItem.Name = "nORMALCaseToolStripMenuItem";
            this.nORMALCaseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nORMALCaseToolStripMenuItem.Text = "Normal Case";
            this.nORMALCaseToolStripMenuItem.Click += new System.EventHandler(this.nORMALCaseToolStripMenuItem_Click);
            // 
            // lowerCaseToolStripMenuItem
            // 
            this.lowerCaseToolStripMenuItem.Name = "lowerCaseToolStripMenuItem";
            this.lowerCaseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.lowerCaseToolStripMenuItem.Text = "Lower Case ";
            this.lowerCaseToolStripMenuItem.Click += new System.EventHandler(this.lowerCaseToolStripMenuItem_Click);
            // 
            // fontStyleToolStripMenuItem
            // 
            this.fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            this.fontStyleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontStyleToolStripMenuItem.Text = "Font Style";
            this.fontStyleToolStripMenuItem.Click += new System.EventHandler(this.fontStyleToolStripMenuItem_Click);
            // 
            // fontColourToolStripMenuItem
            // 
            this.fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            this.fontColourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontColourToolStripMenuItem.Text = "Font Colour";
            this.fontColourToolStripMenuItem.Click += new System.EventHandler(this.fontColourToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutNotepadToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutNotepadToolStripMenuItem
            // 
            this.aboutNotepadToolStripMenuItem.Name = "aboutNotepadToolStripMenuItem";
            this.aboutNotepadToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutNotepadToolStripMenuItem.Text = "About Notepad";
            this.aboutNotepadToolStripMenuItem.Click += new System.EventHandler(this.aboutNotepadToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCntrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCntrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textTransformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPPERCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nORMALCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNotepadToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColourToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

