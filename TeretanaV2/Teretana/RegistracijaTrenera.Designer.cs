
namespace Teretana
{
    partial class RegistracijaTrenera
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
            this.groupBoxTrener = new System.Windows.Forms.GroupBox();
            this.cbStrucnaOblast = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.tbBiografijaT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBrojTelefonaT = new System.Windows.Forms.TextBox();
            this.tbPrezimeT = new System.Windows.Forms.TextBox();
            this.tbImeT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.tbLozinkaT = new System.Windows.Forms.TextBox();
            this.tbKorisnickoImeT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btNazadT = new System.Windows.Forms.Button();
            this.btSacuvajT = new System.Windows.Forms.Button();
            this.groupBoxTrener.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTrener
            // 
            this.groupBoxTrener.Controls.Add(this.cbStrucnaOblast);
            this.groupBoxTrener.Controls.Add(this.dtpDatumRodjenja);
            this.groupBoxTrener.Controls.Add(this.tbBiografijaT);
            this.groupBoxTrener.Controls.Add(this.label5);
            this.groupBoxTrener.Controls.Add(this.label8);
            this.groupBoxTrener.Controls.Add(this.tbBrojTelefonaT);
            this.groupBoxTrener.Controls.Add(this.tbPrezimeT);
            this.groupBoxTrener.Controls.Add(this.tbImeT);
            this.groupBoxTrener.Controls.Add(this.label4);
            this.groupBoxTrener.Controls.Add(this.label3);
            this.groupBoxTrener.Controls.Add(this.label2);
            this.groupBoxTrener.Controls.Add(this.label1);
            this.groupBoxTrener.Location = new System.Drawing.Point(21, 26);
            this.groupBoxTrener.Name = "groupBoxTrener";
            this.groupBoxTrener.Size = new System.Drawing.Size(338, 351);
            this.groupBoxTrener.TabIndex = 3;
            this.groupBoxTrener.TabStop = false;
            this.groupBoxTrener.Text = "Podaci o treneru";
            // 
            // cbStrucnaOblast
            // 
            this.cbStrucnaOblast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrucnaOblast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbStrucnaOblast.FormattingEnabled = true;
            this.cbStrucnaOblast.Items.AddRange(new object[] {
            "kardio",
            "rameni pojas",
            "ledjni pojas",
            "grudi",
            "biceps",
            "regija nogu"});
            this.cbStrucnaOblast.Location = new System.Drawing.Point(164, 178);
            this.cbStrucnaOblast.Name = "cbStrucnaOblast";
            this.cbStrucnaOblast.Size = new System.Drawing.Size(140, 30);
            this.cbStrucnaOblast.TabIndex = 7;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(164, 137);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(140, 28);
            this.dtpDatumRodjenja.TabIndex = 7;
            // 
            // tbBiografijaT
            // 
            this.tbBiografijaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBiografijaT.Location = new System.Drawing.Point(164, 259);
            this.tbBiografijaT.Name = "tbBiografijaT";
            this.tbBiografijaT.Size = new System.Drawing.Size(140, 28);
            this.tbBiografijaT.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Biografija:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Broj telefona:";
            // 
            // tbBrojTelefonaT
            // 
            this.tbBrojTelefonaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojTelefonaT.Location = new System.Drawing.Point(164, 219);
            this.tbBrojTelefonaT.Name = "tbBrojTelefonaT";
            this.tbBrojTelefonaT.Size = new System.Drawing.Size(140, 28);
            this.tbBrojTelefonaT.TabIndex = 7;
            // 
            // tbPrezimeT
            // 
            this.tbPrezimeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezimeT.Location = new System.Drawing.Point(164, 97);
            this.tbPrezimeT.Name = "tbPrezimeT";
            this.tbPrezimeT.Size = new System.Drawing.Size(140, 28);
            this.tbPrezimeT.TabIndex = 6;
            // 
            // tbImeT
            // 
            this.tbImeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImeT.Location = new System.Drawing.Point(164, 60);
            this.tbImeT.Name = "tbImeT";
            this.tbImeT.Size = new System.Drawing.Size(140, 28);
            this.tbImeT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stručna oblast:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rođenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.tbLozinkaT);
            this.groupBoxLogin.Controls.Add(this.tbKorisnickoImeT);
            this.groupBoxLogin.Controls.Add(this.label7);
            this.groupBoxLogin.Controls.Add(this.label6);
            this.groupBoxLogin.Location = new System.Drawing.Point(439, 47);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(312, 154);
            this.groupBoxLogin.TabIndex = 4;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // tbLozinkaT
            // 
            this.tbLozinkaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinkaT.Location = new System.Drawing.Point(157, 91);
            this.tbLozinkaT.Name = "tbLozinkaT";
            this.tbLozinkaT.Size = new System.Drawing.Size(140, 28);
            this.tbLozinkaT.TabIndex = 3;
            // 
            // tbKorisnickoImeT
            // 
            this.tbKorisnickoImeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorisnickoImeT.Location = new System.Drawing.Point(157, 54);
            this.tbKorisnickoImeT.Name = "tbKorisnickoImeT";
            this.tbKorisnickoImeT.Size = new System.Drawing.Size(140, 28);
            this.tbKorisnickoImeT.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Šifra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Korisničko ime:";
            // 
            // btNazadT
            // 
            this.btNazadT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNazadT.Location = new System.Drawing.Point(21, 445);
            this.btNazadT.Name = "btNazadT";
            this.btNazadT.Size = new System.Drawing.Size(138, 46);
            this.btNazadT.TabIndex = 5;
            this.btNazadT.Text = "Nazad";
            this.btNazadT.UseVisualStyleBackColor = true;
            this.btNazadT.Click += new System.EventHandler(this.btNazadT_Click);
            // 
            // btSacuvajT
            // 
            this.btSacuvajT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacuvajT.Location = new System.Drawing.Point(526, 234);
            this.btSacuvajT.Name = "btSacuvajT";
            this.btSacuvajT.Size = new System.Drawing.Size(138, 46);
            this.btSacuvajT.TabIndex = 6;
            this.btSacuvajT.Text = "Sačuvaj";
            this.btSacuvajT.UseVisualStyleBackColor = true;
            this.btSacuvajT.Click += new System.EventHandler(this.btSacuvajT_Click);
            // 
            // RegistracijaTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.btSacuvajT);
            this.Controls.Add(this.btNazadT);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxTrener);
            this.Name = "RegistracijaTrenera";
            this.Text = "RegistracijaTrenera";
            this.groupBoxTrener.ResumeLayout(false);
            this.groupBoxTrener.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTrener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbImeT;
        private System.Windows.Forms.TextBox tbPrezimeT;
        private System.Windows.Forms.TextBox tbLozinkaT;
        private System.Windows.Forms.TextBox tbKorisnickoImeT;
        private System.Windows.Forms.Button btNazadT;
        private System.Windows.Forms.Button btSacuvajT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBrojTelefonaT;
        private System.Windows.Forms.TextBox tbBiografijaT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.ComboBox cbStrucnaOblast;
    }
}