﻿using FirstProgram;
using System;
public class RandomStringInArraySample
{
    public string checkstring()
    {
        string[] authors = { "S", "O" };
        Random rand = new Random();

        int index = rand.Next(authors.Length);
        // Display the result.  
        //  Console.WriteLine(authors[index]);

        return authors[index];

    }
    public void method()
    {
        string[,] roomString = new string[4, 4];
        int count = 0;
        string rep = "";
        string[,] horiz = new string[4, 4];
        string[,] verticle = new string[4, 4];
        string[,] munnaarray = new string[8, 8];
        Console.WriteLine("Random  sequence is  ");
        int Eight_Row = 0;
        int Eight_Col = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                roomString[i, j] = checkstring();
                Console.Write(roomString[i, j] + " ");

                munnaarray[Eight_Row, Eight_Col] = roomString[i, j];
                // Console.Write(munnaarray[Eight_Row, Eight_Col] + " ");
                Eight_Col++;
                if (Eight_Col == 8 && Eight_Row == 0)
                {
                    Eight_Col = 0;
                    Eight_Row = 1;
                }

            }

            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("Horizontal sequence is  ");
        // horiz=verticle;
        // Array.Resize(ref munnaarray,);
        Eight_Row = 2;
        Eight_Col = 0;

        int Print_Row = 0;
        int Print_Col = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {

                if (i < 4 && j < 4)
                {
                    munnaarray[Eight_Row, Eight_Col] = roomString[j, i];
                    Console.Write(munnaarray[Print_Row, Print_Col] + " ");
                    Eight_Col++;
                    Print_Col++;
                    if (Eight_Col == 8 && Eight_Row == 2)
                    {
                        Eight_Col = 0;
                        Eight_Row = 3;
                    }
                    if (Print_Col == 8)
                    {
                        Print_Col = 0;
                        Print_Row++;
                    }
                }

                if (i > 4 && j > 4)
                {
                    if (i == 5 && j == 5)
                    {
                        Console.WriteLine("Verticle sequence is  ");
                    }
                    Console.Write(munnaarray[Print_Row, Print_Col] + " ");
                    if (Print_Col == 3 || Print_Col == 7)
                    {
                        Console.WriteLine();
                    }
                    Print_Col++;
                    if (Print_Col == 8)
                    {
                        Print_Col = 0;
                        Print_Row++;
                    }
                }

            }

            if (i < 4)
            {
                Console.WriteLine();
            }

        }


        // Console.WriteLine("Verticle sequence is  ");

        Console.WriteLine();
        //  count = Matchstring(verticle, count);
        Console.WriteLine("Total count of SOS : " + count);
        //Console.WriteLine();

        //Console.WriteLine("Horizental sequence is  ");

        //Console.WriteLine();
        // horiz = "";
        // verticle = "";
    }
    public int Matchstring(string check, int count = 0)
    {
        string match = "SOS";


        if (check.Contains(match))
        {

            count++;

            Console.WriteLine(" SOS  Found " + count);



        }
        else
        { Console.WriteLine(" SOS not Found"); }
        return count;

    }

    public static void Main()
    {
        RandomStringInArraySample p = new RandomStringInArraySample();
        // p.checkstring();
        p.method();

    }
}