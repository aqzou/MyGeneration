
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL      = SQL_StoredProcs.vbgen
'  ACCESS   = Access_StoredProcs.vbgen
'  ORACLE   = Oracle_StoredProcs.vbgen
'  FIREBIRD = FirebirdStoredProcs.vbgen
'
'  The supporting base class OracleClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.0.0.4)

using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace CSharp.ORACLE
{
	public abstract class _EMPLOYEES : OracleClientEntity
	{
		public _EMPLOYEES()
		{
			this.SchemaGlobal = "HR.";
			this.QuerySource = "MYEMPLOYEES";
			this.MappingName = "MYEMPLOYEES";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			parameters = new ListDictionary();	
			OracleParameter p = new OracleParameter("outCursor", OracleType.Cursor);
			p.Direction = ParameterDirection.Output;
			parameters.Add(p, null);
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "PL_MYEMPLOYEES", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(decimal EMPLOYEE_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.EMPLOYEE_ID, EMPLOYEE_ID);


			OracleParameter p = new OracleParameter("outCursor", OracleType.Cursor);
			p.Direction = ParameterDirection.Output;
			parameters.Add(p, null);
					
			return base.LoadFromSql(this.SchemaStoredProcedure + "PK_MYEMPLOYEES", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static OracleParameter EMPLOYEE_ID
			{
				get
				{
					return new OracleParameter("p_EMPLOYEE_ID", OracleType.Number, 0);
				}
			}
			
			public static OracleParameter FIRST_NAME
			{
				get
				{
					return new OracleParameter("p_FIRST_NAME", OracleType.VarChar, 80);
				}
			}
			
			public static OracleParameter LAST_NAME
			{
				get
				{
					return new OracleParameter("p_LAST_NAME", OracleType.VarChar, 80);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
			public const string EMPLOYEE_ID = "EMPLOYEE_ID";
			public const string FIRST_NAME = "FIRST_NAME";
			public const string LAST_NAME = "LAST_NAME";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[EMPLOYEE_ID] = _EMPLOYEES.PropertyNames.EMPLOYEE_ID;
					ht[FIRST_NAME] = _EMPLOYEES.PropertyNames.FIRST_NAME;
					ht[LAST_NAME] = _EMPLOYEES.PropertyNames.LAST_NAME;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
			public const string EMPLOYEE_ID = "EMPLOYEE_ID";
			public const string FIRST_NAME = "FIRST_NAME";
			public const string LAST_NAME = "LAST_NAME";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[EMPLOYEE_ID] = _EMPLOYEES.ColumnNames.EMPLOYEE_ID;
					ht[FIRST_NAME] = _EMPLOYEES.ColumnNames.FIRST_NAME;
					ht[LAST_NAME] = _EMPLOYEES.ColumnNames.LAST_NAME;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
			public const string EMPLOYEE_ID = "s_EMPLOYEE_ID";
			public const string FIRST_NAME = "s_FIRST_NAME";
			public const string LAST_NAME = "s_LAST_NAME";

		}
		#endregion		
		
		#region Properties
	
		public virtual decimal EMPLOYEE_ID
		{
			get
			{
				return base.Getdecimal(ColumnNames.EMPLOYEE_ID);
			}
			set
			{
				base.Setdecimal(ColumnNames.EMPLOYEE_ID, value);
			}
		}

		public virtual string FIRST_NAME
		{
			get
			{
				return base.Getstring(ColumnNames.FIRST_NAME);
			}
			set
			{
				base.Setstring(ColumnNames.FIRST_NAME, value);
			}
		}

		public virtual string LAST_NAME
		{
			get
			{
				return base.Getstring(ColumnNames.LAST_NAME);
			}
			set
			{
				base.Setstring(ColumnNames.LAST_NAME, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_EMPLOYEE_ID
		{
			get
			{
				return this.IsColumnNull(ColumnNames.EMPLOYEE_ID) ? string.Empty : base.GetdecimalAsString(ColumnNames.EMPLOYEE_ID);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EMPLOYEE_ID);
				else
					this.EMPLOYEE_ID = base.SetdecimalAsString(ColumnNames.EMPLOYEE_ID, value);
			}
		}

		public virtual string s_FIRST_NAME
		{
			get
			{
				return this.IsColumnNull(ColumnNames.FIRST_NAME) ? string.Empty : base.GetstringAsString(ColumnNames.FIRST_NAME);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FIRST_NAME);
				else
					this.FIRST_NAME = base.SetstringAsString(ColumnNames.FIRST_NAME, value);
			}
		}

		public virtual string s_LAST_NAME
		{
			get
			{
				return this.IsColumnNull(ColumnNames.LAST_NAME) ? string.Empty : base.GetstringAsString(ColumnNames.LAST_NAME);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LAST_NAME);
				else
					this.LAST_NAME = base.SetstringAsString(ColumnNames.LAST_NAME, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter EMPLOYEE_ID
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.EMPLOYEE_ID, Parameters.EMPLOYEE_ID);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter FIRST_NAME
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.FIRST_NAME, Parameters.FIRST_NAME);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter LAST_NAME
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.LAST_NAME, Parameters.LAST_NAME);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter EMPLOYEE_ID
			{
				get
				{
					if(_EMPLOYEE_ID_W == null)
					{
						_EMPLOYEE_ID_W = TearOff.EMPLOYEE_ID;
					}
					return _EMPLOYEE_ID_W;
				}
			}

			public WhereParameter FIRST_NAME
			{
				get
				{
					if(_FIRST_NAME_W == null)
					{
						_FIRST_NAME_W = TearOff.FIRST_NAME;
					}
					return _FIRST_NAME_W;
				}
			}

			public WhereParameter LAST_NAME
			{
				get
				{
					if(_LAST_NAME_W == null)
					{
						_LAST_NAME_W = TearOff.LAST_NAME;
					}
					return _LAST_NAME_W;
				}
			}

			private WhereParameter _EMPLOYEE_ID_W = null;
			private WhereParameter _FIRST_NAME_W = null;
			private WhereParameter _LAST_NAME_W = null;

			public void WhereClauseReset()
			{
				_EMPLOYEE_ID_W = null;
				_FIRST_NAME_W = null;
				_LAST_NAME_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			OracleCommand cmd = new OracleCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "PI_MYEMPLOYEES";
	
			CreateParameters(cmd);
			
			OracleParameter p;
			p = cmd.Parameters[Parameters.EMPLOYEE_ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			OracleCommand cmd = new OracleCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "PU_MYEMPLOYEES";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			OracleCommand cmd = new OracleCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "PD_MYEMPLOYEES";
	
			OracleParameter p;
			p = cmd.Parameters.Add(Parameters.EMPLOYEE_ID);
			p.SourceColumn = ColumnNames.EMPLOYEE_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(OracleCommand cmd)
		{
			OracleParameter p;
		
			p = cmd.Parameters.Add(Parameters.EMPLOYEE_ID);
			p.SourceColumn = ColumnNames.EMPLOYEE_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FIRST_NAME);
			p.SourceColumn = ColumnNames.FIRST_NAME;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LAST_NAME);
			p.SourceColumn = ColumnNames.LAST_NAME;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}


