using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace upisivanjePodatakaCSV
{
    public partial class Form1 : Form
    {
        List<Osoba> ListaOsoba = new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrisanje_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            txtgodina.Clear();
            txtprezime.Clear();
            txtime.Clear();
        }

        private void btnupis_Click(object sender, EventArgs e)
        {
            //Osoba osoba = new Osoba();

            try
            {
                Osoba osoba = new Osoba(txtime.Text,
                   txtprezime.Text, txtemail.Text, Convert.ToInt16(txtgodina.Text));

                //osoba.Ime = txtime.Text;
                //osoba.Prezime = txtprezime.Text;
                //osoba.Email = txtemail.Text;
                //osoba.GodinaRodjenja = Convert.ToInt16(txtgodina.Text);

                txtemail.Clear();
                txtgodina.Clear();
                txtprezime.Clear();
                txtime.Clear();
                txtime.Focus();

                DialogResult upit = MessageBox.Show("Želite li unesti još podataka", "Upit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            ListaOsoba.Add(osoba);
                            break;
                        }
                    case DialogResult.No:
                        {
                            txtime.Enabled = false;
                            txtprezime.Enabled = false;
                            txtgodina.Enabled = false;
                            txtemail.Enabled = false;
                            break;
                        }
                }

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgodina.Focus();
            }


        }

        private void btnspremi_Click(object sender, EventArgs e)
        {
            /*
            // textBox1.Text = osoba.ToString();
            textBox1.Text = "Ime,Prezime,Email,GodinaRodjenja" + Environment.NewLine;

            foreach (Osoba osoba in ListaOsoba)
            {
                textBox1.AppendText(osoba.ToString()+Environment.NewLine);
            */
            string putanjaDoDatoteke = "C: \\Users\\Ucenik\\Documents\\testCSV\\osobe.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(putanjaDoDatoteke))
                {
                    sw.WriteLine("Ime,Prezime,Email,GodinaRodjenja");

                    foreach (Osoba osoba in ListaOsoba)
                    {
                        sw.WriteLine(osoba.ToString());
                    }
                }
                MessageBox.Show("Podaci su uspješno spemljeni u CSV datoteku!", "Uspjeh",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je pogreške prilikom spremanja podataka: " + ex.Message,
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
