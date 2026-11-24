Console.WriteLine("Görev başlığı giriniz!");
string gorev = Console.ReadLine()!;
while (string.IsNullOrWhiteSpace(gorev))
{
    System.Console.WriteLine("Lütfen Görev başlığı giriniz");
    gorev = Console.ReadLine()!;
}
Console.WriteLine("Önceliği belirleyiniz (1-3)");
int oncelik = Convert.ToInt32(Console.ReadLine());
while (oncelik < 1 || oncelik > 3)
{
    System.Console.WriteLine("Geçersiz öncelik, 1-3 arası giriniz");
    oncelik = Convert.ToInt32(Console.ReadLine());
}
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

}
Console.WriteLine($"{gorev} | {belirlenmisOncelik}");
