namespace Lab2_DATABASE_FIRST
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.ADD_BUT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EDIT_BUT = new System.Windows.Forms.Button();
            this.DEL_BUT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTable_CMBX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.AllowUserToDeleteRows = false;
            this.mainDGV.AllowUserToResizeColumns = false;
            this.mainDGV.AllowUserToResizeRows = false;
            this.mainDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainDGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainDGV.EnableHeadersVisualStyles = false;
            this.mainDGV.Location = new System.Drawing.Point(267, 0);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainDGV.RowHeadersVisible = false;
            this.mainDGV.RowTemplate.Height = 25;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(533, 450);
            this.mainDGV.TabIndex = 0;
            // 
            // ADD_BUT
            // 
            this.ADD_BUT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ADD_BUT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD_BUT.Location = new System.Drawing.Point(4, 169);
            this.ADD_BUT.Name = "ADD_BUT";
            this.ADD_BUT.Size = new System.Drawing.Size(257, 66);
            this.ADD_BUT.TabIndex = 1;
            this.ADD_BUT.Text = "ДОБАВИТЬ";
            this.ADD_BUT.UseVisualStyleBackColor = false;
            this.ADD_BUT.Click += new System.EventHandler(this.ADD_BUT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "МЕНЮ";
            // 
            // EDIT_BUT
            // 
            this.EDIT_BUT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EDIT_BUT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EDIT_BUT.Location = new System.Drawing.Point(4, 241);
            this.EDIT_BUT.Name = "EDIT_BUT";
            this.EDIT_BUT.Size = new System.Drawing.Size(257, 66);
            this.EDIT_BUT.TabIndex = 3;
            this.EDIT_BUT.Text = "ИЗМЕНИТЬ";
            this.EDIT_BUT.UseVisualStyleBackColor = false;
            this.EDIT_BUT.Click += new System.EventHandler(this.EDIT_BUT_Click);
            // 
            // DEL_BUT
            // 
            this.DEL_BUT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DEL_BUT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DEL_BUT.Location = new System.Drawing.Point(4, 313);
            this.DEL_BUT.Name = "DEL_BUT";
            this.DEL_BUT.Size = new System.Drawing.Size(257, 66);
            this.DEL_BUT.TabIndex = 4;
            this.DEL_BUT.Text = "УДАЛИТЬ";
            this.DEL_BUT.UseVisualStyleBackColor = false;
            this.DEL_BUT.Click += new System.EventHandler(this.DEL_BUT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбор таблицы:";
            // 
            // SelectTable_CMBX
            // 
            this.SelectTable_CMBX.FormattingEnabled = true;
            this.SelectTable_CMBX.Items.AddRange(new object[] {
            "Пользователи",
            "Песни",
            "Плейлисты",
            "Плейлист-Песня связь"});
            this.SelectTable_CMBX.Location = new System.Drawing.Point(12, 92);
            this.SelectTable_CMBX.Name = "SelectTable_CMBX";
            this.SelectTable_CMBX.Size = new System.Drawing.Size(249, 23);
            this.SelectTable_CMBX.TabIndex = 6;
            this.SelectTable_CMBX.SelectedIndexChanged += new System.EventHandler(this.SelectTable_CMBX_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectTable_CMBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DEL_BUT);
            this.Controls.Add(this.EDIT_BUT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADD_BUT);
            this.Controls.Add(this.mainDGV);
            this.Name = "main";
            this.Text = "Lab2DATABASE_FIRST";
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView mainDGV;
        private Button ADD_BUT;
        private Label label1;
        private Button EDIT_BUT;
        private Button DEL_BUT;
        private Label label2;
        private ComboBox SelectTable_CMBX;
    }
}