
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
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
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
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

Public MustInherit Class _Products
	Inherits SqlClientEntity

	Public Sub New()
		Me.QuerySource = "Products"
		Me.MappingName = "Products"
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


		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_ProductsLoadAll]", parameters)

	End Function

	'=================================================================
	' Public Overridable Function LoadByPrimaryKey()  As Boolean
	'=================================================================
	'  Loads a single row of via the primary key
	'=================================================================
	Public Overridable Function LoadByPrimaryKey(ByVal ProductID As Integer) As Boolean

		Dim parameters As ListDictionary = New ListDictionary()
		parameters.Add(_Products.Parameters.ProductID, ProductID)


		Return MyBase.LoadFromSql("[" + Me.SchemaStoredProcedure + "proc_ProductsLoadByPrimaryKey]", parameters)

	End Function

#Region "Parameters"
	Protected Class Parameters

		Public Shared ReadOnly Property ProductID() As SqlParameter
			Get
				Return New SqlParameter("@ProductID", SqlDbType.Int, 0)
			End Get
		End Property

		Public Shared ReadOnly Property ProductName() As SqlParameter
			Get
				Return New SqlParameter("@ProductName", SqlDbType.NVarChar, 40)
			End Get
		End Property

		Public Shared ReadOnly Property SupplierID() As SqlParameter
			Get
				Return New SqlParameter("@SupplierID", SqlDbType.Int, 0)
			End Get
		End Property

		Public Shared ReadOnly Property CategoryID() As SqlParameter
			Get
				Return New SqlParameter("@CategoryID", SqlDbType.Int, 0)
			End Get
		End Property

		Public Shared ReadOnly Property QuantityPerUnit() As SqlParameter
			Get
				Return New SqlParameter("@QuantityPerUnit", SqlDbType.NVarChar, 20)
			End Get
		End Property

		Public Shared ReadOnly Property UnitPrice() As SqlParameter
			Get
				Return New SqlParameter("@UnitPrice", SqlDbType.Money, 0)
			End Get
		End Property

		Public Shared ReadOnly Property UnitsInStock() As SqlParameter
			Get
				Return New SqlParameter("@UnitsInStock", SqlDbType.SmallInt, 0)
			End Get
		End Property

		Public Shared ReadOnly Property UnitsOnOrder() As SqlParameter
			Get
				Return New SqlParameter("@UnitsOnOrder", SqlDbType.SmallInt, 0)
			End Get
		End Property

		Public Shared ReadOnly Property ReorderLevel() As SqlParameter
			Get
				Return New SqlParameter("@ReorderLevel", SqlDbType.SmallInt, 0)
			End Get
		End Property

		Public Shared ReadOnly Property Discontinued() As SqlParameter
			Get
				Return New SqlParameter("@Discontinued", SqlDbType.Bit, 0)
			End Get
		End Property

	End Class
#End Region

#Region "ColumnNames"
	Public Class ColumnNames

		Public Const ProductID As String = "ProductID"
		Public Const ProductName As String = "ProductName"
		Public Const SupplierID As String = "SupplierID"
		Public Const CategoryID As String = "CategoryID"
		Public Const QuantityPerUnit As String = "QuantityPerUnit"
		Public Const UnitPrice As String = "UnitPrice"
		Public Const UnitsInStock As String = "UnitsInStock"
		Public Const UnitsOnOrder As String = "UnitsOnOrder"
		Public Const ReorderLevel As String = "ReorderLevel"
		Public Const Discontinued As String = "Discontinued"

		Public Shared Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then

				ht = New Hashtable

				ht(ProductID) = _Products.PropertyNames.ProductID
				ht(ProductName) = _Products.PropertyNames.ProductName
				ht(SupplierID) = _Products.PropertyNames.SupplierID
				ht(CategoryID) = _Products.PropertyNames.CategoryID
				ht(QuantityPerUnit) = _Products.PropertyNames.QuantityPerUnit
				ht(UnitPrice) = _Products.PropertyNames.UnitPrice
				ht(UnitsInStock) = _Products.PropertyNames.UnitsInStock
				ht(UnitsOnOrder) = _Products.PropertyNames.UnitsOnOrder
				ht(ReorderLevel) = _Products.PropertyNames.ReorderLevel
				ht(Discontinued) = _Products.PropertyNames.Discontinued

			End If

			Return CType(ht(columnName), String)

		End Function

		Private Shared ht As Hashtable = Nothing
	End Class
