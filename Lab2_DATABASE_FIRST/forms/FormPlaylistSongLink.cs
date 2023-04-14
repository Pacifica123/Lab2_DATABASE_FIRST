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
    public partial class FormPlaylistSongLink : Form
    {
        public int id_song { get; set; }
        public int id_playlist { get; set; }
        public FormPlaylistSongLink()
        {
            InitializeComponent();

            SongId_CMBX.DataSource = new Lab3Context().Songs.ToList();
            SongId_CMBX.ValueMember = "Id";
            SongId_CMBX.DisplayMember = "Title";

            PlaylistId_CMBX.DataSource = new Lab3Context().Playlists.ToList();
            PlaylistId_CMBX.ValueMember = "Id";
            PlaylistId_CMBX.DisplayMember = "Titleplaylist";
        }

        private void BUT_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            id_song = Convert.ToInt32(SongId_CMBX.SelectedValue);
            id_playlist = Convert.ToInt32(PlaylistId_CMBX.SelectedValue);
        }

        private void BUT_CANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            return;
        }

        public void LoadEdit(int playlist_id, int song_id)
        {
            PlaylistId_CMBX.SelectedValue = playlist_id;
            PlaylistId_CMBX.SelectedValue = song_id;
        }
    }
}
