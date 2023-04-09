namespace Lab2_DATABASE_FIRST
{
    public partial class main : Form
    {
        Lab3Context db;
        public main()
        {
            InitializeComponent();
            db = new Lab3Context();
            //User user = new User();
            //user.Login = "test";
            //user.Datereg = DateOnly.Parse("2023-04-09");
            //db.Users.Add(user);
            //db.SaveChanges();
            //mainDGV.DataSource = db.Users.ToList();
        }
        #region
        private void ShowUsers()
        {
            mainDGV.DataSource = db.Users.ToList();
        }
        private void ShowPlaylists()
        {
            mainDGV.DataSource = db.Playlists.ToList();
        }
        private void ShowSongs()
        {
            mainDGV.DataSource = db.Songs.ToList();
        }
        private void ShowPlaylistSongs()
        {
            mainDGV.DataSource = db.Playlistsongs.ToList();
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
    }
}