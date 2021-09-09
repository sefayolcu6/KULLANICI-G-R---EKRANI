using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhammed_sefa_yolcu_193201023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*EKLEDİĞİM ÖZELLİKLER:
         -açılabilir form
         -AcceptButton (seçili butona enter a basılınca formu açar)
         -CancelButton (esc ye basılınca formu kapatır)
         -startpozition (form ekranı açılınca ekran üzerindeki konumı belirler)
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 YeniForm = new Form2();
            YeniForm.ShowDialog();// .Show()= ekran kapanmadan yeni bir ekran açabilir.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 YeniForm2 = new Form3();
            YeniForm2.ShowDialog(); // .ShowDialog()= ekran kapanmadan yeni bir ekran açmaz


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
