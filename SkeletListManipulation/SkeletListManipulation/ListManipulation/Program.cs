﻿using System;
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
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                   case "delete":
<<<<<<< HEAD

=======
>>>>>>> a5101867bf9f97615ab8ed37c98db20a9b91c746
                        //TODO
                        break;
                    case "remove":
                        //TODO
                        break;
<<<<<<< HEAD
                    case "countodds":
                        foreach (var n in nums)
                        {
                            if (n%2==0)
                            {
                                nums.Remove(n);
                                Console.WriteLine(string.Join(" ", nums.Count()));
                            }
                            //nums.Count();
                            
                        }
                        break;
=======
                   
>>>>>>> a5101867bf9f97615ab8ed37c98db20a9b91c746
                        //TODO

                    default:
                        break;
                }
            }

        }
    }
}
