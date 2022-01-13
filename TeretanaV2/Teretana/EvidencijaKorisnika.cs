﻿using System;
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
using Shared.Interfaces;
using TeretanaData;//dodao

namespace Teretana
{
    public partial class EvidencijaKorisnika : Form
    {
         private readonly TrenerBusiness itrenerBusiness=new TrenerBusiness();
         private readonly KorisnikBusiness ikorisnikBusiness=new KorisnikBusiness();
        /* private readonly ITrenerBusiness itrenerBusiness;

         public EvidencijaKorisnika(ITrenerBusiness _itrenerBusiness)
         {
             itrenerBusiness = _itrenerBusiness;
            InitializeComponent();
         }

         private readonly IKorisnikBusiness ikorisnikBusiness;

         public EvidencijaKorisnika(IKorisnikBusiness _ikorisnikBusiness)
         {
             ikorisnikBusiness = _ikorisnikBusiness;
             InitializeComponent();
         }*/
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
        private void btSacuvaj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "" || tbPrezime.Text == "" || tbTezina.Text == "" || tbVisina.Text == ""
                || (rbM.Checked==false && rbŽ.Checked==false) || cbIzabraniTrener.SelectedIndex==-1)
            {
                MessageBox.Show("Morate uneti vrednost u obavezna polja.", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Korisnik k = new Korisnik();
                k.ime = tbIme.Text.Trim();
                k.prezime = tbPrezime.Text.Trim();
                k.datum_rodjenja = dtpDatumRodjenja.Value;
                if (rbM.Checked)
                    k.pol = "muški";
                else if(rbŽ.Checked)
                    k.pol = "ženski";
                k.visina = Convert.ToDecimal(tbVisina.Text);
                k.tezina = Convert.ToDecimal(tbTezina.Text);
                k.email = tbEmail.Text;
                k.id_trenera = VratiIdTrenera();
                ikorisnikBusiness.InsertKorisnk(k);

                tbIme.Clear();
                tbPrezime.Clear();
                tbTezina.Clear();
                tbVisina.Clear();
                tbEmail.Clear();
                rbŽ.Checked = false;
                rbM.Checked = false;
                dtpDatumRodjenja.Value = DateTime.Today;

                dataGridViewKorisnici.Rows.Clear();
                osveziSpisak();
            }

        }
        private void osveziSpisak()
        {
            List<Korisnik> lista = new List<Korisnik>();
            lista = this.ikorisnikBusiness.ListaKorisnika();
            foreach(Korisnik k in lista)
            {
                int n = dataGridViewKorisnici.Rows.Add();
                dataGridViewKorisnici.Rows[n].Cells[0].Value = k.ime;
                dataGridViewKorisnici.Rows[n].Cells[1].Value = k.prezime;
                dataGridViewKorisnici.Rows[n].Cells[2].Value = k.pol;
                dataGridViewKorisnici.Rows[n].Cells[3].Value = k.visina;
                dataGridViewKorisnici.Rows[n].Cells[4].Value = k.tezina;
                int idt = k.id_trenera;
                string trenerIspis = "";
                List<Trener> listaTrenera = new List<Trener>();
                listaTrenera = this.itrenerBusiness.VratiTrenere();
                foreach(Trener t in listaTrenera)
                {
                    if(t.id_trenera==idt)
                        trenerIspis = t.ime + " " + t.prezime;
                }
                dataGridViewKorisnici.Rows[n].Cells[5].Value = trenerIspis;

            }
        }

        private void btIzbrisi_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li sigurno želite obrisati korisnika?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int indeksReda = dataGridViewKorisnici.CurrentRow.Index;
                string ime = (string)dataGridViewKorisnici.Rows[indeksReda].Cells[0].Value;
                string prezime = (string)dataGridViewKorisnici.Rows[indeksReda].Cells[1].Value;
                decimal visina = Convert.ToDecimal(dataGridViewKorisnici.Rows[indeksReda].Cells[3].Value);

                int idKor = VratiIdKorisnkia(ime, prezime, visina);
                this.ikorisnikBusiness.DeleteKorisnik(idKor);

