Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace Softvibe.xDatabase

    Public Class XSqlSeverInterfacer
        Protected Connection As SqlConnection = Nothing
        Protected ServerName As String = String.Empty
        Protected DatabaseName As String = String.Empty
        Protected UserName As String = String.Empty
        Protected Password As String = String.Empty
        Protected Transaction As SqlTransaction = Nothing
        Protected AuthenticateMode As PSqlServerAuthenticateMode = PSqlServerAuthenticateMode.WindowsAuthenticateMode
        Protected Command As SqlCommand = Nothing

        Public Enum PSqlServerAuthenticateMode
            WindowsAuthenticateMode = 0
            SQLServerMixedMode = 1
        End Enum

        Public Sub New(ByVal ServerName As String, ByVal DatabaseName As String)
            Me.ServerName = ServerName
            Me.DatabaseName = DatabaseName
            Me.AuthenticateMode = PSqlServerAuthenticateMode.WindowsAuthenticateMode
        End Sub

        Public Sub New(ByVal ServerName As String, ByVal DatabaseName As String, ByVal UserName As String, ByVal Password As String)
            Me.ServerName = ServerName
            Me.DatabaseName = DatabaseName
            Me.AuthenticateMode = PSqlServerAuthenticateMode.SQLServerMixedMode
            Me.UserName = UserName
            Me.Password = Password
        End Sub

        Public Sub New(ByVal ServerName As String, ByVal DatabaseName As String, ByVal AuthenticateMode As PSqlServerAuthenticateMode, ByVal UserName As String, ByVal Password As String)
            Me.ServerName = ServerName
            Me.DatabaseName = DatabaseName
            Me.AuthenticateMode = AuthenticateMode
            Me.UserName = UserName
            Me.Password = Password
        End Sub

        Public ReadOnly Property Connected() As Boolean
            Get
                If Not (Me.Connection Is Nothing) Then
                    If Me.Connection.State = ConnectionState.Open Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End Get
        End Property

        Public Sub Open()
            Dim connectionString As String = String.Empty
            If Me.AuthenticateMode = PSqlServerAuthenticateMode.SQLServerMixedMode Then
                connectionString = "data source=" + Me.ServerName + ";initial catalog=" + Me.DatabaseName + ";password=" + Me.Password + ";user id=" + Me.UserName + ";"
            Else
                connectionString = "data source=" + Me.ServerName + ";Integrated Security=SSPI;initial catalog=" + Me.DatabaseName
            End If
            Me.Connection = New SqlConnection(connectionString)
            Me.Connection.Open()
            Me.Command = Me.Connection.CreateCommand
        End Sub

        Public Sub BeginTransaction()
            Me.Transaction = Me.Connection.BeginTransaction
        End Sub

        Public Sub BeginTransaction(ByVal TransactionName As String)
            Me.Transaction = Me.Connection.BeginTransaction(TransactionName)
        End Sub

        Public Sub CommitTransaction()
            If Not (Me.Transaction Is Nothing) Then
                Me.Transaction.Commit()
                Me.Transaction = Nothing
            End If
        End Sub

        Public Sub RoolbackTransaction()
            If Not (Me.Transaction Is Nothing) Then
                Me.Transaction.Rollback()
                Me.Transaction = Nothing
            End If
        End Sub

        Public Sub RoolbackTransaction(ByVal TransactioName As String)
            If Not (Me.Transaction Is Nothing) Then
                Me.Transaction.Rollback(TransactioName)
                Me.Transaction = Nothing
            End If
        End Sub

        Public Function ExecuteNoneQuery(ByVal SQL As String) As Integer
            If Not (Me.Command Is Nothing) Then
                Me.Command.Transaction = Me.Transaction
                Me.Command.CommandText = SQL
                Return Me.Command.ExecuteNonQuery
            Else
                Throw New Exception("Please open the connection first.")
            End If
        End Function

        Public Function ExecuteScalar(ByVal SQL As String) As Object
            If Not (Me.Command Is Nothing) Then
                Me.Command.Transaction = Me.Transaction
                Me.Command.CommandText = SQL
                Return Me.Command.ExecuteScalar
            Else
                Throw New Exception("Please open the connection first.")
            End If
        End Function

        Public Function ExecuteReader(ByVal SQL As String) As Object
            If Not (Me.Command Is Nothing) Then
                Me.Command.Transaction = Me.Transaction
                Me.Command.CommandText = SQL
                Return Me.Command.ExecuteReader
            Else
                Throw New Exception("Please open the connection first.")
            End If
        End Function

        Public Function ExecuteXmlReader(ByVal SQL As String) As System.Xml.XmlReader
            If Not (Me.Command Is Nothing) Then
                Me.Command.Transaction = Me.Transaction
                Me.Command.CommandText = SQL
                Return Me.Command.ExecuteXmlReader
            Else
                Throw New Exception("Please open the connection first.")
            End If
        End Function

        Public Sub Close()
            If Not (Me.Connection Is Nothing) Then
                Me.Connection.Close()
                Me.Connection = Nothing
                Me.Transaction = Nothing
                Me.Command = Nothing
            End If
        End Sub

        Public Function GetDataSet(ByVal SQL As String) As DataSet
            Return Me.GetDataSet(SQL, "table_" + DateTime.Now.Ticks.ToString)
        End Function

        Public Function GetDataSet(ByVal SQL As String, ByVal AlishTableName As String) As DataSet
            If Not (Me.Connection Is Nothing) Then
                Dim da As SqlDataAdapter = New SqlDataAdapter(SQL, Me.Connection)
                Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)
                da.SelectCommand.Transaction = Me.Transaction
                Dim ds As DataSet = New DataSet
                da.Fill(ds, AlishTableName)
                Return ds
            Else
                Throw New Exception("Please open the connection first.")
            End If
        End Function

        Public Sub FillDataSet(ByVal SQL As String, ByVal ds As DataSet, ByVal AlishTableName As String)
            If Not (Me.Connection Is Nothing) Then
                Dim da As SqlDataAdapter = New SqlDataAdapter(SQL, Me.Connection)
                Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)
                da.SelectCommand.Transaction = Me.Transaction
                da.Fill(ds, AlishTableName)
            Else
                Throw New Exception("Please open the connection first.")
            End If
        End Sub

        Public Sub VerifyConnection()
            If Me.Connected = False Then
                Me.Open()
            End If
        End Sub
    End Class
End Namespace

