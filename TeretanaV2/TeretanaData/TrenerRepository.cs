using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Shared.Models;

namespace TeretanaData
{
    public class TrenerRepository
    {
        public List<Trener> PrijavaTrenera()
        {
            
            SqlConnection konekcija = new SqlConnection(Constants.connString);
            konekcija.Open();

            SqlCommand komanda = new SqlCommand();
            komanda.Connection = konekcija;
            komanda.CommandText = "SELECT* FROM Treneri ";
            SqlDataReader dataReader = komanda.ExecuteReader();
            List<Trener> listaTrenera = new List<Trener>();

            while(dataReader.Read())
            {
                Trener t = new Trener();
                t.id_trenera = dataReader.GetInt32(0);
                t.ime = dataReader.GetString(1);
                t.prezime = dataReader.GetString(2);
                t.datum_rodjenja = dataReader.GetDateTime(3);
                t.strucna_oblast = dataReader.GetString(4);
                t.broj_telefona = dataReader.GetString(5);
                t.biografija = dataReader.GetString(6);
                t.korisnicko_ime = dataReader.GetString(7);
                t.sifra = dataReader.GetString(8);
                listaTrenera.Add(t);
            }
            konekcija.Close();
            return listaTrenera;
        }
    }
}
