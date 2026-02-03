using System;
using System.Collections;

namespace Lab3
{
    public class HashtableDemo
    {
        public static void Run()
        {
            Console.WriteLine("----- Question 3: Hashtable Demo -----");
            Hashtable days = new Hashtable();

            // 1. Create hashtable with keys 1-7 (assuming 1=Sunday as per standard US calendar or 1=Monday? Prompt doesn't specify. I'll use 1=Sunday)
            days.Add(1, "Sunday");
            days.Add(2, "Monday");
            days.Add(3, "Tuesday");
            days.Add(4, "Wednesday");
            days.Add(5, "Thursday");
            days.Add(6, "Friday");
            days.Add(7, "Saturday");

            // 2. Find Tuesday
            bool found = days.ContainsValue("Tuesday");
            if (found)
            {
                Console.WriteLine("Tuesday is found in the Hashtable.");
            }
            else
            {
                Console.WriteLine("Tuesday is NOT found.");
            }

            // 3. Print all days
            Console.WriteLine("\nDays of the week:");
            foreach (DictionaryEntry day in days)
            {
                Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
