using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inkopslistan_ovn_2_8
{
    public partial class frmInköpslista : Form
    {
        List<Vara> varor = new List<Vara>();

        public frmInköpslista()
        {
            InitializeComponent();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            string namn = tbxVara.Text;
            double pris;
            if(!double.TryParse(tbxPris.Text, out pris))
            {
                MessageBox.Show("Felaktigt format på pris", Text);
                return;
            }

            Vara vara = null;
            if (rbnLösvikt.Checked)//Om det är lösvikt
            {
                double mängd;
                if(!double.TryParse(tbxMängd.Text, out mängd)){
                    MessageBox.Show("Felaktigt format på mängd", Text);
                    return;
                }
                vara = new LösVikt(namn, pris, mängd);
            }
            else // Om det är styckvaror
            {
                int mängd;
                if (!int.TryParse(tbxMängd.Text, out mängd))
                {
                    MessageBox.Show("Felaktigt format på mängd", Text);
                    return;
                }
                vara = new StyckSak(namn, pris, mängd);
            }

            //Lägg till varan i listan och listboxen
            varor.Add(vara);
            lbxLista.Items.Add(vara);


            double summa = 0;
            foreach(Vara v in varor)
            {
                summa += v.BeräknaPris();
            }

            tbxSumma.Text = summa.ToString();
        }
    }
}
