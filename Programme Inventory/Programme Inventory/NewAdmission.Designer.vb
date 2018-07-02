<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAdmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtAdmittedOn = New System.Windows.Forms.DateTimePicker()
        Me.cbProgramme = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbModule = New System.Windows.Forms.ComboBox()
        Me.cbBatch = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmailID1 = New System.Windows.Forms.TextBox()
        Me.txtEmailID2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRemain = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFeePaid = New System.Windows.Forms.TextBox()
        Me.txtOtherAmt = New System.Windows.Forms.TextBox()
        Me.txtNetFee = New System.Windows.Forms.TextBox()
        Me.txtConcession = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCourseFee = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCollege = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ProgrammeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Programme_inventoryDataSet4 = New Programme_Inventory.programme_inventoryDataSet4()
        Me.Programme_inventoryDataSet3 = New Programme_Inventory.programme_inventoryDataSet3()
        Me.ProgrammeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgrammeTableAdapter = New Programme_Inventory.programme_inventoryDataSet3TableAdapters.programmeTableAdapter()
        Me.ProgrammeTableAdapter1 = New Programme_Inventory.programme_inventoryDataSet4TableAdapters.programmeTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgrammeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Programme_inventoryDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Programme_inventoryDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgrammeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCollege)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 608)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(564, 543)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 38)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(442, 543)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 38)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(564, 488)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 38)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(442, 488)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 38)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.dtAdmittedOn)
        Me.GroupBox4.Controls.Add(Me.cbProgramme)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.cbModule)
        Me.GroupBox4.Controls.Add(Me.cbBatch)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 171)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enrollment"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Admitted On"
        '
        'dtAdmittedOn
        '
        Me.dtAdmittedOn.Location = New System.Drawing.Point(119, 134)
        Me.dtAdmittedOn.Name = "dtAdmittedOn"
        Me.dtAdmittedOn.Size = New System.Drawing.Size(200, 26)
        Me.dtAdmittedOn.TabIndex = 3
        '
        'cbProgramme
        '
        Me.cbProgramme.FormattingEnabled = True
        Me.cbProgramme.Location = New System.Drawing.Point(119, 29)
        Me.cbProgramme.Name = "cbProgramme"
        Me.cbProgramme.Size = New System.Drawing.Size(235, 26)
        Me.cbProgramme.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Programme"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 18)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Batch"
        '
        'cbModule
        '
        Me.cbModule.FormattingEnabled = True
        Me.cbModule.Location = New System.Drawing.Point(119, 64)
        Me.cbModule.Name = "cbModule"
        Me.cbModule.Size = New System.Drawing.Size(235, 26)
        Me.cbModule.TabIndex = 1
        Me.cbModule.Text = "Select Module"
        '
        'cbBatch
        '
        Me.cbBatch.FormattingEnabled = True
        Me.cbBatch.Location = New System.Drawing.Point(119, 99)
        Me.cbBatch.Name = "cbBatch"
        Me.cbBatch.Size = New System.Drawing.Size(235, 26)
        Me.cbBatch.TabIndex = 2
        Me.cbBatch.Text = "Select Batch"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Module"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAddress)
        Me.GroupBox3.Controls.Add(Me.txtPhone2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtPhone1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtEmailID1)
        Me.GroupBox3.Controls.Add(Me.txtEmailID2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(709, 149)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(109, 31)
        Me.txtAddress.MaxLength = 80
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(557, 26)
        Me.txtAddress.TabIndex = 0
        '
        'txtPhone2
        '
        Me.txtPhone2.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2.Location = New System.Drawing.Point(109, 101)
        Me.txtPhone2.MaxLength = 15
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(135, 26)
        Me.txtPhone2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Phone 1"
        '
        'txtPhone1
        '
        Me.txtPhone1.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1.Location = New System.Drawing.Point(109, 66)
        Me.txtPhone1.MaxLength = 15
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(135, 26)
        Me.txtPhone1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Phone 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(318, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Email ID 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email ID 2"
        '
        'txtEmailID1
        '
        Me.txtEmailID1.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID1.Location = New System.Drawing.Point(432, 66)
        Me.txtEmailID1.MaxLength = 60
        Me.txtEmailID1.Name = "txtEmailID1"
        Me.txtEmailID1.Size = New System.Drawing.Size(234, 26)
        Me.txtEmailID1.TabIndex = 2
        '
        'txtEmailID2
        '
        Me.txtEmailID2.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID2.Location = New System.Drawing.Point(432, 101)
        Me.txtEmailID2.MaxLength = 60
        Me.txtEmailID2.Name = "txtEmailID2"
        Me.txtEmailID2.Size = New System.Drawing.Size(234, 26)
        Me.txtEmailID2.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Address"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRemain)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFeePaid)
        Me.GroupBox2.Controls.Add(Me.txtOtherAmt)
        Me.GroupBox2.Controls.Add(Me.txtNetFee)
        Me.GroupBox2.Controls.Add(Me.txtConcession)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCourseFee)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 460)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 133)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fee Structure"
        '
        'txtRemain
        '
        Me.txtRemain.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemain.Location = New System.Drawing.Point(312, 98)
        Me.txtRemain.MaxLength = 7
        Me.txtRemain.Name = "txtRemain"
        Me.txtRemain.Size = New System.Drawing.Size(66, 26)
        Me.txtRemain.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(225, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Fee Paid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Net Fee"
        '
        'txtFeePaid
        '
        Me.txtFeePaid.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeePaid.Location = New System.Drawing.Point(312, 64)
        Me.txtFeePaid.MaxLength = 7
        Me.txtFeePaid.Name = "txtFeePaid"
        Me.txtFeePaid.Size = New System.Drawing.Size(66, 26)
        Me.txtFeePaid.TabIndex = 4
        '
        'txtOtherAmt
        '
        Me.txtOtherAmt.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherAmt.Location = New System.Drawing.Point(125, 98)
        Me.txtOtherAmt.MaxLength = 7
        Me.txtOtherAmt.Name = "txtOtherAmt"
        Me.txtOtherAmt.Size = New System.Drawing.Size(66, 26)
        Me.txtOtherAmt.TabIndex = 2
        '
        'txtNetFee
        '
        Me.txtNetFee.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetFee.Location = New System.Drawing.Point(312, 30)
        Me.txtNetFee.MaxLength = 7
        Me.txtNetFee.Name = "txtNetFee"
        Me.txtNetFee.Size = New System.Drawing.Size(66, 26)
        Me.txtNetFee.TabIndex = 3
        '
        'txtConcession
        '
        Me.txtConcession.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcession.Location = New System.Drawing.Point(125, 64)
        Me.txtConcession.MaxLength = 7
        Me.txtConcession.Name = "txtConcession"
        Me.txtConcession.Size = New System.Drawing.Size(66, 26)
        Me.txtConcession.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 18)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Other Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Course Fee"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(225, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Remaining"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 18)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Concession"
        '
        'txtCourseFee
        '
        Me.txtCourseFee.Enabled = False
        Me.txtCourseFee.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseFee.Location = New System.Drawing.Point(125, 30)
        Me.txtCourseFee.MaxLength = 7
        Me.txtCourseFee.Name = "txtCourseFee"
        Me.txtCourseFee.Size = New System.Drawing.Size(66, 26)
        Me.txtCourseFee.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(526, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 203)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "College"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'txtCollege
        '
        Me.txtCollege.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollege.Location = New System.Drawing.Point(118, 73)
        Me.txtCollege.MaxLength = 60
        Me.txtCollege.Name = "txtCollege"
        Me.txtCollege.Size = New System.Drawing.Size(261, 26)
        Me.txtCollege.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(118, 32)
        Me.txtName.MaxLength = 45
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 26)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "12456"
        '
        'ProgrammeBindingSource1
        '
        Me.ProgrammeBindingSource1.DataMember = "programme"
        Me.ProgrammeBindingSource1.DataSource = Me.Programme_inventoryDataSet4
        '
        'Programme_inventoryDataSet4
        '
        Me.Programme_inventoryDataSet4.DataSetName = "programme_inventoryDataSet4"
        Me.Programme_inventoryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Programme_inventoryDataSet3
        '
        Me.Programme_inventoryDataSet3.DataSetName = "programme_inventoryDataSet3"
        Me.Programme_inventoryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProgrammeBindingSource
        '
        Me.ProgrammeBindingSource.DataMember = "programme"
        Me.ProgrammeBindingSource.DataSource = Me.Programme_inventoryDataSet3
        '
        'ProgrammeTableAdapter
        '
        Me.ProgrammeTableAdapter.ClearBeforeFill = True
        '
        'ProgrammeTableAdapter1
        '
        Me.ProgrammeTableAdapter1.ClearBeforeFill = True
        '
        'NewAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 634)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewAdmission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgrammeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Programme_inventoryDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Programme_inventoryDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgrammeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmailID2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmailID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCollege As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbModule As System.Windows.Forms.ComboBox
    Friend WithEvents cbProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCourseFee As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRemain As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFeePaid As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtNetFee As System.Windows.Forms.TextBox
    Friend WithEvents txtConcession As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtAdmittedOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Programme_inventoryDataSet3 As Programme_Inventory.programme_inventoryDataSet3
    Friend WithEvents ProgrammeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProgrammeTableAdapter As Programme_Inventory.programme_inventoryDataSet3TableAdapters.programmeTableAdapter
    Friend WithEvents Programme_inventoryDataSet4 As Programme_Inventory.programme_inventoryDataSet4
    Friend WithEvents ProgrammeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProgrammeTableAdapter1 As Programme_Inventory.programme_inventoryDataSet4TableAdapters.programmeTableAdapter
End Class
