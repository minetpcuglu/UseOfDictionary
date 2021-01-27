using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASAMA 1 YOLU AYARLA
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //ASAMA 2  VERİ EKLEME
            AdYas.Add("Mine", 22);
            AdYas.Add("Emre", 19);
            AdYas.Add("Elif", 26);

            //ASAMA 3 FOREACH BU DEGERLERİN OKUNMASINI SAGLAMAK
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            //ASAMA 4 DEGER SAYMA ÖZELLİĞİ
            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman sayısı: "+eleman);

            //ASAMA 5 SİLME İŞLEMİ VARDIR
            AdYas.Remove("Elif");
            Console.WriteLine();

            //ASAMA 6 SİLME İŞLEMİNİ OKUTMA SAGLAMAK
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.WriteLine();
        }
    }
}
