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
	public static partial class Settings_Not_Paid_Report
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".truncateText"] = true;
			tdataArray["Not_Paid_Report"][".NumberOfChars"] = 80;
			tdataArray["Not_Paid_Report"][".ShortName"] = "Not_Paid_Report";
			tdataArray["Not_Paid_Report"][".OwnerID"] = "";
			tdataArray["Not_Paid_Report"][".OriginalTable"] = "public.swimmerpayments";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"report\":\"report\",\"rprint\":\"rprint\",\"search\":\"search\"}"));
			tdataArray["Not_Paid_Report"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}")));
			tdataArray["Not_Paid_Report"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["Not_Paid_Report"] = SettingsMap.GetArray();
			fieldToolTipsArray["Not_Paid_Report"] = SettingsMap.GetArray();
			pageTitlesArray["Not_Paid_Report"] = SettingsMap.GetArray();
			placeHoldersArray["Not_Paid_Report"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["Not_Paid_Report"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["Not_Paid_Report"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["Not_Paid_Report"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["Not_Paid_Report"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["Not_Paid_Report"]["English"]["swimmer"] = "Swimmer";
				fieldToolTipsArray["Not_Paid_Report"]["English"]["swimmer"] = "";
				placeHoldersArray["Not_Paid_Report"]["English"]["swimmer"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["Not_Paid_Report"]["English"])))
				{
					tdataArray["Not_Paid_Report"][".isUseToolTips"] = true;
				}
			}
			tdataArray["Not_Paid_Report"][".NCSearch"] = true;
			tdataArray["Not_Paid_Report"][".shortTableName"] = "Not_Paid_Report";
			tdataArray["Not_Paid_Report"][".nSecOptions"] = 0;
			tdataArray["Not_Paid_Report"][".mainTableOwnerID"] = "";
			tdataArray["Not_Paid_Report"][".entityType"] = 2;
			tdataArray["Not_Paid_Report"][".strOriginalTableName"] = "public.swimmerpayments";
			tdataArray["Not_Paid_Report"][".showAddInPopup"] = false;
			tdataArray["Not_Paid_Report"][".showEditInPopup"] = false;
			tdataArray["Not_Paid_Report"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["Not_Paid_Report"][".listAjax"] = false;
			tdataArray["Not_Paid_Report"][".listAjax"] = false;
			tdataArray["Not_Paid_Report"][".audit"] = false;
			tdataArray["Not_Paid_Report"][".locking"] = false;
			GlobalVars.pages = tdataArray["Not_Paid_Report"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["Not_Paid_Report"][".edit"] = true;
				tdataArray["Not_Paid_Report"][".afterEditAction"] = 1;
				tdataArray["Not_Paid_Report"][".closePopupAfterEdit"] = 1;
				tdataArray["Not_Paid_Report"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["Not_Paid_Report"][".add"] = true;
				tdataArray["Not_Paid_Report"][".afterAddAction"] = 1;
				tdataArray["Not_Paid_Report"][".closePopupAfterAdd"] = 1;
				tdataArray["Not_Paid_Report"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["Not_Paid_Report"][".list"] = true;
			}
			tdataArray["Not_Paid_Report"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["Not_Paid_Report"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["Not_Paid_Report"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["Not_Paid_Report"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["Not_Paid_Report"][".printFriendly"] = true;
			}
			tdataArray["Not_Paid_Report"][".showSimpleSearchOptions"] = true;
			tdataArray["Not_Paid_Report"][".allowShowHideFields"] = true;
			tdataArray["Not_Paid_Report"][".allowFieldsReordering"] = true;
			tdataArray["Not_Paid_Report"][".isUseAjaxSuggest"] = true;


			tdataArray["Not_Paid_Report"][".flexibleSearch"] = true;
			tdataArray["Not_Paid_Report"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["Not_Paid_Report"][".buttonsAdded"] = false;
			tdataArray["Not_Paid_Report"][".addPageEvents"] = false;
			tdataArray["Not_Paid_Report"][".isUseTimeForSearch"] = false;
			tdataArray["Not_Paid_Report"][".badgeColor"] = "2F4F4F";
			tdataArray["Not_Paid_Report"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".googleLikeFields"].Add("swimmer");
			tdataArray["Not_Paid_Report"][".tableType"] = "report";
			tdataArray["Not_Paid_Report"][".printerPageOrientation"] = 0;
			tdataArray["Not_Paid_Report"][".nPrinterPageScale"] = 100;
			tdataArray["Not_Paid_Report"][".nPrinterSplitRecords"] = 40;
			tdataArray["Not_Paid_Report"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["Not_Paid_Report"][".geocodingEnabled"] = false;
			tdataArray["Not_Paid_Report"][".printReportLayout"] = 2;
			tdataArray["Not_Paid_Report"][".reportPrintPartitionType"] = 1;
			tdataArray["Not_Paid_Report"][".reportPrintGroupsPerPage"] = 3;
			tdataArray["Not_Paid_Report"][".reportPrintPDFGroupsPerPage"] = 3;
			tdataArray["Not_Paid_Report"][".lowGroup"] = 1;
			tdataArray["Not_Paid_Report"][".reportGroupFields"] = true;
			tdataArray["Not_Paid_Report"][".pageSize"] = 5;
			reportGroupFields = SettingsMap.GetArray();
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "swimmer";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 1;
			rgroupField["showGroupSummary"] = "1";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			tdataArray["Not_Paid_Report"][".reportGroupFieldsData"] = reportGroupFields;
			tdataArray["Not_Paid_Report"][".reportLayout"] = 2;
			tstrOrderBy = "ORDER BY swimmer";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["Not_Paid_Report"][".strOrderBy"] = tstrOrderBy;
			tdataArray["Not_Paid_Report"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".orderindexes"].Add(new XVar(0, 1, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name)"));
			tdataArray["Not_Paid_Report"][".sqlHead"] = "SELECT CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name) AS swimmer";
			tdataArray["Not_Paid_Report"][".sqlFrom"] = "FROM \"public\".swimmerpayment  INNER JOIN \"public\".swimmer ON \"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
			tdataArray["Not_Paid_Report"][".sqlWhereExpr"] = "\"public\".swimmerpayment.payment_type is null";
			tdataArray["Not_Paid_Report"][".sqlTail"] = "";
			arrGridTabs = SettingsMap.GetArray();
			arrGridTabs.Add(new XVar("tabId", "", "name", "All data", "nameType", "Text", "where", "", "showRowCount", 0, "hideEmpty", 0));
			tdataArray["Not_Paid_Report"][".arrGridTabs"] = arrGridTabs;
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["Not_Paid_Report"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["Not_Paid_Report"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["Not_Paid_Report"][".highlightSearchResults"] = true;
			tableKeysArray["Not_Paid_Report"] = SettingsMap.GetArray();
			tdataArray["Not_Paid_Report"][".Keys"] = tableKeysArray["Not_Paid_Report"];
			tdataArray["Not_Paid_Report"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "swimmer";
			fdata["GoodName"] = "swimmer";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Not_Paid_Report","swimmer");
			fdata["FieldType"] = 201;
			fdata["strField"] = "swimmer";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name)";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["report"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text area");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["nRows"] = 100;
			edata["nCols"] = 200;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["search"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["Not_Paid_Report"]["swimmer"] = fdata;
			tdataArray["Not_Paid_Report"][".searchableFields"].Add("swimmer");
			GlobalVars.tables_data["Not Paid Report"] = tdataArray["Not_Paid_Report"];
			GlobalVars.field_labels["Not_Paid_Report"] = fieldLabelsArray["Not_Paid_Report"];
			GlobalVars.fieldToolTips["Not_Paid_Report"] = fieldToolTipsArray["Not_Paid_Report"];
			GlobalVars.placeHolders["Not_Paid_Report"] = placeHoldersArray["Not_Paid_Report"];
			GlobalVars.page_titles["Not_Paid_Report"] = pageTitlesArray["Not_Paid_Report"];
			GlobalVars.detailsTablesData["Not Paid Report"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Not Paid Report"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name) AS swimmer";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmerpayment  INNER JOIN \"public\".swimmer ON \"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
protoArray["0"]["m_strWhere"] = "\"public\".swimmerpayment.payment_type is null";
protoArray["0"]["m_strOrderBy"] = "ORDER BY swimmer";
	
		
protoArray["0"]["cipherer"] = null;
protoArray["2"] = SettingsMap.GetArray();
protoArray["2"]["m_sql"] = "\"public\".swimmerpayment.payment_type is null";
protoArray["2"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "payment_type", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Not Paid Report"));

protoArray["2"]["m_column"] = obj;
protoArray["2"]["m_contained"] = SettingsMap.GetArray();
protoArray["2"]["m_strCase"] = "is null";
protoArray["2"]["m_havingmode"] = false;
protoArray["2"]["m_inBrackets"] = false;
protoArray["2"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["2"]);

protoArray["0"]["m_where"] = obj;
protoArray["4"] = SettingsMap.GetArray();
protoArray["4"]["m_sql"] = "";
protoArray["4"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["4"]["m_column"] = obj;
protoArray["4"]["m_contained"] = SettingsMap.GetArray();
protoArray["4"]["m_strCase"] = "";
protoArray["4"]["m_havingmode"] = false;
protoArray["4"]["m_inBrackets"] = false;
protoArray["4"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["4"]);

protoArray["0"]["m_having"] = obj;
protoArray["0"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["6"] = SettingsMap.GetArray();
protoArray["7"] = SettingsMap.GetArray();
protoArray["7"]["m_functiontype"] = "SQLF_CUSTOM";
protoArray["7"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "\"public\".swimmer.first_name"));

protoArray["7"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "' '"));

protoArray["7"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "\"public\".swimmer.last_name"));

protoArray["7"]["m_arguments"].Add(obj);
protoArray["7"]["m_strFunctionName"] = "CONCAT";
obj = new SQLFunctionCall(protoArray["7"]);

protoArray["6"]["m_sql"] = "CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name)";
protoArray["6"]["m_srcTableName"] = "Not Paid Report";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "swimmer";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_link"] = "SQLL_MAIN";
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_strName"] = "public.swimmerpayment";
protoArray["12"]["m_srcTableName"] = "Not Paid Report";
protoArray["12"]["m_columns"] = SettingsMap.GetArray();
protoArray["12"]["m_columns"].Add("id");
protoArray["12"]["m_columns"].Add("swimmer_id");
protoArray["12"]["m_columns"].Add("payment_type");
protoArray["12"]["m_columns"].Add("amount_paid");
protoArray["12"]["m_columns"].Add("practice_time");
protoArray["12"]["m_columns"].Add("early_registration");
obj = new SQLTable(protoArray["12"]);

protoArray["11"]["m_table"] = obj;
protoArray["11"]["m_sql"] = "\"public\".swimmerpayment";
protoArray["11"]["m_alias"] = "";
protoArray["11"]["m_srcTableName"] = "Not Paid Report";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_sql"] = "";
protoArray["13"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["13"]["m_column"] = obj;
protoArray["13"]["m_contained"] = SettingsMap.GetArray();
protoArray["13"]["m_strCase"] = "";
protoArray["13"]["m_havingmode"] = false;
protoArray["13"]["m_inBrackets"] = false;
protoArray["13"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["13"]);

protoArray["11"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["11"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_link"] = "SQLL_INNERJOIN";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_strName"] = "public.swimmer";
protoArray["16"]["m_srcTableName"] = "Not Paid Report";
protoArray["16"]["m_columns"] = SettingsMap.GetArray();
protoArray["16"]["m_columns"].Add("id");
protoArray["16"]["m_columns"].Add("first_name");
protoArray["16"]["m_columns"].Add("last_name");
protoArray["16"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["16"]);

protoArray["15"]["m_table"] = obj;
protoArray["15"]["m_sql"] = "INNER JOIN \"public\".swimmer ON \"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
protoArray["15"]["m_alias"] = "";
protoArray["15"]["m_srcTableName"] = "Not Paid Report";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_sql"] = "\"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
protoArray["17"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "swimmer_id", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Not Paid Report"));

protoArray["17"]["m_column"] = obj;
protoArray["17"]["m_contained"] = SettingsMap.GetArray();
protoArray["17"]["m_strCase"] = "= \"public\".swimmer.id";
protoArray["17"]["m_havingmode"] = false;
protoArray["17"]["m_inBrackets"] = false;
protoArray["17"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["17"]);

protoArray["15"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["15"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["19"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "swimmer"));

protoArray["19"]["m_column"] = obj;
protoArray["19"]["m_bAsc"] = 1;
protoArray["19"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["19"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "Not Paid Report";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["Not_Paid_Report"] = obj;

				
		
			tdataArray["Not_Paid_Report"][".sqlquery"] = queryData_Array["Not_Paid_Report"];
			GlobalVars.tableEvents["Not Paid Report"] = new eventsBase();
			tdataArray["Not_Paid_Report"][".hasEvents"] = false;
			GlobalVars.tables_data["Not_Paid_Report"] = tdataArray["Not_Paid_Report"];
		}
	}

}
