using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Harris7800HMP.BDManagers;

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
            try
            {
                //rtbLessonsInfo.LoadFile(fileLesson.FullName);

                using RichTextBox RTB = new RichTextBox();
                RTB.LoadFile(fileLesson.FullName);
                
                Lesson lesson = new Lesson();
                lesson.name = fileLesson.Name;
                lesson.description = RTB.Rtf;
                LessonsManager.CreateLessons(lesson);
                lesson = LessonsManager.GetAllLessons()[0];

                rtbLessonsInfo.Clear();
                rtbLessonsInfo.Rtf = lesson.description;

                //string desc = System.IO.File.ReadAllText(fileLesson.FullName);

                //rtbLessonsInfo.Clear();
                //rtbLessonsInfo.LoadFile(fileLesson.FullName);

                //MySqlManager.BDManager.SqlQuery($"INSERT TestTable(textValue, intValue) VALUES ({"'LolHaha'"}, {1});");
                //MySqlManager.BDManager.SqlQuery($"INSERT TestTable(textValue, intValue) VALUES ({"'LolHaha1'"}, {2});");

                //var ds = MySqlManager.BDManager.SqlQuery($"SELECT * FROM TestTable");
                //foreach (DataTable dt in ds.Tables)
                //{
                //    Console.WriteLine(dt.TableName); // название таблицы
                //                                     // перебор всех столбцов
                //    foreach (DataColumn column in dt.Columns)
                //        rtbLessonsInfo.Text += $"\n\t{column.ColumnName}";
                //    rtbLessonsInfo.Text += "\n";
                //    // перебор всех строк таблицы
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        // получаем все ячейки строки
                //        var cells = row.ItemArray;
                //        foreach (object cell in cells)
                //            rtbLessonsInfo.Text += $"\t{cell}";
                //        rtbLessonsInfo.Text += "\n";
                //    }
                //}
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //throw;
            }
        }

        private void LessonsInfo_Resize(object sender, EventArgs e)
        {
            rtbLessonsInfo.Size = new Size(Size.Width - 40, Size.Height - 65);
        }
    }
}
