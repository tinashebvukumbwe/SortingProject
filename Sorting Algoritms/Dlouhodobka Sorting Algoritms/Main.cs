using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Main : Form
    {
        ListAlg f2;
        Porovnání f3;

        public Main()
        {
            InitializeComponent();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new ListAlg();
            }

            f2.Show();
            f2.Activate();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Porovnání();
            }

            f3.Show();
            f3.Activate();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Počet porovnání znamená, kolikrát algoritmus porovnává 2 čísla.\n\n" +
               "Počet zápisů znamená, kolikrát algoritmus prohodil 2 čísla.\n\n" +
               "Důvod doporučované maximální velikosti je ten, že po startu algoritmu není cesty zpět a musí se počkat na dokončení.\n\n" +
               "Zašrtávací okénka 'Zakázat' vyloučí daný algoritmus z celkového testu.\n\n" +
               "Lišta průběhu algoritmu(Progress bar) je u některých algorimů pouhý odhad, tudíž ho nelze brát jako rozhodující faktor. Pro přesnější grafické zobrazení přejděte do listu algoritmů a posuďte je individuálně."
               , "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
