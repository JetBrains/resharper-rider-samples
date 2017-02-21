using System;
using System.Collections.Generic;
using System.IO;

namespace GameOfLife
{

    class Life
    {
        const int WIDTH = 79;
        const int HEIGHT = 25;
        static byte[,] currentLife = new byte[WIDTH, HEIGHT];
        static byte[,] nextLife = new byte[WIDTH, HEIGHT];

        // using this is faster than using Console.Write()
        static StreamWriter stdout = new StreamWriter(Console.OpenStandardOutput(), System.Text.Encoding.UTF8);

        static void RedrawLife()
        {
            int data;

            for (int row = 0; row < HEIGHT; ++row)
            {
                for (int col = 0; col < WIDTH; ++col)
                {
                    data = currentLife[col, row];
                    if (data == 0)
                    {
                        stdout.Write(' ');
                    }
                    else if (data == 1)
                    {
                        stdout.Write((char) 9632);
                    }
                    else
                    {
                        stdout.Write(' ');
                    }
                }
                if (row != HEIGHT - 1) stdout.Write("\n");
            }
            stdout.Flush();
        }

        static void EdgeWrap(ref int x, ref int y)
        {
            if (x < 0) x += WIDTH;
            else if (x > WIDTH - 1) x -= WIDTH;
            if (y < 0) y += HEIGHT;
            else if (y > HEIGHT - 1) y -= HEIGHT;
        }

        static int CountNeighbours(int x, int y)
        {
            int x1, y1, count = 0;

            for (int sx = x - 1; sx < x + 2; sx++)
            {
                for (int sy = y - 1; sy < y + 2; sy++)
                {
                    if ((sx == x) && (sy == y))
                    {
                        // don't count self
                        continue;
                    }
                    x1 = sx;
                    y1 = sy;
                    EdgeWrap(ref x1, ref y1);
                    if (currentLife[x1, y1] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Update()
        {
            int n;

            for (int x = 0; x < WIDTH; x++)
            {
                for (int y = 0; y < HEIGHT; y++)
                {
                    n = CountNeighbours(x, y);

                    if (n < 2)
                    {
                        // Die due to isolation
                        nextLife[x, y] = (byte) (currentLife[x, y] == 1 ? 2 : 0);
                    }
                    else if (n == 2)
                    {
                        // 2 neighbours - stable
                        nextLife[x, y] = currentLife[x, y];
                    }
                    else if (n == 3)
                    {
                        // 3 neighbours - new life (or same old life)
                        nextLife[x, y] = 1;
                    }
                    else
                    {
                        // 4 or more - die due to overcrowding
                        nextLife[x, y] = 0;
                    }
                }
            }

            // Copy new Life to the matrix
            Array.Copy(nextLife, currentLife, WIDTH*HEIGHT);
            RedrawLife();
        }

        static void CopyPattern(byte[,] src, byte[,] dst, int xoffset, int yoffset)
        {
            for (int y = 0; y < src.GetLength(0); y++)
            {
                for (int x = 0; x < src.GetLength(1); x++)
                {
                    dst[x + xoffset, y + yoffset] = src[y, x];
                }
            }
        }

        static void Main(string[] args)
        {
            // I got the definition of the glider gun here:
            // http://www.conwaylife.com/patterns/gosperglidergun.cells
            byte[,] init = new byte[,]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1},
                {1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };
            CopyPattern(init, currentLife, 0, 0);
            Console.CursorVisible = false;

            while (!Console.KeyAvailable)
            {
                Update();
                System.Threading.Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}