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
    public partial class ShowExaminerForm : Form
    {
        private List<Egzaminatorzy> _egzaminatorzy;
        public ShowExaminerForm()
        {
            InitializeComponent();
        }

        public ShowExaminerForm(List<Egzaminatorzy> egzaminatorzy)
            : this()
        {
            _egzaminatorzy = egzaminatorzy;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;



            DataGridViewColumn newCol = new DataGridViewColumn(); // add a column to the grid
           // DataGridViewCell cell = new DataGridViewCell(); //Specify which type of cell in this column
            //newCol.CellTemplate = cell;

            //newCol.HeaderText = "test2";
            //newCol.Name = "test2";
            //newCol.Visible = true;
            //newCol.Width = 40;

            //dataGridView1.Columns.Add(newCol);


           // dataGridView1.Columns.Add("Uprawnienia", "ewa");
            //Add Columns
            //dataGridView1.ColumnAdded

            //column6.Name = "EgzaminatorImie";
            //column6.HeaderText = "EgzaminatorImie";
           // dataGridView1.Columns[6].DataPropertyName = "EgzaminatorImie";

            //dataGridView1.Columns.Add(column6);


            dataGridView1.DataSource = _egzaminatorzy;
            dataGridView1.Refresh();
        
        }
    }
}
