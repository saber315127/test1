using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class caculator : System.Web.UI.Page
{
    public class Global

    {
        public static string text = "";
        public static double total;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Global.text += 1;
        TextBox1.Text = Global.text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Global.text += 2;
        TextBox1.Text = Global.text;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Global.text += "3";
        TextBox1.Text = Global.text;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Global.text += "4";
        TextBox1.Text = Global.text;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Global.text += "5";
        TextBox1.Text = Global.text;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Global.text += "6";
        TextBox1.Text = Global.text;
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Global.text += "7";
        TextBox1.Text = Global.text;
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Global.text += "8";
        TextBox1.Text = Global.text;
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Global.text += "9";
        TextBox1.Text = Global.text;
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Global.text += "0";
        TextBox1.Text = Global.text;
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Global.text += "+";
        TextBox1.Text = Global.text;
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Global.text += "-";
        TextBox1.Text = Global.text;
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        Global.text += "*";
        TextBox1.Text = Global.text;
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        Global.text += "/";
        TextBox1.Text = Global.text;
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        TextBox1.Text = Convert.ToString("0");
        Global.text = "";
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        TextBox1.Text = Convert.ToString(Global.text);
        Global.text = "";
    }
}