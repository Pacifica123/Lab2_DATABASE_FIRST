﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_DATABASE_FIRST.forms
{
    public partial class FormPlaylists : Form
    {
        public string title { get; set; }
        public int userId { get; set; }
        public FormPlaylists()
        {
            InitializeComponent();
            UserId_CMBX.DataSource = new Lab3Context().Users.ToList();
            UserId_CMBX.ValueMember = "Id";
            UserId_CMBX.DisplayMember = "Login";
        }

        private void BUT_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            title = txtLogin.Text;
            userId = Convert.ToInt32( UserId_CMBX.SelectedValue);
        }

        private void BUT_CANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            return;
        }

        public void LoadEdit(string oldtitle, int id_user)
        {
            txtLogin.Text = oldtitle;
            UserId_CMBX.SelectedValue = id_user;
        }
    }
}