#End Region

#Region "PropertyNames"
	Public Class PropertyNames

		Public Const ProductID As String = "ProductID"
		Public Const ProductName As String = "ProductName"
		Public Const SupplierID As String = "SupplierID"
		Public Const CategoryID As String = "CategoryID"
		Public Const QuantityPerUnit As String = "QuantityPerUnit"
		Public Const UnitPrice As String = "UnitPrice"
		Public Const UnitsInStock As String = "UnitsInStock"
		Public Const UnitsOnOrder As String = "UnitsOnOrder"
		Public Const ReorderLevel As String = "ReorderLevel"
		Public Const Discontinued As String = "Discontinued"

		Public Shared Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then

				ht = New Hashtable

				ht(ProductID) = _Products.ColumnNames.ProductID
				ht(ProductName) = _Products.ColumnNames.ProductName
				ht(SupplierID) = _Products.ColumnNames.SupplierID
				ht(CategoryID) = _Products.ColumnNames.CategoryID
				ht(QuantityPerUnit) = _Products.ColumnNames.QuantityPerUnit
				ht(UnitPrice) = _Products.ColumnNames.UnitPrice
				ht(UnitsInStock) = _Products.ColumnNames.UnitsInStock
				ht(UnitsOnOrder) = _Products.ColumnNames.UnitsOnOrder
				ht(ReorderLevel) = _Products.ColumnNames.ReorderLevel
				ht(Discontinued) = _Products.ColumnNames.Discontinued

			End If

			Return CType(ht(propertyName), String)

		End Function

		Private Shared ht As Hashtable = Nothing

	End Class
#End Region

#Region "StringPropertyNames"
	Public Class StringPropertyNames

		Public Const ProductID As String = "s_ProductID"
		Public Const ProductName As String = "s_ProductName"
		Public Const SupplierID As String = "s_SupplierID"
		Public Const CategoryID As String = "s_CategoryID"
		Public Const QuantityPerUnit As String = "s_QuantityPerUnit"
		Public Const UnitPrice As String = "s_UnitPrice"
		Public Const UnitsInStock As String = "s_UnitsInStock"
		Public Const UnitsOnOrder As String = "s_UnitsOnOrder"
		Public Const ReorderLevel As String = "s_ReorderLevel"
		Public Const Discontinued As String = "s_Discontinued"

	End Class
#End Region

#Region "Properties"
	Public Overridable Property ProductID() As Integer
		Get
			Return MyBase.GetInteger(ColumnNames.ProductID)
		End Get
		Set(ByVal Value As Integer)
			MyBase.SetInteger(ColumnNames.ProductID, Value)
		End Set
	End Property

	Public Overridable Property ProductName() As String
		Get
			Return MyBase.GetString(ColumnNames.ProductName)
		End Get
		Set(ByVal Value As String)
			MyBase.SetString(ColumnNames.ProductName, Value)
		End Set
	End Property

	Public Overridable Property SupplierID() As Integer
		Get
			Return MyBase.GetInteger(ColumnNames.SupplierID)
		End Get
		Set(ByVal Value As Integer)
			MyBase.SetInteger(ColumnNames.SupplierID, Value)
		End Set
	End Property

	Public Overridable Property CategoryID() As Integer
		Get
			Return MyBase.GetInteger(ColumnNames.CategoryID)
		End Get
		Set(ByVal Value As Integer)
			MyBase.SetInteger(ColumnNames.CategoryID, Value)
		End Set
	End Property

	Public Overridable Property QuantityPerUnit() As String
		Get
			Return MyBase.GetString(ColumnNames.QuantityPerUnit)
		End Get
		Set(ByVal Value As String)
			MyBase.SetString(ColumnNames.QuantityPerUnit, Value)
		End Set
	End Property

	Public Overridable Property UnitPrice() As Decimal
		Get
			Return MyBase.GetDecimal(ColumnNames.UnitPrice)
		End Get
		Set(ByVal Value As Decimal)
			MyBase.SetDecimal(ColumnNames.UnitPrice, Value)
		End Set
	End Property

	Public Overridable Property UnitsInStock() As Short
		Get
			Return MyBase.GetShort(ColumnNames.UnitsInStock)
		End Get
		Set(ByVal Value As Short)
			MyBase.SetShort(ColumnNames.UnitsInStock, Value)
		End Set
	End Property

	Public Overridable Property UnitsOnOrder() As Short
		Get
			Return MyBase.GetShort(ColumnNames.UnitsOnOrder)
		End Get
		Set(ByVal Value As Short)
			MyBase.SetShort(ColumnNames.UnitsOnOrder, Value)
		End Set
	End Property

	Public Overridable Property ReorderLevel() As Short
		Get
			Return MyBase.GetShort(ColumnNames.ReorderLevel)
		End Get
		Set(ByVal Value As Short)
			MyBase.SetShort(ColumnNames.ReorderLevel, Value)
		End Set
	End Property

	Public Overridable Property Discontinued() As Boolean
		Get
			Return MyBase.GetBoolean(ColumnNames.Discontinued)
		End Get
		Set(ByVal Value As Boolean)
			MyBase.SetBoolean(ColumnNames.Discontinued, Value)
		End Set
	End Property


