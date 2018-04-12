using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Round
    {
        public int DiceRoll(int range_strat, int range_stop)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int rand_number = rnd.Next(range_stop,range_stop);
            return rand_number;
        }

        public List<List<int[]>> Play_level(List<int[]> player, List<int[]> enemies)
        {

            //int player_Strength = player[1][0];
            //int player_Damage = player[1][1];
            //int player_Health = player[1][2];
            //int player_battle_won = player[1][3];

            //int enemie_Strength = enemies[1][0];
            //int enemie_Damage = enemies[1][1];
            //int enemie_Health = enemies[1][2];
            //int enemie_battle_won = enemies[1][3];
            int rand_strength = DiceRoll(1,6);
            int player_new_strength = player[1][0] + rand_strength;
            int enemie_new_strength = enemies[1][0] + rand_strength;

            if(player_new_strength > enemie_new_strength)
            {
                if (enemies[1][2] > player[1][1])
                {
                    enemies[1][2] = enemies[1][2] - player[1][1];
                }
                else if(enemies[1][2] == player[1][1] || enemies[1][2] < player[1][1])
                {
                    enemies[1][2] = 0;
                }
            }

            List<List<int[]>> player_enemie = new List<List<int[]>>();
            player_enemie.Add(player);
            player_enemie.Add(enemies);
            return player_enemie;
        }

    }
}
