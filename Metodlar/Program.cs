namespace Metodlar

{
    class Program
    {
        static void Main(string[] args)
        {
           

            Urun urun1 = new Urun();
            urun1.adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.adi = "çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Çilek gibi çilek";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                //property
                Console.WriteLine(urun.adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama); 
                Console.WriteLine("---------------");


            }
            Console.WriteLine("--------Metotlar------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12);            

        }
    }
}