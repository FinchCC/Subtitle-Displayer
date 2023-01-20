using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Engine;
using SubToChrome.Other;
using Hotkeys;


namespace SubToChrome
{
    public partial class Form1 : Form
    {
        List<string> SubTimerlist = new List<string>();
        List<int> SubTimerStop = new List<int>();
        List<int> SubTimerStart = new List<int>();
        List<string> SubTextlist = new List<string>();
        public static int Startpos { get; set; }
        Form2 frm; 
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            this.Text = "Universal Subdisplayer --- by Finch";
            lblSeconds.Text = "0";
            Startpos = 0;
            lblSettingsPanel.Hide();
            lblCenterSub.Checked = true;
            btnPause.Visible = false;
            lblhotkeycheck.Enabled = false;
            btnBwd.Hide();
            btnFwd.Hide();
            lblSkipInSeconds.Text = "10";
            lblcleanbox.Checked = true;
            frm = new Form2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnOpenFile_Click(object sender, EventArgs e)
        {
            //1. Choosing the file location
            var filepath = string.Empty;
            OpenFileDialog files = new OpenFileDialog();
            files.Title = "Open subtitles file (needs to be converteble to .txt)";
            files.DefaultExt = ".txt";
            files.Filter = "txt files (*.txt)|*.txt| SubRip (*.srt)|*.srt";
            var fileresult = files.ShowDialog();
            if (fileresult == DialogResult.OK)
            {                   
                //2.Setting the file location
                filepath = files.FileName;
                textBox1.Text = filepath;
                btnStart.Enabled = false;
                progressBar1.Value = 0;
                textBox1.Enabled = false;
            }
            else if (fileresult == DialogResult.Cancel)
                Message("Choose atleast one file", "No file selected");
            else
            {
                //3. Giving error if file isent valid
                Message("Not a valide file!", "error 420!");
                textBox1.Text = string.Empty;
            }



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lblX.Text == string.Empty || lblY.Text == string.Empty)
            {
                btnDefault.PerformClick();
                lblSave.PerformClick();
                Message("Settings are set to default, but can be changed anytimes in the settings tab", "Error - Settings not set");
            }
            //4. Starting Form2 and passing the: Start, Stop and the actually SubText in List<string>

            SubToChrome.Settings.UpdateList(SubTimerStart, SubTimerStop, SubTextlist, Startpos);

            //creating a new instance of the class Form2
            //TODO: make the creation of the instance in the constructer so we can call the same frm from everywhere...?
            frm.Show();
            btnStart.Hide();
            btnPause.Visible = true;
            btnFwd.Show();
            btnBwd.Show();
            lblUpdater.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //cleanig the file
            if (cleanText == true)
            {
                CleanFile.CleanAndWrite(textBox1.Text);
                Message(textBox1.Text, "ttt");
            }

            //---------------
            //Parsing try #1
            //----------
            // on date it looks like it is always 24 letters
            string[] FullSub = File.ReadAllLines(textBox1.Text);
            for (int i = 0; i < FullSub.Length; i++)
            {
                string tempSS = FullSub[i];
                bool ccoursS;
                //Check if the string Contains a letter from alphabet, if it does we mark it as Subtext and add it to the respectfully List<string>
                Converters.checkifoccour(tempSS, out ccoursS);
                string location = i.ToString();
                string locationTO = i + 1.ToString();
                string temp = i.ToString();
                if(FullSub[i] == temp)
                {
                   Console.WriteLine("line {0}: marked as most likely a SubCounter", location);
                }
                else if(FullSub[i].Length == 24 && ccoursS == false)
                {
                    SubTimerlist.Add(FullSub[i]);
                    Console.WriteLine("line {0}: marked as most likely a SubTimer and added to the timer" +
                        "list", location);
                }
                else if(FullSub[i].Length > 2 && ccoursS == true)
                {
                    String SubTextTemp = FullSub[i];
                    if (FullSub[i+1].Length > 2)
                    {
                        string subtexttempto = FullSub[i + 1];
                        SubTextTemp = (SubTextTemp + "\n" + subtexttempto);
                        SubTextlist.Add(SubTextTemp);
                        Console.WriteLine("line {0} and {1}: marked as most likely a SubText and " +
                            "added to the Textlist" +
                        "list", location, locationTO);
                        i++;
                    }
                    else
                    {
                        SubTextlist.Add(FullSub[i]);
                        Console.WriteLine("line {0}: marked as most likely a Subtext and " +
                          "added to the Textlist" +
                        "list", location);
                    }
                }
                else
                {
                    Console.WriteLine("line {0}: failed and hopefully skipped :/", location);
                }
                backgroundWorker1.ReportProgress(((i * 100) / FullSub.Length) / 2);

                //Console.WriteLine((i * 100) / FullSub.Length);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished sorting, with {0} SubText and {1} SubTimes" +
                " and will now print all text to console", SubTextlist.Count, SubTimerlist.Count);
            Console.ResetColor();

            #region Splitting-Sub
            int tempII = 0;
            
