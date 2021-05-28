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
	public static partial class Settings_Swimmers_Without_Suits___Report
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".truncateText"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".NumberOfChars"] = 80;
			tdataArray["Swimmers_Without_Suits___Report"][".ShortName"] = "Swimmers_Without_Suits___Report";
			tdataArray["Swimmers_Without_Suits___Report"][".OwnerID"] = "";
			tdataArray["Swimmers_Without_Suits___Report"][".OriginalTable"] = "public.swimmersuit";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"report\":\"report\",\"rprint\":\"rprint\",\"search\":\"search\"}"));
			tdataArray["Swimmers_Without_Suits___Report"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}")));
			tdataArray["Swimmers_Without_Suits___Report"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["Swimmers_Without_Suits___Report"] = SettingsMap.GetArray();
			fieldToolTipsArray["Swimmers_Without_Suits___Report"] = SettingsMap.GetArray();
			pageTitlesArray["Swimmers_Without_Suits___Report"] = SettingsMap.GetArray();
			placeHoldersArray["Swimmers_Without_Suits___Report"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["Swimmers_Without_Suits___Report"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["Swimmers_Without_Suits___Report"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["Swimmers_Without_Suits___Report"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["Swimmers_Without_Suits___Report"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["Swimmers_Without_Suits___Report"]["English"]["suit_type"] = "Suit Type";
				fieldToolTipsArray["Swimmers_Without_Suits___Report"]["English"]["suit_type"] = "";
				placeHoldersArray["Swimmers_Without_Suits___Report"]["English"]["suit_type"] = "";
				fieldLabelsArray["Swimmers_Without_Suits___Report"]["English"]["suit_size"] = "Suit Size";
				fieldToolTipsArray["Swimmers_Without_Suits___Report"]["English"]["suit_size"] = "";
				placeHoldersArray["Swimmers_Without_Suits___Report"]["English"]["suit_size"] = "";
				fieldLabelsArray["Swimmers_Without_Suits___Report"]["English"]["swimmerName"] = "Name";
				fieldToolTipsArray["Swimmers_Without_Suits___Report"]["English"]["swimmerName"] = "";
				placeHoldersArray["Swimmers_Without_Suits___Report"]["English"]["swimmerName"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["Swimmers_Without_Suits___Report"]["English"])))
				{
					tdataArray["Swimmers_Without_Suits___Report"][".isUseToolTips"] = true;
				}
			}
			tdataArray["Swimmers_Without_Suits___Report"][".NCSearch"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".shortTableName"] = "Swimmers_Without_Suits___Report";
			tdataArray["Swimmers_Without_Suits___Report"][".nSecOptions"] = 0;
			tdataArray["Swimmers_Without_Suits___Report"][".mainTableOwnerID"] = "";
			tdataArray["Swimmers_Without_Suits___Report"][".entityType"] = 2;
			tdataArray["Swimmers_Without_Suits___Report"][".strOriginalTableName"] = "public.swimmersuit";
			tdataArray["Swimmers_Without_Suits___Report"][".showAddInPopup"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".showEditInPopup"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["Swimmers_Without_Suits___Report"][".listAjax"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".listAjax"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".audit"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".locking"] = false;
			GlobalVars.pages = tdataArray["Swimmers_Without_Suits___Report"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".edit"] = true;
				tdataArray["Swimmers_Without_Suits___Report"][".afterEditAction"] = 1;
				tdataArray["Swimmers_Without_Suits___Report"][".closePopupAfterEdit"] = 1;
				tdataArray["Swimmers_Without_Suits___Report"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".add"] = true;
				tdataArray["Swimmers_Without_Suits___Report"][".afterAddAction"] = 1;
				tdataArray["Swimmers_Without_Suits___Report"][".closePopupAfterAdd"] = 1;
				tdataArray["Swimmers_Without_Suits___Report"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".list"] = true;
			}
			tdataArray["Swimmers_Without_Suits___Report"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["Swimmers_Without_Suits___Report"][".printFriendly"] = true;
			}
			tdataArray["Swimmers_Without_Suits___Report"][".showSimpleSearchOptions"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".allowShowHideFields"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".allowFieldsReordering"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".isUseAjaxSuggest"] = true;


			tdataArray["Swimmers_Without_Suits___Report"][".flexibleSearch"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".buttonsAdded"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".addPageEvents"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".isUseTimeForSearch"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".badgeColor"] = "4682B4";
			tdataArray["Swimmers_Without_Suits___Report"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".googleLikeFields"].Add("swimmerName");
			tdataArray["Swimmers_Without_Suits___Report"][".googleLikeFields"].Add("suit_type");
			tdataArray["Swimmers_Without_Suits___Report"][".googleLikeFields"].Add("suit_size");
			tdataArray["Swimmers_Without_Suits___Report"][".tableType"] = "report";
			tdataArray["Swimmers_Without_Suits___Report"][".printerPageOrientation"] = 0;
			tdataArray["Swimmers_Without_Suits___Report"][".nPrinterPageScale"] = 100;
			tdataArray["Swimmers_Without_Suits___Report"][".nPrinterSplitRecords"] = 40;
			tdataArray["Swimmers_Without_Suits___Report"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["Swimmers_Without_Suits___Report"][".geocodingEnabled"] = false;
			tdataArray["Swimmers_Without_Suits___Report"][".printReportLayout"] = 1;
			tdataArray["Swimmers_Without_Suits___Report"][".reportPrintPartitionType"] = 1;
			tdataArray["Swimmers_Without_Suits___Report"][".reportPrintGroupsPerPage"] = 3;
			tdataArray["Swimmers_Without_Suits___Report"][".reportPrintPDFGroupsPerPage"] = 3;
			tdataArray["Swimmers_Without_Suits___Report"][".lowGroup"] = 3;
			tdataArray["Swimmers_Without_Suits___Report"][".reportGroupFields"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".pageSize"] = 5;
			reportGroupFields = SettingsMap.GetArray();
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "swimmerName";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 1;
			rgroupField["showGroupSummary"] = "1";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "suit_type";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 2;
			rgroupField["showGroupSummary"] = "0";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "suit_size";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 3;
			rgroupField["showGroupSummary"] = "1";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			tdataArray["Swimmers_Without_Suits___Report"][".reportGroupFieldsData"] = reportGroupFields;
			tdataArray["Swimmers_Without_Suits___Report"][".repShowDet"] = true;
			tdataArray["Swimmers_Without_Suits___Report"][".reportLayout"] = 1;
			tstrOrderBy = "";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["Swimmers_Without_Suits___Report"][".strOrderBy"] = tstrOrderBy;
			tdataArray["Swimmers_Without_Suits___Report"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".sqlHead"] = "SELECT CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name) AS \"swimmerName\",  \"public\".swimmersuit.suit_type,  \"public\".swimmersuit.suit_size";
			tdataArray["Swimmers_Without_Suits___Report"][".sqlFrom"] = "FROM \"public\".swimmersuit  INNER JOIN \"public\".swimmer ON \"public\".swimmersuit.swimmer_id = \"public\".swimmer.id";
			tdataArray["Swimmers_Without_Suits___Report"][".sqlWhereExpr"] = "";
			tdataArray["Swimmers_Without_Suits___Report"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["Swimmers_Without_Suits___Report"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["Swimmers_Without_Suits___Report"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["Swimmers_Without_Suits___Report"][".highlightSearchResults"] = true;
			tableKeysArray["Swimmers_Without_Suits___Report"] = SettingsMap.GetArray();
			tdataArray["Swimmers_Without_Suits___Report"][".Keys"] = tableKeysArray["Swimmers_Without_Suits___Report"];
			tdataArray["Swimmers_Without_Suits___Report"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "swimmerName";
			fdata["GoodName"] = "swimmerName";
			fdata["ownerTable"] = "";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Swimmers_Without_Suits___Report","swimmerName");
			fdata["FieldType"] = 201;
			fdata["strField"] = "swimmername";
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
			tdataArray["Swimmers_Without_Suits___Report"]["swimmerName"] = fdata;
			tdataArray["Swimmers_Without_Suits___Report"][".searchableFields"].Add("swimmerName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "suit_type";
			fdata["GoodName"] = "suit_type";
			fdata["ownerTable"] = "public.swimmersuit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Swimmers_Without_Suits___Report","suit_type");
			fdata["FieldType"] = 200;
			fdata["strField"] = "suit_type";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmersuit.suit_type";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=10");
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
			tdataArray["Swimmers_Without_Suits___Report"]["suit_type"] = fdata;
			tdataArray["Swimmers_Without_Suits___Report"][".searchableFields"].Add("suit_type");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "suit_size";
			fdata["GoodName"] = "suit_size";
			fdata["ownerTable"] = "public.swimmersuit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Swimmers_Without_Suits___Report","suit_size");
			fdata["FieldType"] = 3;
			fdata["strField"] = "suit_size";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmersuit.suit_size";
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
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
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
			tdataArray["Swimmers_Without_Suits___Report"]["suit_size"] = fdata;
			tdataArray["Swimmers_Without_Suits___Report"][".searchableFields"].Add("suit_size");
			GlobalVars.tables_data["Swimmers Without Suits - Report"] = tdataArray["Swimmers_Without_Suits___Report"];
			GlobalVars.field_labels["Swimmers_Without_Suits___Report"] = fieldLabelsArray["Swimmers_Without_Suits___Report"];
			GlobalVars.fieldToolTips["Swimmers_Without_Suits___Report"] = fieldToolTipsArray["Swimmers_Without_Suits___Report"];
			GlobalVars.placeHolders["Swimmers_Without_Suits___Report"] = placeHoldersArray["Swimmers_Without_Suits___Report"];
			GlobalVars.page_titles["Swimmers_Without_Suits___Report"] = pageTitlesArray["Swimmers_Without_Suits___Report"];
			GlobalVars.detailsTablesData["Swimmers Without Suits - Report"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Swimmers Without Suits - Report"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "public.swimmer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "public.swimmer";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "public_swimmer";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["Swimmers Without Suits - Report"][0] = masterParams;
			GlobalVars.masterTablesData["Swimmers Without Suits - Report"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Swimmers Without Suits - Report"][0]["masterKeys"].Add("id");
			GlobalVars.masterTablesData["Swimmers Without Suits - Report"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["Swimmers Without Suits - Report"][0]["detailKeys"].Add("swimmer_id");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "CONCAT(\"public\".swimmer.first_name, ' ', \"public\".swimmer.last_name) AS \"swimmerName\",  \"public\".swimmersuit.suit_type,  \"public\".swimmersuit.suit_size";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmersuit  INNER JOIN \"public\".swimmer ON \"public\".swimmersuit.swimmer_id = \"public\".swimmer.id";
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
protoArray["6"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "swimmerName";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["11"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suit_type", "m_strTable", "public.swimmersuit", "m_srcTableName", "Swimmers Without Suits - Report"));

protoArray["11"]["m_sql"] = "\"public\".swimmersuit.suit_type";
protoArray["11"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["11"]["m_expr"] = obj;
protoArray["11"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["11"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["13"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "suit_size", "m_strTable", "public.swimmersuit", "m_srcTableName", "Swimmers Without Suits - Report"));

protoArray["13"]["m_sql"] = "\"public\".swimmersuit.suit_size";
protoArray["13"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["13"]["m_expr"] = obj;
protoArray["13"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["13"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_link"] = "SQLL_MAIN";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_strName"] = "public.swimmersuit";
protoArray["16"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["16"]["m_columns"] = SettingsMap.GetArray();
protoArray["16"]["m_columns"].Add("id");
protoArray["16"]["m_columns"].Add("swimmer_id");
protoArray["16"]["m_columns"].Add("suit_type");
protoArray["16"]["m_columns"].Add("suit_size");
obj = new SQLTable(protoArray["16"]);

protoArray["15"]["m_table"] = obj;
protoArray["15"]["m_sql"] = "\"public\".swimmersuit";
protoArray["15"]["m_alias"] = "";
protoArray["15"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_sql"] = "";
protoArray["17"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["17"]["m_column"] = obj;
protoArray["17"]["m_contained"] = SettingsMap.GetArray();
protoArray["17"]["m_strCase"] = "";
protoArray["17"]["m_havingmode"] = false;
protoArray["17"]["m_inBrackets"] = false;
protoArray["17"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["17"]);

protoArray["15"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["15"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_link"] = "SQLL_INNERJOIN";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_strName"] = "public.swimmer";
protoArray["20"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["20"]["m_columns"] = SettingsMap.GetArray();
protoArray["20"]["m_columns"].Add("id");
protoArray["20"]["m_columns"].Add("first_name");
protoArray["20"]["m_columns"].Add("last_name");
protoArray["20"]["m_columns"].Add("gender");
protoArray["20"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["20"]);

protoArray["19"]["m_table"] = obj;
protoArray["19"]["m_sql"] = "INNER JOIN \"public\".swimmer ON \"public\".swimmersuit.swimmer_id = \"public\".swimmer.id";
protoArray["19"]["m_alias"] = "";
protoArray["19"]["m_srcTableName"] = "Swimmers Without Suits - Report";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_sql"] = "\"public\".swimmersuit.swimmer_id = \"public\".swimmer.id";
protoArray["21"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "swimmer_id", "m_strTable", "public.swimmersuit", "m_srcTableName", "Swimmers Without Suits - Report"));

protoArray["21"]["m_column"] = obj;
protoArray["21"]["m_contained"] = SettingsMap.GetArray();
protoArray["21"]["m_strCase"] = "= \"public\".swimmer.id";
protoArray["21"]["m_havingmode"] = false;
protoArray["21"]["m_inBrackets"] = false;
protoArray["21"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["21"]);

protoArray["19"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["19"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "Swimmers Without Suits - Report";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["Swimmers_Without_Suits___Report"] = obj;

				
		
			tdataArray["Swimmers_Without_Suits___Report"][".sqlquery"] = queryData_Array["Swimmers_Without_Suits___Report"];
			GlobalVars.tableEvents["Swimmers Without Suits - Report"] = new eventsBase();
			tdataArray["Swimmers_Without_Suits___Report"][".hasEvents"] = false;
			GlobalVars.tables_data["Swimmers_Without_Suits___Report"] = tdataArray["Swimmers_Without_Suits___Report"];
		}
	}

}
