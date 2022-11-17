using ConsoleApp2;
using IComparable_;
using System.Collections;

ArrayList liste1 = new ArrayList() { 45, 33, 66, 63, 12, 88, 5 };
ArrayList liste2 = new ArrayList() { "Yozgat", "Ankara", "Bursa", "Adana", "Bolu" };

ArrayList liste3 = new ArrayList {
    new Kitap { KitapID = 1, KitapAdı = "İki şehrin hikayesi", Fiyat = 37 },   //new Kitap nesnedir
    new Kitap { KitapID = 5, KitapAdı = "Denemeler", Fiyat = 41 },
    new Kitap { KitapID = 3, KitapAdı = "Büyük Umutlar", Fiyat = 83 }
};

liste1.Sort();
foreach (int item in liste1)
{
    Console.WriteLine(item);
}

liste2.Sort();
foreach (string item in liste2)
{
    Console.WriteLine(item);
}

liste3.Sort();
foreach (Kitap item in liste3)
{
    Console.WriteLine(item.KitapID + " " + item.KitapAdı + " " + item.Fiyat);
}