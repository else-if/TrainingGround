namespace Gauss
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelVariablesCount = new System.Windows.Forms.Label();
            this.VariablesCount = new System.Windows.Forms.NumericUpDown();
            this.AGrid = new System.Windows.Forms.DataGridView();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariablesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(821, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // tESTToolStripMenuItem
            // 
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.AGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.AGrid.Location = new System.Drawing.Point(15, 51);
            this.AGrid.Name = "AGrid";
            this.AGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.AGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AGrid.RowTemplate.DefaultCellStyle.Format = "N2";
            this.AGrid.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.AGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AGrid.Size = new System.Drawing.Size(472, 258);
            this.AGrid.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 385);
            this.Controls.Add(this.AGrid);
            this.Controls.Add(this.VariablesCount);
            this.Controls.Add(this.LabelVariablesCount);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Gauss";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariablesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.Label LabelVariablesCount;
        private System.Windows.Forms.NumericUpDown VariablesCount;
        private System.Windows.Forms.DataGridView AGrid;
    }
}

