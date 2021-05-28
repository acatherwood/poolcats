
		// public.swimmer
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
			public static partial class Options_public_swimmer_import
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id",
1, "first_name",
2, "last_name",
3, "birthdate",
4, "gender" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id", new XVar( 0, "import_field" ),
"first_name", new XVar( 0, "import_field1" ),
"last_name", new XVar( 0, "import_field2" ),
"birthdate", new XVar( 0, "import_field3" ),
"gender", new XVar( 0, "import_field4" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "import_header" ),
"grid", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4" ) ),
"formXtTags", new XVar(  ),
"itemForms", new XVar( "import_header", "top",
"import_field", "grid",
"import_field1", "grid",
"import_field2", "grid",
"import_field3", "grid",
"import_field4", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "import_header", new XVar( 0, "import_header" ),
"import_field", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ) ) ),
"misc", new XVar( "type", "import",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "import",
"type", "import",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "top", new XVar( "modelId", "import-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "import_header" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "import-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "import_header", new XVar( "type", "import_header" ),
"import_field", new XVar( "field", "id",
"type", "import_field" ),
"import_field1", new XVar( "field", "first_name",
"type", "import_field" ),
"import_field2", new XVar( "field", "last_name",
"type", "import_field" ),
"import_field3", new XVar( "field", "birthdate",
"type", "import_field" ),
"import_field4", new XVar( "field", "gender",
"type", "import_field" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}