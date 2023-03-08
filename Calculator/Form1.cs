namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxOutput.Text == "0") || (isOperationPerformed))
                textBoxOutput.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxOutput.Text.Contains("."))
                    textBoxOutput.Text=textBoxOutput.Text + button.Text;
            }
            else
                textBoxOutput.Text=textBoxOutput.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            else
            {


                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxOutput.Text);
                isOperationPerformed = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxOutput.Text = (resultValue + Double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "-":
                    textBoxOutput.Text = (resultValue - Double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "*":
                    textBoxOutput.Text = (resultValue * Double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "/":
                    textBoxOutput.Text = (resultValue / Double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "exp":
                    double i = double.Parse(textBoxOutput.Text);
                    double q;
                    q = (resultValue);
                    textBoxOutput.Text = Math.Pow(q, i).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBoxOutput.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Width = 527;
                this.Height = 427;
                textBoxOutput.Width = 422;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.Width = 527;
                this.Height = 533;
                textBoxOutput.Width = 422;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(textBoxOutput.Text);
            resultValue = resultValue * -1;
            textBoxOutput.Text = resultValue.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.BackColor = Color.DarkGray;
                this.ForeColor = Color.DarkGray;
                tabPage1.ForeColor = Color.DarkGray;
                tabPage1.BackColor = Color.DarkGray;
            }
            else
            {
                this.BackColor = DefaultBackColor;
                this.ForeColor = DefaultForeColor;
                tabPage1.ForeColor = DefaultForeColor;
                tabPage1.BackColor = DefaultBackColor;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1_CheckedChanged(sender, new EventArgs());
                this.Width = 524;
                this.Height = 427;
                textBoxOutput.Width = 422;
            }
            else if (radioButton2.Checked)
            {
                radioButton2_CheckedChanged(sender, new EventArgs());
                this.Width = 524;
                this.Height = 533;
                textBoxOutput.Width = 422;
            }
        }

        private void button3_click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBoxOutput.Text));
            textBoxOutput.Text = System.Convert.ToString(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "3.141592653589793";
        }

        private void button18_click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBoxOutput.Text);
            ilog = Math.Log10(ilog);
            textBoxOutput.Text = System.Convert.ToString(ilog);
        }

        private void button19_click(object sender, EventArgs e)
        {
            double sin = Math.PI * Double.Parse(textBoxOutput.Text) /180;
            sin = Math.Sin(sin);
            textBoxOutput.Text = System.Convert.ToString(sin);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(textBoxOutput.Text);
            sq = Math.Sqrt(sq);
            textBoxOutput.Text=System.Convert.ToString(sq);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU FOR VIEWING MY CALCULATOR!");
        }
    }
}