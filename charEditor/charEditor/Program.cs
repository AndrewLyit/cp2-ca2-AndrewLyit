using RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace charEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<RPG.GameCharacter> charList = new List<RPG.GameCharacter>();       //hard coded characters
            charList.Add(new Brawler());
            charList.Add(new Cleric());
            charList.Add(new BlackWitch());
            charList.Add(new Orc());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(charList));




        }
    }
}
