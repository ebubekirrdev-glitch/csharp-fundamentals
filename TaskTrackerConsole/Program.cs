Console.WriteLine("Görev başlığı giriniz!");
string gorev = Console.ReadLine()!;
Console.WriteLine("Önceliği belirleyiniz (1-3)");
int oncelik = Convert.ToInt32(Console.ReadLine());
string belirlenmisOncelik = "";
if (oncelik == 1)
{
    belirlenmisOncelik = "Yüksek";
}
else if (oncelik == 2)
{
    belirlenmisOncelik = "Orta";
}
else if (oncelik == 3)
{
    belirlenmisOncelik = "Düşük";
}
else
{
    belirlenmisOncelik = "Geçersiz öncelik";
}
Console.WriteLine($"{gorev} | {belirlenmisOncelik}");
