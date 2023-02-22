namespace SifrePin_Puk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hazırlayan AlpayCa");
            Console.WriteLine("Şifre Kontrol Programı... ");

            int reelPin = 1144, reelPuk = 1122334455, pin, yeniPin, puk,
            pinBloke = 3, pukBloke = 10, onayKodu = 0,
            musteriTemsilcisiOnayKodu = 0123456789;

            Console.Write("Lütfen Pin Kodunu Girin : ");
            pin = Convert.ToInt32(Console.ReadLine());
        }
    }
}