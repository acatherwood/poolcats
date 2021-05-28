using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmerpayments : tDALTable
    {
        public XVar id;
        public XVar swimmer_id;
        public XVar payment_type;
        public XVar amount_paid;
        public XVar practice_time;
        public XVar early_registration;
        public static void Init()
        {
            XVar dalTableswimmerpayments = XVar.Array();
            dalTableswimmerpayments["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmerpayments["swimmer_id"] = new XVar("type", 3, "varname", "swimmer_id");
            dalTableswimmerpayments["payment_type"] = new XVar("type", 200, "varname", "payment_type");
            dalTableswimmerpayments["amount_paid"] = new XVar("type", 200, "varname", "amount_paid");
            dalTableswimmerpayments["practice_time"] = new XVar("type", 200, "varname", "practice_time");
            dalTableswimmerpayments["early_registration"] = new XVar("type", 11, "varname", "early_registration");
	        dalTableswimmerpayments.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmerpayments"] = dalTableswimmerpayments;
        }

        public  dalTable_poolcats_at_localhost_public_swimmerpayments()
        {
            			this.m_TableName = "public.swimmerpayments";
            this.m_infoKey = "poolcats_at_localhost_public_swimmerpayments";
        }
    }
}