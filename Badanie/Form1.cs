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
        public Form1()
        {
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
        public void Godzina()
        {
            DateTime time = DateTime.Now;
            tpAktualna_Godzina.Format = DateTimePickerFormat.Custom;
            tpAktualna_Godzina.CustomFormat = "hh:mm";
            tpAktualna_Godzina.Value = time;
        }
        public void Dzien()
        {
            DateTime thisDay = DateTime.Today;
            tpAktualna_Data.Value = thisDay;
        }
    }
}
