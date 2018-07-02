<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProg
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateProgramme = New System.Windows.Forms.Button()
        Me.dgvProgramme = New System.Windows.Forms.DataGridView()
        Me.dgvModule = New System.Windows.Forms.DataGridView()
        Me.dgvCourse = New System.Windows.Forms.DataGridView()
        Me.dgvBatch = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateModule = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateBatch = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateCourse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProgramme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvModule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdateProgramme)
        Me.GroupBox1.Controls.Add(Me.dgvProgramme)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programme Details"
        '
        'btnUpdateProgramme
        '
        Me.btnUpdateProgramme.Location = New System.Drawing.Point(483, 170)
        Me.btnUpdateProgramme.Name = "btnUpdateProgramme"
        Me.btnUpdateProgramme.Size = New System.Drawing.Size(83, 29)
        Me.btnUpdateProgramme.TabIndex = 3
        Me.btnUpdateProgramme.Text = "Update"
        Me.btnUpdateProgramme.UseVisualStyleBackColor = True
        '
        'dgvProgramme
        '
        Me.dgvProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramme.Location = New System.Drawing.Point(6, 24)
        Me.dgvProgramme.MultiSelect = False
        Me.dgvProgramme.Name = "dgvProgramme"
        Me.dgvProgramme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProgramme.Size = New System.Drawing.Size(639, 143)
        Me.dgvProgramme.TabIndex = 3
        '
        'dgvModule
        '
        Me.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModule.Location = New System.Drawing.Point(6, 25)
        Me.dgvModule.MultiSelect = False
        Me.dgvModule.Name = "dgvModule"
        Me.dgvModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvModule.Size = New System.Drawing.Size(639, 198)
        Me.dgvModule.TabIndex = 1
        '
        'dgvCourse
        '
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourse.Location = New System.Drawing.Point(6, 22)
        Me.dgvCourse.MultiSelect = False
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.Size = New System.Drawing.Size(575, 636)
        Me.dgvCourse.TabIndex = 4
        '
        'dgvBatch
        '
        Me.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBatch.Location = New System.Drawing.Point(14, 24)
        Me.dgvBatch.MultiSelect = False
        Me.dgvBatch.Name = "dgvBatch"
        Me.dgvBatch.Size = New System.Drawing.Size(634, 173)
        Me.dgvBatch.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUpdateModule)
        Me.GroupBox2.Controls.Add(Me.dgvModule)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 263)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Modules"
        '
        'btnUpdateModule
        '
        Me.btnUpdateModule.Location = New System.Drawing.Point(480, 230)
        Me.btnUpdateModule.Name = "btnUpdateModule"
        Me.btnUpdateModule.Size = New System.Drawing.Size(83, 29)
        Me.btnUpdateModule.TabIndex = 2
        Me.btnUpdateModule.Text = "Update"
        Me.btnUpdateModule.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnUpdateBatch)
        Me.GroupBox3.Controls.Add(Me.dgvBatch)
        Me.GroupBox3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 473)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 239)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Batch"
        '
        'btnUpdateBatch
        '
        Me.btnUpdateBatch.Location = New System.Drawing.Point(480, 201)
        Me.btnUpdateBatch.Name = "btnUpdateBatch"
        Me.btnUpdateBatch.Size = New System.Drawing.Size(83, 29)
        Me.btnUpdateBatch.TabIndex = 3
        Me.btnUpdateBatch.Text = "Update"
        Me.btnUpdateBatch.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnUpdateCourse)
        Me.GroupBox4.Controls.Add(Me.dgvCourse)
        Me.GroupBox4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(676, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(575, 700)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Course Content"
        '
        'btnUpdateCourse
        '
        Me.btnUpdateCourse.Location = New System.Drawing.Point(431, 662)
        Me.btnUpdateCourse.Name = "btnUpdateCourse"
        Me.btnUpdateCourse.Size = New System.Drawing.Size(83, 29)
        Me.btnUpdateCourse.TabIndex = 6
        Me.btnUpdateCourse.Text = "Update"
        Me.btnUpdateCourse.UseVisualStyleBackColor = True
        '
        'NewProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 741)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewProg"
        Me.Text = "NewProg"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProgramme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvModule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvModule As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCourse As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBatch As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProgramme As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateModule As System.Windows.Forms.Button
    Friend WithEvents btnUpdateProgramme As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBatch As System.Windows.Forms.Button
    Friend WithEvents btnUpdateCourse As System.Windows.Forms.Button
End Class
