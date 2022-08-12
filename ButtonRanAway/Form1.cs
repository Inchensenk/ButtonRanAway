namespace ButtonRanAway
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();        
        public Form1()
        {
            InitializeComponent();
        }

        private void OnRanButtonClick(object sender, EventArgs e)
        {

        }

        private void OnCustomButtonPushMeMouseMove(object sender, MouseEventArgs e)
        {
            customButtonPushMe.Location = new Point(rnd.Next(this.ClientSize.Width - customButtonPushMe.Width), rnd.Next(this.ClientSize.Height - customButtonPushMe.Height));
            this.customButtonPushMe.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.customButtonPushMe.BackgroundColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.customButtonPushMe.BorderColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

        }

        private void OnCustomButtonPushMeClick(object sender, EventArgs e)
        {
            MessageBox.Show("ÊÐÀÑÀÓ×ÅÃ!!!)))");
        }
    }
}
