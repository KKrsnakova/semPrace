namespace Planovac
{
    partial class FormPridej
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPridej));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.tbMisto = new System.Windows.Forms.TextBox();
            this.cbPriorita = new System.Windows.Forms.ComboBox();
            this.btnPridej = new System.Windows.Forms.Button();
            this.btnZrus = new System.Windows.Forms.Button();
            this.lbkl = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPznm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Místo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priorita:";
            // 
            // tbNazev
            // 
            this.tbNazev.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNazev.Location = new System.Drawing.Point(124, 61);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(293, 34);
            this.tbNazev.TabIndex = 4;
            // 
            // tbMisto
            // 
            this.tbMisto.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbMisto.Location = new System.Drawing.Point(124, 150);
            this.tbMisto.Name = "tbMisto";
            this.tbMisto.Size = new System.Drawing.Size(293, 34);
            this.tbMisto.TabIndex = 6;
            // 
            // cbPriorita
            // 
            this.cbPriorita.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbPriorita.FormattingEnabled = true;
            this.cbPriorita.Location = new System.Drawing.Point(124, 194);
            this.cbPriorita.Name = "cbPriorita";
            this.cbPriorita.Size = new System.Drawing.Size(293, 34);
            this.cbPriorita.TabIndex = 8;
            // 
            // btnPridej
            // 
            this.btnPridej.BackColor = System.Drawing.Color.White;
            this.btnPridej.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPridej.Location = new System.Drawing.Point(252, 345);
            this.btnPridej.Name = "btnPridej";
            this.btnPridej.Size = new System.Drawing.Size(94, 37);
            this.btnPridej.TabIndex = 9;
            this.btnPridej.Text = "Přidat";
            this.btnPridej.UseVisualStyleBackColor = false;
            this.btnPridej.Click += new System.EventHandler(this.Pridat);
            // 
            // btnZrus
            // 
            this.btnZrus.BackColor = System.Drawing.Color.White;
            this.btnZrus.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnZrus.Location = new System.Drawing.Point(84, 345);
            this.btnZrus.Name = "btnZrus";
            this.btnZrus.Size = new System.Drawing.Size(94, 37);
            this.btnZrus.TabIndex = 10;
            this.btnZrus.Text = "Zrušit";
            this.btnZrus.UseVisualStyleBackColor = false;
            this.btnZrus.Click += new System.EventHandler(this.Zrus);
            // 
            // lbkl
            // 
            this.lbkl.AutoSize = true;
            this.lbkl.BackColor = System.Drawing.Color.Transparent;
            this.lbkl.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbkl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbkl.Location = new System.Drawing.Point(106, 9);
            this.lbkl.Name = "lbkl";
            this.lbkl.Size = new System.Drawing.Size(196, 47);
            this.lbkl.TabIndex = 11;
            this.lbkl.Text = "Nová událost";
            this.lbkl.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.AllowDrop = true;
            this.dtPicker.CustomFormat = "dd-MM-yyyy";
            this.dtPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPicker.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(124, 107);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(293, 34);
            this.dtPicker.TabIndex = 12;
            this.dtPicker.Value = new System.DateTime(2022, 3, 29, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Poznámka:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // tbPznm
            // 
            this.tbPznm.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbPznm.Location = new System.Drawing.Point(124, 238);
            this.tbPznm.Name = "tbPznm";
            this.tbPznm.Size = new System.Drawing.Size(293, 34);
            this.tbPznm.TabIndex = 14;
            // 
            // FormPridej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Planovac.Properties.Resources.floral_wallpaper;
            this.ClientSize = new System.Drawing.Size(429, 418);
            this.Controls.Add(this.tbPznm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.lbkl);
            this.Controls.Add(this.btnZrus);
            this.Controls.Add(this.btnPridej);
            this.Controls.Add(this.cbPriorita);
            this.Controls.Add(this.tbMisto);
            this.Controls.Add(this.tbNazev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPridej";
            this.Text = "Přidat událost";
            this.Load += new System.EventHandler(this.FormPridej_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.TextBox tbMisto;
        private System.Windows.Forms.ComboBox cbPriorita;
        private System.Windows.Forms.Button btnPridej;
        private System.Windows.Forms.Button btnZrus;
        private System.Windows.Forms.Label lbkl;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPznm;
    }
}