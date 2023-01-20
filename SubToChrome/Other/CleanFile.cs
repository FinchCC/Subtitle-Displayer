using System.IO;

namespace SubToChrome.Other
{
    public static class CleanFile
    {
        public static string[] ShitToLook = new string[]
        {
            "<i>",
            "</i>",
            ">",
            ":",
            "<font color",
            "</font>"
        };
        
        
        public static void CleanAndWrite(string filepath)
        {
            string[] FullText = File.ReadAllLines(filepath);


            //loop trough the hole shit and if it coitains illegal characthers, replace them with nothing.
            for(int i = 0; i < FullText.Length; i++)
            {
                for(int x = 0; x < ShitToLook.Length; x++)
                {
                    if (FullText[i].Contains(ShitToLook[x]) == true)
                    {
                        FullText[i].Replace(ShitToLook[x], "m");
                    }
                }
            }

            //writes the new cleaner version back again
            File.WriteAllLines(filepath, FullText);
        }
    }
}
