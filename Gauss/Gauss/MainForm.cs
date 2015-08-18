using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauss
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeGrids();
        }

        private void InitializeGrids()
        {
            this.AGrid.ColumnCount = (int)VariablesCount.Value;
            this.AGrid.RowCount = (int)VariablesCount.Value;
            
        }

        private void VariablesCount_ValueChanged(object sender, EventArgs e)
        {
            InitializeGrids();
        }
    }
}
