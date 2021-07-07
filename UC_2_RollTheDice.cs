using System;

namespace UC_2_RolltheDice
{
    class UC_2_RollTheDice
    {
        static void Main(string[] args)
        {
            //variable
            int player = 1;
            int StartingP = 0;

            //computation

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            Console.WriteLine("No. of Player " + player);

            Console.WriteLine("You got number :" + DiceRoll);
            Console.ReadLine();
        }
    }
}
