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
	public static partial class Settings_Not_Paid___Report
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), popupPagesLayoutNames = SettingsMap.GetArray(), query = null, queryData_Array = new XVar(), reportGroupFields = SettingsMap.GetArray(), rgroupField = SettingsMap.GetArray(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".truncateText"] = true;
			tdataArray["Not_Paid___Report"][".NumberOfChars"] = 80;
			tdataArray["Not_Paid___Report"][".ShortName"] = "Not_Paid___Report";
			tdataArray["Not_Paid___Report"][".OwnerID"] = "";
			tdataArray["Not_Paid___Report"][".OriginalTable"] = "public.swimmer";
			GlobalVars.defaultPages = MVCFunctions.my_json_decode(new XVar("{\"report\":\"report\",\"rprint\":\"rprint\",\"search\":\"search\"}"));
			tdataArray["Not_Paid___Report"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"report\":[\"report\"],\"rprint\":[\"rprint\"],\"search\":[\"search\"]}")));
			tdataArray["Not_Paid___Report"][".defaultPages"] = GlobalVars.defaultPages;
			fieldLabelsArray["Not_Paid___Report"] = SettingsMap.GetArray();
			fieldToolTipsArray["Not_Paid___Report"] = SettingsMap.GetArray();
			pageTitlesArray["Not_Paid___Report"] = SettingsMap.GetArray();
			placeHoldersArray["Not_Paid___Report"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["Not_Paid___Report"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["Not_Paid___Report"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["Not_Paid___Report"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["Not_Paid___Report"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["Not_Paid___Report"]["English"]["first_name"] = "First Name";
				fieldToolTipsArray["Not_Paid___Report"]["English"]["first_name"] = "";
				placeHoldersArray["Not_Paid___Report"]["English"]["first_name"] = "";
				fieldLabelsArray["Not_Paid___Report"]["English"]["last_name"] = "Last Name";
				fieldToolTipsArray["Not_Paid___Report"]["English"]["last_name"] = "";
				placeHoldersArray["Not_Paid___Report"]["English"]["last_name"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["Not_Paid___Report"]["English"])))
				{
					tdataArray["Not_Paid___Report"][".isUseToolTips"] = true;
				}
			}
			tdataArray["Not_Paid___Report"][".NCSearch"] = true;
			tdataArray["Not_Paid___Report"][".shortTableName"] = "Not_Paid___Report";
			tdataArray["Not_Paid___Report"][".nSecOptions"] = 0;
			tdataArray["Not_Paid___Report"][".mainTableOwnerID"] = "";
			tdataArray["Not_Paid___Report"][".entityType"] = 2;
			tdataArray["Not_Paid___Report"][".strOriginalTableName"] = "public.swimmer";
			tdataArray["Not_Paid___Report"][".showAddInPopup"] = false;
			tdataArray["Not_Paid___Report"][".showEditInPopup"] = false;
			tdataArray["Not_Paid___Report"][".showViewInPopup"] = false;
			popupPagesLayoutNames = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".popupPagesLayoutNames"] = popupPagesLayoutNames;
			tdataArray["Not_Paid___Report"][".listAjax"] = false;
			tdataArray["Not_Paid___Report"][".listAjax"] = false;
			tdataArray["Not_Paid___Report"][".audit"] = false;
			tdataArray["Not_Paid___Report"][".locking"] = false;
			GlobalVars.pages = tdataArray["Not_Paid___Report"][".pages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["Not_Paid___Report"][".edit"] = true;
				tdataArray["Not_Paid___Report"][".afterEditAction"] = 1;
				tdataArray["Not_Paid___Report"][".closePopupAfterEdit"] = 1;
				tdataArray["Not_Paid___Report"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["Not_Paid___Report"][".add"] = true;
				tdataArray["Not_Paid___Report"][".afterAddAction"] = 1;
				tdataArray["Not_Paid___Report"][".closePopupAfterAdd"] = 1;
				tdataArray["Not_Paid___Report"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["Not_Paid___Report"][".list"] = true;
			}
			tdataArray["Not_Paid___Report"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["Not_Paid___Report"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["Not_Paid___Report"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["Not_Paid___Report"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["Not_Paid___Report"][".printFriendly"] = true;
			}
			tdataArray["Not_Paid___Report"][".showSimpleSearchOptions"] = true;
			tdataArray["Not_Paid___Report"][".allowShowHideFields"] = true;
			tdataArray["Not_Paid___Report"][".allowFieldsReordering"] = true;
			tdataArray["Not_Paid___Report"][".isUseAjaxSuggest"] = true;


			tdataArray["Not_Paid___Report"][".flexibleSearch"] = true;
			tdataArray["Not_Paid___Report"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["Not_Paid___Report"][".buttonsAdded"] = false;
			tdataArray["Not_Paid___Report"][".addPageEvents"] = false;
			tdataArray["Not_Paid___Report"][".isUseTimeForSearch"] = false;
			tdataArray["Not_Paid___Report"][".badgeColor"] = "5F9EA0";
			tdataArray["Not_Paid___Report"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".googleLikeFields"].Add("first_name");
			tdataArray["Not_Paid___Report"][".googleLikeFields"].Add("last_name");
			tdataArray["Not_Paid___Report"][".tableType"] = "report";
			tdataArray["Not_Paid___Report"][".printerPageOrientation"] = 0;
			tdataArray["Not_Paid___Report"][".nPrinterPageScale"] = 100;
			tdataArray["Not_Paid___Report"][".nPrinterSplitRecords"] = 40;
			tdataArray["Not_Paid___Report"][".nPrinterPDFSplitRecords"] = 40;
			tdataArray["Not_Paid___Report"][".geocodingEnabled"] = false;
			tdataArray["Not_Paid___Report"][".printReportLayout"] = 3;
			tdataArray["Not_Paid___Report"][".reportPrintPartitionType"] = 1;
			tdataArray["Not_Paid___Report"][".reportPrintGroupsPerPage"] = 3;
			tdataArray["Not_Paid___Report"][".reportPrintPDFGroupsPerPage"] = 3;
			tdataArray["Not_Paid___Report"][".lowGroup"] = 1;
			tdataArray["Not_Paid___Report"][".reportGroupFields"] = true;
			tdataArray["Not_Paid___Report"][".pageSize"] = 5;
			tdataArray["Not_Paid___Report"][".showGroupSummaryCount"] = true;
			reportGroupFields = SettingsMap.GetArray();
			rgroupField = SettingsMap.GetArray();
			rgroupField["strGroupField"] = "last_name";
			rgroupField["groupInterval"] = 0;
			rgroupField["groupOrder"] = 1;
			rgroupField["showGroupSummary"] = "1";
			rgroupField["crossTabAxis"] = "0";
			reportGroupFields.Add(rgroupField);
			tdataArray["Not_Paid___Report"][".reportGroupFieldsData"] = reportGroupFields;
			tdataArray["Not_Paid___Report"][".repShowDet"] = true;
			tdataArray["Not_Paid___Report"][".reportLayout"] = 3;
			tstrOrderBy = "ORDER BY \"public\".swimmer.last_name";
			if(MVCFunctions.strlen(tstrOrderBy) && MVCFunctions.strtolower(MVCFunctions.substr(tstrOrderBy, new XVar(0), new XVar(8))) != "order by")
			{
				tstrOrderBy = MVCFunctions.Concat("order by ", tstrOrderBy);
			}
			tdataArray["Not_Paid___Report"][".strOrderBy"] = tstrOrderBy;
			tdataArray["Not_Paid___Report"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".orderindexes"].Add(new XVar(0, 2, 1, (XVar.Pack(1) ? XVar.Pack("ASC") : XVar.Pack("DESC")), 2, "\"public\".swimmer.last_name"));
			tdataArray["Not_Paid___Report"][".sqlHead"] = "SELECT \"public\".swimmer.first_name,  \"public\".swimmer.last_name";
			tdataArray["Not_Paid___Report"][".sqlFrom"] = "FROM \"public\".swimmer  LEFT OUTER JOIN \"public\".swimmerpayment ON \"public\".swimmer.id = \"public\".swimmerpayment.swimmer_id";
			tdataArray["Not_Paid___Report"][".sqlWhereExpr"] = "(\"public\".swimmerpayment.payment_type is null) AND (\"public\".swimmerpayment.amount_paid is null)";
			tdataArray["Not_Paid___Report"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["Not_Paid___Report"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["Not_Paid___Report"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["Not_Paid___Report"][".highlightSearchResults"] = true;
			tableKeysArray["Not_Paid___Report"] = SettingsMap.GetArray();
			tdataArray["Not_Paid___Report"][".Keys"] = tableKeysArray["Not_Paid___Report"];
			tdataArray["Not_Paid___Report"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "first_name";
			fdata["GoodName"] = "first_name";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Not_Paid___Report","first_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "first_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmer.first_name";
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
			tdataArray["Not_Paid___Report"]["first_name"] = fdata;
			tdataArray["Not_Paid___Report"][".searchableFields"].Add("first_name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "last_name";
			fdata["GoodName"] = "last_name";
			fdata["ownerTable"] = "public.swimmer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("Not_Paid___Report","last_name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "last_name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "\"public\".swimmer.last_name";
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
			tdataArray["Not_Paid___Report"]["last_name"] = fdata;
			tdataArray["Not_Paid___Report"][".searchableFields"].Add("last_name");
			GlobalVars.tables_data["Not Paid - Report"] = tdataArray["Not_Paid___Report"];
			GlobalVars.field_labels["Not_Paid___Report"] = fieldLabelsArray["Not_Paid___Report"];
			GlobalVars.fieldToolTips["Not_Paid___Report"] = fieldToolTipsArray["Not_Paid___Report"];
			GlobalVars.placeHolders["Not_Paid___Report"] = placeHoldersArray["Not_Paid___Report"];
			GlobalVars.page_titles["Not_Paid___Report"] = pageTitlesArray["Not_Paid___Report"];
			GlobalVars.detailsTablesData["Not Paid - Report"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmerpayment";
			detailsParam["dOriginalTable"] = "public.swimmerpayment";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmerpayment";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmerpayment"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["detailKeys"].Add("swimmer_id");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "public.swimmersuit";
			detailsParam["dOriginalTable"] = "public.swimmersuit";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "public_swimmersuit";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("public_swimmersuit"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["masterKeys"].Add("id");
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["Not Paid - Report"][dIndex]["detailKeys"].Add("swimmer_id");
			GlobalVars.masterTablesData["Not Paid - Report"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "\"public\".swimmer.first_name,  \"public\".swimmer.last_name";
protoArray["0"]["m_strFrom"] = "FROM \"public\".swimmer  LEFT OUTER JOIN \"public\".swimmerpayment ON \"public\".swimmer.id = \"public\".swimmerpayment.swimmer_id";
protoArray["0"]["m_strWhere"] = "(\"public\".swimmerpayment.payment_type is null) AND (\"public\".swimmerpayment.amount_paid is null)";
protoArray["0"]["m_strOrderBy"] = "ORDER BY \"public\".swimmer.last_name";
	
		
protoArray["0"]["cipherer"] = null;
protoArray["2"] = SettingsMap.GetArray();
protoArray["2"]["m_sql"] = "(\"public\".swimmerpayment.payment_type is null) AND (\"public\".swimmerpayment.amount_paid is null)";
protoArray["2"]["m_uniontype"] = "SQLL_AND";
obj = new SQLNonParsed(new XVar("m_sql", "(\"public\".swimmerpayment.payment_type is null) AND (\"public\".swimmerpayment.amount_paid is null)"));

protoArray["2"]["m_column"] = obj;
protoArray["2"]["m_contained"] = SettingsMap.GetArray();
protoArray["4"] = SettingsMap.GetArray();
protoArray["4"]["m_sql"] = "\"public\".swimmerpayment.payment_type is null";
protoArray["4"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "payment_type", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Not Paid - Report"));

protoArray["4"]["m_column"] = obj;
protoArray["4"]["m_contained"] = SettingsMap.GetArray();
protoArray["4"]["m_strCase"] = "is null";
protoArray["4"]["m_havingmode"] = false;
protoArray["4"]["m_inBrackets"] = true;
protoArray["4"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["4"]);

protoArray["2"]["m_contained"].Add(obj);
protoArray["6"] = SettingsMap.GetArray();
protoArray["6"]["m_sql"] = "\"public\".swimmerpayment.amount_paid is null";
protoArray["6"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "amount_paid", "m_strTable", "public.swimmerpayment", "m_srcTableName", "Not Paid - Report"));

protoArray["6"]["m_column"] = obj;
protoArray["6"]["m_contained"] = SettingsMap.GetArray();
protoArray["6"]["m_strCase"] = "is null";
protoArray["6"]["m_havingmode"] = false;
protoArray["6"]["m_inBrackets"] = true;
protoArray["6"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["6"]);

protoArray["2"]["m_contained"].Add(obj);
protoArray["2"]["m_strCase"] = "";
protoArray["2"]["m_havingmode"] = false;
protoArray["2"]["m_inBrackets"] = false;
protoArray["2"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["2"]);

protoArray["0"]["m_where"] = obj;
protoArray["8"] = SettingsMap.GetArray();
protoArray["8"]["m_sql"] = "";
protoArray["8"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["8"]["m_column"] = obj;
protoArray["8"]["m_contained"] = SettingsMap.GetArray();
protoArray["8"]["m_strCase"] = "";
protoArray["8"]["m_havingmode"] = false;
protoArray["8"]["m_inBrackets"] = false;
protoArray["8"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["8"]);

protoArray["0"]["m_having"] = obj;
protoArray["0"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "first_name", "m_strTable", "public.swimmer", "m_srcTableName", "Not Paid - Report"));

protoArray["10"]["m_sql"] = "\"public\".swimmer.first_name";
protoArray["10"]["m_srcTableName"] = "Not Paid - Report";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "last_name", "m_strTable", "public.swimmer", "m_srcTableName", "Not Paid - Report"));

protoArray["12"]["m_sql"] = "\"public\".swimmer.last_name";
protoArray["12"]["m_srcTableName"] = "Not Paid - Report";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "public.swimmer";
protoArray["15"]["m_srcTableName"] = "Not Paid - Report";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("id");
protoArray["15"]["m_columns"].Add("first_name");
protoArray["15"]["m_columns"].Add("last_name");
protoArray["15"]["m_columns"].Add("gender");
protoArray["15"]["m_columns"].Add("birthdate");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "\"public\".swimmer";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "Not Paid - Report";
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
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_LEFTJOIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "public.swimmerpayment";
protoArray["19"]["m_srcTableName"] = "Not Paid - Report";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("id");
protoArray["19"]["m_columns"].Add("swimmer_id");
protoArray["19"]["m_columns"].Add("payment_type");
protoArray["19"]["m_columns"].Add("amount_paid");
protoArray["19"]["m_columns"].Add("practice_time");
protoArray["19"]["m_columns"].Add("early_registration");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "LEFT OUTER JOIN \"public\".swimmerpayment ON \"public\".swimmer.id = \"public\".swimmerpayment.swimmer_id";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "Not Paid - Report";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_sql"] = "\"public\".swimmer.id = \"public\".swimmerpayment.swimmer_id";
protoArray["20"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLField(new XVar("m_strName", "id", "m_strTable", "public.swimmer", "m_srcTableName", "Not Paid - Report"));

protoArray["20"]["m_column"] = obj;
protoArray["20"]["m_contained"] = SettingsMap.GetArray();
protoArray["20"]["m_strCase"] = "= \"public\".swimmerpayment.swimmer_id";
protoArray["20"]["m_havingmode"] = false;
protoArray["20"]["m_inBrackets"] = false;
protoArray["20"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["20"]);

protoArray["18"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["18"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["22"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "last_name", "m_strTable", "public.swimmer", "m_srcTableName", "Not Paid - Report"));

protoArray["22"]["m_column"] = obj;
protoArray["22"]["m_bAsc"] = 1;
protoArray["22"]["m_nColumn"] = 0;
obj = new SQLOrderByItem(protoArray["22"]);

protoArray["0"]["m_orderby"].Add(obj);
protoArray["0"]["m_srcTableName"] = "Not Paid - Report";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["Not_Paid___Report"] = obj;

				
		
			tdataArray["Not_Paid___Report"][".sqlquery"] = queryData_Array["Not_Paid___Report"];
			GlobalVars.tableEvents["Not Paid - Report"] = new eventsBase();
			tdataArray["Not_Paid___Report"][".hasEvents"] = false;
			GlobalVars.tables_data["Not_Paid___Report"] = tdataArray["Not_Paid___Report"];
		}
	}

}
