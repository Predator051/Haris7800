using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harris7800HMP.MySqlManager;

namespace Harris7800HMP.BDManagers
{
    public class Lesson
    {
        public int id = 0;
        public string name = "";
        public string description = "";

        public static Lesson parseFromDB(DataRow row)
        {
            return new Lesson()
            {
                id = (int) row["Id"], 
                name = (string) row["Name"], 
                description = (string) row["Description"]
            };
        }
    }

    class LessonsManager
    {
        public static List<Lesson> GetAllLessons()
        {
            List<Lesson> output = new List<Lesson>();

            DataSet ds = BDManager.SqlQuery("SELECT * FROM Lessons");

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    output.Add(Lesson.parseFromDB(row));
                }
            }

            return output;
        }

        public static void CreateLessons(Lesson lesson)
        {
            //BDManager.SqlQuery($"INSERT Lessons(Name, Description) VALUES ('{lesson.name}', '{lesson.description}');");

            var connection = BDManager.CreateMySqlConnection();

            System.Data.SqlClient.SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT Lessons(Name, Description) VALUES (@name, @description);";
            command.Parameters.AddWithValue("@name", lesson.name);
            command.Parameters.AddWithValue("@description", lesson.description);

            connection.Open();
            command.ExecuteNonQuery();


        }
    }
}
