
'===============================================================================
'  Generated From - VbNet_SQL_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  **
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class FirebirdSqlEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'MustInherit' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can Override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  Public Class YourObject
'    Inherits _YourObject
'
'  End Class
'
'===============================================================================

' Generated by MyGeneration Version # (1.1.3.5)

Imports System
Imports System.Data
Imports FirebirdSql.Data.Firebird
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

Namespace MyGeneration.dOOdads.Tests.Firebird

	Public MustInherit Class _AggregateTest
		Inherits FirebirdSqlEntity

		Public Sub New()
			Me.QuerySource = "AggregateTest"
			Me.MappingName = "AggregateTest"
			Me.Dialect = 3
		End Sub

		'=================================================================
		'  Public Overrides Sub AddNew()
		'=================================================================
		'
		'=================================================================
		Public Overrides Sub AddNew()
			MyBase.AddNew()

		End Sub

		Public Overrides Sub FlushData()
			Me._whereClause = Nothing
			Me._aggregateClause = Nothing
			MyBase.FlushData()
		End Sub


		'=================================================================
		'  	Public Function LoadAll() As Boolean
		'=================================================================
		'  Loads all of the records in the database, and sets the currentRow to the first row
		'=================================================================
		Public Function LoadAll() As Boolean

			Dim parameters As ListDictionary = Nothing


			Return MyBase.LoadFromSql("PL_AGGREGATETEST", parameters)

		End Function

		'=================================================================
		' Public Overridable Function LoadByPrimaryKey()  As Boolean
		'=================================================================
		'  Loads a single row of via the primary key
		'=================================================================
		Public Overridable Function LoadByPrimaryKey(ByVal ID As Integer) As Boolean

			Dim parameters As ListDictionary = New ListDictionary
			parameters.Add(Me.Parameters.ID, ID)


			Return MyBase.LoadFromSql("PK_AGGREGATETEST", parameters)

		End Function

#Region "Parameters"
		Protected Class Parameters

			Public Shared ReadOnly Property ID() As FbParameter
				Get
					Return New FbParameter("@ID", FbDbType.Integer, 0)
				End Get
			End Property

			Public Shared ReadOnly Property DepartmentID() As FbParameter
				Get
					Return New FbParameter("@DepartmentID", FbDbType.Integer, 0)
				End Get
			End Property

			Public Shared ReadOnly Property FirstName() As FbParameter
				Get
					Return New FbParameter("@FirstName", FbDbType.VarChar, 25)
				End Get
			End Property

			Public Shared ReadOnly Property LastName() As FbParameter
				Get
					Return New FbParameter("@LastName", FbDbType.VarChar, 15)
				End Get
			End Property

			Public Shared ReadOnly Property Age() As FbParameter
				Get
					Return New FbParameter("@Age", FbDbType.Integer, 0)
				End Get
			End Property

			Public Shared ReadOnly Property HireDate() As FbParameter
				Get
					Return New FbParameter("@HireDate", FbDbType.TimeStamp, 0)
				End Get
			End Property

			Public Shared ReadOnly Property Salary() As FbParameter
				Get
					Return New FbParameter("@Salary", FbDbType.Numeric, 0)
				End Get
			End Property

			Public Shared ReadOnly Property IsActive() As FbParameter
				Get
					Return New FbParameter("@IsActive", FbDbType.SmallInt, 0)
				End Get
			End Property

		End Class
#End Region

#Region "ColumnNames"
		Public Class ColumnNames

			Public Const ID As String = "ID"
			Public Const DepartmentID As String = "DepartmentID"
			Public Const FirstName As String = "FirstName"
			Public Const LastName As String = "LastName"
			Public Const Age As String = "Age"
			Public Const HireDate As String = "HireDate"
			Public Const Salary As String = "Salary"
			Public Const IsActive As String = "IsActive"

			Public Shared Function ToPropertyName(ByVal columnName As String) As String

				If ht Is Nothing Then

					ht = New Hashtable

					ht(ID) = _AggregateTest.PropertyNames.ID
					ht(DepartmentID) = _AggregateTest.PropertyNames.DepartmentID
					ht(FirstName) = _AggregateTest.PropertyNames.FirstName
					ht(LastName) = _AggregateTest.PropertyNames.LastName
					ht(Age) = _AggregateTest.PropertyNames.Age
					ht(HireDate) = _AggregateTest.PropertyNames.HireDate
					ht(Salary) = _AggregateTest.PropertyNames.Salary
					ht(IsActive) = _AggregateTest.PropertyNames.IsActive

				End If

				Return CType(ht(columnName), String)

			End Function

			Private Shared ht As Hashtable = Nothing
		End Class
