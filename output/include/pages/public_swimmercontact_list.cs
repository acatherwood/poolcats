
		// public.swimmercontact
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
			public static partial class Options_public_swimmercontact_list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", false,
"detailsAdd", true,
"inlineEdit", true,
"delete", true,
"updateSelected", false,
"editInPopup", null,
"viewInPopup", null,
"clickSort", true,
"sortDropdown", false,
"showHideFields", false,
"reorderFields", false ),
"master", new XVar( "public.swimmer", new XVar( "preview", true ) ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"simpleSearchOptions", false,
"searchSaving", false ),
"totals", new XVar( "id", new XVar( "totalsType", "" ),
"swimmer_id", new XVar( "totalsType", "" ),
"parent_name", new XVar( "totalsType", "" ),
"address", new XVar( "totalsType", "" ),
"city", new XVar( "totalsType", "" ),
"state", new XVar( "totalsType", "" ),
"zip_code", new XVar( "totalsType", "" ),
"phone", new XVar( "totalsType", "" ),
"email", new XVar( "totalsType", "" ),
"emergency_contact", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "parent_name",
1, "phone",
2, "email",
3, "address",
4, "city",
5, "state",
6, "zip_code",
7, "emergency_contact" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "address",
1, "city",
2, "email",
3, "emergency_contact",
4, "id",
5, "parent_name",
6, "phone",
7, "state",
8, "zip_code",
9, "swimmer_id" ),
"filterFields", XVar.Array(),
"inlineAddFields", new XVar( 0, "parent_name",
1, "phone",
2, "email",
3, "address",
4, "city",
5, "state",
6, "zip_code",
7, "emergency_contact" ),
"inlineEditFields", new XVar( 0, "parent_name",
1, "phone",
2, "email",
3, "address",
4, "city",
5, "state",
6, "zip_code",
7, "emergency_contact" ),
"fieldItems", new XVar( "parent_name", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field" ),
"phone", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field10" ),
"email", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field11" ),
"address", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field12" ),
"city", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field13" ),
"state", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field14" ),
"zip_code", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field15" ),
"emergency_contact", new XVar( 0, "simple_grid_field9",
1, "simple_grid_field16" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", true,
"view", false,
"print", true ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", new XVar( 0, "logo",
1, "menu",
2, "simple_search",
3, "list_options" ),
"left", new XVar( 0, "search_panel" ),
"top", new XVar( 0, "breadcrumb",
1, "master_info" ),
"above-grid", new XVar( 0, "add",
1, "inline_add",
2, "inline_save_all",
3, "inline_cancel_all",
4, "delete",
5, "details_found",
6, "page_size",
7, "print_panel" ),
"below-grid", new XVar( 0, "pagination" ),
"grid", new XVar( 0, "simple_grid_field",
1, "simple_grid_field2",
2, "simple_grid_field10",
3, "simple_grid_field7",
4, "simple_grid_field11",
5, "simple_grid_field8",
6, "simple_grid_field12",
7, "simple_grid_field3",
8, "simple_grid_field13",
9, "simple_grid_field4",
10, "simple_grid_field14",
11, "simple_grid_field5",
12, "simple_grid_field15",
13, "simple_grid_field6",
14, "simple_grid_field16",
15, "simple_grid_field9",
16, "grid_inline_edit",
17, "grid_inline_save",
18, "grid_inline_cancel",
19, "grid_checkbox_head",
20, "grid_checkbox" ) ),
"formXtTags", new XVar( "top", new XVar( 0, "breadcrumb",
1, "mastertable_block" ),
"above-grid", new XVar( 0, "add_link",
1, "inlineadd_link",
2, "saveall_link",
3, "cancelall_link",
4, "deleteselected_link",
5, "records_indicator",
6, "recsPerPage",
7, "print_friendly" ),
"below-grid", new XVar( 0, "pagination" ) ),
"itemForms", new XVar( "logo", "supertop",
"menu", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"search_panel", "left",
"breadcrumb", "top",
"master_info", "top",
"add", "above-grid",
"inline_add", "above-grid",
"inline_save_all", "above-grid",
"inline_cancel_all", "above-grid",
"delete", "above-grid",
"details_found", "above-grid",
"page_size", "above-grid",
"print_panel", "above-grid",
"pagination", "below-grid",
"simple_grid_field", "grid",
"simple_grid_field2", "grid",
"simple_grid_field10", "grid",
"simple_grid_field7", "grid",
"simple_grid_field11", "grid",
"simple_grid_field8", "grid",
"simple_grid_field12", "grid",
"simple_grid_field3", "grid",
"simple_grid_field13", "grid",
"simple_grid_field4", "grid",
"simple_grid_field14", "grid",
"simple_grid_field5", "grid",
"simple_grid_field15", "grid",
"simple_grid_field6", "grid",
"simple_grid_field16", "grid",
"simple_grid_field9", "grid",
"grid_inline_edit", "grid",
"grid_inline_save", "grid",
"grid_inline_cancel", "grid",
"grid_checkbox_head", "grid",
"grid_checkbox", "grid" ),
"itemLocations", new XVar( "simple_grid_field", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field15", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field6" ),
"simple_grid_field16", new XVar( "location", "grid",
"cellId", "headcell_field7" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "cell_field7" ),
"grid_inline_edit", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_inline_save", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "cell_icons" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_checkbox" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "cell_checkbox" ) ),
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
"search_panel", new XVar( 0, "search_panel" ),
"list_options", new XVar( 0, "list_options" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"search_panel_field", new XVar( 0, "search_panel_field",
1, "search_panel_field1",
2, "search_panel_field2",
3, "search_panel_field3",
4, "search_panel_field4",
5, "search_panel_field5",
6, "search_panel_field6",
7, "search_panel_field7",
8, "search_panel_field9",
9, "search_panel_field10" ),
"print_panel", new XVar( 0, "print_panel" ),
"print_scope", new XVar( 0, "print_scope" ),
"print_button", new XVar( 0, "print_button" ),
"print_records", new XVar( 0, "print_records" ),
"export", new XVar( 0, "export" ),
"-", new XVar( 0, "-",
1, "-1",
2, "-2",
3, "-3" ),
"export_selected", new XVar( 0, "export_selected" ),
"import", new XVar( 0, "import" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"master_info", new XVar( 0, "master_info" ),
"add", new XVar( 0, "add" ),
"edit_selected", new XVar( 0, "edit_selected" ),
"inline_save_all", new XVar( 0, "inline_save_all" ),
"inline_cancel_all", new XVar( 0, "inline_cancel_all" ),
"delete", new XVar( 0, "delete" ),
"delete_selected", new XVar( 0, "delete_selected" ),
"grid_field", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field7",
2, "simple_grid_field8",
3, "simple_grid_field3",
4, "simple_grid_field4",
5, "simple_grid_field5",
6, "simple_grid_field6",
7, "simple_grid_field9" ),
"grid_field_label", new XVar( 0, "simple_grid_field",
1, "simple_grid_field10",
2, "simple_grid_field11",
3, "simple_grid_field12",
4, "simple_grid_field13",
5, "simple_grid_field14",
6, "simple_grid_field15",
7, "simple_grid_field16" ),
"grid_inline_edit", new XVar( 0, "grid_inline_edit" ),
"grid_inline_save", new XVar( 0, "grid_inline_save" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ),
"grid_checkbox_head", new XVar( 0, "grid_checkbox_head" ),
"grid_checkbox", new XVar( 0, "grid_checkbox" ),
"inline_add", new XVar( 0, "inline_add" ) ),
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
"tags", new XVar( 0, "parent_name_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "phone_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "email_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "address_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "city_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "state_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "zip_code_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field15" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field7", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "emergency_contact_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field16" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "inlineedit_column",
1, "inline_save",
2, "inline_cancel" ),
"items", new XVar( 0, "grid_inline_edit",
1, "grid_inline_save",
2, "grid_inline_cancel" ),
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
"tags", new XVar( 0, "parent_name_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "phone_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "email_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "address_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "city_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "state_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "zip_code_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field7", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "emergency_contact_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
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
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field7", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 10,
"height", 3 ) ) ),
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
"items", new XVar( 0, "add",
1, "inline_add",
2, "inline_save_all",
3, "inline_cancel_all",
4, "delete" ),
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
7, new XVar( "cell", "headcell_field5" ),
8, new XVar( "cell", "headcell_field6" ),
9, new XVar( "cell", "headcell_field7" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_icons" ),
1, new XVar( "cell", "cell_checkbox" ),
2, new XVar( "cell", "cell_field" ),
3, new XVar( "cell", "cell_field1" ),
4, new XVar( "cell", "cell_field2" ),
5, new XVar( "cell", "cell_field3" ),
6, new XVar( "cell", "cell_field4" ),
7, new XVar( "cell", "cell_field5" ),
8, new XVar( "cell", "cell_field6" ),
9, new XVar( "cell", "cell_field7" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_icons" ),
1, new XVar( "cell", "footcell_checkbox" ),
2, new XVar( "cell", "footcell_field" ),
3, new XVar( "cell", "footcell_field1" ),
4, new XVar( "cell", "footcell_field2" ),
5, new XVar( "cell", "footcell_field3" ),
6, new XVar( "cell", "footcell_field4" ),
7, new XVar( "cell", "footcell_field5" ),
8, new XVar( "cell", "footcell_field6" ),
9, new XVar( "cell", "footcell_field7" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "parent_name",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "parent_name",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "phone",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "phone",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "email",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "email",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "address",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "address",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "city",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "city",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"field", "state",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "state",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field15" ),
"field", "zip_code",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "zip_code",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field7", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field16" ),
"field", "emergency_contact",
"columnName", "field" ),
"cell_field7", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "emergency_contact",
"columnName", "field" ),
"footcell_field7", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_icons", new XVar( "model", "headcell_icons",
"items", XVar.Array(),
"columnName", "inline-edit" ),
"cell_icons", new XVar( "model", "cell_icons",
"items", new XVar( 0, "grid_inline_edit",
1, "grid_inline_save",
2, "grid_inline_cancel" ),
"columnName", "inline-edit" ),
"footcell_icons", new XVar( "model", "footcell_icons",
"items", XVar.Array(),
"columnName", "inline-edit" ),
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
1, "search_panel_field4",
2, "search_panel_field10",
3, "search_panel_field9",
4, "search_panel_field7",
5, "search_panel_field6",
6, "search_panel_field5",
7, "search_panel_field3",
8, "search_panel_field2",
9, "search_panel_field1" ),
"flexiblePanel", true ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "edit_selected",
1, "export_selected",
2, "delete_selected",
3, "-3",
4, "advsearch_link",
5, "show_search_panel",
6, "hide_search_panel",
7, "-1",
8, "export",
9, "-2",
10, "import" ) ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"search_panel_field", new XVar( "field", "address",
"type", "search_panel_field",
"required", false ),
"search_panel_field1", new XVar( "field", "city",
"type", "search_panel_field",
"required", false ),
"search_panel_field2", new XVar( "field", "email",
"type", "search_panel_field",
"required", false ),
"search_panel_field3", new XVar( "field", "emergency_contact",
"type", "search_panel_field",
"required", false ),
"search_panel_field4", new XVar( "field", "id",
"type", "search_panel_field",
"required", false ),
"search_panel_field5", new XVar( "field", "parent_name",
"type", "search_panel_field",
"required", false ),
"search_panel_field6", new XVar( "field", "phone",
"type", "search_panel_field",
"required", false ),
"search_panel_field7", new XVar( "field", "state",
"type", "search_panel_field",
"required", false ),
"search_panel_field9", new XVar( "field", "zip_code",
"type", "search_panel_field",
"required", false ),
"print_panel", new XVar( "type", "print_panel",
"items", new XVar( 0, "print_scope",
1, "print_records",
2, "print_button" ) ),
"print_scope", new XVar( "type", "print_scope" ),
"print_button", new XVar( "type", "print_button" ),
"print_records", new XVar( "type", "print_records" ),
"export", new XVar( "type", "export" ),
"-", new XVar( "type", "-" ),
"export_selected", new XVar( "type", "export_selected" ),
"-1", new XVar( "type", "-" ),
"import", new XVar( "type", "import" ),
"-2", new XVar( "type", "-" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-3", new XVar( "type", "-" ),
"master_info", new XVar( "type", "master_info",
"tables", new XVar( "public.swimmer", "true" ) ),
"search_panel_field10", new XVar( "field", "swimmer_id",
"type", "search_panel_field",
"required", false ),
"add", new XVar( "type", "add" ),
"edit_selected", new XVar( "type", "edit_selected" ),
"inline_save_all", new XVar( "type", "inline_save_all" ),
"inline_cancel_all", new XVar( "type", "inline_cancel_all" ),
"delete", new XVar( "type", "delete" ),
"delete_selected", new XVar( "type", "delete_selected" ),
"simple_grid_field2", new XVar( "field", "parent_name",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field", new XVar( "type", "grid_field_label",
"field", "parent_name" ),
"simple_grid_field7", new XVar( "field", "phone",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field10", new XVar( "type", "grid_field_label",
"field", "phone" ),
"simple_grid_field8", new XVar( "field", "email",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "email" ),
"simple_grid_field3", new XVar( "field", "address",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field12", new XVar( "type", "grid_field_label",
"field", "address" ),
"simple_grid_field4", new XVar( "field", "city",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "city" ),
"simple_grid_field5", new XVar( "field", "state",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field14", new XVar( "type", "grid_field_label",
"field", "state" ),
"simple_grid_field6", new XVar( "field", "zip_code",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field15", new XVar( "type", "grid_field_label",
"field", "zip_code" ),
"simple_grid_field9", new XVar( "field", "emergency_contact",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field16", new XVar( "type", "grid_field_label",
"field", "emergency_contact" ),
"grid_inline_edit", new XVar( "type", "grid_inline_edit" ),
"grid_inline_save", new XVar( "type", "grid_inline_save" ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ),
"grid_checkbox_head", new XVar( "type", "grid_checkbox_head" ),
"grid_checkbox", new XVar( "type", "grid_checkbox" ),
"inline_add", new XVar( "type", "inline_add",
"detailsOnly", true ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}