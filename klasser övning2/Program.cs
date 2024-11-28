﻿

using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

List<rock> rocks = new List<rock>();
bool isIntString1;
bool isIntString2;

Console.WriteLine("How many rocks to create?");

string stringCreate = Console.ReadLine();
int intCreate;

if (isIntString1 = stringCreate.All(char.IsDigit))
{
    int.TryParse (stringCreate, out intCreate);

    for (int i = 1;i <= intCreate; i++)
    { 
        string stringWeight;
        int intWeight;
        Console.WriteLine("how much should the rock weigh?");
        stringWeight = Console.ReadLine();
        if (isIntString2 = stringWeight.All(char.IsDigit))
        {
            int.TryParse(stringWeight, out intWeight);

            rock r = new rock(intWeight);
            rocks.Add(r);
            Console.WriteLine ($"Created rock with {intWeight} weight.");
        }
    }
}


Console.WriteLine($"created {rocks.Count} rocks");