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
	public static partial class Settings_public_swimmerStats
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".truncateText"] = true;
			tdataArray["public_swimmerStats"][".NumberOfChars"] = 80;
			tdataArray["public_swimmerStats"][".ShortName"] = "public_swimmerStats";
			tdataArray["public_swimmerStats"][".OwnerID"] = "";
			tdataArray["public_swimmerStats"][".OriginalTable"] = "public.swimmerStats";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["public_swimmerStats"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["public_swimmerStats"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmerStats"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmerStats"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmerStats"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmerStats"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmerStats"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmerStats"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmerStats"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmerStats"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmerStats"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmerStats"]["English"]["id"] = "";
				placeHoldersArray["public_swimmerStats"]["English"]["id"] = "";
				fieldLabelsArray["public_swimmerStats"]["English"]["suitSize"] = "Suit Size";
				fieldToolTipsArray["public_swimmerStats"]["English"]["suitSize"] = "";
				placeHoldersArray["public_swimmerStats"]["English"]["suitSize"] = "";
				fieldLabelsArray["public_swimmerStats"]["English"]["suitType"] = "Suit Type";
				fieldToolTipsArray["public_swimmerStats"]["English"]["suitType"] = "";
				placeHoldersArray["public_swimmerStats"]["English"]["suitType"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmerStats"]["English"])))
				{
					tdataArray["public_swimmerStats"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmerStats"][".NCSearch"] = true;
			tdataArray["public_swimmerStats"][".shortTableName"] = "public_swimmerStats";
			tdataArray["public_swimmerStats"][".nSecOptions"] = 0;
			tdataArray["public_swimmerStats"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmerStats"][".entityType"] = 0;
			tdataArray["public_swimmerStats"][".strOriginalTableName"] = "public.swimmerStats";
			tdataArray["public_swimmerStats"][".showAddInPopup"] = false;
			tdataArray["public_swimmerStats"][".showEditInPopup"] = false;
			tdataArray["public_swimmerStats"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmerStats"][".listAjax"] = false;
			tdataArray["public_swimmerStats"][".listAjax"] = false;
			tdataArray["public_swimmerStats"][".audit"] = false;
			tdataArray["public_swimmerStats"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmerStats"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmerStats"][".edit"] = true;
				tdataArray["public_swimmerStats"][".afterEditAction"] = 1;
				tdataArray["public_swimmerStats"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmerStats"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmerStats"][".add"] = true;
				tdataArray["public_swimmerStats"][".afterAddAction"] = 1;
				tdataArray["public_swimmerStats"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmerStats"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmerStats"][".list"] = true;
			}
			tdataArray["public_swimmerStats"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmerStats"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmerStats"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmerStats"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmerStats"][".printFriendly"] = true;
			}
			tdataArray["public_swimmerStats"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmerStats"][".allowShowHideFields"] = true;
			tdataArray["public_swimmerStats"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmerStats"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmerStats"][".rowHighlite"] = true;


			tdataArray["public_swimmerStats"][".flexibleSearch"] = true;
			tdataArray["public_swimmerStats"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmerStats"][".buttonsAdded"] = false;
			tdataArray["public_swimmerStats"][".addPageEvents"] = false;
			tdataArray["public_swimmerStats"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmerStats"][".badgeColor"] = "D2691E";
			tdataArray["public_swimmerStats"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmerStats"][".googleLikeFields"].Add("suitSize");
			tdataArray["public_swimmerStats"][".googleLikeFields"].Add("suitType");
			tdataArray["public_swimmerStats"][".tableType"] = "list";
			tdataArray["public_swimmerStats"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmerStats"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmerStats"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmerStats"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmerStats"][".geocodingEnabled"] = false;
			tdataArray["public_swimmerStats"][".pageSize"] = 20;
			tdataArray["public_swimmerStats"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmerStats"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmerStats"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmerStats"][".sqlHead"] = "SELECT id,  	\"suitSize\",  	\"suitType\"";
			tdataArray["public_swimmerStats"][".sqlFrom"] = "FROM \"public\".\"swimmerStats\"";
			tdataArray["public_swimmerStats"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmerStats"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmerStats"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmerStats"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmerStats"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmerStats"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmerStats"].Add("id");
			tdataArray["public_swimmerStats"][".Keys"] = tableKeysArray["public_swimmerStats"];
			tdataArray["public_swimmerStats"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmerStats";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerStats","id");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "id";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["public_swimmerStats"]["id"] = fdata;
			tdataArray["public_swimmerStats"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "suitSize";
			fdata["GoodName"] = "suitSize";
			fdata["ownerTable"] = "public.swimmerStats";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerStats","suitSize");
			fdata["FieldType"] = 3;
			fdata["strField"] = "suitSize";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"suitSize\"";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["public_swimmerStats"]["suitSize"] = fdata;
			tdataArray["public_swimmerStats"][".searchableFields"].Add("suitSize");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "suitType";
			fdata["GoodName"] = "suitType";
			fdata["ownerTable"] = "public.swimmerStats";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerStats","suitType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "suitType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"suitType\"";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=255");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["public_swimmerStats"]["suitType"] = fdata;
			tdataArray["public_swimmerStats"][".searchableFields"].Add("suitType");
			GlobalVars.tables_data["public.swimmerStats"] = tdataArray["public_swimmerStats"];
			GlobalVars.field_labels["public_swimmerStats"] = fieldLabelsArray["public_swimmerStats"];
			GlobalVars.fieldToolTips["public_swimmerStats"] = fieldToolTipsArray["public_swimmerStats"];
			GlobalVars.placeHolders["public_swimmerStats"] = placeHoldersArray["public_swimmerStats"];
			GlobalVars.page_titles["public_swimmerStats"] = pageTitlesArray["public_swimmerStats"];
			GlobalVars.detailsTablesData["public.swimmerStats"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmers";
			detailsParam["dOriginalTable"] = "public.swimmers";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmers";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmers"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["detailKeys"].Add("swimmerStatId");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmersInfo";
			detailsParam["dOriginalTable"] = "public.swimmers";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmersInfo";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmersInfo"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmerStats"][dIndex]["detailKeys"].Add("swimmerStatId");
			GlobalVars.masterTablesData["public.swimmerStats"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	\"suitSize\",  	\"suitType\"";
protoArray["0"]["m_strFrom"] = "FROM \"public\".\"swimmerStats\"";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "";
	
		
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmerStats", "m_srcTableName", "public.swimmerStats"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "public.swimmerStats";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suitSize", "m_strTable", "public.swimmerStats", "m_srcTableName", "public.swimmerStats"));

protoArray["8"]["m_sql"] = "\"suitSize\"";
protoArray["8"]["m_srcTableName"] = "public.swimmerStats";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suitType", "m_strTable", "public.swimmerStats", "m_srcTableName", "public.swimmerStats"));

protoArray["10"]["m_sql"] = "\"suitType\"";
protoArray["10"]["m_srcTableName"] = "public.swimmerStats";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_link"] = "SQLL_MAIN";
protoArray["13"] = SettingsMap.GetArray();
protoArray["13"]["m_strName"] = "public.swimmerStats";
protoArray["13"]["m_srcTableName"] = "public.swimmerStats";
protoArray["13"]["m_columns"] = SettingsMap.GetArray();
protoArray["13"]["m_columns"].Add("id");
protoArray["13"]["m_columns"].Add("suitSize");
protoArray["13"]["m_columns"].Add("suitType");
obj = new SQLTable(protoArray["13"]);

protoArray["12"]["m_table"] = obj;
protoArray["12"]["m_sql"] = "\"public\".\"swimmerStats\"";
protoArray["12"]["m_alias"] = "";
protoArray["12"]["m_srcTableName"] = "public.swimmerStats";
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_sql"] = "";
protoArray["14"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["14"]["m_column"] = obj;
protoArray["14"]["m_contained"] = SettingsMap.GetArray();
protoArray["14"]["m_strCase"] = "";
protoArray["14"]["m_havingmode"] = false;
protoArray["14"]["m_inBrackets"] = false;
protoArray["14"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["14"]);

protoArray["12"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["12"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "public.swimmerStats";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmerStats"] = obj;

				
		
			tdataArray["public_swimmerStats"][".sqlquery"] = queryData_Array["public_swimmerStats"];
			GlobalVars.tableEvents["public.swimmerStats"] = new eventsBase();
			tdataArray["public_swimmerStats"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmerStats"] = tdataArray["public_swimmerStats"];
		}
	}

}
