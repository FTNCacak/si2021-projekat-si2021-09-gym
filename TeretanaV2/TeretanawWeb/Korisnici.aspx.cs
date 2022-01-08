using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TeretanaBusiness;

namespace TeretanawWeb
{
    public partial class Korisnici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           KorisnikBusiness korisnikBusiness = new KorisnikBusiness();
            List<Korisnik> korisnici = korisnikBusiness.ListaKorisnika();

            foreach (Korisnik korisnik in korisnici)
            {
                HtmlGenericControl listonode = new HtmlGenericControl("TR");
                HtmlGenericControl listid = new HtmlGenericControl("TD");
                listid.Attributes.Add("scope", "row");
                listid.InnerText = korisnik.id_korisnika.ToString();
                listonode.Controls.Add(listid);
                HtmlGenericControl listime = new HtmlGenericControl("TD");
                listime.InnerText = korisnik.ime;
                listonode.Controls.Add(listime);
                HtmlGenericControl listprezime = new HtmlGenericControl("TD");
                listprezime.InnerText = korisnik.prezime;
                listonode.Controls.Add(listprezime);
                HtmlGenericControl listel = new HtmlGenericControl("TD");
                listel.InnerText = korisnik.id_trenera.ToString();
                listonode.Controls.Add(listel);
                tablecontent.Controls.Add(listonode);
            }
        }

        protected void btn2_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}