char exit = 'c';

while (exit != 'e')
{
    Console.Write("please enter binary int with space between them: ");

    try
    {
        string input = Console.ReadLine();

        string output = Calculate(input);

        Console.WriteLine($"Result: {output}");

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}

string Calculate(string input)
{
    string[] pairStrings = input.Split(' ');

    List<int> numbers = new List<int>();

    for (int i = 0; i < pairStrings.Length; i += 2)
    {
        if (i + 1 < pairStrings.Length)
        {
            int num1 = Convert.ToInt32(pairStrings[i]);
            int num2 = Convert.ToInt32(pairStrings[i + 1]);

            if (num1 != num2)
                numbers.Add(num1 + num2);
            else
                numbers.Add(Convert.ToInt32(Math.Pow((num1 + num2), 2)));
        }
    }

    string output = string.Join(" ", numbers);
    return output;
}