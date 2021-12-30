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
using TeretanaData;

namespace Teretana
{
    public partial class Prijavljivanje : Form
    {

        //poveyati sa biynis slojem
        private TrenerBusiness tBusiness = new TrenerBusiness();
        public Prijavljivanje()
        {
            InitializeComponent();
        }

        private void btPrijaviSe_Click(object sender, EventArgs e)
        {
            string korIme = tbKorisnickoIme.Text.Trim();
            string sifra = tbSifra.Text.Trim();

            // if()
            List<Trener> lista = this.tBusiness.Proba();
            bool pom = true;
            for(int i=0;i<lista.Count-1; i++)
            {
                if((lista[i].korisnicko_ime==korIme && lista[i].sifra==sifra))
                {
                    EvidencijaKorisnika ek = new EvidencijaKorisnika();
                    ek.Show();
                    this.Hide();
                    pom = false;
                }
            }
            if (korIme == "admin" && sifra == "admin")
            {
                EvidencijaKorisnika ek = new EvidencijaKorisnika();
                ek.Show();
                this.Hide();
                pom = false;
            }
                if (pom==true)
            {
                tbKorisnickoIme.Clear();
                tbSifra.Clear();
            }
        }
    }
}
