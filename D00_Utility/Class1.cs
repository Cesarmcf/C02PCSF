using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public class Utility
    {
        #region WriteTitle
               
        public static void WriteTitle(string title)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 30));
        }
        #endregion

        #region TerminateConsole
        
        public static void TerminateConsole()
        {

            Console.ReadLine();
            Console.Clear();
        }

        #endregion

    }
}

