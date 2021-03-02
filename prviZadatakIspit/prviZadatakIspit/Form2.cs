using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prviZadatakIspit
{
    public partial class Form2 : Form
    {
        List<Osoba> Lista = new List<Osoba>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(textBoxIme.Text, textBoxPrezime.Text, Convert.ToInt32(textBoxOib.Text), Convert.ToDateTime(dateTimePickerDatum.Text));

            Lista.Add(osoba);

            

            this.Close();


        }
    }
}
