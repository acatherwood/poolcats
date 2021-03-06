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
	public static partial class Settings_public_swimmercontact
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".truncateText"] = true;
			tdataArray["public_swimmercontact"][".NumberOfChars"] = 80;
			tdataArray["public_swimmercontact"][".ShortName"] = "public_swimmercontact";
			tdataArray["public_swimmercontact"][".OwnerID"] = "";
			tdataArray["public_swimmercontact"][".OriginalTable"] = "public.swimmercontact";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\"}"));
			tdataArray["public_swimmercontact"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"]}")));
			tdataArray["public_swimmercontact"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmercontact"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmercontact"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmercontact"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmercontact"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmercontact"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmercontact"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmercontact"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmercontact"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmercontact"]["English"]["parent_name"] = "Parent Name";
				fieldToolTipsArray["public_swimmercontact"]["English"]["parent_name"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["parent_name"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["address"] = "Address";
				fieldToolTipsArray["public_swimmercontact"]["English"]["address"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["address"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["city"] = "City";
				fieldToolTipsArray["public_swimmercontact"]["English"]["city"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["city"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["state"] = "State";
				fieldToolTipsArray["public_swimmercontact"]["English"]["state"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["state"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["zip_code"] = "Zip Code";
				fieldToolTipsArray["public_swimmercontact"]["English"]["zip_code"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["zip_code"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["phone"] = "Phone";
				fieldToolTipsArray["public_swimmercontact"]["English"]["phone"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["phone"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["email"] = "Email";
				fieldToolTipsArray["public_swimmercontact"]["English"]["email"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["email"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["emergency_contact"] = "Emergency Contact";
				fieldToolTipsArray["public_swimmercontact"]["English"]["emergency_contact"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["emergency_contact"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["swimmer_id"] = "Swimmer Id";
				fieldToolTipsArray["public_swimmercontact"]["English"]["swimmer_id"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["swimmer_id"] = "";
				fieldLabelsArray["public_swimmercontact"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmercontact"]["English"]["id"] = "";
				placeHoldersArray["public_swimmercontact"]["English"]["id"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmercontact"]["English"])))
				{
					tdataArray["public_swimmercontact"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmercontact"][".NCSearch"] = true;
			tdataArray["public_swimmercontact"][".shortTableName"] = "public_swimmercontact";
			tdataArray["public_swimmercontact"][".nSecOptions"] = 0;
			tdataArray["public_swimmercontact"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmercontact"][".entityType"] = 0;
			tdataArray["public_swimmercontact"][".strOriginalTableName"] = "public.swimmercontact";
			tdataArray["public_swimmercontact"][".showAddInPopup"] = false;
			tdataArray["public_swimmercontact"][".showEditInPopup"] = false;
			tdataArray["public_swimmercontact"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmercontact"][".listAjax"] = false;
			tdataArray["public_swimmercontact"][".listAjax"] = false;
			tdataArray["public_swimmercontact"][".audit"] = false;
			tdataArray["public_swimmercontact"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmercontact"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmercontact"][".edit"] = true;
				tdataArray["public_swimmercontact"][".afterEditAction"] = 1;
				tdataArray["public_swimmercontact"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmercontact"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmercontact"][".add"] = true;
				tdataArray["public_swimmercontact"][".afterAddAction"] = 1;
				tdataArray["public_swimmercontact"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmercontact"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmercontact"][".list"] = true;
			}
			tdataArray["public_swimmercontact"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmercontact"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmercontact"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmercontact"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmercontact"][".printFriendly"] = true;
			}
			tdataArray["public_swimmercontact"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmercontact"][".allowShowHideFields"] = true;
			tdataArray["public_swimmercontact"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmercontact"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmercontact"][".rowHighlite"] = true;


			tdataArray["public_swimmercontact"][".flexibleSearch"] = true;
			tdataArray["public_swimmercontact"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmercontact"][".buttonsAdded"] = false;
			tdataArray["public_swimmercontact"][".addPageEvents"] = false;
			tdataArray["public_swimmercontact"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmercontact"][".badgeColor"] = "00C2C5";
			tdataArray["public_swimmercontact"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("swimmer_id");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("parent_name");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("address");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("city");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("state");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("zip_code");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("phone");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("email");
			tdataArray["public_swimmercontact"][".googleLikeFields"].Add("emergency_contact");
			tdataArray["public_swimmercontact"][".tableType"] = "list";
			tdataArray["public_swimmercontact"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmercontact"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmercontact"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmercontact"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmercontact"][".geocodingEnabled"] = false;
			tdataArray["public_swimmercontact"][".pageSize"] = 20;
			tdataArray["public_swimmercontact"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmercontact"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmercontact"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmercontact"][".sqlHead"] = "SELECT id,  	swimmer_id,  	parent_name,  	address,  	city,  	\"state\",  	zip_code,  	phone,  	email,  	emergency_contact";
			tdataArray["public_swimmercontact"][".sqlFrom"] = "FROM \"public\".swimmercontact";
			tdataArray["public_swimmercontact"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmercontact"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmercontact"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmercontact"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmercontact"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmercontact"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmercontact"].Add("id");
			tdataArray["public_swimmercontact"][".Keys"] = tableKeysArray["public_swimmercontact"];
			tdataArray["public_swimmercontact"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","id");
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
			tdataArray["public_swimmercontact"]["id"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "swimmer_id";
			fdata["GoodName"] = "swimmer_id";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","swimmer_id");
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
			tdataArray["public_swimmercontact"]["swimmer_id"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("swimmer_id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "parent_name";
			fdata["GoodName"] = "parent_name";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","parent_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "parent_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "parent_name";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=500");
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
			tdataArray["public_swimmercontact"]["parent_name"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("parent_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "address";
			fdata["GoodName"] = "address";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","address");
			fdata["FieldType"] = 200;
			fdata["strField"] = "address";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "address";
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
			tdataArray["public_swimmercontact"]["address"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("address");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "city";
			fdata["GoodName"] = "city";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","city");
			fdata["FieldType"] = 200;
			fdata["strField"] = "city";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "city";
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
			tdataArray["public_swimmercontact"]["city"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("city");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "state";
			fdata["GoodName"] = "state";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","state");
			fdata["FieldType"] = 200;
			fdata["strField"] = "state";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"state\"";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=2");
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
			tdataArray["public_swimmercontact"]["state"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("state");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "zip_code";
			fdata["GoodName"] = "zip_code";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","zip_code");
			fdata["FieldType"] = 3;
			fdata["strField"] = "zip_code";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "zip_code";
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
			tdataArray["public_swimmercontact"]["zip_code"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("zip_code");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 8;
			fdata["strName"] = "phone";
			fdata["GoodName"] = "phone";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","phone");
			fdata["FieldType"] = 200;
			fdata["strField"] = "phone";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "phone";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=1000");
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
			tdataArray["public_swimmercontact"]["phone"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("phone");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 9;
			fdata["strName"] = "email";
			fdata["GoodName"] = "email";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","email");
			fdata["FieldType"] = 200;
			fdata["strField"] = "email";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "email";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=1000");
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
			tdataArray["public_swimmercontact"]["email"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("email");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 10;
			fdata["strName"] = "emergency_contact";
			fdata["GoodName"] = "emergency_contact";
			fdata["ownerTable"] = "public.swimmercontact";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmercontact","emergency_contact");
			fdata["FieldType"] = 200;
			fdata["strField"] = "emergency_contact";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "emergency_contact";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=1000");
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
			tdataArray["public_swimmercontact"]["emergency_contact"] = fdata;
			tdataArray["public_swimmercontact"][".searchableFields"].Add("emergency_contact");
			GlobalVars.tables_data["public.swimmercontact"] = tdataArray["public_swimmercontact"];
			GlobalVars.field_labels["public_swimmercontact"] = fieldLabelsArray["public_swimmercontact"];
			GlobalVars.fieldToolTips["public_swimmercontact"] = fieldToolTipsArray["public_swimmercontact"];
			GlobalVars.placeHolders["public_swimmercontact"] = placeHoldersArray["public_swimmercontact"];
			GlobalVars.page_titles["public_swimmercontact"] = pageTitlesArray["public_swimmercontact"];
			GlobalVars.detailsTablesData["public.swimmercontact"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmercontact"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "public.swimmer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "public.swimmer";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "public_swimmer";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["public.swimmercontact"][0] = masterParams;
			GlobalVars.masterTablesData["public.swimmercontact"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmercontact"][0]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmercontact"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmercontact"][0]["detailKeys"].Add("swimmer_id");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "id,  	swimmer_id,  	parent_name,  	address,  	city,  	\"state\",  	zip_code,  	phone,  	email,  	emergency_contact";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmercontact";
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
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["6"]["m_sql"] = "id";
protoArray["6"]["m_srcTableName"] = "public.swimmercontact";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "swimmer_id", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["8"]["m_sql"] = "swimmer_id";
protoArray["8"]["m_srcTableName"] = "public.swimmercontact";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "parent_name", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["10"]["m_sql"] = "parent_name";
protoArray["10"]["m_srcTableName"] = "public.swimmercontact";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "address", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["12"]["m_sql"] = "address";
protoArray["12"]["m_srcTableName"] = "public.swimmercontact";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "city", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["14"]["m_sql"] = "city";
protoArray["14"]["m_srcTableName"] = "public.swimmercontact";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "state", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["16"]["m_sql"] = "\"state\"";
protoArray["16"]["m_srcTableName"] = "public.swimmercontact";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "zip_code", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["18"]["m_sql"] = "zip_code";
protoArray["18"]["m_srcTableName"] = "public.swimmercontact";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["20"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "phone", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["20"]["m_sql"] = "phone";
protoArray["20"]["m_srcTableName"] = "public.swimmercontact";
protoArray["20"]["m_expr"] = obj;
protoArray["20"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["20"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["22"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "email", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["22"]["m_sql"] = "email";
protoArray["22"]["m_srcTableName"] = "public.swimmercontact";
protoArray["22"]["m_expr"] = obj;
protoArray["22"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["22"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["24"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "emergency_contact", "m_strTable", "public.swimmercontact", "m_srcTableName", "public.swimmercontact"));

protoArray["24"]["m_sql"] = "emergency_contact";
protoArray["24"]["m_srcTableName"] = "public.swimmercontact";
protoArray["24"]["m_expr"] = obj;
protoArray["24"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["24"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["26"] = SettingsMap.GetArray();
protoArray["26"]["m_link"] = "SQLL_MAIN";
protoArray["27"] = SettingsMap.GetArray();
protoArray["27"]["m_strName"] = "public.swimmercontact";
protoArray["27"]["m_srcTableName"] = "public.swimmercontact";
protoArray["27"]["m_columns"] = SettingsMap.GetArray();
protoArray["27"]["m_columns"].Add("id");
protoArray["27"]["m_columns"].Add("swimmer_id");
protoArray["27"]["m_columns"].Add("parent_name");
protoArray["27"]["m_columns"].Add("address");
protoArray["27"]["m_columns"].Add("city");
protoArray["27"]["m_columns"].Add("state");
protoArray["27"]["m_columns"].Add("zip_code");
protoArray["27"]["m_columns"].Add("phone");
protoArray["27"]["m_columns"].Add("email");
protoArray["27"]["m_columns"].Add("emergency_contact");
obj = new SQLTable(protoArray["27"]);

protoArray["26"]["m_table"] = obj;
protoArray["26"]["m_sql"] = "\"public\".swimmercontact";
protoArray["26"]["m_alias"] = "";
protoArray["26"]["m_srcTableName"] = "public.swimmercontact";
protoArray["28"] = SettingsMap.GetArray();
protoArray["28"]["m_sql"] = "";
protoArray["28"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["28"]["m_column"] = obj;
protoArray["28"]["m_contained"] = SettingsMap.GetArray();
protoArray["28"]["m_strCase"] = "";
protoArray["28"]["m_havingmode"] = false;
protoArray["28"]["m_inBrackets"] = false;
protoArray["28"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["28"]);

protoArray["26"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["26"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "public.swimmercontact";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmercontact"] = obj;

				
		
			tdataArray["public_swimmercontact"][".sqlquery"] = queryData_Array["public_swimmercontact"];
			GlobalVars.tableEvents["public.swimmercontact"] = new eventsBase();
			tdataArray["public_swimmercontact"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmercontact"] = tdataArray["public_swimmercontact"];
		}
	}

}
