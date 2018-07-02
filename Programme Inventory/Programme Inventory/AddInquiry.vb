
Public Class AddInquiry
    Dim nowRow, nowInquiryIdSelected As Integer
    Private MySql As New MySqlClass
    Private EmailCtrlClass As New EmailCtrl

    Private Sub AddInquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtCollege.Text = ""
        txtAddress.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtEmailID.Text = ""
        txtComments.Text = ""
    End Sub
    Private Sub LoadDataGrid()
        MySql.ExecQuery("SELECT idInquiry, Name, College, Address, Phone_1, Phone_2, Email_ID, Inquiry_Date, Attended_By FROM Inquiry ORDER BY idInquiry DESC", "")
        dgvInquiry.DataSource = MySql.DataSet.Tables(0)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or
           txtCollege.Text = "" Or
           txtAddress.Text = "" Or
           txtPhone1.Text = "" Or
           txtEmailID.Text = "" Or
           txtComments.Text = "" Then

            MsgBox("Can't accept Null values")
        Else

            MySql.Params.Clear()
            MySql.AddParam("@name", txtName.Text, ParameterDirection.Input)
            MySql.AddParam("@college", txtCollege.Text, ParameterDirection.Input)
            MySql.AddParam("@address", txtAddress.Text, ParameterDirection.Input)
            MySql.AddParam("@phone1", txtPhone1.Text, ParameterDirection.Input)
            MySql.AddParam("@phone2", txtPhone2.Text, ParameterDirection.Input)
            MySql.AddParam("@email_id", txtEmailID.Text, ParameterDirection.Input)
            MySql.AddParam("@comments", txtComments.Text, ParameterDirection.Input)
            MySql.AddParam("@attend_by", Form1.FactoryToolStripMenuItem.Text, ParameterDirection.Input)

            MySql.ExecNonQuery("INSERT INTO Inquiry(Name, College, Address, Phone_1, Phone_2, Email_ID, Inquired_About, Inquiry_Date, Attended_By, Is_Acknowledged) values(@name, @college, @address, @phone1, @phone2, @email_id, @comments, now(), @attend_by, 0)", "Text")
            
            Dim fso, objfso, filetxt
            fso = CreateObject("Scripting.FileSystemObject")
            objfso = fso.OpenTextFile("F:\projects\Programme_inventory3\images and other files\new 4.html", 1, False)
            filetxt = objfso.readall
            filetxt = Replace(filetxt, "<%name%>", txtName.Text)
            filetxt = Replace(filetxt, "<%college%>", txtCollege.Text)
            filetxt = Replace(filetxt, "<%address%>", txtAddress.Text)
            filetxt = Replace(filetxt, "<%comments%>", txtComments.Text)
            filetxt = Replace(filetxt, "<%inquired on%>", Now)
            filetxt = Replace(filetxt, "<%attended by%>", Form1.FactoryToolStripMenuItem.Text)
            filetxt = Replace(filetxt, "<%email sent on%>", Now)

            LoadDataGrid()

            'Try
            '     message.Body = "this is a sample body with html in it. <b>This is bold</b> <font color=#336699>This is blue</font>"
            '  message.Body = "<table border=" & Chr(34) & "2" & Chr(34) & "><tr><td>Row 1, Column 1</td><td>Row 1, Column 2</td></tr><tr><td>Row 2, Column 1</td><td>Row 2, Column 2</td></tr></table>"
            '     message.Body = "<title>HTML Tables</title>"
            ' message.Body = "<html><head><title>HTML Tables</title></head></html>"
            'message.Body = "<b>This is heading 2</b><b>This is heading 1</b>"



            EmailCtrlClass.SendEmail("Inquiry Info", filetxt, True)

        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtName.Text = "" Or
           txtCollege.Text = "" Or
           txtAddress.Text = "" Or
           txtPhone1.Text = "" Or
           txtEmailID.Text = "" Or
           txtComments.Text = "" Then

            MsgBox("Can't accept Null values")
        Else

            MySql.Params.Clear()
            MySql.AddParam("@name", txtName.Text, ParameterDirection.Input)
            MySql.AddParam("@college", txtCollege.Text, ParameterDirection.Input)
            MySql.AddParam("@address", txtAddress.Text, ParameterDirection.Input)
            MySql.AddParam("@phone1", txtPhone1.Text, ParameterDirection.Input)
            MySql.AddParam("@phone2", txtPhone2.Text, ParameterDirection.Input)
            MySql.AddParam("@email_id", txtEmailID.Text, ParameterDirection.Input)
            MySql.AddParam("@comments", txtComments.Text, ParameterDirection.Input)
            MySql.AddParam("@attend_by", Form1.FactoryToolStripMenuItem.Text, ParameterDirection.Input)
            MySql.AddParam("@inquiry_id", nowInquiryIdSelected.ToString, ParameterDirection.Input)

            MySql.ExecNonQuery("UPDATE Inquiry SET Name=@name, College=@college, Address=@address, Phone_1=@phone1, Phone_2=@phone2, Email_ID=@email_id, Inquired_About=@comments, Modified_Date=now(), Modified_By=@attend_by, Is_Acknowledged=0 WHERE idInquiry=@inquiry_id", "Text")
            LoadDataGrid()
        End If
    End Sub

    Private Sub dgvInquiry_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvInquiry.SelectionChanged
        nowRow = dgvInquiry.CurrentRow.Index
        nowInquiryIdSelected = dgvInquiry.Rows(nowRow).Cells(0).Value

        txtName.Text = MySql.ExecQuery("SELECT Name FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "Name")
        txtCollege.Text = MySql.ExecQuery("SELECT College FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "College")
        txtAddress.Text = MySql.ExecQuery("SELECT Address FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "Address")
        txtPhone1.Text = MySql.ExecQuery("SELECT Phone_1 FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "Phone_1")
        txtPhone2.Text = MySql.ExecQuery("SELECT Phone_2 FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "Phone_2")
        txtEmailID.Text = MySql.ExecQuery("SELECT Email_ID FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "Email_ID")
        txtComments.Text = MySql.ExecQuery("SELECT Inquired_About FROM Inquiry WHERE idInquiry = " & nowInquiryIdSelected.ToString, "Inquired_About")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        MySql.Params.Clear()
        MySql.AddParam("@inquiry_id", nowInquiryIdSelected.ToString, ParameterDirection.Input)
        MySql.ExecNonQuery("DELETE FROM Inquiry WHERE idInquiry = @inquiry_id", "Text")

        LoadDataGrid()
    End Sub

    Private Sub dgvInquiry_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInquiry.CellContentClick

    End Sub
End Class