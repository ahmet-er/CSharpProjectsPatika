System.Console.WriteLine("Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.");

char exit = 'c';

while (exit != 'e')
{
    System.Console.Write("Write a sentence: ");

    try
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        List<string> resultWords = new List<string>();
        foreach (string word in words)
        {
            string shiftedWord = ShiftWord(word);
            resultWords.Add(shiftedWord);
        }

        string result = string.Join(" " , resultWords);
        Console.WriteLine($"Result: {result}");

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}


string ShiftWord(string word)
{
    char[] charArr = word.ToCharArray();

    for (int i = 0; i < charArr.Length - 1; i++)
    {
        char temp = charArr[i];
        charArr[i] = charArr[i + 1];
        charArr[i + 1] = temp;
    }
    return new string(charArr);
}