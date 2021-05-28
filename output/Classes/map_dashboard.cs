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
	public partial class MapPage_Dashboard : ListPage_Dashboard
	{
		protected dynamic gridBased = XVar.Pack(false);
		protected static bool skipMapPage_DashboardCtor = false;
		public MapPage_Dashboard(dynamic var_params)
			:base((XVar)var_params)
		{
			if(skipMapPage_DashboardCtor)
			{
				skipMapPage_DashboardCtor = false;
				return;
			}
			this.gridBased = XVar.Clone((XVar)(!(XVar)(this.dashElementData["updateMoved"]))  && (XVar)(hasTableDashGridElement()));
		}
		protected override XVar getSubsetSQLComponents()
		{
			dynamic sql = XVar.Array();
			sql = XVar.Clone(base.getSubsetSQLComponents());
			if(XVar.Pack(this.mapRefresh))
			{
				sql.InitAndSetArrayItem(getLatLngWhere((XVar)(this.dashElementData["latF"]), (XVar)(this.dashElementData["lonF"])), "mandatoryWhere", null);
			}
			return sql;
		}
		public override XVar setGoogleMapsParams(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic mapId = null;
			this.googleMapCfg.InitAndSetArrayItem(this.tName, "tName");
			this.googleMapCfg.InitAndSetArrayItem(true, "isUseMainMaps");
			this.googleMapCfg.InitAndSetArrayItem(true, "isUseGoogleMap");
			this.googleMapCfg.InitAndSetArrayItem(false, "isUseFieldsMaps");
			mapId = XVar.Clone(MVCFunctions.Concat(MVCFunctions.GoodFieldName((XVar)(this.dashTName)), "_", this.dashElementName, "_dashMap"));
			this.googleMapCfg.InitAndSetArrayItem(mapId, "mainMapIds", null);
			this.googleMapCfg.InitAndSetArrayItem("DASH_MAP", "mapsData", mapId, "type");
			this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["latF"], "mapsData", mapId, "latField");
			this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["lonF"], "mapsData", mapId, "lngField");
			this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["descF"], "mapsData", mapId, "descField");
			this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["addressF"], "mapsData", mapId, "addressField");
			this.googleMapCfg.InitAndSetArrayItem(true, "mapsData", mapId, "dashMap");
			this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["heatMap"], "mapsData", mapId, "heatMap");
			this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["clustering"], "mapsData", mapId, "clustering");
			this.googleMapCfg.InitAndSetArrayItem((XVar)(this.dashElementData["heatMap"])  || (XVar)(this.dashElementData["clustering"]), "mapsData", mapId, "showAllMarkers");
			if(XVar.Pack(!(XVar)(this.gridBased)))
			{
				this.googleMapCfg.InitAndSetArrayItem("auto", "mapsData", mapId, "zoom");
			}
			else
			{
				if(XVar.Pack(this.dashElementData.KeyExists("zoom")))
				{
					this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["zoom"], "mapsData", mapId, "zoom");
				}
			}
			if(XVar.Pack(this.dashElementData.KeyExists("APIkey")))
			{
				this.googleMapCfg.InitAndSetArrayItem(this.dashElementData["APIkey"], "APIcode");
			}
			if(XVar.Pack(this.dashElementData["clustering"]))
			{
				AddJSFile(new XVar("include/markerclusterer.js"));
			}
			return null;
		}
		public override XVar fillGridData()
		{
			dynamic data = XVar.Array(), editlink = null, keys = XVar.Array(), recNum = null, tKeys = XVar.Array(), var_params = XVar.Array();
			if(XVar.Pack(this.gridBased))
			{
				return null;
			}
			data = XVar.Clone(beforeProccessRow());
			tKeys = XVar.Clone(this.pSet.getTableKeys());
			recNum = XVar.Clone((XVar.Pack((XVar)(hasTableDashGridElement())  || (XVar)(MVCFunctions.strlen((XVar)(this.masterTable)))) ? XVar.Pack(this.pageSize) : XVar.Pack(this.dashElementData["mapMarkerCount"])));
			if((XVar)(!(XVar)(this.mapRefresh))  && (XVar)((XVar)(this.dashElementData["clustering"])  || (XVar)(this.dashElementData["heatMap"])))
			{
				recNum = new XVar(10000);
			}
			while((XVar)(data)  && (XVar)((XVar)(this.recNo <= recNum)  || (XVar)(recNum == -1)))
			{
				genId();
				keys = XVar.Clone(XVar.Array());
				var_params = XVar.Clone(XVar.Array());
				foreach (KeyValuePair<XVar, dynamic> fKey in tKeys.GetEnumerator())
				{
					keys.InitAndSetArrayItem(data[fKey.Value], 0);
					var_params.InitAndSetArrayItem(MVCFunctions.Concat("editid", fKey.Key + 1, "=", MVCFunctions.runner_htmlspecialchars((XVar)(MVCFunctions.RawUrlEncode((XVar)(data[fKey.Value]))))), null);
				}
				editlink = XVar.Clone(MVCFunctions.implode(new XVar("&"), (XVar)(var_params)));
				addBigGoogleMapMarkers((XVar)(data), (XVar)(keys), (XVar)(editlink));
				data = XVar.Clone(beforeProccessRow());
				this.recNo++;
			}
			return null;
		}
		public override XVar fillControlsHTMLMap()
		{
			this.controlsHTMLMap.InitAndSetArrayItem(XVar.Array(), this.tName);
			this.controlsHTMLMap.InitAndSetArrayItem(XVar.Array(), this.tName, Constants.PAGE_DASHMAP);
			this.controlsHTMLMap.InitAndSetArrayItem(XVar.Array(), this.tName, Constants.PAGE_DASHMAP, this.id);
			this.controlsHTMLMap.InitAndSetArrayItem(this.googleMapCfg, this.tName, Constants.PAGE_DASHMAP, this.id, "gMaps");
			return null;
		}
		protected virtual XVar getMapDiv()
		{
			dynamic height = null, mapId = null, width = null;
			mapId = XVar.Clone(MVCFunctions.Concat(MVCFunctions.GoodFieldName((XVar)(this.dashTName)), "_", this.dashElementName, "_dashMap"));
			width = XVar.Clone((XVar.Pack(this.dashElementData["width"]) ? XVar.Pack(this.dashElementData["width"]) : XVar.Pack(600)));
			height = XVar.Clone((XVar.Pack(this.dashElementData["height"]) ? XVar.Pack(this.dashElementData["height"]) : XVar.Pack(400)));
			return MVCFunctions.Concat("<div id=\"", mapId, "\" style=\"width: ", width, "px; height: ", height, "px;\"></div>");
		}
		public override XVar showPage()
		{
			dynamic var_response = XVar.Array();
			fillSetCntrlMaps();
			var_response = XVar.Clone(XVar.Array());
			var_response.InitAndSetArrayItem(GlobalVars.pagesData, "pagesData");
			var_response.InitAndSetArrayItem(this.jsSettings, "settings");
			var_response.InitAndSetArrayItem(this.controlsHTMLMap, "controlsMap");
			var_response.InitAndSetArrayItem(getMapDiv(), "html");
			var_response.InitAndSetArrayItem(true, "success");
			var_response.InitAndSetArrayItem(this.id, "id");
			var_response.InitAndSetArrayItem(grabAllJsFiles(), "additionalJS");
			MVCFunctions.Echo(CommonFunctions.printJSON((XVar)(var_response)));
			return null;
		}
		protected override XVar checkIfSearchPanelActivated(dynamic _param_mobile)
		{
			#region pass-by-value parameters
			dynamic mobile = XVar.Clone(_param_mobile);
			#endregion

			return false;
		}
		public override XVar deleteAvailable()
		{
			return (XVar)(RunnerPage.deleteAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["delete"]);
		}
		public override XVar editAvailable()
		{
			return (XVar)(RunnerPage.editAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["edit"]);
		}
		public override XVar addAvailable()
		{
			return (XVar)(RunnerPage.addAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["add"]);
		}
		public override XVar viewAvailable()
		{
			return (XVar)(RunnerPage.viewAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["view"]);
		}
		public override XVar inlineEditAvailable()
		{
			return false;
		}
		public override XVar inlineAddAvailable()
		{
			return false;
		}
		public override XVar addCommonJs()
		{
			initGmaps();
			return null;
		}
		public override XVar addCommonHtml()
		{
			return null;
		}
		public override XVar commonAssign()
		{
			return null;
		}
		public override XVar addCustomCss()
		{
			return null;
		}
		public override XVar buildPagination()
		{
			return null;
		}
		public override XVar fetchMapMarkersInSeparateQuery(dynamic _param_mapId)
		{
			#region pass-by-value parameters
			dynamic mapId = XVar.Clone(_param_mapId);
			#endregion

			return false;
		}
	}
}
