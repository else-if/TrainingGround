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
        private Gauss Engine;
        private int currentStepIndex = 0;

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
            int colWidth = 60;
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
            this.labelStep.Top = this.labelAnalysis.Top;

            this.Width = this.EGrid.Left + this.EGrid.Width + 24;
            this.Height = this.NextStep.Top + this.NextStep.Height + this.MainMenu.Size.Height + 18;
        }
        private void VariablesCount_ValueChanged(object sender, EventArgs e)
        {
            InitializeElements();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            currentStepIndex = 0;

            int varCount = (int)this.VariablesCount.Value;
            double[,] A = new double[varCount, varCount];
            double []B = new double[varCount];

            for (int i = 0; i < varCount; i++)
            {
                if (this.BGrid[0, i].Value == null) this.BGrid[0, i].Value = 0;
                B[i] = Convert.ToDouble(this.BGrid[0, i].Value.ToString());

                for (int j = 0; j < varCount; j++)
                {
                    if (this.AGrid[j, i].Value == null) this.AGrid[j, i].Value = 0;
                    A[i, j] = Convert.ToDouble(this.AGrid[j, i].Value.ToString());
                }
            }

            Engine = new Gauss(varCount, A, B);
            Engine.Calculate();

            if (Engine.ErrMsg == "")
            {
                for (int i = 0; i < varCount; i++)
                {
                    this.XGrid[0, i].Value = Engine.X[i];
                    this.EGrid[0, i].Value = Engine.E[i];
                }
            }
            else
            {
                MessageBox.Show(Engine.ErrMsg);
            }

            SetStepText();
        }

        private void PrevStep_Click(object sender, EventArgs e)
        {
            int varCount = (int)this.VariablesCount.Value;

            if ((Engine != null) && (currentStepIndex > 0) && (Engine.Steps.Count != 0))
            {
                currentStepIndex--;
                GaussStep currentStep = Engine.Steps[currentStepIndex];

                for (int i = 0; i < varCount; i++)
                {
                    this.BGrid[0, i].Value = currentStep.B[i];

                    for (int j = 0; j < varCount; j++)
                        this.AGrid[j, i].Value = currentStep.A[i, j];
                }
            }

            SetStepText();

        }
        private void NextStep_Click(object sender, EventArgs e)
        {
            int varCount = (int)this.VariablesCount.Value;

            if ((Engine != null) && (currentStepIndex < Engine.Steps.Count - 1))
            {
                currentStepIndex++;
                GaussStep currentStep = Engine.Steps[currentStepIndex];

                for (int i = 0; i < varCount; i++)
                {
                    this.BGrid[0, i].Value = currentStep.B[i];

                    for (int j = 0; j < varCount; j++)
                        this.AGrid[j, i].Value = currentStep.A[i, j];
                }
            }

            SetStepText();
        }

        private void SetStepText()
        {
            if ((Engine == null) || (Engine.Steps.Count == 0)) labelStep.Text = "";
            else labelStep.Text = (currentStepIndex + 1).ToString() + " / " + Engine.Steps.Count.ToString();
        }

        private void AGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            this.AGrid[e.ColumnIndex, e.RowIndex].ErrorText = "";
            double newDouble;

            if (!Double.TryParse(e.FormattedValue.ToString(), out newDouble))
            {
                e.Cancel = true;
                this.AGrid[e.ColumnIndex, e.RowIndex].ErrorText = "В ячейке должно быть указано числовое значение";
            }
        }
        private void BGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            this.BGrid[e.ColumnIndex, e.RowIndex].ErrorText = "";
            double newDouble;

            if (!Double.TryParse(e.FormattedValue.ToString(), out newDouble))
            {
                e.Cancel = true;
                this.BGrid[e.ColumnIndex, e.RowIndex].ErrorText = "В ячейке должно быть указано числовое значение";
            }            
        }

        private void randomValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int varCount = (int)this.VariablesCount.Value;

            Random Rnd = new Random();

            for (int i = 0; i < varCount; i++)
            {
                this.BGrid[0, i].Value = Rnd.Next(-100, 100);

                for (int j = 0; j < varCount; j++)
                    this.AGrid[j, i].Value = Rnd.Next(-100, 100);

            }
        }
        private void happyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.VariablesCount.Value = 4;
            InitializeElements();

            double[,] A = { { -3, 4, 1, 4 }, { 0, 1, 3, 2 }, { 4, 0, -2, -3 }, { 1000, 3, 1, -5 } };
            double[] B = { -1, -1, 4, -2 };

            int varCount = (int)this.VariablesCount.Value;

            for (int i = 0; i < varCount; i++)
            {
                this.BGrid[0, i].Value = B[i];

                for (int j = 0; j < varCount; j++)
                    this.AGrid[j, i].Value = A[i, j];

            }

        }
        private void unhappyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.VariablesCount.Value = 4;
            InitializeElements();

            double[,] A = { { -3, 4, 1, 4 }, { 0, 1, 3, 2 }, { 4, 0, -2, -3 }, { -6, 8, 2, 8 } };
            double[] B = { -1, -1, 4, -2 };

            int varCount = (int)this.VariablesCount.Value;

            for (int i = 0; i < varCount; i++)
            {
                this.BGrid[0, i].Value = B[i];

                for (int j = 0; j < varCount; j++)
                    this.AGrid[j, i].Value = A[i, j];

            }
        }


    }
}
