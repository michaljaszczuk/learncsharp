using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.AddCharactersToList();
            battlefield.PrintWelcome();
            battlefield.PrintStats(battlefield.CharactersList);
            battlefield.BattleNow();
            Character characterUpdate = new Character();
            characterUpdate.RestNow();
            battlefield.PrintStats(battlefield.CharactersList);
            characterUpdate.SleepNow();
            battlefield.PrintStats(battlefield.CharactersList);
            characterUpdate.WorkNow();
            battlefield.PrintStats(battlefield.CharactersList);

        }
    }
}
