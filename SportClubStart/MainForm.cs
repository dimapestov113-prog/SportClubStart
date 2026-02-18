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

        public void BtnAdd_Click(object sender, EventArgs e)
        {
            RegistrationSports RegistrationSports = new RegistrationSports();
            RegistrationSports.ShowDialog();
        }

        public void BtnOtm_Click(object sender, EventArgs e)
        {

            Posechenie Posechenie = new Posechenie();
            Posechenie.ShowDialog();
        }

        public void Otchet_Click(object sender, EventArgs e)
        {
            Progulchiki Progulchiki = new Progulchiki();
            Progulchiki.ShowDialog();
        }
    }
}
//BtnAdd - добавить кого нибудь