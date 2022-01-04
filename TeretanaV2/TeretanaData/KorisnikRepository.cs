using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Shared.Models;

namespace TeretanaData
{
    //metoda koja vraca listu korisnika iz baze
    public class KorisnikRepository
    {
            public List<Korisnik> ListaKorisnika()
            {
                List<Korisnik> lista = new List<Korisnik>();
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT* FROM Korisnici";
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Korisnik k = new Korisnik();
                        k.id_korisnika = sqlDataReader.GetInt32(0);
                        k.ime = sqlDataReader.GetString(1);
                        k.prezime = sqlDataReader.GetString(2);
                        k.datum_rodjenja = sqlDataReader.GetDateTime(3);
                        k.tezina = sqlDataReader.GetDecimal(4);
                        k.visina = sqlDataReader.GetDecimal(5);
                        k.pol = sqlDataReader.GetString(6);
                        k.email = sqlDataReader.GetString(7);
                        k.id_trenera = sqlDataReader.GetInt32(8);
                        lista.Add(k);
                    }
                }
                return lista;
            }
    }
}
