namespace Eticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            urunler urun1 = new urunler();
            urun1.markasi = "nike";
            urun1.numarasi = 41;
            urun1.fiyati = 27.90;


            urunler urun2 = new urunler();
            urun2.markasi = "adidas";
            urun2.numarasi = 31;
            urun2.fiyati = 25.62;


            urunler urun3 = new urunler();
            urun3.markasi = "puma";
            urunler[] ayakkabilar = new urunler[] {urun1, urun2,urun3};
            foreach (var urun in ayakkabilar)
            {
                Console.WriteLine(urun.markasi + ":" + urun.numarasi + ":" + urun.fiyati);
            }



            

        }
        class urunler
        {
            public string markasi { get; set; }
            public int numarasi { get; set; }
            public double fiyati { get; set; }
        }
         
    }
    
}