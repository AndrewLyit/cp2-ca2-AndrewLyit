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

            FlowLayoutPanel characterLayout = new FlowLayoutPanel();
            foreach (GameCharacter c in charList)
            {
                GroupBox charInfo = new GroupBox();
                TableLayoutPanel layout = new TableLayoutPanel();

                Label charName = new Label();
                charName.Text = c.CharacterName;

                Label charHealth = new Label();
                charHealth.Text = c.Health.ToString();

                Button editButton = new Button();
                editButton.Text = "Edit";
                editButton.Click += (s, e) =>
                {
                    selectedChar = c;
                    openEditingMenu(selectedChar);
                };

                layout.Controls.Add(charName);
                layout.Controls.Add(charHealth);
                layout.Controls.Add(editButton);
                charInfo.Controls.Add(layout);
                characterLayout.Controls.Add(charInfo);

            }

            mainMenuPanel.Controls.Add(characterLayout);
        }

        private void openEditingMenu(GameCharacter selectedChar)
        {

            editingMenuPanel.Show();
            GroupBox editOptions = new GroupBox();
            TableLayoutPanel layout = new TableLayoutPanel();
            tbCharName.Text = selectedChar.CharacterName;

            layout.Controls.Add(lblCharName);
            layout.Controls.Add(tbCharName);
            editOptions.Controls.Add(layout);
            editingMenuPanel.Controls.Add(editOptions);
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
    }
}
