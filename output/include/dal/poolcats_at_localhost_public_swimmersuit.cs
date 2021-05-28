using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmersuit : tDALTable
    {
        public XVar id;
        public XVar swimmer_id;
        public XVar suit_type;
        public XVar suit_size;
        public static void Init()
        {
            XVar dalTableswimmersuit = XVar.Array();
            dalTableswimmersuit["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmersuit["swimmer_id"] = new XVar("type", 3, "varname", "swimmer_id");
            dalTableswimmersuit["suit_type"] = new XVar("type", 200, "varname", "suit_type");
            dalTableswimmersuit["suit_size"] = new XVar("type", 3, "varname", "suit_size");
	        dalTableswimmersuit.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmersuit"] = dalTableswimmersuit;
        }

        public  dalTable_poolcats_at_localhost_public_swimmersuit()
        {
            			this.m_TableName = "public.swimmersuit";
            this.m_infoKey = "poolcats_at_localhost_public_swimmersuit";
        }
    }
}