#End Region

#Region "String Properties"

	Public Overridable Property s_ProductID() As String
		Get
			If Me.IsColumnNull(ColumnNames.ProductID) Then
				Return String.Empty
			Else
				Return MyBase.GetIntegerAsString(ColumnNames.ProductID)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.ProductID)
			Else
				Me.ProductID = MyBase.SetIntegerAsString(ColumnNames.ProductID, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_ProductName() As String
		Get
			If Me.IsColumnNull(ColumnNames.ProductName) Then
				Return String.Empty
			Else
				Return MyBase.GetStringAsString(ColumnNames.ProductName)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.ProductName)
			Else
				Me.ProductName = MyBase.SetStringAsString(ColumnNames.ProductName, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_SupplierID() As String
		Get
			If Me.IsColumnNull(ColumnNames.SupplierID) Then
				Return String.Empty
			Else
				Return MyBase.GetIntegerAsString(ColumnNames.SupplierID)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.SupplierID)
			Else
				Me.SupplierID = MyBase.SetIntegerAsString(ColumnNames.SupplierID, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_CategoryID() As String
		Get
			If Me.IsColumnNull(ColumnNames.CategoryID) Then
				Return String.Empty
			Else
				Return MyBase.GetIntegerAsString(ColumnNames.CategoryID)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.CategoryID)
			Else
				Me.CategoryID = MyBase.SetIntegerAsString(ColumnNames.CategoryID, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_QuantityPerUnit() As String
		Get
			If Me.IsColumnNull(ColumnNames.QuantityPerUnit) Then
				Return String.Empty
			Else
				Return MyBase.GetStringAsString(ColumnNames.QuantityPerUnit)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.QuantityPerUnit)
			Else
				Me.QuantityPerUnit = MyBase.SetStringAsString(ColumnNames.QuantityPerUnit, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_UnitPrice() As String
		Get
			If Me.IsColumnNull(ColumnNames.UnitPrice) Then
				Return String.Empty
			Else
				Return MyBase.GetDecimalAsString(ColumnNames.UnitPrice)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.UnitPrice)
			Else
				Me.UnitPrice = MyBase.SetDecimalAsString(ColumnNames.UnitPrice, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_UnitsInStock() As String
		Get
			If Me.IsColumnNull(ColumnNames.UnitsInStock) Then
				Return String.Empty
			Else
				Return MyBase.GetShortAsString(ColumnNames.UnitsInStock)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.UnitsInStock)
			Else
				Me.UnitsInStock = MyBase.SetShortAsString(ColumnNames.UnitsInStock, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_UnitsOnOrder() As String
		Get
			If Me.IsColumnNull(ColumnNames.UnitsOnOrder) Then
				Return String.Empty
			Else
				Return MyBase.GetShortAsString(ColumnNames.UnitsOnOrder)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.UnitsOnOrder)
			Else
				Me.UnitsOnOrder = MyBase.SetShortAsString(ColumnNames.UnitsOnOrder, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_ReorderLevel() As String
		Get
			If Me.IsColumnNull(ColumnNames.ReorderLevel) Then
				Return String.Empty
			Else
				Return MyBase.GetShortAsString(ColumnNames.ReorderLevel)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.ReorderLevel)
			Else
				Me.ReorderLevel = MyBase.SetShortAsString(ColumnNames.ReorderLevel, Value)
			End If
		End Set
	End Property

	Public Overridable Property s_Discontinued() As String
		Get
			If Me.IsColumnNull(ColumnNames.Discontinued) Then
				Return String.Empty
			Else
				Return MyBase.GetBooleanAsString(ColumnNames.Discontinued)
			End If
		End Get
		Set(ByVal Value As String)
			If String.Empty = value Then
				Me.SetColumnNull(ColumnNames.Discontinued)
			Else
				Me.Discontinued = MyBase.SetBooleanAsString(ColumnNames.Discontinued, Value)
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


			Public ReadOnly Property ProductID() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.ProductID, Parameters.ProductID)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property ProductName() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.ProductName, Parameters.ProductName)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property SupplierID() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.SupplierID, Parameters.SupplierID)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property CategoryID() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.CategoryID, Parameters.CategoryID)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property QuantityPerUnit() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.QuantityPerUnit, Parameters.QuantityPerUnit)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property UnitPrice() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.UnitPrice, Parameters.UnitPrice)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property UnitsInStock() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.UnitsInStock, Parameters.UnitsInStock)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property UnitsOnOrder() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.UnitsOnOrder, Parameters.UnitsOnOrder)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property ReorderLevel() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.ReorderLevel, Parameters.ReorderLevel)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Discontinued() As WhereParameter
				Get
					Dim where As WhereParameter = New WhereParameter(ColumnNames.Discontinued, Parameters.Discontinued)
					Me._clause._entity.Query.AddWhereParemeter(where)
					Return where
				End Get
			End Property


			Private _clause As WhereClause
		End Class
