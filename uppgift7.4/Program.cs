using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift_7_4
{
    class program
    {
        static void Main(string[] args)
        {
            string[] strängar = new string[] {"hej", "nej", "ja"};
            char tecken = 'j';
            Console.WriteLine(FinnsTecknetIAllaSträngar(strängar, tecken));
        }
        static bool FinnsTecknetIAllaSträngar(string [] strängar,char tecken)
        {
            List<string> strings = new List<string>();
            int y = 0;
            int x = 0;
            for (int i = 0;i > strängar.Length;i++)
            {
                y++;
                strings.Add(strängar[i]);
                if (strängar[i].Contains(tecken))
                {
                    x++;
                }
            }
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
