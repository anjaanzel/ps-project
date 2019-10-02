using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesija
{
    public class Broker
    {
        
        SqlConnection konekcija;
        SqlTransaction transakcija;
   

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        #region Metode za rukovanje konekcijama i transakcijama
        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Konferencija;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
             
                konekcija.Open();


            }
            catch (Exception)
            {

                MessageBox.Show("Konekcija nije uspešna!");
                throw;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Nije moguće zatvoriti konekciju!");
                throw;
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
            }
            catch (Exception)
            {

                MessageBox.Show("Transakcija se ne može uspostaviti!");
                throw;
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                MessageBox.Show("Transkacija se ne može potvrditi!");
                throw;
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                MessageBox.Show("Transkacija se ne može poništiti!");
                throw;
            }
        }

        #endregion

        public int vratiSifru(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT MAX(" + odo.ID + ") FROM " + odo.NazivTabele;
                SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw new Exception("Greška pri formiranju jedinstvene šifre!");
            }
        }

        public int insert(OpstiDomenskiObjekat odo)
        {

            string upit = "INSERT INTO " + odo.NazivTabele + " " + odo.Insert;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri unosu podataka u bazu!");
            }
        }

        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    
                    lista.Add(odo.procitajRed(red));
                }
               
                return lista;
            }
            catch (Exception)
            {
                
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }

        }

        public OpstiDomenskiObjekat vratiJedanZaOpstiUslov(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovOpsti;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);

            }
            catch (Exception)
            {
                
                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac!= null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaOpstiUslov(OpstiDomenskiObjekat odo)
		{
            string upit = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovOpsti;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
			{
				
				citac = komanda.ExecuteReader();
				DataTable tabela = new DataTable();
				tabela.Load(citac);
				List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

				foreach (DataRow red in tabela.Rows)
				{
					lista.Add(odo.procitajRed(red));
				}

				return lista;
			}
			catch (Exception)
			{
				
				throw new Exception("Greška u radu sa bazom!");
			}
			finally
			{
				if (citac != null)
				{
					citac.Close();
				}
			}
		}

        public OpstiDomenskiObjekat vratiJedanZaID(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);

            }
            catch (Exception)
            {

                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public int update(OpstiDomenskiObjekat odo)
        {

            string upit = "UPDATE " + odo.NazivTabele + " SET " + odo.Update + " WHERE " + odo.UslovID;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri ažuriranju podataka u bazi!");
            }
        }

        public int delete(OpstiDomenskiObjekat odo)
        {

            string upit = "DELETE FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greška pri brisanju iz baze!");
            }
        }
    }
}
