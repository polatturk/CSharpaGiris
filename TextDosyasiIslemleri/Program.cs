namespace TextDosyasiIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string dosyaYolu = "D:\\test\\ogrenciler.txt";
            //text dosyasına veri yazmak için
            // StreamWriter writer = new StreamWriter("D:\\test\\deneme.txt", true);
            //   Yaz(dosyaYolu, "askdjhaksdhjas");


            // writer.WriteLine(metin);
            //  writer.Close();

            // Console.WriteLine("\\t");

            //text dosyasından veri okumak için
            //StreamReader reader = new StreamReader("D:\\test\\deneme.txt");
            //string satir = reader.ReadLine();



            //while(satir!=null)
            //{
            //    Console.WriteLine(satir);
            //    satir = reader.ReadLine();

            //}
            //Kullanıcıya bir öğrenci adı giriniz diye soralım ancak bunu sonsuz dongu içerisinde yapalım. Kullanıcı öğrenci ismi yazıp enter'a bastıkca bunu bir text dosyası içerisine kaydetsin.
            //bir tane Yaz isminde method olusturalım.  Bu metodun geri donus degeri OLMASIN, dışarıdan da içerisine bir tane dosya yolu "dosya", "path" bir tane de metin alsın. Sonra bu method kendi içinde ilgili dosya yolundaki dosyayı streawriterla append modunda açsın, ve gelen metni ona eklesin.

            while (true)
            {

                string ogrenci = "";
                while (ogrenci == "")
                {
                    Console.WriteLine("Öğrenci adı giriniz : ");
                    ogrenci = Console.ReadLine();
                }

                Console.WriteLine("Öğrencinin numarasını giriniz : ");
                ogrenci += " " + Console.ReadLine();
                Yaz(dosyaYolu, ogrenci);

            }




        }
        static void Yaz(string dosyaYolu, string metin)
        {
            StreamWriter writer = new StreamWriter(dosyaYolu, true);
            writer.WriteLine(metin);
            writer.Close();

        }

    }
}