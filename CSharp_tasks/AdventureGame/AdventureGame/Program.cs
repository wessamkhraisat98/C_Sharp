using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{

    abstract class GameCharacter
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health { get; set; }

        public GameCharacter(string name, int health)
        {
            Name = name;

            Health = Math.Max(0, Math.Min(100, health));
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Damage cannot be negative.");
                return;
            }

            Health = Math.Max(0, Health - amount);

            Console.WriteLine(Name + " takes " + amount + " damage.");
        }

        public void ShowHealth()
        {
            Console.WriteLine(Name + "'s health: " + Health);
        }

        public void Heal()
        {
            Heal(10);
        }

        public void Heal(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Healing amount must be positive.");
                return;
            }

            Health = Math.Min(100, Health + amount);

            Console.WriteLine(Name + " heals " + amount + " points.");
            ShowHealth();
        }
    }

    class Warrior : GameCharacter
    {
        public Warrior(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Damage cannot be negative.");
                return;
            }

            int reducedDamage = Math.Max(0, amount - 2);

            base.TakeDamage(reducedDamage);
        }
    }



    class Wizard : GameCharacter
    {
        public Wizard(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
        }
    }



    interface ICollectible
    {
        void Collect();
    }

    class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public HealthPotion(string potionName)
        {
            PotionName = potionName;
        }

        public void Collect()
        {
            Console.WriteLine(PotionName + " collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = Convert.ToInt32(amountText);

                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input! Number is too large or too small.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();

            Warrior warrior = new Warrior("Wessam", 80);
            Wizard wizard = new Wizard("Ahmad", 70);

            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine(character.GetType().Name + " " + character.Name + " enters the game!");

                character.UseSpecialAbility();

                character.TakeDamage(10);

                character.ShowHealth();
                Console.WriteLine();

                if (character is Warrior)
                {
                    character.Heal();
                    Console.WriteLine();

                    character.Heal(15);
                    Console.WriteLine();
                }
            }

            HealthPotion potion = new HealthPotion("Health Potion");

            potion.Collect();
            Console.WriteLine();

            potion.Use(wizard, "15");
            Console.WriteLine();

            potion.Use(wizard, "abc");

            Console.WriteLine();
            Console.WriteLine("===== GAME OVER =====");

            Console.ReadKey();
        }
    }
}
