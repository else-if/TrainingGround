namespace GaussSolution
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelVariablesCount = new System.Windows.Forms.Label();
            this.VariablesCount = new System.Windows.Forms.NumericUpDown();
            this.AGrid = new System.Windows.Forms.DataGridView();
            this.labelBGrid = new System.Windows.Forms.Label();
            this.labelAGrid = new System.Windows.Forms.Label();
            this.BGrid = new System.Windows.Forms.DataGridView();
            this.labelXGrid = new System.Windows.Forms.Label();
            this.XGrid = new System.Windows.Forms.DataGridView();
            this.EGrid = new System.Windows.Forms.DataGridView();
            this.labelEGrid = new System.Windows.Forms.Label();
            this.PrevStep = new System.Windows.Forms.Button();
            this.NextStep = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelAnalysis = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariablesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(788, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomValuesToolStripMenuItem});
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.tESTToolStripMenuItem.Text = "TEST";
            // 
            // randomValuesToolStripMenuItem
            // 
            this.randomValuesToolStripMenuItem.Name = "randomValuesToolStripMenuItem";
            this.randomValuesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.randomValuesToolStripMenuItem.Text = "Random values";
            this.randomValuesToolStripMenuItem.Click += new System.EventHandler(this.randomValuesToolStripMenuItem_Click);
            // 
            // LabelVariablesCount
            // 
            this.LabelVariablesCount.AutoSize = true;
            this.LabelVariablesCount.Location = new System.Drawing.Point(12, 27);
            this.LabelVariablesCount.Name = "LabelVariablesCount";
            this.LabelVariablesCount.Size = new System.Drawing.Size(138, 13);
            this.LabelVariablesCount.TabIndex = 2;
            this.LabelVariablesCount.Text = "Количество неизвестных:";
            // 
            // VariablesCount
            // 
            this.VariablesCount.Location = new System.Drawing.Point(156, 25);
            this.VariablesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VariablesCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VariablesCount.Name = "VariablesCount";
            this.VariablesCount.Size = new System.Drawing.Size(37, 20);
            this.VariablesCount.TabIndex = 3;
            this.VariablesCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VariablesCount.ValueChanged += new System.EventHandler(this.VariablesCount_ValueChanged);
            // 
            // AGrid
            // 
            this.AGrid.AllowUserToAddRows = false;
            this.AGrid.AllowUserToDeleteRows = false;
            this.AGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.AGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.AGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AGrid.EnableHeadersVisualStyles = false;
            this.AGrid.Location = new System.Drawing.Point(12, 72);
            this.AGrid.Name = "AGrid";
            this.AGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.AGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AGrid.RowTemplate.DefaultCellStyle.Format = "N3";
            this.AGrid.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.AGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AGrid.Size = new System.Drawing.Size(469, 258);
            this.AGrid.TabIndex = 4;
            this.AGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.AGrid_CellValidating);
            // 
            // labelBGrid
            // 
            this.labelBGrid.AutoSize = true;
            this.labelBGrid.Location = new System.Drawing.Point(488, 56);
            this.labelBGrid.Name = "labelBGrid";
            this.labelBGrid.Size = new System.Drawing.Size(64, 13);
            this.labelBGrid.TabIndex = 5;
            this.labelBGrid.Text = "Матрица B:";
            // 
            // labelAGrid
            // 
            this.labelAGrid.AutoSize = true;
            this.labelAGrid.Location = new System.Drawing.Point(12, 56);
            this.labelAGrid.Name = "labelAGrid";
            this.labelAGrid.Size = new System.Drawing.Size(64, 13);
            this.labelAGrid.TabIndex = 6;
            this.labelAGrid.Text = "Матрица A:";
            // 
            // BGrid
            // 
            this.BGrid.AllowUserToAddRows = false;
            this.BGrid.AllowUserToDeleteRows = false;
            this.BGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.BGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.BGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.BGrid.EnableHeadersVisualStyles = false;
            this.BGrid.Location = new System.Drawing.Point(491, 72);
            this.BGrid.Name = "BGrid";
            this.BGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.BGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.BGrid.RowTemplate.DefaultCellStyle.Format = "N3";
            this.BGrid.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.BGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BGrid.Size = new System.Drawing.Size(64, 258);
            this.BGrid.TabIndex = 7;
            // 
            // labelXGrid
            // 
            this.labelXGrid.AutoSize = true;
            this.labelXGrid.Location = new System.Drawing.Point(570, 56);
            this.labelXGrid.Name = "labelXGrid";
            this.labelXGrid.Size = new System.Drawing.Size(64, 13);
            this.labelXGrid.TabIndex = 8;
            this.labelXGrid.Text = "Матрица X:";
            // 
            // XGrid
            // 
            this.XGrid.AllowUserToAddRows = false;
            this.XGrid.AllowUserToDeleteRows = false;
            this.XGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.XGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.XGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.XGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.XGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.XGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.XGrid.EnableHeadersVisualStyles = false;
            this.XGrid.Location = new System.Drawing.Point(567, 72);
            this.XGrid.Name = "XGrid";
            this.XGrid.ReadOnly = true;
            this.XGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0";
            this.XGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.XGrid.RowTemplate.DefaultCellStyle.Format = "N3";
            this.XGrid.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.XGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.XGrid.Size = new System.Drawing.Size(64, 258);
            this.XGrid.TabIndex = 9;
            // 
            // EGrid
            // 
            this.EGrid.AllowUserToAddRows = false;
            this.EGrid.AllowUserToDeleteRows = false;
            this.EGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.NullValue = "0";
            this.EGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.EGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.Format = "E2";
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.EGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EGrid.EnableHeadersVisualStyles = false;
            this.EGrid.Location = new System.Drawing.Point(640, 72);
            this.EGrid.Name = "EGrid";
            this.EGrid.ReadOnly = true;
            this.EGrid.RowHeadersVisible = false;
            dataGridViewCellStyle16.NullValue = "0";
            this.EGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.EGrid.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.EGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EGrid.Size = new System.Drawing.Size(64, 258);
            this.EGrid.TabIndex = 11;
            // 
            // labelEGrid
            // 
            this.labelEGrid.AutoSize = true;
            this.labelEGrid.Location = new System.Drawing.Point(643, 56);
            this.labelEGrid.Name = "labelEGrid";
            this.labelEGrid.Size = new System.Drawing.Size(64, 13);
            this.labelEGrid.TabIndex = 10;
            this.labelEGrid.Text = "Матрица E:";
            // 
            // PrevStep
            // 
            this.PrevStep.Location = new System.Drawing.Point(93, 336);
            this.PrevStep.Name = "PrevStep";
            this.PrevStep.Size = new System.Drawing.Size(35, 20);
            this.PrevStep.TabIndex = 14;
            this.PrevStep.Text = "<<";
            this.PrevStep.UseVisualStyleBackColor = true;
            this.PrevStep.Click += new System.EventHandler(this.PrevStep_Click);
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(129, 336);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(35, 20);
            this.NextStep.TabIndex = 15;
            this.NextStep.Text = ">>";
            this.NextStep.UseVisualStyleBackColor = true;
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(199, 25);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 20);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelAnalysis
            // 
            this.labelAnalysis.AutoSize = true;
            this.labelAnalysis.Location = new System.Drawing.Point(11, 340);
            this.labelAnalysis.Name = "labelAnalysis";
            this.labelAnalysis.Size = new System.Drawing.Size(81, 13);
            this.labelAnalysis.TabIndex = 17;
            this.labelAnalysis.Text = "Анализ шагов:";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(170, 340);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(0, 13);
            this.labelStep.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 381);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.labelAnalysis);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.NextStep);
            this.Controls.Add(this.PrevStep);
            this.Controls.Add(this.EGrid);
            this.Controls.Add(this.labelEGrid);
            this.Controls.Add(this.XGrid);
            this.Controls.Add(this.labelXGrid);
            this.Controls.Add(this.BGrid);
            this.Controls.Add(this.labelAGrid);
            this.Controls.Add(this.labelBGrid);
            this.Controls.Add(this.AGrid);
            this.Controls.Add(this.VariablesCount);
            this.Controls.Add(this.LabelVariablesCount);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Gauss";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariablesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.Label LabelVariablesCount;
        private System.Windows.Forms.NumericUpDown VariablesCount;
        private System.Windows.Forms.DataGridView AGrid;
        private System.Windows.Forms.Label labelBGrid;
        private System.Windows.Forms.Label labelAGrid;
        private System.Windows.Forms.DataGridView BGrid;
        private System.Windows.Forms.Label labelXGrid;
        private System.Windows.Forms.DataGridView XGrid;
        private System.Windows.Forms.DataGridView EGrid;
        private System.Windows.Forms.Label labelEGrid;
        private System.Windows.Forms.Button PrevStep;
        private System.Windows.Forms.Button NextStep;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelAnalysis;
        private System.Windows.Forms.ToolStripMenuItem randomValuesToolStripMenuItem;
        private System.Windows.Forms.Label labelStep;
    }
}

