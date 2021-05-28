using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmerStats : tDALTable
    {
        public XVar id;
        public XVar suitSize;
        public XVar suitType;
        public static void Init()
        {
            XVar dalTableswimmerStats = XVar.Array();
            dalTableswimmerStats["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmerStats["suitSize"] = new XVar("type", 3, "varname", "suitSize");
            dalTableswimmerStats["suitType"] = new XVar("type", 200, "varname", "suitType");
	        dalTableswimmerStats.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmerStats"] = dalTableswimmerStats;
        }

        public  dalTable_poolcats_at_localhost_public_swimmerStats()
        {
            			this.m_TableName = "public.swimmerStats";
            this.m_infoKey = "poolcats_at_localhost_public_swimmerStats";
        }
    }
}