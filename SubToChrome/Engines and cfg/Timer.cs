using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubToChrome.Engines_and_cfg
{

    class AccurateTimer
    {
        /*
         * DISCLAIMER:
         *  this following code in this class is not written by me, 
         *  but by Hans Passant(https://social.msdn.microsoft.com/Forums/en-US/6cd5d9e3-e01a-49c4-9976-6c6a2f16ad57/1-millisecond-timer) 
         *  and cleaned by user "John"(https://stackoverflow.com/questions/9228313/most-accurate-timer-in-net).
         *  To be honest, i have no idea what is going on here and i couldnt find any good documentation on the winmm dll either.
         *  the only thing i know is that timers on windows is very unaccurate and super hard to make accurate.
        */
        #region dlls
        private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
        private const int TIME_PERIODIC = 1;
        private const int EVENT_TYPE = TIME_PERIODIC;// + 0x100;  // TIME_KILL_SYNCHRONOUS causes a hang ?!
        [DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeEndPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeSetEvent(int delay, int resolution, TimerEventDel handler, IntPtr user, int eventType);
        [DllImport("winmm.dll")]
        private static extern int timeKillEvent(int id); 
        #endregion
        Action mAction;
        Form mForm;
        private int mTimerId;
        private TimerEventDel mHandler;  // NOTE: declare at class scope so garbage collector doesn't release it!!!

        public AccurateTimer(Form form, Action action, int delay)
        {
            mAction = action;
            mForm = form;
            timeBeginPeriod(1);
            mHandler = new TimerEventDel(TimerCallback);
            mTimerId = timeSetEvent(delay, 0, mHandler, IntPtr.Zero, EVENT_TYPE);
        }

        public void Stop()
        {
            int err = timeKillEvent(mTimerId);
            timeEndPeriod(1);
            System.Threading.Thread.Sleep(100);// Ensure callbacks are drained
        }

        private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2)
        {
            if (mTimerId != 0)
                mForm.BeginInvoke(mAction);
        }


    }
}
