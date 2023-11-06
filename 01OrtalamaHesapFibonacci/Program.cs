System.Console.WriteLine("Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.");

char exit = 'c';

while (exit != 'e')
{
    System.Console.Write("Fibonacci depth: ");

    try
    {
        int depth = Convert.ToInt32(Console.ReadLine());

        double avg = GetFibonacciAvg(depth);

        System.Console.WriteLine($"Fibonacci depth {depth} - Avg: {avg}");

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}


double GetFibonacciAvg(int depth)
{
    Dictionary<int, int> Fibonacci = new Dictionary<int, int>();

    Fibonacci.Add(0, 0);
    Fibonacci.Add(1, 1);
    Fibonacci.Add(2, 1);

    for (int i = 3; i <= depth; i++)
    {
        int value = Fibonacci.ElementAt(i - 1).Value + Fibonacci.ElementAt(i - 2).Value;
        Fibonacci.Add(i, value);
    }
    double fibonacciAvg = Fibonacci.Values.Average();
    return fibonacciAvg;
}