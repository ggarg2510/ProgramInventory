Imports MySql.Data.MySqlClient

Public Class NewAdmission
    Private MySql As New MySqlClass

    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySql.Params.Clear()
        Dim str As String
        str = "12345"

        MySql.AddParam("@programme_name", txtName.Text, ParameterDirection.Input)
        '        MySql.AddParam("@programme_name", "67890")
        ' MySql.ExecScalarQuery("SELECT count(*) FROM users WHERE user_name = @programme_name", "Text")

        MySql.ExecNonQuery("INSERT INTO logins(user_name,logged_on) values(@programme_name, now())", "Text")


        MySql.ExecQueryOnly("SELECT NameProgramme FROM programme")
        If MySql.RecCount > 0 Then
            For Each r As DataRow In MySql.DataSet.Tables(0).Rows
                cbProgramme.Items.Add(r("NameProgramme"))
            Next
            cbProgramme.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ' MySql.AddParam("@programme_name", Programme)

        '        Dim @Name as String

        MySql.ExecReaderQuery("INSERT INTO admission(idModule,Name,College,Address,Phone_1,Phone_2,Email_ID_1,Email_ID_2,Photo_path,Fee_Concession,Fee_Concession,Other_Charges) VALUES(@idModule,@Name,@College,@Address,@Phone_1,@Phone_2,@Email_ID_1,@Email_ID_2,@Photo_path,@Fee_Concession,@Fee_Concession,@Other_Charges)", "Text")
        'WORKOUT ON ADDING PARAMETERS AND CHANGE THE WHOLE PROJECT ACCORDINGLY
    End Sub

    Private Sub cbProgramme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProgramme.SelectedIndexChanged
        Dim i As Integer

        'MySql.AddParam("@programme_name", Programme)

        i = MySql.ExecQuery("SELECT idProgramme FROM programme WHERE NameProgramme='" & cbProgramme.Text & "'", "idProgramme")
        MySql.ExecQueryOnly("SELECT NameModule FROM module WHERE idProgramme=" & i.ToString() & " ORDER BY idModule ASC")
        If MySql.RecCount > 0 Then
            cbModule.Items.Clear()
            For Each r As DataRow In MySql.DataSet.Tables(0).Rows
                cbModule.Items.Add(r("NameModule"))
            Next
            cbModule.SelectedIndex = 0
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class