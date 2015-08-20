using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussSolution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeElements();
        }
        private void InitializeElements()
        {
            int colWidth = 40;
            int rowHeight = 20;

            this.AGrid.ColumnCount = (int)VariablesCount.Value;
            this.AGrid.RowCount = (int)VariablesCount.Value;
            foreach (DataGridViewRow Row in this.AGrid.Rows)
                Row.Height = rowHeight;
            foreach (DataGridViewColumn Col in this.AGrid.Columns)
            {
                Col.Width = colWidth;
                Col.HeaderText = "a" + this.AGrid.Columns.IndexOf(Col);
            }

            this.AGrid.Width = colWidth * this.AGrid.ColumnCount + this.AGrid.Margin.Left;
            this.AGrid.Height = rowHeight * (this.AGrid.RowCount + 1);

            this.BGrid.ColumnCount = 1;
            this.BGrid.RowCount = (int)VariablesCount.Value;

            this.BGrid.Columns[0].HeaderText = "b";
            this.BGrid.Columns[0].Width = colWidth;

            foreach (DataGridViewRow Row in this.BGrid.Rows)
                Row.Height = rowHeight;

            this.labelBGrid.Left = this.AGrid.Left + this.AGrid.Width + 5;
            this.BGrid.Left = this.labelBGrid.Left + 5;
            this.BGrid.Height = this.AGrid.Height;
            this.BGrid.Width = colWidth * this.BGrid.ColumnCount + this.BGrid.Margin.Left;

            this.XGrid.ColumnCount = 1;
            this.XGrid.RowCount = (int)VariablesCount.Value;

            this.XGrid.Columns[0].HeaderText = "x";
            this.XGrid.Columns[0].Width = colWidth;

            foreach (DataGridViewRow Row in this.XGrid.Rows)
                Row.Height = rowHeight;

            this.labelXGrid.Left = this.BGrid.Left + this.BGrid.Width + 25;
            this.XGrid.Left = this.labelXGrid.Left + 5;
            this.XGrid.Height = this.AGrid.Height;
            this.XGrid.Width = colWidth * this.XGrid.ColumnCount + this.XGrid.Margin.Left;

            this.EGrid.ColumnCount = 1;
            this.EGrid.RowCount = (int)VariablesCount.Value;

            this.EGrid.Columns[0].HeaderText = "e";
            this.EGrid.Columns[0].Width = colWidth;

            foreach (DataGridViewRow Row in this.EGrid.Rows)
                Row.Height = rowHeight;

            this.labelEGrid.Left = this.XGrid.Left + this.XGrid.Width + 15;
            this.EGrid.Left = this.labelEGrid.Left + 5;
            this.EGrid.Height = this.AGrid.Height;
            this.EGrid.Width = colWidth * this.EGrid.ColumnCount + this.EGrid.Margin.Left;

            this.labelAnalysis.Top = this.AGrid.Top + this.AGrid.Height + 10;
            this.PrevStep.Top = this.labelAnalysis.Top-3;
            this.NextStep.Top = this.labelAnalysis.Top-3;

            this.Width = this.labelEGrid.Left + this.labelEGrid.Width + 18;
            this.Height = this.NextStep.Top + this.NextStep.Height + this.MainMenu.Size.Height + 18;
        }
        private void VariablesCount_ValueChanged(object sender, EventArgs e)
        {
            InitializeElements();
        }
    }
}
