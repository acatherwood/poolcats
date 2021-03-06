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
	public partial class public_swimmerController : BaseController
	{
		public ActionResult edit()
		{
			try
			{
				dynamic id = null, keys = XVar.Array(), pageMode = null, pageObject = null, var_params = XVar.Array();
				XTempl xt;
				public_swimmer_Variables.Apply();
				CommonFunctions.add_nocache_headers();
				EditPage.handleBrokenRequest();
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("edit_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "public_swimmer_edit";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["editpage"] = XVar.Array();
t_layout.containers["editpage"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "editheader", "block", "editheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.containers["editpage"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.containers["editpage"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "steps" ));
t_layout.containers["steps"] = XVar.Array();
t_layout.containers["steps"].Add(new XVar("name", "multistep_nav_edit", "block", "", "substyle", 1  ));

t_layout.skins["steps"] = "";


t_layout.skins["editpage"] = "";

t_layout.blocks["top"].Add("editpage");
t_layout.containers["fields"] = XVar.Array();
t_layout.containers["fields"].Add(new XVar("name", "editfields", "block", "", "substyle", 1  ));

t_layout.skins["fields"] = "";

t_layout.blocks["top"].Add("fields");
t_layout.containers["bottombuttons"] = XVar.Array();
t_layout.containers["bottombuttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "buttons" ));
t_layout.containers["buttons"] = XVar.Array();
t_layout.containers["buttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "leftbuttons" ));
t_layout.containers["leftbuttons"] = XVar.Array();
t_layout.containers["leftbuttons"].Add(new XVar("name", "editbuttons", "block", "editbuttons", "substyle", 1  ));

t_layout.skins["leftbuttons"] = "";


t_layout.containers["buttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "leftbuttons_1" ));
t_layout.containers["leftbuttons_1"] = XVar.Array();
t_layout.containers["leftbuttons_1"].Add(new XVar("name", "righteditbuttons", "block", "righteditbuttons", "substyle", 1  ));

t_layout.skins["leftbuttons_1"] = "";


t_layout.skins["buttons"] = "";


t_layout.skins["bottombuttons"] = "";

t_layout.blocks["top"].Add("bottombuttons");
GlobalVars.page_layouts["public_swimmer_edit"] = t_layout;


}

{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("list_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "public_swimmer_list";
t_layout.blocks["center"] = XVar.Array();
t_layout.containers["gridcontrols"] = XVar.Array();
t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "add_delete" ));
t_layout.containers["add_delete"] = XVar.Array();
t_layout.containers["add_delete"].Add(new XVar("name", "add", "block", "newrecord_controls_block", "substyle", 1  ));

t_layout.containers["add_delete"].Add(new XVar("name", "recordcontrol", "block", "record_controls_block", "substyle", 1  ));

t_layout.skins["add_delete"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo" ));
t_layout.containers["gridinfo"] = XVar.Array();
t_layout.containers["gridinfo"].Add(new XVar("name", "details_found", "block", "details_found", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "bsfieldhidepanel", "block", "field_hide_panel", "substyle", 1  ));

t_layout.skins["gridinfo"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo_sort" ));
t_layout.containers["gridinfo_sort"] = XVar.Array();
t_layout.containers["gridinfo_sort"].Add(new XVar("name", "reorder_records", "block", "reorder_records", "substyle", 1  ));

t_layout.skins["gridinfo_sort"] = "";


t_layout.skins["gridcontrols"] = "";

t_layout.blocks["center"].Add("gridcontrols");
t_layout.containers["tabs"] = XVar.Array();
t_layout.containers["tabs"].Add(new XVar("name", "bsgrid_tabs", "block", "grid_tabs", "substyle", 1  ));

t_layout.skins["tabs"] = "";

t_layout.blocks["center"].Add("tabs");
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";

t_layout.blocks["center"].Add("messagerow");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grid" ));
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "grid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["grid"] = "";


t_layout.skins["center"] = "";

t_layout.blocks["center"].Add("center");
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";

t_layout.blocks["center"].Add("pagination");
t_layout.blocks["left"] = XVar.Array();
t_layout.containers["left"] = XVar.Array();
t_layout.containers["left"].Add(new XVar("name", "searchpanel", "block", "searchPanel", "substyle", 1  ));

t_layout.containers["left"].Add(new XVar("name", "filterpanel", "block", "filterPanel", "substyle", 1  ));

t_layout.skins["left"] = "";

t_layout.blocks["left"].Add("left");
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.blocks["topmiddle"] = XVar.Array();
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";

t_layout.blocks["topmiddle"].Add("breadcrumbs");
t_layout.containers["masterinfo"] = XVar.Array();
t_layout.containers["masterinfo"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["masterinfo"] = "";

t_layout.blocks["topmiddle"].Add("masterinfo");
GlobalVars.page_layouts["public_swimmer_list"] = t_layout;


}


{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("list_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "public_swimmersuit_list";
t_layout.blocks["center"] = XVar.Array();
t_layout.containers["gridcontrols"] = XVar.Array();
t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "add_delete" ));
t_layout.containers["add_delete"] = XVar.Array();
t_layout.containers["add_delete"].Add(new XVar("name", "add", "block", "newrecord_controls_block", "substyle", 1  ));

t_layout.containers["add_delete"].Add(new XVar("name", "recordcontrol", "block", "record_controls_block", "substyle", 1  ));

t_layout.skins["add_delete"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo" ));
t_layout.containers["gridinfo"] = XVar.Array();
t_layout.containers["gridinfo"].Add(new XVar("name", "details_found", "block", "details_found", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "bsfieldhidepanel", "block", "field_hide_panel", "substyle", 1  ));

t_layout.skins["gridinfo"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo_sort" ));
t_layout.containers["gridinfo_sort"] = XVar.Array();
t_layout.containers["gridinfo_sort"].Add(new XVar("name", "reorder_records", "block", "reorder_records", "substyle", 1  ));

t_layout.skins["gridinfo_sort"] = "";


t_layout.skins["gridcontrols"] = "";

t_layout.blocks["center"].Add("gridcontrols");
t_layout.containers["tabs"] = XVar.Array();
t_layout.containers["tabs"].Add(new XVar("name", "bsgrid_tabs", "block", "grid_tabs", "substyle", 1  ));

t_layout.skins["tabs"] = "";

t_layout.blocks["center"].Add("tabs");
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";

t_layout.blocks["center"].Add("messagerow");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grid" ));
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "grid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["grid"] = "";


t_layout.skins["center"] = "";

t_layout.blocks["center"].Add("center");
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";

t_layout.blocks["center"].Add("pagination");
t_layout.blocks["left"] = XVar.Array();
t_layout.containers["left"] = XVar.Array();
t_layout.containers["left"].Add(new XVar("name", "searchpanel", "block", "searchPanel", "substyle", 1  ));

t_layout.containers["left"].Add(new XVar("name", "filterpanel", "block", "filterPanel", "substyle", 1  ));

t_layout.skins["left"] = "";

t_layout.blocks["left"].Add("left");
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.blocks["topmiddle"] = XVar.Array();
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";

t_layout.blocks["topmiddle"].Add("breadcrumbs");
t_layout.containers["masterinfo"] = XVar.Array();
t_layout.containers["masterinfo"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["masterinfo"] = "";

t_layout.blocks["topmiddle"].Add("masterinfo");
GlobalVars.page_layouts["public_swimmersuit_list"] = t_layout;


}


{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("report_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "Swimmers_Without_Suits___Report_report";
t_layout.blocks["center"] = XVar.Array();
t_layout.containers["gridcontrols"] = XVar.Array();
t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo" ));
t_layout.containers["gridinfo"] = XVar.Array();
t_layout.containers["gridinfo"].Add(new XVar("name", "details_found", "block", "details_found", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.skins["gridinfo"] = "";


t_layout.skins["gridcontrols"] = "";

t_layout.blocks["center"].Add("gridcontrols");
t_layout.containers["tabsrow"] = XVar.Array();
t_layout.containers["tabsrow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "tabs" ));
t_layout.containers["tabs"] = XVar.Array();
t_layout.containers["tabs"].Add(new XVar("name", "bsgrid_tabs", "block", "grid_tabs", "substyle", 1  ));

t_layout.skins["tabs"] = "";


t_layout.skins["tabsrow"] = "";

t_layout.blocks["center"].Add("tabsrow");
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";

t_layout.blocks["center"].Add("messagerow");
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "bsreport", "block", "", "substyle", 1  ));

t_layout.skins["grid"] = "";

t_layout.blocks["center"].Add("grid");
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";

t_layout.blocks["center"].Add("pagination");
t_layout.blocks["left"] = XVar.Array();
t_layout.containers["left"] = XVar.Array();
t_layout.containers["left"].Add(new XVar("name", "searchpanel", "block", "searchPanel", "substyle", 1  ));

t_layout.containers["left"].Add(new XVar("name", "filterpanel", "block", "filterPanel", "substyle", 1  ));

t_layout.skins["left"] = "";

t_layout.blocks["left"].Add("left");
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.blocks["topmiddle"] = XVar.Array();
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";

t_layout.blocks["topmiddle"].Add("breadcrumbs");
t_layout.containers["masterinfo"] = XVar.Array();
t_layout.containers["masterinfo"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["masterinfo"] = "";

t_layout.blocks["topmiddle"].Add("masterinfo");
GlobalVars.page_layouts["Swimmers_Without_Suits___Report_report"] = t_layout;


}


{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("list_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "public_swimmerpayment_list";
t_layout.blocks["center"] = XVar.Array();
t_layout.containers["gridcontrols"] = XVar.Array();
t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "add_delete" ));
t_layout.containers["add_delete"] = XVar.Array();
t_layout.containers["add_delete"].Add(new XVar("name", "add", "block", "newrecord_controls_block", "substyle", 1  ));

t_layout.containers["add_delete"].Add(new XVar("name", "recordcontrol", "block", "record_controls_block", "substyle", 1  ));

t_layout.skins["add_delete"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo" ));
t_layout.containers["gridinfo"] = XVar.Array();
t_layout.containers["gridinfo"].Add(new XVar("name", "details_found", "block", "details_found", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "bsfieldhidepanel", "block", "field_hide_panel", "substyle", 1  ));

t_layout.skins["gridinfo"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo_sort" ));
t_layout.containers["gridinfo_sort"] = XVar.Array();
t_layout.containers["gridinfo_sort"].Add(new XVar("name", "reorder_records", "block", "reorder_records", "substyle", 1  ));

t_layout.skins["gridinfo_sort"] = "";


t_layout.skins["gridcontrols"] = "";

t_layout.blocks["center"].Add("gridcontrols");
t_layout.containers["tabs"] = XVar.Array();
t_layout.containers["tabs"].Add(new XVar("name", "bsgrid_tabs", "block", "grid_tabs", "substyle", 1  ));

t_layout.skins["tabs"] = "";

t_layout.blocks["center"].Add("tabs");
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";

t_layout.blocks["center"].Add("messagerow");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grid" ));
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "grid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["grid"] = "";


t_layout.skins["center"] = "";

t_layout.blocks["center"].Add("center");
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";

t_layout.blocks["center"].Add("pagination");
t_layout.blocks["left"] = XVar.Array();
t_layout.containers["left"] = XVar.Array();
t_layout.containers["left"].Add(new XVar("name", "searchpanel", "block", "searchPanel", "substyle", 1  ));

t_layout.containers["left"].Add(new XVar("name", "filterpanel", "block", "filterPanel", "substyle", 1  ));

t_layout.skins["left"] = "";

t_layout.blocks["left"].Add("left");
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.blocks["topmiddle"] = XVar.Array();
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";

t_layout.blocks["topmiddle"].Add("breadcrumbs");
t_layout.containers["masterinfo"] = XVar.Array();
t_layout.containers["masterinfo"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["masterinfo"] = "";

t_layout.blocks["topmiddle"].Add("masterinfo");
GlobalVars.page_layouts["public_swimmerpayment_list"] = t_layout;


}


{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("list_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "public_swimmercontact_list";
t_layout.blocks["center"] = XVar.Array();
t_layout.containers["gridcontrols"] = XVar.Array();
t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "add_delete" ));
t_layout.containers["add_delete"] = XVar.Array();
t_layout.containers["add_delete"].Add(new XVar("name", "add", "block", "newrecord_controls_block", "substyle", 1  ));

t_layout.containers["add_delete"].Add(new XVar("name", "recordcontrol", "block", "record_controls_block", "substyle", 1  ));

t_layout.skins["add_delete"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo" ));
t_layout.containers["gridinfo"] = XVar.Array();
t_layout.containers["gridinfo"].Add(new XVar("name", "details_found", "block", "details_found", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "printpanel", "block", "print_friendly", "substyle", 1  ));

t_layout.containers["gridinfo"].Add(new XVar("name", "bsfieldhidepanel", "block", "field_hide_panel", "substyle", 1  ));

t_layout.skins["gridinfo"] = "";


t_layout.containers["gridcontrols"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "gridinfo_sort" ));
t_layout.containers["gridinfo_sort"] = XVar.Array();
t_layout.containers["gridinfo_sort"].Add(new XVar("name", "reorder_records", "block", "reorder_records", "substyle", 1  ));

t_layout.skins["gridinfo_sort"] = "";


t_layout.skins["gridcontrols"] = "";

t_layout.blocks["center"].Add("gridcontrols");
t_layout.containers["tabs"] = XVar.Array();
t_layout.containers["tabs"].Add(new XVar("name", "bsgrid_tabs", "block", "grid_tabs", "substyle", 1  ));

t_layout.skins["tabs"] = "";

t_layout.blocks["center"].Add("tabs");
t_layout.containers["messagerow"] = XVar.Array();
t_layout.containers["messagerow"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "message" ));
t_layout.containers["message"] = XVar.Array();
t_layout.containers["message"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["message"] = "";


t_layout.skins["messagerow"] = "";

t_layout.blocks["center"].Add("messagerow");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grid" ));
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "grid", "block", "grid_block", "substyle", 1  ));

t_layout.skins["grid"] = "";


t_layout.skins["center"] = "";

t_layout.blocks["center"].Add("center");
t_layout.containers["pagination"] = XVar.Array();
t_layout.containers["pagination"].Add(new XVar("name", "pagination", "block", "pagination_block", "substyle", 1  ));

t_layout.skins["pagination"] = "";

t_layout.blocks["center"].Add("pagination");
t_layout.blocks["left"] = XVar.Array();
t_layout.containers["left"] = XVar.Array();
t_layout.containers["left"].Add(new XVar("name", "searchpanel", "block", "searchPanel", "substyle", 1  ));

t_layout.containers["left"].Add(new XVar("name", "filterpanel", "block", "filterPanel", "substyle", 1  ));

t_layout.skins["left"] = "";

t_layout.blocks["left"].Add("left");
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more" ));
t_layout.containers["more"] = XVar.Array();
t_layout.containers["more"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["more"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["more"] = "";


t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "more_1" ));
t_layout.containers["more_1"] = XVar.Array();
t_layout.containers["more_1"].Add(new XVar("name", "search", "block", "searchform_block", "substyle", 1  ));

t_layout.skins["more_1"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.blocks["topmiddle"] = XVar.Array();
t_layout.containers["breadcrumbs"] = XVar.Array();
t_layout.containers["breadcrumbs"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bc" ));
t_layout.containers["bc"] = XVar.Array();
t_layout.containers["bc"].Add(new XVar("name", "breadcrumbs", "block", "breadcrumbs", "substyle", 1  ));

t_layout.skins["bc"] = "";


t_layout.skins["breadcrumbs"] = "";

t_layout.blocks["topmiddle"].Add("breadcrumbs");
t_layout.containers["masterinfo"] = XVar.Array();
t_layout.containers["masterinfo"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["masterinfo"] = "";

t_layout.blocks["topmiddle"].Add("masterinfo");
GlobalVars.page_layouts["public_swimmercontact_list"] = t_layout;


}

				pageMode = XVar.Clone(EditPage.readEditModeFromRequest());
				xt = XVar.UnPackXTempl(new XTempl());
				id = XVar.Clone(MVCFunctions.postvalue(new XVar("id")));
				id = XVar.Clone((XVar.Pack(MVCFunctions.intval((XVar)(id)) == 0) ? XVar.Pack(1) : XVar.Pack(id)));
				keys = XVar.Clone(XVar.Array());
				keys.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("editid1")), "id");
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(id, "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(keys, "keys");
				var_params.InitAndSetArrayItem(pageMode, "mode");
				var_params.InitAndSetArrayItem(Constants.PAGE_EDIT, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("a")), "action");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("fields")), "selectedFields");
						

				var_params.InitAndSetArrayItem("captcha_1209xre", "captchaName");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue((XVar)(MVCFunctions.Concat("value_captcha_1209xre_", id))), "captchaValue");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("selection")), "selection");
				var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("rowIds")))), "rowIds");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("mastertable")), "masterTable");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("action")), "lockingAction");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("sid")), "lockingSid");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("keys")), "lockingKeys");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("startEdit")), "lockingStart");
				if(pageMode == Constants.EDIT_INLINE)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("screenWidth")), "screenWidth");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("screenHeight")), "screenHeight");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("orientation")), "orientation");
				}
				if(pageMode == Constants.EDIT_DASHBOARD)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "dashTName");
					if(XVar.Pack(MVCFunctions.postvalue(new XVar("mapRefresh"))))
					{
						var_params.InitAndSetArrayItem(true, "mapRefresh");
						var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("vpCoordinates")))), "vpCoordinates");
					}
				}
				if((XVar)((XVar)(pageMode == Constants.EDIT_POPUP)  || (XVar)(pageMode == Constants.EDIT_INLINE))  && (XVar)(MVCFunctions.postvalue(new XVar("dashTName"))))
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashTName")), "dashTName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
				}
				if(XVar.Pack(var_params["masterTable"]))
				{
					var_params.InitAndSetArrayItem(EditPage.processMasterKeys(), "masterKeysReq");
				}
				GlobalVars.pageObject = XVar.Clone(EditPage.EditPageFactory((XVar)(var_params)));
				if(XVar.Pack(GlobalVars.pageObject.isLockingRequest()))
				{
					GlobalVars.pageObject.doLockingAction();
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
