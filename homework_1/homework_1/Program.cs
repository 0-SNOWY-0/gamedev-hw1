using System;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int health = 100;
            string hero = "baby yoda";

            int damaged() {
                return health - 20;
            }
            int playerhp = damaged();

            Console.WriteLine("Player HP after damage is :" + playerhp);

            int boost() {
                return playerhp + 10;
            }

            int player_hp = boost();

            Console.WriteLine("Player HP after boost is :" + player_hp);

            int[] HealthArray = { playerhp, player_hp };

            Console.WriteLine(HealthArray[1]);

            if (playerhp < player_hp) ;

            Console.WriteLine("80 is less than 90");

        }
    }
}
