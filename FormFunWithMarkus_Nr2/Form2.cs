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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int bottlecount;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        int softdrinksumm;
        public int Softdrinksum
        {
            get
            {
                return softdrinksumm;
            }
            //set
            //{
            //    softdrinksumm = value;
            //}
        }
        private void cbFanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cbFanta.SelectedItem.ToString(), out softdrinksumm);
        }
    }
}
