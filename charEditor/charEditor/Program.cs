﻿using RPG;
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
            charList.Add(new Brawler("George",100,100,20,300,CharacterState.Idle,200,20));
            charList.Add(new Cleric("Jemima",100,100,20,200,CharacterState.Dead,30));
            charList.Add(new BlackWitch("Gertrude",100,100,20,300,CharacterState.Running,30,40));
            charList.Add(new Orc("Johnny",100,100,20,340,CharacterState.Walking,20,30));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(charList));




        }
    }
}
