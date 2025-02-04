using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String wakarimasen = "わかりません。";

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1+1")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = wakarimasen;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form2 error = new Form2();
            error.Left = Location.X + 40;
            error.Top = Location.Y + 40;
            error.StartPosition = FormStartPosition.Manual;
            error.label1.Text = "この機能はまだ実装\nされていません。";
            error.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length >= 9)
            {
                Form2 error = new Form2();
                error.Left = Location.X + 40;
                error.Top = Location.Y + 40;
                error.StartPosition = FormStartPosition.Manual;
                error.ShowDialog();
            }
            else if (label1.Text == wakarimasen)
            {
                Form2 error = new Form2();
                error.label1.Text = "先にAll Clearしてください。";
                error.Left = Location.X + 40;
                error.Top = Location.Y + 40;
                error.StartPosition = FormStartPosition.Manual;
                error.ShowDialog();
            }else 
            {
                var clickedLabel = (Button)sender;
                label1.Text += clickedLabel.Text;
            }
        }
    }
}
