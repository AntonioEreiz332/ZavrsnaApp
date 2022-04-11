using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavrsniRad
{
    public partial class FormProdaja : Form
    {
        public FormProdaja()
        {
            InitializeComponent();
        }

        private void btnStanjeKase_Click(object sender, EventArgs e)
        {
            FormStanje stanje = new FormStanje();
            stanje.Show();
            this.Hide();
        }

        private void FormProdaja_Load(object sender, EventArgs e)
        {
            lblDobardan.Text ="Dobar dan, "+ Korisnik.korinsik_ime;
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmLogin login = new frmLogin();
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }

        }
    }
}
