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
	public static partial class Settings_public_swimmer
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmer"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".truncateText"] = true;
			tdataArray["public_swimmer"][".NumberOfChars"] = 80;
			tdataArray["public_swimmer"][".ShortName"] = "public_swimmer";
			tdataArray["public_swimmer"][".OwnerID"] = "";
			tdataArray["public_swimmer"][".OriginalTable"] = "public.swimmer";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["public_swimmer"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["public_swimmer"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmer"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmer"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmer"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmer"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmer"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmer"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmer"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmer"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmer"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmer"]["English"]["id"] = "";
				placeHoldersArray["public_swimmer"]["English"]["id"] = "";
				fieldLabelsArray["public_swimmer"]["English"]["first_name"] = "First Name";
				fieldToolTipsArray["public_swimmer"]["English"]["first_name"] = "";
				placeHoldersArray["public_swimmer"]["English"]["first_name"] = "";
				fieldLabelsArray["public_swimmer"]["English"]["last_name"] = "Last Name";
				fieldToolTipsArray["public_swimmer"]["English"]["last_name"] = "";
				placeHoldersArray["public_swimmer"]["English"]["last_name"] = "";
				fieldLabelsArray["public_swimmer"]["English"]["birthdate"] = "Birthdate";
				fieldToolTipsArray["public_swimmer"]["English"]["birthdate"] = "";
				placeHoldersArray["public_swimmer"]["English"]["birthdate"] = "";
				fieldLabelsArray["public_swimmer"]["English"]["gender"] = "Gender";
				fieldToolTipsArray["public_swimmer"]["English"]["gender"] = "";
				placeHoldersArray["public_swimmer"]["English"]["gender"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmer"]["English"])))
				{
					tdataArray["public_swimmer"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmer"][".NCSearch"] = true;
			tdataArray["public_swimmer"][".shortTableName"] = "public_swimmer";
			tdataArray["public_swimmer"][".nSecOptions"] = 0;
			tdataArray["public_swimmer"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmer"][".entityType"] = 0;
			tdataArray["public_swimmer"][".strOriginalTableName"] = "public.swimmer";
			tdataArray["public_swimmer"][".showAddInPopup"] = false;
			tdataArray["public_swimmer"][".showEditInPopup"] = false;
			tdataArray["public_swimmer"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmer"][".listAjax"] = false;
			tdataArray["public_swimmer"][".listAjax"] = false;
			tdataArray["public_swimmer"][".audit"] = false;
			tdataArray["public_swimmer"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmer"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmer"][".edit"] = true;
				tdataArray["public_swimmer"][".afterEditAction"] = 2;
				tdataArray["public_swimmer"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmer"][".afterEditActionDetTable"] = "public.swimmercontact";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmer"][".add"] = true;
				tdataArray["public_swimmer"][".afterAddAction"] = 1;
				tdataArray["public_swimmer"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmer"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmer"][".list"] = true;
			}
			tdataArray["public_swimmer"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmer"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmer"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmer"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmer"][".printFriendly"] = true;
			}
			tdataArray["public_swimmer"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmer"][".allowShowHideFields"] = true;
			tdataArray["public_swimmer"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmer"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmer"][".rowHighlite"] = true;


			tdataArray["public_swimmer"][".flexibleSearch"] = true;
			tdataArray["public_swimmer"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmer"][".buttonsAdded"] = false;
			tdataArray["public_swimmer"][".addPageEvents"] = false;
			tdataArray["public_swimmer"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmer"][".badgeColor"] = "00C2C5";
			tdataArray["public_swimmer"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmer"][".googleLikeFields"].Add("first_name");
			tdataArray["public_swimmer"][".googleLikeFields"].Add("last_name");
			tdataArray["public_swimmer"][".googleLikeFields"].Add("gender");
			tdataArray["public_swimmer"][".googleLikeFields"].Add("birthdate");
			tdataArray["public_swimmer"][".tableType"] = "list";
			tdataArray["public_swimmer"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmer"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmer"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmer"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmer"][".geocodingEnabled"] = false;
			tdataArray["public_swimmer"][".pageSize"] = 20;
			tdataArray["public_swimmer"][".warnLeavingPages"] = true;
			tdataArray["public_swimmer"][".hideEmptyFieldsOnView"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmer"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmer"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmer"][".sqlHead"] = "SELECT id,  	first_name,  	last_name,  	gender,  	birthdate";
			tdataArray["public_swimmer"][".sqlFrom"] = "FROM \"public\".swimmer";
			tdataArray["public_swimmer"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmer"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmer"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmer"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmer"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmer"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmer"].Add("id");
			tdataArray["public_swimmer"][".Keys"] = tableKeysArray["public_swimmer"];
			tdataArray["public_swimmer"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmer","id");
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
			tdataArray["public_swimmer"]["id"] = fdata;
			tdataArray["public_swimmer"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "first_name";
			fdata["GoodName"] = "first_name";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmer","first_name");
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
			tdataArray["public_swimmer"]["first_name"] = fdata;
			tdataArray["public_swimmer"][".searchableFields"].Add("first_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "last_name";
			fdata["GoodName"] = "last_name";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmer","last_name");
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
			tdataArray["public_swimmer"]["last_name"] = fdata;
			tdataArray["public_swimmer"][".searchableFields"].Add("last_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "gender";
			fdata["GoodName"] = "gender";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmer","gender");
			fdata["FieldType"] = 200;
			fdata["strField"] = "gender";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "gender";
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
			tdataArray["public_swimmer"]["gender"] = fdata;
			tdataArray["public_swimmer"][".searchableFields"].Add("gender");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "birthdate";
			fdata["GoodName"] = "birthdate";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmer","birthdate");
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
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 13;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["public_swimmer"]["birthdate"] = fdata;
			tdataArray["public_swimmer"][".searchableFields"].Add("birthdate");
			GlobalVars.tables_data["public.swimmer"] = tdataArray["public_swimmer"];
			GlobalVars.field_labels["public_swimmer"] = fieldLabelsArray["public_swimmer"];
			GlobalVars.fieldToolTips["public_swimmer"] = fieldToolTipsArray["public_swimmer"];
			GlobalVars.placeHolders["public_swimmer"] = placeHoldersArray["public_swimmer"];
			GlobalVars.page_titles["public_swimmer"] = pageTitlesArray["public_swimmer"];
			GlobalVars.detailsTablesData["public.swimmer"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmersuit";
			detailsParam["dOriginalTable"] = "public.swimmersuit";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmersuit";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmersuit"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "Swimmers Without Suits - Report";
			detailsParam["dOriginalTable"] = "public.swimmersuit";
			detailsParam["dType"] = Constants.PAGE_REPORT;
			detailsParam["dShortTable"] = "Swimmers_Without_Suits___Report";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("Swimmers_Without_Suits___Report"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 2;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmerpayment";
			detailsParam["dOriginalTable"] = "public.swimmerpayment";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmerpayment";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmerpayment"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 3;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmercontact";
			detailsParam["dOriginalTable"] = "public.swimmercontact";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmercontact";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmercontact"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["public.swimmer"][dIndex]["detailKeys"].Add("swimmer_id");
			GlobalVars.masterTablesData["public.swimmer"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	first_name,  	last_name,  	gender,  	birthdate";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmer";
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmer", "m_srcTableName", "public.swimmer"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "public.swimmer";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "first_name", "m_strTable", "public.swimmer", "m_srcTableName", "public.swimmer"));

protoArray["8"]["m_sql"] = "first_name";
protoArray["8"]["m_srcTableName"] = "public.swimmer";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "last_name", "m_strTable", "public.swimmer", "m_srcTableName", "public.swimmer"));

protoArray["10"]["m_sql"] = "last_name";
protoArray["10"]["m_srcTableName"] = "public.swimmer";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "gender", "m_strTable", "public.swimmer", "m_srcTableName", "public.swimmer"));

protoArray["12"]["m_sql"] = "gender";
protoArray["12"]["m_srcTableName"] = "public.swimmer";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "birthdate", "m_strTable", "public.swimmer", "m_srcTableName", "public.swimmer"));

protoArray["14"]["m_sql"] = "birthdate";
protoArray["14"]["m_srcTableName"] = "public.swimmer";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "public.swimmer";
protoArray["17"]["m_srcTableName"] = "public.swimmer";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("id");
protoArray["17"]["m_columns"].Add("first_name");
protoArray["17"]["m_columns"].Add("last_name");
protoArray["17"]["m_columns"].Add("gender");
protoArray["17"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "\"public\".swimmer";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "public.swimmer";
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_sql"] = "";
protoArray["18"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["18"]["m_column"] = obj;
protoArray["18"]["m_contained"] = SettingsMap.GetArray();
protoArray["18"]["m_strCase"] = "";
protoArray["18"]["m_havingmode"] = false;
protoArray["18"]["m_inBrackets"] = false;
protoArray["18"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["18"]);

protoArray["16"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["16"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "public.swimmer";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmer"] = obj;

				
		
			tdataArray["public_swimmer"][".sqlquery"] = queryData_Array["public_swimmer"];
			GlobalVars.tableEvents["public.swimmer"] = new eventsBase();
			tdataArray["public_swimmer"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmer"] = tdataArray["public_swimmer"];
		}
	}

}
