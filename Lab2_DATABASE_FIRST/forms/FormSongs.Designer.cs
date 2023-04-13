namespace Lab2_DATABASE_FIRST.forms
{
    partial class FormSongs
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
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_CANCEL = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.BUT_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BUT_CANCEL);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.BUT_OK);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(295, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма создания трека";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название песни";
            // 
            // BUT_CANCEL
            // 
            this.BUT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BUT_CANCEL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BUT_CANCEL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BUT_CANCEL.Location = new System.Drawing.Point(99, 71);
            this.BUT_CANCEL.Name = "BUT_CANCEL";
            this.BUT_CANCEL.Size = new System.Drawing.Size(107, 32);
            this.BUT_CANCEL.TabIndex = 5;
            this.BUT_CANCEL.Text = "Отмена";
            this.BUT_CANCEL.UseVisualStyleBackColor = false;
            this.BUT_CANCEL.Click += new System.EventHandler(this.BUT_CANCEL_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(256, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // BUT_OK
            // 
            this.BUT_OK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BUT_OK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BUT_OK.Location = new System.Drawing.Point(6, 71);
            this.BUT_OK.Name = "BUT_OK";
            this.BUT_OK.Size = new System.Drawing.Size(87, 32);
            this.BUT_OK.TabIndex = 4;
            this.BUT_OK.Text = "Ок";
            this.BUT_OK.UseVisualStyleBackColor = true;
            this.BUT_OK.Click += new System.EventHandler(this.BUT_OK_Click);
            // 
            // FormSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(319, 138);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSongs";
            this.Text = "FormSongs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button BUT_CANCEL;
        private TextBox txtTitle;
        private Button BUT_OK;
    }
}