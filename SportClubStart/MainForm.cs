using static System.Windows.Forms.DataFormats;

namespace SportClubStart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            using var db = new ConnectDB();
            db.Database.EnsureCreated();
        }

        public void BtnAdd_Click(object sender, EventArgs e)//добавление спортсменов и тренеров
        {
            RegistrationSports RegistrationSports = new RegistrationSports();
            RegistrationSports.ShowDialog();
        }

        public void BtnOtm_Click(object sender, EventArgs e)// открытие панели для посещения
        {

            Posechenie Posechenie = new Posechenie();
            Posechenie.ShowDialog();
        }

        public void Otchet_Click(object sender, EventArgs e)// открытие панели прогульщиков
        {
            Progulchiki Progulchiki = new Progulchiki();
            Progulchiki.ShowDialog();
        }

        private void OpenCoachers_Click(object sender, EventArgs e)
        {
            AllUsers AllUsers = new AllUsers();
            AllUsers.ShowDialog();
        }
    }
}
//BtnAdd - добавить кого нибудь