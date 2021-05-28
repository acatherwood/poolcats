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
	public static partial class Settings_public_swimmerpayments
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".truncateText"] = true;
			tdataArray["public_swimmerpayments"][".NumberOfChars"] = 80;
			tdataArray["public_swimmerpayments"][".ShortName"] = "public_swimmerpayments";
			tdataArray["public_swimmerpayments"][".OwnerID"] = "";
			tdataArray["public_swimmerpayments"][".OriginalTable"] = "public.swimmerpayments";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["public_swimmerpayments"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["public_swimmerpayments"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmerpayments"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmerpayments"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmerpayments"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmerpayments"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmerpayments"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmerpayments"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmerpayments"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmerpayments"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmerpayments"]["English"]["payment_type"] = "Payment Type";
				fieldToolTipsArray["public_swimmerpayments"]["English"]["payment_type"] = "";
				placeHoldersArray["public_swimmerpayments"]["English"]["payment_type"] = "cash/check";
				fieldLabelsArray["public_swimmerpayments"]["English"]["amount_paid"] = "Amount Paid";
				fieldToolTipsArray["public_swimmerpayments"]["English"]["amount_paid"] = "";
				placeHoldersArray["public_swimmerpayments"]["English"]["amount_paid"] = "";
				fieldLabelsArray["public_swimmerpayments"]["English"]["early_registration"] = "Early Registration";
				fieldToolTipsArray["public_swimmerpayments"]["English"]["early_registration"] = "";
				placeHoldersArray["public_swimmerpayments"]["English"]["early_registration"] = "";
				fieldLabelsArray["public_swimmerpayments"]["English"]["practice_time"] = "Practice Time";
				fieldToolTipsArray["public_swimmerpayments"]["English"]["practice_time"] = "";
				placeHoldersArray["public_swimmerpayments"]["English"]["practice_time"] = "";
				fieldLabelsArray["public_swimmerpayments"]["English"]["swimmer"] = "Swimmer";
				fieldToolTipsArray["public_swimmerpayments"]["English"]["swimmer"] = "";
				placeHoldersArray["public_swimmerpayments"]["English"]["swimmer"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmerpayments"]["English"])))
				{
					tdataArray["public_swimmerpayments"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmerpayments"][".NCSearch"] = true;
			tdataArray["public_swimmerpayments"][".shortTableName"] = "public_swimmerpayments";
			tdataArray["public_swimmerpayments"][".nSecOptions"] = 0;
			tdataArray["public_swimmerpayments"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmerpayments"][".entityType"] = 0;
			tdataArray["public_swimmerpayments"][".strOriginalTableName"] = "public.swimmerpayments";
			tdataArray["public_swimmerpayments"][".showAddInPopup"] = false;
			tdataArray["public_swimmerpayments"][".showEditInPopup"] = false;
			tdataArray["public_swimmerpayments"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmerpayments"][".listAjax"] = false;
			tdataArray["public_swimmerpayments"][".listAjax"] = false;
			tdataArray["public_swimmerpayments"][".audit"] = false;
			tdataArray["public_swimmerpayments"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmerpayments"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmerpayments"][".edit"] = true;
				tdataArray["public_swimmerpayments"][".afterEditAction"] = 1;
				tdataArray["public_swimmerpayments"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmerpayments"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmerpayments"][".add"] = true;
				tdataArray["public_swimmerpayments"][".afterAddAction"] = 1;
				tdataArray["public_swimmerpayments"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmerpayments"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmerpayments"][".list"] = true;
			}
			tdataArray["public_swimmerpayments"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmerpayments"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmerpayments"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmerpayments"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmerpayments"][".printFriendly"] = true;
			}
			tdataArray["public_swimmerpayments"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmerpayments"][".allowShowHideFields"] = true;
			tdataArray["public_swimmerpayments"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmerpayments"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmerpayments"][".rowHighlite"] = true;


			tdataArray["public_swimmerpayments"][".flexibleSearch"] = true;
			tdataArray["public_swimmerpayments"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmerpayments"][".buttonsAdded"] = false;
			tdataArray["public_swimmerpayments"][".addPageEvents"] = false;
			tdataArray["public_swimmerpayments"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmerpayments"][".badgeColor"] = "6493EA";
			tdataArray["public_swimmerpayments"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".googleLikeFields"].Add("payment_type");
			tdataArray["public_swimmerpayments"][".googleLikeFields"].Add("amount_paid");
			tdataArray["public_swimmerpayments"][".googleLikeFields"].Add("practice_time");
			tdataArray["public_swimmerpayments"][".googleLikeFields"].Add("early_registration");
			tdataArray["public_swimmerpayments"][".googleLikeFields"].Add("swimmer");
			tdataArray["public_swimmerpayments"][".tableType"] = "list";
			tdataArray["public_swimmerpayments"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmerpayments"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmerpayments"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmerpayments"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmerpayments"][".geocodingEnabled"] = false;
			tdataArray["public_swimmerpayments"][".pageSize"] = 20;
			tdataArray["public_swimmerpayments"][".warnLeavingPages"] = true;
			tstrOrderBy = "order by swimmer";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmerpayments"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmerpayments"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".orderindexes"].Add(new XVar(0, 5, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "CONCAT(\"public\".swimmers.first_name, ' ', \"public\".swimmers.last_name)"));
			tdataArray["public_swimmerpayments"][".sqlHead"] = "SELECT \"public\".swimmerpayments.payment_type,  \"public\".swimmerpayments.amount_paid,  \"public\".swimmerpayments.practice_time,  \"public\".swimmerpayments.early_registration,  CONCAT(\"public\".swimmers.first_name, ' ', \"public\".swimmers.last_name) AS swimmer";
			tdataArray["public_swimmerpayments"][".sqlFrom"] = "FROM \"public\".swimmerpayments  INNER JOIN \"public\".swimmers ON \"public\".swimmers.id = \"public\".swimmerpayments.swimmer_id";
			tdataArray["public_swimmerpayments"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmerpayments"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmerpayments"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmerpayments"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmerpayments"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmerpayments"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayments"][".Keys"] = tableKeysArray["public_swimmerpayments"];
			tdataArray["public_swimmerpayments"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "payment_type";
			fdata["GoodName"] = "payment_type";
			fdata["ownerTable"] = "public.swimmerpayments";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayments","payment_type");
			fdata["FieldType"] = 200;
			fdata["strField"] = "payment_type";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmerpayments.payment_type";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=20");
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["public_swimmerpayments"]["payment_type"] = fdata;
			tdataArray["public_swimmerpayments"][".searchableFields"].Add("payment_type");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "amount_paid";
			fdata["GoodName"] = "amount_paid";
			fdata["ownerTable"] = "public.swimmerpayments";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayments","amount_paid");
			fdata["FieldType"] = 200;
			fdata["strField"] = "amount_paid";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmerpayments.amount_paid";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Currency");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=200");
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
			tdataArray["public_swimmerpayments"]["amount_paid"] = fdata;
			tdataArray["public_swimmerpayments"][".searchableFields"].Add("amount_paid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "practice_time";
			fdata["GoodName"] = "practice_time";
			fdata["ownerTable"] = "public.swimmerpayments";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayments","practice_time");
			fdata["FieldType"] = 200;
			fdata["strField"] = "practice_time";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmerpayments.practice_time";
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
			tdataArray["public_swimmerpayments"]["practice_time"] = fdata;
			tdataArray["public_swimmerpayments"][".searchableFields"].Add("practice_time");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "early_registration";
			fdata["GoodName"] = "early_registration";
			fdata["ownerTable"] = "public.swimmerpayments";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayments","early_registration");
			fdata["FieldType"] = 11;
			fdata["strField"] = "early_registration";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmerpayments.early_registration";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Checkbox");
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Checkbox");
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterFormat"] = "Options list";
			fdata["showCollapsed"] = false;
			fdata["filterCheckedMessageType"] = "Text";
			fdata["filterCheckedMessageText"] = "Checked";
			fdata["filterUncheckedMessageType"] = "Text";
			fdata["filterUncheckedMessageText"] = "Unchecked";
			tdataArray["public_swimmerpayments"]["early_registration"] = fdata;
			tdataArray["public_swimmerpayments"][".searchableFields"].Add("early_registration");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "swimmer";
			fdata["GoodName"] = "swimmer";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayments","swimmer");
			fdata["FieldType"] = 201;
			fdata["strField"] = "swimmer";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "CONCAT(\"public\".swimmers.first_name, ' ', \"public\".swimmers.last_name)";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
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
			tdataArray["public_swimmerpayments"]["swimmer"] = fdata;
			tdataArray["public_swimmerpayments"][".searchableFields"].Add("swimmer");
			GlobalVars.tables_data["public.swimmerpayments"] = tdataArray["public_swimmerpayments"];
			GlobalVars.field_labels["public_swimmerpayments"] = fieldLabelsArray["public_swimmerpayments"];
			GlobalVars.fieldToolTips["public_swimmerpayments"] = fieldToolTipsArray["public_swimmerpayments"];
			GlobalVars.placeHolders["public_swimmerpayments"] = placeHoldersArray["public_swimmerpayments"];
			GlobalVars.page_titles["public_swimmerpayments"] = pageTitlesArray["public_swimmerpayments"];
			GlobalVars.detailsTablesData["public.swimmerpayments"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayments"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "public.swimmers";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "public.swimmers";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "public_swimmers";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["public.swimmerpayments"][0] = masterParams;
			GlobalVars.masterTablesData["public.swimmerpayments"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayments"][0]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmerpayments"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayments"][0]["detailKeys"].Add("swimmer_id");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "\"public\".swimmerpayments.payment_type,  \"public\".swimmerpayments.amount_paid,  \"public\".swimmerpayments.practice_time,  \"public\".swimmerpayments.early_registration,  CONCAT(\"public\".swimmers.first_name, ' ', \"public\".swimmers.last_name) AS swimmer";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmerpayments  INNER JOIN \"public\".swimmers ON \"public\".swimmers.id = \"public\".swimmerpayments.swimmer_id";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "order by swimmer";
	
		
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
obj = new SQLField(new XVar("m_strName", "payment_type", "m_strTable", "public.swimmerpayments", "m_srcTableName", "public.swimmerpayments"));

protoArray["6"]["m_sql"] = "\"public\".swimmerpayments.payment_type";
protoArray["6"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "amount_paid", "m_strTable", "public.swimmerpayments", "m_srcTableName", "public.swimmerpayments"));

protoArray["8"]["m_sql"] = "\"public\".swimmerpayments.amount_paid";
protoArray["8"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "practice_time", "m_strTable", "public.swimmerpayments", "m_srcTableName", "public.swimmerpayments"));

protoArray["10"]["m_sql"] = "\"public\".swimmerpayments.practice_time";
protoArray["10"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "early_registration", "m_strTable", "public.swimmerpayments", "m_srcTableName", "public.swimmerpayments"));

protoArray["12"]["m_sql"] = "\"public\".swimmerpayments.early_registration";
protoArray["12"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_functiontype"] = "SQLF_CUSTOM";
protoArray["15"]["m_arguments"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "\"public\".swimmers.first_name"));

protoArray["15"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "' '"));

protoArray["15"]["m_arguments"].Add(obj);
obj = new SQLNonParsed(new XVar("m_sql", "\"public\".swimmers.last_name"));

protoArray["15"]["m_arguments"].Add(obj);
protoArray["15"]["m_strFunctionName"] = "CONCAT";
obj = new SQLFunctionCall(protoArray["15"]);

protoArray["14"]["m_sql"] = "CONCAT(\"public\".swimmers.first_name, ' ', \"public\".swimmers.last_name)";
protoArray["14"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "swimmer";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_link"] = "SQLL_MAIN";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_strName"] = "public.swimmerpayments";
protoArray["20"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["20"]["m_columns"] = SettingsMap.GetArray();
protoArray["20"]["m_columns"].Add("id");
protoArray["20"]["m_columns"].Add("swimmer_id");
protoArray["20"]["m_columns"].Add("payment_type");
protoArray["20"]["m_columns"].Add("amount_paid");
protoArray["20"]["m_columns"].Add("practice_time");
protoArray["20"]["m_columns"].Add("early_registration");
obj = new SQLTable(protoArray["20"]);

protoArray["19"]["m_table"] = obj;
protoArray["19"]["m_sql"] = "\"public\".swimmerpayments";
protoArray["19"]["m_alias"] = "";
protoArray["19"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_sql"] = "";
protoArray["21"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["21"]["m_column"] = obj;
protoArray["21"]["m_contained"] = SettingsMap.GetArray();
protoArray["21"]["m_strCase"] = "";
protoArray["21"]["m_havingmode"] = false;
protoArray["21"]["m_inBrackets"] = false;
protoArray["21"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["21"]);

protoArray["19"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["19"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["23"] = SettingsMap.GetArray();
protoArray["23"]["m_link"] = "SQLL_INNERJOIN";
protoArray["24"] = SettingsMap.GetArray();
protoArray["24"]["m_strName"] = "public.swimmers";
protoArray["24"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["24"]["m_columns"] = SettingsMap.GetArray();
protoArray["24"]["m_columns"].Add("id");
protoArray["24"]["m_columns"].Add("first_name");
protoArray["24"]["m_columns"].Add("last_name");
protoArray["24"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["24"]);

protoArray["23"]["m_table"] = obj;
protoArray["23"]["m_sql"] = "INNER JOIN \"public\".swimmers ON \"public\".swimmers.id = \"public\".swimmerpayments.swimmer_id";
protoArray["23"]["m_alias"] = "";
protoArray["23"]["m_srcTableName"] = "public.swimmerpayments";
protoArray["25"] = SettingsMap.GetArray();
protoArray["25"]["m_sql"] = "\"public\".swimmers.id = \"public\".swimmerpayments.swimmer_id";
protoArray["25"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmers", "m_srcTableName", "public.swimmerpayments"));

protoArray["25"]["m_column"] = obj;
protoArray["25"]["m_contained"] = SettingsMap.GetArray();
protoArray["25"]["m_strCase"] = "= \"public\".swimmerpayments.swimmer_id";
protoArray["25"]["m_havingmode"] = false;
protoArray["25"]["m_inBrackets"] = false;
protoArray["25"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["25"]);

protoArray["23"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["23"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["27"] = SettingsMap.GetArray();
obj = new SQLNonParsed(new XVar("m_sql", "swimmer"));

protoArray["27"]["m_column"] = obj;
protoArray["27"]["m_bAsc"] = 1;
protoArray["27"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["27"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "public.swimmerpayments";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmerpayments"] = obj;

				
		
			tdataArray["public_swimmerpayments"][".sqlquery"] = queryData_Array["public_swimmerpayments"];
			GlobalVars.tableEvents["public.swimmerpayments"] = new eventsBase();
			tdataArray["public_swimmerpayments"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmerpayments"] = tdataArray["public_swimmerpayments"];
		}
	}

}