#End Region

#Region "PropertyNames"
		Public Class PropertyNames

			Public Const ID As String = "ID"
			Public Const DepartmentID As String = "DepartmentID"
			Public Const FirstName As String = "FirstName"
			Public Const LastName As String = "LastName"
			Public Const Age As String = "Age"
			Public Const HireDate As String = "HireDate"
			Public Const Salary As String = "Salary"
			Public Const IsActive As String = "IsActive"

			Public Shared Function ToColumnName(ByVal propertyName As String) As String

				If ht Is Nothing Then

					ht = New Hashtable

					ht(ID) = _AggregateTest.ColumnNames.ID
					ht(DepartmentID) = _AggregateTest.ColumnNames.DepartmentID
					ht(FirstName) = _AggregateTest.ColumnNames.FirstName
					ht(LastName) = _AggregateTest.ColumnNames.LastName
					ht(Age) = _AggregateTest.ColumnNames.Age
					ht(HireDate) = _AggregateTest.ColumnNames.HireDate
					ht(Salary) = _AggregateTest.ColumnNames.Salary
					ht(IsActive) = _AggregateTest.ColumnNames.IsActive

				End If

				Return CType(ht(propertyName), String)

			End Function

			Private Shared ht As Hashtable = Nothing

		End Class
#End Region

#Region "StringPropertyNames"
		Public Class StringPropertyNames

			Public Const ID As String = "s_ID"
			Public Const DepartmentID As String = "s_DepartmentID"
			Public Const FirstName As String = "s_FirstName"
			Public Const LastName As String = "s_LastName"
			Public Const Age As String = "s_Age"
			Public Const HireDate As String = "s_HireDate"
			Public Const Salary As String = "s_Salary"
			Public Const IsActive As String = "s_IsActive"

		End Class
#End Region

#Region "Properties"
		Public Overridable Property ID() As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.ID)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.ID, Value)
			End Set
		End Property

		Public Overridable Property DepartmentID() As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.DepartmentID)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.DepartmentID, Value)
			End Set
		End Property

		Public Overridable Property FirstName() As String
			Get
				Return MyBase.GetString(ColumnNames.FirstName)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.FirstName, Value)
			End Set
		End Property

		Public Overridable Property LastName() As String
			Get
				Return MyBase.GetString(ColumnNames.LastName)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.LastName, Value)
			End Set
		End Property

		Public Overridable Property Age() As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.Age)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.Age, Value)
			End Set
		End Property

		Public Overridable Property HireDate() As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.HireDate)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.HireDate, Value)
			End Set
		End Property

		Public Overridable Property Salary() As Decimal
			Get
				Return MyBase.GetDecimal(ColumnNames.Salary)
			End Get
			Set(ByVal Value As Decimal)
				MyBase.SetDecimal(ColumnNames.Salary, Value)
			End Set
		End Property

		Public Overridable Property IsActive() As Short
			Get
				Return MyBase.GetShort(ColumnNames.IsActive)
			End Get
			Set(ByVal Value As Short)
				MyBase.SetShort(ColumnNames.IsActive, Value)
			End Set
		End Property


#End Region

