using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        HashSet<string> regular = new HashSet<string>();
        HashSet<string> vip = new HashSet<string>();

        string input;
        //Add guests to one of the reservation lists.
        while ((input = Console.ReadLine()) != "PARTY")
        {
            //Takes the first digit from a string.
            string digits = new String(input.TakeWhile(Char.IsDigit).ToArray());

            if (digits == string.Empty)
            {
                regular.Add(input);
            }
            else
            {
                vip.Add(input);
            }
        }

        while (true)
        //Removing guests who are present in the reservetion lists.
        {
            input = Console.ReadLine();

            if (input == "END")
            {
                Console.WriteLine(vip.Count + regular.Count);

                foreach (var guest in vip)
                {
                    Console.WriteLine(guest);
                }

                foreach (var guest in regular)
                {
                    Console.WriteLine(guest);
                }
                break;
            }
            vip.Remove(input);
            regular.Remove(input);
        }
    }
}

