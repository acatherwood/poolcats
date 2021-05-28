using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using runnerDotNet;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Web;
using System.Reflection;

namespace runnerDotNet
{
	public interface IGlobalEventProviderCS
	{

		// handlers

		// onscreen events

		// table maps, buttons



		// common events
		XVar AfterTableInit(dynamic context);
		XVar GetTablePermissions(dynamic permissions, dynamic table = null);
		XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null);
	}

	public interface IGlobalEventProviderVB
	{

		// handlers

		// onscreen events

		// table maps, buttons



		// common events
		XVar AfterTableInit(dynamic context);
		XVar GetTablePermissions(dynamic permissions, dynamic table = null);
		XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null);
	}

	public class EventsAggregatorBase : XClass
	{
		public enum EventLanguage
		{
			CS = 0,
			VB = 1
		};

		public XVar events;
		public XVar captchas;
		public XVar maps;

		public EventsAggregatorBase()
		{
			events = XVar.Array();
			captchas = XVar.Array();
			maps = XVar.Array();
		}

		public XVar exists(dynamic curEvent, dynamic table = null)
		{
			if(table == null || table == "")
				return events.KeyExists(curEvent);
			else
				return events.KeyExists(curEvent) && events[curEvent].KeyExists(table);
		}

		public XVar existsMap(dynamic page)
		{
			return maps.KeyExists(page);
		}

		public XVar existsCAPTCHA(dynamic page)
		{
			return captchas.KeyExists(page);
		}

		public void DoImport()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(MVCFunctions.getabspath("\\bin\\Events")));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
	}

	public class class_GlobalEvents : EventsAggregatorBase
	{
		[Import(typeof(IGlobalEventProviderCS))]
		public IGlobalEventProviderCS EventProviderCS;

		[Import(typeof(IGlobalEventProviderVB))]
		public IGlobalEventProviderVB EventProviderVB;


		public class_GlobalEvents()
		{
			DoImport();

			// fill list of events



			// onscreen events

		}

		//	handlers

		//	onscreen events


		// local maps, buttons

		// AJAX handlers



		public XVar AfterTableInit(dynamic context)
		{
			EventProviderCS.AfterTableInit(context);
			EventProviderVB.AfterTableInit(context);
			return null;
		}

		public XVar GetTablePermissions(dynamic permissions, dynamic table = null)
		{
			permissions = EventProviderCS.GetTablePermissions(permissions, table);
			permissions = EventProviderVB.GetTablePermissions(permissions, table);
			return permissions;
		}

		public XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null)
		{
			isEditable = EventProviderCS.IsRecordEditable(values, isEditable, table);
			isEditable = EventProviderVB.IsRecordEditable(values, isEditable, table);
			return isEditable;
		}
	}
}