#Region "String Properties"

		Public Overridable Property s_ID() As String
			Get
				If Me.IsColumnNull(ColumnNames.ID) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.ID)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.ID)
				Else
					Me.ID = MyBase.SetIntegerAsString(ColumnNames.ID, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_DepartmentID() As String
			Get
				If Me.IsColumnNull(ColumnNames.DepartmentID) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.DepartmentID)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.DepartmentID)
				Else
					Me.DepartmentID = MyBase.SetIntegerAsString(ColumnNames.DepartmentID, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_FirstName() As String
			Get
				If Me.IsColumnNull(ColumnNames.FirstName) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.FirstName)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FirstName)
				Else
					Me.FirstName = MyBase.SetStringAsString(ColumnNames.FirstName, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_LastName() As String
			Get
				If Me.IsColumnNull(ColumnNames.LastName) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.LastName)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.LastName)
				Else
					Me.LastName = MyBase.SetStringAsString(ColumnNames.LastName, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Age() As String
			Get
				If Me.IsColumnNull(ColumnNames.Age) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.Age)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Age)
				Else
					Me.Age = MyBase.SetIntegerAsString(ColumnNames.Age, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_HireDate() As String
			Get
				If Me.IsColumnNull(ColumnNames.HireDate) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.HireDate)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.HireDate)
				Else
					Me.HireDate = MyBase.SetDateTimeAsString(ColumnNames.HireDate, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Salary() As String
			Get
				If Me.IsColumnNull(ColumnNames.Salary) Then
					Return String.Empty
				Else
					Return MyBase.GetDecimalAsString(ColumnNames.Salary)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Salary)
				Else
					Me.Salary = MyBase.SetDecimalAsString(ColumnNames.Salary, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IsActive() As String
			Get
				If Me.IsColumnNull(ColumnNames.IsActive) Then
					Return String.Empty
				Else
					Return MyBase.GetShortAsString(ColumnNames.IsActive)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IsActive)
				Else
					Me.IsActive = MyBase.SetShortAsString(ColumnNames.IsActive, Value)
				End If
			End Set
		End Property


#End Region

#Region "Where Clause"
		Public Class WhereClause

			Public Sub New(ByVal entity As BusinessEntity)
				Me._entity = entity
			End Sub

			Public ReadOnly Property TearOff() As TearOffWhereParameter
				Get
					If _tearOff Is Nothing Then
						_tearOff = New TearOffWhereParameter(Me)
					End If

					Return _tearOff
				End Get
			End Property

#Region "TearOff's"
			Public Class TearOffWhereParameter

				Public Sub New(ByVal clause As WhereClause)
					Me._clause = clause
				End Sub


				Public ReadOnly Property ID() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.ID, Parameters.ID)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property DepartmentID() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.DepartmentID, Parameters.DepartmentID)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property FirstName() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.FirstName, Parameters.FirstName)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property LastName() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.LastName, Parameters.LastName)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property Age() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.Age, Parameters.Age)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property HireDate() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.HireDate, Parameters.HireDate)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property Salary() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.Salary, Parameters.Salary)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property IsActive() As WhereParameter
					Get
						Dim where As WhereParameter = New WhereParameter(ColumnNames.IsActive, Parameters.IsActive)
						Me._clause._entity.Query.AddWhereParemeter(where)
						Return where
					End Get
				End Property


				Private _clause As WhereClause
			End Class
