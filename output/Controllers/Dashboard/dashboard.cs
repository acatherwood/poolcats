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
	public partial class DashboardController : BaseController
	{
		public ActionResult dashboard()
		{
			try
			{
				dynamic id = null, mode = null, pageObject = null, strtablename = null, var_params = XVar.Array();
				XTempl xt;
				Dashboard_Variables.Apply();
				CommonFunctions.add_nocache_headers();
				if(XVar.Pack(!(XVar)(Security.processPageSecurity((XVar)(strtablename), new XVar("S")))))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("dashboard_bootstrap1"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "Dashboard_dashboard";
t_layout.blocks["bottom"] = XVar.Array();
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
t_layout.containers["more_1"].Add(new XVar("name", "search_dashboard", "block", "", "substyle", 1  ));

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
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "grid" ));
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "dashboard", "block", "", "substyle", 1  ));

t_layout.skins["grid"] = "";


t_layout.skins["center"] = "";

t_layout.blocks["topmiddle"].Add("center");
GlobalVars.page_layouts["Dashboard_dashboard"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				id = XVar.Clone(MVCFunctions.postvalue(new XVar("id")));
				mode = XVar.Clone(MVCFunctions.postvalue(new XVar("mode")));
				id = XVar.Clone((XVar.Pack(id != XVar.Pack("")) ? XVar.Pack(id) : XVar.Pack(1)));
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(id, "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(mode, "mode");
				var_params.InitAndSetArrayItem(Constants.PAGE_DASHBOARD, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(MVCFunctions.GetTemplateName(new XVar("Dashboard"), new XVar("dashboard")), "templatefile");
				GlobalVars.pageObject = XVar.Clone(new DashboardPage((XVar)(var_params)));
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
