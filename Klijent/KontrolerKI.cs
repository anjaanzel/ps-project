using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;
        public static Korisnik korisnik;
        public static Govornik govornik;
        public static Sala sala;
        public static Raspored raspored;
        public static Predavanje predavanje;

        public static string poveziSeNaServer()
        {
            komunikacija = new Komunikacija();
            if (komunikacija.poveziSeNaServer())
            {
                return "Zaposleni je povezan na server!";
            }
            else
            {
                return "Zaposleni nije povezan na server!";
            }
        }

        public void kraj()
        {
            try
            {
                komunikacija.kraj();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal bool pronadjiKorisnika(TextBox txtKorisnickoIme, TextBox txtKorisnickaSifra)
        {
            korisnik = new Korisnik();
            korisnik.Username = txtKorisnickoIme.Text;
            korisnik.Password = txtKorisnickaSifra.Text;

            korisnik.Uslovi = " Username='" + korisnik.Username + "' and Password='" + korisnik.Password + "'";

            korisnik = komunikacija.PronadjiKorisnika(korisnik) as Korisnik;

            if (korisnik == null)
            {
                MessageBox.Show("Ne postoji korisnik sa unetim podacima!");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno ste se prijavili na sistem!");
                return true;
            }
        }

        public void kreirajPredavaca(TextBox txtID, Button btnKreirajP, GroupBox gbDetaljiP, ComboBox cmbZemlja)
        {
            govornik = komunikacija.kreirajPredavaca() as Govornik;

            if (govornik == null)
            {
                MessageBox.Show("Sistem ne može da kreira novog predavača!");
            }
            else
            {
                cmbZemlja.DataSource = komunikacija.vratiSveZemlje();
                txtID.Text = govornik.SifraGovornika.ToString();
                btnKreirajP.Enabled = false;
                gbDetaljiP.Enabled = true;
                MessageBox.Show("Novi govornik je kreiran! Unesite tražene podatke kako biste ga uspešno sačuvali.");
            }

        }

        public bool zapamtiPredavaca(TextBox txtImeP, TextBox txtPrezimeP, TextBox txtSSS, TextBox txtEmail, TextBox txtKompanija, ComboBox cmbZemlja, RadioButton rbMuski, RadioButton rbZenski)
        {
            

            govornik.ImeGovornika = txtImeP.Text;
            if (govornik.ImeGovornika == "")
            {
                MessageBox.Show("Niste uneli ime!");
                return false;
            }

            govornik.PrezimeGovornika = txtPrezimeP.Text;
            if (govornik.PrezimeGovornika == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                return false;
            }

            try
            {
                govornik.StepenStrucneSpreme = Convert.ToInt32(txtSSS.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli stepen stručne spreme!");
                return false;
            }

            if (govornik.StepenStrucneSpreme < 1 || govornik.StepenStrucneSpreme > 8)
            {
                MessageBox.Show("Stepen stručne spreme mora biti između 1 i 8!");
                return false;
            }

            govornik.Email = txtEmail.Text;
            if (govornik.Email == "")
            {
                MessageBox.Show("Niste uneli e-mail!");
                return false;
            }

            if (!govornik.Email.Contains('@'))
            {
                MessageBox.Show("Niste uneli e-mail u ispravnom formatu!");
                return false;
            }

            govornik.Kompanija = txtKompanija.Text;
            if (govornik.Kompanija == "")
            {
                MessageBox.Show("Niste uneli kompaniju!");
                return false;
            }

            govornik.Zemlja = cmbZemlja.SelectedItem as Zemlja;

            if (govornik.Zemlja == null)
            {
                MessageBox.Show("Niste odabrali zemlju!");
                return false;
            }

            if (rbMuski.Checked == true)
            {
                govornik.Pol = rbMuski.Text;
            }
            else
            {
                govornik.Pol = rbZenski.Text;
            }

            if (!rbMuski.Checked && !rbZenski.Checked)
            {
                MessageBox.Show("Niste odabrali pol predavača!");
                return false;
            }


            Object rez = komunikacija.zapamtiPredavaca(govornik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti predavača!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio predavača!");
                return true;
            }

        }

        public void kreirajSalu(TextBox txtID, Button btnKreirajSalu, GroupBox groupBox1)
        {
            sala = komunikacija.kreirajSalu() as Sala;

            if (sala == null)
            {
                MessageBox.Show("Sistem ne može da kreira novu salu!");
            }
            else
            {
                
                txtID.Text = sala.SifraSale.ToString();
                btnKreirajSalu.Enabled = false;
                groupBox1.Enabled = true;
                MessageBox.Show("Nova sala je kreirana! Unesite tražene podatke kako biste je uspešno sačuvali.");
            }

        }

        public bool zapamtiSalu(TextBox txtImeSale, TextBox txtHotel, TextBox txtSprat, TextBox txtSponzor)
        {
            
            sala.ImeSale = txtImeSale.Text;
            if (sala.ImeSale == "")
            {
                MessageBox.Show("Niste uneli ime sale!");
                return false;
            }

            sala.Hotel = txtHotel.Text;
            if (sala.Hotel == "")
            {
                MessageBox.Show("Niste uneli naziv hotela!");
                return false;
            }

            try
            {
                sala.Sprat = Convert.ToInt32(txtSprat.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli sprat!");
                return false;
            }

            sala.Sponzor = txtSponzor.Text;
            if (sala.Sponzor == "")
            {
                MessageBox.Show("Niste uneli sponzora sale!");
                return false;
            }


            Object rez = komunikacija.zapamtiSalu(sala);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti salu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio salu!");
                return true;
            }
        }

        public void kreirajRaspored(TextBox txtID, Button button1, GroupBox groupBox1)
        {
            raspored = komunikacija.kreirajRaspored() as Raspored;

            if (raspored == null)
            {
                MessageBox.Show("Sistem ne može da kreira novi raspored!");
            }
            else
            {

                txtID.Text = raspored.SifraRasporeda.ToString();
                button1.Enabled = false;
                groupBox1.Enabled = true;
                MessageBox.Show("Novi raspored je kreiran! Unesite tražene podatke kako biste ga uspešno sačuvali.");
            }

        }

        public bool zapamtiRaspored(DateTimePicker dateTimePicker1, TextBox textBox1, TextBox textBox2)
        {
            raspored.Datum = Convert.ToDateTime(dateTimePicker1.Value);

            if (raspored.Datum < DateTime.Now)
            {
                MessageBox.Show("Nije moguće napraviti raspored u prošlosti!");
                return false;
            }

            raspored.VodjaPrograma = textBox1.Text;

            if (raspored.VodjaPrograma == "")
            {
                MessageBox.Show("Niste uneli ime i prezime vođe programa!");
                return false;
            }

            raspored.PauzaZaRucak = Convert.ToDateTime(textBox2.Text);

            if (raspored.PauzaZaRucak.Hour < 12 || raspored.PauzaZaRucak.Hour > 14)
            {
                MessageBox.Show("Niste uneli ime i prezime vođe programa!");
                return false;
            }

            Object rez = komunikacija.zapamtiRaspored(raspored);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti raspored!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio raspored!");
                return true;
            }
        }

        public void pretraziPredavace(TextBox txtFilter, DataGridView dgvPredavac)
        {
            govornik = new Govornik();
            govornik.Uslovi = " ImeGovornika like '" + txtFilter.Text + "%' or PrezimeGovornika like '" + txtFilter.Text + "%' or Pol like '" + txtFilter.Text + "%' or Kompanija like '%" + txtFilter.Text + "%'";

            List<Govornik> lista = komunikacija.pretraziGovornike(govornik) as List<Govornik>;
            dgvPredavac.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe predavače!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Ne postoje predavači koji odgovaraju zadatom kriterijumu!");
                return;
            }
            
        }

        public bool pronadjiPredavaca(DataGridView dataGridView1)
        {
            try
            {
                govornik = dataGridView1.CurrentRow.DataBoundItem as Govornik;

                govornik = komunikacija.pronadjiGovornika(govornik) as Govornik;

                if (govornik == null)
                {
                    MessageBox.Show("Sistem ne može da učita podatke o izabranom predavaču!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspešno učitao podatke o izabranom predavaču!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali predavača!");
                return false;
            }
        }

        public void popuniPoljaPredavac(TextBox txtImeP, TextBox txtPrezimeP, TextBox txtID, TextBox txtSSS, ComboBox cmbZemlja, TextBox txtKompanija, TextBox txtEmail, RadioButton rbMuski, RadioButton rbZenski)
        {
            
            cmbZemlja.DataSource = komunikacija.vratiSveZemlje();

            
            txtImeP.Text = govornik.ImeGovornika;
            txtPrezimeP.Text = govornik.PrezimeGovornika;
            txtID.Text = govornik.SifraGovornika.ToString();
            txtSSS.Text = govornik.StepenStrucneSpreme.ToString();
            txtEmail.Text = govornik.Email;
            cmbZemlja.Text = govornik.Zemlja.ToString();
            txtKompanija.Text = govornik.Kompanija.ToString();

            if (govornik.Pol == "Muški")
            {
                rbMuski.Checked = true;
            }
            else rbZenski.Checked = true;
        }

        public Predavanje zapamtiPredavanje(TextBox txtTema, ComboBox cmbPredavac, ComboBox cmbSala, TextBox txtTrajanje, TextBox txtVremePocetka, ComboBox cmbRaspored, DataGridView dgv)
        {
            predavanje = new Predavanje();

            predavanje.Tema = txtTema.Text;
            if (predavanje.Tema == "")
            {
                MessageBox.Show("Niste uneli temu predavanja!");
                

            }

            predavanje.Govornik = cmbPredavac.SelectedItem as Govornik;
            if (predavanje.Govornik == null)
            {
                MessageBox.Show("Neophodno je odabrati predavača!");
               // return false;
            }

            predavanje.Sala = cmbSala.SelectedItem as Sala;
            if (predavanje.Sala == null)
            {
                MessageBox.Show("Neophodno je odabrati salu!");
                // false;
            }

            predavanje.Raspored = cmbRaspored.SelectedItem as Raspored;
            if (predavanje.Raspored == null)
            {
                MessageBox.Show("Neophodno je odabrati raspored kom predavanje pripada!");
                //return false;
            }

            predavanje.Satnica = Convert.ToDateTime(txtVremePocetka.Text);
            if (predavanje.Satnica == null)
            {
                MessageBox.Show("Niste uneli vreme početka predavanja!");
                //return false;
            }

            Predavanje pr = new Predavanje();
            pr.Uslovi = " Tema like '%'"; 
            List<Predavanje> listaPredavanja = komunikacija.pretraziPredavanja(pr) as List<Predavanje>;

            foreach (Predavanje p in listaPredavanja)
            {
                if (predavanje.Sala.ID == p.Sala.ID && predavanje.Satnica.Hour==p.Satnica.Hour && predavanje.Raspored.Datum==p.Raspored.Datum)
                {
                    MessageBox.Show("U odabranoj sali već postoji predavanje u ovom terminu!");
                    //return false;
                }
            }

            predavanje.Trajanje = Convert.ToDateTime(txtTrajanje.Text);
            if (predavanje.Trajanje == null)
            {
                MessageBox.Show("Niste uneli trajanje predavanja!");
               // return false;
            }

            if (predavanje.Trajanje.Hour < 1 && predavanje.Trajanje.Minute < 25)
            {
                MessageBox.Show("Predavanje mora trajati barem 25 minuta!");
//return false;
            }

            if (predavanje.Trajanje.Hour >= 1 && predavanje.Trajanje.Minute > 30)
            {
                MessageBox.Show("Predavanje ne sme trajati više od 1h 30min!");
                //return false;
            }

            List<Predavanje> predavanja = new List<Predavanje>();
            //predavanja.Add(predavanje);
            //dgv.DataSource = predavanja;

            return predavanje;
            
            
        }

        internal bool zapamtiSvaPredavanja(List<Predavanje> predavanja)
        {
            Object rez = komunikacija.zapamtiPredavanja(predavanja);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti predavanje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio predavanje!");
                return true;
            }
        }

        internal void ucitajListuPredavaca(ComboBox cmbPredavac)
        {
            cmbPredavac.DataSource = komunikacija.vratiSvePredavace();
        }

        internal void ucitajListuSala(ComboBox cmbSala)
        {
            cmbSala.DataSource = komunikacija.vratiSveSale();
        }

        internal void ucitajListuRasporeda(ComboBox cmbRaspored)
        {
            cmbRaspored.DataSource = komunikacija.vratiSveRasporede();
        }

        public void pretraziPredavanja(TextBox txtFilter, DataGridView dgvPredavanja)
        {
            predavanje = new Predavanje();
            predavanje.Uslovi = " Tema like '" + txtFilter.Text + "%'";

            List<Predavanje> lista = komunikacija.pretraziPredavanja(predavanje) as List<Predavanje>;
            dgvPredavanja.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe predavanja!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Ne postoje predavanja koji odgovaraju zadatom kriterijumu!");
                return;
            }

        }

        public bool pronadjiPredavanje(DataGridView dgvPredavanja)
        {
            try
            {
                predavanje = dgvPredavanja.CurrentRow.DataBoundItem as Predavanje;

                predavanje = komunikacija.pronadjiPredavanje(predavanje) as Predavanje;

                if (predavanje == null)
                {
                    MessageBox.Show("Sistem ne može da učita podatke o izabranom predavanju!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je uspešno učitao podatke o izabranom predavanju!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali predavanje!");
                return false;
            }
        }

        public void popuniPoljaPredavanje(TextBox txtTema, ComboBox cmbGovornik, ComboBox cmbSala, TextBox txtTrajanje, TextBox txtVremePocetka, ComboBox cmbRaspored)
        {

            cmbGovornik.DataSource = komunikacija.vratiSvePredavace();
            cmbSala.DataSource = komunikacija.vratiSveSale();
            cmbRaspored.DataSource = komunikacija.vratiSveRasporede();

            txtTema.Text = predavanje.Tema;
            txtTrajanje.Text = predavanje.Trajanje.ToString("HH:mm");
            txtVremePocetka.Text = predavanje.Satnica.ToString("HH:mm");
            cmbGovornik.Text = predavanje.Govornik.ToString();
            cmbSala.Text = predavanje.Sala.ToString();
            cmbRaspored.Text = predavanje.Raspored.ToString();

           
        }

        public bool azurirajPredavanje(TextBox txtTema, ComboBox cmbPredavac, ComboBox cmbSala, TextBox txtTrajanje, TextBox txtVremePocetka, ComboBox cmbRaspored)
        {
            
            predavanje.Tema = txtTema.Text;
            if (predavanje.Tema == "")
            {
                MessageBox.Show("Niste uneli temu predavanja!");
                return false;
            }

            predavanje.Govornik = cmbPredavac.SelectedItem as Govornik;
            if (predavanje.Govornik == null)
            {
                MessageBox.Show("Neophodno je odabrati predavača!");
                return false;
            }

            predavanje.Sala = cmbSala.SelectedItem as Sala;
            if (predavanje.Sala == null)
            {
                MessageBox.Show("Neophodno je odabrati salu!");
                return false;
            }

            predavanje.Raspored = cmbRaspored.SelectedItem as Raspored;
            if (predavanje.Raspored == null)
            {
                MessageBox.Show("Neophodno je odabrati raspored kom predavanje pripada!");
                return false;
            }

            predavanje.Satnica = Convert.ToDateTime(txtVremePocetka.Text);
            if (predavanje.Satnica == null)
            {
                MessageBox.Show("Niste uneli vreme početka predavanja!");
                return false;
            }

            Predavanje pr = new Predavanje();
            pr.Uslovi = " Tema like '%'";
            List<Predavanje> listaPredavanja = komunikacija.pretraziPredavanja(pr) as List<Predavanje>;

            foreach (Predavanje p in listaPredavanja)
            {
                if (predavanje.Sala.ID == p.Sala.ID && predavanje.Satnica.Hour == p.Satnica.Hour && predavanje.Raspored.Datum == p.Raspored.Datum)
                {
                    MessageBox.Show("U odabranoj sali već postoji predavanje u ovom terminu!");
                    return false;
                }
            }

            predavanje.Trajanje = Convert.ToDateTime(txtTrajanje.Text);
            if (predavanje.Trajanje == null)
            {
                MessageBox.Show("Niste uneli trajanje predavanja!");
                return false;
            }

            if (predavanje.Trajanje.Hour < 1 && predavanje.Trajanje.Minute < 25)
            {
                MessageBox.Show("Predavanje mora trajati barem 25 minuta!");
                return false;
            }

            if (predavanje.Trajanje.Hour >= 1 && predavanje.Trajanje.Minute > 30)
            {
                MessageBox.Show("Predavanje ne sme trajati više od 1h 30min!");
                return false;
            }

            Object rez = komunikacija.azurirajPredavanje(predavanje);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti predavanje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio predavanje!");
                return true;
            }
        }

        public bool obrisiGovornika(DataGridView dataGridView1)
        {
            govornik = dataGridView1.CurrentRow.DataBoundItem as Govornik;
            Object rez = komunikacija.obrisiGovornika(govornik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše govornika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno obrisao govornika!");
                return true;
            }
        }

        public bool obrisiPredavanje(DataGridView dataGridView1)
        {
            predavanje = dataGridView1.CurrentRow.DataBoundItem as Predavanje;
            Object rez = komunikacija.obrisiPredavanje(predavanje);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše predavanje!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno obrisao predavanje!");
                return true;
            }
        }
    }
}
