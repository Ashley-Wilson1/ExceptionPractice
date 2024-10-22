namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void doSomething()
        {
            int num1, num2, result;
            try
            {
                num1 = Int32.Parse(textBox1.Text);
                              
            }
            catch (FormatException ex) 
            {
                textBox1.Text = "Format Error";
                return;
            }
            try
            {
  
                num2 = Int32.Parse(textBox2.Text);

            }
            catch (FormatException ex)
            {
                textBox2.Text = "Format Error";
                return;
            }
            try
            {
                result = num1 / num2;
            }
            catch(System.DivideByZeroException ex)
            {
                textBox1.Text = "Divide by zero error";
                return ;
            }

            textBox1.Text = "Result = "+result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doSomething();
        }
    }
}
