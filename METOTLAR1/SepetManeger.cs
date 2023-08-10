using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METOTLAR1
{
    internal class SepetManeger
    {
        //Naming convention 
        //syntax 
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete eklend : " + urun.Adi);

        }
        public void Ekle2 (string Adi,string Aciklama,double fiyat,int stokadeti)
        {
            Console.WriteLine("Sepete eklend : " + Adi);
        }
    }
}
