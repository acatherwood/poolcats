using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmer : tDALTable
    {
        public XVar id;
        public XVar first_name;
        public XVar last_name;
        public XVar gender;
        public XVar birthdate;
        public static void Init()
        {
            XVar dalTableswimmer = XVar.Array();
            dalTableswimmer["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmer["first_name"] = new XVar("type", 200, "varname", "first_name");
            dalTableswimmer["last_name"] = new XVar("type", 200, "varname", "last_name");
            dalTableswimmer["gender"] = new XVar("type", 200, "varname", "gender");
            dalTableswimmer["birthdate"] = new XVar("type", 135, "varname", "birthdate");
	        dalTableswimmer.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmer"] = dalTableswimmer;
        }

        public  dalTable_poolcats_at_localhost_public_swimmer()
        {
            			this.m_TableName = "public.swimmer";
            this.m_infoKey = "poolcats_at_localhost_public_swimmer";
        }
    }
}