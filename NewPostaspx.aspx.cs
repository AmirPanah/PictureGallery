using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewPostaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        
         DAl data = new DAl();
            int slider=0;
            string path = "";
            if (uploader.HasFile)
            {
                Random rnd = new Random();
                string prename = rnd.Next(10000,9999999).ToString();
                string filename = uploader.PostedFile.FileName;
                path = "uploads/slider/" +prename+filename;
                uploader.SaveAs( Server.MapPath(path));
                slider =1;
            }
            string sql = "INSERT INTO slider_news(title,sm,body,slider,img) VALUES('{0}','{1}','{2}','{3}','{4}')";
            sql = string.Format(sql,txttitle.Text.Trim(),txtsm.Text.Trim(),txtbody.Text.Trim(),slider,path);
            data.connect();
            data.docommand(sql);
            data.disconnect();
            
        }
   
}