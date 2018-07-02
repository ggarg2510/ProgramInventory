

Class StartUpLogin
    Private MySql As New MySqlClass
  
    Private Sub StartUpLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub StartUpLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub StartUpLogin_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Beep()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim AccessRights As String
        MySql.RecCount = 0

        MySql.Params.Clear()
        MySql.AddParam("@user_name", txtUser.Text, ParameterDirection.Input)
        MySql.AddParam("@pswd", txtPswd.Text, ParameterDirection.Input)


        'AccessRights = MySql.ExecQuery("SELECT access FROM users WHERE user_name = @user_name AND pswd = @pswd", "access")
        AccessRights = "Admin"

        MySql.RecCount = 1

        If MySql.RecCount = 1 Then

            MySql.Params.Clear()
            MySql.AddParam("@user_name", txtUser.Text, ParameterDirection.Input)
            MySql.ExecNonQuery("INSERT INTO logins(user_name,logged_on) values(@user_name, now())", "Text")

            Form1.FactoryToolStripMenuItem.Text = txtUser.Text
            If AccessRights = "Admin" Then
                Form1.CreateNewProgrammeToolStripMenuItem.Enabled = True
                Form1.UsersToolStripMenuItem.Enabled = True
            Else
                Form1.CreateNewProgrammeToolStripMenuItem.Enabled = False
                Form1.UsersToolStripMenuItem.Enabled = False
            End If
        Else
            MsgBox("User Name & Password doesn't exists ")
        End If

        Me.Hide()
    End Sub
End Class