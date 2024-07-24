using Business.Concrete;
using Entities.Concrete;

namespace C_5_saatlik_kamp
{
    internal class Program
    {
        static void Main(string[] args)




        {

            Vatandas vatandas1 = new Vatandas();
            SelamVer("ali");
            SelamVer("ahmet");
            SelamVer("emre");
            SelamVer();


            string ogrenci1 = "ali";
            string ogrenci2 = "ahmet";
            string ogrenci3 = "aydın";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "ali";
            ogrenciler[1] = "ahmet";
            ogrenciler[2] = "aydın";

            ogrenciler = new string[4];
            ogrenciler[3] = "aydın";

            for (int i = 0; i < ogrenciler.Length; i++)
            {

                Console.WriteLine(ogrenciler[i]);


            }


            string[] sehirler1 = new[] { "Ankara,istanbul,çankırı" };
            string[] sehirler2 = new[] { "bolu,izmir,izmit" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Mustafa ";
            person1.LastName = "Öz";
            person1.DateOfBirthYear = 1940;
            person1.NationalIdentity = 9;

            Person person2 = new Person();
            person2.FirstName = "aydın";


            foreach (string sehir in sehirler1)


            {

                Console.WriteLine(sehir);

            }
            List<string> yenisehirler1 = new List<string> { "a1", "b1", "c1" };
            yenisehirler1.Add("s1");

            foreach (var sehir in yenisehirler1)
            {

                Console.WriteLine(sehir);



            }
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


























            int sonuc = Topla(6,58);



            Console.ReadLine();

        }
        




        //resharper

        static void SelamVer(string isim="isimsiz") // yapılan isimsiz parametresine default parametre deniyor
        {
            Console.WriteLine("Merhaba " + isim);
        }


        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc .ToString() );
            return  sonuc;

        }

        string Ad = "Mahmut";
        string Soyad = "Demir";
        string Dogumyili = "15.08.1994";
        long TcNo = 56156151851;

        // pascal casing kelimenin ilk harfi büyük 
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Dogumyili { get; set; }
            public long TcNo { get; set; }




        }
    }
}

