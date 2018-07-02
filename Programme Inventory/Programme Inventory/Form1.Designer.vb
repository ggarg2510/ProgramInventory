<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Programme")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modules", New System.Windows.Forms.TreeNode() {TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FactoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewProgrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultProgrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewInquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEnrollmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Size = New System.Drawing.Size(1100, 529)
        Me.SplitContainer1.SplitterDistance = 324
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.HotTracking = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 65)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "nodeProgramme"
        TreeNode1.Text = "Programme"
        TreeNode2.Name = "Node3"
        TreeNode2.Text = "Node3"
        TreeNode3.Name = "nodeModules"
        TreeNode3.Text = "Modules"
        TreeNode4.Name = "Node2"
        TreeNode4.Text = "Node2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode3, TreeNode4})
        Me.TreeView1.Size = New System.Drawing.Size(250, 400)
        Me.TreeView1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 507)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(324, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FactoryToolStripMenuItem, Me.DefaultProgrammeToolStripMenuItem, Me.StudentToolStripMenuItem, Me.NewEnrollmentToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(473, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FactoryToolStripMenuItem
        '
        Me.FactoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.SignOutToolStripMenuItem, Me.UsersToolStripMenuItem, Me.CreateNewProgrammeToolStripMenuItem})
        Me.FactoryToolStripMenuItem.Name = "FactoryToolStripMenuItem"
        Me.FactoryToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.FactoryToolStripMenuItem.Text = "Login"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'CreateNewProgrammeToolStripMenuItem
        '
        Me.CreateNewProgrammeToolStripMenuItem.Name = "CreateNewProgrammeToolStripMenuItem"
        Me.CreateNewProgrammeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CreateNewProgrammeToolStripMenuItem.Text = "Create New Programme"
        '
        'DefaultProgrammeToolStripMenuItem
        '
        Me.DefaultProgrammeToolStripMenuItem.Name = "DefaultProgrammeToolStripMenuItem"
        Me.DefaultProgrammeToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.DefaultProgrammeToolStripMenuItem.Text = "Default Programme"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewInquiryToolStripMenuItem, Me.NewEnrollmentToolStripMenuItem1})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "Student"
        Me.StudentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'NewInquiryToolStripMenuItem
        '
        Me.NewInquiryToolStripMenuItem.Name = "NewInquiryToolStripMenuItem"
        Me.NewInquiryToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NewInquiryToolStripMenuItem.Text = "New Inquiry"
        '
        'NewEnrollmentToolStripMenuItem1
        '
        Me.NewEnrollmentToolStripMenuItem1.Name = "NewEnrollmentToolStripMenuItem1"
        Me.NewEnrollmentToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.NewEnrollmentToolStripMenuItem1.Text = "New Enrollment"
        '
        'NewEnrollmentToolStripMenuItem
        '
        Me.NewEnrollmentToolStripMenuItem.Name = "NewEnrollmentToolStripMenuItem"
        Me.NewEnrollmentToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.NewEnrollmentToolStripMenuItem.Text = "New Enrollment"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(324, 529)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 253
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 529)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HomeScreen"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FactoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewProgrammeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents DefaultProgrammeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents NewEnrollmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewInquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewEnrollmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
