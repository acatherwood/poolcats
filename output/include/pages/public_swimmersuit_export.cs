
		// public.swimmersuit
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
			public static partial class Options_public_swimmersuit_export
			{
				static public XVar options()
				{
					return new XVar( "totals", new XVar( "id", new XVar( "totalsType", "" ),
"swimmer_id", new XVar( "totalsType", "" ),
"suit_type", new XVar( "totalsType", "" ),
"suit_size", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "id",
1, "suit_type",
2, "suit_size",
3, "swimmer_id" ),
"exportFields", new XVar( 0, "suit_type",
1, "suit_size",
2, "id",
3, "swimmer_id" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id", new XVar( 0, "export_field" ),
"suit_type", new XVar( 0, "export_field2" ),
"suit_size", new XVar( 0, "export_field3" ),
"swimmer_id", new XVar( 0, "export_field1" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "export_header" ),
"grid", new XVar( 0, "export_field2",
1, "export_field3",
2, "export_field",
3, "export_field1" ),
"footer", new XVar( 0, "export_export",
1, "export_cancel" ) ),
"formXtTags", new XVar(  ),
"itemForms", new XVar( "export_header", "top",
"export_field2", "grid",
"export_field3", "grid",
"export_field", "grid",
"export_field1", "grid",
"export_export", "footer",
"export_cancel", "footer" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "export_header", new XVar( 0, "export_header" ),
"export_export", new XVar( 0, "export_export" ),
"export_cancel", new XVar( 0, "export_cancel" ),
"export_field", new XVar( 0, "export_field",
1, "export_field2",
2, "export_field3",
3, "export_field1" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"misc", new XVar( "type", "export",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ),
"export", new XVar( "format", 2,
"selectFields", false,
"delimiter", ",",
"selectDelimiter", false ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "export",
"type", "export",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "export-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "export-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_field2",
1, "export_field3",
2, "export_field",
3, "export_field1" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"footer", new XVar( "modelId", "export-footer",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array(),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "export_export",
1, "export_cancel" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "export_header", new XVar( "type", "export_header" ),
"export_export", new XVar( "type", "export_export" ),
"export_cancel", new XVar( "type", "export_cancel" ),
"export_field", new XVar( "field", "id",
"type", "export_field" ),
"export_field2", new XVar( "field", "suit_type",
"type", "export_field" ),
"export_field3", new XVar( "field", "suit_size",
"type", "export_field" ),
"export_field1", new XVar( "field", "swimmer_id",
"type", "export_field" ) ),
"dbProps", new XVar(  ),
"version", 2,
"exportFormat", 2,
"exportDelimiter", ",",
"exportSelectDelimiter", false,
"exportSelectFields", false );
				}
			}
		}