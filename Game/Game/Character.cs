using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Character
    {
        public string CharacterName { get; set; }
        public int Life { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public int Mana { get; set; }
        public int FightPower { get; set; }

        public int WorkNow()
        {

            return Money++;
            
        }

        public int RestNow()
        {

            return Mana++;
        }

        public int SleepNow()
        {

            return Health++;
        }

        public override string ToString()
        {

            string sep = ": ";
            return CharacterName + "\n" + "\t" + "Health" + sep + Health
                + "\n" + "\t" + "Money" + sep + Money
                + "\n" + "\t" + "Mana" + sep + Mana
                + "\n" + "\t" + "Fight Power (Mana + Health)" + sep + FightPower
                + "\n" + "\t" + "Life (Health + Mana + Money )" + sep + Life;
        }

        public Character()
        { }

        public Character(string characterName, int health, int money, int mana)
        {
            CharacterName = characterName;
            Health = health;
            Money = money;
            Mana = mana;
            FightPower = health + mana;
            Life = health + money + mana;
        }

        
    }


}
