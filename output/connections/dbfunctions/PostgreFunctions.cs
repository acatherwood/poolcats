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
	public partial class PostgreFunctions : DBFunctions
	{
		protected dynamic postgreDbVersion;
		protected static bool skipPostgreFunctionsCtor = false;
		public PostgreFunctions(dynamic _param_params)
			:base((XVar)_param_params)
		{
			if(skipPostgreFunctionsCtor)
			{
				skipPostgreFunctionsCtor = false;
				return;
			}
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic extraParams = XVar.Array();
			this.escapeChars.InitAndSetArrayItem(true, "\\");
			this.postgreDbVersion = XVar.Clone(extraParams["postgreDbVersion"]);
		}
		public override XVar escapeLIKEpattern(dynamic _param_str)
		{
			#region pass-by-value parameters
			dynamic str = XVar.Clone(_param_str);
			#endregion

			return str;
		}
		public override XVar addSlashes(dynamic _param_str)
		{
			#region pass-by-value parameters
			dynamic str = XVar.Clone(_param_str);
			#endregion

			return base.addSlashes((XVar)(str));
		}
		public override XVar addSlashesBinary(dynamic _param_str)
		{
			#region pass-by-value parameters
			dynamic str = XVar.Clone(_param_str);
			#endregion

			if(XVar.Pack(!(XVar)(MVCFunctions.strlen((XVar)(str)))))
			{
				return "''";
			}
			return MVCFunctions.Concat("E'\\\\x", MVCFunctions.bin2hex((XVar)(str)), "'");
		}
		public override XVar stripSlashesBinary(dynamic _param_str)
		{
			#region pass-by-value parameters
			dynamic str = XVar.Clone(_param_str);
			#endregion

			return MVCFunctions.hex2bin((XVar)(MVCFunctions.substr((XVar)(str), new XVar(2))));
		}
		public override XVar addFieldWrappers(dynamic _param_strName)
		{
			#region pass-by-value parameters
			dynamic strName = XVar.Clone(_param_strName);
			#endregion

			if(MVCFunctions.substr((XVar)(strName), new XVar(0), new XVar(1)) == this.strLeftWrapper)
			{
				return strName;
			}
			return MVCFunctions.Concat(this.strLeftWrapper, strName, this.strRightWrapper);
		}
		public override XVar upper(dynamic _param_dbval)
		{
			#region pass-by-value parameters
			dynamic dbval = XVar.Clone(_param_dbval);
			#endregion

			return MVCFunctions.Concat("upper(", dbval, ")");
		}
		public override XVar field2char(dynamic _param_value, dynamic _param_type = null)
		{
			#region default values
			if(_param_type as Object == null) _param_type = new XVar(3);
			#endregion

			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			dynamic var_type = XVar.Clone(_param_type);
			#endregion

			if(XVar.Pack(CommonFunctions.IsCharType((XVar)(var_type))))
			{
				return value;
			}
			return MVCFunctions.Concat("''||(", value, ")");
		}
		public override XVar field2time(dynamic _param_value, dynamic _param_type)
		{
			#region pass-by-value parameters
			dynamic value = XVar.Clone(_param_value);
			dynamic var_type = XVar.Clone(_param_type);
			#endregion

			return value;
		}
		public override XVar getInsertedIdSQL(dynamic _param_key = null, dynamic _param_table = null, dynamic _param_oraSequenceName = null)
		{
			#region default values
			if(_param_key as Object == null) _param_key = new XVar();
			if(_param_table as Object == null) _param_table = new XVar();
			if(_param_oraSequenceName as Object == null) _param_oraSequenceName = new XVar(false);
			#endregion

			#region pass-by-value parameters
			dynamic key = XVar.Clone(_param_key);
			dynamic table = XVar.Clone(_param_table);
			dynamic oraSequenceName = XVar.Clone(_param_oraSequenceName);
			#endregion

			return "SELECT LASTVAL()";
		}
		public override XVar crossDbSupported()
		{
			return false;
		}
	}
}
