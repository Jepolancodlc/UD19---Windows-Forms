using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculadora
{
    public partial class Form1 : Form
    {
        double resValue = 0;
        string opPerformed = "";
        bool isOpPerf = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOpPerf)
            {
                textBox1.Clear();
            }
            isOpPerf = false;
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text += button.Text;
                }
            }
  
                textBox1.Text +=  button.Text;
            
        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resValue != 0)
            {
                opPerformed = button.Text;
                historial.Text = resValue + " " + opPerformed;
                isOpPerf = true;
            }
            else
            {
              
                opPerformed = button.Text;
                resValue = double.Parse(textBox1.Text);
                historial.Text = resValue + " " + opPerformed;
                isOpPerf = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resValue = 0;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (opPerformed)
            {
                case "+": textBox1.Text = (resValue+ Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-": textBox1.Text = (resValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*": textBox1.Text = (resValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/": textBox1.Text = (resValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default: 
                    break;
            }
            resValue = double.Parse(textBox1.Text);
            historial.Text = "";
        }

       
    }
}
