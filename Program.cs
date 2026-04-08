ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(60);
imageProcessor.Resize(150);
imageProcessor.Resize(100);

imageProcessor.Resize(720, 1080);
imageProcessor.Resize("F4");
class ImageProcessor
{
    public void Resize(int presentase)
    {
        if (presentase <= 0)
        {
            Console.WriteLine("Error! Presentase tidak boleh nol(0) atau negatif");
        }
        if (presentase < 100)
        {
            Console.WriteLine($"Mengecilkan gambar menjadi {presentase}");
        }
        else if (presentase > 100)
        {
            Console.WriteLine($"Memperbesar gambar menjadi {presentase}");
        }
        else
        {
            Console.WriteLine("Ukuran tetap 100% tidak ada perubahan");
        }
    }
    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"mengubah ukuran gambar menjadi {lebar}ps X {tinggi}");
    }
    public void Resize(string ukuran_kertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {ukuran_kertas}");
    }
}
