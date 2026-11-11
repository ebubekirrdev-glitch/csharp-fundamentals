/* 
Görevler:Kullanıcının 1000 TL bakiyesi olsun ve sınırsız para çekme işlemi yapsın.
Çekeceği tutar bakiyeden büyükse "Yetersiz bakiye" yazısı çıksın.
bakiyeye eşit veya küçükse kalan bakiyeyi göstersin.
q ile programdan çıksın
negatif sayı girilirse "geçersiz tutar" yazsın.
 */
int bakiye = 1000;
bool devamEtsin = true;

while (devamEtsin)
{
    Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz,Çıkış için q tuşuna basınız!");
    string girdi = Console.ReadLine()!;

    if (girdi == "q")
    {
        devamEtsin = false;
    }
    else
    {
        int cekilecekTutar = Convert.ToInt32(girdi);
        if (cekilecekTutar <= 0)
        {
            Console.WriteLine("Geçersiz tutar!");
        }
        else if (cekilecekTutar > bakiye)
        {
            Console.WriteLine("Yetersiz bakiye");
        }
        else
        {
            bakiye -= cekilecekTutar;
            Console.WriteLine($"Kalan bakiyeniz {bakiye} TL dir.");
        }
    }
}