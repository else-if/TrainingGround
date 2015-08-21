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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = "0";
            this.AGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = "0";
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.AGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = "0";
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AGrid.DefaultCellStyle = dataGridViewCellStyle19;
            this.AGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AGrid.EnableHeadersVisualStyles = false;
            this.AGrid.Location = new System.Drawing.Point(12, 72);
            this.AGrid.Name = "AGrid";
            this.AGrid.RowHeadersVisible = false;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = "0";
            this.AGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.AGrid.RowTemplate.DefaultCellStyle.Format = "N3";
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
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = "0";
            this.BGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = "0";
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.BGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = "0";
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BGrid.DefaultCellStyle = dataGridViewCellStyle23;
            this.BGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.BGrid.EnableHeadersVisualStyles = false;
            this.BGrid.Location = new System.Drawing.Point(491, 72);
            this.BGrid.Name = "BGrid";
            this.BGrid.RowHeadersVisible = false;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = "0";
            this.BGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = "0";
            this.XGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = "0";
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.XGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.XGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = "0";
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.XGrid.DefaultCellStyle = dataGridViewCellStyle27;
            this.XGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.XGrid.EnableHeadersVisualStyles = false;
            this.XGrid.Location = new System.Drawing.Point(567, 72);
            this.XGrid.Name = "XGrid";
            this.XGrid.RowHeadersVisible = false;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = "0";
            this.XGrid.RowsDefaultCellStyle = dataGridViewCellStyle28;
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
            dataGridViewCellStyle29.NullValue = "0";
            this.EGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.Format = "N2";
            dataGridViewCellStyle30.NullValue = "0";
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.EGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.Format = "E2";
            dataGridViewCellStyle31.NullValue = "0";
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EGrid.DefaultCellStyle = dataGridViewCellStyle31;
            this.EGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EGrid.EnableHeadersVisualStyles = false;
            this.EGrid.Location = new System.Drawing.Point(640, 72);
            this.EGrid.Name = "EGrid";
            this.EGrid.RowHeadersVisible = false;
            dataGridViewCellStyle32.NullValue = "0";
            this.EGrid.RowsDefaultCellStyle = dataGridViewCellStyle32;
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

