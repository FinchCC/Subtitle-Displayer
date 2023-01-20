using System;
using System.Runtime.InteropServices;
using SubToChrome.Other;
using SubToChrome;

namespace NewHotkeys
{
    public static class NewHotkey
    {
        public static bool pressedbool { get; set; }
        public static bool checkforpress(int key)
        {
            short keystate = GetAsyncKeyState(key);

            //check if pressed
            bool ispressed = ((keystate >> 15) & 0x0001) == 0x0001;

            //check if been pressed since last call
            bool hasbeenpressed = ((keystate >> 0) & 0x0001) == 0x0001;

            if(pressedbool == false)
            {
                if (ispressed == true || hasbeenpressed == true)
                {
                    pressedbool = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                pressedbool = false;
                return false;
            }
        }

        public static int KeyUpdate(out int sum)
        {
            int add = 15000;
            int total = 0;
            if (checkforpress(CleanShit.KeysPublic[0]) == true)
                MovieMode();
            if (checkforpress(CleanShit.KeysPublic[1]) == true)
                total += add;
            if (checkforpress(CleanShit.KeysPublic[2]) == true)
            {
                if (total > add)
                    total = -add;
                else
                    total = 0;
            }
                return sum = total;
        }

        public static bool shouldplay()
        {
            throw new System.NotImplementedException();
        }
        
        private static void MovieMode()
        {
            if (Settings.moviemode == true)
            {
                Settings.moviemode = false;
                Console.WriteLine("moviemode off");
            }
            else
            {
                Settings.moviemode = true;
                Console.WriteLine("moviemode on");
            }
        }


        //dll
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
    }


}
