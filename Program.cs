using tpmod7_kelompok;
using tpmodul7_kelompok;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300062_NASHBILLANURFAZZA data = new DataMahasiswa103022300062_NASHBILLANURFAZZA();
        data.ReadJSON();

        KuliahMahasiswa103022300062_NASHBILLANURFAZZA kuliah = new KuliahMahasiswa103022300062_NASHBILLANURFAZZA();
        kuliah.ReadJSON();
    }
}