#End Region

		Public ReadOnly Property ProductID() As WhereParameter
			Get
				If _ProductID_W Is Nothing Then
					_ProductID_W = TearOff.ProductID
				End If
				Return _ProductID_W
			End Get
		End Property

		Public ReadOnly Property ProductName() As WhereParameter
			Get
				If _ProductName_W Is Nothing Then
					_ProductName_W = TearOff.ProductName
				End If
				Return _ProductName_W
			End Get
		End Property

		Public ReadOnly Property SupplierID() As WhereParameter
			Get
				If _SupplierID_W Is Nothing Then
					_SupplierID_W = TearOff.SupplierID
				End If
				Return _SupplierID_W
			End Get
		End Property

		Public ReadOnly Property CategoryID() As WhereParameter
			Get
				If _CategoryID_W Is Nothing Then
					_CategoryID_W = TearOff.CategoryID
				End If
				Return _CategoryID_W
			End Get
		End Property

		Public ReadOnly Property QuantityPerUnit() As WhereParameter
			Get
				If _QuantityPerUnit_W Is Nothing Then
					_QuantityPerUnit_W = TearOff.QuantityPerUnit
				End If
				Return _QuantityPerUnit_W
			End Get
		End Property

		Public ReadOnly Property UnitPrice() As WhereParameter
			Get
				If _UnitPrice_W Is Nothing Then
					_UnitPrice_W = TearOff.UnitPrice
				End If
				Return _UnitPrice_W
			End Get
		End Property

		Public ReadOnly Property UnitsInStock() As WhereParameter
			Get
				If _UnitsInStock_W Is Nothing Then
					_UnitsInStock_W = TearOff.UnitsInStock
				End If
				Return _UnitsInStock_W
			End Get
		End Property

		Public ReadOnly Property UnitsOnOrder() As WhereParameter
			Get
				If _UnitsOnOrder_W Is Nothing Then
					_UnitsOnOrder_W = TearOff.UnitsOnOrder
				End If
				Return _UnitsOnOrder_W
			End Get
		End Property

		Public ReadOnly Property ReorderLevel() As WhereParameter
			Get
				If _ReorderLevel_W Is Nothing Then
					_ReorderLevel_W = TearOff.ReorderLevel
				End If
				Return _ReorderLevel_W
			End Get
		End Property

		Public ReadOnly Property Discontinued() As WhereParameter
			Get
				If _Discontinued_W Is Nothing Then
					_Discontinued_W = TearOff.Discontinued
				End If
				Return _Discontinued_W
			End Get
		End Property

		Private _ProductID_W As WhereParameter = Nothing
		Private _ProductName_W As WhereParameter = Nothing
		Private _SupplierID_W As WhereParameter = Nothing
		Private _CategoryID_W As WhereParameter = Nothing
		Private _QuantityPerUnit_W As WhereParameter = Nothing
		Private _UnitPrice_W As WhereParameter = Nothing
		Private _UnitsInStock_W As WhereParameter = Nothing
		Private _UnitsOnOrder_W As WhereParameter = Nothing
		Private _ReorderLevel_W As WhereParameter = Nothing
		Private _Discontinued_W As WhereParameter = Nothing

		Public Sub WhereClauseReset()

			_ProductID_W = Nothing
			_ProductName_W = Nothing
			_SupplierID_W = Nothing
			_CategoryID_W = Nothing
			_QuantityPerUnit_W = Nothing
			_UnitPrice_W = Nothing
			_UnitsInStock_W = Nothing
			_UnitsOnOrder_W = Nothing
			_ReorderLevel_W = Nothing
			_Discontinued_W = Nothing
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


			Public ReadOnly Property ProductID() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.ProductID, Parameters.ProductID)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property ProductName() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.ProductName, Parameters.ProductName)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property SupplierID() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.SupplierID, Parameters.SupplierID)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property CategoryID() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.CategoryID, Parameters.CategoryID)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property QuantityPerUnit() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.QuantityPerUnit, Parameters.QuantityPerUnit)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property UnitPrice() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.UnitPrice, Parameters.UnitPrice)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property UnitsInStock() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.UnitsInStock, Parameters.UnitsInStock)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property UnitsOnOrder() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.UnitsOnOrder, Parameters.UnitsOnOrder)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property ReorderLevel() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.ReorderLevel, Parameters.ReorderLevel)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property

			Public ReadOnly Property Discontinued() As AggregateParameter
				Get
					Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Discontinued, Parameters.Discontinued)
					Me._clause._entity.Query.AddAggregateParameter(where)
					Return where
				End Get
			End Property


			Private _clause As AggregateClause
		End Class
