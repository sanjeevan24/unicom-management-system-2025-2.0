using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unicom_management_system_2025.Model;

namespace unicom_management_system_2025.Repositories
{
    internal class CourseRepository
    {
        public static void AddCourse(Course course)
        {
            using (var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@CourseName)", DatabaseManager.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.ExecuteNonQuery();
            }
        }

        // Get all courses
        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            using (var cmd = new SQLiteCommand("SELECT * FROM Courses", DatabaseManager.GetConnection()))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    });
                }
            }

            return courses;
        }

        // Delete a course
        public static void DeleteCourse(int courseId)
        {
            using (var cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @CourseID", DatabaseManager.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

