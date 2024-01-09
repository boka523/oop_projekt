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
    public partial class Form3 : Form
    {
        string kategorija;
        public Form3(string k)
        {
            InitializeComponent();
            kategorija = k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //upisujemo u datoteku podatke iz forme

            StreamWriter stream_writer = new StreamWriter(kategorija + ".txt", true);
            stream_writer.WriteLine("Ime i prezime: " + textBox1.Text + " " + textBox2.Text + "\n" +
                         "OIB: " + textBox3.Text + "\n" +
                         "Adresa: " + textBox4.Text + "\n" +
                         "Količina: " + textBox5.Text + "\n" +
                         "Kamate: " + textBox6.Text + "\n" +
                         "Trajanje ugovora: " + textBox8.Text);

            //dodajemo kategorije ovisno o tome o kojem se ugovoru radi

            if (kategorija == "KR")
            {
                stream_writer.WriteLine("Jamac: " + textBox7.Text + "\n");
            }
            else if (kategorija == "ZR")
            {
                stream_writer.WriteLine("Održavanje računa: " + textBox7.Text + "\n");
            }
            else if (kategorija == "IF")
            {
                stream_writer.WriteLine("Rizik: " + textBox7.Text + "\n");
            }
            else
            {
                stream_writer.WriteLine("\n");
            }
            stream_writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //čitamo podatke iz datoteke

            StreamReader stream_reader = new StreamReader(kategorija + ".txt");
            richTextBox1.Text = stream_reader.ReadToEnd();
            stream_reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kolicina, trajanje, kamata, godisnje, godisnja_naknada, konacan_iznos;
            kolicina = int.Parse(textBox5.Text);
            trajanje = int.Parse(textBox8.Text);
            kamata = int.Parse(textBox6.Text);
            godisnje = kolicina / trajanje;
            godisnja_naknada = kolicina * kamata / 100;
            konacan_iznos = kolicina + (godisnja_naknada * trajanje);
            MessageBox.Show("Godišnji povrat kredita iznosi: " + godisnje + "\n Godišnja naknada iznosi: " + godisnja_naknada + "\n Stvaran iznos koji ćete platiti iznosi: " + konacan_iznos);
        }
    }
}
