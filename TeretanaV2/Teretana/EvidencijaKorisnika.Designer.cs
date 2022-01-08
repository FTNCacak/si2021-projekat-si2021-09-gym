﻿
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
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSacuvaj = new System.Windows.Forms.Button();
            this.btIzbrisi = new System.Windows.Forms.Button();
            this.groupBoxKorisnik = new System.Windows.Forms.GroupBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbIzabraniTrener = new System.Windows.Forms.ComboBox();
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
            this.btAzuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.groupBoxKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.AllowUserToAddRows = false;
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.prezime,
            this.pol,
            this.visina,
            this.tezina,
            this.trener});
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(357, 50);
            this.dataGridViewKorisnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.RowHeadersWidth = 51;
            this.dataGridViewKorisnici.RowTemplate.Height = 24;
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(584, 293);
            this.dataGridViewKorisnici.TabIndex = 0;
            this.dataGridViewKorisnici.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKorisnici_CellMouseDoubleClick);
            // 
            // ime
            // 
            this.ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ime.HeaderText = "IME";
            this.ime.MinimumWidth = 35;
            this.ime.Name = "ime";
            this.ime.Width = 60;
            // 
            // prezime
            // 
            this.prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.prezime.HeaderText = "PREZIME";
            this.prezime.MinimumWidth = 70;
            this.prezime.Name = "prezime";
            this.prezime.Width = 97;
            // 
            // pol
            // 
            this.pol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pol.HeaderText = "POL";
            this.pol.MinimumWidth = 6;
            this.pol.Name = "pol";
            this.pol.Width = 65;
            // 
            // visina
            // 
            this.visina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.visina.HeaderText = "VISINA";
            this.visina.MinimumWidth = 6;
            this.visina.Name = "visina";
            this.visina.Width = 80;
            // 
            // tezina
            // 
            this.tezina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tezina.HeaderText = "TEŽINA";
            this.tezina.MinimumWidth = 6;
            this.tezina.Name = "tezina";
            this.tezina.Width = 86;
            // 
            // trener
            // 
            this.trener.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.trener.HeaderText = "TRENER";
            this.trener.MinimumWidth = 6;
            this.trener.Name = "trener";
            this.trener.Width = 94;
            // 
            // btSacuvaj
            // 
            this.btSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacuvaj.Location = new System.Drawing.Point(425, 357);
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
            this.btIzbrisi.Location = new System.Drawing.Point(744, 357);
            this.btIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIzbrisi.Name = "btIzbrisi";
            this.btIzbrisi.Size = new System.Drawing.Size(139, 46);
            this.btIzbrisi.TabIndex = 2;
            this.btIzbrisi.Text = "Izbriši";
            this.btIzbrisi.UseVisualStyleBackColor = true;
            this.btIzbrisi.Click += new System.EventHandler(this.btIzbrisi_Click);
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
            this.groupBoxKorisnik.Size = new System.Drawing.Size(311, 330);
            this.groupBoxKorisnik.TabIndex = 3;
            this.groupBoxKorisnik.TabStop = false;
            this.groupBoxKorisnik.Text = "Podaci o korisniku";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(148, 89);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(141, 28);
            this.dtpDatumRodjenja.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(149, 249);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(140, 30);
            this.tbEmail.TabIndex = 15;
            // 
            // cbIzabraniTrener
            // 
            this.cbIzabraniTrener.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzabraniTrener.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbIzabraniTrener.FormattingEnabled = true;
            this.cbIzabraniTrener.Location = new System.Drawing.Point(149, 288);
            this.cbIzabraniTrener.Name = "cbIzabraniTrener";
            this.cbIzabraniTrener.Size = new System.Drawing.Size(140, 30);
            this.cbIzabraniTrener.TabIndex = 5;
            // 
            // tbTezina
            // 
            this.tbTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbTezina.Location = new System.Drawing.Point(149, 194);
            this.tbTezina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(140, 28);
            this.tbTezina.TabIndex = 14;
            // 
            // tbVisina
            // 
            this.tbVisina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbVisina.Location = new System.Drawing.Point(149, 161);
            this.tbVisina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVisina.Name = "tbVisina";
            this.tbVisina.Size = new System.Drawing.Size(140, 28);
            this.tbVisina.TabIndex = 13;
            // 
            // rbŽ
            // 
            this.rbŽ.AutoSize = true;
            this.rbŽ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbŽ.Location = new System.Drawing.Point(209, 125);
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
            this.rbM.Location = new System.Drawing.Point(157, 125);
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
            this.tbPrezime.Location = new System.Drawing.Point(149, 55);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(140, 28);
            this.tbPrezime.TabIndex = 9;
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbIme.Location = new System.Drawing.Point(149, 21);
            this.tbIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(140, 28);
            this.tbIme.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Izabrani trener:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Težina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Visina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rođenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
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
            // btAzuriraj
            // 
            this.btAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAzuriraj.Location = new System.Drawing.Point(585, 357);
            this.btAzuriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAzuriraj.Name = "btAzuriraj";
            this.btAzuriraj.Size = new System.Drawing.Size(139, 46);
            this.btAzuriraj.TabIndex = 5;
            this.btAzuriraj.Text = "Ažuriraj";
            this.btAzuriraj.UseVisualStyleBackColor = true;
            this.btAzuriraj.Click += new System.EventHandler(this.btAzuriraj_Click);
            // 
            // EvidencijaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 503);
            this.Controls.Add(this.btAzuriraj);
            this.Controls.Add(this.btNazad);
            this.Controls.Add(this.groupBoxKorisnik);
            this.Controls.Add(this.btIzbrisi);
            this.Controls.Add(this.btSacuvaj);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaKorisnika";
            this.Text = "EvidencijaKorisnika";
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
        private System.Windows.Forms.Button btAzuriraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn visina;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezina;
        private System.Windows.Forms.DataGridViewTextBoxColumn trener;
    }
}