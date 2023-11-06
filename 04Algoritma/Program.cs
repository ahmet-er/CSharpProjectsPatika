System.Console.WriteLine("Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.");

char exit = 'c';

while (exit != 'e')
{
    System.Console.Write("Write string, int: ");

    try
    {
        string input = Console.ReadLine();

        Algorithm(input);

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}


void Algorithm(string input)
{
    string[] inputArr = input.Split(',');

    for (global::System.Int32 i = 0; i < inputArr.Length; i += 2)
    {
        string text = inputArr[i];
        int index = Convert.ToInt32(inputArr[i + 1]);

        if (index >= 0 && index < text.Length)
        {
            string output = text.Remove(index, 1);
            Console.WriteLine(output + " ");
        }
        else
        {
            Console.WriteLine("Invalid index for input: " + text);
        }
    }
}