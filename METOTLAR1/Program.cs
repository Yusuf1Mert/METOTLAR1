using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace METOTLAR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("- - - - - - - - - - - -");

            }

            Console.WriteLine("------------Metotlar----------");

            SepetManeger sepetManager = new SepetManeger();
            sepetManager.Ekle(urun1 );
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut", 13, 11);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Diyerbakır karpuzu ", 23, 15);

        }
    }
}
