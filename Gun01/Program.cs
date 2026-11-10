/* 

kullanıcıdan 0-100 arası not al.
50 ve üstüyse geçtin yazısını bas.
50 altındaysa kaldın yazısını bas.
0-100 dışındaysa geçersiz yazısını bas

 */
System.Console.WriteLine("Lütfen notunuzu giriniz!");
 int dersNotu=Convert.ToInt32(Console.ReadLine());
if(dersNotu < 0 || dersNotu > 100)
{
    System.Console.WriteLine("Geçersiz");
}
else if (dersNotu >= 50)
 {
    System.Console.WriteLine("Geçtin");   
 }else
{
    System.Console.WriteLine("Kaldın");
}

/*
Kullanıcıdan şifre iste,yanlışsa tekrar sor.
en fazla 3 deneme hakkı olsun.
doğruysa giriş başarılı yazsın ,3 kez yanlış giriş olursa hesap kilitlendi yazsın. 

 */
 
string sifre = "1234";
int sayac = 0;
bool girisYapildi = false;
while (sayac < 3 && girisYapildi == false)
{
    System.Console.WriteLine("Lütfen şifre giriniz");
    string girilenSifre = (Console.ReadLine()!);
    if (girilenSifre == sifre)
    {
        System.Console.WriteLine("Giriş başarılı");
        girisYapildi = true;
    }
    else
    {
        System.Console.WriteLine("Yanlış şifre");

    }
    sayac++;
}
if (!girisYapildi)
{
    System.Console.WriteLine("Hesap kilitlendi");
}
