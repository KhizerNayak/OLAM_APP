using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ola_App
{
    public partial class HomeOlam : Form
    {
       
        int Pickup, Drop;
        int Measuring;
        


        public HomeOlam()
        {
            InitializeComponent();
            
        }

        private void TxtPickup_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtPickup.Text, out int pickupValue))
            {
                Pickup = Math.Abs(pickupValue);
            }
            else
            {
                // Handle invalid input or show a message
                // For now, setting Pickup to 0 as an example
                MessageBox.Show( "The Pickup should be Entered","Error");
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int dropValue))
            {
                Drop = Math.Abs(dropValue);
            }
            else
            {
                // Handle invalid input or show a message
                // For now, setting Drop to 0 as an example
                MessageBox.Show("The Drop Location is empty","ERROR");
            }
        }


        private void BtnMeasure_Click(object sender, EventArgs e)
        {
            Measuring = Math.Abs(Pickup - Drop);
            
                while (Pickup != 0) 
            {
                if (Measuring <= 29)
                {
                    MessageBox.Show($"The Distance is {Pickup}, {Drop} and ${Measuring * 12} ", "The distance between pick up and drop");
                }
                else if (Measuring >= 30 && Measuring <= 49)
                {
                    MessageBox.Show($"The Distance is {Pickup}, {Drop} and ${Measuring * 10} ", "The distance between pick up and drop");
                }
                else if (Measuring >= 50 && Measuring <= 74)
                {
                    MessageBox.Show($"The Distance is {Pickup}, {Drop} and ${Measuring * 8} ", "The distance between pick up and drop");
                }
                else
                {
                    ShowMessageBox();
                }
            }
            
        }
        private void ShowMessageBox(double DiscountPrice = 10, double OGP = 8) //Custom Message Function
        {
            DiscountPrice = (OGP - (OGP * 0.10));
            MessageBox.Show($"The Distance is {Pickup}, {Drop} and ${Convert.ToInt32(DiscountPrice * Measuring)} ", "The distance between pick up and drop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OaApp f = new OaApp();
            this.Hide();
            f.Show();
        }
    }
}
