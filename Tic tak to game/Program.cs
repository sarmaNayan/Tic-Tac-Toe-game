using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tak_to_game
{
    internal class Program
    {  
        public static char[,] bord = new char[3, 3]
        {
        {'1','2','3'}, //0
        {'4','5','6'}, //1
        {'7','8','9'}  //2
        
        };
        public static char flag = 'f';
        public static char wflag = 'f';
        public static char draw_flag = 't';

        static void Main(string[] args)
        {
            int usr_input = 0;
            int player = 2;

            do
            {
               
                setfild();
               

                if (player == 2)
                {
                    player = 1;
                }
            else if(player == 1)
                {
                    player = 2;
                }
               


                do
                {
                    
                    Console.WriteLine("player {0} term: ",player);
                    try
                    {
                        usr_input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Try again!!!!\n");
                    }

                    chack_input(usr_input, player);

                    winer();

                } while (flag != 't') ;

                



            } while (wflag != 't');

            Console.ReadKey();

        }
        static void setfild()
        {
            Console.Clear();
            Console.WriteLine("        |    |                                         ");
            Console.WriteLine("      {0} |   {1}|  {2}  ", bord[0, 0], bord[0, 1], bord[0,2]);
            Console.WriteLine("    ____|____|____                                      ");
            Console.WriteLine("        |    |                                         ");
            Console.WriteLine("      {0} |   {1}|  {2}  ", bord[1, 0], bord[1, 1], bord[1, 2]);
            Console.WriteLine("    ____|____|____                                        ");
            Console.WriteLine("        |    |                                         ");
            Console.WriteLine("      {0} |   {1}|  {2}  ", bord[2, 0], bord[2, 1], bord[2, 2]);


        }
        static void input(int in_player,int in_userinput)
        {
         switch(in_player)
            {
                case 1:
                    {
                        switch(in_userinput)
                        {
                            case 1: bord[0, 0] = 'X'; break;
                            case 2: bord[0, 1] = 'X'; break;
                            case 3: bord[0, 2] = 'X'; break;
                            case 4: bord[1, 0] = 'X'; break;
                            case 5: bord[1, 1] = 'X'; break;
                            case 6: bord[1, 2] = 'X'; break;
                            case 7: bord[2, 0] = 'X'; break;
                            case 8: bord[2, 1] = 'X'; break;
                            case 9: bord[2, 2] = 'X'; break;

                        }

                        break;
                    }
                    case 2:
                    {
                        switch (in_userinput)
                        {
                            case 1: bord[0, 0] = 'O'; break;
                            case 2: bord[0, 1] = 'O'; break;
                            case 3: bord[0, 2] = 'O'; break;
                            case 4: bord[1, 0] = 'O'; break;
                            case 5: bord[1, 1] = 'O'; break;
                            case 6: bord[1, 2] = 'O'; break;
                            case 7: bord[2, 0] = 'O'; break;
                            case 8: bord[2, 1] = 'O'; break;
                            case 9: bord[2, 2] = 'O'; break;

                        }

                        break;
                    }

            }

        }
        static char chack_input(int user_input,int player)
        {
            if(user_input == 1)
            {
                if (bord[0,0]!='X' && bord[0,0]!='O')
                {
                    input(player, user_input);
                   return flag = 't';
                }

            }
          else  if (user_input == 2)
            {
                if (bord[0, 1] != 'X' && bord[0, 1] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
          else  if (user_input == 3)
            {
                if (bord[0, 2] != 'X' && bord[0, 2] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
          else  if (user_input == 4)
            {
                if (bord[1, 0] != 'X' && bord[1, 0] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
          else  if (user_input == 5)
            {
                if (bord[1, 1] != 'X' && bord[1, 1] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
          else  if (user_input == 6)
            {
                if (bord[1, 2] != 'X' && bord[1, 2] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
           else if (user_input == 7)
            {
                if (bord[2, 0] != 'X' && bord[2, 0] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
          else  if (user_input == 8)
            {
                if (bord[2, 1] != 'X' && bord[2, 1] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }
         else   if (user_input == 9)
            {
                if (bord[2, 2] != 'X' && bord[2, 2] != 'O')
                {
                    input(player, user_input);
                    return flag = 't';
                }

            }

            return flag = 'f'; ;
        }

        static void winer()
        {
            if (bord[0, 0] == 'X' && bord[1, 1] == 'X' && bord[2, 2] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';

            }
         else if (bord[0, 2] == 'X' && bord[1, 1] == 'X' && bord[2, 0] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';

            }

            else if (bord[0, 0] == 'X' && bord[1, 0] == 'X' && bord[2, 0] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 1] == 'X' && bord[1, 1] == 'X' && bord[2, 1] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 2] == 'X' && bord[1, 2] == 'X' && bord[2, 2] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 0] == 'X' && bord[0, 1] == 'X' && bord[0, 2] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[1, 0] == 'X' && bord[1, 1] == 'X' && bord[1, 2] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[2, 0] == 'X' && bord[2, 1] == 'X' && bord[2, 2] == 'X')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            } // player 1 end

            if (bord[0, 0] == 'O' && bord[1, 1] == 'O' && bord[2, 2] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 2] == 'O' && bord[1, 1] == 'O' && bord[2, 0] == 'O')
            {
                Console.WriteLine("Player 1 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';

            }
            else if (bord[0, 0] == 'O' && bord[1, 0] == 'O' && bord[2, 0] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 1] == 'O' && bord[1, 1] == 'O' && bord[2, 1] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 2] == 'O' && bord[1, 2] == 'O' && bord[2, 2] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[0, 0] == 'O' && bord[0, 1] == 'O' && bord[0, 2] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[1, 0] == 'O' && bord[1, 1] == 'O' && bord[1, 2] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            else if (bord[2, 0] == 'O' && bord[2, 1] == 'O' && bord[2, 2] == 'O')
            {
                Console.WriteLine("Player 2 wine the game (:");
                wflag = 't';
                flag = 't';
                draw_flag = 'f';
            }
            // Draw
            else if ((bord[0,0]=='X' || bord[0,0]=='O') && (bord[0, 1] == 'X' || bord[0, 1] == 'O') && (bord[0, 2] == 'X' || bord[0, 2] == 'O') && (bord[1, 0] == 'X' || bord[1, 0] == 'O') && (bord[1,1]=='X' || bord[1,1]=='O') && (bord[1, 2] == 'X' || bord[1, 2] == 'O') && (bord[2, 0] == 'X' || bord[2, 0] == 'O') && (bord[2, 1] == 'X' || bord[2, 1] == 'O') && (bord[2, 2] == 'X' || bord[2, 2] == 'O') && draw_flag =='t')
            {
                Console.WriteLine("No one wine the game!!");
                wflag = 't';
                flag = 't';

            }



        }



    }
}
