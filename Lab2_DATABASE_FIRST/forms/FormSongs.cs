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
    public partial class FormSongs : Form
    {
        public string title { get; set; }
        public FormSongs()
        {
            InitializeComponent();
        }

        private void BUT_OK_Click(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void BUT_CANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            return;
        }
    }
}
