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
using System.Xml.Linq;
using System.IO;

namespace zavrsniRad
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string izXML_korisnik = "";
        public string izXML_lozinka = "";
        public string izXML_ime = "";
        public double izXML_oib = 0;

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korime = txtBoxKorIme.Text;
            string lozinka = txtBoxLoz.Text;
            bool korime_status=false, prezime_status=false;
            if(korime != "")
            {
                korime_status = true;
            }
            if (lozinka != "")
            {
                prezime_status = true;
            }

            if (korime_status && prezime_status){
                    XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\users.xml");
                    var korisnik = from x in doc.Descendants("user").Where
                                   (x => (string)x.Element("username") == txtBoxKorIme.Text)
                                   select new
                                   {
                                       XMLkorisnik = x.Element("username").Value,
                                       XMLlozinka = x.Element("password").Value,
                                       XMLime = x.Element("name").Value,
                                       XMLoib = x.Element("oib").Value
                                   };
                    foreach (var x in korisnik)
                    {
                        izXML_korisnik = x.XMLkorisnik;
                        izXML_lozinka = x.XMLlozinka;
                        izXML_ime = x.XMLime;
                        izXML_oib = Convert.ToDouble(x.XMLoib);

                    }
                if (korime == izXML_korisnik)
                {
                    if (lozinka == izXML_lozinka)
                    {
                        txtBoxKorIme.Clear();
                        txtBoxLoz.Clear();
                        FormProdaja prodaja = new FormProdaja();

                        Korisnik.korinsik_korime = izXML_korisnik;
                        Korisnik.korinsik_lozinka = izXML_lozinka;
                        Korisnik.korinsik_ime = izXML_ime;
                        Korisnik.korinsik_oib = izXML_oib;

                        prodaja.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Pogrešna lozinka!");
                        txtBoxKorIme.Clear();
                        txtBoxLoz.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime!");
                    txtBoxKorIme.Clear();
                    txtBoxLoz.Clear();
                }

            }
            else
            {
                MessageBox.Show("Niste upisali korisničko ime ili lozinku!");
            }

            

        }
    }
}
