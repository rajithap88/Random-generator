/*You are playing a stone game with one of your friends. There are N number of 
 * stones in a bag, each time one of you take turns to take out 1 to 3 stones. 
 * The player who takes out the last stone will be the winner. In this case you
 * will be the first player to remove the stone(s)(Player 1).
 * 
 * Write a method to determine whether you can win the game given the number of 
 * stones in the bag. Print false if you cannot win the game, otherwise print any
 * one set of moves where you are winning the game. Array should contain moves by
 * both the players.
 * Input: 4
 * Output: false
 * Explanation: As there are 4 stones in the bag, you will never win the game. 
 * No matter 1,2 or 3 stones you take out, the last stone will always be removed by   * your friend.
 * Input: 5
  * Output: [1,1,3]   or [1,2,2] or [1,3,1]…..1st plyer wins
            [2,1,2] or [2,2,1] or [3,2,0]…….2nd or 1st player wins 
	      [3,1,1] [3,2,0]…. 2nd or 1st player wins
  * Player 1 picks up 1 stone then player 2 picks up 1 or 2 or 3 stones and the  
  * remaining stones are picked up by player 1.
  * Explanation: As there are 5 stones in the bag, you take out one stone.
  * As there are 4 stones in the bag and it’s your friend’s turn. He will never win 
  * the game because no matter 1,2 or 3 stones he takes out, you will the one to take 
  * out the last stone.
  * 
  * returns      : N/A
  * return type  : void
  */

using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            int res;

            Console.WriteLine("Enter total number of stones available: ");
            val = Console.ReadLine();

            // convert to integer
            res = Convert.ToInt32(val);
            if (res == 1)
            {
                Console.WriteLine("Player1 is winner with moves [1,0]");
            }
            else if (res == 2)
            {
                Random rnd = new Random();
                int stone = rnd.Next(1, 2);
                int n = stone;
                Console.WriteLine(stone);
                if (n == 2)
                {
                    Console.WriteLine("Player1 is winner with moves [2,0]");
                }
                else
                {
                    Console.WriteLine("Player2 is winner ");
                }
            }

            else
            {
                bool stopProgram = false;
                int n1 = res;
                int n = 0;
                int player1 = 0;
                int stone4 = 0;
                int stone5 = 0;
                ArrayList array = new ArrayList();
                //int[] array = new int[25];
                int a = 0;
                while ((n1 > 0) && (stopProgram == false))
                {

                    if (n1 >= 3)
                    {
                        Random rnd4 = new Random();
                        stone4 = rnd4.Next(1, 3);
                        n = ((n1) - (stone4));

                        Console.WriteLine("Number of stones picked by player1:" + stone4);
                        Console.WriteLine("Number of remaining stones after picked by player1:" + n);

                        n1 = n;
                        player1 = 1;
                        array.Add(stone4);
                        a++;
                        if(n==0)
                        {
                            stopProgram = true;
                        }
                    }
                    else if (n1 == 2)
                    {
                        Random rnd4 = new Random();
                        stone4 = rnd4.Next(1, 2);
                        n = ((n1) - (stone4));

                        Console.WriteLine("Number of stones picked by player1:" + stone4);
                        Console.WriteLine("Number of remaining stones after picked by player1:" + n);

                        n1 = n;
                        player1 = 1;
                        //array[a] = stone4;
                        array.Add(stone4);
                        a++;
                        if (n == 0)
                        {
                            stopProgram = true;
                        }
                    }
                    else if (n1 == 1)
                    {
                        
                        stone4 = 1;
                        n = 0;

                        Console.WriteLine("Number of stones picked by player1:" + stone4);
                        Console.WriteLine("Number of remaining stones after picked by player1:" + n);

                        
                        player1 = 1;
                        // array[a] = 1;
                        array.Add(1);
                        stopProgram = true;

                    }

                    if (n >= 3)
                    {

                        Random rnd5 = new Random();

                        stone5 = rnd5.Next(1, 3);
                        Console.WriteLine("Number of stones picked by player2:" + stone5);
                        int n2 = ((n) - (stone5));

                        Console.WriteLine("Number of remaining stones after picked by player2:" + n2);
                        n1 = n2;
                        player1 = 0;
                        //array[a] = stone5;
                        array.Add(stone5);
                        a++;
                        if (n2 == 0)
                        {
                            stopProgram = true;
                        }
                    }
                   else if (n == 2)
                    {

                        Random rnd6 = new Random();

                        stone5 = rnd6.Next(1, 2);
                        Console.WriteLine("Number of stones picked by player2:" + stone5);
                        int n2 = ((n) - (stone5));

                        Console.WriteLine("Number of remaining stones after picked by player2:" + n2);
                        n1 = n2;
                        player1 = 0;
                        // array[a] = stone5;
                        array.Add(stone5);
                        a++;
                        if (n2 == 0)
                        {
                            stopProgram = true;
                        }
                    }
                    else if (n == 1)
                    {

                        //Random rnd5 = new Random();

                        stone5 = 1;
                        Console.WriteLine("Number of stones picked by player2:" + stone5);
                        //int n2 = ((n) - (stone5));

                        //Console.WriteLine("Number of remaining stones after picked by player2:" + n2);
                        n1 = 0;
                        player1 = 0;
                        //array[a] = 1;
                        array.Add(1);
                        stopProgram = true;
                    }

                }
                


                if (player1 == 1)
                {
                   // Console.Write(array);
                    //Console.Write("[" + array + "]");
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (i == 0)
                        {
                            //object o = array[i];
                            Console.Write("[" + array[i] + ",");
                        }
                        else if (i == (array.Count-1))
                        {
                            Console.Write(array[i] + "]");
                        }
                        else 
                        {
                            Console.Write(array[i] + ",");
                        }

                    }
                    /* for (int i = 0; i < array.Length; i++)
                     {
                         if (array[i] != 0)
                         {
                             //int b = i;
                             if (i == 0)
                             {
                                 Console.Write("[" + array[i] + ",");
                             }
                             else if (array[i+1] == 0)
                             {
                                 Console.Write(array[i] + "]");
                             }
                             else
                             {
                                 Console.Write(array[i] + ",");
                             }
                         }
                     }*/
                }
                else
                {
                    Console.WriteLine("Player2 is winner");

                }

            }




        }
    }
}



























