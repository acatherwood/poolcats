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
	public static partial class Settings_Practice_Times
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["Practice_Times"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".truncateText"] = true;
			tdataArray["Practice_Times"][".NumberOfChars"] = 80;
			tdataArray["Practice_Times"][".ShortName"] = "Practice_Times";
			tdataArray["Practice_Times"][".OwnerID"] = "";
			tdataArray["Practice_Times"][".OriginalTable"] = "public.swimmerpayments";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"report\":\"report\",\"rprint\":\"rprint\",\"search\":\"search\"}"));
			tdataArray["Practice_Times"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}")));
			tdataArray["Practice_Times"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["Practice_Times"] = SettingsMap.GetArray();
			fieldToolTipsArray["Practice_Times"] = SettingsMap.GetArray();
			pageTitlesArray["Practice_Times"] = SettingsMap.GetArray();
			placeHoldersArray["Practice_Times"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["Practice_Times"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["Practice_Times"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["Practice_Times"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["Practice_Times"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["Practice_Times"]["English"]["practice_time"] = "Practice Time";
				fieldToolTipsArray["Practice_Times"]["English"]["practice_time"] = "";
				placeHoldersArray["Practice_Times"]["English"]["practice_time"] = "";
				fieldLabelsArray["Practice_Times"]["English"]["swimmer"] = "Swimmer";
				fieldToolTipsArray["Practice_Times"]["English"]["swimmer"] = "";
				placeHoldersArray["Practice_Times"]["English"]["swimmer"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["Practice_Times"]["English"])))
				{
					tdataArray["Practice_Times"][".isUseToolTips"] = true;
				}
			}
			tdataArray["Practice_Times"][".NCSearch"] = true;
			tdataArray["Practice_Times"][".shortTableName"] = "Practice_Times";
			tdataArray["Practice_Times"][".nSecOptions"] = 0;
			tdataArray["Practice_Times"][".mainTableOwnerID"] = "";
			tdataArray["Practice_Times"][".entityType"] = 2;
			tdataArray["Practice_Times"][".strOriginalTableName"] = "public.swimmerpayments";
			tdataArray["Practice_Times"][".showAddInPopup"] = false;
			tdataArray["Practice_Times"][".showEditInPopup"] = false;
			tdataArray["Practice_Times"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["Practice_Times"][".listAjax"] = false;
			tdataArray["Practice_Times"][".listAjax"] = false;
			tdataArray["Practice_Times"][".audit"] = false;
			tdataArray["Practice_Times"][".locking"] = false;
			GlobalVars.pages = tdataArray["Practice_Times"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["Practice_Times"][".edit"] = true;
				tdataArray["Practice_Times"][".afterEditAction"] = 1;
				tdataArray["Practice_Times"][".closePopupAfterEdit"] = 1;
				tdataArray["Practice_Times"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["Practice_Times"][".add"] = true;
				tdataArray["Practice_Times"][".afterAddAction"] = 1;
				tdataArray["Practice_Times"][".closePopupAfterAdd"] = 1;
				tdataArray["Practice_Times"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["Practice_Times"][".list"] = true;
			}
			tdataArray["Practice_Times"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["Practice_Times"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["Practice_Times"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["Practice_Times"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["Practice_Times"][".printFriendly"] = true;
			}
			tdataArray["Practice_Times"][".showSimpleSearchOptions"] = true;
			tdataArray["Practice_Times"][".allowShowHideFields"] = true;
			tdataArray["Practice_Times"][".allowFieldsReordering"] = true;
			tdataArray["Practice_Times"][".isUseAjaxSuggest"] = true;


			tdataArray["Practice_Times"][".flexibleSearch"] = true;
			tdataArray["Practice_Times"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["Practice_Times"][".buttonsAdded"] = false;
			tdataArray["Practice_Times"][".addPageEvents"] = false;
			tdataArray["Practice_Times"][".isUseTimeForSearch"] = false;
			tdataArray["Practice_Times"][".badgeColor"] = "DB7093";
			tdataArray["Practice_Times"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".googleLikeFields"].Add("practice_time");
			tdataArray["Practice_Times"][".googleLikeFields"].Add("swimmer");
			tdataArray["Practice_Times"][".tableType"] = "report";
			tdataArray["Practice_Times"][".printerPageOrientation"] = 0;
			tdataArray["Practice_Times"][".nPrinterPageScale"] = 100;
			tdataArray["Practice_Times"][".nPrinterSplitRecords"] = 40;
			tdataArray["Practice_Times"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["Practice_Times"][".geocodingEnabled"] = false;
			tdataArray["Practice_Times"][".reportPrintPartitionType"] = 1;
			tdataArray["Practice_Times"][".reportPrintGroupsPerPage"] = 3;
			tdataArray["Practice_Times"][".reportPrintPDFGroupsPerPage"] = 3;
			tdataArray["Practice_Times"][".lowGroup"] = 2;
			tdataArray["Practice_Times"][".reportGroupFields"] = true;
			tdataArray["Practice_Times"][".pageSize"] = 5;
			tdataArray["Practice_Times"][".showGroupSummaryCount"] = true;
			reportGroupFields = SettingsMap.GetArray();
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "practice_time";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 1;
			rgroupField["showGroupSummary"] = "1";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "swimmer";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 2;
			rgroupField["showGroupSummary"] = "1";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			tdataArray["Practice_Times"][".reportGroupFieldsData"] = reportGroupFields;
			tdataArray["Practice_Times"][".repShowDet"] = true;
			tdataArray["Practice_Times"][".reportLayout"] = 0;
			tstrOrderBy = "order by \"public\".swimmerpayment.practice_time";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["Practice_Times"][".strOrderBy"] = tstrOrderBy;
			tdataArray["Practice_Times"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".orderindexes"].Add(new XVar(0, 1, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "\"public\".swimmerpayment.practice_time"));
			tdataArray["Practice_Times"][".sqlHead"] = "SELECT \"public\".swimmerpayment.practice_time,  CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name) AS swimmer";
			tdataArray["Practice_Times"][".sqlFrom"] = "FROM \"public\".swimmerpayment  INNER JOIN \"public\".swimmer ON \"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
			tdataArray["Practice_Times"][".sqlWhereExpr"] = "";
			tdataArray["Practice_Times"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["Practice_Times"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["Practice_Times"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["Practice_Times"][".highlightSearchResults"] = true;
			tableKeysArray["Practice_Times"] = SettingsMap.GetArray();
			tdataArray["Practice_Times"][".Keys"] = tableKeysArray["Practice_Times"];
			tdataArray["Practice_Times"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "practice_time";
			fdata["GoodName"] = "practice_time";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Practice_Times","practice_time");
			fdata["FieldType"] = 200;
			fdata["strField"] = "practice_time";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmerpayment.practice_time";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["report"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["Practice_Times"]["practice_time"] = fdata;
			tdataArray["Practice_Times"][".searchableFields"].Add("practice_time");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "swimmer";
			fdata["GoodName"] = "swimmer";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Practice_Times","swimmer");
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
			tdataArray["Practice_Times"]["swimmer"] = fdata;
			tdataArray["Practice_Times"][".searchableFields"].Add("swimmer");
			GlobalVars.tables_data["Practice Times"] = tdataArray["Practice_Times"];
			GlobalVars.field_labels["Practice_Times"] = fieldLabelsArray["Practice_Times"];
			GlobalVars.fieldToolTips["Practice_Times"] = fieldToolTipsArray["Practice_Times"];
			GlobalVars.placeHolders["Practice_Times"] = placeHoldersArray["Practice_Times"];
			GlobalVars.page_titles["Practice_Times"] = pageTitlesArray["Practice_Times"];
			GlobalVars.detailsTablesData["Practice Times"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Practice Times"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "\"public\".swimmerpayment.practice_time,  CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name) AS swimmer";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmerpayment  INNER JOIN \"public\".swimmer ON \"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "order by \"public\".swimmerpayment.practice_time";
	
		
protoArray["0"]["cipherer"] = null;
protoArray["2"] = SettingsMap.GetArray();
protoArray["2"]["m_sql"] = "";
protoArray["2"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["2"]["m_column"] = obj;
protoArray["2"]["m_contained"] = SettingsMap.GetArray();
protoArray["2"]["m_strCase"] = "";
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
obj = new SQLField(new XVar("m_strName", "practice_time", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Practice Times"));

protoArray["6"]["m_sql"] = "\"public\".swimmerpayment.practice_time";
protoArray["6"]["m_srcTableName"] = "Practice Times";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
protoArray["9"] = SettingsMap.GetArray();
protoArray["9"]["m_functiontype"] = "SQLF_CUSTOM";
protoArray["9"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "\"public\".swimmer.first_name"));

protoArray["9"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "' '"));

protoArray["9"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "\"public\".swimmer.last_name"));

protoArray["9"]["m_arguments"].Add(obj);
protoArray["9"]["m_strFunctionName"] = "CONCAT";
obj = new SQLFunctionCall(protoArray["9"]);

protoArray["8"]["m_sql"] = "CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name)";
protoArray["8"]["m_srcTableName"] = "Practice Times";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "swimmer";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_link"] = "SQLL_MAIN";
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_strName"] = "public.swimmerpayment";
protoArray["14"]["m_srcTableName"] = "Practice Times";
protoArray["14"]["m_columns"] = SettingsMap.GetArray();
protoArray["14"]["m_columns"].Add("id");
protoArray["14"]["m_columns"].Add("swimmer_id");
protoArray["14"]["m_columns"].Add("payment_type");
protoArray["14"]["m_columns"].Add("amount_paid");
protoArray["14"]["m_columns"].Add("practice_time");
protoArray["14"]["m_columns"].Add("early_registration");
obj = new SQLTable(protoArray["14"]);

protoArray["13"]["m_table"] = obj;
protoArray["13"]["m_sql"] = "\"public\".swimmerpayment";
protoArray["13"]["m_alias"] = "";
protoArray["13"]["m_srcTableName"] = "Practice Times";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_sql"] = "";
protoArray["15"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["15"]["m_column"] = obj;
protoArray["15"]["m_contained"] = SettingsMap.GetArray();
protoArray["15"]["m_strCase"] = "";
protoArray["15"]["m_havingmode"] = false;
protoArray["15"]["m_inBrackets"] = false;
protoArray["15"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["15"]);

protoArray["13"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["13"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_link"] = "SQLL_INNERJOIN";
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_strName"] = "public.swimmer";
protoArray["18"]["m_srcTableName"] = "Practice Times";
protoArray["18"]["m_columns"] = SettingsMap.GetArray();
protoArray["18"]["m_columns"].Add("id");
protoArray["18"]["m_columns"].Add("first_name");
protoArray["18"]["m_columns"].Add("last_name");
protoArray["18"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["18"]);

protoArray["17"]["m_table"] = obj;
protoArray["17"]["m_sql"] = "INNER JOIN \"public\".swimmer ON \"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
protoArray["17"]["m_alias"] = "";
protoArray["17"]["m_srcTableName"] = "Practice Times";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_sql"] = "\"public\".swimmerpayment.swimmer_id = \"public\".swimmer.id";
protoArray["19"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "swimmer_id", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Practice Times"));

protoArray["19"]["m_column"] = obj;
protoArray["19"]["m_contained"] = SettingsMap.GetArray();
protoArray["19"]["m_strCase"] = "= \"public\".swimmer.id";
protoArray["19"]["m_havingmode"] = false;
protoArray["19"]["m_inBrackets"] = false;
protoArray["19"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["19"]);

protoArray["17"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["17"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["21"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "practice_time", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Practice Times"));

protoArray["21"]["m_column"] = obj;
protoArray["21"]["m_bAsc"] = 1;
protoArray["21"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["21"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "Practice Times";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["Practice_Times"] = obj;

				
		
			tdataArray["Practice_Times"][".sqlquery"] = queryData_Array["Practice_Times"];
			GlobalVars.tableEvents["Practice Times"] = new eventsBase();
			tdataArray["Practice_Times"][".hasEvents"] = false;
			GlobalVars.tables_data["Practice_Times"] = tdataArray["Practice_Times"];
		}
	}

}
