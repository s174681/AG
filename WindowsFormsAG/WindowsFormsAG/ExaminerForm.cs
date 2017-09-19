using System;
using System.Collections.Generic;
using System.ComponentModel;
using WindowsFormsAG.Model;
using WindowsFormsAG.Controller;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAG
{
    public partial class ExaminerForm : Form
    {
        private List<EgzaminatorzyViewModel> Przydzial;
        
        public ExaminerForm()
        {
            InitializeComponent();
        }

        public ExaminerForm(List<Egzaminatorzy> przydzial):this
            ()
        {
            Przydzial = przydzial.Select(x => new EgzaminatorzyViewModel(){ Imie = x.EgzaminatorImie, Nazwisko = x.EgzaminatorNazwisko,  KodOsrodka = x.EgzaminatorOsrodek, Kwalifikacje = string.Join(",",x.KwalifikacjeList.Select(o => o.KwalifikacjaKod)), Miejscowosc = x.EgzaminatorMiasto, NumerCKE = x.EgzaminatorCKE }).ToList();

            dataGridViewEgzaminator.AutoGenerateColumns = false;
            dataGridViewEgzaminator.ColumnCount = 6;
            dataGridViewEgzaminator.DataSource = Przydzial;

            dataGridViewEgzaminator.Columns[0].Frozen = true;
            //Add Columns
            dataGridViewEgzaminator.Columns[0].Name = "Imie";
            dataGridViewEgzaminator.Columns[0].HeaderText = "Imię";
            dataGridViewEgzaminator.Columns[0].DataPropertyName = "Imie";

            dataGridViewEgzaminator.Columns[1].Name = "Nazwisko";
            dataGridViewEgzaminator.Columns[1].HeaderText = "Nazwisko";
            dataGridViewEgzaminator.Columns[1].DataPropertyName = "Nazwisko";

            dataGridViewEgzaminator.Columns[2].Name = "NumerCKE";
            dataGridViewEgzaminator.Columns[2].HeaderText = "Numer CKE";
            dataGridViewEgzaminator.Columns[2].DataPropertyName = "NumerCKE";

            dataGridViewEgzaminator.Columns[3].Name = "Kwalifikacje";
            dataGridViewEgzaminator.Columns[3].HeaderText = "Kwalifikacje";
            dataGridViewEgzaminator.Columns[3].DataPropertyName = "Kwalifikacje";

            dataGridViewEgzaminator.Columns[4].Name = "KodOsrodka";
            dataGridViewEgzaminator.Columns[4].HeaderText = "Kod ośrodka";
            dataGridViewEgzaminator.Columns[4].DataPropertyName = "KodOsrodka";

            dataGridViewEgzaminator.Columns[5].Name = "Miejscowosc";
            dataGridViewEgzaminator.Columns[5].HeaderText = "Miejscowość";
            dataGridViewEgzaminator.Columns[5].DataPropertyName = "Miejscowosc";

            dataGridViewEgzaminator.Refresh();
            labelLicznik.Text = Przydzial.Count.ToString();
        }
    }
}
