using System.Media;
using System.Windows.Forms;
namespace Tic_Tac_Toe
{
    public partial class Lobby : Form
    {
        int counterX = 0;
        int counterO = 0;
        SoundPlayer StartSound = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\Pokemon.wav");
        SoundPlayer LobbyTheme = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\LobbyMusic.wav");
        SoundPlayer ScoreButton = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\Score_Sound.wav");
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
            StartSound.Play();
            Hide();
            InGame Start = new InGame();
            Start.ShowDialog();
            Show();
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

        private void X_Score_Click(object sender, EventArgs e)
        {
            ScoreButton.Play();
            counterX++;
            P1_Score.Text = counterX.ToString();
        }

        private void Score_O_Click(object sender, EventArgs e)
        {
            ScoreButton.Play();
            counterO++;
            P2_Score.Text = counterO.ToString();
        }
    } 
}