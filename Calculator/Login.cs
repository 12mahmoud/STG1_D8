using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "Mahmoud" & txt_pass.Text == "2002")
            {
                
                Form1 calc = new Form1();
                this.Hide();
                calc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, wrong username or password.");
            }
        }
    }
}
