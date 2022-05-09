namespace Planovac
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvUdalosti = new System.Windows.Forms.ListView();
            this.udalost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.misto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priorita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbPoznamka = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPoznamka = new System.Windows.Forms.Button();
            this.btnUpravit = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.btnPridat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbdatcas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDatum = new System.Windows.Forms.Label();
            this.lbCas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvUdalosti
            // 
            this.lvUdalosti.BackColor = System.Drawing.SystemColors.Window;
            this.lvUdalosti.BackgroundImageTiled = true;
            this.lvUdalosti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUdalosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.udalost,
            this.datum,
            this.misto,
            this.priorita});
            this.lvUdalosti.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.lvUdalosti.GridLines = true;
            this.lvUdalosti.HideSelection = false;
            this.lvUdalosti.Location = new System.Drawing.Point(12, 12);
            this.lvUdalosti.Name = "lvUdalosti";
            this.lvUdalosti.Size = new System.Drawing.Size(785, 408);
            this.lvUdalosti.TabIndex = 0;
            this.lvUdalosti.UseCompatibleStateImageBehavior = false;
            this.lvUdalosti.View = System.Windows.Forms.View.Details;
            this.lvUdalosti.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lvUdalosti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Klik);
            // 
            // udalost
            // 
            this.udalost.Text = "Událost";
            this.udalost.Width = 256;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 179;
            // 
            // misto
            // 
            this.misto.Text = "Místo";
            this.misto.Width = 179;
            // 
            // priorita
            // 
            this.priorita.Text = "Priorita";
            this.priorita.Width = 150;
            // 
            // lbPoznamka
            // 
            this.lbPoznamka.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.lbPoznamka.FormattingEnabled = true;
            this.lbPoznamka.ItemHeight = 23;
            this.lbPoznamka.Location = new System.Drawing.Point(12, 426);
            this.lbPoznamka.Name = "lbPoznamka";
            this.lbPoznamka.Size = new System.Drawing.Size(785, 119);
            this.lbPoznamka.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnPoznamka);
            this.panel1.Controls.Add(this.btnUpravit);
            this.panel1.Controls.Add(this.btnSmazat);
            this.panel1.Controls.Add(this.btnPridat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(803, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.panel1.Size = new System.Drawing.Size(239, 570);
            this.panel1.TabIndex = 7;
            // 
            // btnPoznamka
            // 
            this.btnPoznamka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPoznamka.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPoznamka.Location = new System.Drawing.Point(0, 239);
            this.btnPoznamka.Name = "btnPoznamka";
            this.btnPoznamka.Size = new System.Drawing.Size(239, 33);
            this.btnPoznamka.TabIndex = 10;
            this.btnPoznamka.Text = "Poznámka";
            this.btnPoznamka.UseVisualStyleBackColor = true;
            this.btnPoznamka.Click += new System.EventHandler(this.btnPoznamka_Click);
            // 
            // btnUpravit
            // 
            this.btnUpravit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpravit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravit.Location = new System.Drawing.Point(0, 206);
            this.btnUpravit.Name = "btnUpravit";
            this.btnUpravit.Size = new System.Drawing.Size(239, 33);
            this.btnUpravit.TabIndex = 10;
            this.btnUpravit.Text = "Upravit";
            this.btnUpravit.UseVisualStyleBackColor = true;
            // 
            // btnSmazat
            // 
            this.btnSmazat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmazat.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSmazat.Location = new System.Drawing.Point(0, 173);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(239, 33);
            this.btnSmazat.TabIndex = 9;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.Smaz);
            // 
            // btnPridat
            // 
            this.btnPridat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPridat.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridat.Location = new System.Drawing.Point(0, 137);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(239, 36);
            this.btnPridat.TabIndex = 3;
            this.btnPridat.Text = "Přidat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.Pridej);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbdatcas);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbDatum);
            this.panel2.Controls.Add(this.lbCas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 124);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbdatcas
            // 
            this.lbdatcas.AutoSize = true;
            this.lbdatcas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbdatcas.Location = new System.Drawing.Point(33, 0);
            this.lbdatcas.Name = "lbdatcas";
            this.lbdatcas.Size = new System.Drawing.Size(176, 26);
            this.lbdatcas.TabIndex = 3;
            this.lbdatcas.Text = "Aktuální datum a čas";
            this.lbdatcas.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Planovac.Properties.Resources.time;
            this.pictureBox1.Location = new System.Drawing.Point(186, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbDatum.Location = new System.Drawing.Point(3, 34);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(74, 26);
            this.lbDatum.TabIndex = 1;
            this.lbDatum.Text = "Datum: ";
            // 
            // lbCas
            // 
            this.lbCas.AutoSize = true;
            this.lbCas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbCas.Location = new System.Drawing.Point(3, 74);
            this.lbCas.Name = "lbCas";
            this.lbCas.Size = new System.Drawing.Size(41, 26);
            this.lbCas.TabIndex = 0;
            this.lbCas.Text = "Čas:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPoznamka);
            this.Controls.Add(this.lvUdalosti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Plánovač";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader udalost;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader misto;
        private System.Windows.Forms.ColumnHeader priorita;
        private System.Windows.Forms.ListView lvUdalosti;
        private System.Windows.Forms.ListBox lbPoznamka;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPoznamka;
        private System.Windows.Forms.Button btnUpravit;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.Label lbCas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbdatcas;
    }
}

