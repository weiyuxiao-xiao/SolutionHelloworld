using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectHelloworld
{
    public partial class homeOutput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "这是我的第二个动态网页";
            Response.Write("<script language='javascript'>alert('欢迎学习《数据思维下的算法与程序设计》课程')</script>");
        }
    }
}