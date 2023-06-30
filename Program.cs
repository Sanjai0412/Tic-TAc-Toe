using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    class Program
    {
        static char temp;
        static char player;
        static string[] arr = new string[9];
        static void Main(string[] args)
        {
            Put_Value();
            Console.WriteLine("Choose Your Coin (X or O) in Capital :");
            player = char.Parse(Console.ReadLine());
            for(int i=0;i<9;i++)
            {
                showboard(arr);
                //Console.WriteLine();
                Console.WriteLine("Player : "+player);
                Console.WriteLine("Enter the Position : ");
                int pos=int.Parse(Console.ReadLine());
                Input_Data(player, pos);
            
                player=Flip_Player(player);
                Winning_Posiblities(arr);
                if (temp == 'W')
                {
                    Console.Clear();
                    showboard(arr);
                    player = Flip_Player(player);
                    Console.WriteLine("Player '"+player+"' Won the Match..... :)");
                    break;
                }
                else if (i > 8)
                {
                    Console.WriteLine("Match Draw.... :(");
                    break;
                }
                Console.Clear();
            }
        }

        public static void Input_Data(char player, int pos)
        {
            arr[pos] = player.ToString();
        }

        public static void showboard(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("|"+arr[i] + "|\t");
             
            }
        }
        public static void Put_Value()
        {
            for (int i = 0; i < 9; i++)
            {
                arr[i] = i.ToString();
            }
        }
        public static char Flip_Player(char player)
        {
            if (player == 'X')
            {
                player = 'O';
            }
            else if (player == 'O')
            {
                player = 'X';
            }
            return player;
        }
        public static char Winning_Posiblities(string[] arr)
        {
            for(int i=0;i<9;i=i+3)
            {
                if (arr[0] == (arr[i + 1]) && arr[i + 1] == (arr[i + 2]))
                {
                    temp = 'W';
                }
                else if (arr[0] == arr[3] && arr[3] == arr[6])
                {
                    temp = 'W';
                }
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    temp = 'W';
                }
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    temp = 'W';
                }
                else if (arr[0] == arr[4] && arr[4] == arr[8])
                {
                    temp = 'W';
                }
                else if (arr[2] == arr[4] && arr[4] == arr[6])
                {
                    temp = 'W';
                }

            }
            return temp;
        }
       

    }
  
}
