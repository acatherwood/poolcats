
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
			public static partial class Options_public_swimmercontact_import
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "id",
1, "parent_name",
2, "address",
3, "city",
4, "state",
5, "zip_code",
6, "phone",
7, "email",
8, "emergency_contact",
9, "swimmer_id" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "id", new XVar( 0, "import_field" ),
"parent_name", new XVar( 0, "import_field2" ),
"address", new XVar( 0, "import_field3" ),
"city", new XVar( 0, "import_field4" ),
"state", new XVar( 0, "import_field5" ),
"zip_code", new XVar( 0, "import_field6" ),
"phone", new XVar( 0, "import_field7" ),
"email", new XVar( 0, "import_field8" ),
"emergency_contact", new XVar( 0, "import_field9" ),
"swimmer_id", new XVar( 0, "import_field10" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "top", new XVar( 0, "import_header" ),
"grid", new XVar( 0, "import_field2",
1, "import_field3",
2, "import_field4",
3, "import_field5",
4, "import_field6",
5, "import_field7",
6, "import_field8",
7, "import_field9",
8, "import_field10",
9, "import_field" ) ),
"formXtTags", new XVar(  ),
"itemForms", new XVar( "import_header", "top",
"import_field2", "grid",
"import_field3", "grid",
"import_field4", "grid",
"import_field5", "grid",
"import_field6", "grid",
"import_field7", "grid",
"import_field8", "grid",
"import_field9", "grid",
"import_field10", "grid",
"import_field", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "import_header", new XVar( 0, "import_header" ),
"import_field", new XVar( 0, "import_field",
1, "import_field2",
2, "import_field3",
3, "import_field4",
4, "import_field5",
5, "import_field6",
6, "import_field7",
7, "import_field8",
8, "import_field9",
9, "import_field10" ) ),
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
"items", new XVar( 0, "import_field2",
1, "import_field3",
2, "import_field4",
3, "import_field5",
4, "import_field6",
5, "import_field7",
6, "import_field8",
7, "import_field9",
8, "import_field10",
9, "import_field" ),
"_t", "Map",
"_i", new XVar(  ),
"_s", 0 ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "import_header", new XVar( "type", "import_header" ),
"import_field", new XVar( "field", "id",
"type", "import_field" ),
"import_field2", new XVar( "field", "parent_name",
"type", "import_field" ),
"import_field3", new XVar( "field", "address",
"type", "import_field" ),
"import_field4", new XVar( "field", "city",
"type", "import_field" ),
"import_field5", new XVar( "field", "state",
"type", "import_field" ),
"import_field6", new XVar( "field", "zip_code",
"type", "import_field" ),
"import_field7", new XVar( "field", "phone",
"type", "import_field" ),
"import_field8", new XVar( "field", "email",
"type", "import_field" ),
"import_field9", new XVar( "field", "emergency_contact",
"type", "import_field" ),
"import_field10", new XVar( "field", "swimmer_id",
"type", "import_field" ) ),
"dbProps", new XVar(  ),
"version", 2 );
				}
			}
		}