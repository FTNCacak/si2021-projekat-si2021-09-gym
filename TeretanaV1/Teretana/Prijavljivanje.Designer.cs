﻿
namespace Teretana
{
    partial class Prijavljivanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.btPrijaviSe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorisnickoIme.Location = new System.Drawing.Point(297, 126);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(206, 34);
            this.tbKorisnickoIme.TabIndex = 2;
            // 
            // tbSifra
            // 
            this.tbSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSifra.Location = new System.Drawing.Point(297, 194);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(206, 34);
            this.tbSifra.TabIndex = 3;
            this.tbSifra.UseSystemPasswordChar = true;
            // 
            // btPrijaviSe
            // 
            this.btPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrijaviSe.Location = new System.Drawing.Point(548, 145);
            this.btPrijaviSe.Name = "btPrijaviSe";
            this.btPrijaviSe.Size = new System.Drawing.Size(162, 58);
            this.btPrijaviSe.TabIndex = 4;
            this.btPrijaviSe.Text = "Prijavi se";
            this.btPrijaviSe.UseVisualStyleBackColor = true;
            this.btPrijaviSe.Click += new System.EventHandler(this.btPrijaviSe_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj novog trenera";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Prijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPrijaviSe);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prijavljivanje";
            this.Text = "Prijavljivanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Button btPrijaviSe;
        private System.Windows.Forms.Button button1;
    }
}

