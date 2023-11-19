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
    string output = "";
    string[] words = input.Split(' ');
    string consonants = "bcçdfgğhjklmnprsştvyzBCÇDFGĞHJKLMNPRSŞTVYZ";

    foreach (var word in words)
    {
        int count = 0;
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            if (consonants.Contains(c))
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count == 2)
            {
                output += "True ";
                break;
            }
        }
        if (count < 2)
        {
            output += "False ";
        }
    }
    return output.Trim();
}