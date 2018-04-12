using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Character
    {
        public List<int[]> battle_charactor_setup()
        {
            int[] start_stats = { 0, 0, 0, 0 };
            int[] play_stats = { 0, 0, 0, 0 };
            List<int[]> game_setup = new List<int[]>();
            //Strength: 7 , Damage: 3, Health: 5, battle won 0
            Round gen_ran = new Round();
            start_stats[0] = gen_ran.DiceRoll(1,6);
            start_stats[1] = gen_ran.DiceRoll(1,3);
            start_stats[2] = gen_ran.DiceRoll(5,6);
            start_stats[3] = 0;

            game_setup.Add(start_stats);
            game_setup.Add(play_stats);
            return game_setup;
        }
    }
}
