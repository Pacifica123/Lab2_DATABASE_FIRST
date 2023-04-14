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
            // тестил начальную работу
            //User user = new User();
            //user.Login = "test";
            //user.Datereg = DateOnly.Parse("2023-04-09");
            //db.Users.Add(user);
            //db.SaveChanges();
            //mainDGV.DataSource = db.Users.ToList();
        }
        #region ФУНКЦИИ SHOW
        private void ShowUsers()
        {
            mainDGV.DataSource = db.Users.ToList();
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "Логин";
            mainDGV.Columns[2].HeaderText = "Дата регистрации";
            mainDGV.Columns[3].Visible = false;
        }
        private void ShowPlaylists()
        {

            //mainDGV.DataSource = db.Playlists.ToList();
            var playlist = from p in db.Playlists
                           join u in db.Users on p.Userid equals u.Id
                           select new
                           {
                               p.Id,
                               p.Titleplaylist,
                               u.Login
                           };
            mainDGV.DataSource = playlist.AsEnumerable().ToList();
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "Название плейлиста";
            //mainDGV.Columns[2].Visible = false;
            //mainDGV.Columns[3].Visible = false;
            //mainDGV.Columns[4].Visible = false;
            mainDGV.Columns[2].HeaderText = "Владелец/Создатель"; //когда дойдем до join

        }
        private void ShowSongs()
        {
            mainDGV.DataSource = db.Songs.ToList();
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "Название песни";
            mainDGV.Columns[2].Visible = false;
        }
        private void ShowPlaylistSongs()
        {
            //mainDGV.DataSource = db.Playlistsongs.ToList();

            var link = from l in db.Playlistsongs
                       join s in db.Songs on l.Songid equals s.Id
                       join p in db.Playlists on l.Playlistid equals p.Id
                       select new
                       {
                           l.Id,
                           s.Title,
                           p.Titleplaylist
                       };
            
            mainDGV.Columns[0].Visible = false;

            //опять же когда дойдем до join
            //mainDGV.Columns[1].Visible = false;
            //mainDGV.Columns[2].Visible = false;
           // mainDGV.Columns[3].Visible = false;
           // mainDGV.Columns[4].Visible = false;
            mainDGV.Columns[1].HeaderText = "Песня";
            mainDGV.Columns[2].HeaderText = "Плейлист песни";
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
                    MessageBox.Show("Таблицы не выбрана!");
                    return;
            }
        }
        #region ФУНКЦИИ ADD
        private void AddUser()
        {
            // Создаем форму
            FormUsers formUsers = new FormUsers();
            
            // Получаем результат из формы ОК/Отмена
            if (formUsers.ShowDialog() == DialogResult.Cancel) { return; }
            // Создаем юзера и заполняем входными данными
            User user = new User();
            user.Login = formUsers.login;
            user.Datereg = formUsers.dateReg;
           // var playlistList = db.Playlists.Where(p => p.Id)
            //user.Playlists
            // Сохраняем и обновляем
            db.Users.Add(user);
            db.SaveChanges(); ShowUsers();
        }
        private void AddSong()
        {
            FormSongs formSongs = new FormSongs();
            if(formSongs.ShowDialog() == DialogResult.Cancel) { return; }
            Song song = new Song();
            song.Title = formSongs.title;
            //  song.Playlistsongs = ???
            db.Songs.Add(song);
            db.SaveChanges(); ShowSongs();
        }
        private void AddPlaylist()
        {
            FormPlaylists formPlaylists = new FormPlaylists();
            if(formPlaylists.ShowDialog() == DialogResult.Cancel) { return; }
            Playlist playlist = new Playlist();
            playlist.Titleplaylist = formPlaylists.title;
            playlist.Userid = formPlaylists.userId;
            // TODO: подумать как решить эту проблему c NULL:
            playlist.User = db.Users.FirstOrDefault(u => u.Id == playlist.Userid);
            playlist.User.Playlists.Add(playlist);
            db.Playlists.Add(playlist);
            db.SaveChanges(); ShowPlaylists();
        }
        private void AddPlaylistSongs()
        {
            FormPlaylistSongLink formLink = new FormPlaylistSongLink();
            if (formLink.ShowDialog() == DialogResult.Cancel) { return; }
            Playlistsong link = new Playlistsong();
            link.Playlistid = formLink.id_playlist;
            link.Songid = formLink.id_song;
            link.Playlist = db.Playlists.FirstOrDefault(p => p.Id == link.Playlistid);
            link.Song = db.Songs.FirstOrDefault(s => s.Id == link.Songid);
            link.Song.Playlistsongs.Add(link);
            db.Playlistsongs.Add(link);
            db.SaveChanges(); ShowPlaylistSongs();
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
                    // абстрактно можно представить как AllTrack_playlist ?
                    AddSong();
                    break;
                case 2:
                    AddPlaylist();
                    break;
                case 3:
                    // если песни нет ни в каком из плейлисте - записи нету. Но она есть в Songs аля AllTrack или коренвой плейлист...
                    AddPlaylistSongs();
                    break;
                default:
                    MessageBox.Show("Таблицы не выбрана!");
                    return;
            }
        }
        #region ФУНКЦИИ DEL
        private void DelUser(int id)
        {
            User user = db.Users.FirstOrDefault(u => u.Id == id);
            db.Users.Remove(user);
            MessageBox.Show("Запись удалена!");
            db.SaveChanges();
            ShowUsers();
        }
        private void DelSong(int id)
        {
            Song song = db.Songs.FirstOrDefault(s => s.Id == id);
            db.Songs.Remove(song);
            MessageBox.Show("Запись удалена!");
            db.SaveChanges();
            ShowSongs();
        }
        private void DelPlaylist(int id)
        {
            Playlist playlist = db.Playlists.FirstOrDefault(p => p.Id == id);
            db.Playlists.Remove(playlist);
            MessageBox.Show("Запись удалена!");
            db.SaveChanges();
            ShowPlaylists();
        }
        private void DelLink(int id)
        {
            Playlistsong link = db.Playlistsongs.FirstOrDefault(l => l.Id == id);
            db.Playlistsongs.Remove(link);
            MessageBox.Show("Запись удалена!");
            db.SaveChanges();
            ShowPlaylistSongs();
        }
        #endregion
        private void DEL_BUT_Click(object sender, EventArgs e)
        {
            if(SelectTable_CMBX.SelectedValue == null)
            { MessageBox.Show("Таблицы не выбрана!"); return; }
            int selectedid = Convert.ToInt32(mainDGV.CurrentRow.Cells[0].Value);
            switch (SelectTable_CMBX.SelectedIndex)
            {
                case 0:
                    DelUser(selectedid);
                    break;
                case 1:
                    DelSong(selectedid);
                    break;
                case 2:
                    DelPlaylist(selectedid);
                    break;
                case 3:
                    DelLink(selectedid);
                    break;
                default:
                    MessageBox.Show("Произошло что-то странное");
                    break;
            }
        }
    }
}