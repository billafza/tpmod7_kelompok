using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod7_kelompok
{
    internal class DataMahasiswa103022300020_NADYASEKARRAHMAWATI
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("tp7_1_103022300020.json");
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(json);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }

        static void Main(string[] args)
        {
            ReadJSON();
        }
    }
}
