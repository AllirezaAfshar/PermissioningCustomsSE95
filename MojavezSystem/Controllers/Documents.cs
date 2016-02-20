using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Providers.Entities;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using MojavezSystem.Models;

namespace MojavezSystem.Controllers
{
    public class Documents
    {
        public IIdentity user { get; set; }
        public List<Permission> PermissionList { get; set; }
        public int ID;
        public string Name { get; set; }

        public Documents(IIdentity u, int ID, string Name)
        {
            user = u;
            PermissionList = new List<Permission>();
            this.ID = ID;
            this.Name = Name;
        }
    }
}