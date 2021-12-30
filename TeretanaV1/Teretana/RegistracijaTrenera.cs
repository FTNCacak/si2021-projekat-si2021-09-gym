using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeretanaBusiness;

namespace Teretana
{
    public partial class RegistracijaTrenera : Form
    {
        readonly TrenerBusiness trenerBussines = new TrenerBusiness();
        public RegistracijaTrenera()
        {
            InitializeComponent();
        }

        private void btNazadT_Click(object sender, EventArgs e)
        {
            Prijavljivanje prijavljivanje = new Prijavljivanje();
            prijavljivanje.Show();
            this.Hide();
        }
    }
}
