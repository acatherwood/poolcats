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
	public static partial class Settings_public_swimmersuit
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".truncateText"] = true;
			tdataArray["public_swimmersuit"][".NumberOfChars"] = 80;
			tdataArray["public_swimmersuit"][".ShortName"] = "public_swimmersuit";
			tdataArray["public_swimmersuit"][".OwnerID"] = "";
			tdataArray["public_swimmersuit"][".OriginalTable"] = "public.swimmersuit";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"list\":\"list\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["public_swimmersuit"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"list\":[\"list\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["public_swimmersuit"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["public_swimmersuit"] = SettingsMap.GetArray();
			fieldToolTipsArray["public_swimmersuit"] = SettingsMap.GetArray();
			pageTitlesArray["public_swimmersuit"] = SettingsMap.GetArray();
			placeHoldersArray["public_swimmersuit"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["public_swimmersuit"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["public_swimmersuit"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["public_swimmersuit"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["public_swimmersuit"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["public_swimmersuit"]["English"]["suit_type"] = "Suit Type";
				fieldToolTipsArray["public_swimmersuit"]["English"]["suit_type"] = "";
				placeHoldersArray["public_swimmersuit"]["English"]["suit_type"] = "";
				fieldLabelsArray["public_swimmersuit"]["English"]["suit_size"] = "Suit Size";
				fieldToolTipsArray["public_swimmersuit"]["English"]["suit_size"] = "";
				placeHoldersArray["public_swimmersuit"]["English"]["suit_size"] = "";
				fieldLabelsArray["public_swimmersuit"]["English"]["swimmer_id"] = "Swimmer Id";
				fieldToolTipsArray["public_swimmersuit"]["English"]["swimmer_id"] = "";
				placeHoldersArray["public_swimmersuit"]["English"]["swimmer_id"] = "";
				fieldLabelsArray["public_swimmersuit"]["English"]["id"] = "Id";
				fieldToolTipsArray["public_swimmersuit"]["English"]["id"] = "";
				placeHoldersArray["public_swimmersuit"]["English"]["id"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["public_swimmersuit"]["English"])))
				{
					tdataArray["public_swimmersuit"][".isUseToolTips"] = true;
				}
			}
			tdataArray["public_swimmersuit"][".NCSearch"] = true;
			tdataArray["public_swimmersuit"][".shortTableName"] = "public_swimmersuit";
			tdataArray["public_swimmersuit"][".nSecOptions"] = 0;
			tdataArray["public_swimmersuit"][".mainTableOwnerID"] = "";
			tdataArray["public_swimmersuit"][".entityType"] = 0;
			tdataArray["public_swimmersuit"][".strOriginalTableName"] = "public.swimmersuit";
			tdataArray["public_swimmersuit"][".showAddInPopup"] = false;
			tdataArray["public_swimmersuit"][".showEditInPopup"] = false;
			tdataArray["public_swimmersuit"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["public_swimmersuit"][".listAjax"] = false;
			tdataArray["public_swimmersuit"][".listAjax"] = false;
			tdataArray["public_swimmersuit"][".audit"] = false;
			tdataArray["public_swimmersuit"][".locking"] = false;
			GlobalVars.pages = tdataArray["public_swimmersuit"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["public_swimmersuit"][".edit"] = true;
				tdataArray["public_swimmersuit"][".afterEditAction"] = 1;
				tdataArray["public_swimmersuit"][".closePopupAfterEdit"] = 1;
				tdataArray["public_swimmersuit"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["public_swimmersuit"][".add"] = true;
				tdataArray["public_swimmersuit"][".afterAddAction"] = 1;
				tdataArray["public_swimmersuit"][".closePopupAfterAdd"] = 1;
				tdataArray["public_swimmersuit"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["public_swimmersuit"][".list"] = true;
			}
			tdataArray["public_swimmersuit"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["public_swimmersuit"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["public_swimmersuit"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["public_swimmersuit"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["public_swimmersuit"][".printFriendly"] = true;
			}
			tdataArray["public_swimmersuit"][".showSimpleSearchOptions"] = true;
			tdataArray["public_swimmersuit"][".allowShowHideFields"] = true;
			tdataArray["public_swimmersuit"][".allowFieldsReordering"] = true;
			tdataArray["public_swimmersuit"][".isUseAjaxSuggest"] = true;
			tdataArray["public_swimmersuit"][".rowHighlite"] = true;


			tdataArray["public_swimmersuit"][".flexibleSearch"] = true;
			tdataArray["public_swimmersuit"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["public_swimmersuit"][".buttonsAdded"] = false;
			tdataArray["public_swimmersuit"][".addPageEvents"] = false;
			tdataArray["public_swimmersuit"][".isUseTimeForSearch"] = false;
			tdataArray["public_swimmersuit"][".badgeColor"] = "6b8e23";
			tdataArray["public_swimmersuit"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".googleLikeFields"].Add("suit_type");
			tdataArray["public_swimmersuit"][".googleLikeFields"].Add("suit_size");
			tdataArray["public_swimmersuit"][".googleLikeFields"].Add("swimmer_id");
			tdataArray["public_swimmersuit"][".googleLikeFields"].Add("id");
			tdataArray["public_swimmersuit"][".tableType"] = "list";
			tdataArray["public_swimmersuit"][".printerPageOrientation"] = 0;
			tdataArray["public_swimmersuit"][".nPrinterPageScale"] = 100;
			tdataArray["public_swimmersuit"][".nPrinterSplitRecords"] = 40;
			tdataArray["public_swimmersuit"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["public_swimmersuit"][".geocodingEnabled"] = false;
			tdataArray["public_swimmersuit"][".pageSize"] = 20;
			tdataArray["public_swimmersuit"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["public_swimmersuit"][".strOrderBy"] = tstrOrderBy;
			tdataArray["public_swimmersuit"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["public_swimmersuit"][".sqlHead"] = "SELECT suit_type,  suit_size,  swimmer_id,  id";
			tdataArray["public_swimmersuit"][".sqlFrom"] = "FROM \"public\".swimmersuit";
			tdataArray["public_swimmersuit"][".sqlWhereExpr"] = "";
			tdataArray["public_swimmersuit"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["public_swimmersuit"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["public_swimmersuit"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["public_swimmersuit"][".highlightSearchResults"] = true;
			tableKeysArray["public_swimmersuit"] = SettingsMap.GetArray();
			tableKeysArray["public_swimmersuit"].Add("id");
			tdataArray["public_swimmersuit"][".Keys"] = tableKeysArray["public_swimmersuit"];
			tdataArray["public_swimmersuit"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "suit_type";
			fdata["GoodName"] = "suit_type";
			fdata["ownerTable"] = "public.swimmersuit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersuit","suit_type");
			fdata["FieldType"] = 200;
			fdata["strField"] = "suit_type";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "suit_type";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
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
			tdataArray["public_swimmersuit"]["suit_type"] = fdata;
			tdataArray["public_swimmersuit"][".searchableFields"].Add("suit_type");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "suit_size";
			fdata["GoodName"] = "suit_size";
			fdata["ownerTable"] = "public.swimmersuit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersuit","suit_size");
			fdata["FieldType"] = 3;
			fdata["strField"] = "suit_size";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "suit_size";
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
			tdataArray["public_swimmersuit"]["suit_size"] = fdata;
			tdataArray["public_swimmersuit"][".searchableFields"].Add("suit_size");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "swimmer_id";
			fdata["GoodName"] = "swimmer_id";
			fdata["ownerTable"] = "public.swimmersuit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersuit","swimmer_id");
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
			edata["LookupType"] = 1;
			edata["LookupTable"] = "";
			edata["LookupConnId"] = "";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "id";
			edata["LookupOrderBy"] = "";
			edata["SimpleAdd"] = true;
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
			tdataArray["public_swimmersuit"]["swimmer_id"] = fdata;
			tdataArray["public_swimmersuit"][".searchableFields"].Add("swimmer_id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "id";
			fdata["GoodName"] = "id";
			fdata["ownerTable"] = "public.swimmersuit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("public_swimmersuit","id");
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
			tdataArray["public_swimmersuit"]["id"] = fdata;
			tdataArray["public_swimmersuit"][".searchableFields"].Add("id");
			GlobalVars.tables_data["public.swimmersuit"] = tdataArray["public_swimmersuit"];
			GlobalVars.field_labels["public_swimmersuit"] = fieldLabelsArray["public_swimmersuit"];
			GlobalVars.fieldToolTips["public_swimmersuit"] = fieldToolTipsArray["public_swimmersuit"];
			GlobalVars.placeHolders["public_swimmersuit"] = placeHoldersArray["public_swimmersuit"];
			GlobalVars.page_titles["public_swimmersuit"] = pageTitlesArray["public_swimmersuit"];
			GlobalVars.detailsTablesData["public.swimmersuit"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersuit"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "public.swimmer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "public.swimmer";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "public_swimmer";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["public.swimmersuit"][0] = masterParams;
			GlobalVars.masterTablesData["public.swimmersuit"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersuit"][0]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmersuit"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersuit"][0]["detailKeys"].Add("swimmer_id");


			strOriginalDetailsTable = "public.swimmer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "Not Paid - Report";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "Not_Paid___Report";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			masterParams["type"] = Constants.PAGE_REPORT;
			GlobalVars.masterTablesData["public.swimmersuit"][1] = masterParams;
			GlobalVars.masterTablesData["public.swimmersuit"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersuit"][1]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["public.swimmersuit"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["public.swimmersuit"][1]["detailKeys"].Add("swimmer_id");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "suit_type,  suit_size,  swimmer_id,  id";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmersuit";
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
obj = new SQLField(new XVar("m_strName", "suit_type", "m_strTable", "public.swimmersuit", "m_srcTableName", "public.swimmersuit"));

protoArray["6"]["m_sql"] = "suit_type";
protoArray["6"]["m_srcTableName"] = "public.swimmersuit";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suit_size", "m_strTable", "public.swimmersuit", "m_srcTableName", "public.swimmersuit"));

protoArray["8"]["m_sql"] = "suit_size";
protoArray["8"]["m_srcTableName"] = "public.swimmersuit";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "swimmer_id", "m_strTable", "public.swimmersuit", "m_srcTableName", "public.swimmersuit"));

protoArray["10"]["m_sql"] = "swimmer_id";
protoArray["10"]["m_srcTableName"] = "public.swimmersuit";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmersuit", "m_srcTableName", "public.swimmersuit"));

protoArray["12"]["m_sql"] = "id";
protoArray["12"]["m_srcTableName"] = "public.swimmersuit";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "public.swimmersuit";
protoArray["15"]["m_srcTableName"] = "public.swimmersuit";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("id");
protoArray["15"]["m_columns"].Add("swimmer_id");
protoArray["15"]["m_columns"].Add("suit_type");
protoArray["15"]["m_columns"].Add("suit_size");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "\"public\".swimmersuit";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "public.swimmersuit";
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
protoArray["0"]["m_srcTableName"] = "public.swimmersuit";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["public_swimmersuit"] = obj;

				
		
			tdataArray["public_swimmersuit"][".sqlquery"] = queryData_Array["public_swimmersuit"];
			GlobalVars.tableEvents["public.swimmersuit"] = new eventsBase();
			tdataArray["public_swimmersuit"][".hasEvents"] = false;
			GlobalVars.tables_data["public_swimmersuit"] = tdataArray["public_swimmersuit"];
		}
	}

}
