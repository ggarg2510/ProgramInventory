
Public Class Form1
    Private MySql As New MySqlClass
    Private EmailCtrlClass As New EmailCtrl

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 

        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Top = Screen.PrimaryScreen.WorkingArea.Top

        ' EmailCtrlClass.ConfigMail()
        StartUpLogin.Show()

    End Sub

    Private Sub CreateUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        users.Show()
    End Sub

    Private Sub CreateNewProgrammeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewProgrammeToolStripMenuItem.Click
        NewProg.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutToolStripMenuItem.Click
        FactoryToolStripMenuItem.Text = "Login"

        CreateNewProgrammeToolStripMenuItem.Enabled = False
        UsersToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False
        SignOutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub NewInquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewInquiryToolStripMenuItem.Click
        AddInquiry.Show()
    End Sub

    Private Sub NewEnrollmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEnrollmentToolStripMenuItem1.Click
        NewAdmission.Show()
    End Sub
End Class
