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

        public void displayCharacters()
        {
            charLayoutPanel.Controls.Clear();
            foreach (GameCharacter c in charList)
            {
                TableLayoutPanel layout = new TableLayoutPanel();
                //GroupBox charBox = new GroupBox();
                Panel charBox = new Panel();
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
            experienceIn.Text = selectedChar.CharacterExperience.ToString();
            weightLimitIn.Text = selectedChar.WeightLimit.ToString();


            if(selectedChar is BlackWitch)
            {
                BlackWitch temp = selectedChar as BlackWitch;

                polyLbl1.Text = "Dark Power:";
                polyNumeric1.Maximum = 100;
                polyNumeric1.Value = temp.DarkPower;
                
                polyLbl2.Text = "M. Proficiency: ";
                polyNumeric2.Maximum = 100;
                polyNumeric2.Value = temp.MagicProficiency;
                polyLbl2.Show();
                polyNumeric2.Show();

            }
            
            if (selectedChar is Brawler)
            {
                Brawler temp = selectedChar as Brawler;

                polyLbl1.Text = "Punch Damage:";
                polyNumeric1.Maximum = 100;
                polyNumeric1.Value = temp.PunchDamage;

                polyLbl2.Text = "Strength: ";
                polyNumeric2.Maximum = 100;
                polyNumeric2.Value = temp.Strength;
                polyLbl2.Show();
                polyNumeric2.Show();

            }

            if (selectedChar is Cleric)
            {
                Cleric temp = selectedChar as Cleric;

                polyLbl1.Text = "Piety Level:";
                polyNumeric1.Maximum = 100;
                polyNumeric1.Value = temp.PietyLevel;

                polyLbl2.Hide();
                polyNumeric2.Hide();
                
            }

            if (selectedChar is Orc)
            {
                Orc temp = selectedChar as Orc;

                polyLbl1.Text = "Ferociousness:";
                polyNumeric1.Maximum = 100;
                polyNumeric1.Value = temp.Ferociousness;

                polyLbl2.Text = "Strength: ";
                polyNumeric2.Maximum = 100;
                polyNumeric2.Value = temp.Strength;
                polyLbl2.Show();
                polyNumeric2.Show();

            }



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
            if (!(tbCharName.Text.Length == 0))
                selectedChar.CharacterName = tbCharName.Text;
            else
            {
                System.Windows.Forms.MessageBox.Show("Character name cannot be empty.");
                return;
            }

            selectedChar.Health = healthSlider.Value;

            //Updating character values
            selectedChar.CharacterExperience = Convert.ToInt32(experienceIn.Value);
            selectedChar.WeightLimit = Convert.ToDouble(weightLimitIn.Value);
            if (selectedChar is BlackWitch)
            {
                BlackWitch temp = selectedChar as BlackWitch;
                temp.DarkPower = Convert.ToInt32(polyNumeric1.Value);
                temp.MagicProficiency = Convert.ToInt32(polyNumeric2.Value);
                selectedChar = temp;
            }

            if (selectedChar is Brawler)
            {
                Brawler temp = selectedChar as Brawler;
                temp.PunchDamage = Convert.ToInt32(polyNumeric1.Value);
                temp.Strength = Convert.ToInt32(polyNumeric2.Value);
                selectedChar = temp;
            }

            if (selectedChar is Cleric)
            {
                Cleric temp = selectedChar as Cleric;
                temp.PietyLevel = Convert.ToInt32(polyNumeric1.Value);                
                selectedChar = temp;
            }

            if (selectedChar is Orc)
            {
                Orc temp = selectedChar as Orc;
                temp.Ferociousness = Convert.ToInt32(polyNumeric1.Value);
                temp.Strength = Convert.ToInt32(polyNumeric2.Value);
                selectedChar = temp;
            }


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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void xpLbl_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            charList.Remove(selectedChar);
            editingMenuPanel.Hide();
            displayCharacters();
        }

        private void newCharBtn_Click(object sender, EventArgs e)
        {
            NewCharForm form2 = new NewCharForm(charList, this);
            form2.ShowDialog();
        }
    }
}
