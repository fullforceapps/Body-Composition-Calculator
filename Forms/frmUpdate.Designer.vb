<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statuslabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.updatestatuslabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnsecondary = New System.Windows.Forms.LinkLabel
        Me.btnmain = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CurVerNumLbl = New System.Windows.Forms.Label
        Me.CurAppNameLbl = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UpdEULAUpdLbl = New System.Windows.Forms.LinkLabel
        Me.UpdNUpdDescLbl = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.UpdVerNumLbl = New System.Windows.Forms.Label
        Me.UpdAppNameLbl = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.AdminPrivBTN = New System.Windows.Forms.LinkLabel
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowMerge = False
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabel, Me.updatestatuslabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 290)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(435, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuslabel
        '
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(86, 17)
        Me.statuslabel.Text = "Ready                "
        '
        'updatestatuslabel
        '
        Me.updatestatuslabel.Name = "updatestatuslabel"
        Me.updatestatuslabel.Size = New System.Drawing.Size(223, 17)
        Me.updatestatuslabel.Text = "                                                                        "
        '
        'btnsecondary
        '
        Me.btnsecondary.AutoSize = True
        Me.btnsecondary.Location = New System.Drawing.Point(219, 268)
        Me.btnsecondary.Name = "btnsecondary"
        Me.btnsecondary.Size = New System.Drawing.Size(96, 13)
        Me.btnsecondary.TabIndex = 5
        Me.btnsecondary.TabStop = True
        Me.btnsecondary.Text = "Install update later."
        '
        'btnmain
        '
        Me.btnmain.BackColor = System.Drawing.SystemColors.Control
        Me.btnmain.Location = New System.Drawing.Point(321, 263)
        Me.btnmain.Name = "btnmain"
        Me.btnmain.Size = New System.Drawing.Size(102, 23)
        Me.btnmain.TabIndex = 10
        Me.btnmain.Text = "PreRuntime"
        Me.btnmain.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CurVerNumLbl)
        Me.GroupBox1.Controls.Add(Me.CurAppNameLbl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Version"
        '
        'CurVerNumLbl
        '
        Me.CurVerNumLbl.AutoSize = True
        Me.CurVerNumLbl.Location = New System.Drawing.Point(114, 50)
        Me.CurVerNumLbl.Name = "CurVerNumLbl"
        Me.CurVerNumLbl.Size = New System.Drawing.Size(82, 13)
        Me.CurVerNumLbl.TabIndex = 3
        Me.CurVerNumLbl.Text = "Version Number"
        '
        'CurAppNameLbl
        '
        Me.CurAppNameLbl.AutoSize = True
        Me.CurAppNameLbl.Location = New System.Drawing.Point(114, 20)
        Me.CurAppNameLbl.Name = "CurAppNameLbl"
        Me.CurAppNameLbl.Size = New System.Drawing.Size(54, 13)
        Me.CurAppNameLbl.TabIndex = 2
        Me.CurAppNameLbl.Text = "AppName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Installed Version: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AdminPrivBTN)
        Me.GroupBox2.Controls.Add(Me.UpdEULAUpdLbl)
        Me.GroupBox2.Controls.Add(Me.UpdNUpdDescLbl)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.UpdVerNumLbl)
        Me.GroupBox2.Controls.Add(Me.UpdAppNameLbl)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 161)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Latest Version"
        '
        'UpdEULAUpdLbl
        '
        Me.UpdEULAUpdLbl.AutoSize = True
        Me.UpdEULAUpdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdEULAUpdLbl.LinkColor = System.Drawing.Color.Red
        Me.UpdEULAUpdLbl.Location = New System.Drawing.Point(6, 114)
        Me.UpdEULAUpdLbl.Name = "UpdEULAUpdLbl"
        Me.UpdEULAUpdLbl.Size = New System.Drawing.Size(238, 26)
        Me.UpdEULAUpdLbl.TabIndex = 1
        Me.UpdEULAUpdLbl.TabStop = True
        Me.UpdEULAUpdLbl.Text = "The programs license has been updated." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please take some time and review it."
        '
        'UpdNUpdDescLbl
        '
        Me.UpdNUpdDescLbl.Location = New System.Drawing.Point(114, 76)
        Me.UpdNUpdDescLbl.Name = "UpdNUpdDescLbl"
        Me.UpdNUpdDescLbl.Size = New System.Drawing.Size(291, 38)
        Me.UpdNUpdDescLbl.TabIndex = 7
        Me.UpdNUpdDescLbl.Text = "Description of Update"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Update Description:"
        '
        'UpdVerNumLbl
        '
        Me.UpdVerNumLbl.AutoSize = True
        Me.UpdVerNumLbl.Location = New System.Drawing.Point(114, 49)
        Me.UpdVerNumLbl.Name = "UpdVerNumLbl"
        Me.UpdVerNumLbl.Size = New System.Drawing.Size(82, 13)
        Me.UpdVerNumLbl.TabIndex = 5
        Me.UpdVerNumLbl.Text = "Version Number"
        '
        'UpdAppNameLbl
        '
        Me.UpdAppNameLbl.AutoSize = True
        Me.UpdAppNameLbl.Location = New System.Drawing.Point(114, 22)
        Me.UpdAppNameLbl.Name = "UpdAppNameLbl"
        Me.UpdAppNameLbl.Size = New System.Drawing.Size(54, 13)
        Me.UpdAppNameLbl.TabIndex = 4
        Me.UpdAppNameLbl.Text = "AppName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Latest Version: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Program: "
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'AdminPrivBTN
        '
        Me.AdminPrivBTN.AutoSize = True
        Me.AdminPrivBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPrivBTN.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AdminPrivBTN.Location = New System.Drawing.Point(6, 143)
        Me.AdminPrivBTN.Name = "AdminPrivBTN"
        Me.AdminPrivBTN.Size = New System.Drawing.Size(271, 13)
        Me.AdminPrivBTN.TabIndex = 8
        Me.AdminPrivBTN.TabStop = True
        Me.AdminPrivBTN.Text = "This update requires administrative privelages."
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 312)
        Me.Controls.Add(Me.btnsecondary)
        Me.Controls.Add(Me.btnmain)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Body Composition Calculator - FullForce Update"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents updatestatuslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnmain As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CurVerNumLbl As System.Windows.Forms.Label
    Friend WithEvents CurAppNameLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UpdAppNameLbl As System.Windows.Forms.Label
    Friend WithEvents UpdVerNumLbl As System.Windows.Forms.Label
    Friend WithEvents btnsecondary As System.Windows.Forms.LinkLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents UpdNUpdDescLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents UpdEULAUpdLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents AdminPrivBTN As System.Windows.Forms.LinkLabel

End Class
