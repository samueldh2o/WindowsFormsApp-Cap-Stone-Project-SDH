using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Cap_Stone_Project_SDH
{
    public partial class frm_myNumberGame : Form
    {
        public frm_myNumberGame()
        {
            InitializeComponent();
        }

        private void frm_MyNumberGame_Load(object sender, EventArgs e)
        {

        }

        private void lbl_rools_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double winingNumber = random.Next(0, 100);

            double Number;
            double.TryParse(textBox_1.Text, out Number);


            if (Number > winingNumber && Number > 0 && Number < 101)
            {
                textBox2.Text = ("To High. Please Try a Lower Value Number");

            }
            else if (Number < winingNumber && Number > 0 && Number < 101)
            {
                textBox2.Text = ("To Low. Please Try a Higher Value Number ");
            }
            else if (Number == winingNumber)
            {
                textBox2.Text = ("You are Correct.");

               
            }
            else if (Number > 100 || Number < 0)
            {
                textBox2.Text = ("Please Try a Reel Number Between 0 and 100 ");
            }
            
           



        }
    }
}
