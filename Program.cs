using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedrual
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Randomisation Test";

            //weapon blade library
            string[] Weapon_blade = { "Needle point", "Spear point", "Kukri point", "Trailing point", "Clip point",
            "Drop point", "Drop point", "Tanto point", "Talon", "Hawkbill", "Dao", "Nessmuk", "Straight back", "Dagger like", };



            //weapon material library
            string[] Material_blade = { "golden", "wooden", "titanium", "steel", "uranium", "stone", "plastic", "zinc", "magnesium",
            "aluminium", "brass", "bronze", "copper", "tin", "platinum", "silver", "lead", "iron" };

            string[] Material_blade2 = { "golden", "wooden", "Titanium", "steel", "uranium", "stone", "plastic", "zinc", "magnesium",
            "aluminium", "brass", "bronze", "copper", "tin", "platinum", "silver", "lead", "iron" };



            //Condition library
            string[] Weapon_condition = { "like a masterwork!", "lengendary", "shoddy", "bent", "cracked", "warped", "decent",
            "good", "well made", "ordinairy", "magical", "old", "brand new", "used", "cursed", "horrible" };


            //randomatron
            Random rand = new Random();


            //makes number from Lib choice converts it into int
            int Blade = rand.Next (Weapon_blade.Length);
            int Handle = rand.Next(Material_blade2.Length);
            int Condition = rand.Next(Weapon_condition.Length);
            int Bladematt = rand.Next(Material_blade.Length);

            //grabs the int from randomiser and refers it back according to the right string
            Console.WriteLine($"you found a {Material_blade[Bladematt]} sword with a {Weapon_blade[Blade]} blade and a {Material_blade2[Handle]} handle , it looks {Weapon_condition[Condition]}");

            

            Console.ReadLine();
        }
    }
}
