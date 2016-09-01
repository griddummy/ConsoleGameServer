using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameServer
{
    public class Log
    {
        public enum Type { Warning, Debug, Fail}
        static readonly Log m_instance = new Log();
        
        static Log()
        {

        }

        private Log()
        {

        }

        public static Log instance
        {
            get
            {
                return m_instance;
            }            
        }

        public void WriteLine(string message)
        {
            WriteLine(message, Type.Debug);
        }

        public void WriteLine(string message, Type type)
        {

            if(type == Type.Fail)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(type == Type.Warning)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}