using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hotkeys;

namespace SubToChrome
{
    public partial class Form2 : Form
    {
        //llhotkey hook

        //installing the grahpcis to save memory
        Graphics g; Brush myBrush; Font drawfont; int posx; int posy; PointF point; 
        SubToChrome.Engines_and_cfg.AccurateTimer mTimer1;
        //hotkey
        private bool keysRegistred;

        //dll imports inside a region to make it clean
        #region Dll's
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        //signatur import (GetWindowLong) from pinvoke.net
        [DllImport("user32.dll", SetLastError = true)]
        static extern System.Int32 GetWindowLong(IntPtr hWnd, int nIndex);

        #endregion Dll's

        //Public lists:
        #region The 3 diffrent parts of a rnt file and other properties
        public List<int> SubPublicStart { get; set; }
        public List<int> SubPublicTest { get; set; }
        public List<int> SubPublicTestEnd { get; set; }
        public List<int> SubPublicStop { get; set; }
        public List<string> SubPublicText { get; set; }
        public int IntStart { get; set; }
        public int IntStop { get; set; }
        public string CurrentText { get; set; }

        //main float for timer add
        public int MainTimer { get; set; }
        public bool isPlaying { get; set; }
        //main refrencepoint to what text we are on
        #endregion


        public Form2()
        {
            InitializeComponent();
        }
        public void updateInfo()
        {
            // getting the varibles from settings.cs and storing them in local varibles
            SubPublicStart = Settings.SubStartTemp;
            SubPublicStop = Settings.SubStopTemp;
            SubPublicText = Settings.SubTextTemp;
            MainTimer = Settings.IStartPos;
            Console.WriteLine(SubPublicStart.Count());
            Console.WriteLine(SubPublicStop.Count());
        }

