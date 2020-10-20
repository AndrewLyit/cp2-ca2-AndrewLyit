using RPG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charEditor
{
    public partial class Form1 : Form
    {
        List<GameCharacter> charList;
        public Form1(List<GameCharacter> charList)
        {
            InitializeComponent();
            this.charList = charList;
            displayCharacters();
        }

        private void displayCharacters()
        {
            foreach (GameCharacter c in charList)
            {
                GroupBox charInfo = new GroupBox();
                FlowLayoutPanel layout = new FlowLayoutPanel();

                Label charName = new Label();
                charName.Text = c.CharacterName;

                Label charHealth = new Label();
                charHealth.Text = c.Health.ToString();

                layout.Controls.Add(charName);
                layout.Controls.Add(charHealth);
                charInfo.Controls.Add(layout);
                mainMenuPanel.Controls.Add(charInfo);


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
