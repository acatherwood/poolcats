
		// Not Paid Report
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
			public static partial class Options_Not_Paid_Report_search
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "swimmer" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "swimmer", new XVar( 0, "integrated_search_field" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "search_header" ),
"above-grid", XVar.Array(),
"below-grid", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list" ),
"grid", new XVar( 0, "integrated_search_field" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "search_header", "top",
"search_search", "below-grid",
"search_reset", "below-grid",
"search_back_list", "below-grid",
"integrated_search_field", "grid" ),
"itemLocations", new XVar( "integrated_search_field", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "search_header", new XVar( 0, "search_header" ),
"search_reset", new XVar( 0, "search_reset" ),
"search_back_list", new XVar( 0, "search_back_list" ),
"search_search", new XVar( 0, "search_search" ),
"integrated_search_field", new XVar( 0, "integrated_search_field" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_search_field" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"misc", new XVar( "type", "search",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "search",
"type", "search",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "search-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "search-above-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "search-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-search",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_search_field" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"separateLabels", false ) ),
"items", new XVar( "search_header", new XVar( "type", "search_header" ),
"search_reset", new XVar( "type", "search_reset" ),
"search_back_list", new XVar( "type", "search_back_list" ),
"search_search", new XVar( "type", "search_search" ),
"integrated_search_field", new XVar( "field", "swimmer",
"type", "integrated_search_field",
"orientation", 0,
"required", false ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}