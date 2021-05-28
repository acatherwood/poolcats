using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;
using runnerDotNet;

namespace runnerDotNet
{
	public class PostgreConnection : Connection
	{
		public PostgreConnection(XVar parameters) : base(parameters)
		{ }
		
		protected override string GetLastInsertedIdSql()
		{
			return "SELECT lastval()";
		}
		
		protected override DbCommand GetCommand()
		{
			return new Npgsql.NpgsqlCommand();
		}
		
		protected override ConnectionsPool GetConnectionsPool(string connStr)
		{
			return new PostgreConnectionPool(connStr);
		}
		
		protected override DBFunctions GetDbFunctions( XVar extraParams)
		{
			return new PostgreFunctions(  extraParams );
		}
		
		protected override DBInfo GetDbInfo()
		{
			return new PostgreInfo(this);
		}
		
		public override XVar queryPage(XVar strSQL, XVar pageStart, XVar pageSize, XVar applyLimit)
		{
			if( applyLimit )
				strSQL = String.Format("{0} limit {1} offset {2}", strSQL, pageSize, ((pageStart - 1) * pageSize));
			
			return query( strSQL );
		}
	}
}