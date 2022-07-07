using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            Console.WriteLine("lütfen bir sayı girin");
            //ekrana girilen sayıya kadar olan tek sayıları ekrana yazdırın
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
                
            }
            //GİRİLEN SAYIYA KADAR 1000 OLAN tek sayıların ve çift sayıların toplamını yazan kod.
            int tektoplam=0;
            int cifttoplam=0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1)
                tektoplam+=i;
                else
                cifttoplam+=i;
                
            }
            Console.WriteLine("tek toplam "+tektoplam);
            Console.WriteLine("çift toplam "+cifttoplam);
            //break continue
            Console.WriteLine("sayi girin");
            int s=int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
                
            }
             for (int i = 0; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
                
            }


        }
    }
}

