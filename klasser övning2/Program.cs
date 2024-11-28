

using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

List<rock> rocks = new List<rock>();
// bool isIntString1;
// bool isIntString2;

Console.WriteLine("How many rocks to create?");

string stringCreate = Console.ReadLine();
int intCreate;
int.TryParse (stringCreate, out intCreate);

for (int i = 1;i <= intCreate; i++)
{ 
    string stringWeight;
    int intWeight;
    Console.WriteLine("how much should this rock weigh?");
    stringWeight = Console.ReadLine();
    

        int.TryParse(stringWeight, out intWeight);

        rock r = new rock(intWeight);
        rocks.Add(r);
        Console.WriteLine ($"Created rock with {intWeight} weight.");

}
Console.WriteLine($"created {rocks.Count} rocks");
Console.ReadLine();