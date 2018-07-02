
Imports MySql.Data.MySqlClient


Public Class users
    Dim nowRow, nowUserIdSelected As Integer
    Public a, b, c As String
    Private MySql As New MySqlClass

    Private Sub users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbPermission.Items.Clear()
        cbPermission.Items.Add("Default")
        cbPermission.Items.Add("Admin")
        cbPermission.Items.Add("Cordinator")

        LoadDataGrid()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUser.Text = ""
        txtPswd.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtUser.Text <> "" And txtPswd.Text <> "" Then

            MySql.Params.Clear()
            MySql.AddParam("@user_name", txtUser.Text, ParameterDirection.Input)
            MySql.AddParam("@pswd", txtPswd.Text, ParameterDirection.Input)
            MySql.AddParam("@permission", cbPermission.Text, ParameterDirection.Input)

            MySql.ExecNonQuery("INSERT INTO users(user_name, pswd, access, created_on) values(@user_name, @pswd, @permission, now())", "Text")

            LoadDataGrid()
        Else
            MsgBox("Can't accept Null values")
        End If
    End Sub

    Private Sub DataGridViewUsers_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUsers.SelectionChanged
        nowRow = dgvUsers.CurrentRow.Index
        nowUserIdSelected = dgvUsers.Rows(nowRow).Cells(0).Value

        MySql.Params.Clear()
        MySql.AddParam("@user_id", nowUserIdSelected.ToString, ParameterDirection.Input)

        ' MySql.AddParam("user_name", txtUser.Text, ParameterDirection.Output)
        ' MySql.AddParam("pswd", txtPswd.Text, ParameterDirection.Output)
        ' MySql.AddParam("access", cbPermission.Text, ParameterDirection.Output)

        '     MySql.LArguments.Clear()
        '    MySql.LArguments.Add(Me.a)

        '  a = ""
        'b = ""
        'c = ""

        'MySql.Arguments.Clear()
        'MySql.AddArgument("user_name", Me.a)
        'MySql.AddArgument("pswd", Me.b)
        'MySql.AddArgument("access", Me.c)

        'MySql.AddArgument("user_name", txtUser)
        'MySql.AddArgument("pswd", txtPswd)
        'MySql.AddArgument("access", cbPermission)

        '  Arguments.Insert(Name, Value)
        '  MySql.Arguments.Add( .Insert("user_name", txtUser.Text)
        ' MySql.Arguments.Insert("pswd", txtPswd.Text)
        'MySql.Arguments.Insert("access", cbPermission.Text)

        MySql.LArguments.Clear()
        MySql.LArguments.Add("user_name")
        MySql.LArguments.Add("pswd")
        MySql.LArguments.Add("access")
        MySql.ExecReaderQuery("SELECT user_name, pswd, access FROM users WHERE idUsers = @user_id", "Text")
        txtUser.Text = MySql.RArguments(0)
        txtPswd.Text = MySql.RArguments(1)
        cbPermission.Text = MySql.RArguments(2)

        Beep()

        '  txtUser.Text = MySql.ExecQuery("SELECT user_name FROM users WHERE idUsers = " & nowUserIdSelected.ToString, "user_name")
        '  txtPswd.Text = MySql.ExecQuery("SELECT pswd FROM users WHERE idUsers = " & nowUserIdSelected.ToString, "pswd")
        '  cbPermission.SelectedItem = MySql.ExecQuery("SELECT access FROM users WHERE idUsers = " & nowUserIdSelected.ToString, "access")
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtUser.Text <> "" And txtPswd.Text <> "" Then

            MySql.Params.Clear()
            MySql.AddParam("@user_name", txtUser.Text, ParameterDirection.Input)
            MySql.AddParam("@pswd", txtPswd.Text, ParameterDirection.Input)
            MySql.AddParam("@permission", cbPermission.Text, ParameterDirection.Input)
            MySql.AddParam("@user_id", nowUserIdSelected.ToString, ParameterDirection.Input)

            MySql.ExecNonQuery("UPDATE users SET user_name = @user_name, pswd = @pswd, access = @permission, modified_on = now() WHERE idUsers = @user_id", "Text")

            LoadDataGrid()
        Else
            MsgBox("Can't accept Null values")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        MySql.Params.Clear()
        MySql.AddParam("@user_id", nowUserIdSelected.ToString, ParameterDirection.Input)

        MySql.ExecNonQuery("DELETE FROM users WHERE idUsers = @user_id", "Text")

        LoadDataGrid()
    End Sub

    Private Sub LoadDataGrid()
        ' SHOW TABLE ON DATAGRIDVIEW without displaying 'Factory' user 
        MySql.ExecQuery("SELECT idUsers, user_name, access,created_on, modified_on FROM users WHERE user_name<>'Factory'", "")
        dgvUsers.DataSource = MySql.DataSet.Tables(0)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class