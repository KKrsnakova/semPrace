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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvUdalosti = new System.Windows.Forms.ListView();
            this.udalost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.misto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priorita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgPoznamka = new System.Windows.Forms.DataGridView();
            this.btnPridat = new System.Windows.Forms.Button();
            this.btnUpravit = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoznamka)).BeginInit();
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
            this.lvUdalosti.Size = new System.Drawing.Size(650, 400);
            this.lvUdalosti.TabIndex = 0;
            this.lvUdalosti.UseCompatibleStateImageBehavior = false;
            this.lvUdalosti.View = System.Windows.Forms.View.Details;
            this.lvUdalosti.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // udalost
            // 
            this.udalost.Text = "Událost";
            this.udalost.Width = 256;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 114;
            // 
            // misto
            // 
            this.misto.Text = "Místo";
            this.misto.Width = 132;
            // 
            // priorita
            // 
            this.priorita.Text = "Priorita";
            this.priorita.Width = 150;
            // 
            // dgPoznamka
            // 
            this.dgPoznamka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoznamka.Location = new System.Drawing.Point(12, 418);
            this.dgPoznamka.Name = "dgPoznamka";
            this.dgPoznamka.Size = new System.Drawing.Size(650, 115);
            this.dgPoznamka.TabIndex = 1;
            this.dgPoznamka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPridat
            // 
            this.btnPridat.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridat.Location = new System.Drawing.Point(680, 12);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(143, 36);
            this.btnPridat.TabIndex = 2;
            this.btnPridat.Text = "Přidat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.Pridej);
            // 
            // btnUpravit
            // 
            this.btnUpravit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravit.Location = new System.Drawing.Point(680, 63);
            this.btnUpravit.Name = "btnUpravit";
            this.btnUpravit.Size = new System.Drawing.Size(143, 33);
            this.btnUpravit.TabIndex = 3;
            this.btnUpravit.Text = "Upravit";
            this.btnUpravit.UseVisualStyleBackColor = true;
            this.btnUpravit.Click += new System.EventHandler(this.Uprav);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSmazat.Location = new System.Drawing.Point(680, 112);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(143, 33);
            this.btnSmazat.TabIndex = 4;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.Smaz);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Planovac.Properties.Resources.floral_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 545);
            this.Controls.Add(this.btnSmazat);
            this.Controls.Add(this.btnUpravit);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.dgPoznamka);
            this.Controls.Add(this.lvUdalosti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Plánovač";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoznamka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgPoznamka;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnUpravit;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.ColumnHeader udalost;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader misto;
        private System.Windows.Forms.ColumnHeader priorita;
        private System.Windows.Forms.ListView lvUdalosti;
    }
}

