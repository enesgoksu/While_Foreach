﻿namespace While_Foreach.While_Foreach
{
    class Program
    {
        public static void Main(string[] args)
        {
            // While
            // 1' den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesapla konsola yazdır.
            
            // Console.Write("Bir sayı girin: ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
        
            //     while(sayac <= sayi)
            //     {
            //         toplam += sayac;
            //         sayac ++;
            //     }    
            //         Console.WriteLine(toplam / sayi);



            // // 'a' dan 'z' ye kadar bütün harfleri konsola yazdır.

            // char character = 'a';

            // while (character < 'z')
            // {
            //     Console.Write(character);
            //     character ++;
            // }



            Console.WriteLine("**** Foreach **** ");
            string[] arabalar = {"Bmw","Ford","Toyata","Nissan"};
            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}