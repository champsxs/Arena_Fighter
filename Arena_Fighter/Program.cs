using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon.CSharp.InfoGenerator;


namespace Arena_Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle start_battle = new Battle();
            Character start_chars = new Character();
            List<int[]> player_char = new List<int[]>();
            List<int[]> enemies_char = new List<int[]>();
            player_char = start_chars.battle_charactor_setup();
            enemies_char = start_chars.battle_charactor_setup();

            start_battle.Main_menu_print();
            string player_name = Console.ReadLine();
            //Auto gen enemies fname
            InfoGenerator rand_enmy_name = new InfoGenerator();
            string enemies_name = rand_enmy_name.NextFirstName();
            start_battle.sub_menu(player_char, player_name);
            bool correct_selection = false;
            // string user_menu_select = Console.ReadKey().KeyChar.ToString().ToLower();
            while (false == correct_selection)
            {
                string user_menu_select = Console.ReadKey().KeyChar.ToString().ToLower();

                if ("b" == user_menu_select)
                {
                    console_write("Battle selected");
                    correct_selection = true;
                }
                else if ("q" == user_menu_select)
                {
                    Environment.Exit(0);
                }
                else
                {
                    start_battle.sub_menu(player_char, player_name);
                }
            }
           
            Console.ReadKey();
            
            
            //Helper to console print
            void console_write(string text_to_con, bool new_line = false)
            {
                if (false != new_line)
                {
                    Console.WriteLine(text_to_con);
                }
                else
                {
                    Console.Write(text_to_con);
                }
            }
        }

        
    }
}
