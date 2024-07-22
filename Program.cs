namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawKite('*', 100);
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

        static void DrawTriangle(char character = '*', int maxBase = 11)
        {
            for (int i = 0; i < maxBase; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(new String(' ', (maxBase - i) / 2) + new String(character, i));

                Thread.Sleep(100);
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

        static void DrawKite(char character = '*', int height = 15)
        {
            int maxBase = height / 2;
           
            DrawTriangle(character, maxBase);

            for (int i = maxBase; i > 0; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine(new String(' ', (maxBase - i) / 2) + new String(character, i));

                Thread.Sleep(100);  
            }
        }

        static void DrawStar()
        {

        }
    }
}
