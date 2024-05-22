namespace Dlouhodobka_Sorting_Algoritms
{
    partial class Vizualizace
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
            this.btn_Ready = new System.Windows.Forms.Button();
            this.lb_porovnani = new System.Windows.Forms.Label();
            this.lb_prvky = new System.Windows.Forms.Label();
            this.lb_zapisu = new System.Windows.Forms.Label();
            this.lb_cas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(635, 15);
            this.btn_Ready.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(100, 28);
            this.btn_Ready.TabIndex = 0;
            this.btn_Ready.Text = "Start";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // lb_porovnani
            // 
            this.lb_porovnani.AutoSize = true;
            this.lb_porovnani.Location = new System.Drawing.Point(924, 27);
            this.lb_porovnani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_porovnani.Name = "lb_porovnani";
            this.lb_porovnani.Size = new System.Drawing.Size(167, 16);
            this.lb_porovnani.TabIndex = 1;
            this.lb_porovnani.Text = "Number of comparisons ??";
            // 
            // lb_prvky
            // 
            this.lb_prvky.AutoSize = true;
            this.lb_prvky.Location = new System.Drawing.Point(16, 27);
            this.lb_prvky.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prvky.Name = "lb_prvky";
            this.lb_prvky.Size = new System.Drawing.Size(147, 16);
            this.lb_prvky.TabIndex = 2;
            this.lb_prvky.Text = "Number of elements: ??";
            // 
            // lb_zapisu
            // 
            this.lb_zapisu.AutoSize = true;
            this.lb_zapisu.Location = new System.Drawing.Point(1155, 27);
            this.lb_zapisu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_zapisu.Name = "lb_zapisu";
            this.lb_zapisu.Size = new System.Drawing.Size(132, 16);
            this.lb_zapisu.TabIndex = 3;
            this.lb_zapisu.Text = "Number of entries: ??";
            // 
            // lb_cas
            // 
            this.lb_cas.AutoSize = true;
            this.lb_cas.Location = new System.Drawing.Point(177, 27);
            this.lb_cas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cas.Name = "lb_cas";
            this.lb_cas.Size = new System.Drawing.Size(106, 16);
            this.lb_cas.TabIndex = 4;
            this.lb_cas.Text = "Elapsed time: ??";
            // 
            // Vizualizace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 554);
            this.Controls.Add(this.lb_cas);
            this.Controls.Add(this.lb_zapisu);
            this.Controls.Add(this.lb_prvky);
            this.Controls.Add(this.lb_porovnani);
            this.Controls.Add(this.btn_Ready);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vizualizace";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Vizualizace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Label lb_porovnani;
        private System.Windows.Forms.Label lb_prvky;
        private System.Windows.Forms.Label lb_zapisu;
        private System.Windows.Forms.Label lb_cas;
    }
}