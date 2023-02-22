using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders40_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butonKlik(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            butonKlik(sender, e);
        }


        private void butonKlik(object sender, EventArgs e)
        {
            //Button kontrolünün hangi grupta olduğunu kontrol edelim.
            Control groupBox = ((Button)sender).Parent;

            //döngü içinde Formdaki kontrolleri geziyoruz.
            foreach (Control item in this.Controls)
            {
                //Gezdiğimiz kontrol GroupBox ise içine giriyoruz.
                if (item is GroupBox)
                {
                    //Groupbox kontrollü içinde geziyoruz.
                    foreach (Control item2 in item.Controls)
                    {
                        //Buttonun içindeki bulunduğu groupbox ve Textbox şartı sağlanıyorsa içine textboxı seçiyoruz.
                        if (item2 is TextBox && item2.Parent == groupBox)
                        {
                            (item2 as TextBox).Clear();
                        }
                    }
                }

            }
        }


    }
}
