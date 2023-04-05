using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cnvrt_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(Amount_Txt.Text);
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Dollar")
            {
                int conver = i / 103;
                display_txt.Text = "Converted Amount : " + conver + "\t $";
            }
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i / 115;
                display_txt.Text = "Converted Amount : " + conver + "\t Euro";
            }
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i / 115;
                display_txt.Text = "Converted Amount : " + conver + "\t RS/=";
            }

        }
    }
}