                dataGridViewKorisnici.Rows.Clear();
                osveziSpisak();
            }
        }

        private void dataGridViewKorisnici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indeksReda = dataGridViewKorisnici.CurrentRow.Index;
            string ime = (string)dataGridViewKorisnici.Rows[indeksReda].Cells[0].Value;
            string prezime = (string)dataGridViewKorisnici.Rows[indeksReda].Cells[1].Value;
            string pol= (string)dataGridViewKorisnici.Rows[indeksReda].Cells[2].Value;
            decimal visina = Convert.ToDecimal(dataGridViewKorisnici.Rows[indeksReda].Cells[3].Value);
            decimal tezina= Convert.ToDecimal(dataGridViewKorisnici.Rows[indeksReda].Cells[4].Value);
            string trener= (string)dataGridViewKorisnici.Rows[indeksReda].Cells[5].Value;
            List<Korisnik> lista = new List<Korisnik>();
            lista = this.ikorisnikBusiness.ListaKorisnika();
            int idKor = 0;
            string email="";
            DateTime rodjenje=DateTime.Today;
            foreach (Korisnik k in lista)
            {
                if (k.ime == ime && k.prezime == prezime && visina == k.visina)
                {
                    idKor = k.id_korisnika;
                    email = k.email;
                    rodjenje = k.datum_rodjenja;
                }
            }
            tbIme.Text = ime;
            tbPrezime.Text = prezime;
            if (pol == "muški")
                rbM.Checked=true;
            else if (pol == "ženski")
                rbŽ.Checked=true;
            tbVisina.Text = visina.ToString();
            tbTezina.Text = tezina.ToString();
            tbEmail.Text = email;
            dtpDatumRodjenja.Value = rodjenje;
            cbIzabraniTrener.SelectedItem = trener;

        }

        private void btAzuriraj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "" || tbPrezime.Text == "" || tbTezina.Text == "" || tbVisina.Text == "")
            {
                MessageBox.Show("Dvoklikom miša odaberite korisnika čije podatke želite ažurirati", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Korisnik k = new Korisnik();
                k.ime = tbIme.Text;
                k.prezime = tbPrezime.Text;
                if (rbM.Checked)
                    k.pol = "muški";
                else
                    k.pol = "ženski";

                k.datum_rodjenja = dtpDatumRodjenja.Value;
                k.visina = Convert.ToDecimal(tbVisina.Text);
                k.tezina = Convert.ToDecimal(tbTezina.Text);
                k.email = tbEmail.Text;
                k.id_trenera = VratiIdTrenera();
                k.id_korisnika = VratiIdKorisnkia((string)dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentRow.Index].Cells[0].Value,
                    (string)dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentRow.Index].Cells[1].Value,
                    Convert.ToDecimal(dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentRow.Index].Cells[3].Value));

                this.ikorisnikBusiness.UpdateKorisnik(k);

                dataGridViewKorisnici.Rows.Clear();
                osveziSpisak();

                tbIme.Clear();
                tbPrezime.Clear();
                tbTezina.Clear();
                tbVisina.Clear();
                tbEmail.Clear();
                rbM.Checked = false;
                rbŽ.Checked = false;
                cbIzabraniTrener.SelectedIndex = -1;
                dtpDatumRodjenja.Value = DateTime.Today;
            }
        }
        private int VratiIdTrenera()
        {
            List<Trener> lista = new List<Trener>();
            lista = this.itrenerBusiness.VratiTrenere();
            int pomId = 0;
            string[] podaci = cbIzabraniTrener.Text.Split(' ');
            foreach (Trener t in lista)
            {
                if ((podaci[0] == t.ime) && (podaci[1] == t.prezime))
                    pomId = t.id_trenera;
            }
            return pomId;
        }
        private int VratiIdKorisnkia(string ime, string prezime, decimal visina)
        {
            List<Korisnik> lista = new List<Korisnik>();
            lista = this.ikorisnikBusiness.ListaKorisnika();
            int idKor = 0;
            foreach (Korisnik k in lista)
            {
                if (k.ime == ime && k.prezime == prezime && visina == k.visina)
                    idKor = k.id_korisnika;
            }
            return idKor;
        }

        private void EvidencijaKorisnika_Load(object sender, EventArgs e)
        {
            osveziSpisak();
            List<Trener> lista = new List<Trener>();
            lista = this.itrenerBusiness.VratiTrenere();
            foreach(Trener t in lista)
            {
                cbIzabraniTrener.Items.Add(t.ime + " " + t.prezime);
            }
            
        }
    }
}
