using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Battle
    {
        Log_writer log = new Log_writer();

      
        public void Main_menu_print()
        {
            DateTime game_initialize_time = DateTime.Now;
            //Welcome menu setup
            Console.WriteLine("######################################");
            Console.WriteLine("###### Welcome to Arena Fighter ######");
            Console.WriteLine("######################################");
            Console.WriteLine("");
            Console.Write("Please enter player name : ");
            log.log_writer("Game_initialize", "Main menu print completed", "expecting - unsername", game_initialize_time);

        }
        public void sub_menu(List<int[]> character_stats, string character_name)
        {
            Console.Clear();
            DateTime character_initialize_time = DateTime.Now;
            Console.WriteLine("########### Player Profile ###########");
            Console.WriteLine(" " + character_name + " ");
            Console.WriteLine("######################################");
            Console.WriteLine("");
            //Strength: 7 , Damage: 3, Health: 5, battle won 0
            Console.Write("Strength : ");
            Console.WriteLine(character_stats[0][0]);
            Console.Write("Health : ");
            Console.WriteLine(character_stats[0][2]);
            Console.Write("Damage level : ");
            Console.WriteLine(character_stats[0][1]);
            Console.Write("Battles won : ");
            Console.WriteLine(character_stats[0][3]);
            Console.WriteLine("");
            Console.WriteLine("Continue to level 1 ? Press B");
            Console.WriteLine("End without fighting ? Press Q");
         

            log.log_writer("Game_initialize", "Main menu print completed", "expecting - unsername", character_initialize_time);


        }
       


    }
}
