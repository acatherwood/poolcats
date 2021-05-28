
		// Swimmers without Suits Report
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
			public static partial class Options_Swimmers_without_Suits_Report_report
			{
				static public XVar options()
				{
					return new XVar( "allDetails", new XVar( "linkType", 2 ),
"details", new XVar( "public.swimmersuit", new XVar( "displayPreview", 1,
"previewPageId", "list",
"showCount", false,
"hideEmptyChild", false,
"showProceedLink", true ) ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"simpleSearchOptions", false,
"searchSaving", false ),
"fields", new XVar( "gridFields", new XVar( 0, "suit_type",
1, "suit_size" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "swimmer",
1, "suit_type",
2, "suit_size" ),
"filterFields", XVar.Array(),
"fieldItems", new XVar( "swimmer", new XVar( 0, "report_group_field" ),
"suit_type", new XVar( 0, "report_grid_field" ),
"suit_size", new XVar( 0, "report_grid_field1" ) ) ),
"pdf", new XVar( "pdfView", false ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu",
2, "simple_search",
3, "list_options" ),
"left", new XVar( 0, "search_panel" ),
"top", new XVar( 0, "breadcrumb" ),
"above-grid", new XVar( 0, "details_preview",
1, "details_found",
2, "page_size",
3, "print_panel" ),
"below-grid", new XVar( 0, "pagination" ),
"grid", new XVar( 0, "report_group_field",
1, "report_grid_field",
2, "report_grid_field1" ) ),
"formXtTags", new XVar( "top", new XVar( 0, "breadcrumb" ),
"below-grid", new XVar( 0, "pagination" ) ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"search_panel", "left",
"breadcrumb", "top",
"details_preview", "above-grid",
"details_found", "above-grid",
"page_size", "above-grid",
"print_panel", "above-grid",
"pagination", "below-grid",
"report_group_field", "grid",
"report_grid_field", "grid",
"report_grid_field1", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar( "menu", 3,
"simple_search", 3,
"list_options", 3,
"search_panel", 5,
"print_panel", 5 ) ),
"itemsByType", new XVar( "page_size", new XVar( 0, "page_size" ),
"details_found", new XVar( 0, "details_found" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"pagination", new XVar( 0, "pagination" ),
"list_options", new XVar( 0, "list_options" ),
"export_report_excel", new XVar( 0, "export_report_excel" ),
"export_report_word", new XVar( 0, "export_report_word" ),
"search_panel", new XVar( 0, "search_panel" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"-", new XVar( 0, "-",
1, "-1" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"print_panel", new XVar( 0, "print_panel" ),
"print_scope", new XVar( 0, "print_scope" ),
"print_button", new XVar( 0, "print_button" ),
"print_records", new XVar( 0, "print_records" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"details_preview", new XVar( 0, "details_preview" ),
"report_group_field", new XVar( 0, "report_group_field" ),
"search_panel_field", new XVar( 0, "search_panel_field",
1, "search_panel_field1",
2, "search_panel_field2" ),
"report_grid_field", new XVar( 0, "report_grid_field",
1, "report_grid_field1" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"misc", new XVar( "type", "report",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "report",
"type", "report",
"layoutId", "topbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "topbar-menu",
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
1, "list_options" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"left", new XVar( "modelId", "list-vbar",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_panel" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "list-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "breadcrumb" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "report-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "details_preview" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "details_found",
1, "page_size",
2, "print_panel" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "report-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "pagination" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
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
"items", new XVar( 0, "report_grid_field",
1, "report_grid_field1" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "page_size", new XVar( "type", "page_size" ),
"details_found", new XVar( "type", "details_found" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"pagination", new XVar( "type", "pagination" ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "advsearch_link",
1, "show_search_panel",
2, "hide_search_panel",
3, "-1",
4, "export_report_excel",
5, "export_report_word" ) ),
"export_report_excel", new XVar( "type", "export_report_excel" ),
"export_report_word", new XVar( "type", "export_report_word" ),
"search_panel", new XVar( "type", "search_panel",
"items", new XVar( 0, "search_panel_field",
1, "search_panel_field2",
2, "search_panel_field1" ),
"flexiblePanel", true ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"-", new XVar( "type", "-" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"print_panel", new XVar( "type", "print_panel",
"items", new XVar( 0, "print_scope",
1, "print_records",
2, "print_button" ) ),
"print_scope", new XVar( "type", "print_scope" ),
"print_button", new XVar( "type", "print_button" ),
"print_records", new XVar( "type", "print_records" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-1", new XVar( "type", "-" ),
"details_preview", new XVar( "type", "details_preview",
"table", "public.swimmersuit",
"items", XVar.Array(),
"popup", false,
"proceedLink", true,
"pageId", "list" ),
"report_group_field", new XVar( "field", "swimmer",
"type", "report_group_field" ),
"search_panel_field", new XVar( "field", "swimmer",
"type", "search_panel_field",
"required", false ),
"report_grid_field", new XVar( "field", "suit_type",
"type", "report_grid_field" ),
"search_panel_field1", new XVar( "field", "suit_type",
"type", "search_panel_field",
"required", false ),
"report_grid_field1", new XVar( "field", "suit_size",
"type", "report_grid_field" ),
"search_panel_field2", new XVar( "field", "suit_size",
"type", "search_panel_field",
"required", false ) ),
"dbProps", new XVar(  ),
"version", 2,
"pageWidth", "standard",
"pageAlign", "center" );
				}
			}
		}