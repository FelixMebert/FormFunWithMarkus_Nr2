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
        public Form1()
        {
            InitializeComponent();
        }


        private void cBGertränkeart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ToDo: Replayce with Switch
            cBSorte.Items.Clear();
            string valBier = "Bier";
            string valSotfdrinks = "Softdrinks";
            if (cBGertränkeart.SelectedItem.ToString() == valBier)
            {
                cBSorte.Items.Add("Weizen");
                cBSorte.Items.Add("Export");
                cBSorte.Items.Add("Pils");
            }

            else if (cBGertränkeart.SelectedItem.ToString() == valSotfdrinks)
            {
                cBSorte.Items.Add("Fanta");
                cBSorte.Items.Add("Sprite");
                cBSorte.Items.Add("Cola");
            }

            //object valBier = new Bier();
            //if (cBGertränkeart.SelectedItem == valBier)
            //{
            //    cBSorte.Items.Add("Export");
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
