using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotkeys
{
    public class LowLevelKeyboardH
    {
        public List<Keys> KeysToCheck = new List<Keys>();
        //false == not passing the keyboardsignal further down the hook chain
        public bool Leak;
        //represent the method that has something with keys todo
        public event KeyEventHandler keypressed;

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;

        public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

        public struct keyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        //constructor
        public LowLevelKeyboardH(bool shouldleak)
        {
            Leak = shouldleak;
            hook();
        }

        //deconstructor
        ~LowLevelKeyboardH()
        {
            unhook();
        }

        public void unhook()
        {
            UnhookWindowsHookEx(hhook);
        }

        //implementation
        IntPtr hhook = IntPtr.Zero;
        public void hook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, Callback, hInstance, 0);
        }

        public int Callback(int code, int wParam, ref keyboardHookStruct lParam)
        {
            //the hook code?
            if (code >= 0)
            {
                //getting the event information wich will be sent as a inptr and storing it as a key
                Keys k = (Keys)lParam.vkCode;
                //if k = insert (if the event information contained info about insert) -> cont
                if (KeysToCheck.Contains(k))
                {
                    //keyeventargs get all information about the key, like is it pressed, unpressed and so on
                    KeyEventArgs kH = new KeyEventArgs(k);
                    //wPram = the event type, if event is key up AND the keypressed event is inititaled ->
                    if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && keypressed != null)
                    {
                        //raise event
                        keypressed(this, kH);
                    }
                }

            }

            return CallNextHookEx(hhook, code, wParam, ref lParam);
        }




        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);
    }
}
