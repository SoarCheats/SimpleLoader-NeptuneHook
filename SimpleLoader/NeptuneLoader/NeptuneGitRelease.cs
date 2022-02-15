using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeptuneLoader
{
    internal class Loader
    {

















        // Compatible Loader For Some Games you Might want to cheat on or sum shit idk but im using this for a cheat menu i will be creating so if you want to use this to go for it :)
        // You Can Change Name of the shit i will release a easier version soon :)
        // yes i did code all this shit just for it to be released on github lmao
        // have fun :)
        // skid all you want cause i dont give 1 shit
      








        /*                                                                                                   
________  ___  _________  ___  ___  ___  ___  ________      ________  ________  _____ ______           ___ ________  ________  ________  ________  ________  ___  ___  _______   ________  _________  ________      
|\   ____\|\  \|\___   ___\\  \|\  \|\  \|\  \|\   __  \    |\   ____\|\   __  \|\   _ \  _   \        /  /|\   ____\|\   __  \|\   __  \|\   __  \|\   ____\|\  \|\  \|\  ___ \ |\   __  \|\___   ___\\   ____\     
\ \  \___|\ \  \|___ \  \_\ \  \\\  \ \  \\\  \ \  \|\ /_   \ \  \___|\ \  \|\  \ \  \\\__\ \  \      /  //\ \  \___|\ \  \|\  \ \  \|\  \ \  \|\  \ \  \___|\ \  \\\  \ \   __/|\ \  \|\  \|___ \  \_\ \  \___|_    
\ \  \  __\ \  \   \ \  \ \ \   __  \ \  \\\  \ \   __  \   \ \  \    \ \  \\\  \ \  \\|__| \  \    /  //  \ \_____  \ \  \\\  \ \   __  \ \   _  _\ \  \    \ \   __  \ \  \_|/_\ \   __  \   \ \  \ \ \_____  \   
 \ \  \|\  \ \  \   \ \  \ \ \  \ \  \ \  \\\  \ \  \|\  \ __\ \  \____\ \  \\\  \ \  \    \ \  \  /  //    \|____|\  \ \  \\\  \ \  \ \  \ \  \\  \\ \  \____\ \  \ \  \ \  \_|\ \ \  \ \  \   \ \  \ \|____|\  \  
  \ \_______\ \__\   \ \__\ \ \__\ \__\ \_______\ \_______\\__\ \_______\ \_______\ \__\    \ \__\/_ //       ____\_\  \ \_______\ \__\ \__\ \__\\ _\\ \_______\ \__\ \__\ \_______\ \__\ \__\   \ \__\  ____\_\  \ 
   \|_______|\|__|    \|__|  \|__|\|__|\|_______|\|_______\|__|\|_______|\|_______|\|__|     \|__|__|/       |\_________\|_______|\|__|\|__|\|__|\|__|\|_______|\|__|\|__|\|_______|\|__|\|__|    \|__| |\_________\
                                                                                                             \|_________|                                                                               \|_________|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
           */


        // ignore
        const int SWP_NOSIZE = 0x0001;


        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);







        //main begining menu edit if you want
        static void loader()
        {
            Thread title = new Thread(neptunetitle) { IsBackground = true };
            title.Start();
            Console.SetWindowSize(40, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            string s = "[Neptune Hook Beta]";
            WindowUtility.MoveWindowToCenter();
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            string qut = "Version - 1.0.0";
            Console.SetCursorPosition((Console.WindowWidth - qut.Length) / 2, Console.CursorTop);
            Console.WriteLine(qut);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asd = "Developed By SoarCheats#2848 :)";
            Console.SetCursorPosition((Console.WindowWidth - asd.Length) / 2, Console.CursorTop);
            Console.WriteLine(asd);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string asds = "Select a Compatible Game.";
            
            Console.SetCursorPosition((Console.WindowWidth - asds.Length) / 2, Console.CursorTop);
            Console.WriteLine(asds);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("1.");
            Console.ResetColor();
            Console.WriteLine("Among Us");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ResetColor();
            Console.WriteLine("Assault Cube");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ResetColor();
            Console.WriteLine("Crab Game");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("->");
            var input = Console.ReadLine();
            if (input == "1")
            {
                AmongUs();
            }
            if (input == "2")
            {
                AssaultCube();

            }
            if (input == "3")
            {
                CrabGame();
            }
        }









        // edit if you want but i would just leave this alone :-)
        static void Main(string[] args)
        {
            loader();
        }










        // use this to keep your console app open until the app your cheating or using is exitied out off, afterwards it will end this console and the process / injector / external menu your using :)
        static void procendloop(string procname, string proctoend)
        {
            Process[] proc = Process.GetProcessesByName(procname);
            if (proc.Length > 0)
            {
                procendloop(procname,proctoend);
            }
            else
            {
                Process[] kill = Process.GetProcessesByName(proctoend);
                kill[0].Kill();
            }
        }











        // loops until proc is found then returns
        // skid if you want idgaf
        static void LoopProcess(string procname)
        {
            Process[] proc = Process.GetProcessesByName(procname);
            if(proc.Length > 0)
            {
                return;
            }
            else
            {
                if (proc.Length > 0)
                {
                    return;
                }
                else
                {
                    LoopProcess(procname);
                }
            }
        }










        //preset variable 1
        static void AmongUs()
        {
            // opens proc when au is found
            Console.Clear();
            WindowUtility.MoveWindowToCenter();
            Console.SetWindowSize(40, 13);
            Console.ForegroundColor = ConsoleColor.Red;
            //center text 
            string s = "[Neptune Hook Beta]"; 
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            string qut = "Version - 1.0.0";
            Console.SetCursorPosition((Console.WindowWidth - qut.Length) / 2, Console.CursorTop);
            Console.WriteLine(qut);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asd = "Developed By SoarCheats#2848 :)";
            Console.SetCursorPosition((Console.WindowWidth - asd.Length) / 2, Console.CursorTop);
            Console.WriteLine(asd);
            Console.ForegroundColor = ConsoleColor.Yellow;
            // center text
            string asds = "Selected: Among Us";
            Console.SetCursorPosition((Console.WindowWidth - asds.Length) / 2, Console.CursorTop);
            Console.WriteLine(asds);
            Console.WriteLine();

            LoopProcess("Among Us"); // Will Constantly Loop Until Process Is Found Then Will Return and continue this thread :) DONT PUT EXE AT THE END >:(
            Console.ResetColor();
            Console.WriteLine("[+] Bypassed Anti Cheat");
            Console.WriteLine("[+] Speed Detection Disabled");
            Console.WriteLine("[+] Float Detection Disabled");
            Console.WriteLine("[+] Secure GUI Loaded");
            Console.WriteLine();
            Thread.Sleep(3000);
            // i think i banged your mother ;)
            Console.WriteLine("[+] Neptune Hook Loaded");
            Process.Start(@"C:\Windows\AmongCheats.exe");
            //might want to add a manifest because it being in windows this proc dosnt have the right privlages ;)
            procendloop("Among Us", "AmongCheats"); // 1212: The App You Want To Watch to see if it ends - 1414 : The app to exit out of if the 1212 app is not open :)
        }














        //preset variable 2
        static void AssaultCube()
        {
            Console.Clear();
            WindowUtility.MoveWindowToCenter();
            Console.SetWindowSize(40, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            string s = "[Neptune Hook Beta]";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            string qut = "Version - 1.0.0";
            Console.SetCursorPosition((Console.WindowWidth - qut.Length) / 2, Console.CursorTop);
            Console.WriteLine(qut);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asd = "Developed By SoarCheats#2848 :)";
            Console.SetCursorPosition((Console.WindowWidth - asd.Length) / 2, Console.CursorTop);
            Console.WriteLine(asd);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string asds = "Selected: Assualt Cube";
            Console.SetCursorPosition((Console.WindowWidth - asds.Length) / 2, Console.CursorTop);
            Console.WriteLine(asds);
            Thread.Sleep(5000);
        }










        // preset variable 3
        static void CrabGame()
        {
            Console.Clear();
            WindowUtility.MoveWindowToCenter();
            Console.SetWindowSize(40, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            string s = "[Neptune Hook Beta]";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            string qut = "Version - 1.0.0";
            Console.SetCursorPosition((Console.WindowWidth - qut.Length) / 2, Console.CursorTop);
            Console.WriteLine(qut);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asd = "Developed By SoarCheats#2848 :)";
            Console.SetCursorPosition((Console.WindowWidth - asd.Length) / 2, Console.CursorTop);
            Console.WriteLine(asd);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string asds = "Selected: Crab Game";
            Console.SetCursorPosition((Console.WindowWidth - asds.Length) / 2, Console.CursorTop);
            Console.WriteLine(asds);
            Thread.Sleep(5000);
        }
        
        static void neptunetitle()
        {
            Console.Title = "N";
            Thread.Sleep(100);
            Console.Title = "Ne";
            Thread.Sleep(100);
            Console.Title = "Nep";
            Thread.Sleep(100);
            Console.Title = "Nept";
            Thread.Sleep(100);
            Console.Title = "Neptu";
            Thread.Sleep(100);
            Console.Title = "Neptun";
            Thread.Sleep(100);
            Console.Title = "Neptune";
            Thread.Sleep(100);
            Console.Title = "Neptune-";
            Thread.Sleep(100);
            Console.Title = "Neptune-L";
            Thread.Sleep(100);
            Console.Title = "Neptune-Lo";
            Thread.Sleep(100);
            Console.Title = "Neptune-Loa";
            Thread.Sleep(100);
            Console.Title = "Neptune-Load";
            Thread.Sleep(100);
            Console.Title = "Neptune-Loade";
            Thread.Sleep(100);
            Console.Title = "Neptune-Loader";
            Thread.Sleep(5000);
            Console.Title = "Neptune-Loade";
            Thread.Sleep(100);
            Console.Title = "Neptune-Load";
            Thread.Sleep(100);
            Console.Title = "Neptune-Loa";
            Thread.Sleep(100);
            Console.Title = "Neptune-Lo";
            Thread.Sleep(100);
            Console.Title = "Neptune-L";
            Thread.Sleep(100);
            Console.Title = "Neptune-";
            Thread.Sleep(100);
            Console.Title = "Neptune";
            Thread.Sleep(100);
            Console.Title = "Neptun";
            Thread.Sleep(100);
            Console.Title = "Neptu";
            Thread.Sleep(100);
            Console.Title = "Nept";
            Thread.Sleep(100);
            Console.Title = "Nep";
            Thread.Sleep(100);
            Console.Title = "Ne";
            Thread.Sleep(100);
            Console.Title = "N";
            Thread.Sleep(100);
            Console.Title = "";
            Thread.Sleep(100);
            titleloop();
        }
    }
}
