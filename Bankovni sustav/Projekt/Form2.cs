using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //botuni otvaraju forme, ovisno koji se ugovor želi ugovoriti;
        //neki botuni skrivaju ili mijenjaju neke labele, to smo napravili da
        //možemo imati jednu formu za sve oblike ugovora

        private void buttonStednja_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("ST");
            frm3.Text = "Štednja";
            frm3.labelJamac.Hide();
            frm3.labelJamac1.Hide();
            frm3.textBox7.Hide();
            frm3.button3.Hide();
            frm3.Show();
        }

        private void buttonKredit_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("KR");
            frm3.Text = "Kredit";
            frm3.Show();
        }

        private void buttonZiro_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("ZR");
            frm3.Text = "Žiro-račun";
            frm3.labelJamac.Hide();
            frm3.labelJamac1.Location = new Point(260, 156);
            frm3.labelJamac1.Text = "Održavanje računa: ";
            frm3.button3.Hide();
            frm3.Show();
        }

        private void buttonFond_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("IF");
            frm3.Text = "Fond";
            frm3.labelJamac.Text = "* - postavlja se od najvećeg gubitka do najvećeg dobitka u postotcima";
            frm3.labelJamac1.Text = "Rizik*: ";
            frm3.button3.Hide();
            frm3.Show();
        }
    }
}
