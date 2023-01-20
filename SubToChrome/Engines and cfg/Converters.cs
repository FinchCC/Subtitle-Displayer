using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Converters
    {

        //Converting hardcoded values like HH:MM:SS to all milliseconds, so it can be stored in a single int
        public static int TimeConverter(char[] startnum, out int NUM)
        {
            //creating a new list<string>
            List<String> GetMulitplied = new List<string>();

            //converting a char[] to the list<string>, definitly a stupid way to convert but it seemed the fastest to program
            //TODO: making a faster converter
            for (int forY = 0; forY < startnum.Length; forY++)
            {
                string temppp = new string(startnum).Substring(forY, 1);
                GetMulitplied.Add(temppp);
                //MessageBox.Show(temppp);
            }


            /*
            Array so you can gradually devide the values from the list<string> by this array of already found values
            TODO: making it so that it will find out how long each member of list<string> wich will result in the program
            not crashing if the member of list<string> is not perfectly long and to make the algorythm more efficient*/
            int[] toMultiply = new int[]
            {
                36000000,
                3600000,
                600000,
                60000,
                10000,
                1000,
                100,
                10,
                1
            };
            //temp valuys
            int NUMBER = 0;
            int y = 0;
            for (int x = 0; x < GetMulitplied.Count; x++)
            {
                //Converting the values from list<string> to a temp int
                int tempInt = Convert.ToInt32(GetMulitplied[x]);


                /*
                multiplying the number from the temp int by the fitting number from the GetMultiplied[] to make into a perfect milliseconds
                but this is not the right or best way to do it, if the length of list<string>["x"] is longer than the supported values
                from the toMultiply or shorter than the program will crash. The values are also hardcoded wich makes this not supporting "typos"
                or any other file formats
                */
                NUMBER = NUMBER + (tempInt * toMultiply[x]);
                y++;
            }
            return NUM = NUMBER;
        }


        //checking if a string contains any letter form the alphabet, does not have support for typical string characthers that arent letter like:
                            // ": , -, _, "," , .  .etc"
        public static bool checkifoccour(string tempSS, out bool ccoursS)
        {
            //just a temp bool
            bool temp = false;
            
            //making it lower, bc if the hole string was all cap lock it didnt detect and would crash.
            string temptocheck = tempSS.ToLower();
            
            //string[] to check if occours in the string, occours == string is text, conatains != string is not text
            #region Region Alphabet
            string[] alfabeth = new string[]
            {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            "æ",
            "ø",
            "å",
            };
            #endregion
            
            //the checking loop
            for (int it = 0; alfabeth.Length > it; it++)
            {
                if (temptocheck.Contains(alfabeth[it]))
                {
                    temp = true;
                    //breaking the function if it finds a letter, stopping it from using uneccesary mem
                    break;
                }
            }
            
            //if it occours then return true
            if (temp == true)
            {
                ccoursS = true;
                return ccoursS;
            }
            
            //else return false
            else
            {
                ccoursS = false;
                return ccoursS;
            }
        }
    }
}
