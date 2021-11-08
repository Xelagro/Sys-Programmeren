using System;

namespace SYS_Les6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // Hier begint de code

    abstract class PickUps
    {
        public virtual void onPickUp()
        {
            Console.WriteLine("You pick up the thing");
        }

        public void HitByMouse(int x, int y)
        {
            int ItemX = 10;
            int ItemY = 30;

            if (x == ItemX && y == ItemY)
            {
                onPickUp();
            }
        }
    }
    abstract class Equipment : PickUps
    {
        public virtual void Equip()
        {

        }
    }

        // Pickup van armor

    class Armor : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Dit is een helm");
        }
    }

        // Pickup vam wapens

    class Weapon : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Dit is een zwaard");
        }
    }

        // Pickup heal potion

    class HealingPotion : PickUps
    {
        public override void onPickUp()
        {
            base.onPickUp();
            Console.WriteLine("Je hebt nu een HealthPotion in je inv");
        }
    }
        
        // Pickup Mana Potion.

    class ManaPotion : PickUps
    {
        public override void onPickUp()
        {
            base.onPickUp();
            Console.WriteLine("Je hebt nu een ManaPotion in je inv");
        }
    }
}
