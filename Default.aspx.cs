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

        DAl data = new DAl();
        int count = 4;
        string sql = "SELECT TOP {0} id,title,sm,img FROM slider_news WHERE slider=1 ORDER BY id DESC";
        sql = string.Format(sql, count.ToString());
        rep_slider.DataSource = data.select(sql);
        rep_slider.DataBind();
    }
}