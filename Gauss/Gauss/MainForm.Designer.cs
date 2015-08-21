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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.randomValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            dataGridViewCellStyle33.Format = "N2";
            dataGridViewCellStyle33.NullValue = "0";
            this.AGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.Format = "N2";
            dataGridViewCellStyle34.NullValue = "0";
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.AGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.Format = "N2";
            dataGridViewCellStyle35.NullValue = "0";
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AGrid.DefaultCellStyle = dataGridViewCellStyle35;
            this.AGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AGrid.EnableHeadersVisualStyles = false;
            this.AGrid.Location = new System.Drawing.Point(12, 72);
            this.AGrid.Name = "AGrid";
            this.AGrid.RowHeadersVisible = false;
            dataGridViewCellStyle36.Format = "N2";
            dataGridViewCellStyle36.NullValue = "0";
            this.AGrid.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.AGrid.RowTemplate.DefaultCellStyle.Format = "N2";
            this.AGrid.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.AGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AGrid.Size = new System.Drawing.Size(469, 258);
            this.AGrid.TabIndex = 4;
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
            dataGridViewCellStyle37.Format = "N2";
            dataGridViewCellStyle37.NullValue = "0";
            this.BGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.Format = "N2";
            dataGridViewCellStyle38.NullValue = "0";
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.BGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.Format = "N2";
            dataGridViewCellStyle39.NullValue = "0";
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BGrid.DefaultCellStyle = dataGridViewCellStyle39;
            this.BGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.BGrid.EnableHeadersVisualStyles = false;
            this.BGrid.Location = new System.Drawing.Point(491, 72);
            this.BGrid.Name = "BGrid";
            this.BGrid.RowHeadersVisible = false;
            dataGridViewCellStyle40.Format = "N2";
            dataGridViewCellStyle40.NullValue = "0";
            this.BGrid.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.BGrid.RowTemplate.DefaultCellStyle.Format = "N2";
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
            dataGridViewCellStyle41.Format = "N2";
            dataGridViewCellStyle41.NullValue = "0";
            this.XGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.Format = "N2";
            dataGridViewCellStyle42.NullValue = "0";
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.XGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.XGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.Format = "N2";
            dataGridViewCellStyle43.NullValue = "0";
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.XGrid.DefaultCellStyle = dataGridViewCellStyle43;
            this.XGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.XGrid.EnableHeadersVisualStyles = false;
            this.XGrid.Location = new System.Drawing.Point(567, 72);
            this.XGrid.Name = "XGrid";
            this.XGrid.RowHeadersVisible = false;
            dataGridViewCellStyle44.Format = "N2";
            dataGridViewCellStyle44.NullValue = "0";
            this.XGrid.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.XGrid.RowTemplate.DefaultCellStyle.Format = "N2";
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
            dataGridViewCellStyle45.Format = "N2";
            dataGridViewCellStyle45.NullValue = "0";
            this.EGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.Format = "N2";
            dataGridViewCellStyle46.NullValue = "0";
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.EGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.Format = "N2";
            dataGridViewCellStyle47.NullValue = "0";
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EGrid.DefaultCellStyle = dataGridViewCellStyle47;
            this.EGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EGrid.EnableHeadersVisualStyles = false;
            this.EGrid.Location = new System.Drawing.Point(640, 72);
            this.EGrid.Name = "EGrid";
            this.EGrid.RowHeadersVisible = false;
            dataGridViewCellStyle48.Format = "N2";
            dataGridViewCellStyle48.NullValue = "0";
            this.EGrid.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.EGrid.RowTemplate.DefaultCellStyle.Format = "N2";
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
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(129, 336);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(35, 20);
            this.NextStep.TabIndex = 15;
            this.NextStep.Text = ">>";
            this.NextStep.UseVisualStyleBackColor = true;
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
            // randomValuesToolStripMenuItem
            // 
            this.randomValuesToolStripMenuItem.Name = "randomValuesToolStripMenuItem";
            this.randomValuesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.randomValuesToolStripMenuItem.Text = "Random values";
            this.randomValuesToolStripMenuItem.Click += new System.EventHandler(this.randomValuesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 381);
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
    }
}

