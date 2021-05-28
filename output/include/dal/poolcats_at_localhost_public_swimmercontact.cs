using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmercontact : tDALTable
    {
        public XVar id;
        public XVar swimmer_id;
        public XVar parent_name;
        public XVar address;
        public XVar city;
        public XVar state;
        public XVar zip_code;
        public XVar phone;
        public XVar email;
        public XVar emergency_contact;
        public static void Init()
        {
            XVar dalTableswimmercontact = XVar.Array();
            dalTableswimmercontact["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmercontact["swimmer_id"] = new XVar("type", 3, "varname", "swimmer_id");
            dalTableswimmercontact["parent_name"] = new XVar("type", 200, "varname", "parent_name");
            dalTableswimmercontact["address"] = new XVar("type", 200, "varname", "address");
            dalTableswimmercontact["city"] = new XVar("type", 200, "varname", "city");
            dalTableswimmercontact["state"] = new XVar("type", 200, "varname", "state");
            dalTableswimmercontact["zip_code"] = new XVar("type", 3, "varname", "zip_code");
            dalTableswimmercontact["phone"] = new XVar("type", 200, "varname", "phone");
            dalTableswimmercontact["email"] = new XVar("type", 200, "varname", "email");
            dalTableswimmercontact["emergency_contact"] = new XVar("type", 200, "varname", "emergency_contact");
	        dalTableswimmercontact.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmercontact"] = dalTableswimmercontact;
        }

        public  dalTable_poolcats_at_localhost_public_swimmercontact()
        {
            			this.m_TableName = "public.swimmercontact";
            this.m_infoKey = "poolcats_at_localhost_public_swimmercontact";
        }
    }
}