        //llhotkey hook
        LowLevelKeyboardH LLHK;
        private void Form2_Load(object sender, EventArgs e)
        {
            #region Visuals
            this.BackColor = Color.Peru;
            this.TransparencyKey = Color.Peru;
            this.TopMost = true;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            Form1 frm = new Form1();

            #endregion Visuals
            //first updating the fonts and pos of the drawing
            updateInfo();
            //then getting the actuall sub information from Settings.cs
            updateSettings();
            //registrering new hotkeys

            //Temp list for debugging
            #region debugging
            /*
            int xy = 1;
            int ty = 0;
            int tt = 9000;
            delay = 0;
            SubPublicTest = new List<int>();
            SubPublicTestEnd = new List<int>();
            SubPublicTest.Add(tt);
            SubPublicTestEnd.Add(9500);
            for (int i = 0; i < 50; i++)
            {
                if (ty + 1 == xy)
                {
                    SubPublicTest.Add(xy * 10000);
                    ty++;
                }
                    
                else
                {
                    SubPublicTestEnd.Add(xy * 10000);
                    xy++;
                }
            }
            Console.WriteLine(SubPublicTest.Count());
            Console.WriteLine(SubPublicTestEnd.Count());
            IntStart = 0;
            

            foreach (var item in SubPublicText)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            //doing the low level keyboard hook in main form to prevent garbage collecting maybe?
            //running the LLhook // true dosent do shit
            LLHK = new LowLevelKeyboardH(true);
            LLHK.KeysToCheck.Add(Keys.Insert);
            LLHK.KeysToCheck.Add(Keys.Space);
            LLHK.KeysToCheck.Add((Keys)0x25);
            LLHK.KeysToCheck.Add((Keys)0x27);
            LLHK.keypressed += new KeyEventHandler(LLHK_Pressed);

            //then running the main components
            subWorker.RunWorkerAsync();


            //tick interval of the timer
            int delay = 20;
            //starting accurate timer
            mTimer1 = new SubToChrome.Engines_and_cfg.AccurateTimer(this, new Action(TimerTick1), delay);
            //lblTimer.Start();
        }
        //on timer tick
        private void TimerTick1()
        {
            if(isPlaying == true)
                MainTimer = MainTimer + 20;
        }

        public void updateSettings()
        {
            //checking if hotkeys are enabled
            //if (Settings.HotkeysEnabled == true)
              //  lblKeychecker.Start();
            //else
              //  lblKeychecker.Stop();


            //Setting the properties of drawing , does this in form_load to save memory instead of doeing this everytime drawing is -
            //called
            int SizeofFont = SubToChrome.Settings.FontSize;
            posx = SubToChrome.Settings.posX;
            posy = SubToChrome.Settings.posY;
            posy = posy + (posy - (posy / 4));
            point = new PointF(posx, posy);

            g = this.CreateGraphics();
            myBrush = new SolidBrush(Color.Yellow);
            drawfont = new Font("Arial", SizeofFont);
            //making the position perfect for subs
            //actually not, does this in drawing calls so that it updates if changed in settings
            //update -- does not do this in drawing to save memory. does it now in a void that can be called if something is changed in form1
        }

        private void Draw(int x)
        {
            //checking if the text is already written on screeen, if it is you dont wanna write it again
            string temp = SubPublicText[IntStart];
            if(temp.Equals(CurrentText) == false)
            {
                //centering the subs by getting the subsize and substraction the orginal pos
                if (Settings.CenterSub == true)
                {
                    float stringwidth = g.MeasureString(temp, drawfont).Width / 2;
                    float stringheight = g.MeasureString(temp, drawfont).Height / 2;
                    point = new PointF(posx - stringwidth, posy - stringheight);
                }        
                //cleaning the screen
                Clean(0);
                //actually drawing with the graphic class "g"
                g.DrawString(temp, drawfont, myBrush, point);
                Console.WriteLine(SubPublicText[IntStart]);
                CurrentText = temp;
            }

        }
        private void Clean(int stop)
        {
            g.Clear(Color.Peru);
            //Console.WriteLine(stop);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void subWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("justdebuggingshit");

            while (ShouldPlay == true)
            {
                if(isPlaying == true)
                {
                    //Console.WriteLine("moredebugging");
                    int stop = SubPublicStop[IntStart];
                    if (IntStart != 0 && IntStop != 0)
                        if (MainTimer >= stop)
                            Clean(stop);
                    for (int t = 0; t < SubPublicStart.Count; t++)
                    {
                        int tempStart = SubPublicStart[t];
                        int tempStop = SubPublicStop[t];
                        IntStop = tempStop;
                        if (tempStop > MainTimer)
                        {
                            //Console.WriteLine("evenmoredebugging");
                            if (tempStart < MainTimer)
                            {
                                IntStart = t;
                                Draw(t);
                                break;
                            }
                        }

                    }
                }
            }
        }
        private bool ShouldPlay = true;

        public void Forward()
        {
            if(Settings.moviemode == true)
            {
                Console.WriteLine("skipp 15 seconds into future");
                MainTimer = MainTimer + skipamount;
            }
        }

        public void Backward()
        {
            if(Settings.moviemode == true)
            {
                Console.WriteLine("Skip 15 seconds back to the past");
                if (MainTimer > skipamount)
                    MainTimer = MainTimer - skipamount;
                else
                    MainTimer = 0;
            }
        }

        private void StartorStop()
        {
            if(Settings.moviemode == true)
            {
                if (isPlaying == true)
                    isPlaying = false;
                else if (isPlaying == false)
                    isPlaying = true;
            }
        }

        private void MovieMode()
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

        public static void LLHK_Pressed(object sender, KeyEventArgs e)
        {
            //do shit
            if (e.KeyCode == Keys.Insert)
                Console.WriteLine("eeee");
        }

        private readonly Keys leftarrow = (Keys)0x25;
        private readonly Keys rightarrow = (Keys)0x27;


        private int skipamount = Settings.skipammount;
        #region OldAsyncKeyCheck

        /*
        private void lblKeychecker_Tick(object sender, EventArgs e)
        {
            NewHotkey.pressedbool = true;
            if (Settings.hotkeyhotkey == true)
                if (NewHotkey.checkforpress(CleanShit.KeysPublic[0]) == true)
                {
                    MovieMode();
                    NewHotkey.pressedbool = true;
                }
            if (NewHotkey.checkforpress(CleanShit.KeysPublic[1]) == true)
            {
                Backward();
                NewHotkey.pressedbool = true;
            }                    
            if (NewHotkey.checkforpress(CleanShit.KeysPublic[2]) == true)
            {
                Forward();
                NewHotkey.pressedbool = true;
            }
            if (NewHotkey.checkforpress(CleanShit.KeysPublic[3]) == true)
            {
                StartorStop();
                NewHotkey.pressedbool = true;
            }
        }
        */
        #endregion

    }
}
