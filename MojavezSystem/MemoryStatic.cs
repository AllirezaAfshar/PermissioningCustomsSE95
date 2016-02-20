using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Provider;
using MojavezSystem.Controllers;

namespace MojavezSystem
{
    
    public static class MemoryStatic
    {
        public static int docID = 1;
        public static int permID = 1;
        public static int orgID = 1;

        public static List<Organ> OrgsList = new List<Organ>(); 
        public static List<Permission> PermissionList = new List<Permission>();
        public static List<Documents> DocumentList = new List<Documents>();
        
        public static void AddOrgan(Organ o)
        {
            o.ID = orgID;
            if(!OrgsList.Contains(o))  OrgsList.Add(o);
            orgID++;

        }
        public static void AddPerm(Permission p)
        {
            p.ID = permID;
            p.passed = false;
            if(!PermissionList.Contains(p))  PermissionList.Add(p);
            permID++;

        }
        public static void AddDoc(Documents d)
        {
            d.ID = docID;
            if(!DocumentList.Contains(d))  DocumentList.Add(d);
            docID++;

        }



    }
}