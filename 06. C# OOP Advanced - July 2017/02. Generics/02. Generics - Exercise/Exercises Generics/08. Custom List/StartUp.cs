﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Custom_List
{
    public class StartUp
    {
        public static void Main()
        {
            MyList<string> list = new MyList<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else
                {
                    string[] data = input.Split();
                    switch (data[0])
                    {
                        case "Add":
                            list.Add(data[1]);
                            break;
                        case "Remove":
                            list.Remove(int.Parse(data[1]));
                            break;
                        case "Contains":
                            Console.WriteLine(list.Contains(data[1]));
                            break;
                        case "Swap":
                            list.Swap(int.Parse(data[1]), int.Parse(data[2]));
                            break;
                        case "Greater":
                            Console.WriteLine(list.CountGreaterThan(data[1]));
                            break;
                        case "Max":
                            Console.WriteLine(list.Max());
                            break;
                        case "Min":
                            Console.WriteLine(list.Min());
                            break;
                        case "Print":
                            Console.WriteLine(list.ToString());
                            break;
                        case "END":
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
