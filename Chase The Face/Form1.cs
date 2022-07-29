namespace Chase_The_Face
{
    public partial class menuForm : Form
    {
        public int score = 0;
        public int locationX = 0;
        public int locationY = 0;
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

            if (MessageBox.Show("Start ?", "Start Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                timer1.Start();
                timer1.Tick += Timer1_Tick;
            }
            else
                exit();
        }
        private void exit()
        {
            Application.Exit();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
                forceMoveFace();
        }

        public Task moveFace()
        {
            locationX = new Random().Next(10, gamePanel.Size.Width - 50);
            locationY = new Random().Next(10, gamePanel.Size.Height - 50);
            smileFace.Location = new Point(locationX, locationY);
            return Task.CompletedTask;
        }
        public async void forceMoveFace()
        {
            await moveFace();
            score--;
            scoreText.Text = $"Score : {score}";
        }

        private async void smileFace_Click(object sender, EventArgs e)
        {
           await moveFace();
            score++;
            scoreText.Text = $"Score : {score}";
            timer1.Stop();
            timer1.Start();

        }
    }
}