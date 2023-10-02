using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürün_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            double fiyat, borc;

            int adet = Convert.ToInt32(txtAdet.Text);
            fiyat = Convert.ToDouble(txtFiyat.Text);

            borc = Convert.ToDouble (fiyat * adet);    
            lblBorc.Text = "ödenecek tutar: " + borc.ToString();
        }
    }
}
