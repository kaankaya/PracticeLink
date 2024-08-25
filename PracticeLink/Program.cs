class Program
{
    public static void Main(string[] args)
    {
        // Random Nesne Üretimi
        Random random = new Random();
        List<int> numbers = new List<int>();

        // Rastgele 10 adet sayıdan oluşan liste oluşturuyoruz (-50 ile 50 arasında)
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 51));
        }

        // Listeyi yazdır
        Console.WriteLine("Oluşturulan liste: " + string.Join(", ", numbers));
        Console.WriteLine("-------------------------");

        // Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift sayılar: " + string.Join(", ", evenNumbers));
        Console.WriteLine("-------------------------");

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek sayılar: " + string.Join(", ", oddNumbers));
        Console.WriteLine("-------------------------");

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif sayılar: " + string.Join(", ", negativeNumbers));
        Console.WriteLine("-------------------------");

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif sayılar: " + string.Join(", ", positiveNumbers));
        Console.WriteLine("-------------------------");

        // 15'ten büyük ve 22'den küçük sayılar
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", rangeNumbers));
        Console.WriteLine("-------------------------");

        // Listedeki her bir sayının karesi 
        var squaredNumbers = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Her bir sayının karesi: " + string.Join(", ", squaredNumbers));
        Console.WriteLine("-------------------------");
    }
}