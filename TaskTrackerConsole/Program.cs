Console.WriteLine("Görev başlığı giriniz!");
string gorev = Console.ReadLine()!;
Console.WriteLine("Önceliği belirleyiniz (1-3)");
int oncelik = Convert.ToInt32(Console.ReadLine());
string belirlenmisOncelik = "";
switch (oncelik)
{
    case 1:
        belirlenmisOncelik = "Yüksek";
        break;
    case 2:
        belirlenmisOncelik = "Orta";
        break;
    case 3:
        belirlenmisOncelik = "Düşük";
        break;
    default:
        belirlenmisOncelik = "Geçersiz öncelik";
        break;
}
Console.WriteLine($"{gorev} | {belirlenmisOncelik}");
