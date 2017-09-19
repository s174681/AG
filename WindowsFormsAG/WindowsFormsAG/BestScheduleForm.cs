using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms;
using WindowsFormsAG.Model;
//using Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsAG
{
    public partial class BestScheduleForm : Form
    {
        private List<Egzaminy> _egzaminy;
        private Schedule _chromosom;
        private int _liczbaDni;
        private DateTime _dtStart;
        
        public BestScheduleForm()
        {
            InitializeComponent();
            _egzaminy = new List<Egzaminy>();
            _chromosom = new Schedule();
        }

        public BestScheduleForm(List<Egzaminy> egzaminy, Schedule osobnik, int liczbaDni, DateTime dtStart)
            : this()
        {
            _egzaminy = egzaminy;
            _chromosom = osobnik;
            _liczbaDni = liczbaDni;
            _dtStart = dtStart;

            dataGridView1.AutoGenerateColumns = false;
            //Set Columns Count  
            dataGridView1.DataSource = null;
            dataGridView1.ColumnCount = _liczbaDni + 2;
            dataGridView1.Columns[0].Frozen = true;

            //Add Columns
            dataGridView1.Columns[0].Name = "OsrodekKod";
            dataGridView1.Columns[0].HeaderText = "Kod ośrodka";
            dataGridView1.Columns[0].DataPropertyName = "OsrodekKod";

            dataGridView1.Columns[1].Name = "KwalifikacjaKod";
            dataGridView1.Columns[1].HeaderText = "Kwalifikacja";
            dataGridView1.Columns[1].DataPropertyName = "KwalifikacjaKod";


        }

         private void BestScheduleForm_Shown(object sender, EventArgs e)
        {
            for (int i = 2; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Name = (i - 1).ToString();
            }

            DateTime dtStart = _dtStart;

            for (int i = 2; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = dtStart.AddDays(i - 2).ToShortDateString();
            }

            dataGridView1.DataSource = _egzaminy;

            for (int i = 0; i < _chromosom.GetSlots().Count; i++)
            {
                List<Egzaminy> item_egzaminy = _chromosom.GetSlots().ElementAt(i).ToList();
                for (int j = 0; j < item_egzaminy.Count; j++)
                {
                    for (int w = 0; w < _egzaminy.Count; w++)
                    {
                        if (dataGridView1.Rows[w].Cells[0].Value.ToString() == item_egzaminy.ElementAt(j).OsrodekKod
                        && dataGridView1.Rows[w].Cells[1].Value.ToString() == item_egzaminy.ElementAt(j).KwalifikacjaKod)
                        {
                            dataGridView1.Rows[w].Cells[i + 2].Value = item_egzaminy.ElementAt(j).Kryterium.ToString();
                        }
                    }
                } 
            }

            dataGridView1.Update();
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > 1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                if (row.Cells[e.ColumnIndex].Value != null)
                {
                    List<Egzaminy> item_egzaminy = _chromosom.GetSlots().ElementAt(e.ColumnIndex - 2).ToList();

                    for (int i = 0; i < item_egzaminy.Count; i++)
                    {
                        if (row.Cells[0].Value.ToString() == item_egzaminy[i].OsrodekKod && row.Cells[1].Value.ToString() == item_egzaminy[i].KwalifikacjaKod)
                        {
                            textBoxKod.Text = item_egzaminy[i].OsrodekKod;
                            textBoxName.Text = item_egzaminy[i].OsrodekNazwa;
                            textBoxCity.Text = item_egzaminy[i].OsrodekMiejscowosc;
                            textBoxKodKwalifikacji.Text = item_egzaminy[i].KwalifikacjaKod;
                            textBoxNazwaKwalifikacji.Text = item_egzaminy[i].KwalifikacjaNazwa;

                            listViewExaminer.Items.Clear();
                            for (int k = 0; k < item_egzaminy[i].EgzaminatorzyList.Count; k++)
                            {
                                ListViewItem item_view = new ListViewItem((i + 1).ToString());
                                item_view.SubItems.Add(item_egzaminy[i].EgzaminatorzyList.ElementAt(k).EgzaminatorImie.ToString());
                                item_view.SubItems.Add(item_egzaminy[i].EgzaminatorzyList.ElementAt(k).EgzaminatorNazwisko.ToString());
                                item_view.SubItems.Add(item_egzaminy[i].EgzaminatorzyList.ElementAt(k).EgzaminatorOsrodek.ToString());
                                item_view.SubItems.Add(item_egzaminy[i].EgzaminatorzyList.ElementAt(k).EgzaminatorMiasto.ToString());
                                item_view.SubItems.Add(item_egzaminy[i].EgzaminatorzyList.ElementAt(k).EgzaminatorCKE.ToString());
                                listViewExaminer.Items.Add(item_view);
                                listViewExaminer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                                //string.Join(",", egz[i].EgzaminatorzyList.Select(x => x.EgzaminatorImie +" "+ x.EgzaminatorNazwisko))
                            }                        
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            for (int i = 2; i < dataGridView1.ColumnCount; i++)
            {
                // AutoSize kolumn
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //AllCells

                if (dataGridView1.Columns[i].Index ==
                    e.ColumnIndex && e.RowIndex >= 0)
                {
                    System.Drawing.Rectangle newRect = new System.Drawing.Rectangle(e.CellBounds.X + 1,
                        e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                        e.CellBounds.Height - 4);

                    using (
                        Brush gridBrush = new SolidBrush(this.dataGridView1.GridColor),
                        backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            if (e.Value != null)
                            {
                                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
                                e.PaintContent(e.CellBounds);
                                e.Graphics.DrawRectangle(Pens.Black, newRect);
                                e.Handled = true;
                            }
                        }
                    }
                }
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //saveFileDialogExcel.Filter = "Excel Files(2013)|*.xls|Excel Files(2017)|*.xlsx";
            //saveFileDialogExcel.FileName = "Preliminarz " + DateTime.Today.ToShortDateString() + ".xlsx";
            //if (saveFileDialogExcel.ShowDialog() != DialogResult.Cancel)
            //{
            //    // Tworzenie aplikacji Excel
            //   // Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            //    ExcelApp.Application.Workbooks.Add(Type.Missing);

            //   // ExcelApp.Columns.ColumnWidth = 20;

            //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //    {
            //        ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //    }

            //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
            //        }
            //    }

            //    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialogExcel.FileName.ToString());
            //    ExcelApp.ActiveWorkbook.Saved = true;
            //    ExcelApp.Quit();
            //}
        }


        private void buttonCKE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCKE.Text) && string.IsNullOrEmpty(textBoxOsrodek.Text) && string.IsNullOrEmpty(textBoxKwalifikacji.Text))
            {
                dataGridView1.DataSource = _egzaminy;
                BestScheduleForm_Shown(sender, e);

            }
            else 
            {

                List<Egzaminy> tmp = _egzaminy.Where(x => (string.IsNullOrEmpty(textBoxKwalifikacji.Text) || x.KwalifikacjaKod == textBoxKwalifikacji.Text) 
                    && (string.IsNullOrEmpty(textBoxOsrodek.Text) || x.OsrodekKod == textBoxOsrodek.Text) 
                    && x.EgzaminatorzyList.Any(o => (string.IsNullOrEmpty(textBoxCKE.Text) || o.EgzaminatorCKE == textBoxCKE.Text))).ToList();
                dataGridView1.DataSource = tmp;
                
                for (int i = 0; i < _chromosom.GetSlots().Count; i++)
                {
                    List<Egzaminy> item_egzaminy = _chromosom.GetSlots().ElementAt(i).ToList();
                    for (int j = 0; j < item_egzaminy.Count; j++)
                    {
                        for (int w = 0; w < tmp.Count; w++)
                        {
                            if (dataGridView1.Rows[w].Cells[0].Value.ToString() == item_egzaminy.ElementAt(j).OsrodekKod
                            && dataGridView1.Rows[w].Cells[1].Value.ToString() == item_egzaminy.ElementAt(j).KwalifikacjaKod)
                            {
                                dataGridView1.Rows[w].Cells[i + 2].Value = item_egzaminy.ElementAt(j).Kryterium.ToString();
                            }
                        }
                    }
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();

        }

        private void buttonOsrodek_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOsrodek.Text))
            {
                dataGridView1.DataSource = _egzaminy;
                BestScheduleForm_Shown(sender, e);

            }
            else
            {
                List<Egzaminy> tmp = _egzaminy.Where(x => x.OsrodekKod == textBoxOsrodek.Text).Select(x => x).Distinct().ToList();
                dataGridView1.DataSource = tmp;

                for (int i = 0; i < _chromosom.GetSlots().Count; i++)
                {
                    List<Egzaminy> item_egzaminy = _chromosom.GetSlots().ElementAt(i).ToList();
                    for (int j = 0; j < item_egzaminy.Count; j++)
                    {
                        for (int w = 0; w < tmp.Count; w++)
                        {
                            if (dataGridView1.Rows[w].Cells[0].Value.ToString() == item_egzaminy.ElementAt(j).OsrodekKod
                            && dataGridView1.Rows[w].Cells[1].Value.ToString() == item_egzaminy.ElementAt(j).KwalifikacjaKod)
                            {
                                dataGridView1.Rows[w].Cells[i + 2].Value = item_egzaminy.ElementAt(j).Kryterium.ToString();
                            }
                        }
                    }
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void buttonKwalifikacja_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxKwalifikacji.Text))
            {
                dataGridView1.DataSource = _egzaminy;
                BestScheduleForm_Shown(sender, e);

            }
            else
            {
                List<Egzaminy> tmp = _egzaminy.Where(x => x.KwalifikacjaKod == textBoxKwalifikacji.Text).Select(x => x).Distinct().ToList();
                dataGridView1.DataSource = tmp;

                for (int i = 0; i < _chromosom.GetSlots().Count; i++)
                {
                    List<Egzaminy> item_egzaminy = _chromosom.GetSlots().ElementAt(i).ToList();
                    for (int j = 0; j < item_egzaminy.Count; j++)
                    {
                        for (int w = 0; w < tmp.Count; w++)
                        {
                            if (dataGridView1.Rows[w].Cells[0].Value.ToString() == item_egzaminy.ElementAt(j).OsrodekKod
                            && dataGridView1.Rows[w].Cells[1].Value.ToString() == item_egzaminy.ElementAt(j).KwalifikacjaKod)
                            {
                                dataGridView1.Rows[w].Cells[i + 2].Value = item_egzaminy.ElementAt(j).Kryterium.ToString();
                            }
                        }
                    }
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           // printPreviewView.PrintPreviewControl();
        }
    }
}
