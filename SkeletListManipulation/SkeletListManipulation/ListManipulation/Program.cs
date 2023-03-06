using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        nums.Add(int.Parse(cmd[1]));
                        break;

                   case "delete":
                        nums.Remove(nums[1]);
                        break;

                    case "remove":
                        //TODO
                        break;
                    case "addMany":
                        nums.Add(int.Parse(cmd[1]));
                        break;
                    case "print":
                        {
                            Console.WriteLine(string.Join(" ", nums));
                            break;
                        }
                    case "printodds":
                        {
                            Console.WriteLine(string.Join(" ", nums.Where(n => n % 2 == 1)));
                        }
                            break;

                    default:
                        break;
                }
            }

        }
    }
}
