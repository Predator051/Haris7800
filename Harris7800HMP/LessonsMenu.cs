using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Harris7800HMP
{

    public partial class LessonsMenu : Form
    {
        public FileInfo[] LoadListOfLessons()
        {
            var d = new DirectoryInfo(Properties.Settings.Default.LessonsDirectory);//Assuming Test is your Folder
            if (!d.Exists)
            {
                d.Create();

                using RichTextBox RTB = new RichTextBox();
                RTB.Rtf = @"{\rtf1 DEFAULT TEXT!}";
                RTB.SaveFile(d.FullName + "\\default.rtf", RichTextBoxStreamType.RichText);
            }
            var files = d.GetFiles("*.rtf"); //Getting Text files
           

            return files.Where((fInfo) => fInfo.Name[0] != '~').ToArray();
        }

        public LessonsMenu()
        {
            InitializeComponent();
            var lessons = LoadListOfLessons();
            foreach (var fileName in lessons)
            {
                lbLessons.Items.Add(new LessonItem(fileName));
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLessons.SelectedItem != null)
            {
                var lessonItem = (LessonItem)lbLessons.SelectedItem;
                var form = new Form1(lessonItem.Lesson);
                form.Show(this);
            }
        }

        private void параметриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pMenu = new ParametersMenu();
            pMenu.ShowDialog();

            this.lbLessons.Items.Clear();

            var lessons = LoadListOfLessons();
            foreach (var fileName in lessons)
            {
                lbLessons.Items.Add(new LessonItem(fileName));
            }
        }
    }
}
