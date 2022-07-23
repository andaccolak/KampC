using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {

        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler sepete eklendi : " +urun.adi);
            
        }
        public void Ekle2(string urunadi, string aciklama, double fiyat)
        {
            Console.WriteLine("tebrikler sepete eklendi : " + urunadi);
        }
    }
}
