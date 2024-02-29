using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mesaj = "Merahba";
            //double tutar = 10000;
            //int sayi = 100;
            //bool girisYapmisMi = false;
            //string ad = "Muhammet";
            //string soyAd = "Aydın";
            //int dogumYili = 1985;
            //long tcNo = 12345678910;

            //Console.WriteLine(tutar*1.18);

            //Console.WriteLine("Hello, World!");

            //Console.WriteLine(mesaj);
            //Console.WriteLine(tutar);//database den gelir
            //Console.ReadLine();

            Vatandas vatandas1 = new Vatandas();

            //SelamVer("muhammet");
            //SelamVer("Aydin");
            //SelamVer();   
            //int sonuc = Topla(3,6);


            string[] ogrenciler = new string[3];

            ogrenciler[0] = " Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {

                //Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demirog";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FatherName = "Murat";

            foreach (string sehir in sehirler1) {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler = new List<string> { "Ankara 1","İstanbul 1","İzmir 1"};
            yeniSehirler.Add("Adana 1");

            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba "+ isim);
        }
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Tpolam : " + sonuc);
            return sonuc;
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public int DogumYili {get; set;}

        public long TcNo { get; set;}

    }
}