using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
namespace runnerDotNet
{
	public static partial class Swimmers_without_Suits_Report_Variables
	{
		public static void Apply()
		{
			GlobalVars.strTableName = new XVar("Swimmers without Suits Report");
			XSession.Session["OwnerID"] = XSession.Session[MVCFunctions.Concat("_", GlobalVars.strTableName, "_OwnerID")];
			GlobalVars.strOriginalTableName = new XVar("public.swimmers");
			GlobalVars.gstrOrderBy = new XVar("ORDER BY swimmer");
			if((XVar)(MVCFunctions.strlen((XVar)(GlobalVars.gstrOrderBy)))  && (XVar)(MVCFunctions.strtolower((XVar)(MVCFunctions.substr((XVar)(GlobalVars.gstrOrderBy), new XVar(0), new XVar(8)))) != "order by"))
			{
				GlobalVars.gstrOrderBy = XVar.Clone(MVCFunctions.Concat("order by ", GlobalVars.gstrOrderBy));
			}
			GlobalVars.gSettings = XVar.Clone(new ProjectSettings(new XVar("Swimmers without Suits Report")));
			GlobalVars.gQuery = XVar.Clone(GlobalVars.gSettings.getSQLQuery());
			GlobalVars.eventObj = GlobalVars.tableEvents["Swimmers without Suits Report"];
			GlobalVars.reportCaseSensitiveGroupFields = new XVar(false);
			GlobalVars.gstrSQL = XVar.Clone(GlobalVars.gQuery.gSQLWhere(new XVar("")));
		}
	}

}
