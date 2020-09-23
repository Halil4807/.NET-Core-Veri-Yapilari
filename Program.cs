using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
