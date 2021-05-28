using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmers : tDALTable
    {
        public XVar id;
        public XVar first_name;
        public XVar last_name;
        public XVar birthdate;
        public static void Init()
        {
            XVar dalTableswimmers = XVar.Array();
            dalTableswimmers["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmers["first_name"] = new XVar("type", 200, "varname", "first_name");
            dalTableswimmers["last_name"] = new XVar("type", 200, "varname", "last_name");
            dalTableswimmers["birthdate"] = new XVar("type", 135, "varname", "birthdate");
	        dalTableswimmers.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmers"] = dalTableswimmers;
        }

        public  dalTable_poolcats_at_localhost_public_swimmers()
        {
            			this.m_TableName = "public.swimmers";
            this.m_infoKey = "poolcats_at_localhost_public_swimmers";
        }
    }
}