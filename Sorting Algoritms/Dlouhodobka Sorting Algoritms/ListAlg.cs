using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class ListAlg : Form
    {
        Vizualizace f3;

        public ListAlg()
        {
            InitializeComponent();
        }

        private void btn_BubbleSort_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 1, cb_Fast.Checked);

        }

        public void LoadOkna(Vizualizace f3, int alg, bool fast)
        {
            if (f3 == null || f3.IsDisposed)
            {
                try
                {
                    f3 = new Vizualizace(Convert.ToInt32(tb_PocetPrvku.Text), Convert.ToInt32(tb_Delay.Text), alg, fast);
                }
                catch
                {
                    MessageBox.Show("Zadejte čísla ve správném formátu", "Kritická chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            f3.Show();
            f3.Activate();
        }

        private void btn_OddEven_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 2, cb_Fast.Checked);
        }

        private void cb_Fast_CheckedChanged(object sender, EventArgs e)
        {
            tb_Delay.ReadOnly = cb_Fast.Checked;
        }

        private void btn_Quick_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 3, cb_Fast.Checked);
        }

        private void btn_Bogo_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 4, cb_Fast.Checked);
        }

        private void btn_Heap_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 5, cb_Fast.Checked);
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 6, cb_Fast.Checked);
        }

        private void btn_BubbleHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Maximální doporučená velikost pole: 100\n" +
                "Maximální doporučená velikost pole v rychlém režimu: 700\n \n" +
                "Bubble sort je jednoduchý algoritmus řazení, který postupně prochází seznamem prvků a postupně prohazuje sousední prvky, pokud nejsou ve správném pořadí. Tento proces se opakuje, dokud není seznam plně setříděn.\n\n" +
                "Tento algoritmus je poměrně jednoduchý, ale může být neefektivní pro velké seznamy, protože vyžaduje opakované průchody seznamem. Jeho časová složitost je O(n^2), kde n je počet prvků v seznamu."
                , "Bubble Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_OddHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Maximální doporučená velikost pole: 130\n" +
                "Maximální doporučená velikost pole v rychlém režimu: 750\n \n" +
                "Odd-even sort (také známý jako Brick sort) je algoritmus řazení podobný bubble sortu, ale pracuje s párovými průchody seznamem. Každý první průchod řadí sudé indexy a druhý průchod řadí liché indexy.\n\n" +
                "Tento algoritmus má časovou složitost O(n^2), ale může být efektivnější než bubble sort pro některé typy dat a pro určité implementace."
                , "Odd-Even Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_QuickHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Maximální doporučená velikost pole: 600\n" +
               "Maximální doporučená velikost pole v rychlém režimu: 2000\n \n" +
               "Quick sort je efektivní algoritmus řazení, který používá princip rozděl a panuj. Základní myšlenka spočívá v rozdělení seznamu na menší podseznamy, které jsou řazeny nezávisle na sobě. Tento algoritmus se často implementuje rekurzivně.\n\n" +
               "Quick sort je efektivní algoritmus s průměrnou časovou složitostí O(n log n). Nicméně v nejhorším případě může mít časovou složitost O(n^2), což nastane, pokud je pivot vybrán tak, že rozdělení seznamu vytvoří jedno prázdné a jedno plné podpole."
               , "Quick Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_BogoHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Maximální doporučená velikost pole: 5\n" +
               "Maximální doporučená velikost pole v rychlém režimu: 7\n \n" +
               "Bogo sort je velmi neefektivní algoritmus řazení, který je spíše vtipný než použitelný v reálných situacích. Jeho základní princip spočívá v náhodném promíchání seznamu a kontrole, zda je seznam setříděn. Pokud není setříděn, promíchá se znovu a tento proces se opakuje, dokud není seznam setříděn.\n\n" +
               "Bogo sort nemá garantovanou časovou složitost a může trvat prakticky nekonečně dlouho na setřídění seznamu, zejména pokud je seznam velký. Je to použitelné spíše jako ukázkový příklad neefektivního algoritmu než jako skutečně použitelný algoritmus řazení."
               , "Bogo Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_HeapHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Maximální doporučená velikost pole: 300\n" +
               "Maximální doporučená velikost pole v rychlém režimu: 900\n \n" +
               "Heap sort je efektivní algoritmus řazení, který využívá vlastností binárních hald. Haldy jsou binární stromy, ve kterých je každý uzel větší (nebo menší) než jeho děti, přičemž kořen stromu má nejvyšší (nebo nejnižší) hodnotu. V heap sortu se využívá max-heap (nebo min-heap), kde nejvyšší hodnota (nebo nejnižší hodnota) je na kořeni haldy.\n\n" +
               "Heap sort má časovou složitost O(n log n), což ho činí efektivním algoritmem pro řazení, zejména pro velké seznamy."
               , "Heap Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
