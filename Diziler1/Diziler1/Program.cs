using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tek boyutlu dizi oluştur
            int[] notlar = { 75, 85, 90, 60, 95 };

            // Toplam ve ortalama hesapla
            int toplam = 0;
            foreach (int not in notlar)
            {
                toplam += not;
            }
            double ortalama = (double)toplam / notlar.Length;

            Console.WriteLine($"Notlar: {string.Join(", ", notlar)}");
            Console.WriteLine($"Ortalama: {ortalama}");

            // Array sınıfı metodları
            Array.Sort(notlar);
            Console.WriteLine("Sıralı Notlar (Artan): " + string.Join(", ", notlar));

            Array.Reverse(notlar);
            Console.WriteLine("Sıralı Notlar (Azalan): " + string.Join(", ", notlar));

            int enYuksek = notlar[0]; // en son sıraladığımız için en yüksek not ilk eleman
            Console.WriteLine($"En yüksek not: {enYuksek}");
        }
    }
}
