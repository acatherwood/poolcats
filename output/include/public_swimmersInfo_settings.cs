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
	public static partial class Settings_public_swimmersInfo
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".truncateText"] = true;
			tdataArray["public_swimmersInfo"][".NumberOfChars"] = 80;
			tdataArray["public_swimmersInfo"][".ShortName"] = "public_swimmersInfo";
			tdataArray["public_swimmersInfo"][".OwnerID"] = "";
			tdataArray["public_swimmersInfo"][".OriginalTable"] = "public.swimmers";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"edit\":\"edit\",\"export\":\"export\",\"list\":\"list\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["public_swimmersInfo"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"edit\":[\"edit\"],\"export\":[\"export\"],\"list\":[\"list\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["public_swimmersInfo"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmersInfo"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmersInfo"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmersInfo"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmersInfo"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmersInfo"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmersInfo"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmersInfo"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmersInfo"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmersInfo"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmersInfo"]["English"]["id"] = "";
				placeHoldersArray["public_swimmersInfo"]["English"]["id"] = "";
				fieldLabelsArray["public_swimmersInfo"]["English"]["first_name"] = "First Name";
				fieldToolTipsArray["public_swimmersInfo"]["English"]["first_name"] = "";
				placeHoldersArray["public_swimmersInfo"]["English"]["first_name"] = "";
				fieldLabelsArray["public_swimmersInfo"]["English"]["last_name"] = "Last Name";
				fieldToolTipsArray["public_swimmersInfo"]["English"]["last_name"] = "";
				placeHoldersArray["public_swimmersInfo"]["English"]["last_name"] = "";
				fieldLabelsArray["public_swimmersInfo"]["English"]["birthdate"] = "Birthdate";
				fieldToolTipsArray["public_swimmersInfo"]["English"]["birthdate"] = "";
				placeHoldersArray["public_swimmersInfo"]["English"]["birthdate"] = "";
				fieldLabelsArray["public_swimmersInfo"]["English"]["suitSize"] = "Suit Size";
				fieldToolTipsArray["public_swimmersInfo"]["English"]["suitSize"] = "";
				placeHoldersArray["public_swimmersInfo"]["English"]["suitSize"] = "";
				fieldLabelsArray["public_swimmersInfo"]["English"]["suitType"] = "Suit Type";
				fieldToolTipsArray["public_swimmersInfo"]["English"]["suitType"] = "";
				placeHoldersArray["public_swimmersInfo"]["English"]["suitType"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmersInfo"]["English"])))
				{
					tdataArray["public_swimmersInfo"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmersInfo"][".NCSearch"] = true;
			tdataArray["public_swimmersInfo"][".shortTableName"] = "public_swimmersInfo";
			tdataArray["public_swimmersInfo"][".nSecOptions"] = 0;
			tdataArray["public_swimmersInfo"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmersInfo"][".entityType"] = 1;
			tdataArray["public_swimmersInfo"][".strOriginalTableName"] = "public.swimmers";
			tdataArray["public_swimmersInfo"][".showAddInPopup"] = false;
			tdataArray["public_swimmersInfo"][".showEditInPopup"] = false;
			tdataArray["public_swimmersInfo"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmersInfo"][".listAjax"] = false;
			tdataArray["public_swimmersInfo"][".listAjax"] = false;
			tdataArray["public_swimmersInfo"][".audit"] = false;
			tdataArray["public_swimmersInfo"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmersInfo"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmersInfo"][".edit"] = true;
				tdataArray["public_swimmersInfo"][".afterEditAction"] = 1;
				tdataArray["public_swimmersInfo"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmersInfo"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmersInfo"][".add"] = true;
				tdataArray["public_swimmersInfo"][".afterAddAction"] = 1;
				tdataArray["public_swimmersInfo"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmersInfo"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmersInfo"][".list"] = true;
			}
			tdataArray["public_swimmersInfo"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmersInfo"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmersInfo"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmersInfo"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmersInfo"][".printFriendly"] = true;
			}
			tdataArray["public_swimmersInfo"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmersInfo"][".allowShowHideFields"] = true;
			tdataArray["public_swimmersInfo"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmersInfo"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmersInfo"][".rowHighlite"] = true;


			tdataArray["public_swimmersInfo"][".flexibleSearch"] = true;
			tdataArray["public_swimmersInfo"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmersInfo"][".buttonsAdded"] = false;
			tdataArray["public_swimmersInfo"][".addPageEvents"] = false;
			tdataArray["public_swimmersInfo"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmersInfo"][".badgeColor"] = "00C2C5";
			tdataArray["public_swimmersInfo"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmersInfo"][".googleLikeFields"].Add("first_name");
			tdataArray["public_swimmersInfo"][".googleLikeFields"].Add("last_name");
			tdataArray["public_swimmersInfo"][".googleLikeFields"].Add("birthdate");
			tdataArray["public_swimmersInfo"][".googleLikeFields"].Add("suitSize");
			tdataArray["public_swimmersInfo"][".googleLikeFields"].Add("suitType");
			tdataArray["public_swimmersInfo"][".tableType"] = "list";
			tdataArray["public_swimmersInfo"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmersInfo"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmersInfo"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmersInfo"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmersInfo"][".geocodingEnabled"] = false;
			tdataArray["public_swimmersInfo"][".isDisplayLoading"] = true;
			tdataArray["public_swimmersInfo"][".pageSize"] = 20;
			tdataArray["public_swimmersInfo"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmersInfo"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmersInfo"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmersInfo"][".sqlHead"] = "SELECT \"public\".swimmers.id,  \"public\".swimmers.first_name,  \"public\".swimmers.last_name,  \"public\".swimmers.birthdate,  \"public\".\"swimmerStats\".\"suitSize\",  \"public\".\"swimmerStats\".\"suitType\"";
			tdataArray["public_swimmersInfo"][".sqlFrom"] = "FROM \"public\".swimmers  INNER JOIN \"public\".\"swimmerStats\" ON \"public\".swimmers.\"swimmerStatId\" = \"public\".\"swimmerStats\".id";
			tdataArray["public_swimmersInfo"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmersInfo"][".sqlTail"] = "";
			arrGridTabs = SettingsMap.GetArray();
			arrGridTabs.Add(new XVar("tabId", "", "name", "All data", "nameType", "Text", "where", "", "showRowCount", 0, "hideEmpty", 0));
			tdataArray["public_swimmersInfo"][".arrGridTabs"] = arrGridTabs;
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmersInfo"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmersInfo"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmersInfo"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmersInfo"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmersInfo"].Add("id");
			tdataArray["public_swimmersInfo"][".Keys"] = tableKeysArray["public_swimmersInfo"];
			tdataArray["public_swimmersInfo"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersInfo","id");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmers.id";
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
			tdataArray["public_swimmersInfo"]["id"] = fdata;
			tdataArray["public_swimmersInfo"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "first_name";
			fdata["GoodName"] = "first_name";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersInfo","first_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "first_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmers.first_name";
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
			tdataArray["public_swimmersInfo"]["first_name"] = fdata;
			tdataArray["public_swimmersInfo"][".searchableFields"].Add("first_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "last_name";
			fdata["GoodName"] = "last_name";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersInfo","last_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "last_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmers.last_name";
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
			tdataArray["public_swimmersInfo"]["last_name"] = fdata;
			tdataArray["public_swimmersInfo"][".searchableFields"].Add("last_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "birthdate";
			fdata["GoodName"] = "birthdate";
			fdata["ownerTable"] = "public.swimmers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersInfo","birthdate");
			fdata["FieldType"] = 7;
			fdata["strField"] = "birthdate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmers.birthdate";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
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
			tdataArray["public_swimmersInfo"]["birthdate"] = fdata;
			tdataArray["public_swimmersInfo"][".searchableFields"].Add("birthdate");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "suitSize";
			fdata["GoodName"] = "suitSize";
			fdata["ownerTable"] = "public.swimmerStats";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersInfo","suitSize");
			fdata["FieldType"] = 3;
			fdata["strField"] = "suitSize";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".\"swimmerStats\".\"suitSize\"";
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
			tdataArray["public_swimmersInfo"]["suitSize"] = fdata;
			tdataArray["public_swimmersInfo"][".searchableFields"].Add("suitSize");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "suitType";
			fdata["GoodName"] = "suitType";
			fdata["ownerTable"] = "public.swimmerStats";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersInfo","suitType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "suitType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".\"swimmerStats\".\"suitType\"";
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
			tdataArray["public_swimmersInfo"]["suitType"] = fdata;
			tdataArray["public_swimmersInfo"][".searchableFields"].Add("suitType");
			GlobalVars.tables_data["public.swimmersInfo"] = tdataArray["public_swimmersInfo"];
			GlobalVars.field_labels["public_swimmersInfo"] = fieldLabelsArray["public_swimmersInfo"];
			GlobalVars.fieldToolTips["public_swimmersInfo"] = fieldToolTipsArray["public_swimmersInfo"];
			GlobalVars.placeHolders["public_swimmersInfo"] = placeHoldersArray["public_swimmersInfo"];
			GlobalVars.page_titles["public_swimmersInfo"] = pageTitlesArray["public_swimmersInfo"];
			GlobalVars.detailsTablesData["public.swimmersInfo"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersInfo"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "public.swimmerStats";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "public.swimmerStats";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "public_swimmerStats";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["public.swimmersInfo"][0] = masterParams;
			GlobalVars.masterTablesData["public.swimmersInfo"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersInfo"][0]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmersInfo"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersInfo"][0]["detailKeys"].Add("swimmerStatId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "\"public\".swimmers.id,  \"public\".swimmers.first_name,  \"public\".swimmers.last_name,  \"public\".swimmers.birthdate,  \"public\".\"swimmerStats\".\"suitSize\",  \"public\".\"swimmerStats\".\"suitType\"";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmers  INNER JOIN \"public\".\"swimmerStats\" ON \"public\".swimmers.\"swimmerStatId\" = \"public\".\"swimmerStats\".id";
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmersInfo"));

protoArray["6"]["m_sql"] = "\"public\".swimmers.id";
protoArray["6"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "first_name", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmersInfo"));

protoArray["8"]["m_sql"] = "\"public\".swimmers.first_name";
protoArray["8"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "last_name", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmersInfo"));

protoArray["10"]["m_sql"] = "\"public\".swimmers.last_name";
protoArray["10"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "birthdate", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmersInfo"));

protoArray["12"]["m_sql"] = "\"public\".swimmers.birthdate";
protoArray["12"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suitSize", "m_strTable", "public.swimmerStats", "m_srcTableName", "public.swimmersInfo"));

protoArray["14"]["m_sql"] = "\"public\".\"swimmerStats\".\"suitSize\"";
protoArray["14"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suitType", "m_strTable", "public.swimmerStats", "m_srcTableName", "public.swimmersInfo"));

protoArray["16"]["m_sql"] = "\"public\".\"swimmerStats\".\"suitType\"";
protoArray["16"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "public.swimmers";
protoArray["19"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("id");
protoArray["19"]["m_columns"].Add("first_name");
protoArray["19"]["m_columns"].Add("last_name");
protoArray["19"]["m_columns"].Add("birthdate");
protoArray["19"]["m_columns"].Add("swimmerStatId");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "\"public\".swimmers";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_sql"] = "";
protoArray["20"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["20"]["m_column"] = obj;
protoArray["20"]["m_contained"] = SettingsMap.GetArray();
protoArray["20"]["m_strCase"] = "";
protoArray["20"]["m_havingmode"] = false;
protoArray["20"]["m_inBrackets"] = false;
protoArray["20"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["20"]);

protoArray["18"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["18"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["22"] = SettingsMap.GetArray();
protoArray["22"]["m_link"] = "SQLL_INNERJOIN";
protoArray["23"] = SettingsMap.GetArray();
protoArray["23"]["m_strName"] = "public.swimmerStats";
protoArray["23"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["23"]["m_columns"] = SettingsMap.GetArray();
protoArray["23"]["m_columns"].Add("id");
protoArray["23"]["m_columns"].Add("suitSize");
protoArray["23"]["m_columns"].Add("suitType");
obj = new SQLTable(protoArray["23"]);

protoArray["22"]["m_table"] = obj;
protoArray["22"]["m_sql"] = "INNER JOIN \"public\".\"swimmerStats\" ON \"public\".swimmers.\"swimmerStatId\" = \"public\".\"swimmerStats\".id";
protoArray["22"]["m_alias"] = "";
protoArray["22"]["m_srcTableName"] = "public.swimmersInfo";
protoArray["24"] = SettingsMap.GetArray();
protoArray["24"]["m_sql"] = "\"public\".swimmers.\"swimmerStatId\" = \"public\".\"swimmerStats\".id";
protoArray["24"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "swimmerStatId", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmersInfo"));

protoArray["24"]["m_column"] = obj;
protoArray["24"]["m_contained"] = SettingsMap.GetArray();
protoArray["24"]["m_strCase"] = "= \"public\".\"swimmerStats\".id";
protoArray["24"]["m_havingmode"] = false;
protoArray["24"]["m_inBrackets"] = false;
protoArray["24"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["24"]);

protoArray["22"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["22"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "public.swimmersInfo";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmersInfo"] = obj;

				
		
			tdataArray["public_swimmersInfo"][".sqlquery"] = queryData_Array["public_swimmersInfo"];
			GlobalVars.tableEvents["public.swimmersInfo"] = new eventsBase();
			tdataArray["public_swimmersInfo"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmersInfo"] = tdataArray["public_swimmersInfo"];
		}
	}

}