#End Region

		Public ReadOnly Property ProductID() As AggregateParameter
			Get
				If _ProductID_W Is Nothing Then
					_ProductID_W = TearOff.ProductID
				End If
				Return _ProductID_W
			End Get
		End Property

		Public ReadOnly Property ProductName() As AggregateParameter
			Get
				If _ProductName_W Is Nothing Then
					_ProductName_W = TearOff.ProductName
				End If
				Return _ProductName_W
			End Get
		End Property

		Public ReadOnly Property SupplierID() As AggregateParameter
			Get
				If _SupplierID_W Is Nothing Then
					_SupplierID_W = TearOff.SupplierID
				End If
				Return _SupplierID_W
			End Get
		End Property

		Public ReadOnly Property CategoryID() As AggregateParameter
			Get
				If _CategoryID_W Is Nothing Then
					_CategoryID_W = TearOff.CategoryID
				End If
				Return _CategoryID_W
			End Get
		End Property

		Public ReadOnly Property QuantityPerUnit() As AggregateParameter
			Get
				If _QuantityPerUnit_W Is Nothing Then
					_QuantityPerUnit_W = TearOff.QuantityPerUnit
				End If
				Return _QuantityPerUnit_W
			End Get
		End Property

		Public ReadOnly Property UnitPrice() As AggregateParameter
			Get
				If _UnitPrice_W Is Nothing Then
					_UnitPrice_W = TearOff.UnitPrice
				End If
				Return _UnitPrice_W
			End Get
		End Property

		Public ReadOnly Property UnitsInStock() As AggregateParameter
			Get
				If _UnitsInStock_W Is Nothing Then
					_UnitsInStock_W = TearOff.UnitsInStock
				End If
				Return _UnitsInStock_W
			End Get
		End Property

		Public ReadOnly Property UnitsOnOrder() As AggregateParameter
			Get
				If _UnitsOnOrder_W Is Nothing Then
					_UnitsOnOrder_W = TearOff.UnitsOnOrder
				End If
				Return _UnitsOnOrder_W
			End Get
		End Property

		Public ReadOnly Property ReorderLevel() As AggregateParameter
			Get
				If _ReorderLevel_W Is Nothing Then
					_ReorderLevel_W = TearOff.ReorderLevel
				End If
				Return _ReorderLevel_W
			End Get
		End Property

		Public ReadOnly Property Discontinued() As AggregateParameter
			Get
				If _Discontinued_W Is Nothing Then
					_Discontinued_W = TearOff.Discontinued
				End If
				Return _Discontinued_W
			End Get
		End Property

		Private _ProductID_W As AggregateParameter = Nothing
		Private _ProductName_W As AggregateParameter = Nothing
		Private _SupplierID_W As AggregateParameter = Nothing
		Private _CategoryID_W As AggregateParameter = Nothing
		Private _QuantityPerUnit_W As AggregateParameter = Nothing
		Private _UnitPrice_W As AggregateParameter = Nothing
		Private _UnitsInStock_W As AggregateParameter = Nothing
		Private _UnitsOnOrder_W As AggregateParameter = Nothing
		Private _ReorderLevel_W As AggregateParameter = Nothing
		Private _Discontinued_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

			_ProductID_W = Nothing
			_ProductName_W = Nothing
			_SupplierID_W = Nothing
			_CategoryID_W = Nothing
			_QuantityPerUnit_W = Nothing
			_UnitPrice_W = Nothing
			_UnitsInStock_W = Nothing
			_UnitsOnOrder_W = Nothing
			_ReorderLevel_W = Nothing
			_Discontinued_W = Nothing
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

		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_ProductsInsert]"

		CreateParameters(cmd)

		Dim p As SqlParameter
		p = cmd.Parameters(Parameters.ProductID.ParameterName)
		p.Direction = ParameterDirection.Output

		Return cmd

	End Function

	Protected Overrides Function GetUpdateCommand() As IDbCommand

		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_ProductsUpdate]"

		CreateParameters(cmd)

		Return cmd

	End Function

	Protected Overrides Function GetDeleteCommand() As IDbCommand

		Dim cmd As SqlCommand = New SqlCommand
		cmd.CommandType = CommandType.StoredProcedure
		cmd.CommandText = "[" + Me.SchemaStoredProcedure + "proc_ProductsDelete]"

		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.ProductID)
		p.SourceColumn = ColumnNames.ProductID
		p.SourceVersion = DataRowVersion.Current


		Return cmd

	End Function

	Private Sub CreateParameters(ByVal cmd As SqlCommand)

		Dim p As SqlParameter
		p = cmd.Parameters.Add(Parameters.ProductID)
		p.SourceColumn = ColumnNames.ProductID
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.ProductName)
		p.SourceColumn = ColumnNames.ProductName
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.SupplierID)
		p.SourceColumn = ColumnNames.SupplierID
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.CategoryID)
		p.SourceColumn = ColumnNames.CategoryID
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.QuantityPerUnit)
		p.SourceColumn = ColumnNames.QuantityPerUnit
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.UnitPrice)
		p.SourceColumn = ColumnNames.UnitPrice
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.UnitsInStock)
		p.SourceColumn = ColumnNames.UnitsInStock
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.UnitsOnOrder)
		p.SourceColumn = ColumnNames.UnitsOnOrder
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.ReorderLevel)
		p.SourceColumn = ColumnNames.ReorderLevel
		p.SourceVersion = DataRowVersion.Current

		p = cmd.Parameters.Add(Parameters.Discontinued)
		p.SourceColumn = ColumnNames.Discontinued
		p.SourceVersion = DataRowVersion.Current


	End Sub

End Class



