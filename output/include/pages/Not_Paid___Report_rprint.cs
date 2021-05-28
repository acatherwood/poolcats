
		// Not Paid - Report
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
			public static partial class Options_Not_Paid___Report_rprint
			{
				static public XVar options()
				{
					return new XVar( "details", new XVar( "public.swimmerpayment", new XVar( "displayPreview", 2,
"previewPageId", "" ),
"public.swimmersuit", new XVar( "displayPreview", 2,
"previewPageId", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "first_name" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "first_name", new XVar( 0, "report_grid_field1" ),
"last_name", new XVar( 0, "report_group_field" ) ) ),
"pdf", new XVar( "pdfView", false ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "print_header",
1, "print_subheader" ),
"above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array(),
"grid", new XVar( 0, "report_group_field",
1, "report_grid_field1" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "print_pages" ),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "print_header", "top",
"print_subheader", "top",
"print_pages", "above-grid",
"report_group_field", "grid",
"report_grid_field1", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "print_header", new XVar( 0, "print_header" ),
"print_subheader", new XVar( 0, "print_subheader" ),
"print_pages", new XVar( 0, "print_pages" ),
"report_grid_field", new XVar( 0, "report_grid_field1" ),
"report_group_field", new XVar( 0, "report_group_field" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar( "print_pages", new XVar( "tag", "PRINT_PAGES",
"type", 2 ) ) ) ),
"misc", new XVar( "type", "rprint",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "rprint",
"type", "rprint",
"layoutId", "basic",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "print-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", new XVar( 0, "print_header",
1, "print_subheader" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "print-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "print_pages" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "print-below-grid",
"grid", XVar.Array(),
"cells", new XVar(  ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "report-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "report_group_field" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "report_grid_field1" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "print_header", new XVar( "type", "print_header" ),
"print_subheader", new XVar( "type", "print_subheader" ),
"print_pages", new XVar( "type", "print_pages" ),
"report_grid_field1", new XVar( "field", "first_name",
"type", "report_grid_field" ),
"report_group_field", new XVar( "field", "last_name",
"type", "report_group_field" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}