
Imports MySql.Data.MySqlClient

Public Class NewProg
    Private MySql As New MySqlClass
    Dim SelectedModule As Integer
    Private skip_dgvModule_RowEnter As Integer

    Public DataSetProgramme, DataSetModule, DataSetBatch, DataSetCourse As DataSet
    Public DataAdapProgramme, DataAdapModule, DataAdapBatch, DataAdapCourse As MySqlDataAdapter


    Private Sub NewProg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Settings.defProgramme = 5
        My.Settings.Save()

        skip_dgvModule_RowEnter = 0
        MySql.ExecQueryNew("SELECT * FROM Programme", "", DataSetProgramme, DataAdapProgramme)
        dgvProgramme.DataSource = DataSetProgramme.Tables(0)
        dgvProgramme.Rows(4).Selected = True


        MySql.ExecQueryNew("SELECT * FROM module WHERE idProgramme=" & My.Settings.defProgramme.ToString, "", DataSetModule, DataAdapModule)
        dgvModule.DataSource = DataSetModule.Tables(0)
        dgvModule.Rows(1).Selected = True
        SelectedModule = dgvModule.CurrentRow.Cells(0).Value
        DataAdapModule.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(DataAdapModule).GetUpdateCommand

        'SelectedModule = dgvModule.SelectedRows(0).Cells(0).Value

        'MySql.DataAdap.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(MySql.DataAdap).GetUpdateCommand


        MySql.ExecQueryNew("SELECT * FROM batch WHERE idModule=" & SelectedModule.ToString, "", DataSetBatch, DataAdapBatch)
        dgvBatch.DataSource = DataSetBatch.Tables(0)

        MySql.ExecQueryNew("SELECT * FROM course WHERE idModule=" & SelectedModule.ToString, "", DataSetCourse, DataAdapCourse)
        dgvCourse.DataSource = DataSetCourse.Tables(0)


        ' Beep()
        dgvModule.Columns(1).ReadOnly = True


        '   MySql.DataAdap.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(MySql.DataAdap).GetUpdateCommand

        dgvModule.Rows(1).Selected = True
        SelectedModule = dgvModule.CurrentRow.Cells(0).Value

        dgvModule.Columns(0).Width = 50
        dgvModule.Columns(1).Width = 50
        dgvModule.Columns(2).Width = 150
        dgvModule.Columns(3).Width = 150

        dgvBatch.Columns(0).Width = 50
        dgvBatch.Columns(1).Width = 50
        dgvBatch.Columns(2).Width = 120

        dgvCourse.Columns(0).Width = 50
        dgvCourse.Columns(1).Width = 50
        dgvCourse.Columns(2).Width = 400
        dgvCourse.Columns(3).Width = 400



        'dgvModule.Columns(3).Visible = False
        'dgvModule.Columns(3).Frozen = True


        If MySql.RecCount = 5 Then
            Beep()
            MySql.DataAdap.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(MySql.DataAdap).GetUpdateCommand

        End If

        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Top = Screen.PrimaryScreen.WorkingArea.Top

        'btnUpdtProgramme.Enabled = False
        'btnUpdtModule.Enabled = False
        'btnUpdtBatch.Enabled = False
        'btnUpdtCourse.Enabled = False


        skip_dgvModule_RowEnter = 1


        'TODO: This line of code loads data into the 'Programme_inventoryDataSet2._module' table. You can move, or remove it, as needed.
        'Me.ModuleTableAdapter.Fill(Me.Programme_inventoryDataSet2._module)
        '      dbconn = New MySqlConnection("Data Source =localhost;user id=root;password=pswd@MYsql118;database=programme_inventory")
        '     dbconn.Open()
        '        Dim cnt As Integer
        '       sql = "SELECT count(*) from USERS"
        '      Try
        '         dbcomm = New MySqlCommand(sql, dbconn)
        '         cnt = dbcomm.ExecuteScalar ' .()
        '         dbread.Close()
        '     Catch ex As Exception
        ' MsgBox(ex.Message.ToString)
        ' End Try
        '       Dim column As DataGridViewColumn = DataGridViewModule.Columns[0]
        '        column.Width = 10
        '    Dim dbDataTab As New DataTable
        '   Dim dbBindSource As New BindingSource
        '  Dim dbAdap As MySqlDataAdapter
        'sql = "SELECT @count:=@count+1 AS 'count', * FROM module"

        '        sql = "SELECT NameModule,Description,Fee FROM module"
        '        sql = "SELECT idUsers, user_name, access,created_on, modified_on FROM users WHERE user_name<>'Factory'"
        '       Try
        'dbcomm.Connection = dbconn

        '    dbAdap = New MySqlDataAdapter("SET @count:=0", dbconn)
        '   dbAdap = New MySqlDataAdapter(sql, dbconn)
        '  dbDataTab = New DataTable
        ' dbAdap.Fill(dbDataTab)
        ' DataGridViewModule.DataSource = dbDataTab
        '  Catch ex As Exception
        'MsgBox(ex.Message.ToString)
        ' End Try

    End Sub


    Private Sub dgvModule_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModule.CellClick
        Dim i As Integer
        i = dgvModule.CurrentRow.Index
        dgvModule.Rows(i).Cells(1).Value = My.Settings.defProgramme
        '      btnUpdtModule.Enabled = True

        'dgvModule.Rows(i).Cells(0).Value = MySql.ExecScalerQuery("SELECT MAX(idModule)+1 FROM Module")

    End Sub

    Private Sub dgvBatch_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBatch.CellClick
        Dim i As Integer
        i = dgvBatch.CurrentRow.Index
        dgvBatch.Rows(i).Cells(1).Value = SelectedModule
    End Sub

    Private Sub dgvCourse_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCourse.CellClick
        Dim i As Integer
        i = dgvCourse.CurrentRow.Index
        dgvCourse.Rows(i).Cells(1).Value = SelectedModule

    End Sub


    Private Sub btnUpdateModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateModule.Click
        DataAdapModule.Update(DataSetModule)
        MySql.ExecQueryNew("SELECT * FROM module WHERE idProgramme=" & My.Settings.defProgramme.ToString, "", DataSetModule, DataAdapModule)
        dgvModule.DataSource = DataSetModule.Tables(0)
        DataAdapModule.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(DataAdapModule).GetUpdateCommand

    End Sub

    Private Sub btnUpdateProgramme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateProgramme.Click
        DataAdapProgramme.Update(DataSetProgramme)
        MySql.ExecQueryNew("SELECT * FROM Programme", "", DataSetProgramme, DataAdapProgramme)
        dgvProgramme.DataSource = DataSetProgramme.Tables(0)
        DataAdapProgramme.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(DataAdapProgramme).GetUpdateCommand

    End Sub

    Private Sub btnUpdateBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBatch.Click
        DataAdapBatch.Update(DataSetBatch)
        MySql.ExecQueryNew("SELECT * FROM batch WHERE idModule=" & SelectedModule.ToString, "", DataSetBatch, DataAdapBatch)
        dgvBatch.DataSource = DataSetBatch.Tables(0)
        DataAdapBatch.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(DataAdapBatch).GetUpdateCommand

    End Sub

    Private Sub btnUpdateCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCourse.Click
        DataAdapCourse.Update(DataSetCourse)
        MySql.ExecQueryNew("SELECT * FROM course WHERE idModule=" & SelectedModule.ToString, "", DataSetCourse, DataAdapCourse)
        dgvCourse.DataSource = DataSetCourse.Tables(0)
        DataAdapCourse.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(DataAdapCourse).GetUpdateCommand

    End Sub
End Class