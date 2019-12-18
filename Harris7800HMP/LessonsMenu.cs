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

    public partial class LessonsMenu : Form
    {
        public FileInfo[] loadListOfLessons()
        {
            DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.LessonsDirectory);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.rtf"); //Getting Text files


            return Files.Where((fInfo) => fInfo.Name[0] != '~' ).ToArray();
        }

        public LessonsMenu()
        {
            InitializeComponent();
            var lessons = loadListOfLessons();
            foreach (var fileName in lessons)
            {
                lbLessons.Items.Add(new LessonItem(fileName));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LessonItem lessonItem = (LessonItem)lbLessons.SelectedItem;
            Form1 form = new Form1(lessonItem.Lesson);
            form.Show(this);
        }
    }
}
