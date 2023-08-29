using System.ComponentModel.Design.Serialization;

namespace Drinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region GUI
        private void buttonGetDrinks_Click(object sender, EventArgs e)
        {
            Logic();
        }
        #endregion GUI

        #region Logic
        static void Logic()
        {

        }
        #endregion Logic

        #region DAL
        static void DAL()
        {

        }
        #endregion DAL

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is CheckBox)
                {
                    
                }
            }
        }
    }
}