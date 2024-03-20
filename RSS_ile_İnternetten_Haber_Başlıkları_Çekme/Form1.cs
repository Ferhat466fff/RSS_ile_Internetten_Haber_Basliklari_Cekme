using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_ile_İnternetten_Haber_Başlıkları_Çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Hurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader oku = new XmlTextReader("http://mix.chimpfeedr.com/07479-Hurriyet-Gazetesi");
            while(oku.Read())
            {
              if(oku.Name=="title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }
        }

        private void btn_Milliyet_Click(object sender, EventArgs e)
        {
       
            listBox1.Items.Clear();
            XmlTextReader oku = new XmlTextReader("https://www.aksam.com.tr/cache/rss.xml");
            while (oku.Read())
            {
                if (oku.Name == "title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }

        }

        private void btn_Fotomac_Click(object sender, EventArgs e)
        {
       

            listBox1.Items.Clear();
            XmlTextReader oku = new XmlTextReader(" https://www.fotomac.com.tr/rss/anasayfa.xml");
            while (oku.Read())
            {
                if (oku.Name == "title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }

        }
    }
}
