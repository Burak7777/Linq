using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


class ABC
{
{

    static void Main()
    {
        IEnumerable<int> result = ((ParallelQuery<int>)ParallelEnumerable.Range(3, 20))
        .Where(n => n % 5 == 0).Select(result => result);
        Console.WriteLine("Sayılar : ");
        foreach (int sayilar in result)
        {
            Console.WriteLine(sayilar);
        }
    }
}

static void Main()
{
    IEnumerable<int> veri = ((ParallelQuery<int>)ParallelEnumerable.Range(10, 30))
        .Where(i => i % 2 == 0).Select(deger => deger);
    foreach (int cift in veri)
    {
        Console.WriteLine(cift);
    }

}
}

    static void Main()
{
    IEnumerable<int> veri = ((ParallelQuery<int>)(ParallelEnumerable.Range(4, 50))
        .Where(i => i % 2 == 1).Select(deger => deger));
    foreach (int tek in veri)
    {
        Console.WriteLine(tek);
    }
}
}

    static void Main()
{
    int[] Yas = { 27, 24, 22, 24, 25, 27, 20, 23, 24, 22, 23, 26, 31 };
    int toplam = Yas.Sum();
    int ort = toplam / Yas.Length;

    var oay = from yaslar in Yas where yaslar < ort select yaslar;
    Console.WriteLine("Ortalama yaslar: " + ort);
    Console.WriteLine("Ortalamanın altında kalan yaslar: ");
    foreach (int i in oay)
    {
        Console.WriteLine(i + " ");
    }
    Console.WriteLine();
}
}


static void Main()
{
    string[] isim = { "Burak", "Enes", "Yunus", "Tarık", "Özlem", "Berfin", "Mira", };
    var a = from isimler in isim where isimler.Length > 4 select isimler;
    foreach (var Isim in a)
    {
        Console.WriteLine(Isim);
    }

    Console.WriteLine();
}
}

class ABC
{

    static void Main()
    {
        string[] isim = { "Burak", "Yunus", "Tarık", "Enes", "Caner" };
        var a = from isimler in isim where isimler.Contains("r") select isimler;
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}



public class Calisanlar
{
    public int cal_id
    {
        get; set;
    }
    public string cal_ad
    {
        get; set;
    }
    public string cal_cinsiyet
    {
        get; set;
    }
    public int cal_is_tarihi
    {
        get; set;
    }
    public int cal_maas
    {
        get; set;
    }

    public class ABC
    {
        static public void Main()
        {
            ArrayList liste = new ArrayList();

            liste.Add("BURAK PAZARLAMA");
            liste.Add(3);
            liste.Add(new Calisanlar() { cal_id = 201, cal_ad = "Burak", cal_maas = 50000, cal_cinsiyet = "Erkek", cal_is_tarihi = 2023 });
            liste.Add(new Calisanlar() { cal_id = 202, cal_ad = "Enes", cal_maas = 12000, cal_cinsiyet = "Erkek", cal_is_tarihi = 2023 });
            liste.Add(new Calisanlar() { cal_id = 203, cal_ad = "Berfin", cal_maas = 20000, cal_cinsiyet = "Erkek", cal_is_tarihi = 2023 });
            liste.Add(new Calisanlar() { cal_id = 201, cal_ad = "Mira", cal_maas = 28000, cal_cinsiyet = "Erkek", cal_is_tarihi = 2023 });


            var xyz = from x1 in liste.OfType<string>()
                      select x1;
            foreach (var asd in xyz)
            {
                Console.WriteLine(asd);
            }

            var xyz2 = from x2 in liste.OfType<Calisanlar>()
                       select x2;
            foreach (var asd2 in xyz2)
            {
                Console.WriteLine(asd2.cal_ad);
            }

            var xyz3 = from x3 in liste.OfType<Calisanlar>()
                       select x3;
            foreach (var asd3 in xyz3)
            {
                Console.WriteLine(asd3.cal_maas);
            }

        }
    }
}






