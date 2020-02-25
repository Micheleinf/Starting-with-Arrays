using System;

/*
 * File:                ArraysAufgabe
 * Author:               Michele Biondi
 * Date:                29.1.2020
 * Description:         Aufgabe First-Array
 */

namespace ArraysAufgabe
{
    class Program
    {
        static void one(string[] args)
        {
            string[] names = new string[] { "Hund", "Katze", "Maus", "Elefant", "Giraffe", "Vogel" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
