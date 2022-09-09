using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog note = new OpenFileDialog();
            note.Title = "Open";
            note.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (note.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(note.FileName, RichTextBoxStreamType.PlainText);
            }
            Text = note.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog note = new SaveFileDialog();
            note.Title = "Save";
            note.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (note.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(note.FileName, RichTextBoxStreamType.PlainText);
            }
            Text = note.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }
    }
}
