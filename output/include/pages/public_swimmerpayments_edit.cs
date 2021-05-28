
		// public.swimmerpayments
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
			public static partial class Options_public_swimmerpayments_edit
			{
				static public XVar options()
				{
					return new XVar( "master", new XVar( "public.swimmers", new XVar( "preview", false ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "payment_type",
1, "amount_paid",
2, "early_registration",
3, "practice_time" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"updateOnEditFields", XVar.Array(),
"fieldItems", new XVar( "payment_type", new XVar( 0, "integrated_edit_field1" ),
"amount_paid", new XVar( 0, "integrated_edit_field2" ),
"early_registration", new XVar( 0, "integrated_edit_field4" ),
"practice_time", new XVar( 0, "integrated_edit_field" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", true,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "edit_header" ),
"above-grid", new XVar( 0, "edit_message" ),
"below-grid", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close",
3, "hamburger" ),
"grid", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field4",
3, "integrated_edit_field" ) ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "message_block" ) ),
"itemForms", new XVar( "edit_header", "top",
"edit_message", "above-grid",
"edit_save", "below-grid",
"edit_back_list", "below-grid",
"edit_close", "below-grid",
"hamburger", "below-grid",
"integrated_edit_field1", "grid",
"integrated_edit_field2", "grid",
"integrated_edit_field4", "grid",
"integrated_edit_field", "grid" ),
"itemLocations", new XVar( "integrated_edit_field1", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "edit_header", new XVar( 0, "edit_header" ),
"hamburger", new XVar( 0, "hamburger" ),
"edit_reset", new XVar( 0, "edit_reset" ),
"edit_message", new XVar( 0, "edit_message" ),
"edit_save", new XVar( 0, "edit_save" ),
"edit_back_list", new XVar( 0, "edit_back_list" ),
"edit_close", new XVar( 0, "edit_close" ),
"edit_view", new XVar( 0, "edit_view" ),
"integrated_edit_field", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field4",
3, "integrated_edit_field" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field4",
3, "integrated_edit_field" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"misc", new XVar( "type", "edit",
"breadcrumb", false,
"nextPrev", false ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ),
"edit", new XVar( "updateSelected", false ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "edit",
"type", "edit",
"layoutId", "nomenu",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "edit-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"above-grid", new XVar( "modelId", "edit-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_message" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "edit-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "hamburger" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field4",
3, "integrated_edit_field" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ) ),
"items", new XVar( "edit_header", new XVar( "type", "edit_header" ),
"hamburger", new XVar( "type", "hamburger",
"items", new XVar( 0, "edit_reset",
1, "edit_view" ) ),
"edit_reset", new XVar( "type", "edit_reset" ),
"edit_message", new XVar( "type", "edit_message" ),
"edit_save", new XVar( "type", "edit_save" ),
"edit_back_list", new XVar( "type", "edit_back_list" ),
"edit_close", new XVar( "type", "edit_close" ),
"edit_view", new XVar( "type", "edit_view" ),
"integrated_edit_field1", new XVar( "field", "payment_type",
"type", "integrated_edit_field",
"orientation", 0,
"updateOnEdit", false ),
"integrated_edit_field2", new XVar( "field", "amount_paid",
"type", "integrated_edit_field",
"orientation", 0,
"updateOnEdit", false ),
"integrated_edit_field4", new XVar( "field", "early_registration",
"type", "integrated_edit_field",
"orientation", 0 ),
"integrated_edit_field", new XVar( "field", "practice_time",
"type", "integrated_edit_field",
"orientation", 0 ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}