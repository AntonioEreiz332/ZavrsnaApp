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
    public partial class FormStanje : Form
    {
        public FormStanje()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            FormProdaja prodaja = new FormProdaja();
            this.Close();
            prodaja.Show();
        }
    }
}
