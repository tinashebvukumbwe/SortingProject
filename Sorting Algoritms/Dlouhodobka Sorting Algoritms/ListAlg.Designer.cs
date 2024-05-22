namespace Dlouhodobka_Sorting_Algoritms
{
    partial class ListAlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_BubbleSort = new System.Windows.Forms.Button();
            this.tb_PocetPrvku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Delay = new System.Windows.Forms.TextBox();
            this.btn_OddEven = new System.Windows.Forms.Button();
            this.cb_Fast = new System.Windows.Forms.CheckBox();
            this.btn_Quick = new System.Windows.Forms.Button();
            this.btn_Bogo = new System.Windows.Forms.Button();
            this.btn_Heap = new System.Windows.Forms.Button();
            this.btn_BubbleHelp = new System.Windows.Forms.Button();
            this.btn_OddHelp = new System.Windows.Forms.Button();
            this.btn_QuickHelp = new System.Windows.Forms.Button();
            this.btn_BogoHelp = new System.Windows.Forms.Button();
            this.btn_HeapHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BubbleSort
            // 
            this.btn_BubbleSort.Location = new System.Drawing.Point(32, 28);
            this.btn_BubbleSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BubbleSort.Name = "btn_BubbleSort";
            this.btn_BubbleSort.Size = new System.Drawing.Size(309, 80);
            this.btn_BubbleSort.TabIndex = 0;
            this.btn_BubbleSort.Text = "Bubble Sort";
            this.btn_BubbleSort.UseVisualStyleBackColor = true;
            this.btn_BubbleSort.Click += new System.EventHandler(this.btn_BubbleSort_Click);
            // 
            // tb_PocetPrvku
            // 
            this.tb_PocetPrvku.Location = new System.Drawing.Point(609, 25);
            this.tb_PocetPrvku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PocetPrvku.Name = "tb_PocetPrvku";
            this.tb_PocetPrvku.Size = new System.Drawing.Size(64, 22);
            this.tb_PocetPrvku.TabIndex = 1;
            this.tb_PocetPrvku.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of elements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Length of delay between corks:";
            // 
            // tb_Delay
            // 
            this.tb_Delay.Location = new System.Drawing.Point(609, 57);
            this.tb_Delay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Delay.Name = "tb_Delay";
            this.tb_Delay.Size = new System.Drawing.Size(64, 22);
            this.tb_Delay.TabIndex = 4;
            this.tb_Delay.Text = "10";
            // 
            // btn_OddEven
            // 
            this.btn_OddEven.Location = new System.Drawing.Point(32, 116);
            this.btn_OddEven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OddEven.Name = "btn_OddEven";
            this.btn_OddEven.Size = new System.Drawing.Size(309, 80);
            this.btn_OddEven.TabIndex = 5;
            this.btn_OddEven.Text = "Odd-Even Sort";
            this.btn_OddEven.UseVisualStyleBackColor = true;
            this.btn_OddEven.Click += new System.EventHandler(this.btn_OddEven_Click);
            // 
            // cb_Fast
            // 
            this.cb_Fast.AutoSize = true;
            this.cb_Fast.Location = new System.Drawing.Point(571, 101);
            this.cb_Fast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Fast.Name = "cb_Fast";
            this.cb_Fast.Size = new System.Drawing.Size(104, 20);
            this.cb_Fast.TabIndex = 6;
            this.cb_Fast.Text = "Rapid mode";
            this.cb_Fast.UseVisualStyleBackColor = true;
            this.cb_Fast.CheckedChanged += new System.EventHandler(this.cb_Fast_CheckedChanged);
            // 
            // btn_Quick
            // 
            this.btn_Quick.Location = new System.Drawing.Point(32, 204);
            this.btn_Quick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Quick.Name = "btn_Quick";
            this.btn_Quick.Size = new System.Drawing.Size(309, 80);
            this.btn_Quick.TabIndex = 7;
            this.btn_Quick.Text = "Quick Sort";
            this.btn_Quick.UseVisualStyleBackColor = true;
            this.btn_Quick.Click += new System.EventHandler(this.btn_Quick_Click);
            // 
            // btn_Bogo
            // 
            this.btn_Bogo.Location = new System.Drawing.Point(32, 292);
            this.btn_Bogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Bogo.Name = "btn_Bogo";
            this.btn_Bogo.Size = new System.Drawing.Size(309, 80);
            this.btn_Bogo.TabIndex = 8;
            this.btn_Bogo.Text = "Bogo Sort";
            this.btn_Bogo.UseVisualStyleBackColor = true;
            this.btn_Bogo.Click += new System.EventHandler(this.btn_Bogo_Click);
            // 
            // btn_Heap
            // 
            this.btn_Heap.Location = new System.Drawing.Point(32, 379);
            this.btn_Heap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Heap.Name = "btn_Heap";
            this.btn_Heap.Size = new System.Drawing.Size(309, 80);
            this.btn_Heap.TabIndex = 9;
            this.btn_Heap.Text = "Heap Sort";
            this.btn_Heap.UseVisualStyleBackColor = true;
            this.btn_Heap.Click += new System.EventHandler(this.btn_Heap_Click);
            // 
            // btn_BubbleHelp
            // 
            this.btn_BubbleHelp.Location = new System.Drawing.Point(349, 54);
            this.btn_BubbleHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BubbleHelp.Name = "btn_BubbleHelp";
            this.btn_BubbleHelp.Size = new System.Drawing.Size(31, 28);
            this.btn_BubbleHelp.TabIndex = 10;
            this.btn_BubbleHelp.Text = "?";
            this.btn_BubbleHelp.UseVisualStyleBackColor = true;
            this.btn_BubbleHelp.Click += new System.EventHandler(this.btn_BubbleHelp_Click);
            // 
            // btn_OddHelp
            // 
            this.btn_OddHelp.Location = new System.Drawing.Point(349, 142);
            this.btn_OddHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OddHelp.Name = "btn_OddHelp";
            this.btn_OddHelp.Size = new System.Drawing.Size(31, 28);
            this.btn_OddHelp.TabIndex = 11;
            this.btn_OddHelp.Text = "?";
            this.btn_OddHelp.UseVisualStyleBackColor = true;
            this.btn_OddHelp.Click += new System.EventHandler(this.btn_OddHelp_Click);
            // 
            // btn_QuickHelp
            // 
            this.btn_QuickHelp.Location = new System.Drawing.Point(349, 230);
            this.btn_QuickHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QuickHelp.Name = "btn_QuickHelp";
            this.btn_QuickHelp.Size = new System.Drawing.Size(31, 28);
            this.btn_QuickHelp.TabIndex = 12;
            this.btn_QuickHelp.Text = "?";
            this.btn_QuickHelp.UseVisualStyleBackColor = true;
            this.btn_QuickHelp.Click += new System.EventHandler(this.btn_QuickHelp_Click);
            // 
            // btn_BogoHelp
            // 
            this.btn_BogoHelp.Location = new System.Drawing.Point(349, 318);
            this.btn_BogoHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BogoHelp.Name = "btn_BogoHelp";
            this.btn_BogoHelp.Size = new System.Drawing.Size(31, 28);
            this.btn_BogoHelp.TabIndex = 13;
            this.btn_BogoHelp.Text = "?";
            this.btn_BogoHelp.UseVisualStyleBackColor = true;
            this.btn_BogoHelp.Click += new System.EventHandler(this.btn_BogoHelp_Click);
            // 
            // btn_HeapHelp
            // 
            this.btn_HeapHelp.Location = new System.Drawing.Point(349, 405);
            this.btn_HeapHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HeapHelp.Name = "btn_HeapHelp";
            this.btn_HeapHelp.Size = new System.Drawing.Size(31, 28);
            this.btn_HeapHelp.TabIndex = 14;
            this.btn_HeapHelp.Text = "?";
            this.btn_HeapHelp.UseVisualStyleBackColor = true;
            this.btn_HeapHelp.Click += new System.EventHandler(this.btn_HeapHelp_Click);
            // 
            // ListAlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 476);
            this.Controls.Add(this.btn_HeapHelp);
            this.Controls.Add(this.btn_BogoHelp);
            this.Controls.Add(this.btn_QuickHelp);
            this.Controls.Add(this.btn_OddHelp);
            this.Controls.Add(this.btn_BubbleHelp);
            this.Controls.Add(this.btn_Heap);
            this.Controls.Add(this.btn_Bogo);
            this.Controls.Add(this.btn_Quick);
            this.Controls.Add(this.cb_Fast);
            this.Controls.Add(this.btn_OddEven);
            this.Controls.Add(this.tb_Delay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_PocetPrvku);
            this.Controls.Add(this.btn_BubbleSort);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListAlg";
            this.Text = "List Algoritmů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BubbleSort;
        private System.Windows.Forms.TextBox tb_PocetPrvku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Delay;
        private System.Windows.Forms.Button btn_OddEven;
        private System.Windows.Forms.CheckBox cb_Fast;
        private System.Windows.Forms.Button btn_Quick;
        private System.Windows.Forms.Button btn_Bogo;
        private System.Windows.Forms.Button btn_Heap;
        private System.Windows.Forms.Button btn_BubbleHelp;
        private System.Windows.Forms.Button btn_OddHelp;
        private System.Windows.Forms.Button btn_QuickHelp;
        private System.Windows.Forms.Button btn_BogoHelp;
        private System.Windows.Forms.Button btn_HeapHelp;
    }
}