#End Region

			Public ReadOnly Property ID() As WhereParameter
				Get
					If _ID_W Is Nothing Then
						_ID_W = TearOff.ID
					End If
					Return _ID_W
				End Get
			End Property

			Public ReadOnly Property DepartmentID() As WhereParameter
				Get
					If _DepartmentID_W Is Nothing Then
						_DepartmentID_W = TearOff.DepartmentID
					End If
					Return _DepartmentID_W
				End Get
			End Property

			Public ReadOnly Property FirstName() As WhereParameter
				Get
					If _FirstName_W Is Nothing Then
						_FirstName_W = TearOff.FirstName
					End If
					Return _FirstName_W
				End Get
			End Property

			Public ReadOnly Property LastName() As WhereParameter
				Get
					If _LastName_W Is Nothing Then
						_LastName_W = TearOff.LastName
					End If
					Return _LastName_W
				End Get
			End Property

			Public ReadOnly Property Age() As WhereParameter
				Get
					If _Age_W Is Nothing Then
						_Age_W = TearOff.Age
					End If
					Return _Age_W
				End Get
			End Property

			Public ReadOnly Property HireDate() As WhereParameter
				Get
					If _HireDate_W Is Nothing Then
						_HireDate_W = TearOff.HireDate
					End If
					Return _HireDate_W
				End Get
			End Property

			Public ReadOnly Property Salary() As WhereParameter
				Get
					If _Salary_W Is Nothing Then
						_Salary_W = TearOff.Salary
					End If
					Return _Salary_W
				End Get
			End Property

			Public ReadOnly Property IsActive() As WhereParameter
				Get
					If _IsActive_W Is Nothing Then
						_IsActive_W = TearOff.IsActive
					End If
					Return _IsActive_W
				End Get
			End Property

			Private _ID_W As WhereParameter = Nothing
			Private _DepartmentID_W As WhereParameter = Nothing
			Private _FirstName_W As WhereParameter = Nothing
			Private _LastName_W As WhereParameter = Nothing
			Private _Age_W As WhereParameter = Nothing
			Private _HireDate_W As WhereParameter = Nothing
			Private _Salary_W As WhereParameter = Nothing
			Private _IsActive_W As WhereParameter = Nothing

			Public Sub WhereClauseReset()

				_ID_W = Nothing
				_DepartmentID_W = Nothing
				_FirstName_W = Nothing
				_LastName_W = Nothing
				_Age_W = Nothing
				_HireDate_W = Nothing
				_Salary_W = Nothing
				_IsActive_W = Nothing
				Me._entity.Query.FlushWhereParameters()

			End Sub

			Private _entity As BusinessEntity
			Private _tearOff As TearOffWhereParameter
		End Class

		Public ReadOnly Property Where() As WhereClause
			Get
				If _whereClause Is Nothing Then
					_whereClause = New WhereClause(Me)
				End If

				Return _whereClause
			End Get
		End Property

		Private _whereClause As WhereClause = Nothing
#End Region

#Region "Aggregate Clause"
		Public Class AggregateClause

			Public Sub New(ByVal entity As BusinessEntity)
				Me._entity = entity
			End Sub

			Public ReadOnly Property TearOff() As TearOffAggregateParameter
				Get
					If _tearOff Is Nothing Then
						_tearOff = New TearOffAggregateParameter(Me)
					End If

					Return _tearOff
				End Get
			End Property

#Region "AggregateParameter TearOff's"
			Public Class TearOffAggregateParameter

				Public Sub New(ByVal clause As AggregateClause)
					Me._clause = clause
				End Sub


				Public ReadOnly Property ID() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.ID, Parameters.ID)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property DepartmentID() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.DepartmentID, Parameters.DepartmentID)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property FirstName() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FirstName, Parameters.FirstName)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property LastName() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.LastName, Parameters.LastName)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property Age() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Age, Parameters.Age)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property HireDate() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.HireDate, Parameters.HireDate)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property Salary() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Salary, Parameters.Salary)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property

				Public ReadOnly Property IsActive() As AggregateParameter
					Get
						Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IsActive, Parameters.IsActive)
						Me._clause._entity.Query.AddAggregateParameter(where)
						Return where
					End Get
				End Property


				Private _clause As AggregateClause
			End Class
