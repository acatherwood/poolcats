
		// public.swimmerpayment
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
			public static partial class Options_public_swimmerpayment_import
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id",
1, "swimmer_id",
2, "payment_type",
3, "amount_paid",
4, "practice_time",
5, "early_registration" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id", new XVar( 0, "import_field" ),
"swimmer_id", new XVar( 0, "import_field1" ),
"payment_type", new XVar( 0, "import_field2" ),
"amount_paid", new XVar( 0, "import_field3" ),
"practice_time", new XVar( 0, "import_field4" ),
"early_registration", new XVar( 0, "import_field5" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "import_header" ),
"grid", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4",
5, "import_field5" ) ),
"formXtTags", new XVar(  ),
"itemForms", new XVar( "import_header", "top",
"import_field", "grid",
"import_field1", "grid",
"import_field2", "grid",
"import_field3", "grid",
"import_field4", "grid",
"import_field5", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "import_header", new XVar( 0, "import_header" ),
"import_field", new XVar( 0, "import_field",
1, "import_field1",
2, "import_field2",
3, "import_field3",
4, "import_field4",
5, "import_field5" ) ),
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
4, "import_field4",
5, "import_field5" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "import_header", new XVar( "type", "import_header" ),
"import_field", new XVar( "field", "id",
"type", "import_field" ),
"import_field1", new XVar( "field", "swimmer_id",
"type", "import_field" ),
"import_field2", new XVar( "field", "payment_type",
"type", "import_field" ),
"import_field3", new XVar( "field", "amount_paid",
"type", "import_field" ),
"import_field4", new XVar( "field", "practice_time",
"type", "import_field" ),
"import_field5", new XVar( "field", "early_registration",
"type", "import_field" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}