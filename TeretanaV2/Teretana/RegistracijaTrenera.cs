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

        private void btSacuvajT_Click(object sender, EventArgs e)
        {
            if (tbImeT.Text == "" || tbPrezimeT.Text == "" || tbBrojTelefonaT.Text == "" ||
                tbKorisnickoImeT.Text == "" || tbLozinkaT.Text == "")
            {
                MessageBox.Show("Morate uneti vrednost u obavezna polja.", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Trener t = new Trener();
                t.ime = tbImeT.Text.Trim();
                t.prezime = tbPrezimeT.Text.Trim();
                t.datum_rodjenja = dtpDatumRodjenja.Value;
                t.strucna_oblast = cbStrucnaOblast.SelectedItem.ToString();
                t.br_telefona = tbBrojTelefonaT.Text;
                t.biografija = tbBiografijaT.Text;
                t.korisnicko_ime = tbKorisnickoImeT.Text.Trim();
                t.sifra = tbLozinkaT.Text.Trim();
                trenerBussines.InsertTrener(t);

                tbImeT.Clear();
                tbPrezimeT.Clear();
                dtpDatumRodjenja.Value = DateTime.Today;
                cbStrucnaOblast.SelectedItem = "kardio";
                tbBrojTelefonaT.Clear();
                tbBiografijaT.Clear();
                tbKorisnickoImeT.Clear();
                tbLozinkaT.Clear();
            }
        }

        private void RegistracijaTrenera_Load(object sender, EventArgs e)
        {
            cbStrucnaOblast.SelectedItem = "kardio";
        }
    }
}
