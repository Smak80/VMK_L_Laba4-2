namespace VMK_L_Laba4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ball? b = null;
        private Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (b == null)
            {
                b = new Ball();
                b.ForeColor = Color.FromArgb(
                    random.Next(255),
                    random.Next(255),
                    random.Next(255)
                );
                b.Size = new Size(100, 100);
                b.Font = new Font("Cambria", 16, FontStyle.Bold);
                b.Location = new (
                    random.Next(panel1.Width - b.Width),
                    random.Next(panel1.Height - b.Height)
                    );
                panel1.Controls.Add(b);
            }
        }

    }
}