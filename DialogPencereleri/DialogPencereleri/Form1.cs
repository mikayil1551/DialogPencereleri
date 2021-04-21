using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=  fontDialog1.ShowDialog();

            if (sonuc==DialogResult.OK)
            {
                lblDeneme.Font = fontDialog1.Font;
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\User\Desktop\YenidenC#";

            openFileDialog1.Filter = "Jpeg Dosyasi(*.jpeg)|*.jpeg|Jpg Dosyasi(*.jpg)" +
                "|*.jpg|Png Dosyasi(*.png)|*.png|Gif Dosyasi(*.gif)|*.gif";
            openFileDialog1.Title = "Resim Dosyasi Seciniz";

            DialogResult sonuc=  openFileDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDeneme.Text = openFileDialog1.FileName;
                lblDeneme2.Text = openFileDialog1.SafeFileName;

            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydedilecek dosyayi seciniz";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                lblDeneme2.Text = saveFileDialog1.FileName;

            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDeneme2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                lblDeneme.ForeColor = colorDialog1.Color;
                lblDeneme2.BackColor = colorDialog1.Color;
            }
        }
    }
}
