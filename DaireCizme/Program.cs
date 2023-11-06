System.Console.WriteLine("Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.");

char exit = 'c';

while (exit != 'e')
{
    System.Console.Write("Circle radius: ");

    try
    {
        int radius = Convert.ToInt32(Console.ReadLine());

        DrawTriangle(radius);

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}


void DrawTriangle(int radius)
{
    for (global::System.Int32 i = -radius; i <= radius; i++)
    {
        for (global::System.Int32 j = -radius; j <= radius; j++)
        {
            if (i * i + j * j <= radius * radius)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}