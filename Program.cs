using tpmod7_kelompok;
using tpmodul7_kelompok;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa1302204032_ALWINFAHROZIMARBUN data = new DataMahasiswa1302204032_ALWINFAHROZIMARBUN();
        data.ReadJSON();

        KuliahMahasiswa1302204032_ALWINFAHROZIMARBUN kuliah = new KuliahMahasiswa1302204032_ALWINFAHROZIMARBUN();
        kuliah.ReadJSON();
    }
}