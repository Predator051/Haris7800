using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harris7800HMP
{
    public partial class ParametersMenu : Form
    {
        public ParametersMenu()
        {
            InitializeComponent();
            var d = new DirectoryInfo(Properties.Settings.Default.LessonsDirectory);
            this.textBox1.Text = d.FullName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                this.textBox1.Text = fbd.SelectedPath;
                Properties.Settings.Default.LessonsDirectory = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }
    }
}
