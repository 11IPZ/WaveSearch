using System;

namespace Search
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[,] Map = new int[,]
            {
                {-2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2},
                {-2, 0, -2, -1, -1, -1, -1, -2, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -2, -1, -2, -2, -2, -2, -2, -2, -1, -1, -1, -1, -1, -2, -1, -1, -1, -2},
                {-2, -1, -2, -1, -2, -1, -1, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -1, -1, -2, -1, -2, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -1, -2},
                {-2, -2, -1, -2, -2, -1, -2, -2, -2, -2, -1, -1, -1, -2, -2, -1, -1, -1, -1, -2},
                {-2, -1, -1, -2, -1, -1, -1, -1, -1, -2, -2, -2, -2, -1, -2, -2, -2, -2, -1, -2},
                {-2, -2, -1, -2, -1, -1, -1, -2, -1, -2, -1, -1, -1, -1, -2, -1, -2, -1, -1, -2},
                {-2, -1, -1, -2, -2, -2, -1, -1, -2, -1, -1, -2, -1, -1, -1, -1, -2, -1, -2, -2},
                {-2, -1, -1, -1, -2, -1, -1, -2, -2, -1, -1, -2, -2, -2, -1, -1, -2, -1, -1, -2},
                {-2, -1, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -1, -2, -1, -2, -2, -1, -2},
                {-2, -1, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -1, -1, -2, -2, -2, -1, -2, -1, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2},
                {-2, -1, -1, -2, -1, -2, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -1, -2, -1, -2},
                {-2, -1, -2, -1, -1, -2, -1, -2, -2, -1, -1, -1, -2, -1, -1, -2, -1, -2, -1, -2},
                {-2, -1, -2, -2, -1, -2, -1, -1, -2, -1, -2, -2, -2, -1, -1, -2, -2, -2, -1, -2},
                {-2, -1, -2, -1, -1, -1, -2, -1, -2, -1, -2, -2, -1, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -2, -1, -2, -1, -2, -1, -2, -1, -1, -1, -2, -2, -1, -1, -2, -1, -1, -2},
                {-2, -1, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -2, -1, -1, -2, -1, -1, -2},
                {-2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2},

            };
            int[,] cMap = new int[,]
            {
                {-2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2},
                {-2, 0, -2, -1, -1, -1, -1, -2, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -2, -1, -2, -2, -2, -2, -2, -2, -1, -1, -1, -1, -1, -2, -1, -1, -1, -2},
                {-2, -1, -2, -1, -2, -1, -1, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -1, -1, -2, -1, -2, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -1, -2},
                {-2, -2, -1, -2, -2, -1, -2, -2, -2, -2, -1, -1, -1, -2, -2, -1, -1, -1, -1, -2},
                {-2, -1, -1, -2, -1, -1, -1, -1, -1, -2, -2, -2, -2, -1, -2, -2, -2, -2, -1, -2},
                {-2, -2, -1, -2, -1, -1, -1, -2, -1, -2, -1, -1, -1, -1, -2, -1, -2, -1, -1, -2},
                {-2, -1, -1, -2, -2, -2, -1, -1, -2, -1, -1, -2, -1, -1, -1, -1, -2, -1, -2, -2},
                {-2, -1, -1, -1, -2, -1, -1, -2, -2, -1, -1, -2, -2, -2, -1, -1, -2, -1, -1, -2},
                {-2, -1, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -1, -2, -1, -2, -2, -1, -2},
                {-2, -1, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -1, -1, -2, -2, -2, -1, -2, -1, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2},
                {-2, -1, -1, -2, -1, -2, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -1, -2, -1, -2},
                {-2, -1, -2, -1, -1, -2, -1, -2, -2, -1, -1, -1, -2, -1, -1, -2, -1, -2, -1, -2},
                {-2, -1, -2, -2, -1, -2, -1, -1, -2, -1, -2, -2, -2, -1, -1, -2, -2, -2, -1, -2},
                {-2, -1, -2, -1, -1, -1, -2, -1, -2, -1, -2, -2, -1, -1, -1, -1, -1, -1, -1, -2},
                {-2, -1, -2, -1, -2, -1, -2, -1, -2, -1, -1, -1, -2, -2, -1, -1, -2, -1, -1, -2},
                {-2, -1, -1, -1, -2, -1, -1, -1, -2, -1, -1, -2, -1, -2, -1, -1, -2, -1, -4, -2},
                {-2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2, -2},
            };
            WriteMap(Map, 20, 20);

            int[,] nMap = DeksterMap(Map,cMap,20,20);

            WriteMap(nMap, 20, 20);
        }

        static void WriteMap(int[,] Map, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    int m = Map[i, b];

                    if (m == -2)
                    {
                        Console.Write("█");
                    }
                    else if (m == -1)
                    {
                        Console.Write(" ");
                    }
                    else if (m == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    else if (m == -4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    else if (m == -5)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(m);
                    }
                }
                Console.WriteLine();
            }
        }

        static int[,] DeksterMap(int[,] Map, int[,] cMap, int height, int width)
        {
            int step = 0;
            int last = 0;
            int x = 0;
            int y = 0;
            bool active = true;

            while (active)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int b = 0; b < width; b++)
                    {
                        if(Map[i,b] == step)
                        {
                            if (Map[i,b + 1] == -1 || Map[i, b + 1] == -4)
                            {
                                Map[i, b + 1] = step+1;
                            }
                            if (Map[i, b - 1] == -1 || Map[i, b + 1] == -4)
                            {
                                Map[i, b - 1] = step+1;
                            }
                            if (Map[i + 1, b] == -1 || Map[i, b + 1] == -4)
                            {
                                Map[i + 1, b ] = step+1;
                            }
                            if (Map[i - 1, b] == -1 || Map[i, b + 1] == -4)
                            {
                                Map[i - 1, b] = step+1;
                            }
                        }
                    }
                }
                step++;

                if(step == (height * width))
                {
                    active = false;
                }
            }
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (cMap[i, b] == -4)
                    {
                        last = Map[i, b];
                        y = i;
                        x = b;
                    }
                }
            }

            int[,] Ret = PathMap(Map, cMap, last, y, x);
            return Ret;
        }

        static int[,] PathMap(int[,] Map, int[,] cMap, int step, int i, int b)
        {
            bool active = true;

            while (active)
            {
                if (Map[i, b + 1] == step - 1)
                {
                    cMap[i, b + 1] = -5;
                    b += 1;
                }else
                if (Map[i, b - 1] == step - 1)
                {
                    cMap[i, b - 1] = -5;
                    b -= 1;
                }else
                if (Map[i + 1, b] == step - 1)
                {
                    cMap[i + 1, b] = -5;
                    i += 1;
                }else
                if (Map[i - 1, b] == step - 1)
                {
                    cMap[i - 1, b] = -5;
                    i -= 1;
                }
                step--;

                if (step == 1)
                {
                    active = false;
                }
            }

            return cMap;
        }
    }
}
