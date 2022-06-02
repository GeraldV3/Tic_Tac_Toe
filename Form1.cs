using System.Media;
namespace Tic_Tac_Toe
{
    public partial class Lobby : Form
    {
        SoundPlayer StartSound = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\Pokemon.wav");
        SoundPlayer LobbyTheme = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\LobbyMusic.wav");
        public Lobby()
        {
            InitializeComponent();
        }
        private void Start_btn_MouseHover(object sender, EventArgs e)
        {
            Start_btn.Image = Properties.Resources.Start1;
        }
        private void Start_btn_MouseLeave(object sender, EventArgs e)
        {
            Start_btn.Image = Properties.Resources.Start;
        }
        private void Start_btn_Click(object sender, EventArgs e)
        {
            Task.Delay(10000);
            StartSound.Play();
            this.Hide();
            InGame Start = new InGame();
            Start.ShowDialog();
            this.Show();
            LobbyTheme.Play();
        }
        private void Quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Quit_btn_MouseHover(object sender, EventArgs e)
        {
            Quit_btn.Image = Properties.Resources.Quit1;
        }
        private void Quit_btn_MouseLeave(object sender, EventArgs e)
        {
            Quit_btn.Image = Properties.Resources.Quit;
        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            LobbyTheme.Play();
        }
    } 
}