using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Battlefield
    {
        readonly Character wizard = new Character("wizard", 2, 2, 4);
        readonly Character warrior = new Character("warrior", 2, 1, 3);
        readonly Character elf = new Character("elf", 3, 2, 1);

        
        public List<Character> CharactersList = new List<Character>();
        public List<Character> battleMembers = new List<Character>();

        public void AddCharactersToList()
        {

            CharactersList.Add(wizard);
            CharactersList.Add(warrior);
            CharactersList.Add(elf);
        }


        public void PrintWelcome()

        {

            Console.WriteLine("\t \t \tWelcome to THE GAME!");
            Console.WriteLine("\t \t \tContestants: ");
        }
        public List<Character> PrintStats(List<Character> CharactersList)
        {
            CharactersList.ForEach(Console.WriteLine);

            return CharactersList;
            

        }

        /*string characterName, int health, int money, int mana*/
        public void BattleNow()
        {

            battleMembers.Add(wizard);
            battleMembers.Add(warrior);

            Console.WriteLine("(press any key...)");
            Console.ReadLine();

            Console.WriteLine("\t \t B  A  T  T  L  E  !");
            Console.WriteLine("\t \t {0} VS {1}", wizard.CharacterName, warrior.CharacterName);
            Console.Write("Wizard:  Fight Power: {0}, Life: {1} ", wizard.FightPower, wizard.Life);
            Console.Write(" || Warrior:  Fight Power: {0}, Life: {1}", warrior.FightPower, warrior.Life);
            Console.WriteLine();
            Console.WriteLine();

            if (wizard.FightPower > warrior.FightPower)
            {
                wizard.Mana += warrior.Mana;
                wizard.Health += warrior.Health;
                wizard.Money += warrior.Money;
                wizard.FightPower += warrior.FightPower;
                wizard.Life += warrior.Life;

                warrior.Mana -= warrior.Mana - 1;
                warrior.Health -= warrior.Health - 1;
                warrior.Money -= warrior.Money - 1;
                warrior.FightPower = warrior.Health + warrior.Mana;
                warrior.Life = warrior.Health + warrior.Mana + warrior.Money;



                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wizard won!");
                Console.ResetColor();
                Console.WriteLine("(press any key...)");
                Console.ReadLine();
                Console.WriteLine("WIZARD: Fight power after battle: {0}", wizard.FightPower);
                Console.WriteLine("WIZARD: Life level after battle: {0}", wizard.Life);
                Console.WriteLine("(press any key...)");
                Console.ReadLine();
                Console.WriteLine("Stats after battle: ");
                PrintStats(CharactersList);

            }
            else if (wizard.FightPower < warrior.FightPower)
            {
                
                
                warrior.Mana += wizard.Mana;
                warrior.Health += wizard.Health;
                warrior.Money += wizard.Money;
                warrior.FightPower += wizard.FightPower;
                warrior.Life += wizard.Life;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wizard lost!");
                Console.ResetColor();
                PrintStats(CharactersList);
            }

            else 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Truce!");
                Console.ResetColor();
                PrintStats(CharactersList);

            }

            

        }
        
        
	

	}
    
    
    
}
