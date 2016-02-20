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
    public partial class ViewDocument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String s = Request.QueryString["id"];
            int id = int.Parse(s);
            MojavezSystem.Controllers.Documents doc = MemoryStatic.DocumentList.FirstOrDefault(d => d.ID == id);
            lblID.Text = doc.ID.ToString();
            lblName.Text = doc.Name;
            lblOwner.Text = doc.user.Name;
            doc.PermissionList.ForEach(p=> lblPermissions.Text += p.name);


            foreach (Controllers.Permission p in doc.PermissionList)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                permissionUl.Controls.Add(li);

                HtmlGenericControl anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "/UI/ViewPermission.aspx?id=" + p.ID);
                anchor.InnerText = p.name+"   "+p.ID+" "+ " "+ (p.passed?"تایید شده":"در حال بررسی");

                li.Controls.Add(anchor);
            }
        }

        protected void btnAddPermission_OnClick(object sender, EventArgs e)
        {
            PermissionPanels.Visible = true;
        }

        protected void SubmitPermission_OnClick(object sender, EventArgs e)
        {
            String s = Request.QueryString["id"];
            int id = int.Parse(s);
            MemoryStatic.DocumentList.FirstOrDefault(d => d.ID == id).PermissionList.Add(new Permission
            {
                ID = (int)(DateTime.Now.Ticks%1000),
                name = txtName.Text,
                org =  new Organ
                {
                    ID = (int)(DateTime.Now.Ticks % 985) ,
                    name = txtOrgan.Text
                }
            });

            MemoryStatic.PermissionList.Add(new Permission
            {
                ID = (int)(DateTime.Now.Ticks % 1000),
                name = txtName.Text,
                org = new Organ
                {
                    ID = (int)(DateTime.Now.Ticks % 985),
                    name = txtOrgan.Text
                }
            }); 

        }
    }
}