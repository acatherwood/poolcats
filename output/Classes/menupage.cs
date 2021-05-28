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
	public partial class MenuPage : RunnerPage
	{
		protected static bool skipMenuPageCtor = false;
		public MenuPage(dynamic var_params)
			:base((XVar)var_params)
		{
			if(skipMenuPageCtor)
			{
				skipMenuPageCtor = false;
				return;
			}
		}
		public virtual XVar process()
		{
			dynamic redirect = null;
			if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeProcessLogin"))))
			{
				GlobalVars.globalEvents.BeforeProcessLogin(this);
			}
			redirect = XVar.Clone(getRedirectForMenuPage());
			if(XVar.Pack(redirect))
			{
				MVCFunctions.HeaderRedirect((XVar)(MVCFunctions.Concat("", redirect)));
				MVCFunctions.ob_flush();
				HttpContext.Current.Response.End();
				throw new RunnerInlineOutputException();
				return null;
			}
			commonAssign();
			doCommonAssignments();
			if(XVar.Pack(isPD()))
			{
				hideWelcomeItemsIfEmpty((XVar)(this.pSet.welcomeItems()));
			}
			addButtonHandlers();
			addCommonJs();
			displayMenuPage();
			return null;
		}
		public virtual XVar getRedirectForMenuPage()
		{
			dynamic i = null, menuNodes = XVar.Array(), redirect = null;
			if(XVar.Pack(isShowMenu()))
			{
				return "";
			}
			redirect = new XVar("");
			menuNodes = XVar.Clone(getMenuNodes());
			i = new XVar(0);
			for(;i < MVCFunctions.count(menuNodes); i++)
			{
				if(menuNodes[i]["linkType"] == "Internal")
				{
					if(XVar.Pack(isUserHaveTablePerm((XVar)(menuNodes[i]["table"]), (XVar)(menuNodes[i]["pageType"]))))
					{
						dynamic var_type = null;
						var_type = XVar.Clone(getPermisType((XVar)(menuNodes[i]["pageType"])));
						if(var_type == "A")
						{
							redirect = new XVar("add");
						}
						if(var_type == "E")
						{
							redirect = new XVar("edit");
						}
						else
						{
							if((XVar)(menuNodes[i]["pageType"] == "List")  && (XVar)(var_type == "S"))
							{
								redirect = new XVar("list");
							}
							else
							{
								if((XVar)(menuNodes[i]["pageType"] == "Report")  && (XVar)(var_type == "S"))
								{
									redirect = new XVar("report");
								}
								else
								{
									if((XVar)(menuNodes[i]["pageType"] == "Chart")  && (XVar)(var_type == "S"))
									{
										redirect = new XVar("chart");
									}
									else
									{
										if((XVar)(menuNodes[i]["pageType"] == "View")  && (XVar)(var_type == "S"))
										{
											redirect = new XVar("view");
										}
										else
										{
											if((XVar)(menuNodes[i]["pageType"] == "Dashboard")  && (XVar)(var_type == "S"))
											{
												redirect = new XVar("dashboard");
											}
										}
									}
								}
							}
						}
						redirect = XVar.Clone(MVCFunctions.GetTableLink((XVar)(CommonFunctions.GetTableURL((XVar)(menuNodes[i]["table"]))), (XVar)(redirect)));
					}
				}
			}
			if((XVar)(this.isDynamicPerm)  && (XVar)(CommonFunctions.IsAdmin()))
			{
				redirect = XVar.Clone(MVCFunctions.GetTableLink(new XVar("admin_rights"), new XVar("list")));
			}
			if(XVar.Pack(this.isAddWebRep))
			{
				redirect = XVar.Clone(MVCFunctions.GetTableLink(new XVar("webreport")));
			}
			return redirect;
		}
		protected virtual XVar doCommonAssignments()
		{
			setLangParams();
			this.xt.assign(new XVar("id"), (XVar)(this.id));
			this.xt.assign(new XVar("menu_block"), new XVar(true));
			assignBody();
			return null;
		}
		public virtual XVar hideWelcomeItemsIfEmpty(dynamic _param_itemsData)
		{
			#region pass-by-value parameters
			dynamic itemsData = XVar.Clone(_param_itemsData);
			#endregion

			dynamic hide = null;
			hide = new XVar(true);
			foreach (KeyValuePair<XVar, dynamic> itemData in itemsData.GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(itemData.Value["menutItem"])))
				{
					hide = new XVar(false);
					continue;
				}
				if(XVar.Pack(!(XVar)(itemData.Value["group"])))
				{
					if((XVar)(itemData.Value["table"])  && (XVar)(itemData.Value["page"]))
					{
						if(XVar.Pack(isUserHaveTablePerm((XVar)(itemData.Value["table"]), (XVar)(itemData.Value["page"]))))
						{
							hide = new XVar(false);
						}
						else
						{
							this.xt.displayItemHidden((XVar)(itemData.Key));
						}
					}
					continue;
				}
				if(XVar.Pack(!(XVar)(hideWelcomeGroupIfEmpty((XVar)(itemData.Key), (XVar)(itemData.Value)))))
				{
					hide = new XVar(false);
				}
			}
			return hide;
		}
		public virtual XVar hideWelcomeGroupIfEmpty(dynamic _param_grId, dynamic _param_grData)
		{
			#region pass-by-value parameters
			dynamic grId = XVar.Clone(_param_grId);
			dynamic grData = XVar.Clone(_param_grData);
			#endregion

			dynamic hide = null;
			if((XVar)(!(XVar)(grData["items"]))  || (XVar)(MVCFunctions.count(grData["items"]) < 1))
			{
				this.xt.displayItemHidden((XVar)(grId));
				return true;
			}
			hide = XVar.Clone(hideWelcomeItemsIfEmpty((XVar)(grData["items"])));
			if(XVar.Pack(hide))
			{
				this.xt.displayItemHidden((XVar)(grId));
			}
			return hide;
		}
		public virtual XVar displayMenuPage()
		{
			dynamic templatefile = null;
			templatefile = XVar.Clone(this.templatefile);
			if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeShowMenu"))))
			{
				GlobalVars.globalEvents.BeforeShowMenu((XVar)(this.xt), ref templatefile, this);
			}
			display((XVar)(templatefile));
			return null;
		}
	}
}
