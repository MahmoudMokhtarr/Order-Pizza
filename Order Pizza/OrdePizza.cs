using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OrdePizza : Form
    {
        public OrdePizza()
        {
            InitializeComponent();
        }

        void UpdetPlugins()
        {
            UpdetTotalPrice();

            string Plugins = "";

            if (chkOnions.Checked)
            {
                Plugins = "Onions ,";
            }

            if (chkMushrooms.Checked)
            {
                Plugins += "Mushrooms ,";

            }

            if (chkChickens.Checked)
            {
                Plugins += "Chickens ,";
            }

            if (chkOlive.Checked)
            {
                Plugins += "Olive ,";
            }

            if (chkMozzarellacheese.Checked)
            {
                Plugins += "Mozzarella cheese ,";
            }

            if (chkPepper.Checked)
            {
                Plugins += "Pepper ,";
            }

            if (chkTomatoes.Checked)
            {
                Plugins += "Tomatoes ,";
            }

            if (Plugins == "")
            {
                Plugins = "No Plugins ";
            }

            tbYourPlugins.Text = Plugins;
        }
        void UpdetaCrusr()
        {
            UpdetTotalPrice();

            if (rbThinCrust.Checked)
            {
                tbCrustType.Text = "Thin Crust ";
            }
            if (rbThickCrust.Checked)
            {
                tbCrustType.Text = "Thick Crust ";
            }

        }
        float CalculateCrustPrice()
        {

            if (rbThickCrust.Checked)


                return Convert.ToSingle(rbThickCrust.Tag);            

            else

                return Convert.ToSingle(rbThinCrust.Tag);


        }
        float CalculatePlugiensPrice()
        {
            float TotalPlugiensPrice = 0;

            if (chkOnions.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkOnions.Tag);
            }
            if (chkOlive.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkOlive.Tag);
            }
            if (chkPepper.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkPepper.Tag);
            }
            if (chkTomatoes.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkChickens.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkChickens.Tag);
            }
            if (chkMozzarellacheese.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkMozzarellacheese.Tag);
            }
            if (chkMushrooms.Checked)
            {
                TotalPlugiensPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            return TotalPlugiensPrice;
        }
        float GetSizePrice()
              {
            if (rbSmal.Checked) 

            return Convert.ToSingle(rbSmal.Tag);

            else if (rbMedium.Checked)

            return Convert.ToSingle(rbMedium.Tag);

            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

        }
        float CalculateTotalPrice()
        {
            return GetSizePrice() + CalculatePlugiensPrice() + CalculateCrustPrice();
        }
        void UpdetTotalPrice()
        {
            lbTotalPrice.Text = "$ " + CalculateTotalPrice().ToString();
        }
        void UpdetSize()
        {

            UpdetTotalPrice();

            if (rbSmal.Checked == true)
            {
                tbSize.Text = rbSmal.Text;
                return;
            }

            if (rbMedium.Checked == true)
            {
                tbSize.Text = rbMedium.Text;
                return;
            }
            if (rbLarge.Checked == true)
            {
                tbSize.Text = rbLarge.Text;
                return;

            }

        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins();
        }
        private void chkChickens_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins(); 
        }
        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins();
        }
        private void chkMozzarellacheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins();
        }
        private void chkPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdetPlugins();
        }
        private void rbSmal_CheckedChanged(object sender, EventArgs e)
        {

            UpdetSize();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdetSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdetSize();
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdetaCrusr();
        }
        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdetaCrusr();
        }
        private void Where_To_Eat_Click(object sender, EventArgs e)
        {
            if (rbEatIn.Checked == true)
            {
                tbWhereToEat.Text = rbEatIn.Text;
            }
            else
            {
                tbWhereToEat.Text = rbTakeOut.Text;
            }


        }
        private void btnOrderPiza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPiza.Enabled = false;
                gbSize.Enabled = false;
                gbYourPlugins.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbYourPlugins.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;


            chkChickens.Checked = false;
            chkOnions.Checked = false;
            chkMushrooms.Checked = false;
            chkMozzarellacheese.Checked = false;
            chkOlive.Checked = false;
            chkPepper.Checked = false;  
            chkTomatoes.Checked = false;

            Convert.ToSingle(lbTotalPrice.Text = "0");

        }

    }
 }

