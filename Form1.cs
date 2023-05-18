namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button.Left=0;
            button1.Left = button1.Left - 10;
            button1.Top = button1.Top - 10;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Top = button1.Top - 30;
            button2.Top = button2.Top + 30;
            button3.Left = button3.Left - 30;
            button4.Left = button4.Left + 30;
            button1.BackColor = Color.Aqua;
            button2.BackColor = Color.DarkViolet;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Green;
            button5.Visible = false;
            button6.Visible = true;
        }
    }
}