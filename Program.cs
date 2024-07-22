namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawCircle('*', 20);
        }

        static void DrawRectangle(char character = '*', int length = 30, int height = 20)
        {
            int i = 0;

            while (i < height)
            {
                Console.Write(new String(character, length) + '\n');
                i++;

                Thread.Sleep(100);
            }
        }

        static void DrawTriangle(char character = '*', int triangleBase = 11)
        {
            for (int i = 0; i < triangleBase; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(new String(' ', (triangleBase - i) / 2) + new String(character, i));
            }
        }

        static void DrawCircle(char character = '*', int radius = 10)
        {
            double consoleRatio = Convert.ToDouble(4.0 / 2.0),
                a = consoleRatio * radius,
                b = radius;

            for (int y = -radius; y <= radius; y++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (y / b) * (y / b);

                    if (d > 0.9 && d < 1.2)
                        Console.Write(character);
                    else
                        Console.Write(" ");

                    Thread.Sleep(50);
                }

                Console.Write('\n');
            }
        }
    }
}
