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
            
            


        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Top = button1.Top - 50;
            button2.Top = button2.Top + 50;
            button3.Left = button3.Left - 50;
            button4.Left = button4.Left + 50;
            button1.BackColor = Color.Aqua;
            button2.BackColor = Color.DarkViolet;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Green;
            button5.Visible = false;
            button6.Visible = true;
            button1.Text = "Ç»Ç∫âüÇµÇΩÅ`";
            button2.Text = "Ç»Ç∫âüÇµÇΩÅ`";
            button3.Text = "Ç»Ç∫âüÇµÇΩÅ`";
            button4.Text = "Ç»Ç∫âüÇµÇΩÅ`";
            

        }
    }
}