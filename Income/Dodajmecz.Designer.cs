namespace Income
{
    partial class Dodajmecz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodajmecz));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.KlasaCb = new System.Windows.Forms.ComboBox();
            this.PodokregCb = new System.Windows.Forms.ComboBox();
            this.Kwota = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 83);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(111, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dodaj mecz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Klasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Podokręg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kwota";
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dodaj.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dodaj.ForeColor = System.Drawing.Color.Red;
            this.Dodaj.Location = new System.Drawing.Point(165, 484);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(147, 53);
            this.Dodaj.TabIndex = 19;
            this.Dodaj.Text = "DODAJ";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // KlasaCb
            // 
            this.KlasaCb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KlasaCb.FormattingEnabled = true;
            this.KlasaCb.Items.AddRange(new object[] {
            "IV Liga ",
            "Klasa OKR",
            "Klasa A",
            "Klasa B",
            "I Liga Jun.St.",
            "II Liga Jun.St.",
            "Juniorzy Podokręg",
            "IV Liga kobiet",
            "Tramp, Młodziki",
            "Juniorki Śl.ZPN",
            "Orliki,Żak,",
            "IV Liga linia ",
            "Klasa OKR linia",
            "Klasa A linia",
            "Klasa B linia",
            "I Liga Jun.St. linia",
            "II Liga Jun.St. linia",
            "Juniorzy Podokręg linia",
            "IV Liga kobiet linia"});
            this.KlasaCb.Location = new System.Drawing.Point(24, 138);
            this.KlasaCb.Name = "KlasaCb";
            this.KlasaCb.Size = new System.Drawing.Size(229, 39);
            this.KlasaCb.TabIndex = 20;
            this.KlasaCb.SelectedIndexChanged += new System.EventHandler(this.KlasaCb_SelectedIndexChanged);
            // 
            // PodokregCb
            // 
            this.PodokregCb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PodokregCb.FormattingEnabled = true;
            this.PodokregCb.Items.AddRange(new object[] {
            "Skoczów",
            "Bielsko-Biała",
            "Żywiec",
            "Bytom",
            "Częstochowa",
            "Katowice",
            "Lubliniec",
            "Racibórz",
            "Rybnik",
            "Sosnowiec",
            "Tychy",
            "Zabrze"});
            this.PodokregCb.Location = new System.Drawing.Point(24, 229);
            this.PodokregCb.Name = "PodokregCb";
            this.PodokregCb.Size = new System.Drawing.Size(229, 39);
            this.PodokregCb.TabIndex = 21;
            // 
            // Kwota
            // 
            this.Kwota.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kwota.Location = new System.Drawing.Point(24, 414);
            this.Kwota.Name = "Kwota";
            this.Kwota.Size = new System.Drawing.Size(229, 39);
            this.Kwota.TabIndex = 38;
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Month.Location = new System.Drawing.Point(24, 314);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(229, 39);
            this.Month.TabIndex = 39;
            this.Month.TextChanged += new System.EventHandler(this.Month_TextChanged);
            // 
            // Dodajmecz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 549);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Kwota);
            this.Controls.Add(this.PodokregCb);
            this.Controls.Add(this.KlasaCb);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dodajmecz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodajmecz";
            this.Load += new System.EventHandler(this.Dodajmecz_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Dodaj;
        private ComboBox KlasaCb;
        private ComboBox PodokregCb;
        private TextBox Kwota;
        private TextBox Month;
    }
}