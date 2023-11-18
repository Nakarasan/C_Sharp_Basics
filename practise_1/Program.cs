//simple comment

using Microsoft.VisualBasic;
using practise_1;

class Person
{
    static void Main(String[] args)
    {
        //Vehicle car = new Vehicle();
        //Console.WriteLine(car.FormatYear());
        int area = GetArea(10, 5);

        Console.WriteLine(area);
        //.

    }

    public static int GetArea(int rectHeight, int rectWidth)
    {
        return rectHeight * rectWidth;
    }
}

