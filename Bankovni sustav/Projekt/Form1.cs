using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt
{
    public partial class Form1 : Form
    {
        int p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Učitavamo korisnička imena i lozinke

            StreamReader stream_reader = new StreamReader("Korisnici.txt");
            List<string> korisnici = new List<string>();
            string linija;
            while ((linija = stream_reader.ReadLine()) != null)
            {
                korisnici.Add(linija);
            }
            stream_reader.Close();

            //Provjeravamo korisnička imena i lozinke

            for (int i = 0; i < 11; i++)
            {
                if (korisnici[i] == textBoxKIme.Text && korisnici[i] != "")
                {
                    if (korisnici[i+1] == textBoxLozinka.Text && korisnici[i+1] != "")
                    {
                        this.Hide();
                        Form2 frm2 = new Form2();
                        p = 1;
                        frm2.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Podatci nisu točni.");
                textBoxKIme.Clear();
                textBoxLozinka.Clear();
            }
            p = 0;
            return;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxLozinka.UseSystemPasswordChar = false;
            }
            else
                textBoxLozinka.UseSystemPasswordChar = true;
        }
    }
}
