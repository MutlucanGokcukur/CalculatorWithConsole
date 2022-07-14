using System;

namespace CalculatorWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama H1 = new Hesaplama();
            Console.WriteLine("******Hesap Makinesi Uygulamasına Hoşgeldiniz******");
            System.Threading.Thread.Sleep(2000);
            int yapılanİslemSayı = 0;
        bb:
            Console.Clear();

            Hesaplama.Menü();
            int yapılacakislem = Convert.ToInt32(Console.ReadLine());
            decimal sonuc = 0;
            if (yapılacakislem == 5 || yapılacakislem == 6)
            {
                Console.Write("İşlem Yapılacak Sayıyı Giriniz: ");
                int s1 = Convert.ToInt32(Console.ReadLine());
                switch (yapılacakislem)
                {
                    case 5:
                        yapılanİslemSayı++;
                        sonuc = H1.KareAl(s1);
                        H1.İslem(s1, s1, sonuc, "*");
                        break;
                    case 6:
                        yapılanİslemSayı++;
                        sonuc = H1.KokAl(s1);
                        Console.WriteLine("{0} * 1/2 = {1}", s1, sonuc);
                        break;
                }
            }
            else if (yapılacakislem == 1 || yapılacakislem == 2 || yapılacakislem == 3 || yapılacakislem == 4)
            {
                Console.Write("Birinci Sayıyı Giriniz: ");
                decimal s1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz: ");
                decimal s2 = Convert.ToDecimal(Console.ReadLine());
                switch (yapılacakislem)
                {

                    case 1:
                        yapılanİslemSayı++;
                        sonuc = H1.Toplama(s1, s2);
                        H1.İslem(s1, s2, sonuc, "+");
                        break;
                    case 2:
                        yapılanİslemSayı++;
                        sonuc = H1.Cıkarma(s1, s2);
                        H1.İslem(s1, s2, sonuc, "-");
                        break;
                    case 3:
                        yapılanİslemSayı++;
                        sonuc = H1.Carpma(s1, s2);
                        H1.İslem(s1, s2, sonuc, "*");
                        break;
                    case 4:
                        yapılanİslemSayı++;
                        sonuc = H1.Bolme(s1, s2);
                        H1.İslem(s1, s2, sonuc, "/");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz İşlem Numarası Girdiniz...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("İşlem Numarasını Tekrar Girmek İster Misiniz?(E/H)");
                string secim = Console.ReadLine();
                secim = secim.ToUpper();
                if (secim == "E")
                {
                    goto bb;
                }
                else
                {
                    Console.WriteLine("Uygulama Kapatılıyor");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            Console.Write("Tekrar İşlem Yapmak İster Misiniz?(E/H)");
            string secim2 = Console.ReadLine();
            secim2 = secim2.ToUpper();
            if (secim2 == "E")
            {
                goto bb;
            }
            else
            {
                Console.WriteLine("Uygulama Kapatılıyor\nYapılan İşlem Sayısı: {0}\nİyi Günler Dileriz....", yapılanİslemSayı);
                Environment.Exit(0);
            }
        }
    }

    public class Hesaplama
    {
        #region Menü
        public static void Menü()
        {
            Console.WriteLine("Uygulama İle Yapabileceğiniz İşlem Numaraları");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("5-Karesini Al");
            Console.WriteLine("6-Kökünü Al");
            Console.Write("İşlem Numaranızı Giriniz: ");
        }
        #endregion

        #region Toplama
        public decimal Toplama(decimal s1, decimal s2)
        {
            return s1 + s2;
        }
        #endregion

        #region Çıkarma
        public decimal Cıkarma(decimal s1, decimal s2)
        {
            return s1 - s2;
        }
        #endregion

        #region Carpma
        public decimal Carpma(decimal s1, decimal s2)
        {
            return s1 * s2;
        }
        #endregion

        #region Bolme
        public decimal Bolme(decimal s1, decimal s2)
        {
            return s1 / s2;
        }
        #endregion

        #region KareAl
        public decimal KareAl(decimal s1)
        {
            return s1 * s1;
        }
        #endregion

        #region Kokunu Al
        public decimal KokAl(double s1)
        {
            return Convert.ToDecimal(Math.Sqrt(s1));
        }
        #endregion

        #region İslemler
        public void İslem(decimal s1, decimal s2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", s1, operators, s2, sonuc);
        }
        #endregion
    }
}
