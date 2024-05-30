using Library;

namespace L1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customTextBox1.InvalidValue += CustomTextBox1_InvalidValue;
        }

        private void CustomTextBox1_InvalidValue(object? sender, EventArgs e)
        {

            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox1_InvalidValue(object sender, EventArgs e)
        {
            if (sender is CustomTextBox)
            {
                var valueError = ((ValueErrorEventArgs)e).ValueError;
                label1.Text = valueError.ToString();
            }
        }
    }
}
