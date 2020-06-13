﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Baza_podataka;
using Tennis_Track.Klase;

namespace Tennis_Track.Forme
{
    public partial class GlavniIzbornik : Form
    {
        private LoginForm loginForm;

        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        public GlavniIzbornik(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {
            lblImePrezimeKorisnika.Text = "Trenutno ste prijavljeni kao" + Environment.NewLine + PrijavaClana.clan.Ime + " " + PrijavaClana.clan.Prezime;
            lblImePrezimeKorisnika.BackColor = System.Drawing.Color.Transparent;
            if (PrijavaClana.clan.TipClana == "Admin")
            {
                btnDodajClana.Visible = true;
            }
            else
            {
                btnDodajClana.Visible = false;
            }
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            DodajClana dodajClana = new DodajClana(this);
            this.Hide();
            dodajClana.ShowDialog();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            PrijavaClana.clan = null;
            this.Close();
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            Postavke postavke = new Postavke(this);
            this.Hide();
            postavke.ShowDialog();
        }

        private void btnRangListe_Click(object sender, EventArgs e)
        {
            RangListe rangListe = new RangListe(this);
            this.Hide();
            rangListe.ShowDialog();
        }

        private void bntMecevi_Click(object sender, EventArgs e)
        {
            Mecevi mecevi = new Mecevi(this);
            this.Hide();
            mecevi.ShowDialog();
        }

        private void lblImePrezimeKorisnika_Click(object sender, EventArgs e)
        {
            StatistikaKorisnika statistikaKorisnika = new StatistikaKorisnika(this);
            this.Hide();
            statistikaKorisnika.ShowDialog();

        }
    }
}
