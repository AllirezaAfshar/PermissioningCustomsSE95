using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MojavezSystem.Controllers
{
    public class Permission
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Organ org { get; set; }

        public bool passed;
    }
}