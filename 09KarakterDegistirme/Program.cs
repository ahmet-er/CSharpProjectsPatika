char exit = 'c';

while (exit != 'e')
{
    Console.Write("write a sentence: ");

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
    var xWord = input.Split(' ');
    List<string> word = new List<string>(xWord);
    string output = "";

    foreach (var y in word)
    {
        char[] chars = y.ToCharArray();
        char temp = chars[0];
        chars[0] = chars[chars.Length - 1];
        chars[chars.Length - 1] = temp;
        output += new string(chars) + " ";
    }

    return output.Trim();
}