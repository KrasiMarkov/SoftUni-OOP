using System;

namespace Class_Box_Data
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                double surfaceArea = box.CalculateSurfaceArea();

                double lateralSurfaceArea = box.CalculateLateralSurfaceArea();

                double volume = box.CalculateVolume();

                Console.WriteLine($"Surface Area - {surfaceArea:F2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
                Console.WriteLine($"Volume - {volume:F2}");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
