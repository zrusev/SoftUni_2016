﻿namespace Labyrinth
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[,] lab = ReadLab(n);

            bool[,] visited = new bool[lab.GetLength(0), lab.GetLength(1)];

            int row = 0;
            int col = 0;

            //FIND START POINT
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (lab[i, j] == "*")
                    {
                        row = i;
                        col = j;
                        found = true;
                        break;
                    }

                    if (found)
                    {
                        break;
                    }
                }
            }

            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(new Cell(row, col, true, 0));

            while (queue.Count != 0)
            {
                Cell current = queue.Dequeue();
                visited[current.Row, current.Col] = true;

                row = current.Row;
                col = current.Col;

                if (lab[row, col] != "*")
                {
                    lab[row, col] = current.Moves.ToString();
                }

                //UP
                if (row - 1 >= 0 && lab[row - 1, col] != "x" && !visited[row - 1, col])
                {
                    queue.Enqueue(new Cell(row - 1, col, false, current.Moves + 1));
                }

                //RIGHT
                if (col + 1 < lab.GetLength(1) && lab[row, col + 1] != "x" && !visited[row, col + 1])
                {
                    queue.Enqueue(new Cell(row, col + 1, false, current.Moves + 1));
                }

                //DOWN
                if (row + 1 < lab.GetLength(0) && lab[row + 1, col] != "x" && !visited[row + 1, col])
                {
                    queue.Enqueue(new Cell(row + 1, col, false, current.Moves + 1));
                }

                //LEFT
                if (col - 1 >= 0 && lab[row, col - 1] != "x" && !visited[row, col - 1])
                {
                    queue.Enqueue(new Cell(row, col - 1, false, current.Moves + 1));
                }
            }

            PrintLab(lab);
        }

        //INITIALIZE LAB MATRIX
        private static string[,] ReadLab(int n)
        {
            string[,] lab = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    lab[i, j] = line[j].ToString();
                }
            }

            return lab;
        }

        //PRINT LAB MATRIX
        private static void PrintLab(string[,] lab)
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i, j] == "*")
                    {
                        Console.Write("*");
                    }
                    else if (lab[i, j] == "0")
                    {
                        Console.Write("u");
                    }
                    else
                    {
                        Console.Write(lab[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }

    public class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public bool Visited { get; set; }
        public int Moves { get; set; }

        public Cell(int row, int col, bool visited, int moves)
        {
            this.Row = row;
            this.Col = col;
            this.Visited = visited;
            this.Moves = moves;
        }
    }
}
