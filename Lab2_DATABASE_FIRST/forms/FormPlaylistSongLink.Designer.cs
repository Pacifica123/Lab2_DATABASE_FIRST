namespace Lab2_DATABASE_FIRST.forms
{
    partial class FormPlaylistSongLink
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlaylistId_CMBX = new System.Windows.Forms.ComboBox();
            this.SongId_CMBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_CANCEL = new System.Windows.Forms.Button();
            this.BUT_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlaylistId_CMBX);
            this.groupBox1.Controls.Add(this.SongId_CMBX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BUT_CANCEL);
            this.groupBox1.Controls.Add(this.BUT_OK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(223, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма создания сязи трек-плейлист";
            // 
            // PlaylistId_CMBX
            // 
            this.PlaylistId_CMBX.FormattingEnabled = true;
            this.PlaylistId_CMBX.Location = new System.Drawing.Point(6, 95);
            this.PlaylistId_CMBX.Name = "PlaylistId_CMBX";
            this.PlaylistId_CMBX.Size = new System.Drawing.Size(200, 23);
            this.PlaylistId_CMBX.TabIndex = 7;
            // 
            // SongId_CMBX
            // 
            this.SongId_CMBX.FormattingEnabled = true;
            this.SongId_CMBX.Location = new System.Drawing.Point(6, 42);
            this.SongId_CMBX.Name = "SongId_CMBX";
            this.SongId_CMBX.Size = new System.Drawing.Size(200, 23);
            this.SongId_CMBX.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Трек";
            // 
            // BUT_CANCEL
            // 
            this.BUT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BUT_CANCEL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BUT_CANCEL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BUT_CANCEL.Location = new System.Drawing.Point(99, 166);
            this.BUT_CANCEL.Name = "BUT_CANCEL";
            this.BUT_CANCEL.Size = new System.Drawing.Size(107, 32);
            this.BUT_CANCEL.TabIndex = 5;
            this.BUT_CANCEL.Text = "Отмена";
            this.BUT_CANCEL.UseVisualStyleBackColor = false;
            this.BUT_CANCEL.Click += new System.EventHandler(this.BUT_CANCEL_Click);
            // 
            // BUT_OK
            // 
            this.BUT_OK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BUT_OK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BUT_OK.Location = new System.Drawing.Point(6, 166);
            this.BUT_OK.Name = "BUT_OK";
            this.BUT_OK.Size = new System.Drawing.Size(87, 32);
            this.BUT_OK.TabIndex = 4;
            this.BUT_OK.Text = "Ок";
            this.BUT_OK.UseVisualStyleBackColor = true;
            this.BUT_OK.Click += new System.EventHandler(this.BUT_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Принадлежит плейлисту";
            // 
            // FormPlaylistSongLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(251, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlaylistSongLink";
            this.Text = "FormPlaylistSongLink";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button BUT_CANCEL;
        private Button BUT_OK;
        private Label label2;
        private ComboBox SongId_CMBX;
        private ComboBox PlaylistId_CMBX;
    }
}