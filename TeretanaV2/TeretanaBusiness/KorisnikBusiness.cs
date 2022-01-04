using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeretanaData;

namespace TeretanaBusiness
{
    public class KorisnikBusiness
    {
        //referenca od business ka data
        private readonly KorisnikRepository korisnikRepository;
        public KorisnikBusiness()
        {
            this.korisnikRepository = new KorisnikRepository();
        }

        //metoda za vracanje liste korisnika iz baze
        public List<Korisnik> ListaKorisnika()
        {
            return this.korisnikRepository.ListaKorisnika();
        }

        //metoda za azuriranje podataka o korisnicima u bazi
        public string UpdateKorisnik(Korisnik korisnik)
         {
             int rowsAffected = this.korisnikRepository.UpdateKorisnik(korisnik);

             if (rowsAffected > 0)
             {
                 return "Izmena uspešna!";
             }
             else
             {
                 return "Neuspešna izmena!";
             }
         }

        //metoda za brisanje korisnika iz baze
        public string DeleteKorisnik(int id_korisnika)
        {
            int rowsAffected = this.korisnikRepository.DeleteKorisnik(id_korisnika);

            if (rowsAffected > 0)
            {
                return "Korisnik je obrisan iz baze podataka!";
            }
            else
            {
                return "Brisanje korisnika nije uspelo!";
            }
        }
    }
}
