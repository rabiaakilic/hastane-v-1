using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_v_1_1359
{
    public partial class Form1 : Form
    {
        Hasta hasta1= new Hasta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            


            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

           hasta1 = new Hasta();

            hasta1.ad = txtAd.Text;
            hasta1.soyad = txtSoyad.Text;
            hasta1.tcno = txtTcNo.Text; 
            hasta1.tel = txtTel.Text;
            hasta1.kronikHastalik = rbKronikHastalıkVar.Checked;
            hasta1.kangurubu = cmbKan.Text;
            hasta1.dtarih = dtpTarih.Value;

        }  
    }
}
