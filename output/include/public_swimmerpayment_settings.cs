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
	public static partial class Settings_public_swimmerpayment
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".truncateText"] = true;
			tdataArray["public_swimmerpayment"][".NumberOfChars"] = 80;
			tdataArray["public_swimmerpayment"][".ShortName"] = "public_swimmerpayment";
			tdataArray["public_swimmerpayment"][".OwnerID"] = "";
			tdataArray["public_swimmerpayment"][".OriginalTable"] = "public.swimmerpayment";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["public_swimmerpayment"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["public_swimmerpayment"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmerpayment"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmerpayment"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmerpayment"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmerpayment"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmerpayment"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmerpayment"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmerpayment"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmerpayment"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmerpayment"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmerpayment"]["English"]["id"] = "";
				placeHoldersArray["public_swimmerpayment"]["English"]["id"] = "";
				fieldLabelsArray["public_swimmerpayment"]["English"]["swimmer_id"] = "Swimmer Id";
				fieldToolTipsArray["public_swimmerpayment"]["English"]["swimmer_id"] = "";
				placeHoldersArray["public_swimmerpayment"]["English"]["swimmer_id"] = "";
				fieldLabelsArray["public_swimmerpayment"]["English"]["payment_type"] = "Payment Type";
				fieldToolTipsArray["public_swimmerpayment"]["English"]["payment_type"] = "";
				placeHoldersArray["public_swimmerpayment"]["English"]["payment_type"] = "";
				fieldLabelsArray["public_swimmerpayment"]["English"]["amount_paid"] = "Amount Paid";
				fieldToolTipsArray["public_swimmerpayment"]["English"]["amount_paid"] = "";
				placeHoldersArray["public_swimmerpayment"]["English"]["amount_paid"] = "";
				fieldLabelsArray["public_swimmerpayment"]["English"]["practice_time"] = "Practice Time";
				fieldToolTipsArray["public_swimmerpayment"]["English"]["practice_time"] = "";
				placeHoldersArray["public_swimmerpayment"]["English"]["practice_time"] = "";
				fieldLabelsArray["public_swimmerpayment"]["English"]["early_registration"] = "Early Registration";
				fieldToolTipsArray["public_swimmerpayment"]["English"]["early_registration"] = "";
				placeHoldersArray["public_swimmerpayment"]["English"]["early_registration"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmerpayment"]["English"])))
				{
					tdataArray["public_swimmerpayment"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmerpayment"][".NCSearch"] = true;
			tdataArray["public_swimmerpayment"][".shortTableName"] = "public_swimmerpayment";
			tdataArray["public_swimmerpayment"][".nSecOptions"] = 0;
			tdataArray["public_swimmerpayment"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmerpayment"][".entityType"] = 0;
			tdataArray["public_swimmerpayment"][".strOriginalTableName"] = "public.swimmerpayment";
			tdataArray["public_swimmerpayment"][".showAddInPopup"] = false;
			tdataArray["public_swimmerpayment"][".showEditInPopup"] = false;
			tdataArray["public_swimmerpayment"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmerpayment"][".listAjax"] = false;
			tdataArray["public_swimmerpayment"][".listAjax"] = false;
			tdataArray["public_swimmerpayment"][".audit"] = false;
			tdataArray["public_swimmerpayment"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmerpayment"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmerpayment"][".edit"] = true;
				tdataArray["public_swimmerpayment"][".afterEditAction"] = 1;
				tdataArray["public_swimmerpayment"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmerpayment"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmerpayment"][".add"] = true;
				tdataArray["public_swimmerpayment"][".afterAddAction"] = 1;
				tdataArray["public_swimmerpayment"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmerpayment"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmerpayment"][".list"] = true;
			}
			tdataArray["public_swimmerpayment"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmerpayment"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmerpayment"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmerpayment"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmerpayment"][".printFriendly"] = true;
			}
			tdataArray["public_swimmerpayment"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmerpayment"][".allowShowHideFields"] = true;
			tdataArray["public_swimmerpayment"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmerpayment"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmerpayment"][".rowHighlite"] = true;


			tdataArray["public_swimmerpayment"][".flexibleSearch"] = true;
			tdataArray["public_swimmerpayment"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmerpayment"][".buttonsAdded"] = false;
			tdataArray["public_swimmerpayment"][".addPageEvents"] = false;
			tdataArray["public_swimmerpayment"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmerpayment"][".badgeColor"] = "7B68EE";
			tdataArray["public_swimmerpayment"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmerpayment"][".googleLikeFields"].Add("swimmer_id");
			tdataArray["public_swimmerpayment"][".googleLikeFields"].Add("payment_type");
			tdataArray["public_swimmerpayment"][".googleLikeFields"].Add("amount_paid");
			tdataArray["public_swimmerpayment"][".googleLikeFields"].Add("practice_time");
			tdataArray["public_swimmerpayment"][".googleLikeFields"].Add("early_registration");
			tdataArray["public_swimmerpayment"][".tableType"] = "list";
			tdataArray["public_swimmerpayment"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmerpayment"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmerpayment"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmerpayment"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmerpayment"][".geocodingEnabled"] = false;
			tdataArray["public_swimmerpayment"][".pageSize"] = 20;
			tdataArray["public_swimmerpayment"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmerpayment"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmerpayment"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmerpayment"][".sqlHead"] = "SELECT id,  	swimmer_id,  	payment_type,  	amount_paid,  	practice_time,  	early_registration";
			tdataArray["public_swimmerpayment"][".sqlFrom"] = "FROM \"public\".swimmerpayment";
			tdataArray["public_swimmerpayment"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmerpayment"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmerpayment"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmerpayment"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmerpayment"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmerpayment"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmerpayment"].Add("id");
			tdataArray["public_swimmerpayment"][".Keys"] = tableKeysArray["public_swimmerpayment"];
			tdataArray["public_swimmerpayment"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayment","id");
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
			tdataArray["public_swimmerpayment"]["id"] = fdata;
			tdataArray["public_swimmerpayment"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "swimmer_id";
			fdata["GoodName"] = "swimmer_id";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayment","swimmer_id");
			fdata["FieldType"] = 3;
			fdata["strField"] = "swimmer_id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "swimmer_id";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["LookupType"] = 2;
			edata["LookupTable"] = "public.swimmer";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "id";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["IsRequired"] = true;
			edata["acceptFileTypes"] = ".+$";
			edata["maxNumberOfFiles"] = 1;
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
			tdataArray["public_swimmerpayment"]["swimmer_id"] = fdata;
			tdataArray["public_swimmerpayment"][".searchableFields"].Add("swimmer_id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "payment_type";
			fdata["GoodName"] = "payment_type";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayment","payment_type");
			fdata["FieldType"] = 200;
			fdata["strField"] = "payment_type";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "payment_type";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=20");
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
			tdataArray["public_swimmerpayment"]["payment_type"] = fdata;
			tdataArray["public_swimmerpayment"][".searchableFields"].Add("payment_type");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "amount_paid";
			fdata["GoodName"] = "amount_paid";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayment","amount_paid");
			fdata["FieldType"] = 200;
			fdata["strField"] = "amount_paid";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "amount_paid";
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
			tdataArray["public_swimmerpayment"]["amount_paid"] = fdata;
			tdataArray["public_swimmerpayment"][".searchableFields"].Add("amount_paid");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "practice_time";
			fdata["GoodName"] = "practice_time";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayment","practice_time");
			fdata["FieldType"] = 200;
			fdata["strField"] = "practice_time";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "practice_time";
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
			tdataArray["public_swimmerpayment"]["practice_time"] = fdata;
			tdataArray["public_swimmerpayment"][".searchableFields"].Add("practice_time");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "early_registration";
			fdata["GoodName"] = "early_registration";
			fdata["ownerTable"] = "public.swimmerpayment";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmerpayment","early_registration");
			fdata["FieldType"] = 11;
			fdata["strField"] = "early_registration";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "early_registration";
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
			tdataArray["public_swimmerpayment"]["early_registration"] = fdata;
			tdataArray["public_swimmerpayment"][".searchableFields"].Add("early_registration");
			GlobalVars.tables_data["public.swimmerpayment"] = tdataArray["public_swimmerpayment"];
			GlobalVars.field_labels["public_swimmerpayment"] = fieldLabelsArray["public_swimmerpayment"];
			GlobalVars.fieldToolTips["public_swimmerpayment"] = fieldToolTipsArray["public_swimmerpayment"];
			GlobalVars.placeHolders["public_swimmerpayment"] = placeHoldersArray["public_swimmerpayment"];
			GlobalVars.page_titles["public_swimmerpayment"] = pageTitlesArray["public_swimmerpayment"];
			GlobalVars.detailsTablesData["public.swimmerpayment"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayment"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "public.swimmer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "public.swimmer";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "public_swimmer";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["public.swimmerpayment"][0] = masterParams;
			GlobalVars.masterTablesData["public.swimmerpayment"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayment"][0]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmerpayment"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayment"][0]["detailKeys"].Add("swimmer_id");


			strOriginalDetailsTable = "public.swimmer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "Not Paid - Report";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "Not_Paid___Report";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			masterParams["type"] = Constants.PAGE_REPORT;
			GlobalVars.masterTablesData["public.swimmerpayment"][1] = masterParams;
			GlobalVars.masterTablesData["public.swimmerpayment"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayment"][1]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmerpayment"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmerpayment"][1]["detailKeys"].Add("swimmer_id");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	swimmer_id,  	payment_type,  	amount_paid,  	practice_time,  	early_registration";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmerpayment";
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmerpayment", "m_srcTableName", "public.swimmerpayment"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "swimmer_id", "m_strTable", "public.swimmerpayment", "m_srcTableName", "public.swimmerpayment"));

protoArray["8"]["m_sql"] = "swimmer_id";
protoArray["8"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "payment_type", "m_strTable", "public.swimmerpayment", "m_srcTableName", "public.swimmerpayment"));

protoArray["10"]["m_sql"] = "payment_type";
protoArray["10"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "amount_paid", "m_strTable", "public.swimmerpayment", "m_srcTableName", "public.swimmerpayment"));

protoArray["12"]["m_sql"] = "amount_paid";
protoArray["12"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "practice_time", "m_strTable", "public.swimmerpayment", "m_srcTableName", "public.swimmerpayment"));

protoArray["14"]["m_sql"] = "practice_time";
protoArray["14"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "early_registration", "m_strTable", "public.swimmerpayment", "m_srcTableName", "public.swimmerpayment"));

protoArray["16"]["m_sql"] = "early_registration";
protoArray["16"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "public.swimmerpayment";
protoArray["19"]["m_srcTableName"] = "public.swimmerpayment";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("id");
protoArray["19"]["m_columns"].Add("swimmer_id");
protoArray["19"]["m_columns"].Add("payment_type");
protoArray["19"]["m_columns"].Add("amount_paid");
protoArray["19"]["m_columns"].Add("practice_time");
protoArray["19"]["m_columns"].Add("early_registration");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "\"public\".swimmerpayment";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "public.swimmerpayment";
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
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "public.swimmerpayment";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmerpayment"] = obj;

				
		
			tdataArray["public_swimmerpayment"][".sqlquery"] = queryData_Array["public_swimmerpayment"];
			GlobalVars.tableEvents["public.swimmerpayment"] = new eventsBase();
			tdataArray["public_swimmerpayment"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmerpayment"] = tdataArray["public_swimmerpayment"];
		}
	}

}
