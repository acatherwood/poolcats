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
	public partial class Swimmers_Without_Suits___ReportController : BaseController
	{
		public ActionResult print()
		{
			try
			{
				dynamic pageObject = null, var_params = XVar.Array();
				XTempl xt;
				Swimmers_Without_Suits___Report_Variables.Apply();
				if((XVar)(MVCFunctions.postvalue("format") != "excel")  && (XVar)(MVCFunctions.postvalue("format") != "word"))
				{
					CommonFunctions.add_nocache_headers();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("rprint_bootstrap"), new XVar("OfficeOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "cerulean";
			t_layout.customCssPageName = "Swimmers_Without_Suits___Report_rprint";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["pdf"] = XVar.Array();
t_layout.containers["pdf"].Add(new XVar("name", "printbuttons", "block", "printbuttons", "substyle", 1  ));

t_layout.skins["pdf"] = "";

t_layout.blocks["top"].Add("pdf");
t_layout.containers["master"] = XVar.Array();
t_layout.containers["master"].Add(new XVar("name", "masterinfo", "block", "mastertable_block", "substyle", 1  ));

t_layout.skins["master"] = "";

t_layout.blocks["top"].Add("master");
t_layout.containers["pageheader"] = XVar.Array();
t_layout.containers["pageheader"].Add(new XVar("name", "printheader", "block", "printheader", "substyle", 1  ));

t_layout.containers["pageheader"].Add(new XVar("name", "page_of_print", "block", "page_number", "substyle", 1  ));

t_layout.skins["pageheader"] = "";

t_layout.blocks["top"].Add("pageheader");
t_layout.containers["grid"] = XVar.Array();
t_layout.containers["grid"].Add(new XVar("name", "report_print", "block", "", "substyle", 1  ));

t_layout.skins["grid"] = "";

t_layout.blocks["top"].Add("grid");
GlobalVars.page_layouts["Swimmers_Without_Suits___Report_rprint"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(Constants.REPORT_SIMPLE, "mode");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(Constants.PAGE_RPRINT, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("all")), "allPagesMode");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("pdf")), "pdfMode");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("exportPdf")), "exportPdf");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("htmlPdfContent")), "pdfContent");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("width")), "pdfWidth");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("format")), "format");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("records")), "splitByGroups");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("x")), "x");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("y")), "y");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("data")), "dataField");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("op")), "operation");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("xtype")), "xType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("ytype")), "yType");
				GlobalVars.pageObject = XVar.Clone(new ReportPrintPage((XVar)(var_params)));
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
