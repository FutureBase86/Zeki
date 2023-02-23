namespace SifrePin_Puk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hazırlayan Sedat");
            Console.WriteLine("Şifre Kontrol Programı... ");

            int reelPin = 1144, reelPuk = 1122334455, pin, yeniPin, puk,
            pinBloke = 3, pukBloke = 10, onayKodu = 0,
            musteriTemsilcisiOnayKodu = 0123456789;

            Console.Write("Lütfen Pin Kodunu Girin : ");
            pin = Convert.ToInt32(Console.ReadLine());

            while (pin != reelPin)
            {

                for (int i = 2; i <= pinBloke; i++)
                {
                    Console.Write("Lütfen Pin Kodunu Girin : ");
                    pin = Convert.ToInt32(Console.ReadLine());

                    if (pin == reelPin) break;

                    if (i == pinBloke)
                    {
                        Console.WriteLine("Pin Kodunuz Bloke Oldu...");
                        for (int j = 1; j <= pukBloke; j++)
                        {
                            Console.Write("Lütfen Puk Kodunu Girin : ");
                            puk = Convert.ToInt32(Console.ReadLine());

                            if (j >= 10)
                            {
                                Console.WriteLine("Puk Kodunuz Bloke OLdu...\nLütfen Müşteri Hizmetleri İle İletişime Geçiniz.");
                                Console.Write("Müşteri Temsilcisi Onay Kodu : ");
                                onayKodu = Convert.ToInt32(Console.ReadLine());
                                if (onayKodu != musteriTemsilcisiOnayKodu)
                                {
                                    Console.WriteLine("Sistem Kilitlendi...");
                                    break;
                                }
                            }
                            if (puk == reelPuk || onayKodu == musteriTemsilcisiOnayKodu)
                            {
                                reelPin = 1144;
                                Console.Write("Yeni pin Giriniz : ");
                                reelPin = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                        }
                    }
                }
                break;
            }
            Console.WriteLine("Açılıyor...");
        }
    }
}
