using System.IO;

namespace Harris7800HMP
{
    public class LessonItem
    {
        public LessonItem(FileInfo fileLesson)
        {
            Lesson = fileLesson;
        }

        private FileInfo lesson;

        public FileInfo Lesson { get => lesson; set => lesson = value; }

        public override string ToString()
        {
            return Lesson.Name.Substring(0, Lesson.Name.Length - 4);
        }
    }

}
