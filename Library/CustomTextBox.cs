using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    [ToolboxBitmap(@"C:\Users\vitalii\Downloads\CustomTextBox.ico")]
    public partial class CustomTextBox : TextBox
    {
        private float minValue = float.MinValue;
        private float maxValue = float.MaxValue;

        public float MinValue
        {
            get { return minValue; }
            set { minValue = value; }
        }

        public float MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; }
        }

        public EventHandler InvalidValue;

        public CustomTextBox()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            this.TextChanged += CustomTextBox_TextChanged;
        }

        private void CustomTextBox_TextChanged(object sender, EventArgs e)
        {
            float value;
            var isIncorrectValue = !float.TryParse(this.Text, out value);

            if(isIncorrectValue)
            {
                var eventArgs = new ValueErrorEventArgs(ValueError.INCORRECT_VALUE);
                InvalidValue?.Invoke(this, eventArgs);
                this.BackColor = Color.Red;
            }
            else if (value < minValue) 
            {
                var eventArgs = new ValueErrorEventArgs(ValueError.EXCEED_LOWER_LIMIT);
                InvalidValue?.Invoke(this, eventArgs);
                this.BackColor = Color.Red;
            }
            else if(value > maxValue)
            {
                var eventArgs = new ValueErrorEventArgs(ValueError.EXCEED_UPPER_LIMIT);
                InvalidValue?.Invoke(this, eventArgs);
                this.BackColor = Color.Red;
            }
            else this.BackColor = Color.White;
        }
    }
}

public class ValueErrorEventArgs : EventArgs
{
    public ValueError ValueError { get; private set; }

    public ValueErrorEventArgs(ValueError valueError)
    {
        ValueError = valueError;
    }
}

public enum ValueError
{
    EXCEED_UPPER_LIMIT,
    EXCEED_LOWER_LIMIT,
    INCORRECT_VALUE
}