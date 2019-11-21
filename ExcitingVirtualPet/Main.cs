using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcitingVirtualPet
{
    public partial class Main : Form
    {
        public int MAX_HUNGER { get; set; }
        public Main()
        {
            InitializeComponent();
        }
        private void CatButton_Click(object sender, EventArgs e)
        {
            //Load form for cat
            Main mainCat = new Main();

        }

        private void DogButton_Click(object sender, EventArgs e)
        {
            //Load form for dog
        }
        private void BirdButton_Click(object sender, EventArgs e)
        {

        }

        private void LizardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
