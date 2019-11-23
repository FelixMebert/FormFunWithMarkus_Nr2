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
            double price = Convert.ToDouble(tbPreis.Text);
            int count = Convert.ToInt32(cBAnzahl.Text);
            double result = 0.0f;
            result = price* count;
            tbSumme.Text = result.ToString();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += Form2_FormClosed;
            form2.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            Form2 form2 = (Form2)sender;
            Drinks[] Getränke = new Drinks[form2.Softdrinksum];


            Getränke[0] = fanta;
        }
    }
}
