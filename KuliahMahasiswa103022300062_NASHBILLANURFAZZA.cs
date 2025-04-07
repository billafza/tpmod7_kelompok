using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod7_kelompok
{
    public class Course 
    {
        public String code { get; set; }
        public String name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    public class KuliahMahasiswa103022300062_NASHBILLANURFAZZA
    {
        

        public void ReadJSON()
        {
            try
            {
                string jsonPath = "C:\\NASHBILLA NURFAZZA\\PRAKTIKUM KONSTRUKSI PL\\tpmod7_kelompok\\tp7_2_103022300062.json";
                string jsonString = File.ReadAllText(jsonPath);
                CourseList courseList = JsonSerializer.Deserialize<CourseList>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 1;
                foreach (var mk in courseList.courses)
                {
                    Console.WriteLine($"MK {i} {mk.code} - {mk.name}");
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
