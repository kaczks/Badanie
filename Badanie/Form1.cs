using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badanie
{
    public partial class Form1 : Form
    {
        public class Kolejka //deklarownie kolejki
        {
            public Kolejka next;
            public string komotka = "";
        }

        public class queue
        {
            private Kolejka start;
            private Kolejka koniec;

            public queue() //konstruktor
            {
                start = koniec = null;
            }

            public void Des() //destruktor
            {
                while (start != null)
                {
                    usun();
                }
            }

            public bool pusty()  // sprawdz czy jest pusta (funkcja)
            {
                return start == null;
            }

            public string przod() // zwroc poczatek (funkcja)
            {
                if (start != null)
                {
                    return start.komotka;
                }
                else
                {
                    return "Zle";
                }
            }

            public void Zapisz(string Kol) //zapisywanie do kolejki (funkcja)
            {
                Kolejka k = new Kolejka();
                k.next = null;
                k.komotka = Kol;
                if (koniec != null)
                {
                    koniec.next = k;
                }
                else
                {
                    start = k;
                }
                koniec = k;
            }
            public void usun() //usuwanie z kolejki (funkcja)
            {
                if (start != null)
                {
                    Kolejka k = start;
                    start = start.next;
                    if (start == null)
                    {
                        koniec = null;
                    }
                    k = null;
                }
            }
        }
        private queue Badanie_kolejka = new queue();
        public Form1()
        {//
            ////
            InitializeComponent();
            Godzina();
            Dzien();
        }

        private void lData_Click(object sender, EventArgs e)
        {

        }

        private void lImie_Click(object sender, EventArgs e)
        {

        }

        private void tpAktualna_Data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tpAktualna_Godzina_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Godzina() // aktualna godzina
        {
            DateTime time = DateTime.Now;
            tpAktualna_Godzina.Format = DateTimePickerFormat.Custom;
            tpAktualna_Godzina.CustomFormat = "HH:mm";
            tpAktualna_Godzina.Value = time;
        }
        public void Dzien() //aktualny dzien
        {
            DateTime thisDay = DateTime.Today;
            tpAktualna_Data.Value = thisDay;
        }

        private void refresh_Tick(object sender, EventArgs e) //Daty
        {
            Godzina();
            Dzien();
        }
        struct NFZ // struktura
        {
            public string Imie;
            public string Nazwa_Badania;
            public DateTime Data_Badania;
        }
        NFZ pacjet;
        private void btnDodaj_Click(object sender, EventArgs e) // Zapisywanie do struktury
        {
            pacjet.Imie = tbImie.Text;
            pacjet.Nazwa_Badania = tbBadania.Text;
            pacjet.Data_Badania = tpData_Badania.Value;

            Imie_label.Text = pacjet.Imie;
            Badanie_label.Text = pacjet.Nazwa_Badania;
            tp_Badania.Value = pacjet.Data_Badania;

            //Zapisywanie do kolejki
            Badanie_kolejka.Zapisz(tbImie.Text);
            Badanie_kolejka.Zapisz(tbBadania.Text);
            Badanie_kolejka.Zapisz(tpData_Badania.Value.ToString());


        }
        private void Dane_pacjeta_Click(object sender, EventArgs e)
        {

        }

        private void btn_wypisz_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i++)
            {
                WypKol.Text += Badanie_kolejka.przod() + "\n";
                Badanie_kolejka.usun();
            }
        }
    }
}
