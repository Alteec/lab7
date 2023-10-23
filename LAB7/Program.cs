using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using MyClassLib.WorldOfTanks;


namespace Registration.Interface;
class HW
{
    static void Main()
    {
        SimulateFight();
    }

    static void SimulateFight(string name1="T-34",string name2="Pantera",int rounds=5)
    {
        for(int i=0;i<rounds; i++)
        {
            Console.WriteLine($"Round {i+1}");

            Tank a = new Tank(name1);
            Tank b = new Tank(name2);
            Console.WriteLine($"Winner: {(a ^ b).Name}");
            Console.WriteLine("__________________________________________________________");

        }
    }
}