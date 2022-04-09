using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.ForeColor != textBox1.BackColor || textBox2.ForeColor != textBox2.BackColor) {
            using (ColorDialog dialog = new ColorDialog())
                {
                dialog.ShowDialog();
                    textBox1.ForeColor = dialog.Color;
                    textBox2.ForeColor = dialog.Color;
                }
            }
            else { }
        }

        private void цветЛистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.ForeColor != textBox1.BackColor || textBox2.ForeColor != textBox2.BackColor) {
            using (ColorDialog dialog = new ColorDialog())
                {
                dialog.ShowDialog();
                textBox1.BackColor = dialog.Color;
                textBox2.BackColor = dialog.Color;
                }
            }
            else { }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                dialog.ShowDialog();
                textBox1.Font = dialog.Font;
                textBox2.Font = dialog.Font;
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintDialog dialog = new PrintDialog())
            {
                dialog.ShowDialog();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "*.txt|*.txt|*.doc|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, textBox1.Text);
                    File.WriteAllText(dialog.FileName, textBox2.Text);
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "*.txt|*.txt|*.doc|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(dialog.FileName);
                    textBox2.Text = File.ReadAllText(dialog.FileName);
                }
            }
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
