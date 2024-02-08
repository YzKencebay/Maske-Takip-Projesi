using Business.Concrete;
using Entities.Concrete;

SelamVer("Ziya");
SelamVer();

Topla(18, 34);

string ogrenci1 = "Ayşegül";
string ogrenci2 = "Metehan";
string ogrenci3 = "Turgut";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Ayşegül";
ogrenciler[1] = "Metehan";
ogrenciler[2] = "Turgut";

ogrenciler = new string[4];
ogrenci3 = "Tarık";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}


string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Edirne";
Console.WriteLine(sehirler2[0]);

int sayi1 = 18;
int sayi2 = 34;
sayi2 = sayi1;
sayi1 = 18;
Console.WriteLine(sayi2);

Person person1 = new Person { FirstName = "YUSUF ZİYA", LastName = "KENCEBAY", DateOfBirthYear = 2001, NationalIdentity = 123 };


foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine(); 


static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}


static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}

//MyListApp();

static void MyListApp()
{
    MyList<string> myList = new MyList<string>("Ayşegül", "Zeliha", "Ziya");//constructor ile gelen veriler

    myList.Add("Ziya");
    myList.AddRange("Ziya", "Ayaz", "İrem");
}

class MyList<T> //generic <> :
                //bu iki işaret arasına yazılan T herhangi bir isimde olabilir.
                //generic, biz oraya istediğimiz bir veri türünü verebiliriz string olabilir int olabilir class olabilir..vb
{

    //Params -> method parametresine verilen bir anahtar kelimedir.
    //bu anahtar kelime bir veri türünün tek bir eleman ile değilde birden fazla veri vermemizi sağlar.

    //cgeneric yapıda constructor ile params keyword sayesinde verilen veri tipinde verileri
    //foreach ile tek tek dönüp ekrana yazdırıyor. Basir bir MyList uygulaması.
    public MyList(params T[] items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    //constructor halinin method versiyonu.
    public void AddRange(params T[] items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void Add(T item)
    {
        Console.WriteLine(item);
    }
}



