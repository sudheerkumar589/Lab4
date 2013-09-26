using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        calculator.WebService ws = new calculator.WebService();

        float num1 = (float)Convert.ToInt16(TextBox1.Text);
        float num2 = (float)Convert.ToInt16(TextBox2.Text);
        float result = ws.add(num1, num2);
        result_message.Text = "The value after Addition is : " + Convert.ToString(result);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        calculator.WebService ws = new calculator.WebService();

        float num1 = (float)Convert.ToInt16(TextBox1.Text);
        float num2 = (float)Convert.ToInt16(TextBox2.Text);
        float result = ws.sub(num1, num2);
        result_message.Text = "The value after Subtraction is : " + Convert.ToString(result);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        calculator.WebService ws = new calculator.WebService();

        float num1 = (float)Convert.ToInt16(TextBox1.Text);
        float num2 = (float)Convert.ToInt16(TextBox2.Text);
        float result = ws.multiply(num1, num2);
        result_message.Text = "The value after Multiplication is : "+ Convert.ToString(result);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        calculator.WebService ws = new calculator.WebService();

        float num1 = (float)Convert.ToInt16(TextBox1.Text);
        float num2 = (float)Convert.ToInt16(TextBox2.Text);
        float result = ws.div(num1, num2);
        result_message.Text = "The value after Division is : " + Convert.ToString(result);
    }
}