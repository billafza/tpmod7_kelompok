using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tpmodul7_kelompok
{
    class DataMahasiswa1030223000126_KhansaAuliaFauzah
        public class Nama
        {
            [JsonPropertyName("depan")]
            public String depan { get; set; }

            [JsonPropertyName("belakang")]
            public String belakang { get; set; }
        }

        class Mahasiswa
        {
            [JsonPropertyName("nama")]
            public Nama nama { get; set; }

            [JsonPropertyName("nim")]
            public String nim { get; set; }

            [JsonPropertyName("fakultas")]
            public String fakultas { get; set; }
        }
        public void ReadJSON()
        {
            try
            {
                string jsonPath = "C:\\KhansaAulia\\tpmod7_kelompok\\tp7_1_103022300126.json";
                string jsonString = File.ReadAllText(jsonPath);

                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

