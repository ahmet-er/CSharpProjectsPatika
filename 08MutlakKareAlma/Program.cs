char exit = 'x';
List<int> inputList = new List<int>();

while (exit != 'c')
{
    Console.WriteLine("For calculation, press 'c'");
    Console.Write("Please enter a number (or press 'c' to calculate): ");

    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "c")
    {
        if (inputList.Count > 0)
        {
            var output = Calculate(inputList);
            Console.WriteLine($"Result: {output}");
        }
        else
        {
            Console.WriteLine("Please enter at least one number before pressing 'c' for calculation.");
        }
        break;
    }

    try
    {
        int input = Convert.ToInt32(userInput);
        inputList.Add(input);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid number or 'c' to calculate.");
    }
}

string Calculate(List<int> inputs)
{
    List<int> lessThan67 = new List<int>();
    List<int> moreThan67 = new List<int>();
    foreach (int number in inputs)
    {
        if (number <= 67)
        {
            var diff = 67 - number;
            lessThan67.Add(diff);
        }
        else
        {
            var diff = number - 67;
            var pow = (int)Math.Pow(diff, 2);
            moreThan67.Add(pow);
        }
    }
    var result1 = lessThan67.Sum();
    var result2 = moreThan67.Sum();

    return $"{result1} {result2}";
}