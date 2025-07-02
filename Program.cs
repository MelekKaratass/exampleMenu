/*
1 Adana 12.00 TL
2 Beyti 22.00 TL
3 Salata 7.00 TL
4 Çorba  8.00 TL
5 İçecek 4.00 Tl
6 Çıkış
 */

using System;

int secim;
double toplam = 0;
do
{
    Console.WriteLine("1 Adana 12.75 TL");
    Console.WriteLine("2 Beyti 22.50 TL");
    Console.WriteLine("3 Salata 7.00 TL");
    Console.WriteLine("4 Çorba  8.00 TL)");
    Console.WriteLine("5 İçecek 4.25 Tl");
    Console.WriteLine("6 Çıkış");
    Console.WriteLine("Lütfen seçim yapınız");
    secim = int.Parse(Console.ReadLine());
   

    switch (secim)
    {
        case 1:
            toplam += 12.75;
            Console.WriteLine("Şuanki hesap ="+toplam);
            break;

        case 2:
            toplam += 22.50;
            Console.WriteLine("Şuanki hesap =" + toplam);
            break;
        case 3:
            toplam += 7.00;
            Console.WriteLine("Şuanki hesap =" + toplam);
            break;
        case 4:
            toplam += 8.00;
            Console.WriteLine("Şuanki hesap =" + toplam);
            break;
        case 5:
            toplam += 4.25;
            Console.WriteLine("Şuanki hesap =" + toplam);
            break;
        case 6:
            Console.WriteLine("Alışverişiniz tamamlandı.");
            break;
        default:
            Console.WriteLine("Lütfen 1-6 arasında seçim yapınız.");
            break;
    }
} while (secim != 6);

Console.WriteLine("Toplam Hesap ="+ toplam);