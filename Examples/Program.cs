namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------ if parola kontrol------------------------------------ -

            //string parola = Console.ReadLine();
            //if (parola == "1234")
            //{
            //    Console.WriteLine("Parola doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen parola doğru değil");
            //}

            ////------------------------- Kullanıcı adı ve parola kontrol----------------------------------

            //string kullaniciAdi = Console.ReadLine();
            //string parola1 = Console.ReadLine();
            //if (kullaniciAdi == "admin" && parola1 == "1234")
            //{
            //    Console.WriteLine("Kullanıcı Adı ve Parola Doğru");
            //}
            //else
            //{
            //    Console.WriteLine(" Kullanıcı Adı ve Parola Yanlış!");
            //}

            ////------------------------- İç içe yapı Kullanıcı adı ve parola kontrol----------------------------

            //string kullaniciAdi1 = Console.ReadLine();
            //string parola3 = Console.ReadLine();
            //if (kullaniciAdi1 == "admin")
            //{
            //    if (parola3 == "123456")
            //    {
            //        Console.WriteLine("Kullanıcı Adı ve Parola Doğru");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girilen Parola Doğru Değil!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Kullanıcı Adı Doğru Değil!");
            //}

            ////----------------------------Sayı çift mi?-----------------------------------

            //Console.WriteLine("Bir sayı giriniz:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Girilen Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı Çift DEĞİLDİR");
            //}

            ////----------------------- büyük sayıyı bulma-------------------------------------

            //int sayi1, sayi2;
            //Console.Write("Birinci sayıyı girin.");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı girin.");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //    Console.WriteLine("1. sayı olan {0} daha büyük.", sayi1);
            //else
            //    Console.WriteLine("2. sayı olan {0} daha büyük.", sayi2);
            ////Çalışma hatasını bulun?
            //Console.ReadKey();

            ////--------------- Basit Hesap Makinesi--------------------------------------------

            //int sayiA, sayiB, sonuc;
            //byte islem; //Neden byte tanımladık ?
            //Console.Write("Birinci sayıyı girin."); //Write ve WriteLine farkına dikkat edin.
            //sayiA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı girin.");
            //sayiB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı girin.");
            //Console.WriteLine("Yapılacak olan işlemi seçin.");
            //islem = Convert.ToByte(Console.ReadLine());
            //if (islem == 1)
            //{
            //    sonuc = sayiA + sayiB;
            //    Console.WriteLine("İşlem sonucu={0}.", sonuc);
            //    //"{0}" kullanımına dikkat;
            //}
            //else if (islem == 2)
            //{
            //    sonuc = sayiA - sayiB;
            //    Console.WriteLine("İşlem sonucu={0}.", sonuc);
            //    //"{0}" kullanımına dikkat;
            //}
            //else if (islem == 3)
            //{
            //    sonuc = sayiA * sayiB;
            //    Console.WriteLine("İşlem sonucu={0}.", sonuc);
            //}
            //else if (islem == 4)
            //{
            //    sonuc = sayiA / sayiB;
            //    Console.WriteLine("İşlem sonucu={0}.", sonuc);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı değer girdiniz. ");
            //}

            //// ------------------------- Alışveriş tutarına göre İndirim --------------------------------

            //int alisverisTutari, indirimliAlisveriTutari;
            //byte indirimOrani = 0; //Neden 0 tanımladık ?
            //Console.Write("Alışveriş tutarını girin.");
            //alisverisTutari = Convert.ToInt32(Console.ReadLine());
            //if (alisverisTutari <= 200)
            //    indirimOrani = 10;
            //else if (alisverisTutari <= 400)
            //    indirimOrani = 15;
            //else if (alisverisTutari > 400)
            //    indirimOrani = 20;
            //indirimliAlisveriTutari = alisverisTutari - alisverisTutari * indirimOrani / 100;
            //Console.Write("Alışveriş tutarınız={0} ve indirim oranınız= {1}, indirimli alışveriş tutarınız ={2} ", alisverisTutari, indirimOrani, indirimliAlisveriTutari);
            //Console.ReadLine();


            ////-------------------------------- Otopark Ücret Hesaplama ----------------------------------------

            //int parkSaati = 0; int ucret = 0;
            //Console.Write("Park süresini girin.");
            //parkSaati = Convert.ToInt32(Console.ReadLine());
            //if (parkSaati < 3)
            //    ucret = parkSaati * 4;
            //else if (parkSaati > 3 && parkSaati < 7)
            //    ucret = parkSaati * 3;
            //else if (parkSaati >= 7 && parkSaati < 12)
            //    ucret = parkSaati * 2;
            //else if (parkSaati >= 12)
            //    ucret = parkSaati * 1;
            //Console.Write("Ödenecek Toplam Park Ücreti = {0}.", ucret);

            //// -------------------------------- Kare - Dikdörtgen -- Alan - Çevre -------------------------------

            //string kareDikdortgen = "", alanCevre = "";
            //int ax, b, cevre, alan;
            //Console.WriteLine("1- Kare");
            //Console.WriteLine("2- Diktörtgen");
            //Console.Write("Seçiminiz (1-2) : ");
            //kareDikdortgen = Console.ReadLine();
            //if (kareDikdortgen == "1")
            //{
            //    Console.WriteLine("1- Alan");
            //    Console.WriteLine("2- Çevre");
            //    Console.Write("Seçiminiz (1-2) : ");
            //    alanCevre = Console.ReadLine();
            //    if (alanCevre == "1")
            //    {
            //        Console.Write("Kenarı giriniz = ");
            //        ax = int.Parse(Console.ReadLine());
            //        alan = ax * ax;
            //        Console.WriteLine("Alan = {0}", alan);
            //    }
            //    if (alanCevre == "2")
            //    {
            //        Console.Write("Kenarı giriniz = ");
            //        ax = int.Parse(Console.ReadLine());
            //        cevre = 4 * ax;
            //        Console.WriteLine("Çevre={0}", cevre);
            //    }
            //}

            //if (kareDikdortgen == "2")
            //{
            //    Console.WriteLine("1- Alan");
            //    Console.WriteLine("2- Çevre");
            //    Console.Write("Seçiminiz (1-2) : ");
            //    alanCevre = Console.ReadLine();
            //    if (alanCevre == "1")
            //    {
            //        Console.Write("Uzun kenarı giriniz = ");
            //        ax = int.Parse(Console.ReadLine());
            //        Console.Write("Kısa kenarı giriniz = ");
            //        b = int.Parse(Console.ReadLine());
            //        alan = ax * b;
            //        Console.WriteLine("Alan = {0}", alan);
            //    }
            //    if (alanCevre == "2")
            //    {
            //        Console.Write("Uzun kenarı giriniz = ");
            //        ax = int.Parse(Console.ReadLine());
            //        Console.Write("Kısa kenarı giriniz = ");
            //        b = int.Parse(Console.ReadLine());
            //        cevre = 2 * (ax + b);
            //        Console.WriteLine("Çevre = {0}", cevre);
            //    }
            //}


            //// -------------------------------- FOR 1 den 100 e toplam --------------------------------
            //int toplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);


            //// -------------------------------- WHİLE 1 den 100 e toplam --------------------------------

            //int toplam2 = 0;
            //int iX = 0;
            //while (iX < 100)
            //{
            //    toplam2 += iX;
            //    iX++;
            //}
            //Console.WriteLine(toplam2);

            // -------------------------------- SAYINIZ X BASAMAKLIDIR--------------------------------

            //int sayiX = Convert.ToInt32(Console.ReadLine());
            //int basamak = 0;
            //while (sayiX > 0)
            //{
            //    basamak++;
            //    sayiX = sayiX / 10;
            //}
            //Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + "basamaklıdır.");

            // -------------------------------- SAYINIZ X BASAMAKLIDIR--------------------------------

            //int toplamA = 0;
            //int sayac = 0;
            //do
            //{
            //    sayac++;
            //    toplamA += sayac;
            //}
            //while (sayac < 100);
            //Console.WriteLine("Toplam: " + toplamA.ToString()
            //+ ",Sayaç: " + sayac.ToString());


            // -------------------------------- FOR EACH DİZZİDEKİ SAYILAR ÇARPIM --------------------------------

            //int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            //int carpim = 1;
            //foreach (int x in sayilar)
            //{
            //    carpim = carpim * x;
            //    Console.WriteLine(carpim);  
            //}

            // --------------------------------- 7 DEN 200 E SAYILAR TOPLAMI------------------------------

            //int toplamM = 0;
            //for (int i = 7; i <= 200; i++)
            //{
            //    toplamM += i;
            //}
            ////Console.WriteLine("Toplam = {0}", toplam);
            //Console.WriteLine("Toplam = " + toplamM);



            // ----------------------- GİRİLEN İKİ SAYI ARASINDAKİ SAYILAR TOPLAMI-----------------------------

            //int toplam = 0, a, b;
            //Console.WriteLine("bir sayi girin");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("bir sayi girin");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    int gecici = a;
            //    a = b;
            //    b = gecici;
            //}
            //for (int i = a; i <= b; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Toplam = " + toplam);

            //--------------------------------------- SAYI TAHMİN----------------------------------------------

            //Console.WriteLine("0 ile 100 arasında bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int defa = 0; Random rnd = new Random();
            //int aklimdakiSayi = rnd.Next(0, 100);
            //do
            //{
            //    defa++;
            //    if (sayi > aklimdakiSayi)
            //    {
            //        Console.WriteLine("Daha küçük sayı girin");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (sayi < aklimdakiSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir girin");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //    }
            //} while (sayi != aklimdakiSayi);
            //Console.WriteLine("Tebrikler. Sayıyı {0}. Defa da buldunuz.", defa);

            //---------------- ÜÇ BOYUTLU DİZİ YAZDIRMA--------------------------

            //int[,,] dizi = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine(dizi[i, j, k]);
            //        }
            //    }
            //}
            //Console.ReadLine();


            // --------------------------- EN KÜÇÜK ELEMAN ----------------------------------------

            //int[,] dizi = { { 12, 8, 9, 6 }, { 5, 3, 9, -4 }, { 4, 7, 8, -11 } };
            //int min = dizi[0, 0];
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        if (dizi[i, j] < min)
            //        {
            //            min = dizi[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Minimum eleman: " + min);
            //Console.ReadLine();




        }
    }

}