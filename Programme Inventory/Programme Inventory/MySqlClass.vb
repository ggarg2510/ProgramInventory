
Imports MySql.Data.MySqlClient


Public Class argum
    Public Name As String
    Public val As String

    Public Property Value As String
        Get
            Value = val
        End Get

        Set(ByVal value1 As String)
            val = value1

        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal Name_param As String,
                   ByRef Value_param As Object)
        Name = Name_param
        Value = Value_param
    End Sub

End Class

Public Class MySqlClass

    ' Connection
    Private Conn As New MySqlConnection("Data Source=localhost;user id=root;password=pswd@MYsql118;database=programme_inventory")
    Private Cmd As New MySqlCommand

    ' MySql Data
    Public DataAdap As MySqlDataAdapter
    Public DataSet As DataSet
    Public QueryResult As MySqlDataReader

    ' Parameters
    Public Params As New List(Of MySqlParameter)
    Public Arguments As New List(Of argum)

    Public LArguments As New List(Of String)
    Public RArguments As New List(Of String)

    ' Query Stats
    Public RecCount As Integer
    Public Exception As String

    '   Text
    '   StoredProcedure
    '   TableDirect
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object, ByVal Direction As ParameterDirection)
        Dim NewParam As New MySqlParameter(Name, Value)
        NewParam.Direction = Direction
        Params.Add(NewParam)
    End Sub

    Public Sub AddArgument(ByVal Name As String, Byref Value As Object)
        'argum.Name = "1234"
        
        Dim NewParam As New argum(Name, Value)
        Arguments.Add(NewParam)
    End Sub


    Public Function ExecScalarQuery(ByVal CmdText As String, ByVal CommandType As String) As String
        ExecScalarQuery = ""
        Try
            ' Create MySql command
            Cmd = New MySqlCommand(CmdText, Conn)
            '  Cmd.CommandType = CommandType.st.Text

            'Open connetion and execute query
            Conn.Open()
            ExecScalarQuery = Cmd.ExecuteScalar.ToString()

        Catch ex As Exception
            Exception = ex.Message
        End Try

        Conn.Close()
        If Exception <> "" Then MsgBox(Exception.ToString())

    End Function

    Public Function ExecNonQuery(ByVal CmdText As String, ByVal CommandType As String) As Integer
        ExecNonQuery = 0
        Try
            ' Create MySql command
            Cmd = New MySqlCommand(CmdText, Conn)
            '    Cmd.CommandType = CommandType

            ' load parameters into sql string
            Params.ForEach(Sub(x) Cmd.Parameters.Add(x))

            'Open connetion and execute query
            Conn.Open()
            ExecNonQuery = Cmd.ExecuteNonQuery

        Catch ex As Exception
            Exception = ex.Message
        End Try

        Conn.Close()
        If Exception <> "" Then MsgBox(Exception.ToString())

    End Function

    Public Sub ExecReaderQuery(ByVal CmdText As String, ByVal CommandType As String)
        Try
            ' Create MySql command
            Cmd = New MySqlCommand(CmdText, Conn)
            '  Cmd.CommandType = CommandType

            ' load parameters into sql string
            Params.ForEach(Sub(x) Cmd.Parameters.Add(x))

            'Open connetion and execute query
            Conn.Open()
            '   ExecScalarQuery = Cmd.ExecuteScalar

            ' Execute Command
            DataSet = New DataSet
            DataAdap = New MySqlDataAdapter(Cmd)
            RecCount = DataAdap.Fill(DataSet)

            QueryResult = Cmd.ExecuteReader()
            RArguments.Clear()
            Dim i As Byte
            i = 0
            While QueryResult.Read

                '                Dim astr As String
                For i = 0 To LArguments.Count - 1
                    RArguments.Add(QueryResult(LArguments(i).ToString()))

                Next
                '  users.txtUser.Text = astr
                '                LArguments.Insert(0, astr)
                'Dim i As Byte
                'For i = 0 To Arguments.Count - 1
                '    Str = Arguments(i).Name
                '    Str = QueryResult(Arguments(i).Name).ToString()

                '    '                    Arguments(i).Val = str 'QueryResult(Arguments(i).Name).ToString()
                'Next i
            End While

        Catch ex As Exception
            Exception = ex.Message
        End Try

        Conn.Close()
        If Exception <> "" Then MsgBox(Exception.ToString())

    End Sub
    Public Function ExecQueryNew(ByVal Query As String, ByRef QueryParam As String, ByRef DataSet As DataSet, ByRef DataAdap As MySqlDataAdapter) As String
        ExecQueryNew = ""
        Try
            Conn.Open()

            ' Create MySql command
            Cmd = New MySqlCommand(Query, Conn)
            'Cmd.CommandText()
            'Cmd.CommandType()

            ' load parameters into sql string
            Params.ForEach(Sub(x) Cmd.Parameters.Add(x))

            ' Execute Command
            DataSet = New DataSet
            DataAdap = New MySqlDataAdapter(Cmd)
            RecCount = DataAdap.Fill(DataSet)

            If QueryParam <> "" Then
                QueryResult = Cmd.ExecuteReader()
                While QueryResult.Read
                    ExecQueryNew = QueryResult(QueryParam).ToString()
                End While
            End If

        Catch ex As Exception
            Exception = ex.Message
            MsgBox(ex.Message.ToString)
        End Try

        Params.Clear()
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Function


    Public Function ExecQuery(ByVal Query As String, ByRef QueryParam As String) As String
        ExecQuery = ""
        Try
            Conn.Open()

            ' Create MySql command
            Cmd = New MySqlCommand(Query, Conn)

            ' Execute Command
            DataSet = New DataSet
            DataAdap = New MySqlDataAdapter(Cmd)
            RecCount = DataAdap.Fill(DataSet)

            If QueryParam <> "" Then
                QueryResult = Cmd.ExecuteReader()
                While QueryResult.Read
                    ExecQuery = QueryResult(QueryParam).ToString()
                End While
            End If

            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Function


    'create procedure

    Public Sub ExecQueryOnly(ByVal Query As String)
        Try
            Conn.Open()

            ' Create MySql command
            Cmd = New MySqlCommand(Query, Conn)

            ' load parameters into sql string
            Params.ForEach(Sub(x) Cmd.Parameters.Add(x))

            ' Execute Command
            DataSet = New DataSet
            DataAdap = New MySqlDataAdapter(Cmd)
            RecCount = DataAdap.Fill(DataSet)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Params.Clear()
        If Conn.State = ConnectionState.Open Then    Conn.Close()
    End Sub
End Class
