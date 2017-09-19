using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsAG.Controller;
using WindowsFormsAG.Model;
using System.Collections;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Threading;
using System.ComponentModel;

namespace WindowsFormsAG
{
    public partial class Harmonogram : Form
    {
        private EgzaminatorzyController Examiner;

        private EgzaminyController Exam;

        private List<Schedule> BestSchedule;

        private AlgorithmController _algorithm;

        private static int MAX_GENERATION = 500;

        public int DaysCount { get; set; }

        private BackgroundWorker backgroundGeneruj;

        public AlgorthmParameters ParametryAlgorytmu { get; set; }
        
        private Schedule _best;

        private DateTime _dtStart;

        public Harmonogram()
        {
            InitializeComponent();
            backgroundGeneruj = new BackgroundWorker();
            BestSchedule = new List<Schedule>();
            _best = new Schedule();
            InitializeBackgroundWorker();
            dateTimePickerFrom.Enabled = false;
            dateTimePickerFor.Enabled = false;
            buttonStart.Enabled = false;
            buttonStop.Enabled = false;
            ParametryAlgorytmu = new AlgorthmParameters();
            _dtStart = dateTimePickerFrom.Value;
        }

         //Ustawienie obiektu BackgroundWorker przez dołączenie obsługi zdarzeń 
        private void InitializeBackgroundWorker()
        {
            backgroundGeneruj.DoWork += new DoWorkEventHandler(backgroundGeneruj_DoWork);
            backgroundGeneruj.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundGeneruj_RunWorkerCompleted);
            backgroundGeneruj.ProgressChanged += new ProgressChangedEventHandler(backgroundGeneruj_ProgressChanged);
            backgroundGeneruj.WorkerReportsProgress = true;
            backgroundGeneruj.WorkerSupportsCancellation = true; 
        }

