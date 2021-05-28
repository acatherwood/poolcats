using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_poolcats_at_localhost_public_swimmerpayment : tDALTable
    {
        public XVar id;
        public XVar swimmer_id;
        public XVar payment_type;
        public XVar amount_paid;
        public XVar practice_time;
        public XVar early_registration;
        public static void Init()
        {
            XVar dalTableswimmerpayment = XVar.Array();
            dalTableswimmerpayment["id"] = new XVar("type", 3, "varname", "id");
            dalTableswimmerpayment["swimmer_id"] = new XVar("type", 3, "varname", "swimmer_id");
            dalTableswimmerpayment["payment_type"] = new XVar("type", 200, "varname", "payment_type");
            dalTableswimmerpayment["amount_paid"] = new XVar("type", 200, "varname", "amount_paid");
            dalTableswimmerpayment["practice_time"] = new XVar("type", 200, "varname", "practice_time");
            dalTableswimmerpayment["early_registration"] = new XVar("type", 11, "varname", "early_registration");
	        dalTableswimmerpayment.InitAndSetArrayItem(true, "id", "key");
            GlobalVars.dal_info["poolcats_at_localhost_public_swimmerpayment"] = dalTableswimmerpayment;
        }

        public  dalTable_poolcats_at_localhost_public_swimmerpayment()
        {
            			this.m_TableName = "public.swimmerpayment";
            this.m_infoKey = "poolcats_at_localhost_public_swimmerpayment";
        }
    }
}