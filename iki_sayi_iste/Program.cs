using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan ilk sayıyı girmesini isteyin ve değeri bir tamsayıya dönüştürün.
        Console.Write("İlk sayıyı girin: ");
        int ilkSayi = Convert.ToInt32(Console.ReadLine());

        // Kullanıcıdan ikinci sayıyı girmesini isteyin ve değeri bir tamsayıya dönüştürün.
        Console.Write("İkinci sayıyı girin: ");
        int ikinciSayi = Convert.ToInt32(Console.ReadLine());

        // Kullanıcıdan hangi türdeki sayıların toplanmasını istediğini girmesini isteyin.
        Console.Write("Tekler mi çiftler mi toplansın? (tek/cift): ");
        string tur = Console.ReadLine().ToLower();

        // Toplam değişkenini tanımlayın ve başlangıçta sıfıra ayarlayın.
        int toplam = 0;

        // İlk sayıdan başlayarak ikinci sayıya kadar olan sayıları kontrol edin.
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            // Kullanıcı "tek" istediğinde tek sayıları topla.
            if (tur == "tek" && i % 2 != 0)
                toplam += i;
            // Kullanıcı "cift" istediğinde çift sayıları topla.
            else if (tur == "cift" && i % 2 == 0)
                toplam += i;
        }

        // Sonucu ekrana yazdırın.
        Console.WriteLine($"{ilkSayi} ile {ikinciSayi} arasındaki {tur} sayıların toplamı: {toplam}");
    }
}
