using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        public string Name { get; set; }
        private int Ammunition {  get; set; }
        private int ArmorLevel {  get; set; }

        private int ManeuverabilityLevel { get; set; }
        
        public Tank(string name )
        {
            Random rand=new Random();
            this.Name = name;
            this.Ammunition = rand.Next(101);
            this.ArmorLevel = rand.Next(101);
            this.ManeuverabilityLevel = rand.Next(101);

        }

        public static Tank operator ^(Tank a, Tank b)
        {
            int flag1 = 0;
            int flag2 = 0;
            int placeholder = 0;


            placeholder = a.Ammunition > b.Ammunition ? flag1++:flag2++ ;
            placeholder = a.ArmorLevel > b.ArmorLevel ? flag1++ : flag2++;
            placeholder = a.ManeuverabilityLevel > b.ManeuverabilityLevel ? flag1++ : flag2++;

            Console.WriteLine($"{"Название",-15}{a.Name,-10} {b.Name,-10}\n{"Боекомплект:",-15}{a.Ammunition,-10} {b.Ammunition,-10}\n{"Уровень брони:",-15}{a.ArmorLevel,-10} {b.ArmorLevel,-10}\n{"Маневренность:",-15}{a.ManeuverabilityLevel,-10} {b.ManeuverabilityLevel,-10}");
            Console.WriteLine($"{"Счет:",-15}{flag1,-11}{flag2,-10}");


            return flag1 >flag2?a:b;
        }

        public string Stat()
        {
            return $"Название: {this.Name}\nБоекомплект: {this.Ammunition}\nУровень брони {this.ArmorLevel}\nУровень маневренности:{this.ManeuverabilityLevel}";
        }

    }
}
