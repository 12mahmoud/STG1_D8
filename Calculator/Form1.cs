namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int num1;
        private int num2;
        private char op;




        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region numbers buttons
        private void b1_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("1");
        }



        private void b2_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("9");
        }

        private void b0_Click(object sender, EventArgs e)
        {
            res_txt.AppendText("0");
        }
        #endregion

        #region operations
        private void add_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(res_txt.Text);
            op = '+';
            res_txt.Text = "";
        }

        private void substract_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(res_txt.Text);
            op = '-';
            res_txt.Text = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(res_txt.Text);
            op = '*';
            res_txt.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(res_txt.Text);
            op = '/';
            res_txt.Text = "";
        }

        private void bce_Click(object sender, EventArgs e)
        {
            num1 = num2 = 0;
            res_txt.Text = "";
        }
        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(res_txt.Text);

            switch (op)
            {
                case '+':
                    res_txt.Text = (num1 + num2).ToString();
                    break;
                case '-':
                    res_txt.Text = (num1 - num2).ToString();
                    break;
                case '*':
                    res_txt.Text = (num1 * num2).ToString();
                    break;
                case '/':
                    res_txt.Text = (num1 / num2).ToString();
                    break;


            }
        }
        #endregion


    }
}