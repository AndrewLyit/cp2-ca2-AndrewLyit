using RPG;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charEditor
{
    public partial class NewCharForm : Form
    {
        List<GameCharacter> charList;
        string classChosen;
        Form1 originForm;
        GameCharacter newChar;
        public NewCharForm(List<GameCharacter> charList, Form1 originalForm)
        {
            InitializeComponent();
            this.charList = charList;
            this.originForm = originalForm;
        }

        private void editingMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void classCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            classChosen = classCombo.Text;
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {      
            this.Close();
        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            if (!(classChosen == null))
            {
                if (classChosen.Equals("BlackWitch"))
                    newChar = new BlackWitch();
                else if (classChosen.Equals("Brawler"))
                    newChar = new Brawler();
                else if (classChosen.Equals("Cleric"))
                    newChar = new Cleric();
                else
                    newChar = new Orc();



                if (newChar is BlackWitch)
                {
                    polyLbl1.Text = "Dark Power:";
                    polyLbl2.Text = "Magic Proficiency:";
                    polyLbl2.Show();
                    polyNumeric2.Show();
                }

                else if (newChar is Brawler)
                {
                    polyLbl1.Text = "Punch Damage:";
                    polyLbl2.Text = "Strength:";
                    polyLbl2.Show();
                    polyNumeric2.Show();
                }

                else if (newChar is Cleric)
                {
                    polyLbl1.Text = "Piety Level:";
                    polyLbl2.Hide();
                    polyNumeric2.Hide();
                }

                else if (newChar is Orc)
                {
                    polyLbl1.Text = "Ferociousness:";
                    polyLbl2.Text = "Strength:";
                    polyLbl2.Show();
                    polyNumeric2.Show();
                }
                classSelectionPanel.Hide();
                editingMenuPanel.Show();

            }
            else
                System.Windows.Forms.MessageBox.Show("Class must be selected");

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!(tbCharName.Text.Length == 0))
                newChar.CharacterName = tbCharName.Text;
            else
            {
                System.Windows.Forms.MessageBox.Show("Character name cannot be empty.");
                return;
            }

            newChar.Health = healthSlider.Value;
            newChar.CharacterExperience = Convert.ToInt32(experienceIn.Value);
            newChar.WeightLimit = Convert.ToDouble(weightLimitIn.Value);
            if (newChar is BlackWitch)
            {
                BlackWitch temp = newChar as BlackWitch;
                temp.DarkPower = Convert.ToInt32(polyNumeric1.Value);
                temp.MagicProficiency = Convert.ToInt32(polyNumeric2.Value);
                newChar = temp;
            }

            if (newChar is Brawler)
            {
                Brawler temp = newChar as Brawler;
                temp.PunchDamage = Convert.ToInt32(polyNumeric1.Value);
                temp.Strength = Convert.ToInt32(polyNumeric2.Value);
                newChar = temp;
            }

            if (newChar is Cleric)
            {
                Cleric temp = newChar as Cleric;
                temp.PietyLevel = Convert.ToInt32(polyNumeric1.Value);
                newChar = temp;
            }

            if (newChar is Orc)
            {
                Orc temp = newChar as Orc;
                temp.Ferociousness = Convert.ToInt32(polyNumeric1.Value);
                temp.Strength = Convert.ToInt32(polyNumeric2.Value);
                newChar = temp;
            }

            charList.Add(newChar);
            originForm.displayCharacters();
            this.Close();
        }

        private void layout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCharName_Click(object sender, EventArgs e)
        {

        }
    }
}
