using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoasp
{
    public partial class calculator : System.Web.UI.Page
    {
        int num1;
        string operation;

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
            //num1 = Convert.ToInt32(TextBox1.Text);

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            operation = "*";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            operation = "+";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            operation = "-";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            operation = "/";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Write(num1);
            int num2;
            int result;
            num2 = Convert.ToInt32(TextBox1.Text);
            if (operation == "+")
            {
                result = (num1 + num2);
                Response.Write(result);
                //TextBox1.Text = Convert.ToString(result);
                //num1 = result;
            }
            if (operation == "-")
            {
                result = (num1 - num2);
                TextBox1.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "*")
            {
                result = (num1 * num2);
                TextBox1.Text = Convert.ToString(result);
                num1 = result;
            }
            if (operation == "/")
            {
                if (num2 == 0)
                {
                    TextBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    result = (num1 / num2);
                    TextBox1.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";
            //num1 = Convert.ToInt32(TextBox1.Text);
        }
    }
}