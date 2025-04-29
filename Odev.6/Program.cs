namespace Odev._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen sağlık durumunuzu giriniz(evet/hayır): ");
            string saglikDurumu = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Lütfen sabıkanız var mı giriniz (evet/hayır): ");
            string sabika = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("girdiğiniz bilgiler şunlardır:");
            Console.WriteLine($"YAŞ: {yas}");
            Console.WriteLine($"SAĞLIK DURUMU:{saglikDurumu}");
            Console.WriteLine($"SABIKA DURUMU: {sabika}");

            if(yas >= 18 && saglikDurumu == "evet" && sabika == "hayır")
            {
                Console.WriteLine("ehliyet almanız uygundur.");
            }
            else
            {
                Console.WriteLine("ehliyet alamazsınız");
            }



        }
    }
}
