using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MojavezSystem.Controllers;

namespace MojavezSystem.UI
{
    public partial class Documents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MemoryStatic.AddDoc(new Controllers.Documents(User.Identity, 0, "num1"+DateTime.Now.Ticks));
            List<Controllers.Documents> docs = MemoryStatic.DocumentList.Where(document => document.user.Name == User.Identity.Name).ToList();


            foreach (Controllers.Documents doc in docs)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                ulDocument.Controls.Add(li);

                HtmlGenericControl anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "/UI/ViewDocument.aspx?id="+doc.ID);
                anchor.InnerText = doc.ID.ToString()+ " "+doc.Name;

                li.Controls.Add(anchor);
            }

        }

        protected void OnClick(object sender, EventArgs e)
        {
            pnl.Visible = true;
        }

        protected void OnClickSubmit(object sender, EventArgs e)
        {
            MemoryStatic.AddDoc(new Controllers.Documents(User.Identity, 0,Doctxt.Text+ DateTime.Now.Ticks));
            pnl.Visible = false;
        }
    }
}