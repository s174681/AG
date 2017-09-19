using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsAG.Model;

namespace WindowsFormsAG
{
    public partial class ShowExamForm : Form
    {
        private List<Egzaminy> _egzaminy;

        public ShowExamForm()
        {
            InitializeComponent();
        }

        public ShowExamForm(List<Egzaminy> egzaminy)
            :this()
        {
            _egzaminy = egzaminy;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.DataSource = _egzaminy;
            dataGridView1.Refresh();
        }
    }
}
