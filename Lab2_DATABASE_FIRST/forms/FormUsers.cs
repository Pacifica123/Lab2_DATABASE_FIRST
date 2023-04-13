using System;
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
    public partial class FormUsers : Form
    {
        public string login { get; set; }
        public DateOnly dateReg { get; set; }

        public FormUsers()
        {
            InitializeComponent();
        }

        private void BUT_OK_Click(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            dateReg = DateOnly.FromDateTime(dateTimePicker1.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void BUT_CANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            return;
        }
    }
}
