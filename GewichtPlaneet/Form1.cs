using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GewichtPlaneet
{
    public partial class frmPlaneet : Form
    {
        public frmPlaneet()
        {
            InitializeComponent();
        }

        private void frmPlaneet_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnBereken_Click(object sender, EventArgs e)
        {// Door Erian Nkunga
            try
            {
                string aarde = txtGewicht.Text;


                txtAarde.Text = aarde;

                int gewicht = int.Parse(txtGewicht.Text);

                double Mercurius = gewicht * 0.38;

                double Venus = gewicht * 0.91;

                double Mars = gewicht * 0.38;

                double jupiter = gewicht * 2.34;

                double Saturnus = gewicht * 0.93;

                double Uranus = gewicht * 0.92;

                double Neptunes = gewicht * 1.12;

                double Pluto = gewicht * 0.07;

                double Maan = gewicht * 0.17;

                double zon = gewicht * 27.9;

                string Merc = Mercurius.ToString();
                string Ven = Venus.ToString();
                string Mar = Mars.ToString();
                string Jupiter = jupiter.ToString();
                string Sat = Saturnus.ToString();
                string Uran = Uranus.ToString();
                string Nep = Neptunes.ToString();
                string pluto = Pluto.ToString();
                string maan = Maan.ToString();
                string Zon = zon.ToString();

                txtMercurius.Text = Merc;
                txtVenus.Text = Ven;
                txtMars.Text = Mar;
                txtJupiter.Text = Jupiter;
                txtSaturnus.Text = Sat;
                txtUranus.Text = Uran;
                txtNeptunus.Text = Nep;
                txtPluto.Text = pluto;
                txtZon.Text = Zon;
                txtMaan.Text = maan;

                lbxResultaat.Items.Add(aarde);
                lbxResultaat.Items.Add(Merc);
                lbxResultaat.Items.Add(Ven);
                lbxResultaat.Items.Add(Mar);
                lbxResultaat.Items.Add(Jupiter);
                lbxResultaat.Items.Add(Sat);
                lbxResultaat.Items.Add(Uran);
                lbxResultaat.Items.Add(Nep);
                lbxResultaat.Items.Add(pluto);
                lbxResultaat.Items.Add(maan);
                lbxResultaat.Items.Add(Zon);
            }

            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }
    }
}
