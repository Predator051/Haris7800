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
    public partial class LessonsInfo : Form
    {

        FileInfo fileLesson;
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
            rtbLessonsInfo.Size = new Size(this.Size.Width - 40, this.Size.Height - 65);
        }
    }
}