#End Region

			Public ReadOnly Property ID() As AggregateParameter
				Get
					If _ID_W Is Nothing Then
						_ID_W = TearOff.ID
					End If
					Return _ID_W
				End Get
			End Property

			Public ReadOnly Property DepartmentID() As AggregateParameter
				Get
					If _DepartmentID_W Is Nothing Then
						_DepartmentID_W = TearOff.DepartmentID
					End If
					Return _DepartmentID_W
				End Get
			End Property

			Public ReadOnly Property FirstName() As AggregateParameter
				Get
					If _FirstName_W Is Nothing Then
						_FirstName_W = TearOff.FirstName
					End If
					Return _FirstName_W
				End Get
			End Property

			Public ReadOnly Property LastName() As AggregateParameter
				Get
					If _LastName_W Is Nothing Then
						_LastName_W = TearOff.LastName
					End If
					Return _LastName_W
				End Get
			End Property

			Public ReadOnly Property Age() As AggregateParameter
				Get
					If _Age_W Is Nothing Then
						_Age_W = TearOff.Age
					End If
					Return _Age_W
				End Get
			End Property

			Public ReadOnly Property HireDate() As AggregateParameter
				Get
					If _HireDate_W Is Nothing Then
						_HireDate_W = TearOff.HireDate
					End If
					Return _HireDate_W
				End Get
			End Property

			Public ReadOnly Property Salary() As AggregateParameter
				Get
					If _Salary_W Is Nothing Then
						_Salary_W = TearOff.Salary
					End If
					Return _Salary_W
				End Get
			End Property

			Public ReadOnly Property IsActive() As AggregateParameter
				Get
					If _IsActive_W Is Nothing Then
						_IsActive_W = TearOff.IsActive
					End If
					Return _IsActive_W
				End Get
			End Property

			Private _ID_W As AggregateParameter = Nothing
			Private _DepartmentID_W As AggregateParameter = Nothing
			Private _FirstName_W As AggregateParameter = Nothing
			Private _LastName_W As AggregateParameter = Nothing
			Private _Age_W As AggregateParameter = Nothing
			Private _HireDate_W As AggregateParameter = Nothing
			Private _Salary_W As AggregateParameter = Nothing
			Private _IsActive_W As AggregateParameter = Nothing

			Public Sub AggregateClauseReset()

				_ID_W = Nothing
				_DepartmentID_W = Nothing
				_FirstName_W = Nothing
				_LastName_W = Nothing
				_Age_W = Nothing
				_HireDate_W = Nothing
				_Salary_W = Nothing
				_IsActive_W = Nothing
				Me._entity.Query.FlushAggregateParameters()

			End Sub

			Private _entity As BusinessEntity
			Private _tearOff As TearOffAggregateParameter
		End Class

		Public ReadOnly Property Aggregate() As AggregateClause
			Get
				If _aggregateClause Is Nothing Then
					_aggregateClause = New AggregateClause(Me)
				End If

				Return _aggregateClause
			End Get
		End Property

		Private _aggregateClause As AggregateClause = Nothing
#End Region

		Protected Overrides Function GetInsertCommand() As IDbCommand

			Dim cmd As FbCommand = New FbCommand
			cmd.CommandType = CommandType.StoredProcedure
			cmd.CommandText = "EXECUTE PROCEDURE PI_AGGREGATETEST (?,?,?,?,?,?,?,?)"

			CreateParameters(cmd)

			Dim p As FbParameter
			p = cmd.Parameters(Parameters.ID.ParameterName)
			p.Direction = ParameterDirection.InputOutput

			Return cmd

		End Function

		Protected Overrides Function GetUpdateCommand() As IDbCommand

			Dim cmd As FbCommand = New FbCommand
			cmd.CommandType = CommandType.StoredProcedure
			cmd.CommandText = "EXECUTE PROCEDURE PU_AGGREGATETEST (?,?,?,?,?,?,?,?)"

			CreateParameters(cmd)

			Return cmd

		End Function

		Protected Overrides Function GetDeleteCommand() As IDbCommand

			Dim cmd As FbCommand = New FbCommand
			cmd.CommandType = CommandType.StoredProcedure
			cmd.CommandText = "EXECUTE PROCEDURE PD_AGGREGATETEST (?)"

			Dim p As FbParameter
			p = cmd.Parameters.Add(Parameters.ID)
			p.SourceColumn = ColumnNames.ID
			p.SourceVersion = DataRowVersion.Current


			Return cmd

		End Function

		Private Sub CreateParameters(ByVal cmd As FbCommand)

			Dim p As FbParameter
			p = cmd.Parameters.Add(Parameters.ID)
			p.SourceColumn = ColumnNames.ID
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.DepartmentID)
			p.SourceColumn = ColumnNames.DepartmentID
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.FirstName)
			p.SourceColumn = ColumnNames.FirstName
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.LastName)
			p.SourceColumn = ColumnNames.LastName
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.Age)
			p.SourceColumn = ColumnNames.Age
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.HireDate)
			p.SourceColumn = ColumnNames.HireDate
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.Salary)
			p.SourceColumn = ColumnNames.Salary
			p.SourceVersion = DataRowVersion.Current

			p = cmd.Parameters.Add(Parameters.IsActive)
			p.SourceColumn = ColumnNames.IsActive
			p.SourceVersion = DataRowVersion.Current


		End Sub

	End Class

End Namespace



