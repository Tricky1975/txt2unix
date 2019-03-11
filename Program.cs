// Lic:
// txt2unix
// Converts text files to unix
// 
// 
// 
// (c) Jeroen P. Broks, 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
// Please note that some references to data like pictures or audio, do not automatically
// fall under this licenses. Mostly this is noted in the respective files.
// 
// Version: 19.03.11
// EndLic

using System;
using TrickyUnits;

namespace txt2unix
{
    class Program        
    {
        static void E(string e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(e);
        }
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("txt2unix - Coded by Jeroen P. Broks");
                Console.WriteLine("\n\tUsage: txt2unix <text-files>");
                Console.WriteLine("\n\nWarning this tool is very very simplistic and although it does try to distiguish text files from binary files, there is no 100% protection, and using it on binary files can have very funny outcomes!");
            } else {
                foreach (string fl in args) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Processing: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{fl} ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("r\b");
                    string s = QuickStream.LoadString(fl);
                    Console.Write("p\b");
                    if (s.IndexOf((char)26) >= 0)
                        E("Binary file! Can't process!");
                    else {
                        s = s.Replace("\r\n", "\n");
                        Console.Write("w\b");
                        QuickStream.SaveString(fl, s);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ok");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }        
    }
}
