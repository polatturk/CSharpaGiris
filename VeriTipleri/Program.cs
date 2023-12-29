namespace VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En çok kullanılan veri tiplerinden biri olan INTeger, yani tam sayıların alabileceği Maximum değer 2.147.483.647'dir. Bu maximum değeri int.MaxValue ile görebiliriz. Aynı şekilde alabileceği en düşük değeri de int.MinValue ile görebiliriz.

            //= operatörü ile değişkenlere değer ataması yapabiliriz. Örneğin:
            //int sayi1 = 5;
            //int sayi2=6;
            //sayi1 = sayi1 + 5;
            //sayi1 += 5;
            //= operatörü sağ tarafındaki değeri sol tarafındaki değişkene atar.

            //string veri tipi ile metinsel ifadeleri tutabiliriz. Metinsel ifadeleri çift tırnak içerisinde yazmamız gerekmektedir. Örneğin:
            //	string metin = "Merhaba Dünya";
            //string veri tipi ile birlikte + operatörünü kullanarak metinsel ifadeleri birleştirebiliriz. Örneğin:
            //	string ad = "Mehmet";
            //	string soyad = "Kaya";
            //string bosluk = " ";
            //string adSoyad = ad + " " + soyad;
            //CONCAT-ENATION
            //	Console.WriteLine("Merhaba  : "+ad + " " + soyad);

            //Bu kullanımın adı interpolation olarak geçmektedir. Bu kullanım ile değişkenleri süslü parantez içerisinde kullanabiliriz. Örneğin:
            //	Console.WriteLine($"Merhaba  : {ad} {soyad}");

            //Kullanıcıya adını ve soyadını ayrı ayrı soralım ve ardından ekrana "Hoşgeldin Ad Soyad" formatında yazdıralım.
            //Console.WriteLine("Adınızı giriniz : ");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı giriniz : ");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Hoşgeldin {ad} {soyad}");

            //Console.WriteLine($"Adınız soyadınız toplam {ad.Length + soyad.Length} karakter uzunlugundadir");

            //char karakter = (char)255;
            //stringler aslında characterlerden oluşan bir dizidir. Örneğin:
            //
            //	string ad = "emre";
            //4 tane karakterden oluşan bir dizi oluşturmuş gibi oluyoruz. Bu dizinin elemanlarına erişmek için dizi elemanlarına erişir gibi erişebiliriz. Örneğin:

            //	Console.WriteLine(ad[0]);

            //	byte sayi = 255;
            //maximum 255 değeri alabilen yapısal olarak int'ten farkı olmayan bir veri tipidir.
            //bool x = 1 == 1;


            //Console.WriteLine(x);
            //Console.WriteLine("Doğum yılınızı giriniz : ");
            //int yil = int.Parse(Console.ReadLine());

            //int bugununYili = DateTime.Now.Day;
            //Console.WriteLine($"Yaşınız {bugununYili-yil}");

            //Console.WriteLine("Doğum yılınızı giriniz : ");
            //int yil = int.Parse(Console.ReadLine());
            //Console.WriteLine("Doğum ayınızı giriniz : ");
            //int ay = int.Parse(Console.ReadLine());
            //Console.WriteLine("Doğum gününüzü giriniz : ");
            //int gun = int.Parse(Console.ReadLine());

            //DateTime dogumTarihi = new DateTime(yil, ay, gun);

            //  TimeSpan fark= DateTime.Now- dogumTarihi;
            //Console.WriteLine($"Dogdugunuzdan beri {fark.Days} gün geçmiş");
            ////float gunler = float.Parse(fark.Days.ToString());
            //Console.WriteLine($"Gerçek yaşınız {fark.Days*1.0 / 365}");


            //string meyveler= "elma,armut,kiraz,çilek";
            //string[] meyveDizisi=new string[4];
            //meyveDizisi[0] = "elma";
            //meyveDizisi[1] = "armut";
            //meyveDizisi[2] = "kiraz";
            //meyveDizisi[3] = "çilek";
            //string[] yeniMeyveDizisi = {"elma", "armut", "kiraz", "çilek" };


            //string adSoyad = "Mehmet Kaya";
            //Console.WriteLine(adSoyad.ToUpper());
            //Console.WriteLine(adSoyad.ToLower());

            //	char karakter = (char)97; //küçük a
            //	char buyukKarakter = (char)65; //büyük A
            //Console.WriteLine("Bir yazı giriniz : ");
            //	string metin = Console.ReadLine();
            //	char[] chars = metin.ToCharArray();

            //int sayac = 0;
            //foreach (char karakter in chars)
            //{

            //	byte asciiKodu = (byte)karakter;
            //	asciiKodu -= 32;
            //	chars[sayac] = (char)asciiKodu;
            //	sayac++;
            //	//sayac=sayac+1;
            //	//sayac+=1;

            //}

            //for(int i=0; i<chars.Length; i++)
            //{
            //	byte asciiKodu = (byte)chars[i];
            //	asciiKodu -= 32;
            //	chars[i] = (char)asciiKodu;
            //}

            //int sayac = 0;
            //while(sayac<chars.Length)
            //{
            //	byte asciiKodu = (byte)chars[sayac];
            //	asciiKodu -= 32;
            //	chars[sayac] = (char)asciiKodu;
            //	sayac++;

            //}
            //sayac = 0;
            //do
            //{
            //	byte asciiKodu = (byte)chars[sayac];
            //	asciiKodu -= 32;
            //	chars[sayac] = (char)asciiKodu;
            //	sayac++;
            //} while (sayac < chars.Length);


            int a = 7;
            int b = 6;

            //if(a<b)
            //{
            //	//true ise bu kısım çalışır
            //	Console.WriteLine("a küçüktür b'den");
            //}
            //else
            //{
            //	//false olması durumunda burası çalışır
            //	Console.WriteLine("a büyüktür b'den");
            //}

            //if(a<b)
            //{
            //	Console.WriteLine("a küçüktür b'den");
            //}
            //else if(a==b)
            //{
            //	Console.WriteLine("a eşittir b'ye");
            //}
            //else
            //{
            //	Console.WriteLine("a büyüktür b'den");
            //}

            //int sayi1 = 0;
            //int sayi2 = 0;
            //int sayi3 = 0;
            //int enBuyukSayi = 0;


            //Console.WriteLine("1. sayıyı giriniz : ");
            //sayi1 = int.Parse(Console.ReadLine());
            //enBuyukSayi = sayi1;


            //Console.WriteLine("2. sayıyı giriniz : ");
            //sayi2 = int.Parse(Console.ReadLine());

            //if(sayi2>enBuyukSayi)
            //{
            //	enBuyukSayi = sayi2;
            //}


            //Console.WriteLine("3. sayıyı giriniz : ");
            //sayi3 = int.Parse(Console.ReadLine());
            //if(sayi3>enBuyukSayi)
            //{
            //	enBuyukSayi = sayi3;
            //}

        }

    }
}