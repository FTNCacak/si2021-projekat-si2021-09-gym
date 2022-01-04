
namespace Teretana
{
    partial class EvidencijaKorisnika
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
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.btSacuvaj = new System.Windows.Forms.Button();
            this.btIzbrisi = new System.Windows.Forms.Button();
            this.groupBoxKorisnik = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.tbVisina = new System.Windows.Forms.TextBox();
            this.rbŽ = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNazad = new System.Windows.Forms.Button();
            this.cbIzabraniTrener = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.groupBoxKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(340, 46);
            this.dataGridViewKorisnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.RowHeadersWidth = 51;
            this.dataGridViewKorisnici.RowTemplate.Height = 24;
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(469, 293);
            this.dataGridViewKorisnici.TabIndex = 0;
            // 
            // btSacuvaj
            // 
            this.btSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacuvaj.Location = new System.Drawing.Point(427, 357);
            this.btSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSacuvaj.Name = "btSacuvaj";
            this.btSacuvaj.Size = new System.Drawing.Size(139, 46);
            this.btSacuvaj.TabIndex = 1;
            this.btSacuvaj.Text = "Sačuvaj";
            this.btSacuvaj.UseVisualStyleBackColor = true;
            this.btSacuvaj.Click += new System.EventHandler(this.btSacuvaj_Click);
            // 
            // btIzbrisi
            // 
            this.btIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIzbrisi.Location = new System.Drawing.Point(587, 357);
            this.btIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIzbrisi.Name = "btIzbrisi";
            this.btIzbrisi.Size = new System.Drawing.Size(139, 46);
            this.btIzbrisi.TabIndex = 2;
            this.btIzbrisi.Text = "Izbriši";
            this.btIzbrisi.UseVisualStyleBackColor = true;
            // 
            // groupBoxKorisnik
            // 
            this.groupBoxKorisnik.Controls.Add(this.dtpDatumRodjenja);
            this.groupBoxKorisnik.Controls.Add(this.tbEmail);
            this.groupBoxKorisnik.Controls.Add(this.cbIzabraniTrener);
            this.groupBoxKorisnik.Controls.Add(this.tbTezina);
            this.groupBoxKorisnik.Controls.Add(this.tbVisina);
            this.groupBoxKorisnik.Controls.Add(this.rbŽ);
            this.groupBoxKorisnik.Controls.Add(this.rbM);
            this.groupBoxKorisnik.Controls.Add(this.tbPrezime);
            this.groupBoxKorisnik.Controls.Add(this.tbIme);
            this.groupBoxKorisnik.Controls.Add(this.label8);
            this.groupBoxKorisnik.Controls.Add(this.label7);
            this.groupBoxKorisnik.Controls.Add(this.label6);
            this.groupBoxKorisnik.Controls.Add(this.label5);
            this.groupBoxKorisnik.Controls.Add(this.label4);
            this.groupBoxKorisnik.Controls.Add(this.label3);
            this.groupBoxKorisnik.Controls.Add(this.label2);
            this.groupBoxKorisnik.Controls.Add(this.label1);
            this.groupBoxKorisnik.Location = new System.Drawing.Point(21, 25);
            this.groupBoxKorisnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKorisnik.Name = "groupBoxKorisnik";
            this.groupBoxKorisnik.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKorisnik.Size = new System.Drawing.Size(292, 330);
            this.groupBoxKorisnik.TabIndex = 3;
            this.groupBoxKorisnik.TabStop = false;
            this.groupBoxKorisnik.Text = "Podaci o korisniku";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(147, 249);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(140, 30);
            this.tbEmail.TabIndex = 15;
            // 
            // tbTezina
            // 
            this.tbTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbTezina.Location = new System.Drawing.Point(147, 194);
            this.tbTezina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(140, 28);
            this.tbTezina.TabIndex = 14;
            // 
            // tbVisina
            // 
            this.tbVisina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbVisina.Location = new System.Drawing.Point(147, 161);
            this.tbVisina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVisina.Name = "tbVisina";
            this.tbVisina.Size = new System.Drawing.Size(140, 28);
            this.tbVisina.TabIndex = 13;
            // 
            // rbŽ
            // 
            this.rbŽ.AutoSize = true;
            this.rbŽ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbŽ.Location = new System.Drawing.Point(207, 126);
            this.rbŽ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbŽ.Name = "rbŽ";
            this.rbŽ.Size = new System.Drawing.Size(43, 28);
            this.rbŽ.TabIndex = 12;
            this.rbŽ.TabStop = true;
            this.rbŽ.Text = "Ž";
            this.rbŽ.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbM.Location = new System.Drawing.Point(155, 126);
            this.rbM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(47, 28);
            this.rbM.TabIndex = 11;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPrezime.Location = new System.Drawing.Point(147, 55);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(140, 28);
            this.tbPrezime.TabIndex = 9;
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbIme.Location = new System.Drawing.Point(147, 21);
            this.tbIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(140, 28);
            this.tbIme.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Izabrani trener:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Težina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Visina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rođenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // btNazad
            // 
            this.btNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNazad.Location = new System.Drawing.Point(21, 446);
            this.btNazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNazad.Name = "btNazad";
            this.btNazad.Size = new System.Drawing.Size(139, 46);
            this.btNazad.TabIndex = 4;
            this.btNazad.Text = "Nazad";
            this.btNazad.UseVisualStyleBackColor = true;
            this.btNazad.Click += new System.EventHandler(this.btNazad_Click);
            // 
            // cbIzabraniTrener
            // 
            this.cbIzabraniTrener.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzabraniTrener.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbIzabraniTrener.FormattingEnabled = true;
            this.cbIzabraniTrener.Location = new System.Drawing.Point(146, 288);
            this.cbIzabraniTrener.Name = "cbIzabraniTrener";
            this.cbIzabraniTrener.Size = new System.Drawing.Size(140, 30);
            this.cbIzabraniTrener.TabIndex = 5;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(146, 89);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(141, 28);
            this.dtpDatumRodjenja.TabIndex = 5;
            // 
            // EvidencijaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.btNazad);
            this.Controls.Add(this.groupBoxKorisnik);
            this.Controls.Add(this.btIzbrisi);
            this.Controls.Add(this.btSacuvaj);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaKorisnika";
            this.Text = "EvidencijaKorisnika";
            this.Load += new System.EventHandler(this.EvidencijaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.groupBoxKorisnik.ResumeLayout(false);
            this.groupBoxKorisnik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
        private System.Windows.Forms.Button btSacuvaj;
        private System.Windows.Forms.Button btIzbrisi;
        private System.Windows.Forms.GroupBox groupBoxKorisnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.TextBox tbVisina;
        private System.Windows.Forms.RadioButton rbŽ;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Button btNazad;
        private System.Windows.Forms.ComboBox cbIzabraniTrener;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
    }
}