using System.Collections.Generic;

namespace SubToChrome
{

    public static class Settings
    {
        public static int posX { get; set; }
        public static int posY { get; set; }
        public static int FontSize { get; set; }
        public static bool CenterSub { get; set; }

        public static bool HotkeysEnabled { get; set; }
        public static bool hotkeyhotkey { get; set; }
        public static bool moviemode { get; set; }
        public static int skipammount { get; set; }

        //sending shit between forms:
        public static List<int> SubStartTemp = new List<int>();
        public static List<int> SubStopTemp = new List<int>();
        public static List<string> SubTextTemp = new List<string>();
        public static int IStartPos;

        //this function gets the input lists and varibles and stores it in local static and public varibles 
        //that gets accessed from form2 when the local update function in form2 is called
        //Updatelist() is called => all the above varibles gets updated => if form2 needs new information they are ready
        public static void UpdateList(List<int> start, List<int> stop, List<string> text, int startpos)
        {
            SubStartTemp = start;
            SubStopTemp = stop;
            SubTextTemp = text;
            IStartPos = startpos;

        }
    }

}
