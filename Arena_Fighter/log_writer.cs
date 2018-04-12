using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Log_writer
    {
        public bool log_writer(string action, string log_msg, string player_name, DateTime action_time)
        {
            StreamWriter log_writer = File.AppendText(player_name + "-battle-log.log");


            try
            {
                log_writer.Write(action + " > ");
                log_writer.Write(" {0},{1}", action_time.ToLongTimeString(), action_time.ToLongDateString());
                log_writer.WriteLine(" >> " + log_msg);
                log_writer.Close();
                return true;
            }
            catch (Exception)
            {
                //return false;
                throw;

            }


        }
    }
}
