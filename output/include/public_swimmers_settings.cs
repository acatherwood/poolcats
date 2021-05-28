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
	public static partial class Settings_public_swimmers
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmers"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".truncateText"] = true;
			tdataArray["public_swimmers"][".NumberOfChars"] = 80;
			tdataArray["public_swimmers"][".ShortName"] = "public_swimmers";
			tdataArray["public_swimmers"][".OwnerID"] = "";
			tdataArray["public_swimmers"][".OriginalTable"] = "public.swimmers";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["public_swimmers"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["public_swimmers"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmers"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmers"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmers"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmers"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmers"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmers"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmers"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmers"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmers"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmers"]["English"]["id"] = "";
				placeHoldersArray["public_swimmers"]["English"]["id"] = "";
				fieldLabelsArray["public_swimmers"]["English"]["first_name"] = "First Name";
				fieldToolTipsArray["public_swimmers"]["English"]["first_name"] = "";
				placeHoldersArray["public_swimmers"]["English"]["first_name"] = "";
				fieldLabelsArray["public_swimmers"]["English"]["last_name"] = "Last Name";
				fieldToolTipsArray["public_swimmers"]["English"]["last_name"] = "";
				placeHoldersArray["public_swimmers"]["English"]["last_name"] = "";
				fieldLabelsArray["public_swimmers"]["English"]["birthdate"] = "Birthdate";
				fieldToolTipsArray["public_swimmers"]["English"]["birthdate"] = "";
				placeHoldersArray["public_swimmers"]["English"]["birthdate"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmers"]["English"])))
				{
					tdataArray["public_swimmers"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmers"][".NCSearch"] = true;
			tdataArray["public_swimmers"][".shortTableName"] = "public_swimmers";
			tdataArray["public_swimmers"][".nSecOptions"] = 0;
			tdataArray["public_swimmers"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmers"][".entityType"] = 0;
			tdataArray["public_swimmers"][".strOriginalTableName"] = "public.swimmers";
			tdataArray["public_swimmers"][".showAddInPopup"] = false;
			tdataArray["public_swimmers"][".showEditInPopup"] = false;
			tdataArray["public_swimmers"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmers"][".listAjax"] = false;
			tdataArray["public_swimmers"][".listAjax"] = false;
			tdataArray["public_swimmers"][".audit"] = false;
			tdataArray["public_swimmers"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmers"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmers"][".edit"] = true;
				tdataArray["public_swimmers"][".afterEditAction"] = 1;
				tdataArray["public_swimmers"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmers"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmers"][".add"] = true;
				tdataArray["public_swimmers"][".afterAddAction"] = 1;
				tdataArray["public_swimmers"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmers"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmers"][".list"] = true;
			}
			tdataArray["public_swimmers"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmers"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmers"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmers"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmers"][".printFriendly"] = true;
			}
			tdataArray["public_swimmers"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmers"][".allowShowHideFields"] = true;
			tdataArray["public_swimmers"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmers"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmers"][".rowHighlite"] = true;


			tdataArray["public_swimmers"][".flexibleSearch"] = true;
			tdataArray["public_swimmers"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmers"][".buttonsAdded"] = false;
			tdataArray["public_swimmers"][".addPageEvents"] = false;
			tdataArray["public_swimmers"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmers"][".badgeColor"] = "CD853F";
			tdataArray["public_swimmers"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmers"][".googleLikeFields"].Add("first_name");
			tdataArray["public_swimmers"][".googleLikeFields"].Add("last_name");
			tdataArray["public_swimmers"][".googleLikeFields"].Add("birthdate");
			tdataArray["public_swimmers"][".tableType"] = "list";
			tdataArray["public_swimmers"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmers"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmers"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmers"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmers"][".geocodingEnabled"] = false;
			tdataArray["public_swimmers"][".pageSize"] = 20;
			tdataArray["public_swimmers"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmers"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmers"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmers"][".sqlHead"] = "SELECT id,  	first_name,  	last_name,  	birthdate";
			tdataArray["public_swimmers"][".sqlFrom"] = "FROM \"public\".swimmers";
			tdataArray["public_swimmers"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmers"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmers"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmers"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmers"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmers"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmers"].Add("id");
			tdataArray["public_swimmers"][".Keys"] = tableKeysArray["public_swimmers"];
			tdataArray["public_swimmers"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmers","id");
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
			tdataArray["public_swimmers"]["id"] = fdata;
			tdataArray["public_swimmers"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "first_name";
			fdata["GoodName"] = "first_name";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmers","first_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "first_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "first_name";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["public_swimmers"]["first_name"] = fdata;
			tdataArray["public_swimmers"][".searchableFields"].Add("first_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "last_name";
			fdata["GoodName"] = "last_name";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmers","last_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "last_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "last_name";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=100");
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
			tdataArray["public_swimmers"]["last_name"] = fdata;
			tdataArray["public_swimmers"][".searchableFields"].Add("last_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "birthdate";
			fdata["GoodName"] = "birthdate";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmers","birthdate");
			fdata["FieldType"] = 135;
			fdata["strField"] = "birthdate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "birthdate";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["ShowTime"] = true;
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Equals", 1, "More than", 2, "Less than", 3, "Between", 4, Constants.EMPTY_SEARCH, 5, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			tdataArray["public_swimmers"]["birthdate"] = fdata;
			tdataArray["public_swimmers"][".searchableFields"].Add("birthdate");
			GlobalVars.tables_data["public.swimmers"] = tdataArray["public_swimmers"];
			GlobalVars.field_labels["public_swimmers"] = fieldLabelsArray["public_swimmers"];
			GlobalVars.fieldToolTips["public_swimmers"] = fieldToolTipsArray["public_swimmers"];
			GlobalVars.placeHolders["public_swimmers"] = placeHoldersArray["public_swimmers"];
			GlobalVars.page_titles["public_swimmers"] = pageTitlesArray["public_swimmers"];
			GlobalVars.detailsTablesData["public.swimmers"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmersuit";
			detailsParam["dOriginalTable"] = "public.swimmersuit";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmersuit";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmersuit"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmerpayments";
			detailsParam["dOriginalTable"] = "public.swimmerpayments";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmerpayments";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmerpayments"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Not Paid Report";
			detailsParam["dOriginalTable"] = "public.swimmerpayments";
			detailsParam["dType"] = Constants.PAGE_REPORT;
			detailsParam["dShortTable"] = "Not_Paid_Report";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Not_Paid_Report"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Practice Times";
			detailsParam["dOriginalTable"] = "public.swimmerpayments";
			detailsParam["dType"] = Constants.PAGE_REPORT;
			detailsParam["dShortTable"] = "Practice_Times";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Practice_Times"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmers"][dIndex]["detailKeys"].Add("swimmer_id");
			GlobalVars.masterTablesData["public.swimmers"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	first_name,  	last_name,  	birthdate";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmers";
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmers"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "public.swimmers";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "first_name", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmers"));

protoArray["8"]["m_sql"] = "first_name";
protoArray["8"]["m_srcTableName"] = "public.swimmers";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "last_name", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmers"));

protoArray["10"]["m_sql"] = "last_name";
protoArray["10"]["m_srcTableName"] = "public.swimmers";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "birthdate", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmers"));

protoArray["12"]["m_sql"] = "birthdate";
protoArray["12"]["m_srcTableName"] = "public.swimmers";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "public.swimmers";
protoArray["15"]["m_srcTableName"] = "public.swimmers";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("id");
protoArray["15"]["m_columns"].Add("first_name");
protoArray["15"]["m_columns"].Add("last_name");
protoArray["15"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "\"public\".swimmers";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "public.swimmers";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_sql"] = "";
protoArray["16"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["16"]["m_column"] = obj;
protoArray["16"]["m_contained"] = SettingsMap.GetArray();
protoArray["16"]["m_strCase"] = "";
protoArray["16"]["m_havingmode"] = false;
protoArray["16"]["m_inBrackets"] = false;
protoArray["16"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["16"]);

protoArray["14"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["14"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "public.swimmers";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmers"] = obj;

				
		
			tdataArray["public_swimmers"][".sqlquery"] = queryData_Array["public_swimmers"];
			GlobalVars.tableEvents["public.swimmers"] = new eventsBase();
			tdataArray["public_swimmers"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmers"] = tdataArray["public_swimmers"];
		}
	}

}
