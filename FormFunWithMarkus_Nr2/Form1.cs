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
            cBSorte.Items.Clear();
            object valBier = ;
           if(cBGertränkeart.SelectedItem == selectedval )
            {
                cBSorte.Items.Add("Export");
            }


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
