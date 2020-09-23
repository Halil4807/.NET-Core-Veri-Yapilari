using System;
using System.Globalization;

namespace consoleapp
{
    class Program
    {
        private static IFormatProvider culture;

        static void Main(string[] args)
        {
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            DateTime simdi = DateTime.Now;
            // Şimdiki zamanı sistemden çeker.
            Console.WriteLine(simdi);

            Console.WriteLine(simdi.Year);
            Console.Write(simdi.Month + "  ");
            Console.WriteLine(aylar[simdi.Month - 1]);
            Console.WriteLine(simdi.Day);
            Console.WriteLine(simdi.DayOfWeek);
            Console.WriteLine(simdi.Hour);
            Console.WriteLine(simdi.Minute);
            Console.WriteLine(simdi.Second);

            DateTime dt = new DateTime(1996, 06, 11, 12, 23, 23);
            // Tarih atama

            Console.WriteLine(dt);
            Console.WriteLine(dt.AddDays(2));
            // dt'ye 2 gün ekleyip ekrana yazdırma

            Console.WriteLine(dt.AddHours(2));
            // dt'ye 2 ay ekleyip ekrana yazdırma

            Console.WriteLine(dt.AddYears(2));
            // dt'ye 2 yıl ekleyip ekrana yazdırma

            Console.WriteLine(dt.AddMonths(-2));
            // dt'ye 2 ay çıkarma ekrana yazdırma

            var fark = simdi - dt;
            // 2 tarih arasındaki fark

            Console.WriteLine(fark.TotalDays);
            // 2 tarih arasındaki günü yazdırır

            Console.WriteLine(simdi); // 23.09.2020 22:14:23
            Console.WriteLine(simdi.ToString("d")); // 23.09.2020
            Console.WriteLine(simdi.ToString("D")); // 23 Eylül 2020 Çarşamba
            Console.WriteLine(simdi.ToString("F")); // 23 Eylül 2020 Çarşamba 22:14:23
            Console.WriteLine(simdi.ToString("M")); // 23 Eylül
            Console.WriteLine(simdi.ToString("t")); // 22:14
            Console.WriteLine(simdi.ToString("T")); // 22:14:23
            Console.WriteLine(simdi.ToString("Y")); // Eylül 2020

            Console.WriteLine(simdi.ToString("hh:mm:ss")); // 10:18:12
            Console.WriteLine(simdi.ToString("hhmm-ss")); // 10-18-12
            Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy")); // Çar Eyl 23, 2020

            CultureInfo culture = new CultureInfo("en"); // fr vb.
            Console.WriteLine(simdi.ToString("F", culture)); // Wednesday, September 23, 2020 10:27:21 PM





            /*
            String[] isimler = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" };
            int[] numaralar = { 5, 3, 9, 1, 2 };

            // isimler[0] = "Ali";
            isimler.SetValue("Ali", 0);
            //Ali değerini 0.index'e atarma yapar

            Console.WriteLine(isimler.GetValue(0));
            Console.WriteLine(isimler[0]);
            // isimler dizininin 0. elemanını ekrana yazdırma

            Console.WriteLine(Array.IndexOf(isimler, "Çınar"));
            // Çınar'ın isimler dizininin kaçınce elemanı olduğunu ekrana yazdırma

            Console.WriteLine(isimler.Length);
            // isimler dizininde kaç eleman olduğunu ekrana yazdırma

            Array.Sort(isimler);
            //isimler dizinini alfabetik olarak sıralar

            Array.Reverse(isimler);
            // isimler dizinini ters çevirir
            Array.Reverse(numaralar);
            // numaralar dizinini ters çevirir

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[^1]);
            // ^ ifadesi dizinin sonundan anlamına gelir. 
            // 0 ilk eleman iken ^1 en son eleman

            var result = isimler[1..4];
            // 1 dahil, 4 hariç arasındaki elemanları alır

            var result2 = isimler[1..];
            // 1 den sonraki elemanları alır

            var result3 = isimler[..4];
            // 4 e kadar elemanları alır. 4 hariç

            Array.Clear(isimler, 1, 2);
            // isimler dizininin 1. indexinden itibaren 2 elemanı silme
            // Silinen elemanın yeri null olur

            Array.Clear(numaralar, 1, 2);
            // numaralar dizininin 1. indexinden itibaren 2 elemanı silme
            // Silinen elemanın yeri 0 olur

            Console.WriteLine("");
            string msg = "Hello World!";
            Console.WriteLine(msg[0..5]);
            // 0'dan 5'e kadar olan karakterleri alır.
            // 'Hello'

            Console.WriteLine("");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }




            Console.WriteLine("");
            foreach (var numara in numaralar)
            {
                Console.WriteLine(numara);
            }


            Console.WriteLine("");
            foreach (var isim in result)
            {
                Console.WriteLine(isim);
            }


            
            // Console.Write("Name: ");
            // string name = Console.ReadLine();
            // Console.Write("Surname: ");
            // string surname = Console.ReadLine();
            // Console.Write("Age: ");
            // string age = Console.ReadLine();

            // Console.WriteLine( "My name is " + name + " " + surname+" and I'm "+age+" years old." );
            // Console.WriteLine( $"My name is {name} {surname} and I'm {age} years old." );
            // Console.WriteLine( string.Format("My name is {0} {1} and I'm {2} years old.",name,surname,age));
            
                        string msg = " Hello There. My name is Halil ÖZTÜRK. ";
                        Console.WriteLine(msg.Length);
                        // String'in uzunluğunu yazdırma

                        Console.WriteLine(msg.ToLower());
                        // Bütün string'i küçük harf yapıp yyazdırma

                        Console.WriteLine(msg.ToUpper());
                        // Bütün string'i BÜYÜK harf yapıp yazdırma

                        Console.WriteLine(msg.Trim());
                        // Baştaki ve sondaki boşlukları kaldırıp yzdırma

                        Console.WriteLine(msg.TrimStart());
                        // Baştaki boşlukları kaldırıp yazdırma

                        Console.WriteLine(msg.TrimEnd());
                        // Sondaki boşlukları kaldırıp yazdırma

                        Console.WriteLine(msg.Split()[5]);
                        //Boşluklardan bölünen 5. parçasını yazdırma

                        Console.WriteLine(msg[5]);
                        // İstenilen indexteki karakteri yazdırma

                        Console.WriteLine(msg.StartsWith(" Hello"));
                        //String Hello ile mi başlıyor sorusunun sonucunu yazdırma

                        Console.WriteLine(msg.StartsWith(" H"));
                        // String H ile mi başlıyor sorusunun sonucunu ekrana yazdırma

                        Console.WriteLine(msg.EndsWith("ÖZTÜRK. "));
                        // String H ile mi bitiyor sorusunun sonucunu ekrana yazdırma

                        Console.WriteLine(msg.EndsWith(". "));
                        // String H ile mi bitiyor sorusunun sonucunu ekrana yazdırma

                        Console.WriteLine(msg.EndsWith("!"));
                        // String H ile mi bitiyor sorusunun sonucunu ekrana yazdırma

                        Console.WriteLine(msg.Contains("Halil"));
                        // Stringin içerisinde 'Halil' bilgisi var mı sorusunun sonucunu yazdırma 

                        Console.WriteLine(msg.Contains("halil"));
                        // Stringin içerisinde 'halil' bilgisi var mı sorusunun sonucunu yazdırma 

                        Console.WriteLine(msg.IndexOf("name"));
                        // String'te 'name' in kaçıncı indexte olduğunu ekrana yazdırma

                        Console.WriteLine(msg.Substring(5));
                        // String'in 5. index'ten sonraki metni ekrana yazdırma

                        Console.WriteLine(msg.Substring(5, 10));
                        // String'in 5. index'ten sonraki 10 karakteri ekrana yazdırma

                        Console.WriteLine(msg.Substring(msg.IndexOf("name"), 10));
                        // String'in name'den sonra 10 karakteri ekrana yazdırma

                        Console.WriteLine(msg.Replace(" ", "-"));
                        // String'te bulununan ' ' karakterini '-' karakteri ile değiştirip ekrana yazdırma

                        Console.WriteLine(msg.Replace(" ", "-").Replace("@", "").ToLower());
                        // String'te bulununan ' ' karakterini '-' karakteri ile değiştirip 
                        // daha sonrada bulununan '@' karakterini kaldırıp 
                        // string'i küçük harfe çevirip ekrana yazdırma
                        // URL oluştururken kullanılabilir. (Türkçe karakterlerde değiştirilip)

                        Console.WriteLine(msg.Insert(0, "..."));
                        // String'i belirtilen index'ten sonra '...' ekleyip ekrana yazdırma

                        Console.WriteLine(msg.Insert(msg.Length, "..."));
                        // String'i sonuna '...' ekleyip ekrana yazdırma

                        Console.WriteLine(msg.Remove(5));
                        // String'in 5.indexten sonra metni silip ekrana yazdırma

                        Console.WriteLine(msg.Remove(6,10));
                        // String'in 5.indexten sonra metnin 10 karakterini silip ekrana yazdırma
            */

        }
    }
}
