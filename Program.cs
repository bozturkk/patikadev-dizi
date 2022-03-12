using System;

namespace diziler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new String[5]; // dizinin boyutu belli eleman belli değil.
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            //değer atama ve erişim
            renkler[0]="Mavi";
            Console.WriteLine(hayvanlar[0]); // dizilere erişim
            // diziler 0. index den başlar.
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);

            //döngülerle dizi
            Console.WriteLine("Lütfen dizinin uzunluğunu giriniz.");
            int a = int.Parse(Console.ReadLine());
            int[] sayilar = new int[a];
            
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Lütfen dizinin " + i+1 + ". elemanını giriniz: ");
                int nowValue = int.Parse(Console.ReadLine());
                sayilar[i] = nowValue;
            }
            int toplam = 0;
            
            Console.WriteLine("girdiğiniz sayılar şu şekilde :");
            foreach (var sayi in sayilar)
            {
                Console.Write(sayi + ", ");
                toplam += sayi;
            }
            Console.WriteLine("sayiların toplamı şu şekilde : {0}", toplam);

            
        }
    }
}