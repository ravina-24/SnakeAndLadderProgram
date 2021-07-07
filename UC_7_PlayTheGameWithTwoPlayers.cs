using System;

namespace UC_7_PlayTheGameWithTwoPlayers
{
  public class UC_7PlayTheGameWithTwoPlayers
    {
        public const int NoPlay = 0;
        public const int GotLadder = 1;
        public const int SnakeBite = 2;
        public const int WinningP = 100;
        static void Main(string[] args)
        {
            //Variables


            int StartingPositionOfPlayer1 = 1;
            int StartingPositionOfPlayer2 = 1;
            int CurrentPositionofPlayer1 = 0;
            int CurrentPositionofPlayer2 = 0;
            int count = 0;
            //Computation
            while (StartingPositionOfPlayer1 <= WinningP || StartingPositionOfPlayer2 <= WinningP)
            {
                //generating the random dice number for player1


                Random random = new Random();
                int DiceRollForPlayer1 = random.Next(1, 7);
                Console.WriteLine("Player1 got number: " + DiceRollForPlayer1);
                //generating the random Dice number for player2 
                Random random1 = new Random();
                int DiceRollForPlayer2 = random1.Next(1, 7);
                Console.WriteLine("Player2 got number:" + DiceRollForPlayer2);


                //Checking the option for NoPlay , GotLadder and SnakeBite for player1 

                Random random2 = new Random();
                int Check = random2.Next(0, 3);
                Console.WriteLine("Checking the status " + Check);

                //Checking the option for Player2 

                Random random3 = new Random();
                int Check1 = random3.Next(0, 3);

                Console.WriteLine("Checking the status: " + Check1);
                CurrentPositionofPlayer1 = StartingPositionOfPlayer1 + DiceRollForPlayer1;
                CurrentPositionofPlayer2 = StartingPositionOfPlayer2 + DiceRollForPlayer2;
                count++;
                if (CurrentPositionofPlayer1 == 100 || CurrentPositionofPlayer2 == 100)
                {



                    if (CurrentPositionofPlayer1 == 100)
                    {
                        StartingPositionOfPlayer1 = StartingPositionOfPlayer1 - DiceRollForPlayer1;
                        Console.WriteLine("player1 is at " + StartingPositionOfPlayer1);
                        Console.WriteLine(".....................player1 won game ....................");
                        break;
                    }
                    else if (CurrentPositionofPlayer2 == 100)
                    {
                        StartingPositionOfPlayer2 = StartingPositionOfPlayer2 - DiceRollForPlayer2;
                        Console.WriteLine("player1 is at " + StartingPositionOfPlayer2);
                        Console.WriteLine(".................player2 won game ....................");
                        break;
                    }
                }
                else if (CurrentPositionofPlayer2 > 100 || CurrentPositionofPlayer2 > 100)
                {
                    if (CurrentPositionofPlayer1 > 100)
                    {
                        Console.WriteLine("  player 1 do not have any option and you will have to stay in that position: " + DiceRollForPlayer1);
                        Console.WriteLine("Player1 is at position :" + StartingPositionOfPlayer1);

                        continue;
                    }

                    else if (CurrentPositionofPlayer1 > 100)
                    {
                        Console.WriteLine("  player 2 do not have any option and you will have to stay in that position: " + DiceRollForPlayer2);
                        Console.WriteLine("player2 is  at position :" + StartingPositionOfPlayer2);
                        continue;

                    }
                }
                if (Check == NoPlay)
                {
                    if (StartingPositionOfPlayer1 > 100)

                    {
                        Console.WriteLine("player1 don't have any option ");
                        Console.WriteLine("Player1 is at same position");
                    }

                }

                else if (Check == GotLadder)
                {

                    StartingPositionOfPlayer1 = StartingPositionOfPlayer1 + DiceRollForPlayer1;
                    Console.WriteLine("Player1  is moving forward by:" + DiceRollForPlayer1);

                }
                else if (Check == SnakeBite)
                {
                    StartingPositionOfPlayer1 = StartingPositionOfPlayer1 - DiceRollForPlayer1;
                    Console.WriteLine("Player1  is moving backward by:" + DiceRollForPlayer1);

                }
                if (Check1 == NoPlay)
                {
                    if (StartingPositionOfPlayer1 > 100)

                    {
                        Console.WriteLine("player2 don't have any option ");
                        Console.WriteLine("Player2 is at same position");
                    }

                }

                else if (Check1 == GotLadder)
                {


                    StartingPositionOfPlayer2 = StartingPositionOfPlayer2 + DiceRollForPlayer2;
                    Console.WriteLine(" Player2 is moving forward by : " + DiceRollForPlayer2);
                }
                else if (Check1 == SnakeBite)
                {

                    StartingPositionOfPlayer2 = StartingPositionOfPlayer2 - DiceRollForPlayer2;
                    Console.WriteLine(" Player2 is moving backward by : " + DiceRollForPlayer2);
                }
                if (StartingPositionOfPlayer1 <= 0 || StartingPositionOfPlayer2 <= 0)
                {
                    if (CurrentPositionofPlayer1 <= 0)
                    {
                        StartingPositionOfPlayer1 = StartingPositionOfPlayer1 - StartingPositionOfPlayer1;
                        Console.WriteLine("Player1 is now at 0th position and you will have to Restart the game");
                    }
                    else if (CurrentPositionofPlayer1 <= 0)
                    {
                        StartingPositionOfPlayer2 = StartingPositionOfPlayer2 - StartingPositionOfPlayer2;
                        Console.WriteLine("Player2 is now at 0th position and you will have to Restart the game");
                    }
                }

                Console.WriteLine("player1  position is " + StartingPositionOfPlayer1);

                Console.WriteLine("player2 position is " + StartingPositionOfPlayer2);

                Console.WriteLine(" Dice is thrown by player1 :" + count + ":times");

                Console.WriteLine("Dice is thrown by player 2 :" + count + ":times");

            }
        }
    }
}
