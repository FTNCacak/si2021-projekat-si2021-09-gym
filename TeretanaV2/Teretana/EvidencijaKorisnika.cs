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
using Shared.Models;

namespace Teretana
{
    public partial class EvidencijaKorisnika : Form
    {
        readonly TrenerBusiness trenerBussines = new TrenerBusiness();
        readonly KorisnikBusiness korisnikBussines = new KorisnikBusiness();
        public EvidencijaKorisnika()
        {
            InitializeComponent();
        }

        private void btNazad_Click(object sender, EventArgs e)
        {
            Prijavljivanje prijavljivanje = new Prijavljivanje();
            prijavljivanje.Show();
            this.Hide();
        }

        private void EvidencijaKorisnika_Load(object sender, EventArgs e)
        {
            List<Trener> lista = new List<Trener>();
            lista = this.trenerBussines.Proba();
            foreach(Trener t in lista)
            {
                cbIzabraniTrener.Items.Add(t.ime +" " +t.prezime);
                cbIzabraniTrener.SelectedItem = t.ime + " " + t.prezime;
            }
            
        }

        private void btSacuvaj_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.ime = tbIme.Text.Trim();
            k.prezime = tbPrezime.Text.Trim();
            k.datum_rodjenja = dtpDatumRodjenja.Value;
            if (rbM.Checked)
                k.pol = "muški";
            else
                k.pol = "ženski";
            k.visina = Convert.ToDecimal(tbVisina.Text);
            k.tezina = Convert.ToDecimal(tbVisina.Text);
            k.email = tbEmail.Text;
            List<Trener> lista = new List<Trener>();
            lista= this.trenerBussines.Proba();
            int pomId=0;
            string []podaci = cbIzabraniTrener.Text.Split(' ');
            foreach(Trener t in lista)
            {
                if ((podaci[0] == t.ime) && (podaci[1] == t.prezime))
                    pomId = t.id_trenera;
            }
            k.id_trenera = pomId;
            korisnikBussines.InsertKorisnk(k);

            tbIme.Clear();
            tbPrezime.Clear();
            tbTezina.Clear();
            tbVisina.Clear();
            tbEmail.Clear();
            dtpDatumRodjenja.Value = Convert.ToDateTime("9/11/2003");


        }
    }
}
