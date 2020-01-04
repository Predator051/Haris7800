using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Harris7800HMP
{
    public partial class LessonsInfo : Form
    {
        private FileInfo fileLesson;
        public LessonsInfo(FileInfo fl)
        {
            InitializeComponent();
            fileLesson = fl;
        }

        private void LessonsInfo_Load(object sender, EventArgs e)
        {
            rtbLessonsInfo.LoadFile(fileLesson.FullName);
        }

        private void LessonsInfo_Resize(object sender, EventArgs e)
        {
            rtbLessonsInfo.Size = new Size(Size.Width - 40, Size.Height - 65);
        }
    }
}
