using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tierstudy
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = objbll.InsertDB(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, TextBox4.Text, TextBox5.Text);
            if(i!=0)
            {
                Label1.Text = "inserted";
            }
        

        }
        }
    }
