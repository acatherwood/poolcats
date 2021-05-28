
		// Dashboard
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
			public static partial class Options_Dashboard_dashboard
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu",
2, "simple_search",
3, "loginform_login",
4, "username_button" ),
"top", new XVar( 0, "breadcrumb" ),
"grid", XVar.Array() ),
"formXtTags", new XVar( "top", new XVar( 0, "breadcrumb" ),
"grid", XVar.Array() ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"simple_search", "supertop",
"loginform_login", "supertop",
"username_button", "supertop",
"breadcrumb", "top" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar( "menu", 3,
"simple_search", 3,
"loginform_login", 3,
"username_button", 3 ) ),
"itemsByType", new XVar( "breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"loginform_login", new XVar( 0, "loginform_login" ),
"username_button", new XVar( 0, "username_button" ),
"logout_link", new XVar( 0, "logout_link" ) ),
"cellMaps", new XVar(  ) ),
"loginForm", new XVar( "loginForm", 0 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"misc", new XVar( "type", "dashboard",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "dashboard",
"type", "dashboard",
"layoutId", "topbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "topbar-dashboard",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "logo",
1, "menu" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "simple_search",
1, "loginform_login",
2, "username_button" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "dashboard-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "breadcrumb" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "dashboard-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"loginform_login", new XVar( "type", "loginform_login",
"popup", false ),
"username_button", new XVar( "type", "username_button",
"items", new XVar( 0, "logout_link" ) ),
"logout_link", new XVar( "type", "logout_link" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}