﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Porovnání : Form
    {
        static Stopwatch stopwatch;

        static ProgressBar pbBubble;
        static ProgressBar pbOdd;
        static ProgressBar pbQuick;
        static ProgressBar pbBogo;
        static ProgressBar pbHeap;

        static CheckBox cbBubble;
        static CheckBox cbOdd;
        static CheckBox cbQuick;
        static CheckBox cbBogo;
        static CheckBox cbHeap;


        static Label lbBubbleCas;
        static Label lbBubblePorovnani;
        static Label lbBubbleZapis;
        static Label lbBubblePoradi;

        static Label lbOddCas;
        static Label lbOddPorovnani;
        static Label lbOddZapis;
        static Label lbOddPoradi;

        static Label lbQuickCas;
        static Label lbQuickPorovnani;
        static Label lbQuickZapis;
        static Label lbQuickPoradi;

        static Label lbBogoCas;
        static Label lbBogoPorovnani;
        static Label lbBogoZapis;
        static Label lbBogoPoradi;

        static Label lbHeapCas;
        static Label lbHeapPorovnani;
        static Label lbHeapZapis;
        static Label lbHeapPoradi;


        int[] numbers;
        static int pocet;
        static int porovnani = 0;
        static int zapis = 0;
        static double cas;

        static double[] casy = new double[5];



        public Porovnání()
        {
            InitializeComponent();
        }

        private void Porovnání_Load(object sender, EventArgs e)
        {
            porovnani = 0;
            zapis = 0;

            pbBubble = pb_bubble;
            pbOdd = pb_odd;
            pbQuick = pb_quick;
            pbBogo = pb_bogo;
            pbHeap = pb_heap;

            cbBubble = cb_bubble;
            cbOdd = cb_odd;
            cbQuick = cb_quick;
            cbBogo = cb_bogo;
            cbHeap = cb_heap;

            lbBubblePoradi = lb_BubblePoradi;
            lbOddPoradi = lb_OddPoradi;
            lbQuickPoradi = lb_QuickPoradi;
            lbBogoPoradi = lb_BogoPoradi;
            lbHeapPoradi = lb_HeapPoradi;


            lbBubbleCas = lb_BubbleCas;
            lbBubblePorovnani = lb_BubblePorovnani;
            lbBubbleZapis = lb_BubbleZapis;

            lbOddCas = lb_OddCas;
            lbOddPorovnani = lb_OddPorovnani;
            lbOddZapis = lb_OddZapis;

            lbQuickCas = lb_QuickCas;
            lbQuickPorovnani = lb_QuickPorovnani;
            lbQuickZapis = lb_QuickZapis;

            lbBogoCas = lb_BogoCas;
            lbBogoPorovnani = lb_BogoPorovnani;
            lbBogoZapis = lb_BogoZapis;

            lbHeapCas = lb_HeapCas;
            lbHeapPorovnani = lb_HeapPorovnani;
            lbHeapZapis = lb_HeapZapis;
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                pocet = Convert.ToInt32(tb_pocet.Text);
            }
            catch
            {
                MessageBox.Show("Zadejte číslo ve správném formátu","Kritická chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btn_start.Enabled = false;
            btn_start.BackColor = Color.LightGray;

            pbBubble.Maximum = pocet - 1;
            pbOdd.Maximum = (pocet * 2) - 1;
            pbHeap.Maximum = pocet - 1;
            pbQuick.Maximum = pocet + (pocet / 10);
            GenPole();



                BubbleSortAlgorithm(numbers);
            porovnani = 0;
            zapis = 0;
            GenPole();

                OddEvenSortAlgorithm(numbers);
            porovnani = 0;
            zapis = 0;
            GenPole();

            stopwatch = new Stopwatch();
            stopwatch.Start();
                Quick_Sort(numbers, 0, pocet - 1);
            stopwatch.Stop();
            if(!cbQuick.Checked)
            {
                cas = stopwatch.Elapsed.TotalMilliseconds;
                casy[2] = cas;
                pbQuick.Value = pbQuick.Maximum;
                lbQuickCas.Text = "Čas: " + cas + " ms";
                lbQuickPorovnani.Text = "Počet porovnání: " + porovnani;
                lbQuickZapis.Text = "Počet zápisů: " + zapis;
            }
            porovnani = 0;
            zapis = 0;
            GenPole();

                BogoSort(numbers);
            porovnani = 0;
            zapis = 0;
            GenPole();

                HeapSort(numbers);




            lbBubblePoradi.Text = "Pořadí: " + NajdiPoradi(casy, 0);
            lbOddPoradi.Text = "Pořadí: " + NajdiPoradi(casy, 1);
            lbQuickPoradi.Text = "Pořadí: " + NajdiPoradi(casy, 2);
            lbBogoPoradi.Text = "Pořadí: " + NajdiPoradi(casy, 3);
            lbHeapPoradi.Text = "Pořadí: " + NajdiPoradi(casy, 4);
        }

        public void GenPole()
        {
            // Vytvoření pole s čísly od 1 do 30
            numbers = Enumerable.Range(1, pocet).ToArray();

            // Vytvoření instance generátoru náhodných čísel
            Random random = new Random();

            // Protiření pole a pro každý prvek provést náhodnou výměnu s jiným prvkem
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomIndex = random.Next(i, numbers.Length);
                int temp = numbers[i];
                numbers[i] = numbers[randomIndex];
                numbers[randomIndex] = temp;
            }
        }

        static int NajdiPoradi(double[] pole, int index)
        {
            // Vytvoření pole indexů seřazených hodnot (ignorujeme hodnoty rovné 0)
            int[] indexy = Enumerable.Range(0, pole.Length)
                                      .Where(i => pole[i] != 0)
                                      .ToArray();

            // Seřazení pouze ne-nulových hodnot
            double[] neNuloveHodnoty = indexy.Select(i => pole[i]).ToArray();
            Array.Sort(neNuloveHodnoty, indexy);

            // Vyhledání pořadí na základě indexu
            for (int i = 0; i < neNuloveHodnoty.Length; i++)
            {
                if (indexy[i] == index)
                {
                    return i + 1; // Pořadí začíná od 1
                }
            }

            // Pokud index není nalezen, vrátit -1 nebo vhodnou hodnotu
            return 0;
        }

        static void BubbleSortAlgorithm(int[] arr)
        {
            if (cbBubble.Checked)
                return;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                    porovnani++;
                }
                pbBubble.Value++;
            }

            stopwatch.Stop();
            cas = stopwatch.Elapsed.TotalMilliseconds;
            casy[0] = cas;

            lbBubbleCas.Text = "Čas: " + cas + " ms";
            lbBubblePorovnani.Text = "Počet porovnání: " + porovnani;
            lbBubbleZapis.Text = "Počet zápisů: " + zapis;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            zapis++;
        }

        // Metoda pro provádění odd-even sort
        static void OddEvenSortAlgorithm(int[] arr)
        {
            if (cbOdd.Checked)
                return;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = arr.Length;
            bool sorted = false; // Zjistí, zda je pole již seřazené

            while (!sorted)
            {
                sorted = true;

                // Provádí se dvě fáze: lichá a sudá
                for (int i = 1; i < n - 1; i += 2) // Lichá fáze
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sorted = false;
                    }
                    porovnani++;
                }

                pbOdd.Value++;

                for (int i = 0; i < n - 1; i += 2) // Sudá fáze
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sorted = false;
                    }
                    porovnani++;
                }

                pbOdd.Value++;
            }

            pbOdd.Value = pbOdd.Maximum;

            stopwatch.Stop();
            cas = stopwatch.Elapsed.TotalMilliseconds;
            casy[1] = cas;

            lbOddCas.Text = "Čas: " + cas + " ms";
            lbOddPorovnani.Text = "Počet porovnání: " + porovnani;
            lbOddZapis.Text = "Počet zápisů: " + zapis;
        }


        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (cbQuick.Checked)
                return;

            // Check if there are elements to sort
            if (left < right)
            {
                // Find the pivot index
                int pivot = Partition(arr, left, right);

                // Recursively sort elements on the left and right of the pivot
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
            pbQuick.Value++;
        }

        // Method to partition the array
        static int Partition(int[] arr, int left, int right)
        {
            // Select the pivot element
            int pivot = arr[left];

            // Continue until left and right pointers meet
            while (true)
            {
                // Move left pointer until a value greater than or equal to pivot is found
                while (arr[left] < pivot)
                {
                    left++;
                    porovnani++;
                }

                // Move right pointer until a value less than or equal to pivot is found
                while (arr[right] > pivot)
                {
                    right--;
                    porovnani++;
                }

                // If left pointer is still smaller than right pointer, swap elements
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    Swap(arr, left, right);
                }
                else
                {
                    // Return the right pointer indicating the partitioning position
                    return right;
                }
            }
        }


        static void BogoSort(int[] arr)
        {
            if (cbBogo.Checked)
                return;

            Random random = new Random();
            stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!IsSorted(arr))
            {
                Shuffle(arr, random);
            }
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
                porovnani++;
            }
            pbBogo.Value = pbBogo.Maximum;

            stopwatch.Stop();
            cas = stopwatch.Elapsed.TotalMilliseconds;
            casy[3] = cas;

            lbBogoCas.Text = "Čas: " + cas + " ms";
            lbBogoPorovnani.Text = "Počet porovnání: " + porovnani;
            lbBogoZapis.Text = "Počet zápisů: " + zapis;
            return true;
        }

        static void Shuffle(int[] arr, Random random)
        {
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);

                Swap(arr, k, n);
            }
        }

        public void HeapSort(int[] array)
        {
            if (cbHeap.Checked)
                return;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                Swap(array, 0, i);

                // call max heapify on the reduced heap
                Heapify(array, i, 0);
                pbHeap.Value++;
            }

            stopwatch.Stop();
            cas = stopwatch.Elapsed.TotalMilliseconds;
            casy[4] = cas;

            lbHeapCas.Text = "Čas: " + cas + " ms";
            lbHeapPorovnani.Text = "Počet porovnání: " + porovnani;
            lbHeapZapis.Text = "Počet zápisů: " + zapis;
        }

        void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && array[l] > array[largest])
                largest = l;

            porovnani++;

            // If right child is larger than largest so far
            if (r < n && array[r] > array[largest])
                largest = r;

            porovnani++;

            // If largest is not root
            if (largest != i)
            {
                Swap(array, i, largest);

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }

            porovnani++;
        }






        private void btn_reset_Click(object sender, EventArgs e)
        {
            pbBubble.Value = 0;
            pbOdd.Value = 0;
            pbQuick.Value = 0;
            pbBogo.Value = 0;
            pbHeap.Value = 0;

            for(int i = 0;i < 5;i++)
            {
                casy[i] = 0;
            }

            pocet = 0;
            zapis = 0;
            porovnani = 0;
            btn_start.BackColor = Color.White;
            btn_start.Enabled = true;

            lbBubbleCas.Text = "Čas: ?? ms";
            lbBubblePorovnani.Text = "Počet porovnání: ??";
            lbBubbleZapis.Text = "Počet zápisů: ??";
            lbBubblePoradi.Text = "Pořadí: ??";

            lbOddCas.Text = "Čas: ?? ms";
            lbOddPorovnani.Text = "Počet porovnání: ??";
            lbOddZapis.Text = "Počet zápisů: ??";
            lbOddPoradi.Text = "Pořadí: ??";

            lbQuickCas.Text = "Čas: ?? ms";
            lbQuickPorovnani.Text = "Počet porovnání: ??";
            lbQuickZapis.Text = "Počet zápisů: ??";
            lbQuickPoradi.Text = "Pořadí: ??";

            lbBogoCas.Text = "Čas: ?? ms";
            lbBogoPorovnani.Text = "Počet porovnání: ??";
            lbBogoZapis.Text = "Počet zápisů: ??";
            lbBogoPoradi.Text = "Pořadí: ??";

            lbHeapCas.Text = "Čas: ?? ms";
            lbHeapPorovnani.Text = "Počet porovnání: ??";
            lbHeapZapis.Text = "Počet zápisů: ??";
            lbHeapPoradi.Text = "Pořadí: ??";
        }
    }
}
