namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public Action<double>? OnCalculations { get; set; }
        private string _currentInput = string.Empty;
        private double _result, num1, num2;

        public frmCalculator()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control == null) return;

                if (control is Button btn)
                {
                    btn.Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            if (char.IsDigit(buttonText, 0))
            {
                _currentInput += buttonText;
            }
            //else if (!(char.IsDigit(buttonText, 0)) & buttonText != "=" & _currentInput== string.Empty)
            //{
            //    num1 = Convert.ToInt32(buttonText);
            //    _currentInput = num1.ToString();
            //}
            //else if (buttonText == "=")
            //{
            //    OnCalculations?.Invoke();
            //}
            else
            {
                _currentInput += " " + buttonText + " ";
            }

            txtDisplay.Text = _currentInput; // Update single textbox with expression
        }

        public void DisplayResult(double result)
        {
            _currentInput = result.ToString(); // Replace input with result
            txtDisplay.Text = _currentInput;
        }
    }
}
