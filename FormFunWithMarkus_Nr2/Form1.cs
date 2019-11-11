using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFunWithMarkus_Nr2
{
    public partial class Form1 : Form
    {
        private Softdrinks fanta;
        private Beer weizen;
        public Form1()
        {
            fanta = new Softdrinks();
            fanta.Name = "Fanta";
            fanta.Price = 1.50;
            weizen = new Beer();
            weizen.Name = "Weizen";
            InitializeComponent();
        }


        private void cBGertränkeart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ToDo: Replayce with Switch
            
            cBSorte.Items.Clear();

            switch(cBGertränkeart.SelectedItem)
                {
                case "Softdrinks":
                    cBSorte.Items.Add(fanta.Name.ToString());
                    break;

                case "Bier":
                    cBSorte.Items.Add(weizen.Name.ToString());
                    break;


                default:
                    MessageBox.Show("Bitte eine Getränkeart auswählen");
                    break;
            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Drinks[] Getränke = new Drinks[8];


            Getränke[0] = fanta;
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cBSorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBSorte.SelectedItem.ToString() == fanta.Name)
            {
                tbPreis.Text = fanta.Price.ToString();
            }
        }

        private void cBAnzahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price;
            switch (cBAnzahl.SelectedIndex)
            {
                case 0:
                    price = Convert.ToDouble(tbPreis.Text);
                    price = price * 1;
                    tbSumme.Text = price.ToString();
                    break;

                case 1:
                    price = Convert.ToDouble(tbPreis.Text);
                    price = price * 2;
                    tbSumme.Text = price.ToString();
                    break;

                case 2:
                    price = Convert.ToDouble(tbPreis.Text);
                    price = price * 3;
                    tbSumme.Text = price.ToString();
                    break;

                case 3:
                    price = Convert.ToDouble(tbPreis.Text);
                    price = price * 4;
                    tbSumme.Text = price.ToString();
                    break;
                case 4:
                    price = Convert.ToDouble(tbPreis.Text);
                    price = price * 5;
                    tbSumme.Text = price.ToString();
                    break;
            }
        }

        private void tbPreis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
