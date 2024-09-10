int bakiye = 35000;
string[] diziUrunler = { "bilgisayar", "telefon", "klavye" };
int[] diziFiyatlar = { 10000, 5000, 1500 };
int toplamFiyat = 0;
double indirimliFiyat = 0;
char yesNo = 'e';


while (yesNo != 'h')
{
    Console.Write("\nÜrün almak ister misiniz? e/h: ");
    yesNo = Char.Parse(Console.ReadLine());

    if (yesNo == 'e')
    {
        Console.Write("Ne almak istediniz?: ");
        string alinanUrun = Console.ReadLine();

        Console.Write("Kaç adet almak istediniz?: ");
        int adet = int.Parse(Console.ReadLine());


        if (alinanUrun == diziUrunler[0])
        {
            toplamFiyat = diziFiyatlar[0] * adet;
        }
        else if (alinanUrun == diziUrunler[1])
        {
            toplamFiyat = diziFiyatlar[1] * adet;
        }
        else if (alinanUrun == diziUrunler[2])
        {
            toplamFiyat = diziFiyatlar[2] * adet;
        }
        else
        {
            Console.WriteLine("Tanımsız Değer...");
        }



        if (toplamFiyat > 20000 && toplamFiyat <= 30000)
        {
            indirimliFiyat = toplamFiyat - (toplamFiyat * 0.20);
            Console.Write("İndirimsiz Toplam Fiyat: " + toplamFiyat);
            Console.Write("\n%20 İndirimli Toplam Fiyat: " + indirimliFiyat);
        }
        else if (toplamFiyat > 30000 && toplamFiyat <= 35000)
        {
            indirimliFiyat = toplamFiyat - (toplamFiyat * 0.30);
            Console.Write("İndirimsiz Toplam Fiyat: " + toplamFiyat);
            Console.Write("\n%30 İndirimli Toplam Fiyat: " + indirimliFiyat);
        }
        else if (toplamFiyat > 35000)
        {
            Console.Write($"Toplam Fiyat Bakiyeyi Aşıyor: {toplamFiyat}");
            Console.Write("Yetersiz Bakiye");
        }
        else
        {
            Console.Write($"Toplam Fiyat: {toplamFiyat}");
        }

    }


}
Console.WriteLine("İyi Günler...");