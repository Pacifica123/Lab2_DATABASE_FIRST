namespace Lab2_DATABASE_FIRST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lab3Context db = new Lab3Context();
            dataGridView1.DataSource = db.Users.ToList();
        }
    }
}