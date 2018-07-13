using System;
using System.IO;
using System.Reflection;

namespace DiscordBot.Common
{
    public class TreeOfSaviorHelper
    {
        private static string _data = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data/tosdata.json");
        public static string GetCommandValue(string cmd)
        {
            using (StreamReader r = new StreamReader(_data))
            {
                var json = r.ReadToEnd();
                var json_des =  JsonHelper.Deserialize(json);
                foreach(var items in (dynamic)json_des) {
                    if (items.Key == cmd.TrimStart())
                    {   
                        return items.Value;
                    }
                }
            }
            return "**[Popolion Help]**\r\n  ```md\r\n  I'm sorry I cannot help you with that please try typing @Popolion<space>help\r\n  ";
        }

        public static string TrimCommandMessage(string msg, string trimVal)
        {
            return msg.Substring(msg.IndexOf(" "));
        }
    }

    public class TreeOfSaviorData 
    {
        public string Help { get; set; }
    }
}