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
	public static partial class Settings_Dashboard
	{
		static public void Apply()
		{
			SettingsMap dashField = SettingsMap.GetArray(), dbelement = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), pageTitlesArray = new XVar(), query = null, queryData_Array = new XVar(), table = null, tdataArray = new XVar();
			tdataArray["Dashboard"] = SettingsMap.GetArray();
			tdataArray["Dashboard"][".ShortName"] = "Dashboard";
			GlobalVars.pages = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"dashboard\":[\"dashboard\"]}")));
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"dashboard\":\"dashboard\"}"));
			tdataArray["Dashboard"][".pages"] = GlobalVars.pages;
			tdataArray["Dashboard"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["Dashboard"] = SettingsMap.GetArray();
			pageTitlesArray["Dashboard"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["Dashboard"]["English"] = SettingsMap.GetArray();
			}
			tdataArray["Dashboard"][".searchFields"] = SettingsMap.GetArray();
			tdataArray["Dashboard"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["Dashboard"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["Dashboard"][".dashElements"] = SettingsMap.GetArray();
			tdataArray["Dashboard"][".shortTableName"] = "Dashboard";
			tdataArray["Dashboard"][".entityType"] = 4;

			GlobalVars.tableEvents["Dashboard"] = new eventsBase();
			tdataArray["Dashboard"][".hasEvents"] = false;
			tdataArray["Dashboard"][".tableType"] = "dashboard";

			tdataArray["Dashboard"][".addPageEvents"] = false;
			tdataArray["Dashboard"][".isUseAjaxSuggest"] = true;
			GlobalVars.tables_data["Dashboard"] = tdataArray["Dashboard"];
			GlobalVars.field_labels["Dashboard"] = fieldLabelsArray["Dashboard"];
			GlobalVars.page_titles["Dashboard"] = pageTitlesArray["Dashboard"];
			GlobalVars.tables_data["Dashboard"] = tdataArray["Dashboard"];
		}
	}

}
