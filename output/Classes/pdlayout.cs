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
	public partial class PDLayout : XClass
	{
		public dynamic bootstrapTheme = XVar.Pack("");
		public dynamic customCssPageName = XVar.Pack("");
		public dynamic page;
		public dynamic table;
		public dynamic version = XVar.Pack(4);
		public dynamic bootstrapSize;
		public dynamic name = XVar.Pack("");
		public dynamic style = XVar.Pack("");
		public PDLayout(dynamic _param_table, dynamic _param_page, dynamic _param_theme, dynamic _param_size = null)
		{
			#region default values
			if(_param_size as Object == null) _param_size = new XVar("normal");
			#endregion

			#region pass-by-value parameters
			dynamic table = XVar.Clone(_param_table);
			dynamic page = XVar.Clone(_param_page);
			dynamic theme = XVar.Clone(_param_theme);
			dynamic size = XVar.Clone(_param_size);
			#endregion

			this.page = XVar.Clone(page);
			this.table = XVar.Clone(table);
			this.bootstrapTheme = XVar.Clone(theme);
			this.bootstrapSize = XVar.Clone(size);
		}
		public virtual XVar getCSSFiles(dynamic _param_rtl = null, dynamic _param_mobile = null, dynamic _param_pdf = null)
		{
			#region default values
			if(_param_rtl as Object == null) _param_rtl = new XVar(false);
			if(_param_mobile as Object == null) _param_mobile = new XVar(false);
			if(_param_pdf as Object == null) _param_pdf = new XVar(false);
			#endregion

			#region pass-by-value parameters
			dynamic rtl = XVar.Clone(_param_rtl);
			dynamic mobile = XVar.Clone(_param_mobile);
			dynamic pdf = XVar.Clone(_param_pdf);
			#endregion

			dynamic files = XVar.Array(), suffix = null;
			files = XVar.Clone(XVar.Array());
			suffix = new XVar("");
			if(XVar.Pack(rtl))
			{
				suffix = new XVar("RTL");
			}
			files.InitAndSetArrayItem(MVCFunctions.Concat("styles/bootstrap/", this.bootstrapTheme, "/", this.bootstrapSize, "/style.css"), null);
			files.InitAndSetArrayItem(MVCFunctions.Concat("styles/bs", suffix, ".css"), null);
			files.InitAndSetArrayItem("styles/font-awesome/css/font-awesome.min.css", null);
			if(XVar.Pack(MVCFunctions.file_exists((XVar)(MVCFunctions.getabspath(new XVar("styles/custom/custom.css"))))))
			{
				files.InitAndSetArrayItem(MVCFunctions.Concat("styles/custom/custom", suffix, ".css"), null);
			}
			files.InitAndSetArrayItem(MVCFunctions.Concat("styles/pages/", this.table, "_", this.page["id"], ".css"), null);
			return files;
		}
		public virtual XVar prepareGrid(dynamic _param_xt_packed, dynamic _param_itemsToHide, dynamic cellMap, dynamic _param_location)
		{
			#region packeted values
			XTempl _param_xt = XVar.UnPackXTempl(_param_xt_packed);
			#endregion

			#region pass-by-value parameters
			XTempl xt = XVar.Clone(_param_xt);
			dynamic itemsToHide = XVar.Clone(_param_itemsToHide);
			dynamic location = XVar.Clone(_param_location);
			#endregion

			dynamic hiddenRows = XVar.Array(), hidingMap = null, removedRows = XVar.Array();
			foreach (KeyValuePair<XVar, dynamic> dummy in cellMap.cells.GetEnumerator())
			{
				dynamic cMapRef = XVar.Array(), hidden = null, var_empty = null;
				cMapRef = cellMap.cells[dummy.Key];
				if(XVar.Pack(cMapRef["fixedAtClient"]))
				{
					continue;
				}
				var_empty = new XVar(false);
				if(XVar.Pack(!(XVar)(cMapRef["fixedAtServer"])))
				{
					var_empty = new XVar(true);
					foreach (KeyValuePair<XVar, dynamic> item in cMapRef["tags"].GetEnumerator())
					{
						if(XVar.Pack(xt.getVar((XVar)(item.Value))))
						{
							var_empty = new XVar(false);
							break;
						}
					}
				}
				hidden = new XVar(true);
				foreach (KeyValuePair<XVar, dynamic> item in cMapRef["items"].GetEnumerator())
				{
					if(XVar.Pack(!(XVar)(itemsToHide[item.Value])))
					{
						hidden = new XVar(false);
						break;
					}
				}
				if(XVar.Pack(var_empty))
				{
					cMapRef.InitAndSetArrayItem(true, "removable");
				}
				if(XVar.Pack(hidden))
				{
					cMapRef.InitAndSetArrayItem(true, "hidable");
				}
			}
			removedRows = XVar.Clone(cellMap.removeRowsColumns(new XVar("removable")));
			hidingMap = XVar.Clone(cellMap.makeClone());
			hiddenRows = XVar.Clone(hidingMap.removeRowsColumns(new XVar("hidable")));
			foreach (KeyValuePair<XVar, dynamic> row in removedRows.GetEnumerator())
			{
				xt.assign((XVar)(MVCFunctions.Concat("row_", location, "_", row.Value)), new XVar("data-hidden"));
			}
			foreach (KeyValuePair<XVar, dynamic> row in hiddenRows.GetEnumerator())
			{
				xt.assign((XVar)(MVCFunctions.Concat("row_", location, "_", row.Value)), new XVar("data-hidden"));
			}
			foreach (KeyValuePair<XVar, dynamic> cMap in cellMap.cells.GetEnumerator())
			{
				dynamic cellAttrs = XVar.Array(), hCell = XVar.Array();
				if((XVar)(0 == MVCFunctions.count(cMap.Value["rows"]))  || (XVar)(0 == MVCFunctions.count(cMap.Value["cols"])))
				{
					continue;
				}
				xt.assign((XVar)(MVCFunctions.Concat("cellblock_", location, "_", cMap.Key)), new XVar(true));
				cellAttrs = XVar.Clone(XVar.Array());
				hCell = hidingMap.cells[cMap.Key];
				if((XVar)(0 == MVCFunctions.count(hCell["rows"]))  || (XVar)(0 == MVCFunctions.count(hCell["cols"])))
				{
					cellAttrs.InitAndSetArrayItem("data-hidden", null);
				}
				if(1 < MVCFunctions.count(hCell["cols"]))
				{
					cellAttrs.InitAndSetArrayItem(MVCFunctions.Concat("colspan=\"", MVCFunctions.count(hCell["cols"]), "\""), null);
				}
				if(1 < MVCFunctions.count(hCell["rows"]))
				{
					cellAttrs.InitAndSetArrayItem(MVCFunctions.Concat("rowspan=\"", MVCFunctions.count(hCell["rows"]), "\""), null);
				}
				if(XVar.Pack(MVCFunctions.count(cellAttrs)))
				{
					xt.assign((XVar)(MVCFunctions.Concat("cell_", location, "_", cMap.Key)), (XVar)(MVCFunctions.implode(new XVar(" "), (XVar)(cellAttrs))));
				}
			}
			return hidingMap;
		}
		public virtual XVar visibleOnMedia(dynamic _param_media, dynamic _param_visibilty)
		{
			#region pass-by-value parameters
			dynamic media = XVar.Clone(_param_media);
			dynamic visibilty = XVar.Clone(_param_visibilty);
			#endregion

			if(media == XVar.Pack(0))
			{
				return (XVar)((XVar)((XVar)(visibilty == XVar.Pack(0))  || (XVar)(visibilty == 3))  || (XVar)(visibilty == 4))  || (XVar)(visibilty == 5);
			}
			else
			{
				if(media == 1)
				{
					return (XVar)((XVar)(visibilty == XVar.Pack(0))  || (XVar)(visibilty == 2))  || (XVar)(visibilty == 4);
				}
			}
			return null;
		}
		public virtual XVar prepareForms(dynamic _param_xt_packed, dynamic _param_itemsToHide, dynamic _param_recordItemsToHide, dynamic _param_pageObject)
		{
			#region packeted values
			XTempl _param_xt = XVar.UnPackXTempl(_param_xt_packed);
			#endregion

			#region pass-by-value parameters
			XTempl xt = XVar.Clone(_param_xt);
			dynamic itemsToHide = XVar.Clone(_param_itemsToHide);
			dynamic recordItemsToHide = XVar.Clone(_param_recordItemsToHide);
			dynamic pageObject = XVar.Clone(_param_pageObject);
			#endregion

			dynamic cellMaps = XVar.Array(), formItems = XVar.Array(), formTags = XVar.Array(), helper = XVar.Array(), invisibleItems = XVar.Array(), present = null, ps = null, visibleCellsMap = XVar.Array();
			if(XVar.Pack(pageObject))
			{
				ps = XVar.Clone(pageObject.pSet);
			}
			else
			{
				ps = XVar.Clone(new ProjectSettings((XVar)(CommonFunctions.GetTableByShort((XVar)(this.table))), (XVar)(this.page["type"]), (XVar)(this.page["id"])));
			}
			helper = ps.helperFormItems();
			invisibleItems = XVar.Clone(itemsToHide);
			foreach (KeyValuePair<XVar, dynamic> visibility in helper["itemVisiblity"].GetEnumerator())
			{
				if(XVar.Pack(!(XVar)(visibleOnMedia((XVar)(CommonFunctions.getMediaType()), (XVar)(visibility.Value)))))
				{
					invisibleItems.InitAndSetArrayItem(true, visibility.Key);
				}
			}
			visibleCellsMap = XVar.Clone(XVar.Array());
			cellMaps = ps.helperCellMaps();
			foreach (KeyValuePair<XVar, dynamic> loc in MVCFunctions.array_keys((XVar)(cellMaps)).GetEnumerator())
			{
				dynamic hMap = null;
				hMap = prepareGrid((XVar)(xt), (XVar)(invisibleItems), (XVar)(new CellMapPD((XVar)(cellMaps[loc.Value]))), (XVar)(loc.Value));
				if(XVar.Pack(pageObject))
				{
					visibleCellsMap.InitAndSetArrayItem(prepareClientCellMap((XVar)(cellMaps[loc.Value]), (XVar)(hMap)), loc.Value);
				}
			}
			if(XVar.Pack(pageObject))
			{
				pageObject.setPageData(new XVar("cellMaps"), (XVar)(visibleCellsMap));
			}
			foreach (KeyValuePair<XVar, dynamic> item in MVCFunctions.array_keys((XVar)(invisibleItems)).GetEnumerator())
			{
				if(XVar.Pack(itemsToHide[item.Value]))
				{
					xt.assign((XVar)(MVCFunctions.Concat("item_", item.Value)), new XVar("data-hidden"));
				}
				else
				{
					xt.assign((XVar)(MVCFunctions.Concat("item_", item.Value)), new XVar("data-media-hidden"));
				}
			}
			if(XVar.Pack(pageObject))
			{
				foreach (KeyValuePair<XVar, dynamic> itemRecords in recordItemsToHide.GetEnumerator())
				{
					foreach (KeyValuePair<XVar, dynamic> recordId in MVCFunctions.array_keys((XVar)(itemRecords.Value)).GetEnumerator())
					{
						pageObject.hideRecordItem((XVar)(itemRecords.Key), (XVar)(recordId.Value));
					}
				}
			}
			xt.assign(new XVar("firstAboveGridCell"), new XVar(true));
			formTags = helper["formXtTags"];
			foreach (KeyValuePair<XVar, dynamic> loc in MVCFunctions.array_keys((XVar)(formTags)).GetEnumerator())
			{
				present = new XVar(false);
				foreach (KeyValuePair<XVar, dynamic> tag in formTags[loc.Value].GetEnumerator())
				{
					if(XVar.Pack(xt.getVar((XVar)(tag.Value))))
					{
						present = new XVar(true);
						break;
					}
				}
				if(XVar.Pack(!(XVar)(present)))
				{
					xt.assign((XVar)(MVCFunctions.Concat(loc.Value, "_block")), new XVar(false));
				}
			}
			formItems = helper["formItems"];
			foreach (KeyValuePair<XVar, dynamic> loc in MVCFunctions.array_keys((XVar)(formItems)).GetEnumerator())
			{
				present = new XVar(false);
				foreach (KeyValuePair<XVar, dynamic> item in formItems[loc.Value].GetEnumerator())
				{
					if(XVar.Pack(!(XVar)(invisibleItems.KeyExists(item.Value))))
					{
						present = new XVar(true);
						break;
					}
				}
				if(XVar.Pack(!(XVar)(present)))
				{
					xt.assign((XVar)(MVCFunctions.Concat("form_", loc.Value)), new XVar("data-hidden"));
				}
			}
			return null;
		}
		protected virtual XVar prepareClientCellMap(dynamic allCells, dynamic visibleCells)
		{
			foreach (KeyValuePair<XVar, dynamic> cellId in MVCFunctions.array_keys((XVar)(visibleCells.cells)).GetEnumerator())
			{
				allCells.InitAndSetArrayItem(visibleCells.cells[cellId.Value]["cols"], "cells", cellId.Value, "visibleCols");
			}
			return allCells;
		}
	}
	public partial class CellMapPD : XClass
	{
		public dynamic cells;
		public dynamic height;
		public dynamic width;
		public CellMapPD(dynamic map)
		{
			this.cells = map["cells"];
			this.height = XVar.Clone(map["height"]);
			this.width = XVar.Clone(map["width"]);
		}
		public virtual XVar makeClone()
		{
			dynamic newMap = null;
			newMap = XVar.Clone(new XVar("cells", MVCFunctions.cloneArray((XVar)(this.cells)), "height", this.height, "width", this.width));
			return new CellMapPD((XVar)(newMap));
		}
		public virtual XVar getColumnCells(dynamic _param_col)
		{
			#region pass-by-value parameters
			dynamic col = XVar.Clone(_param_col);
			#endregion

			dynamic ret = XVar.Array();
			ret = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> cMap in this.cells.GetEnumerator())
			{
				if(!XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(col), (XVar)(cMap.Value["cols"]))), XVar.Pack(false)))
				{
					ret.InitAndSetArrayItem(cMap.Key, null);
				}
			}
			return ret;
		}
		public virtual XVar getRowCells(dynamic _param_row)
		{
			#region pass-by-value parameters
			dynamic row = XVar.Clone(_param_row);
			#endregion

			dynamic ret = XVar.Array();
			ret = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> cMap in this.cells.GetEnumerator())
			{
				if(!XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(row), (XVar)(cMap.Value["rows"]))), XVar.Pack(false)))
				{
					ret.InitAndSetArrayItem(cMap.Key, null);
				}
			}
			return ret;
		}
		public virtual XVar removeRowsColumns(dynamic _param_cellRemoveFlag)
		{
			#region pass-by-value parameters
			dynamic cellRemoveFlag = XVar.Clone(_param_cellRemoveFlag);
			#endregion

			dynamic canDeleteCol = null, canDeleteRow = null, cell = null, col = null, colCells = XVar.Array(), colIdx = null, colsArr = null, i = null, ret = XVar.Array(), row = null, rowCells = XVar.Array(), rowIdx = null, rowsArr = null;
			col = new XVar(0);
			for(;col < this.width; ++(col))
			{
				colCells = XVar.Clone(getColumnCells((XVar)(col)));
				canDeleteCol = new XVar(true);
				foreach (KeyValuePair<XVar, dynamic> _cell in colCells.GetEnumerator())
				{
					if((XVar)(!(XVar)(this.cells[_cell.Value][cellRemoveFlag]))  && (XVar)(MVCFunctions.count(this.cells[_cell.Value]["cols"]) == 1))
					{
						canDeleteCol = new XVar(false);
						break;
					}
				}
				if(XVar.Pack(!(XVar)(canDeleteCol)))
				{
					continue;
				}
				i = new XVar(0);
				for(;i < MVCFunctions.count(colCells); ++(i))
				{
					cell = XVar.Clone(colCells[i]);
					colIdx = XVar.Clone(MVCFunctions.array_search((XVar)(col), (XVar)(this.cells[cell]["cols"])));
					MVCFunctions.array_splice((XVar)(this.cells[cell]["cols"]), (XVar)(colIdx), new XVar(1));
					colsArr = this.cells[cell]["cols"];
					MVCFunctions.array_splice((XVar)(colsArr), (XVar)(colIdx), new XVar(1));
					this.cells.InitAndSetArrayItem(colsArr, cell, "cols");
				}
			}
			ret = XVar.Clone(XVar.Array());
			row = new XVar(0);
			for(;row < this.height; ++(row))
			{
				rowCells = XVar.Clone(getRowCells((XVar)(row)));
				canDeleteRow = new XVar(true);
				foreach (KeyValuePair<XVar, dynamic> _cell in rowCells.GetEnumerator())
				{
					if((XVar)(!(XVar)(this.cells[_cell.Value][cellRemoveFlag]))  && (XVar)(MVCFunctions.count(this.cells[_cell.Value]["rows"]) == 1))
					{
						canDeleteRow = new XVar(false);
						break;
					}
				}
				if(XVar.Pack(!(XVar)(canDeleteRow)))
				{
					continue;
				}
				i = new XVar(0);
				for(;i < MVCFunctions.count(rowCells); ++(i))
				{
					cell = XVar.Clone(rowCells[i]);
					rowIdx = XVar.Clone(MVCFunctions.array_search((XVar)(row), (XVar)(this.cells[cell]["rows"])));
					MVCFunctions.array_splice((XVar)(this.cells[cell]["rows"]), (XVar)(rowIdx), new XVar(1));
					rowsArr = XVar.Clone(this.cells[cell]["rows"]);
					MVCFunctions.array_splice((XVar)(rowsArr), (XVar)(rowIdx), new XVar(1));
					this.cells.InitAndSetArrayItem(rowsArr, cell, "rows");
				}
				ret.InitAndSetArrayItem(row, null);
			}
			return ret;
		}
	}
}
