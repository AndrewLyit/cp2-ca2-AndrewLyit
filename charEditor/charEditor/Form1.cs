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
        GameCharacter selectedChar;
        public Form1(List<GameCharacter> charList)
        {
            InitializeComponent();
            this.charList = charList;
            editingMenuPanel.Hide();
            displayCharacters();

        }

        private void displayCharacters()
        {

            foreach (GameCharacter c in charList)
            {
                TableLayoutPanel layout = new TableLayoutPanel();
                GroupBox charBox = new GroupBox();
                Label charName = new Label();
                charName.Text = c.CharacterName;

                Label charHealth = new Label();
                charHealth.Text = "Health: "+c.Health.ToString();

                Label charClass = new Label();
                if (c is Cleric)
                    charClass.Text = "Cleric";

                else if (c is Brawler)
                    charClass.Text = "Brawler";

                else if (c is BlackWitch)
                    charClass.Text = "BlackWitch";

                else if (c is Orc)
                    charClass.Text = "Orc";

                else
                    charClass.Text = "Unkown Class";



                Button editButton = new Button();
                editButton.Text = "Edit";
                editButton.Click += (s, e) =>
                {
                    selectedChar = c;
                    openEditingMenu(selectedChar);
                };

                layout.Controls.Add(charName);
                layout.Controls.Add(charClass);
                layout.Controls.Add(charHealth);
                layout.Controls.Add(editButton);
                charBox.Controls.Add(layout);

                charLayoutPanel.Controls.Add(charBox);
            }
            mainMenuPanel.Show();
        }

        private void openEditingMenu(GameCharacter selectedChar)
        {
            layout.ColumnCount = 2;
            
            tbCharName.Text = selectedChar.CharacterName;
            healthSlider.Value = selectedChar.Health;
            layout.Controls.Add(lblCharName, 0,0);
            layout.Controls.Add(tbCharName, 1,0);

            editingMenuPanel.Controls.Add(layout);
            editingMenuPanel.Show();

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            selectedChar.CharacterName = tbCharName.Text;
            selectedChar.Health = healthSlider.Value;
            editingMenuPanel.Hide();
            charLayoutPanel.Controls.Clear();
            displayCharacters();

            selectedChar = null;
        }


        private void editingMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCharName_Click(object sender, EventArgs e)
        {

        }
    }
}
