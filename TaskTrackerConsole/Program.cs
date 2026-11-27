for (int i = 1; i <= 3; i++)
{
    string baslik;
    do
    {
        System.Console.WriteLine("Lütfen görev başlığını giriniz: ");
        baslik = Console.ReadLine()!;

    } while (string.IsNullOrWhiteSpace(baslik));

    int oncelik = 0;

    while (oncelik < 1 || oncelik > 3)
    {
        System.Console.WriteLine("Lütfen öncelik giriniz (1-3) ");
        oncelik = int.Parse(Console.ReadLine()!);

    }

    switch (oncelik)
    {
        case 1:

            System.Console.WriteLine($"Görev {i}: {baslik} - Yüksek");

            break;
        case 2:

            System.Console.WriteLine($"Görev {i}: {baslik} - Orta");

            break;
        case 3:

            System.Console.WriteLine($"Görev {i}: {baslik} - Düşük");

            break;

        default:

            System.Console.WriteLine("Geçersiz öncelik!");

            break;
    }
}