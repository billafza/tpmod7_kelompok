using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod7_kelompok
{
    internal class KuliahMahasiswa103022300020_NADYASEKARRAHMAWATI
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CoursesList
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_2_103022300126.json");
            CoursesList data = JsonSerializer.Deserialize<CoursesList>(json);

            foreach (var course in data.courses)
            {
                Console.WriteLine($"{course.code} - {course.name}");
            }
        }

        static void Main(string[] args)
        {
            ReadJSON();
        }
    }
}
