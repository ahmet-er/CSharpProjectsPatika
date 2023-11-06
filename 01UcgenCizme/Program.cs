System.Console.WriteLine("Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.");

char exit = 'c';

while (exit != 'e')
{
    System.Console.Write("Triangle height: ");

    try
    {
        int height = Convert.ToInt32(Console.ReadLine());

        DrawTriangle(height);

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}


void DrawTriangle(int height)
{
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j<= height - i; j++)
        {
            Console.Write(" ");
        }

        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}