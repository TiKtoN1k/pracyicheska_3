namespace practicheskaya_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] octava1 = new int[] { 65, 69, 73, 77, 82, 87, 92, 98 };
                int[] octava2 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196 };
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.A)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[0]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.S)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[1]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.D)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[2]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.F)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[3]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.G)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[4]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.H)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[5]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.J)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[6]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.K)
                {
                    x(octava1);
                    static void x(int[] oct)
                    {
                        {
                            sound(oct[7]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.Q)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[0]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.W)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[1]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.E)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[2]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.R)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[3]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.T)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[4]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.Y)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[5]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.U)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[6]);
                        }
                    }
                }
                if (key.Key == ConsoleKey.I)
                {
                    x(octava2);
                    static void x(int[] oct)
                    {
                        {
                            soun(oct[7]);
                        }
                    }
                }
                static void sound(int octava1)
                {
                    Console.Beep(octava1, 300);
                }
                static void soun(int octava2)
                {
                    Console.Beep(octava2, 300);
                }
            }

        }
    }
}