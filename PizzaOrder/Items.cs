using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class frm_items : Form
    {
        const double price_italian = 10;
        const double price_barbeque = 12;
        const double price_vegeroni = 11;
        const double price_supreme = 15;
        const double price_seafood = 13;
        const double price_cola = 2;
        const double price_zero = 2;
        const double price_pepsi = 2;
        const double price_fanta = 2;
        const double price_sprite = 2;
        public frm_items()
        {
            InitializeComponent();
        }
        // Tämä tapahtumankäsittelijäfunktio käynnistyy, kun käyttäjä klikkaa "exitBT" -painiketta. 
        // Se näyttää viestiruudun, joka kysyy käyttäjältä, haluaako hän varmasti poistua järjestelmästä. 
        // Jos käyttäjä valitsee "Kyllä", sovellus suljetaan, muussa tapauksessa koodin suoritus jatkuu normaalisti.
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the System", "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frm_items_Load(object sender, EventArgs e)
        {
            paymentCB.Items.Add(" ");
            paymentCB.Items.Add(" Cash");
            paymentCB.Items.Add(" Cash on Delivery");

            EnableTextBoxes();
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void italianCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (italianCHB.Checked == true)
            {
                italianTB.Enabled = true;
                italianTB.Text = "";
                italianTB.Focus();
            }
            else
            {
                italianTB.Enabled = false;
                italianTB.Text = "0";
            }
        }

        private void barbequeCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (barbequeCHB.Checked == true)
            {
                barbequeTB.Enabled = true;
                barbequeTB.Text = "";
                barbequeTB.Focus();
            }
            else
            {
                barbequeTB.Enabled = false;
                barbequeTB.Text = "0";
            }
        }

        private void veganvegeroniCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (veganvegeroniCHB.Checked == true)
            {
                vegeroniTB.Enabled = true;
                vegeroniTB.Text = "";
                vegeroniTB.Focus();
            }
            else
            {
                vegeroniTB.Enabled = false;
                vegeroniTB.Text = "0";
            }
        }

        private void supremeCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (supremeCHB.Checked == true)
            {
                supremeTB.Enabled = true;
                supremeTB.Text = "";
                supremeTB.Focus();
            }
            else
            {
                supremeTB.Enabled = false;
                supremeTB.Text = "0";
            }
        }

        private void seafoodCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (seafoodCHB.Checked == true)
            {
                seafoodTB.Enabled = true;
                seafoodTB.Text = "";
                seafoodTB.Focus();
            }
            else
            {
                seafoodTB.Enabled = false;
                seafoodTB.Text = "0";
            }
        }

        private void cocacolaCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (cocacolaCHB.Checked == true)
            {
                colaTB.Enabled = true;
                colaTB.Text = "";
                colaTB.Focus();
            }
            else
            {
                colaTB.Enabled = false;
                colaTB.Text = "0";
            }
        }

        private void zeroCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (zeroCHB.Checked == true)
            {
                zeroTB.Enabled = true;
                zeroTB.Text = "";
                zeroTB.Focus();
            }
            else
            {
                zeroTB.Enabled = false;
                zeroTB.Text = "0";
            }
        }

        private void pepsiCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (pepsiCHB.Checked == true)
            {
                pepsiTB.Enabled = true;
                pepsiTB.Text = "";
                pepsiTB.Focus();
            }
            else
            {
                pepsiTB.Enabled = false;
                pepsiTB.Text = "0";
            }
        }

        private void spriteCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteCHB.Checked == true)
            {
                spriteTB.Enabled = true;
                spriteTB.Text = "";
                spriteTB.Focus();
            }
            else
            {
                spriteTB.Enabled = false;
                spriteTB.Text = "0";
            }
        }

        private void fantaCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (fantaCHB.Checked == true)
            {
                fantaTB.Enabled = true;
                spriteTB.Text = "";
                spriteTB.Focus();
            }
            else
            {
                spriteTB.Enabled = false;
                spriteTB.Text = "0";
            }
        }

        private void paymentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentCB.Text == "Cash")
            {
                paymentTB.Enabled = true;
                paymentTB.Text = "";
                paymentTB.Focus();
            }
            else if (paymentCB.Text == "Cash on Delivery")
            {
                nameTB.Enabled = true;
                addressTB.Enabled = true;
                phoneTB.Enabled = true;
                nameTB.Text = "";
                phoneTB.Text = "";
                addressTB.Text = "";
                nameTB.Focus();
                addressTB.Focus();
                phoneTB.Focus();
            }
            else
            {
                paymentTB.Enabled = false;
                paymentTB.Text = "0";
            }
        }

        private void totalBT_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToDouble(italianTB.Text) * price_italian;
            itemcost[2] = Convert.ToDouble(barbequeTB.Text) * price_barbeque;
            itemcost[3] = Convert.ToDouble(vegeroniTB.Text) * price_vegeroni;
            itemcost[4] = Convert.ToDouble(supremeTB.Text) * price_supreme;
            itemcost[5] = Convert.ToDouble(seafoodTB.Text) * price_seafood;
            itemcost[6] = Convert.ToDouble(colaTB.Text) * price_cola;
            itemcost[7] = Convert.ToDouble(zeroTB.Text) * price_zero;
            itemcost[8] = Convert.ToDouble(pepsiTB.Text) * price_pepsi;
            itemcost[9] = Convert.ToDouble(spriteTB.Text) * price_sprite;
            itemcost[10] = Convert.ToDouble(fantaTB.Text) * price_fanta;

            double total, payment, cost;
            if (paymentCB.Text == "Cash")
            {
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];

                resultLB.Text = Convert.ToString(total);

                payment = Convert.ToInt32(paymentTB.Text);
                cost = payment - total;
                changeresultLB.Text = Convert.ToString(cost);
             }
            else
            {
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];

                resultLB.Text = Convert.ToString(total);

                payment = Convert.ToInt32(paymentTB.Text);
                cost = payment - total;
                changeresultLB.Text = Convert.ToString(cost);
            }
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetCheckBox();
        }
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(Controls);
            };
            func(Controls);  
        }
        private void ResetCheckBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = "0";
                    else
                        func(Controls);
            };
            func(Controls);
        }
        private void okBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing Stelios Pizza" + nameTB + "We will deliver your Order at"
                + addressTB + "We will send a message at" + phoneTB);
        }
    }
}
