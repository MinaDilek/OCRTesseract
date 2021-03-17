using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract; 

namespace OCRTesseract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./tessdata", "eng");
                var sonuc = ocr.Process(img);
                richTextBox1.Text = sonuc.GetText();
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string cumle = txtCumle.Text;

            char Harf = Convert.ToChar(txtHarf.Text);
            int harfSayisi = 0;

            foreach (char i in cumle)
            {
                if (Harf == i)
                    harfSayisi++;
            }
            lblSonuc.Text = Harf.ToString() + " Harfinin Toplam Sayısı:" + harfSayisi.ToString();






        }
    }
}
