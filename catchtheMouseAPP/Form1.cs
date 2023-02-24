namespace catchtheMouseAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTikla_MouseClick(object sender, MouseEventArgs e)
        {
            Random sayi1 = new Random();

            btnTikla.BackColor = Color.FromArgb(sayi1.Next(0, 255), sayi1.Next(0, 255), sayi1.Next(0, 255));
            this.BackColor = Color.FromArgb(sayi1.Next(0, 255), sayi1.Next(0, 255), sayi1.Next(0, 255));              
            btnTikla.Left = rnd.Next((this.Width - btnTikla.Width));
            btnTikla.Top = rnd.Next((this.Height - btnTikla.Height));

        }
    }
}