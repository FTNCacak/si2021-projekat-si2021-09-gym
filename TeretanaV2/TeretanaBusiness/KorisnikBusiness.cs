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

        //metoda za vracanej liste korisnika iz baze
        public List<Korisnik> ListaKorisnika()
        {
            return this.korisnikRepository.ListaKorisnika();
        }
    }
}
