
		// <global>
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
			public static partial class Options____global____menu
			{
				static public XVar options()
				{
					return new XVar( "welcome", new XVar( "welcomeItems", new XVar( "logo", new XVar( "menutItem", false ),
"menu", new XVar( "menutItem", false ),
"welcome_group1", new XVar( "menutItem", true,
"group", true,
"items", new XVar( "welcome_item", new XVar( "menutItem", true,
"group", false,
"items", null,
"table", "public.swimmer",
"page", "list" ),
"welcome_item4", new XVar( "menutItem", true,
"group", false,
"items", null,
"table", "public.swimmercontact",
"page", "list" ),
"welcome_item1", new XVar( "menutItem", true,
"group", false,
"items", null,
"table", "public.swimmersuit",
"page", "list" ),
"welcome_item3", new XVar( "menutItem", true,
"group", false,
"items", null,
"table", "public.swimmerpayment",
"page", "list" ) ) ),
"welcome_group", new XVar( "menutItem", true,
"group", true,
"items", new XVar( "welcome_item2", new XVar( "menutItem", true,
"group", false,
"items", null,
"table", "Swimmers Without Suits - Report",
"page", "report" ),
"welcome_item5", new XVar( "menutItem", true,
"group", false,
"items", null,
"table", "Not Paid - Report",
"page", "report" ) ) ) ) ),
"fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu" ),
"above-grid", XVar.Array(),
"grid", new XVar( 0, "welcome_group1",
1, "welcome_group" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"welcome_group1", "grid",
"welcome_group", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar( "menu", 3 ) ),
"itemsByType", new XVar( "logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"welcome_item", new XVar( 0, "welcome_item1",
1, "welcome_item",
2, "welcome_item2",
3, "welcome_item3",
4, "welcome_item5",
5, "welcome_item4" ),
"welcome_group", new XVar( 0, "welcome_group",
1, "welcome_group1" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "menu",
"type", "menu",
"layoutId", "topbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "menu-topbar-menu",
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
"items", XVar.Array(),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "empty-above-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "welcome",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c" ) ),
"section", "" ),
2, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "welcome_group1" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c", new XVar( "model", "c1",
"items", new XVar( 0, "welcome_group" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c1",
"items", XVar.Array(),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"welcome_item1", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "public.swimmersuit",
"linkPage", "list",
"linkText", new XVar( "table", "public.swimmersuit",
"type", 6 ),
"linkIcon", new XVar( "fa", "star-o" ),
"linkComments", new XVar( "text", "Suit Table - hide?",
"type", 0 ) ),
"welcome_item", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "public.swimmer",
"linkPage", "list",
"linkText", new XVar( "table", "public.swimmer",
"type", 6 ),
"linkIcon", new XVar( "glyph", "bookmark" ),
"linkComments", new XVar( "text", "Swimmer and all details",
"type", 0 ) ),
"welcome_item2", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "Swimmers Without Suits - Report",
"linkPage", "report",
"linkText", new XVar( "table", "Swimmers Without Suits - Report",
"type", 6 ),
"linkIcon", new XVar( "glyph", "asterisk" ),
"linkComments", new XVar( "text", "We don't have sizes or types for these swimmers",
"type", 0 ) ),
"welcome_item3", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "public.swimmerpayment",
"linkPage", "list",
"linkIcon", new XVar( "fa", "money" ),
"linkComments", new XVar( "text", "Payment table - hide?",
"type", 0 ) ),
"welcome_item5", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "Not Paid - Report",
"linkPage", "report",
"linkText", new XVar( "table", "Not Paid - Report",
"type", 6 ),
"linkIcon", new XVar( "glyph", "minus" ),
"linkComments", new XVar( "type", 0,
"text", "These people haven't paid us" ) ),
"welcome_item4", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "public.swimmercontact",
"linkPage", "list",
"linkText", new XVar( "type", 0,
"text", "Contact" ),
"linkIcon", new XVar( "glyph", "phone-alt" ),
"linkComments", new XVar( "type", 0,
"text", "Emergency conact info" ) ),
"welcome_group", new XVar( "type", "welcome_group",
"linkText", new XVar( "text", "Reports",
"type", 0 ),
"items", new XVar( 0, "welcome_item2",
1, "welcome_item5" ) ),
"welcome_group1", new XVar( "type", "welcome_group",
"linkText", new XVar( "text", "Swimmer Info",
"type", 0 ),
"items", new XVar( 0, "welcome_item",
1, "welcome_item4",
2, "welcome_item1",
3, "welcome_item3" ) ) ),
"dbProps", new XVar(  ),
"version", 2,
"menuWidth", "full",
"pageAlign", "center" );
				}
			}
		}