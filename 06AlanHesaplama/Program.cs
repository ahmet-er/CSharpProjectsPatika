char exit = 'c';

while (exit != 'e')
{
    Console.Write("Please select shape for calculation\n--Circle: press '0'--\n--Triangle: press '1'--\n--Square: press '2'--\n--Rectangle: press'3'--\nselect shape: ");

    try
    {
        int shapeIndex = Convert.ToInt32(Console.ReadLine());

        switch (shapeIndex)
        {
            case 0:
                CircleCalculate();
                break;
            case 1:
                TriangleCalculate();
                break;
            case 2:
                SquareCalculate();
                break;
            case 3:
                RectangleCalculate();
                break;
            default:
                Console.WriteLine("Wrong selection.");
                break;
        }

        Console.Write("If you want to exit, press 'e'; if you want to continue, press'c':");
        exit = Convert.ToChar(Console.ReadLine());
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine(ex);
    }
}

void RectangleCalculate()
{
    Console.Write("long side length:");
    int longLength = Convert.ToInt32(Console.ReadLine());
    Console.Write("short side length:");
    int shortLength = Convert.ToInt32(Console.ReadLine());

    double result = longLength * shortLength;
    Console.WriteLine($"area of the rectangle: {shortLength} x {longLength} = {result}");
}

void SquareCalculate()
{
    Console.Write("square side lenth: ");
    int length = Convert.ToInt32(Console.ReadLine());
    double result = Math.Pow(length, 2);
    Console.WriteLine($"square side lenth: {length}, area of the square: {result}");
}

void CircleCalculate()
{
    Console.Write("Circle radius: ");
    int radius = Convert.ToInt32(Console.ReadLine());
    double result = Math.PI * Math.Pow(radius, 2);

    Console.WriteLine($"your radius: {radius}, area of the circle: {result}");
}

void TriangleCalculate()
{
    Console.Write("Please select triangle type:\n--Equilateral(Eşitkenar): press '0'--\n--Isosceles(İkizkenar): press '1'--\n--Scalene(Çeşitkenar): press '2'--\nselect type:");
    int triangleType = Convert.ToInt32(Console.ReadLine());
    switch (triangleType)
    {
        case 0:
            EquilateralTrianleCal();
            break;
        case 1:
            IsoscelesTriangleCal();
            break;
        case 2:
            ScaleneTriangleCal();
            break;
        default:
            Console.WriteLine("wrong type selected");
            break;
    }
}

void ScaleneTriangleCal()
{

    Console.Write("First side lenth: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Second side lenth: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Thith side lenth: ");
    double c = Convert.ToDouble(Console.ReadLine());

    if ((a + b > c) && (a + c > b) && (b + c > a))
    {
        double s = (a + b + c) / 2;
        double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine($"area of the scale triangle: {result}");
    }
    else
    {
        Console.WriteLine("you can not create triangle this side lengths");
    }
}

void IsoscelesTriangleCal()
{
    Console.Write("twin side length: ");
    int twinSideLenth = Convert.ToInt32(Console.ReadLine());
    Console.Write("other length: ");
    int otherLenth = Convert.ToInt32(Console.ReadLine());

    double heigth = Math.Sqrt(Math.Pow(twinSideLenth, 2) - Math.Pow((otherLenth / 2), 2));

    double result = heigth * otherLenth / 2;
    Console.WriteLine($"area of the isosceles triangle: {result}");
}

void EquilateralTrianleCal()
{
    Console.Write("triangle side length:");
    int length = Convert.ToInt32(Console.ReadLine());
    double result = ((Math.Sqrt(3) / 4) * Math.Pow(length, 2));

    Console.WriteLine($"triangle side length: {length}, area of the equilateral triangle: {result}");
}