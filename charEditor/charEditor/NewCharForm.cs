using RPG;
using System;
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

            System.Windows.Forms.MessageBox.Show(classChosen);
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.charList.Add(new Cleric());
            originForm.displayCharacters();
            this.Close();
        }
    }
}
