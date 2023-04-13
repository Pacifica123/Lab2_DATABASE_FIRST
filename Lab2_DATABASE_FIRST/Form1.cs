using Lab2_DATABASE_FIRST.forms;

namespace Lab2_DATABASE_FIRST
{
    public partial class main : Form
    {
        Lab3Context db;
        public main()
        {
            InitializeComponent();
            db = new Lab3Context();
            // ������ ��������� ������
            //User user = new User();
            //user.Login = "test";
            //user.Datereg = DateOnly.Parse("2023-04-09");
            //db.Users.Add(user);
            //db.SaveChanges();
            //mainDGV.DataSource = db.Users.ToList();
        }
        #region ������� SHOW
        private void ShowUsers()
        {
            mainDGV.DataSource = db.Users.ToList();
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "�����";
            mainDGV.Columns[2].HeaderText = "���� �����������";
            mainDGV.Columns[3].Visible = false;
        }
        private void ShowPlaylists()
        {

            mainDGV.DataSource = db.Playlists.ToList();
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "�������� ���������";
            mainDGV.Columns[2].Visible = false;
            mainDGV.Columns[3].Visible = false;
            mainDGV.Columns[4].Visible = false;
            // mainDGV.Columns[5].HeaderText = "��������/���������"; //����� ������ �� join
        }
        private void ShowSongs()
        {
            mainDGV.DataSource = db.Songs.ToList();
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "�������� �����";
            mainDGV.Columns[2].Visible = false;
        }
        private void ShowPlaylistSongs()
        {
            mainDGV.DataSource = db.Playlistsongs.ToList();
            mainDGV.Columns[0].Visible = false;

            //����� �� ����� ������ �� join
            //mainDGV.Columns[1].Visible = false;
            //mainDGV.Columns[2].Visible = false;
            mainDGV.Columns[3].Visible = false;
            mainDGV.Columns[4].Visible = false;
            //mainDGV.Columns[5].HeaderText = "�����";
            //mainDGV.Columns[6].HeaderText = "�������� �����";
        }
        #endregion
        private void SelectTable_CMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectTable_CMBX.SelectedIndex)
            {
                case 0:
                    ShowUsers();
                    break;
                case 1:
                    ShowSongs();
                    break;
                case 2:
                    ShowPlaylists();
                    break;
                case 3:
                    ShowPlaylistSongs();
                    break;
                default:
                    MessageBox.Show("������� �� �������!");
                    return;
            }
        }
        #region ������� ADD
        private void AddUser()
        {
            // ������� �����
            FormUsers formUsers = new FormUsers();
            
            // �������� ��������� �� ����� ��/������
            if (formUsers.ShowDialog() == DialogResult.Cancel) { return; }
            // ������� ����� � ��������� �������� �������
            User user = new User();
            user.Login = formUsers.login;
            user.Datereg = formUsers.dateReg;
            // ��������� � ���������
            db.SaveChanges();
            ShowUsers();
        }
        private void AddSong()
        {
            FormSongs formSongs = new FormSongs();
            if(formSongs.ShowDialog() == DialogResult.Cancel) { return; }
            Song song = new Song();
            song.Title = formSongs.title;
          //  song.Playlistsongs = ???
            db.SaveChanges();
            ShowSongs();
        }
        private void AddPlaylist()
        {
            FormPlaylists formPlaylists = new FormPlaylists();
            if(formPlaylists.ShowDialog() == DialogResult.Cancel) { return; }
            Playlist playlist = new Playlist();
            playlist.Titleplaylist = formPlaylists.title;
            playlist.Userid = formPlaylists.userId;
            // TODO: �������� ��� ������ ��� ��������:
            playlist.User = db.Users.FirstOrDefault(u => u.Id == playlist.Userid);
            db.SaveChanges();
            ShowPlaylists();
        }
        private void AddPlaylistSongs()
        {
            FormPlaylistSongLink formLink = new FormPlaylistSongLink();
            if (formLink.ShowDialog() == DialogResult.Cancel) { return; }


        }
        #endregion
        private void ADD_BUT_Click(object sender, EventArgs e)
        {
            switch (SelectTable_CMBX.SelectedIndex)
            {
                case 0:
                    AddUser();
                    break;
                case 1:
                    // ���������� ����� ����������� ��� AllTrack_playlist ?
                    AddSong();
                    break;
                case 2:
                    AddPlaylist();
                    break;
                case 3:
                    // ���� ����� ��� �� � ����� �� ��������� - ������ ����. �� ��� ���� � Songs ��� AllTrack ��� �������� ��������...
                    AddPlaylistSongs();
                    break;
                default:
                    MessageBox.Show("������� �� �������!");
                    return;
            }
        }
    }
}