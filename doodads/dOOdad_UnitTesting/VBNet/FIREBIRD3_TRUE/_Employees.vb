
'===============================================================================
'  Generated From - VbNet_dOOdads_BusinessEntity.vbgen
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

' Generated by MyGeneration Version # (1.0.0.4)

Imports System
Imports System.Data
Imports FirebirdSql.Data.Firebird
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

Namespace FIREBIRD3_TRUE

    Public MustInherit Class _Employees
        Inherits FirebirdSqlEntity

        Public Sub New()
            Me.QuerySource = "Employees"
            Me.MappingName = "Employees"
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
            MyBase.FlushData()
        End Sub


        '=================================================================
        '  	Public Function LoadAll() As Boolean
        '=================================================================
        '  Loads all of the records in the database, and sets the currentRow to the first row
        '=================================================================
        Public Function LoadAll() As Boolean

            Dim parameters As ListDictionary = Nothing


            Return MyBase.LoadFromSql("PL_EMPLOYEES", parameters)

        End Function

        '=================================================================
        ' Public Overridable Function LoadByPrimaryKey()  As Boolean
        '=================================================================
        '  Loads a single row of via the primary key
        '=================================================================
        Public Overridable Function LoadByPrimaryKey(ByVal EmployeeID As Long) As Boolean

            Dim parameters As ListDictionary = New ListDictionary
            parameters.Add(Me.Parameters.EmployeeID, EmployeeID)


            Return MyBase.LoadFromSql("PK_EMPLOYEES", parameters)

        End Function

#Region "Parameters"
        Protected Class Parameters

            Public Shared ReadOnly Property EmployeeID() As FbParameter
                Get
                    Return New FbParameter("@EmployeeID", FbDbType.BigInt, 0)
                End Get
            End Property

            Public Shared ReadOnly Property FirstName() As FbParameter
                Get
                    Return New FbParameter("@FirstName", FbDbType.VarChar, 80)
                End Get
            End Property

            Public Shared ReadOnly Property LastName() As FbParameter
                Get
                    Return New FbParameter("@LastName", FbDbType.VarChar, 80)
                End Get
            End Property

        End Class
#End Region

#Region "ColumnNames"
        Public Class ColumnNames

            Public Const EmployeeID As String = "EmployeeID"
            Public Const FirstName As String = "FirstName"
            Public Const LastName As String = "LastName"

            Public Shared Function ToPropertyName(ByVal columnName As String) As String

                If ht Is Nothing Then

                    ht = New Hashtable

                    ht(EmployeeID) = _Employees.PropertyNames.EmployeeID
                    ht(FirstName) = _Employees.PropertyNames.FirstName
                    ht(LastName) = _Employees.PropertyNames.LastName

                End If

                Return CType(ht(columnName), String)

            End Function

            Private Shared ht As Hashtable = Nothing
        End Class
#End Region

#Region "PropertyNames"
        Public Class PropertyNames

            Public Const EmployeeID As String = "EmployeeID"
            Public Const FirstName As String = "FirstName"
            Public Const LastName As String = "LastName"

            Public Shared Function ToColumnName(ByVal propertyName As String) As String

                If ht Is Nothing Then

                    ht = New Hashtable

                    ht(EmployeeID) = _Employees.ColumnNames.EmployeeID
                    ht(FirstName) = _Employees.ColumnNames.FirstName
                    ht(LastName) = _Employees.ColumnNames.LastName

                End If

                Return CType(ht(propertyName), String)

            End Function

            Private Shared ht As Hashtable = Nothing

        End Class
#End Region

#Region "StringPropertyNames"
        Public Class StringPropertyNames

            Public Const EmployeeID As String = "s_EmployeeID"
            Public Const FirstName As String = "s_FirstName"
            Public Const LastName As String = "s_LastName"

        End Class
#End Region

#Region "Properties"
        Public Overridable Property EmployeeID() As Long
            Get
                Return MyBase.GetLong(ColumnNames.EmployeeID)
            End Get
            Set(ByVal Value As Long)
                MyBase.SetLong(ColumnNames.EmployeeID, Value)
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


#End Region

#Region "String Properties"

        Public Overridable Property s_EmployeeID() As String
            Get
                If Me.IsColumnNull(ColumnNames.EmployeeID) Then
                    Return String.Empty
                Else
                    Return MyBase.GetLongAsString(ColumnNames.EmployeeID)
                End If
            End Get
            Set(ByVal Value As String)
                If String.Empty = Value Then
                    Me.SetColumnNull(ColumnNames.EmployeeID)
                Else
                    Me.EmployeeID = MyBase.SetLongAsString(ColumnNames.EmployeeID, Value)
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
                If String.Empty = Value Then
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
                If String.Empty = Value Then
                    Me.SetColumnNull(ColumnNames.LastName)
                Else
                    Me.LastName = MyBase.SetStringAsString(ColumnNames.LastName, Value)
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


                Public ReadOnly Property EmployeeID() As WhereParameter
                    Get
                        Dim where As WhereParameter = New WhereParameter(ColumnNames.EmployeeID, Parameters.EmployeeID)
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


                Private _clause As WhereClause
            End Class
#End Region

            Public ReadOnly Property EmployeeID() As WhereParameter
                Get
                    If _EmployeeID_W Is Nothing Then
                        _EmployeeID_W = TearOff.EmployeeID
                    End If
                    Return _EmployeeID_W
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

            Private _EmployeeID_W As WhereParameter = Nothing
            Private _FirstName_W As WhereParameter = Nothing
            Private _LastName_W As WhereParameter = Nothing

            Public Sub WhereClauseReset()

                _EmployeeID_W = Nothing
                _FirstName_W = Nothing
                _LastName_W = Nothing
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

        Protected Overrides Function GetInsertCommand() As IDbCommand

            Dim cmd As FbCommand = New FbCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "EXECUTE PROCEDURE PI_EMPLOYEES (?,?,?)"

            CreateParameters(cmd)

            Return cmd

        End Function

        Protected Overrides Function GetUpdateCommand() As IDbCommand

            Dim cmd As FbCommand = New FbCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "EXECUTE PROCEDURE PU_EMPLOYEES (?,?,?)"

            CreateParameters(cmd)

            Return cmd

        End Function

        Protected Overrides Function GetDeleteCommand() As IDbCommand

            Dim cmd As FbCommand = New FbCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "EXECUTE PROCEDURE PD_EMPLOYEES (?)"

            Dim p As FbParameter
            p = cmd.Parameters.Add(Parameters.EmployeeID)
            p.SourceColumn = ColumnNames.EmployeeID
            p.SourceVersion = DataRowVersion.Current


            Return cmd

        End Function

        Private Sub CreateParameters(ByVal cmd As FbCommand)

            Dim p As FbParameter
            p = cmd.Parameters.Add(Parameters.EmployeeID)
            p.SourceColumn = ColumnNames.EmployeeID
            p.SourceVersion = DataRowVersion.Current

            p = cmd.Parameters.Add(Parameters.FirstName)
            p.SourceColumn = ColumnNames.FirstName
            p.SourceVersion = DataRowVersion.Current

            p = cmd.Parameters.Add(Parameters.LastName)
            p.SourceColumn = ColumnNames.LastName
            p.SourceVersion = DataRowVersion.Current


        End Sub

    End Class

End Namespace
