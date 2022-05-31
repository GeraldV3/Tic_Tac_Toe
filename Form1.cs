using System.Media;
namespace Tic_Tac_Toe
{
    public partial class Lobby : Form
    {
        SoundPlayer StartSound = new SoundPlayer(@"C:\Users\pc\Desktop\Tic Tac Toe\Picture and Sound\Pokemon.wav");
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
            InGame Start = new InGame();
            Start.ShowDialog();
        }
    } 
}