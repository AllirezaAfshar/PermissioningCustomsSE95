using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MojavezSystem.Controllers;

namespace MojavezSystem.UI
{
    public partial class ViewPermission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String s = Request.QueryString["id"];
            int id = int.Parse(s);
            MojavezSystem.Controllers.Permission p = MemoryStatic.PermissionList.FirstOrDefault(p1 => p1.ID == id);
            lblName.Text = p.name;
            lblID.Text = id.ToString();
            lblOrg.Text = p.org.name;
            lblStatus.Text = p.passed ? "تایید شده" : "در حال بررسی";

        }

        protected void btnPass_OnClick(object sender, EventArgs e)
        {
            String s = Request.QueryString["id"];
            int id = int.Parse(s);

            foreach (Permission permission in MemoryStatic.PermissionList.Where(permission => permission.ID == id))
            {
                permission.passed = true;
            }

            foreach (Controllers.Documents documents in MemoryStatic.DocumentList)
            {
                foreach (Permission permission in documents.PermissionList)
                {
                    if (permission.ID == id)
                    {
                        permission.passed = true;
                    }
                }

            }
        }
    }
}