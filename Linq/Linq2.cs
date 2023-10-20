using System;
using System.Collections.Generic;
using System.Linq;


public class calisan
{
    public int cal_id { get; set; }
    public string cal_name { get; set; }
    public string cal_cinsiyet { get; set; }
    public string cal_year { get; set; }
    public int cal_maas { get; set; }




}

class abd
{
    static public void Main()
    {

        List<calisan> cal = new List<calisan>();
        {
            new calisan() { cal_id = 207, cal_name = "burak", cal_cinsiyet = "erkek", cal_year = "7", cal_maas = 35000 };
            new calisan() { cal_id = 202, cal_name = "enes", cal_cinsiyet = "erkek", cal_year = "6", cal_maas = 15000 };
            new calisan() { cal_id = 205, cal_name = "caner", cal_cinsiyet = "erkek", cal_year = "8", cal_maas = 45000 };
            new calisan() { cal_id = 209, cal_name = "yunus", cal_cinsiyet = "erkek", cal_year = "4", cal_maas = 25000 };
        }

        var x1 = from x in cal
                 where x.cal_id <= 207
                 where x.cal_maas < 35000
                 select x.cal_name;

        foreach (var item in x1)
        {
            Console.WriteLine(item);
        }

    }
}






