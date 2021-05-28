
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
			public static partial class Options_public_swimmercontact_print
			{
				static public XVar options()
				{
					return new XVar( "master", new XVar( "public.swimmer", new XVar( "preview", false ) ),
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
1, "address",
2, "city",
3, "state",
4, "zip_code",
5, "phone",
6, "email",
7, "emergency_contact",
8, "swimmer_id",
9, "id" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "parent_name", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field11" ),
"address", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field12" ),
"city", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field13" ),
"state", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field14" ),
"zip_code", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field15" ),
"phone", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field16" ),
"email", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field17" ),
"emergency_contact", new XVar( 0, "simple_grid_field9",
1, "simple_grid_field18" ),
"swimmer_id", new XVar( 0, "simple_grid_field10",
1, "simple_grid_field19" ),
"id", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1" ) ) ),
"pdf", new XVar( "pdfView", false ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "print_header",
1, "print_subheader" ),
"above-grid", new XVar( 0, "print_pages",
1, "inline_add" ),
"below-grid", XVar.Array(),
"grid", new XVar( 0, "simple_grid_field11",
1, "simple_grid_field2",
2, "simple_grid_field12",
3, "simple_grid_field3",
4, "simple_grid_field13",
5, "simple_grid_field4",
6, "simple_grid_field14",
7, "simple_grid_field5",
8, "simple_grid_field15",
9, "simple_grid_field6",
10, "simple_grid_field16",
11, "simple_grid_field7",
12, "simple_grid_field17",
13, "simple_grid_field8",
14, "simple_grid_field18",
15, "simple_grid_field9",
16, "simple_grid_field19",
17, "simple_grid_field10",
18, "simple_grid_field1",
19, "simple_grid_field",
20, "grid_inline_cancel" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "print_pages",
1, "inlineadd_link" ),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "print_header", "top",
"print_subheader", "top",
"print_pages", "above-grid",
"inline_add", "above-grid",
"simple_grid_field11", "grid",
"simple_grid_field2", "grid",
"simple_grid_field12", "grid",
"simple_grid_field3", "grid",
"simple_grid_field13", "grid",
"simple_grid_field4", "grid",
"simple_grid_field14", "grid",
"simple_grid_field5", "grid",
"simple_grid_field15", "grid",
"simple_grid_field6", "grid",
"simple_grid_field16", "grid",
"simple_grid_field7", "grid",
"simple_grid_field17", "grid",
"simple_grid_field8", "grid",
"simple_grid_field18", "grid",
"simple_grid_field9", "grid",
"simple_grid_field19", "grid",
"simple_grid_field10", "grid",
"simple_grid_field1", "grid",
"simple_grid_field", "grid",
"grid_inline_cancel", "grid" ),
"itemLocations", new XVar( "simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field15", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field16", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field17", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "cell_field6" ),
"simple_grid_field18", new XVar( "location", "grid",
"cellId", "headcell_field7" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "cell_field7" ),
"simple_grid_field19", new XVar( "location", "grid",
"cellId", "headcell_field8" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "cell_field8" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "headcell_field9" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field9" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "cell_icons" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "print_header", new XVar( 0, "print_header" ),
"print_subheader", new XVar( 0, "print_subheader" ),
"print_pages", new XVar( 0, "print_pages" ),
"grid_field", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field3",
2, "simple_grid_field4",
3, "simple_grid_field5",
4, "simple_grid_field6",
5, "simple_grid_field7",
6, "simple_grid_field8",
7, "simple_grid_field9",
8, "simple_grid_field10",
9, "simple_grid_field" ),
"grid_field_label", new XVar( 0, "simple_grid_field11",
1, "simple_grid_field12",
2, "simple_grid_field13",
3, "simple_grid_field14",
4, "simple_grid_field15",
5, "simple_grid_field16",
6, "simple_grid_field17",
7, "simple_grid_field18",
8, "simple_grid_field19",
9, "simple_grid_field1" ),
"inline_add", new XVar( 0, "inline_add" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "parent_name_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "address_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "city_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "state_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "zip_code_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field15" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "phone_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field16" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "email_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field17" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field7", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "emergency_contact_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field18" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field8", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "swimmer_id_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field19" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field9", new XVar( "cols", new XVar( 0, 10 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "id_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "inline_cancel" ),
"items", new XVar( 0, "grid_inline_cancel" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "parent_name_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "address_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "city_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "state_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "zip_code_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "phone_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "email_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field7", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "emergency_contact_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field8", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "swimmer_id_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field9", new XVar( "cols", new XVar( 0, 10 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "id_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 7 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field7", new XVar( "cols", new XVar( 0, 8 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field8", new XVar( "cols", new XVar( 0, 9 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field9", new XVar( "cols", new XVar( 0, 10 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 11,
"height", 3 ) ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar( "print_pages", new XVar( "tag", "PRINT_PAGES",
"type", 2 ) ) ),
"gridType", 0,
"recsPerRow", 1 ),
"misc", new XVar( "type", "print",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "print",
"type", "print",
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
"items", new XVar( 0, "print_pages",
1, "inline_add" ),
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
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_icons" ),
1, new XVar( "cell", "headcell_field" ),
2, new XVar( "cell", "headcell_field1" ),
3, new XVar( "cell", "headcell_field2" ),
4, new XVar( "cell", "headcell_field3" ),
5, new XVar( "cell", "headcell_field4" ),
6, new XVar( "cell", "headcell_field5" ),
7, new XVar( "cell", "headcell_field6" ),
8, new XVar( "cell", "headcell_field7" ),
9, new XVar( "cell", "headcell_field8" ),
10, new XVar( "cell", "headcell_field9" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_icons" ),
1, new XVar( "cell", "cell_field" ),
2, new XVar( "cell", "cell_field1" ),
3, new XVar( "cell", "cell_field2" ),
4, new XVar( "cell", "cell_field3" ),
5, new XVar( "cell", "cell_field4" ),
6, new XVar( "cell", "cell_field5" ),
7, new XVar( "cell", "cell_field6" ),
8, new XVar( "cell", "cell_field7" ),
9, new XVar( "cell", "cell_field8" ),
10, new XVar( "cell", "cell_field9" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_icons" ),
1, new XVar( "cell", "footcell_field" ),
2, new XVar( "cell", "footcell_field1" ),
3, new XVar( "cell", "footcell_field2" ),
4, new XVar( "cell", "footcell_field3" ),
5, new XVar( "cell", "footcell_field4" ),
6, new XVar( "cell", "footcell_field5" ),
7, new XVar( "cell", "footcell_field6" ),
8, new XVar( "cell", "footcell_field7" ),
9, new XVar( "cell", "footcell_field8" ),
10, new XVar( "cell", "footcell_field9" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "parent_name",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "parent_name",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "address",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "address",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "city",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "city",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"field", "state",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "state",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field15" ),
"field", "zip_code",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "zip_code",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field16" ),
"field", "phone",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "phone",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field17" ),
"field", "email",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "email",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field7", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field18" ),
"field", "emergency_contact",
"columnName", "field" ),
"cell_field7", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "emergency_contact",
"columnName", "field" ),
"footcell_field7", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field8", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field19" ),
"field", "swimmer_id",
"columnName", "field" ),
"cell_field8", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "swimmer_id",
"columnName", "field" ),
"footcell_field8", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field9", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "id",
"columnName", "field" ),
"cell_field9", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "id",
"columnName", "field" ),
"footcell_field9", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_icons", new XVar( "model", "headcell_icons",
"items", XVar.Array() ),
"cell_icons", new XVar( "model", "cell_icons",
"items", new XVar( 0, "grid_inline_cancel" ) ),
"footcell_icons", new XVar( "model", "footcell_icons",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "print_header", new XVar( "type", "print_header" ),
"print_subheader", new XVar( "type", "print_subheader" ),
"print_pages", new XVar( "type", "print_pages" ),
"simple_grid_field2", new XVar( "field", "parent_name",
"type", "grid_field" ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "parent_name" ),
"simple_grid_field3", new XVar( "field", "address",
"type", "grid_field" ),
"simple_grid_field12", new XVar( "type", "grid_field_label",
"field", "address" ),
"simple_grid_field4", new XVar( "field", "city",
"type", "grid_field" ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "city" ),
"simple_grid_field5", new XVar( "field", "state",
"type", "grid_field" ),
"simple_grid_field14", new XVar( "type", "grid_field_label",
"field", "state" ),
"simple_grid_field6", new XVar( "field", "zip_code",
"type", "grid_field" ),
"simple_grid_field15", new XVar( "type", "grid_field_label",
"field", "zip_code" ),
"simple_grid_field7", new XVar( "field", "phone",
"type", "grid_field" ),
"simple_grid_field16", new XVar( "type", "grid_field_label",
"field", "phone" ),
"simple_grid_field8", new XVar( "field", "email",
"type", "grid_field" ),
"simple_grid_field17", new XVar( "type", "grid_field_label",
"field", "email" ),
"simple_grid_field9", new XVar( "field", "emergency_contact",
"type", "grid_field" ),
"simple_grid_field18", new XVar( "type", "grid_field_label",
"field", "emergency_contact" ),
"simple_grid_field10", new XVar( "field", "swimmer_id",
"type", "grid_field" ),
"simple_grid_field19", new XVar( "type", "grid_field_label",
"field", "swimmer_id" ),
"simple_grid_field", new XVar( "field", "id",
"type", "grid_field" ),
"simple_grid_field1", new XVar( "type", "grid_field_label",
"field", "id" ),
"inline_add", new XVar( "type", "inline_add",
"detailsOnly", true ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}