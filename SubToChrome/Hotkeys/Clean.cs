using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SubToChrome.OldHotkeys;

namespace SubToChrome.Other
{
    public static class CleanShit
    {
        //keys in int
        public static readonly List<int> KeysPublic = new List<int>()
        {
            (int)Keys.Insert,
            0x25,
            0x27,
            (int)Keys.Space
        };


        //old regestration of hotkeys
        public static void RegistrerKyes(GlobalHotkey hk)
        {
            if(Settings.HotkeysEnabled == true)
            {
                foreach (var item in KeysPublic)
                {
                    if (hk.RegisterKey(true, item) == true)
                        Console.WriteLine("Sucsessfully hooked key: {0}", item);
                    else
                        Console.WriteLine("Key: {0} failed :(", item);
                }
            }
        }

    }
}
