
		// public.swimmersInfo
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
			public static partial class Options_public_swimmersInfo_list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", true,
"detailsAdd", true,
"inlineEdit", false,
"delete", true,
"updateSelected", false,
"addInPopup", null,
"clickSort", true,
"sortDropdown", false,
"showHideFields", false,
"reorderFields", false ),
"master", new XVar( "public.swimmerStats", new XVar( "preview", true ) ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"simpleSearchOptions", false,
"searchSaving", false ),
"totals", new XVar( "id", new XVar( "totalsType", "" ),
"first_name", new XVar( "totalsType", "" ),
"last_name", new XVar( "totalsType", "" ),
"birthdate", new XVar( "totalsType", "" ),
"suitSize", new XVar( "totalsType", "" ),
"suitType", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "id",
1, "first_name",
2, "last_name",
3, "birthdate",
4, "suitSize",
5, "suitType" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "birthdate",
1, "first_name",
2, "id",
3, "last_name",
4, "suitSize",
5, "suitType" ),
"filterFields", XVar.Array(),
"inlineAddFields", XVar.Array(),
"inlineEditFields", XVar.Array(),
"fieldItems", new XVar( "id", new XVar( 0, "simple_grid_field",
1, "simple_grid_field6" ),
"first_name", new XVar( 0, "simple_grid_field1",
1, "simple_grid_field7" ),
"last_name", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field8" ),
"birthdate", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field9" ),
"suitSize", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field10" ),
"suitType", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field11" ) ) ),
"pageLinks", new XVar( "edit", true,
"add", false,
"view", true,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu",
2, "simple_search",
3, "list_options",
4, "loginform_login",
5, "username_button" ),
"left", new XVar( 0, "search_panel" ),
"top", new XVar( 0, "breadcrumb",
1, "master_info" ),
"above-grid", new XVar( 0, "inline_add",
1, "inline_save_all",
2, "inline_cancel_all",
3, "delete",
4, "details_found",
5, "page_size" ),
"below-grid", new XVar( 0, "pagination" ),
"grid", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field",
2, "simple_grid_field7",
3, "simple_grid_field1",
4, "simple_grid_field8",
5, "simple_grid_field2",
6, "simple_grid_field9",
7, "simple_grid_field3",
8, "simple_grid_field10",
9, "simple_grid_field4",
10, "simple_grid_field11",
11, "simple_grid_field5",
12, "grid_edit",
13, "grid_inline_save",
14, "grid_inline_cancel",
15, "grid_view",
16, "grid_checkbox_head",
17, "grid_checkbox" ) ),
"formXtTags", new XVar( "top", new XVar( 0, "breadcrumb",
1, "mastertable_block" ),
"above-grid", new XVar( 0, "inlineadd_link",
1, "saveall_link",
2, "cancelall_link",
3, "deleteselected_link",
4, "records_indicator",
5, "recsPerPage" ),
"below-grid", new XVar( 0, "pagination" ) ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"loginform_login", "supertop",
"username_button", "supertop",
"search_panel", "left",
"breadcrumb", "top",
"master_info", "top",
"inline_add", "above-grid",
"inline_save_all", "above-grid",
"inline_cancel_all", "above-grid",
"delete", "above-grid",
"details_found", "above-grid",
"page_size", "above-grid",
"pagination", "below-grid",
"simple_grid_field6", "grid",
"simple_grid_field", "grid",
"simple_grid_field7", "grid",
"simple_grid_field1", "grid",
"simple_grid_field8", "grid",
"simple_grid_field2", "grid",
"simple_grid_field9", "grid",
"simple_grid_field3", "grid",
"simple_grid_field10", "grid",
"simple_grid_field4", "grid",
"simple_grid_field11", "grid",
"simple_grid_field5", "grid",
"grid_edit", "grid",
"grid_inline_save", "grid",
"grid_inline_cancel", "grid",
"grid_view", "grid",
"grid_checkbox_head", "grid",
"grid_checkbox", "grid" ),
"itemLocations", new XVar( "simple_grid_field6", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"grid_edit", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_inline_save", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_view", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_checkbox" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "cell_checkbox" ) ),
"itemVisiblity", new XVar( "menu", 3,
"simple_search", 3,
"list_options", 3,
"loginform_login", 3,
"username_button", 3,
"search_panel", 5 ) ),
"itemsByType", new XVar( "page_size", new XVar( 0, "page_size" ),
"details_found", new XVar( 0, "details_found" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"pagination", new XVar( 0, "pagination" ),
"search_panel", new XVar( 0, "search_panel" ),
"list_options", new XVar( 0, "list_options" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"search_panel_field", new XVar( 0, "search_panel_field",
1, "search_panel_field1",
2, "search_panel_field2",
3, "search_panel_field3",
4, "search_panel_field4",
5, "search_panel_field5" ),
"export", new XVar( 0, "export" ),
"-", new XVar( 0, "-",
1, "-1",
2, "-2",
3, "-3" ),
"export_selected", new XVar( 0, "export_selected" ),
"delete", new XVar( 0, "delete" ),
"delete_selected", new XVar( 0, "delete_selected" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"master_info", new XVar( 0, "master_info" ),
"inline_add", new XVar( 0, "inline_add" ),
"inline_save_all", new XVar( 0, "inline_save_all" ),
"inline_cancel_all", new XVar( 0, "inline_cancel_all" ),
"loginform_login", new XVar( 0, "loginform_login" ),
"username_button", new XVar( 0, "username_button" ),
"logout_link", new XVar( 0, "logout_link" ),
"grid_field", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1",
2, "simple_grid_field2",
3, "simple_grid_field3",
4, "simple_grid_field4",
5, "simple_grid_field5" ),
"grid_field_label", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field7",
2, "simple_grid_field8",
3, "simple_grid_field9",
4, "simple_grid_field10",
5, "simple_grid_field11" ),
"grid_edit", new XVar( 0, "grid_edit" ),
"grid_view", new XVar( 0, "grid_view" ),
"grid_checkbox", new XVar( 0, "grid_checkbox" ),
"grid_checkbox_head", new XVar( 0, "grid_checkbox_head" ),
"grid_inline_save", new XVar( 0, "grid_inline_save" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox_head" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "first_name_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "last_name_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "birthdate_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "suitSize_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "suitType_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "edit_column",
1, "inline_save",
2, "inline_cancel",
3, "view_column" ),
"items", new XVar( 0, "grid_edit",
1, "grid_inline_save",
2, "grid_inline_cancel",
3, "grid_view" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "first_name_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "last_name_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "birthdate_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "suitSize_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "suitType_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_checkbox", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 8,
"height", 3 ) ) ),
"loginForm", new XVar( "loginForm", 0 ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ),
"gridType", 0,
"recsPerRow", 1 ),
"misc", new XVar( "type", "list",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "list",
"type", "list",
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
1, "list_options",
2, "loginform_login",
3, "username_button" ),
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
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "breadcrumb" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c3", new XVar( "model", "c3",
"items", new XVar( 0, "master_info" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "list-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "inline_add",
1, "inline_save_all",
2, "inline_cancel_all",
3, "delete" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "details_found",
1, "page_size" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "list-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "pagination" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_icons" ),
1, new XVar( "cell", "headcell_checkbox" ),
2, new XVar( "cell", "headcell_field" ),
3, new XVar( "cell", "headcell_field1" ),
4, new XVar( "cell", "headcell_field2" ),
5, new XVar( "cell", "headcell_field3" ),
6, new XVar( "cell", "headcell_field4" ),
7, new XVar( "cell", "headcell_field5" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_icons" ),
1, new XVar( "cell", "cell_checkbox" ),
2, new XVar( "cell", "cell_field" ),
3, new XVar( "cell", "cell_field1" ),
4, new XVar( "cell", "cell_field2" ),
5, new XVar( "cell", "cell_field3" ),
6, new XVar( "cell", "cell_field4" ),
7, new XVar( "cell", "cell_field5" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_icons" ),
1, new XVar( "cell", "footcell_checkbox" ),
2, new XVar( "cell", "footcell_field" ),
3, new XVar( "cell", "footcell_field1" ),
4, new XVar( "cell", "footcell_field2" ),
5, new XVar( "cell", "footcell_field3" ),
6, new XVar( "cell", "footcell_field4" ),
7, new XVar( "cell", "footcell_field5" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "id",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "id",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "first_name",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "first_name",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "last_name",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "last_name",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "birthdate",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "birthdate",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "suitSize",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "suitSize",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "suitType",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "suitType",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_icons", new XVar( "model", "headcell_icons",
"items", XVar.Array(),
"columnName", "list-icons" ),
"cell_icons", new XVar( "model", "cell_icons",
"items", new XVar( 0, "grid_edit",
1, "grid_inline_save",
2, "grid_inline_cancel",
3, "grid_view" ),
"columnName", "list-icons" ),
"footcell_icons", new XVar( "model", "footcell_icons",
"items", XVar.Array(),
"columnName", "list-icons" ),
"headcell_checkbox", new XVar( "model", "headcell_checkbox",
"items", new XVar( 0, "grid_checkbox_head" ),
"columnName", "checkbox" ),
"cell_checkbox", new XVar( "model", "cell_checkbox",
"items", new XVar( 0, "grid_checkbox" ),
"columnName", "checkbox" ),
"footcell_checkbox", new XVar( "model", "footcell_checkbox",
"items", XVar.Array(),
"columnName", "checkbox" ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "page_size", new XVar( "type", "page_size" ),
"details_found", new XVar( "type", "details_found" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"pagination", new XVar( "type", "pagination" ),
"search_panel", new XVar( "type", "search_panel",
"items", new XVar( 0, "search_panel_field",
1, "search_panel_field5",
2, "search_panel_field4",
3, "search_panel_field3",
4, "search_panel_field2",
5, "search_panel_field1" ),
"flexiblePanel", true ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "export_selected",
1, "delete_selected",
2, "-3",
3, "advsearch_link",
4, "show_search_panel",
5, "hide_search_panel",
6, "-1",
7, "export" ) ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"search_panel_field", new XVar( "field", "birthdate",
"type", "search_panel_field",
"required", false ),
"search_panel_field1", new XVar( "field", "first_name",
"type", "search_panel_field",
"required", false ),
"search_panel_field2", new XVar( "field", "id",
"type", "search_panel_field",
"required", false ),
"search_panel_field3", new XVar( "field", "last_name",
"type", "search_panel_field",
"required", false ),
"export", new XVar( "type", "export" ),
"-", new XVar( "type", "-" ),
"export_selected", new XVar( "type", "export_selected" ),
"-1", new XVar( "type", "-" ),
"-2", new XVar( "type", "-" ),
"delete", new XVar( "type", "delete" ),
"delete_selected", new XVar( "type", "delete_selected" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-3", new XVar( "type", "-" ),
"master_info", new XVar( "type", "master_info",
"tables", new XVar( "public.swimmerStats", "true" ) ),
"inline_add", new XVar( "type", "inline_add" ),
"inline_save_all", new XVar( "type", "inline_save_all" ),
"inline_cancel_all", new XVar( "type", "inline_cancel_all" ),
"loginform_login", new XVar( "type", "loginform_login",
"popup", false ),
"username_button", new XVar( "type", "username_button",
"items", new XVar( 0, "logout_link" ) ),
"logout_link", new XVar( "type", "logout_link" ),
"search_panel_field4", new XVar( "field", "suitSize",
"type", "search_panel_field",
"required", false ),
"search_panel_field5", new XVar( "field", "suitType",
"type", "search_panel_field",
"required", false ),
"simple_grid_field", new XVar( "field", "id",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field6", new XVar( "type", "grid_field_label",
"field", "id" ),
"simple_grid_field1", new XVar( "field", "first_name",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field7", new XVar( "type", "grid_field_label",
"field", "first_name" ),
"simple_grid_field2", new XVar( "field", "last_name",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field8", new XVar( "type", "grid_field_label",
"field", "last_name" ),
"simple_grid_field3", new XVar( "field", "birthdate",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field9", new XVar( "type", "grid_field_label",
"field", "birthdate" ),
"simple_grid_field4", new XVar( "field", "suitSize",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field10", new XVar( "type", "grid_field_label",
"field", "suitSize" ),
"simple_grid_field5", new XVar( "field", "suitType",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "suitType" ),
"grid_edit", new XVar( "type", "grid_edit" ),
"grid_view", new XVar( "type", "grid_view" ),
"grid_checkbox", new XVar( "type", "grid_checkbox" ),
"grid_checkbox_head", new XVar( "type", "grid_checkbox_head" ),
"grid_inline_save", new XVar( "type", "grid_inline_save" ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}