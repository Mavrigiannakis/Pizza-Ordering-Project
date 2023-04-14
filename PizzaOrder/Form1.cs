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
    public partial class frm_front : Form
    {
        public frm_front()
        {
            InitializeComponent();
        }
        // Tämä tapahtumankäsittelijäfunktio käynnistyy, kun käyttäjä klikkaa "orderBT" -painiketta. 
        // Se avaa uuden ikkunan "frm_items", joka näyttää kaikki saatavilla olevat tuotteet. 
        // Tämän jälkeen se piilottaa nykyisen ikkunan käyttäen "this.Hide()" -metodia.
        private void orderBT_Click(object sender, EventArgs e)
        {
            Form item = new frm_items();
            item.Show();
            this.Hide();
        }

        // Tämä tapahtumankäsittelijäfunktio käynnistyy, kun käyttäjä klikkaa "exitBT" -painiketta. 
        // Se näyttää viestiruudun, joka kysyy käyttäjältä, haluaako hän varmasti poistua järjestelmästä. 
        // Jos käyttäjä valitsee "Kyllä", sovellus suljetaan, muussa tapauksessa koodin suoritus jatkuu normaalisti.
        private void exitBT_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the System", "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( iExit == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void frm_front_Load(object sender, EventArgs e)
        {

        }
    }
}
