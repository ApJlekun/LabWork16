namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += DigitButton_Click;
                }
            }
            clearButton.Click += clearButton_Click;
        }

        private void DigitButton_Click(object? sender, EventArgs e)
        {
            Button digitButton = (Button)sender;
            inputField.Text += digitButton.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputField.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