            for (int x = 0; x < SubTimerlist.Count; x++)
            {
                //temp value
                tempII = 0;

                //Just genral cleaning, and removing of shit
                string[] tempArray = SubTimerlist[x].Split('-');
                tempArray[tempII] = tempArray[tempII].Replace('-', ' ').Replace(',', ' ');
                tempArray[tempII + 2] = tempArray[tempII + 2].Replace('-', ' ').Replace(',', ' ');

                /*
                 removing whitespace with String.Concat -> wich bascicly is: if a char(c) is => whitespace then remove char(c) and 
                 then convert back to string 
                */
                tempArray[tempII] = String.Concat(tempArray[tempII].Where(c => !Char.IsWhiteSpace(c)));
                tempArray[tempII + 2] = String.Concat(tempArray[tempII + 2].Where(c => !Char.IsWhiteSpace(c)));

                //Converting to a char array
                char[] TempCharr = tempArray[tempII].ToCharArray();
                char[] TempCharr2 = tempArray[tempII + 2].ToCharArray();


                //NUM = SubTimerStart in milliseconds
                //NUM2 = SubTimerStop in miliseconds
                int NUM = 0;
                int NUM2 = 0;
                Converters.TimeConverter(TempCharr, out NUM);
                Converters.TimeConverter(TempCharr2, out NUM2);

                //adding the milliseconds to the universal list
                SubTimerStart.Add(NUM);
                SubTimerStop.Add(NUM2);
                backgroundWorker1.ReportProgress(50 + ((x * 100) / SubTimerlist.Count) / 2);
            }
            #endregion
        }
        

        private void btnPreload_Click(object sender, EventArgs e)
        {
            //checking if the background worker is working the stop the task from "dobbel-running"
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            //if the background worker isent running , -then start it
            else
            {
                Console.Beep();
                MessageBox.Show("Is currently Pre-loading already....", "Already Pre-loading");
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //for every loop in the progress the progressbar updates with a value
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //informing the user with a message box that the preload is done
            Message("Done Preloading", "Done!");
            btnStart.Enabled = true;
            //setting the value of the progressbar to 100 manually to skip any visual bugs
            progressBar1.Value = 100;

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Showing settings
            lblSettingsPanel.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Hiding settings
            lblSettingsPanel.Hide();
        }


        private void lblSave_Click(object sender, EventArgs e)
        {
            // Goal: Save the values with try, bc we dont want a crash.

            //try to get the values from the boxes and converting it to int
            try
            {
                SubToChrome.Settings.posX = Convert.ToInt32(lblX.Text) / 2;
                SubToChrome.Settings.posY = Convert.ToInt32(lblY.Text) / 2;
                SubToChrome.Settings.FontSize = Convert.ToInt32(lblSize.Text);
                Settings.skipammount = Convert.ToInt32(lblSkipInSeconds.Text);
                
            }
            //catching the error, sending message and then resseting values to default
            catch
            {
                Message("Error handler successfully caught the error and resetted the values!", "Error - Unsupported values");
                btnDefault.PerformClick();
            }
            //trying to save the start value and passing it to a local Form1 value bc quick editing
            try
            {
                //setting the value to start(or 0) if the string is empty or "whitespaces". Using just a if instead of try to save timeboth
                if(string.IsNullOrEmpty(lblSeconds.Text) == true)
                {
                    lblSeconds.Text = "0";
                }
                //actually converting
                int seconds = Convert.ToInt32(lblSeconds.Text);
                //setting to a Get;Set; value.
                Startpos = seconds;
                //hiding the panel
                lblSettingsPanel.Hide();
            }
            //cathing the error if anything goes wrong and then sending a message to inform and dont to more.
            catch
            {
                Message("Starting position values not supported, use only number without , / .", "Error - Unsupported values");
            }
            //if the form has been loaded call the function to update display settings.
            try
            {
                frm.updateSettings();
            }
            catch
            {

            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            //just setting the button to a debugger values
            //TODO: make default values savable in a settings file or something
            lblX.Text = "1440";
            lblY.Text = "1080";
            lblSize.Text = "16";
            lblSkipInSeconds.Text = "10";
            lblcleanbox.Checked = true;
        }

        //Just a function to quicksend Messageboxes
        public void Message(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCenterSub_CheckedChanged(object sender, EventArgs e)
        {
            if (lblCenterSub.Checked == true)
                Settings.CenterSub = true;
            else
                Settings.CenterSub = false;
        }

        private void lblUpdater_Tick(object sender, EventArgs e)
        {
            if (frm.isPlaying == false)
                btnPause.Text = namePlay;
            else if (frm.isPlaying == true)
                btnPause.Text = namePause;
            else
            {
                //do nothing, just to catch errors
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (frm.isPlaying == true)
            {
                frm.isPlaying = false;
                btnPause.Text = namePlay;
            }
            else if(frm.isPlaying == false)
            {
                frm.isPlaying = true;
                btnPause.Text = namePause;
            }

        }

        private readonly string namePlay = "To Play click or press space";
        private readonly string namePause = "To Pause click or press space";

        private void lblHotkeys_CheckedChanged(object sender, EventArgs e)
        {
            if (lblHotkeys.Checked == true)
            {
                Settings.HotkeysEnabled = true;
                lblhotkeycheck.Checked = true;
                lblhotkeycheck.Enabled = true;
            }                
            else
            {
                Settings.HotkeysEnabled = true;
                lblhotkeycheck.Checked = false;
                lblhotkeycheck.Enabled = false;
            }

        }

        private void lblhotkeycheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lblHotkeys.Checked == true)
            {
                Settings.hotkeyhotkey = true;
                Settings.moviemode = true;
            }
            else
            {
                Settings.hotkeyhotkey = false;
                Settings.moviemode = false;
            }
        }

        private void btnBwd_Click(object sender, EventArgs e)
        {
            frm.Backward();
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            frm.Forward();
        }

        private void lblcleanbox_CheckedChanged(object sender, EventArgs e)
        {
            if (lblcleanbox.Checked == true)
                cleanText = true;
            else
                cleanText = false;
        }

        private bool cleanText;

        private void lblSkipInSeconds_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
