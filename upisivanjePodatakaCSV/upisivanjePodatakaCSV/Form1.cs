using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                txtemail.Clear();
                txtgodina.Clear();
                txtprezime.Clear();
                txtime.Clear();
                txtime.Focus();

                DialogResult upit = MessageBox.Show("Želite li unesti još podataka", "Upit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch(upit){
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
    }
}
