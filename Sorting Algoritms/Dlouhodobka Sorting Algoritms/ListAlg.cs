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
                    MessageBox.Show("Enter the numbers in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                "Maximum recommended field size: 100\n" +
                "Maximum recommended field size in fast mode: 700\n \n" +
                "Bubble sort is a simple sorting algorithm that sequentially goes through a list of elements and sequentially drops adjacent elements if they are not in the correct order. This process is repeated until the list is fully sorted.\n\n\n" +
                "This algorithm is relatively simple, but can be inefficient for large lists because it requires repeated passes through the list. Its time complexity is O(n^2), where n is the number of elements in the list.",
                "Bubble Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_OddHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Maximum recommended field size: 130\n" +
                "Maximum recommended field size in fast mode: 750\n \n" +
                "Odd-even sort (also known as Brick sort) is a sorting algorithm similar to bubble sort, but works with paired passes through a list. Each first pass sorts even indexes and the second pass sorts odd indexes.\n\n\n" +
                "This algorithm has a time complexity of O(n^2), but may be more efficient than bubble sort for some data types and for certain implementations."
                , "Odd-Even Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_QuickHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Maximum recommended field size: 600\n" +
               "Maximum recommended field size in fast mode: 2000\n \n" +
               "Quick sort is an efficient sorting algorithm that uses the divide and conquer principle. The basic idea is to divide the list into smaller sublists that are sorted independently of each other. This algorithm is often implemented recursively.\n\n" +
               "Quick sort is an efficient algorithm with an average time complexity of O(n log n). However, in the worst case it can have a time complexity of O(n^2), which occurs if the pivot is chosen such that splitting the list produces one empty and one full subarray.", "Quick Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_BogoHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Maximum recommended field size: 5\n" +
               "Maximum recommended field size in fast mode: 7\n \n" +
               "Bogo sort is a very inefficient sorting algorithm that is more of a joke than usable in real-world situations. Its basic principle is to randomly shuffle the list and check if the list is sorted. If it is not sorted, it is shuffled again and this process is repeated until the list is sorted." + 
               "Bogo sort has no guaranteed time complexity and can take almost infinitely long to sort a list, especially if the list is large. It is more useful as an example of an inefficient algorithm than as a truly usable sorting algorithm.",
               "Bogo Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_HeapHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Maximum recommended field size: 300\n" +
               "Maximum recommended field size in fast mode: 900\n \n" +
               "Heap sort is an efficient sorting algorithm that takes advantage of the properties of binary heaps. Heaps are binary trees in which each node is larger (or smaller) than its children, with the root of the tree having the highest (or lowest) value. The heap sort uses max-heap (or min-heap), where the highest value (or lowest value) is at the root of the heap.\n\n" +
               "Heap sort has a time complexity of O(n log n), which makes it an efficient sorting algorithm, especially for large lists.",
               "Heap Sort Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
