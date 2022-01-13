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
using Shared.Interfaces;

namespace Teretana
{
    public partial class RegistracijaTrenera : Form
    {
        private readonly TrenerBusiness itrenerBusiness=new TrenerBusiness();

       /* private readonly ITrenerBusiness itrenerBusiness;

        public RegistracijaTrenera(ITrenerBusiness _itrenerBusiness)
        {
            itrenerBusiness = _itrenerBusiness;
            InitializeComponent();
        }*/
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
            bool duplikat = false;
            List<Trener> lista = new List<Trener>();
            lista = this.itrenerBusiness.VratiTrenere();
            foreach (Trener t in lista)
            {
                if (tbKorisnickoImeT.Text == t.korisnicko_ime)
                    duplikat = true;
            }
            if (tbImeT.Text == "" || tbPrezimeT.Text == "" || tbBrojTelefonaT.Text == "" ||
                tbKorisnickoImeT.Text == "" || tbLozinkaT.Text == "" || cbStrucnaOblast.SelectedIndex==-1)
            {
                MessageBox.Show("Morate uneti vrednost u obavezna polja.", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(duplikat)
            {
                MessageBox.Show("Već postoji korisnik sa identičnim korisničkim imenom", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                itrenerBusiness.InsertTrener(t);

                tbImeT.Clear();
                tbPrezimeT.Clear();
                dtpDatumRodjenja.Value = DateTime.Today;
                cbStrucnaOblast.SelectedIndex = -1;
                tbBrojTelefonaT.Clear();
                tbBiografijaT.Clear();
                tbKorisnickoImeT.Clear();
                tbLozinkaT.Clear();
            }
        }

    }
}
