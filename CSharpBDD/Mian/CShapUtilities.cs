using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBDD.Mian
{
    internal class CShapUtilities
    {

        /// <summary>
        /// this methos is usefull to get ramndon integer
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public int RandomInteger(int range)
        {
            Random r = new Random();
            int rnum = r.Next(range);
            return rnum;
        }

        /// <summary>
        ///  this methos is usefull date
        /// </summary>
        /// <returns></returns>

        public String GetDate()
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToShortDateString();
            return date;
        }

        /// <summary>
        /// this method is usefull to get time
        /// </summary>
        /// <returns></returns>
        public String GetTime()
        {
            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToShortTimeString();
            return time;
        }

        /// <summary>
        ///  this method is usefull to get both time and date
        /// </summary>
        /// <returns></returns>
        public String GetDateAndTime()
        {
            DateTime dateTime = DateTime.Now;
            string dataAndtime = dateTime.ToString();
            return dataAndtime;
        }

        public string GetUniqueString(int lengthOfString)
        {
            string charectors = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            for (int i = 0; i < lengthOfString; i++)
            {
                sb.Append(charectors[r.Next(charectors.Length)]);
            }

            return sb.ToString();
        }
    }
}
