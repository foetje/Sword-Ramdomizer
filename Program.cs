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

            //Weapon MattVars
            int Weapon_slash = 0;
            int Weapon_pierce = 0;
            int Weapon_Blunt = 0;
            int Weapon_Stability = 0;
            int Weapon_cond = 0;
            int WeaponFinal = 0;

            //weapon blade library
            string[] Weapon_blade = { "Needle point", "Spear point", "Kukri point", "Trailing point", "Clip point",
            "Drop point", "Drop point", "Tanto point", "Talon", "Hawkbill", "Dao", "Nessmuk", "Straight back", "Dagger like", };



            //weapon material library
            string[] Material_blade = { "golden", "wooden", "titanium", "steel", "uranium", "stone", "plastic", "zinc", "magnesium",
            "aluminium", "brass", "bronze", "copper", "tin", "platinum", "silver", "lead", "iron" };

            string[] Material_handle = { "golden", "wooden", "Titanium", "steel", "uranium", "stone", "plastic", "rubber", "cloth wrapped",
            "latex wrapped", "brass", "bronze", "copper", "tin", "platinum", "silver", "lead", "iron" };



            //Condition library
            string[] Weapon_condition = { "like a masterwork!", "lengendary", "shoddy", "bent", "cracked", "warped", "decent",
            "good", "well made", "ordinairy", "magical", "old", "brand new", "used", "cursed", "horrible" };


            //Magic muliplier
            string[] Magic_spell = { "shoots fire", "shoots lightning", "controlls gravity" };

            //Magic debuff
            string[] Curse_Spell = { "hurts to the touch", "whispering", "degrading" };


            //randomatron
            Random rand = new Random();


            //makes number from Lib choice converts it into int
            int Blade = rand.Next (Weapon_blade.Length);
            int Handle = rand.Next(Material_handle.Length);
            int Condition = rand.Next(Weapon_condition.Length);
            int Bladematt = rand.Next(Material_blade.Length);

            //grabs random number
            int BlademattInt = Bladematt;
            int ConditionInt = Condition;
            int HandleInt = Handle;
            int BladeInt = Blade;
            


            //refers it back according to the right string
            Console.WriteLine($"you found a {Material_blade[BlademattInt]} sword with a {Weapon_blade[BladeInt]} blade and a {Material_handle[HandleInt]} handle , it looks {Weapon_condition[ConditionInt]}");

            


            //stats config Blade material
            if (BlademattInt == 0)
            {
                Weapon_slash = 25;
                Weapon_pierce = 10;
                Weapon_Blunt = 0;
            }
            else if (BlademattInt == 1)
            {
                Weapon_slash = 5;
                Weapon_pierce = 2;
                Weapon_Blunt = 5;
            }
            else if (BlademattInt == 2)
            {
                Weapon_slash = 65;
                Weapon_pierce = 25;
                Weapon_Blunt = 7;
            }
            else if (BlademattInt == 3)
            {
                Weapon_slash = 35;
                Weapon_pierce = 15;
                Weapon_Blunt = 3;
            }
            else if (BlademattInt == 4)
            {
                Weapon_slash = 25;
                Weapon_pierce = 5;
                Weapon_Blunt = 40;
            }
            else if (BlademattInt == 5)
            {
                Weapon_slash = 10;
                Weapon_pierce = 4;
                Weapon_Blunt = 10;
            }
            else if (BlademattInt == 6)
            {
                Weapon_slash = 10;
                Weapon_pierce = 5;
                Weapon_Blunt = 0;
            }
            else if (BlademattInt == 7)
            {
                Weapon_slash = 25;
                Weapon_pierce = 15;
                Weapon_Blunt = 1;
            }
            else if (BlademattInt == 8)
            {
                Weapon_slash = 23;
                Weapon_pierce = 11;
                Weapon_Blunt = 0;
            }
            else if (BlademattInt == 9)
            {
                Weapon_slash = 26;
                Weapon_pierce = 20;
                Weapon_Blunt = 0;
            }
            else if (BlademattInt == 10)
            {
                Weapon_slash = 40;
                Weapon_pierce = 20;
                Weapon_Blunt = 10;
            }
            else if (BlademattInt == 11)
            {
                Weapon_slash = 37;
                Weapon_pierce = 19;
                Weapon_Blunt = 12;
            }
            else if (BlademattInt == 12)
            {
                Weapon_slash = 25;
                Weapon_pierce = 15;
                Weapon_Blunt = 2;
            }
            else if (BlademattInt == 13)
            {
                Weapon_slash = 15;
                Weapon_pierce = 15;
                Weapon_Blunt = 0;
            }
            else if (BlademattInt == 14)
            {
                Weapon_slash = 70;
                Weapon_pierce = 30;
                Weapon_Blunt = 0;
            }
            else if (BlademattInt == 15)
            {
                Weapon_slash = 30;
                Weapon_pierce = 20;
                Weapon_Blunt = 2;
            }
            else if (BlademattInt == 16)
            {
                Weapon_slash = 25;
                Weapon_pierce = 5;
                Weapon_Blunt = 50;
            }
            else if (BlademattInt == 17)
            {
                Weapon_slash = 33;
                Weapon_pierce = 12;
                Weapon_Blunt = 7;
            }

            //stats config handle stability

            if (HandleInt == 0)
            {
                Weapon_Stability = 45;
            }
            else if (HandleInt == 1)
            {
                Weapon_Stability = 50;
            }
            else if (HandleInt == 2)
            {
                Weapon_Stability = 25;
            }
            else if (HandleInt == 3)
            {
                Weapon_Stability = 60;
            }
            else if (HandleInt == 4)
            {
                Weapon_Stability = 30;
            }
            else if (HandleInt == 5)
            {
                Weapon_Stability = 20;
            }
            else if (HandleInt == 6)
            {
                Weapon_Stability = 40;
            }
            else if (HandleInt == 7)
            {
                Weapon_Stability = 80;
            }
            else if (HandleInt == 8)
            {
                Weapon_Stability = 65;
            }
            else if (HandleInt == 9)
            {
                Weapon_Stability = 70;
            }
            else if (HandleInt == 10)
            {
                Weapon_Stability = 10;
            }
            else if (HandleInt == 11)
            {
                Weapon_Stability = 45;
            }
            else if (HandleInt == 12)
            {
                Weapon_Stability = 10;
            }
            else if (HandleInt == 13)
            {
                Weapon_Stability = 43;
            }
            else if (HandleInt == 14)
            {
                Weapon_Stability = 100;
            }
            else if (HandleInt == 15)
            {
                Weapon_Stability = 75;
            }
            else if (HandleInt == 16)
            {
                Weapon_Stability = 5;
            }
            else if (HandleInt == 17)
            {
                Weapon_Stability = 55;
            }



            //stats config Condition
            if (ConditionInt == 0)
            {
                Weapon_cond = 15;
            }
            else if (ConditionInt == 1)
            {
                Weapon_cond = 13;
            }
            else if (ConditionInt == 2)
            {
                Weapon_cond = -2;
            }
            else if (ConditionInt == 3)
            {
                Weapon_cond = -10;
            }
            else if (ConditionInt == 4)
            {
                Weapon_cond = -8;
            }
            else if (ConditionInt == 5)
            {
                Weapon_cond = -8;
            }
            else if (ConditionInt == 6)
            {
                Weapon_cond = 0;
            }
            else if (ConditionInt == 7)
            {
                Weapon_cond = 4;
            }
            else if (ConditionInt == 8)
            {
                Weapon_cond = 2;
            }
            else if (ConditionInt == 9)
            {
                Weapon_cond = 0;
            }
            else if (ConditionInt == 10)
            {
                Weapon_cond =8;
            }
            else if (ConditionInt == 11)
            {
                Weapon_cond = -5;
            }
            else if (ConditionInt == 12)
            {
                Weapon_cond = 6;
            }
            else if (ConditionInt == 13)
            {
                Weapon_cond = 0;
            }
            else if (ConditionInt == 14)
            {
                Weapon_cond = -25;
            }
            else if (ConditionInt == 15)
            {
                Weapon_cond = -20;
            }


            //calculate final weapon stats
            Weapon_slash = Weapon_slash + Weapon_cond;
            Weapon_pierce = Weapon_pierce + Weapon_cond;
            Weapon_Blunt = Weapon_Blunt + Weapon_cond;
            WeaponFinal = Weapon_Blunt + Weapon_cond + Weapon_pierce + Weapon_slash + Weapon_Stability;

            Console.WriteLine("Your Weapon's final score = " + WeaponFinal);

            if (WeaponFinal <= 0)
            {
                Console.WriteLine("This is a terrible sword");
            }
            else if (WeaponFinal <= 50)
            {
                Console.WriteLine("This is a bad weapon");
            }
            else if (WeaponFinal <= 120)
            {
                Console.WriteLine("This is a mediocre weapon");
            }
            else if (WeaponFinal <= 170)
            {
                Console.WriteLine("This is a good weapon");
            }
            else if (WeaponFinal <= 200)
            {
                Console.WriteLine("This is a great weapon");
            }
            else if (WeaponFinal > 200)
            {
                Console.WriteLine("This is a perfect weapon");
            }

            

        }
    }
}