        // Przycisk GENERUJ
        private void buttonStart_Click(object sender, EventArgs e)
        {
            dataGridViewSchedule.AutoGenerateColumns = false;
            //Set Columns Count  
            dataGridViewSchedule.DataSource = null;
            dataGridViewSchedule.ColumnCount = DaysCount + 2;
            dataGridViewSchedule.Columns[0].Frozen = true;

            //Add Columns
            dataGridViewSchedule.Columns[0].Name = "OsrodekKod";
            dataGridViewSchedule.Columns[0].HeaderText = "Kod ośrodka";
            dataGridViewSchedule.Columns[0].DataPropertyName = "OsrodekKod";

            dataGridViewSchedule.Columns[1].Name = "KwalifikacjaKod";
            dataGridViewSchedule.Columns[1].HeaderText = "Kwalifikacja";
            dataGridViewSchedule.Columns[1].DataPropertyName = "KwalifikacjaKod";
            

            chart1.ChartAreas[0].AxisX.Maximum = MAX_GENERATION;
            chart1.ChartAreas[0].AxisX.Interval = 20;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisY.Minimum = 0.5;
            chart1.ChartAreas[0].AxisY.Interval = 0.125;

            _algorithm = new AlgorithmController(ParametryAlgorytmu);

            for (int i = 2; i < dataGridViewSchedule.ColumnCount; i++)
            {
                dataGridViewSchedule.Columns[i].HeaderText = _dtStart.AddDays(i - 2).ToShortDateString();    
            }

            dataGridViewSchedule.DataSource = Exam.GetListExams().Distinct().ToList();

            _best.SetNumDays(DaysCount);
            _best.SetNumExams(Exam.RecordCount);

            _algorithm.Population(Examiner.GetListEgzaminatorzy(), Exam.GetListExams());

            if (backgroundGeneruj.IsBusy != true)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                // Uruchomienie działanie asynchroniczne szukanie nalepszego chromosomu wśród najlepszych 
                backgroundGeneruj.RunWorkerAsync(new ThreadModelView());
            }
        }

        // Nowe okno po kliknięciu na komórkę w harmonograie dataGridView
        private void dataGridViewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > 1)
            {
                DataGridViewRow row = this.dataGridViewSchedule.Rows[e.RowIndex];
                
                if (row.Cells[e.ColumnIndex].Value != null)
                {
                    List<Egzaminy> egz = BestSchedule[0].GetSlots().ElementAt(e.ColumnIndex - 2).ToList();

                    for (int i = 0; i < egz.Count; i++)
                    {
                        if (row.Cells[0].Value.ToString() == egz[i].OsrodekKod && row.Cells[1].Value.ToString() == egz[i].KwalifikacjaKod)
                        {
                            ExaminerForm f3 = new ExaminerForm(egz[i].EgzaminatorzyList);
                            f3.ShowDialog();                              
                        }
                    } 
                }  
            }
        }
        
        // Przycisk STOP 
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //zmiana stan algorytmu na AS_USER_STOPED
            //instance.Stop();
            if (backgroundGeneruj.WorkerSupportsCancellation == true && backgroundGeneruj.IsBusy)
           {
               backgroundGeneruj.CancelAsync();
               buttonStop.Enabled = false;
               buttonStart.Enabled = true;
           }   
        }

        /// <summary>
        /// Na zakończona wykonać odpowiednie zadanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundGeneruj_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Proces w tle jest kompletny. 
            // Musimy sprawdzić naszą odpowiedź, 
            // czy wystąpił błąd, anulowano, lub zakończono powodzeniem.  
            if (e.Cancelled)
            {
                MessageBox.Show("Proces został anulowany.");
            }

            // Sprawdź, czy wystąpił błąd w procesie w tle.
            else if (e.Error != null)
            {
                MessageBox.Show("Wystąpił błąd podczas wykonywania operacji w tle.");
            }
            else
            {
                // Wszystko zakończone normalnie.
                MessageBox.Show("Proces zakończony funkcja celu osiągneła wartość " + BestSchedule[0].GetFitness().ToString());
            }

            listView1.Items.Clear();
            for (int d = 0; d < BestSchedule.Count; d++)
            {
                ListViewItem item_view = new ListViewItem((d + 1).ToString());
                item_view.SubItems.Add(BestSchedule[d].GetFitness().ToString());
                listView1.Items.Add(item_view);
            }

            // Zmiana odpowiednio stanu przycisków w interfejsie użytkownika
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        /// <summary>
        /// Informacja o postępie operacji generowania chromosomów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundGeneruj_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundGeneruj.CancellationPending)
            {
                ThreadModelView item = (ThreadModelView)e.UserState;

                bestFitness.Text = item.TheBestFitness.ToString();
                labelGeneracji.Text = item.CurrentGeneration.ToString();
                bestFitness.Refresh();
                labelGeneracji.Refresh();
                
                chart1.Series[0].Points.AddXY(item.CurrentGeneration, item.CurrentFitness);
                
                    for (int j = 0; j < DaysCount; j++)
                    {
                        for (int w = 0; w < Exam.RecordCount; w++)
                        {
                            dataGridViewSchedule.Rows[w].Cells[j + 2].Value = null;
                        }
                    }

                    listView1.Items.Clear();
                    for (int d = 0; d < BestSchedule.Count; d++)
                    {
                        ListViewItem item_view = new ListViewItem((d+1).ToString());
                        item_view.SubItems.Add(BestSchedule[d].GetFitness().ToString());
                        listView1.Items.Add(item_view);
                        listView1.Refresh();
                    }

                    for (int i = 0; i < BestSchedule[0].GetSlots().Count; i++)
                    {
                        List<Egzaminy> item_egzaminy = BestSchedule[0].GetSlots().ElementAt(i).ToList();
                        for (int j = 0; j < item_egzaminy.Count; j++)
                        {
                            for (int w = 0; w < Exam.RecordCount; w++)
                            {
                                if (dataGridViewSchedule.Rows[w].Cells[0].Value.ToString() == item_egzaminy.ElementAt(j).OsrodekKod
                                && dataGridViewSchedule.Rows[w].Cells[1].Value.ToString() == item_egzaminy.ElementAt(j).KwalifikacjaKod)
                                {
                                    dataGridViewSchedule.Rows[w].Cells[i + 2].Value = item_egzaminy.ElementAt(j).Kryterium;//egz.ElementAt(j).CzasTrwania + ", " + egz.ElementAt(j).LiczbaEgzaminatorow;
                                }
                            }
                        }
                    }

                    dataGridViewSchedule.Update();
                    dataGridViewSchedule.Refresh();
                    listView1.Refresh();
              }       
        }

        /// <summary>
        /// Operacja generowania chromosomu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundGeneruj_DoWork(object sender, DoWorkEventArgs e)
        {
            ThreadModelView ThreadModel = (ThreadModelView)e.Argument;

            for (int i = 0; i < MAX_GENERATION; i++)
            {
                //_algorithm.GetSchedule(Examiner.GetListEgzaminatorzy(), Exam.GetListExams(), out _best);

                _best = _algorithm.GetSchedule(Examiner.GetListEgzaminatorzy(), Exam.GetListExams());

                ThreadModel.CurrentFitness = _best.GetFitness();

                if (ThreadModel.CurrentFitness > ThreadModel.TheBestFitness)
                {
                    ThreadModel.TheBestFitness = ThreadModel.CurrentFitness;

                     Schedule Best = Clonowanie.DeepCopy(_best); //TUTAJ JEST  KLONOWANIE
                     
                     BestSchedule.Insert(0, Best);
                }

                ThreadModel.CurrentGeneration = i;

                Thread.Sleep(1000);

                backgroundGeneruj.ReportProgress(i, ThreadModel);

                //zgłoszenie o przerwaniu dzialania algorytmu
                if (backgroundGeneruj.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundGeneruj.ReportProgress(0);
                    return;
                }
            }
            
        }

        // Malowanie po harmonogramu 
        private void dataGridViewSchedule_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
        {
            for (int i = 2; i < dataGridViewSchedule.ColumnCount; i++)
            {
                // AutoSize kolumn
                DataGridViewColumn column = dataGridViewSchedule.Columns[i];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //AllCells

                if (this.dataGridViewSchedule.Columns[i].Index ==
                    e.ColumnIndex && e.RowIndex >= 0)
                {
                    Rectangle newRect = new Rectangle(e.CellBounds.X + 1,
                        e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                        e.CellBounds.Height - 4);

                    using (
                        Brush gridBrush = new SolidBrush(this.dataGridViewSchedule.GridColor),
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

        private void dateTimePickerFor_ValueChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = true;
            DateTime dt1 = dateTimePickerFrom.Value;
            DateTime dt2 = dateTimePickerFor.Value;
            TimeSpan tsDiff = dt2.Subtract(dt1);
            int liczba = Exam.GetListExams().Select(x => x.CzasTrwania).Max();
            if (liczba > Convert.ToInt32(tsDiff.Days) + 2)
            {
                MessageBox.Show("Zwiększ przedział. Wykonanie harmonogramu dla tego przedziału jest nie możliwe");
            }
            else DaysCount = Convert.ToInt32(tsDiff.Days) + 2;
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {

            buttonStart.Enabled = true;
            buttonStop.Enabled = true;
            DateTime dt1 = dateTimePickerFrom.Value;
            DateTime dt2 = dateTimePickerFor.Value;
            TimeSpan tsDiff = dt2.Subtract(dt1);
            int liczba = Exam.GetListExams().Select(x => x.CzasTrwania).Max();
            if (liczba > Convert.ToInt32(tsDiff.Days)+2)
            {
                MessageBox.Show("Zwiększ przedział. Wykonanie harmonogramu dla tego przedziału jest nie możliwe");   
            }
            else DaysCount = Convert.ToInt32(tsDiff.Days)+2; 
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Schedule osobnik = BestSchedule.ElementAt(listView1.SelectedItems[0].Index);
            BestScheduleForm bestForm = new BestScheduleForm(Exam.GetListExams(), osobnik, DaysCount, _dtStart);
            bestForm.ShowDialog();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miOpenEgzaminy_Click(object sender, EventArgs e)
        {
            openFileEgzaminy.ShowDialog();
            if (openFileEgzaminy.FileName != "")
            {
                Exam = new EgzaminyController(openFileEgzaminy.FileName);
                Exam.LoadFile();
                Exam.LoadFileExams();
                dateTimePickerFor.Enabled = true;
            }


            dataGridViewSchedule.AutoGenerateColumns = false;
            //Set Columns Count  
            dataGridViewSchedule.DataSource = null;
            dataGridViewSchedule.ColumnCount = 2;
            //Add Columns
            dataGridViewSchedule.Columns[0].Name = "OsrodekKod";
            dataGridViewSchedule.Columns[0].HeaderText = "Kod ośrodka";
            dataGridViewSchedule.Columns[0].DataPropertyName = "OsrodekKod";
            dataGridViewSchedule.Columns[1].Name = "KwalifikacjaKod";
            dataGridViewSchedule.Columns[1].HeaderText = "Kwalifikacja";
            dataGridViewSchedule.Columns[1].DataPropertyName = "KwalifikacjaKod";
            dataGridViewSchedule.DataSource = Exam.GetListExams().Distinct().ToList();
            dataGridViewSchedule.Refresh();
            labelDay.Text = Exam.RecordCount.ToString();

        }

        private void miOpenEgzaminatorzy_Click(object sender, EventArgs e)
        {
            openFileEgzaminatorzy.ShowDialog();
            if (openFileEgzaminy.FileName != "")
            {
                Examiner = new EgzaminatorzyController(openFileEgzaminatorzy.FileName);
                Examiner.LoadFile();
                Examiner.LoadFileExaminers();
                dateTimePickerFrom.Enabled = true;
            }

            MessageBox.Show("Wczytano " + Examiner.RecordCount.ToString() + " egzaminatorów");
        }

        private void pokazEgzaminyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ShowExamForm shownExam = new ShowExamForm(Exam.GetListExams());
            shownExam.ShowDialog();
        }

        private void pokazEgzaminatorowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ShowExaminerForm shownExaminer = new ShowExaminerForm(Examiner.GetListEgzaminatorzy());
            shownExaminer.ShowDialog();
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlgorithmSettingsForm settings = new AlgorithmSettingsForm(this);
            settings.ShowDialog();

        }


    }
}
