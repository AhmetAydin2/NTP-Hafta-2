Console.WriteLine("Hello, World!");

//Week2

//Girilen sayının çift-tek kontrolü (if)

Console.WriteLine("Sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine("Çift sayı girdiniz");
}
else
{
    Console.WriteLine("Tek sayı girdiniz");
}
Console.ReadKey();

//1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma

int sayı;
Console.WriteLine("1 ile 10 arasında bir sayı giriniz");
sayı = int.Parse(Console.ReadLine());

switch (sayı)
{
    case 1:
        Console.WriteLine("Bir");
        break;

    case 2:
        Console.WriteLine("İki");
        break;

    case 3:
        Console.WriteLine("Üç");
        break;

    case 4:
        Console.WriteLine("Dört");
        break;

    case 5:
        Console.WriteLine("Beş");
        break;

    case 6:
        Console.WriteLine("Altı");
        break;

    case 7:
        Console.WriteLine("Yedi");
        break;

    case 8:
        Console.WriteLine("Sekiz");
        break;

    case 9:
        Console.WriteLine("Dokuz");
        break;

    case 10:
        Console.WriteLine("On");
        break;
    default:
        Console.WriteLine("1 ile 10 arasında bir sayı giriniz");
        break;
}



//Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarı değilse başarısız uyarısı veren


Console.WriteLine("Kullanıcı adınızı giriniz");
string nickname =Console.ReadLine();
Console.WriteLine("Şifrenizi giriniz");
string password =Console.ReadLine();    
if (nickname == "admin" && password == "Admin_32453@"){
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("BAŞARISIZ GİRİŞ");
}
Console.ReadLine();

//10-20 20-30 30-40 arası sıcaklık durumlarına göre ekrana (normal-sıcak-çok sıcak) uyarısı veren 

Console.WriteLine("Sıcaklık değerini giriniz");
int temp=int.Parse(Console.ReadLine());

if (temp < 20)
{
    Console.WriteLine("Normal");
}
else if (temp > 30)
{
    Console.WriteLine("Çok sıcak");
}
else
{
    Console.WriteLine("Sıcak");

}
Console.ReadLine();

