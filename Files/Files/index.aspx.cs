using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Files
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var dir = new DirectoryInfo(Server.MapPath("~/content"));
                var data = dir.GetFiles().Select(P => new { P.Name }).ToList();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }
    }
}