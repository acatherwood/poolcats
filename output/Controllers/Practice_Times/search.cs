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
	public partial class Practice_TimesController : BaseController
	{
		public ActionResult search()
		{
			try
			{
				dynamic accessGranted = null, chrt_array = XVar.Array(), cname = null, id = null, layoutVersion = null, mode = null, pageObject = null, rname = null, templatefile = null, var_params = XVar.Array();
				XTempl xt;
				Practice_Times_Variables.Apply();
				CommonFunctions.add_nocache_headers();
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("search_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "Practice_Times_search";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["searchpage"] = XVar.Array();
t_layout.containers["searchpage"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "bssearchheader", "block", "searchheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.skins["searchpage"] = "";

t_layout.blocks["top"].Add("searchpage");
t_layout.containers["fields"] = XVar.Array();
t_layout.containers["fields"].Add(new XVar("name", "bssearchfields", "block", "", "substyle", 1  ));

t_layout.skins["fields"] = "";

t_layout.blocks["top"].Add("fields");
t_layout.containers["bottombuttons"] = XVar.Array();
t_layout.containers["bottombuttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "bbuttons" ));
t_layout.containers["bbuttons"] = XVar.Array();
t_layout.containers["bbuttons"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "leftbuttons" ));
t_layout.containers["leftbuttons"] = XVar.Array();
t_layout.containers["leftbuttons"].Add(new XVar("name", "srchbuttons", "block", "searchbuttons", "substyle", 1  ));

t_layout.skins["leftbuttons"] = "";


t_layout.skins["bbuttons"] = "";


t_layout.skins["bottombuttons"] = "";

t_layout.blocks["top"].Add("bottombuttons");
GlobalVars.page_layouts["Practice_Times_search"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				mode = new XVar(Constants.SEARCH_SIMPLE);
				if(MVCFunctions.postvalue(new XVar("mode")) == "dashsearch")
				{
					mode = new XVar(Constants.SEARCH_DASHBOARD);
				}
				else
				{
					if(MVCFunctions.postvalue(new XVar("mode")) == "inlineLoadCtrl")
					{
						mode = new XVar(Constants.SEARCH_LOAD_CONTROL);
						layoutVersion = XVar.Clone(MVCFunctions.postvalue(new XVar("layoutVersion")));
					}
				}
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(mode, "mode");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(Constants.PAGE_SEARCH, "pageType");
				var_params.InitAndSetArrayItem(cname, "chartName");
				var_params.InitAndSetArrayItem(rname, "reportName");
				var_params.InitAndSetArrayItem(templatefile, "templatefile");
				var_params.InitAndSetArrayItem("Practice_Times", "shortTableName");
				var_params.InitAndSetArrayItem(layoutVersion, "layoutVersion");
				var_params.InitAndSetArrayItem((XVar.Pack(MVCFunctions.postvalue(new XVar("searchControllerId"))) ? XVar.Pack(MVCFunctions.postvalue(new XVar("searchControllerId"))) : XVar.Pack(id)), "searchControllerId");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("ctrlField")), "ctrlField");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isNeedSettings")), "needSettings");
				if(mode == Constants.SEARCH_DASHBOARD)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "dashTName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
				}
				var_params.InitAndSetArrayItem(SearchPage.getExtraPageParams(), "extraPageParams");
				GlobalVars.pageObject = XVar.Clone(new SearchPage((XVar)(var_params)));
				if(mode == Constants.SEARCH_LOAD_CONTROL)
				{
					GlobalVars.pageObject.displaySearchControl();
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				if(mode == Constants.SEARCH_DASHBOARD)
				{
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
