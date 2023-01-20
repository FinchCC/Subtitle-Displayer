using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SubToChrome.OldHotkeys
{
    public static class OldOthers
    {
        //message id i think?..
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }

    //global hook that will riderect keyboard events to this form, this makes it so that other programs dont registrer

    public class GlobalHotkey
    {
        /// <summary>
        /// Creating a hook:
        /// First we create a new instance of GlobalHook in form2(ghk) and run it with our wished values, so that the private ints down below
        /// (id, modifers, key, handle) isen't empty and then when we call RegisterKey() we Register a key with the imported RegistrerHotKey
        /// from "user32.dll" where we use the values now stored in the varibles (id, modifers, key, handle..) to create a task that will
        /// send this form2 a signal each time the wished keys have been pressed, go to form2 for the listner
        /// </summary>

        private int id;
        private int modifiers;
        private int key;
        private IntPtr handle;


        public GlobalHotkey(int modify, Keys skey, Form form)
        {
            modifiers = modify;
            key = (int)skey;
            handle = form.Handle;
            id = GetHashCode();
        }

        //registrring the key
        public bool RegisterKey(bool custom, int cust)
        {
            int keyUse = key;
            if (custom == true)
                keyUse = cust;
            return RegisterHotKey(handle, id, modifiers, keyUse);
        }

        public bool UnRegisterKey()
        {
            return UnregisterHotKey(handle, id);
        }
        
        //gives us a uniqe id for the keys so the computers know where to send the signals to
        public override int GetHashCode()
        {
            // ^n equals the end of a sequal - n == ^n = length - n
            return modifiers ^ key ^ handle.ToInt32();
        }


        #region Explanation
        /// <summary>
        /// An application-defined function that processes messages sent to a window. 
        /// The WNDPROC type defines a pointer to this callback function.
        /// 
        /// This function just overwrites the normal shit that happends when a process sends a signal to this program
        /// m.msg = is what id the message that the program has recived and if this id equals to:WM_HOTKEY_MSG_ID(0x0312)
        /// whitch is just a id for keyboard related events => switch what key has been pressed and then //do shit 
        /// </summary> 
        #endregion
        /* Overides the default system message recived handler, used in the old global keyboard hook
         */
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == OldHotkeys.OldOthers.WM_HOTKEY_MSG_ID)
        //    {
        //        Keys test = GetKey(m.LParam);
        //        int testto = (int)test;
        //        switch (test)
        //        {
        //            case Keys.Space:
        //                StartorStop();
        //                break;
        //            case Keys.J:
        //                Backward();
        //                break;
        //            case Keys.L:
        //                Forward();
        //                break;
        //            case Keys.Insert:
        //                MovieMode();
        //                break;
        //        }
        //        Console.WriteLine(testto);
        //        switch (testto)
        //        {
        //            case 0x25:
        //                Backward();
        //                break;
        //            case 0x27:
        //                Forward();
        //                break;
        //        }
        //    }

        //    base.WndProc(ref m);
        //}




        /// <summary>
        /// gets the specific key that got pressed
        /// </summary>
        /// <param name="LParam">m.LParam</param>
        /// <returns>he value of this field depends on the message. 
        /// Use the LParam field to get information that is important for handling the message.</returns>
        //private Keys GetKey(IntPtr LParam)
        //{
        //    return (Keys)((LParam.ToInt32()) >> 16);
        //}


        /* *** Old regestration of global keybaord hook
         * ghk = new OldHotkeys.GlobalHotkey(0, Keys.Space, this);
         */


        //dlls
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}
