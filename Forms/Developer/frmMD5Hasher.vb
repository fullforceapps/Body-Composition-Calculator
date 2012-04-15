Public Class frmMD5Hasher
    Inherits System.Windows.Forms.Form

#Region " Code generated by the Windows form designer "

    Public Sub New()
        MyBase.New()

        'This call is necessary for the Windows form designer.
        InitializeComponent()

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is necessary for the Windows form designer
    ' It can be modified with the Windows form designer.
    ' Do not use the code editor to edit.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbString2Hash As System.Windows.Forms.TextBox
    Friend WithEvents pbHash As System.Windows.Forms.Button
    Friend WithEvents tbHash1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbHash2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbHash3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbHash4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbHash5 As System.Windows.Forms.TextBox
    Friend WithEvents cbHI As System.Windows.Forms.CheckBox
    Friend WithEvents cbHO As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbHNo As System.Windows.Forms.TextBox
    Friend WithEvents pbToClipBoard As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMD5Hasher))
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbString2Hash = New System.Windows.Forms.TextBox
        Me.tbHash1 = New System.Windows.Forms.TextBox
        Me.pbHash = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbHash2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbHash3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbHash4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbHash5 = New System.Windows.Forms.TextBox
        Me.cbHI = New System.Windows.Forms.CheckBox
        Me.cbHO = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbHNo = New System.Windows.Forms.TextBox
        Me.pbToClipBoard = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "String to hash:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbString2Hash
        '
        Me.tbString2Hash.Location = New System.Drawing.Point(122, 147)
        Me.tbString2Hash.Name = "tbString2Hash"
        Me.tbString2Hash.Size = New System.Drawing.Size(314, 21)
        Me.tbString2Hash.TabIndex = 1
        '
        'tbHash1
        '
        Me.tbHash1.Location = New System.Drawing.Point(122, 192)
        Me.tbHash1.Name = "tbHash1"
        Me.tbHash1.Size = New System.Drawing.Size(314, 21)
        Me.tbHash1.TabIndex = 2
        '
        'pbHash
        '
        Me.pbHash.Location = New System.Drawing.Point(204, 346)
        Me.pbHash.Name = "pbHash"
        Me.pbHash.Size = New System.Drawing.Size(56, 24)
        Me.pbHash.TabIndex = 3
        Me.pbHash.Text = "Hash"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hash 1:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hash 2:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbHash2
        '
        Me.tbHash2.Location = New System.Drawing.Point(122, 222)
        Me.tbHash2.Name = "tbHash2"
        Me.tbHash2.Size = New System.Drawing.Size(314, 21)
        Me.tbHash2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hash 3:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbHash3
        '
        Me.tbHash3.Location = New System.Drawing.Point(122, 252)
        Me.tbHash3.Name = "tbHash3"
        Me.tbHash3.Size = New System.Drawing.Size(314, 21)
        Me.tbHash3.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(22, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hash 4:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbHash4
        '
        Me.tbHash4.Location = New System.Drawing.Point(122, 282)
        Me.tbHash4.Name = "tbHash4"
        Me.tbHash4.Size = New System.Drawing.Size(314, 21)
        Me.tbHash4.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(22, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Hash 5:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbHash5
        '
        Me.tbHash5.Location = New System.Drawing.Point(122, 312)
        Me.tbHash5.Name = "tbHash5"
        Me.tbHash5.Size = New System.Drawing.Size(314, 21)
        Me.tbHash5.TabIndex = 11
        '
        'cbHI
        '
        Me.cbHI.Location = New System.Drawing.Point(30, 348)
        Me.cbHI.Name = "cbHI"
        Me.cbHI.Size = New System.Drawing.Size(76, 24)
        Me.cbHI.TabIndex = 13
        Me.cbHI.Text = "Hide input"
        '
        'cbHO
        '
        Me.cbHO.Location = New System.Drawing.Point(112, 347)
        Me.cbHO.Name = "cbHO"
        Me.cbHO.Size = New System.Drawing.Size(86, 24)
        Me.cbHO.TabIndex = 14
        Me.cbHO.Text = "Hide output"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(293, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Copy Hash"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbHNo
        '
        Me.tbHNo.Location = New System.Drawing.Point(361, 349)
        Me.tbHNo.Name = "tbHNo"
        Me.tbHNo.Size = New System.Drawing.Size(18, 21)
        Me.tbHNo.TabIndex = 16
        Me.tbHNo.Text = "5"
        '
        'pbToClipBoard
        '
        Me.pbToClipBoard.Location = New System.Drawing.Point(385, 346)
        Me.pbToClipBoard.Name = "pbToClipBoard"
        Me.pbToClipBoard.Size = New System.Drawing.Size(84, 24)
        Me.pbToClipBoard.TabIndex = 17
        Me.pbToClipBoard.Text = "To Clipboard"
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(124, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "MD5 Hash Generator"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(485, 91)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'frmMD5Hasher
        '
        Me.AcceptButton = Me.pbToClipBoard
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(501, 387)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pbToClipBoard)
        Me.Controls.Add(Me.tbHNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbHO)
        Me.Controls.Add(Me.cbHI)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbHash5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbHash4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbHash3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbHash2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbHash)
        Me.Controls.Add(Me.tbHash1)
        Me.Controls.Add(Me.tbString2Hash)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMD5Hasher"
        Me.Text = "FullForce Development MD5 Hash Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim sText As String, nCounter As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetControls(cbHO.Checked)
        sText = ""
        nCounter = 0
        Timer1.Enabled = True
    End Sub

    Private Sub tbString2Hash_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbString2Hash.TextChanged
        Timer2.Enabled = False
        tbHash1.Text = ""
        tbHash2.Text = ""
        tbHash3.Text = ""
        tbHash4.Text = ""
        tbHash5.Text = ""
        nCounter = 0
        Timer2.Enabled = True
    End Sub

    Private Function HashString(ByVal S As String) As String
        Dim r As String
        r = ""
        Try
            If S <> "" Then
                r = ComputeMD5HashForString(S)
            End If
        Catch
            r = ""
        End Try
        Return r
    End Function

    Private Sub pbHash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbHash.Click
        tbHash1.Text = HashString(tbString2Hash.Text)
        tbHash2.Text = HashString(tbHash1.Text)
        tbHash3.Text = HashString(tbHash2.Text)
        tbHash4.Text = HashString(tbHash3.Text)
        tbHash5.Text = HashString(tbHash4.Text)
    End Sub


    Private Sub cbHI_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHI.CheckedChanged
        SetControls(cbHO.Checked)
    End Sub

    Private Sub cbHO_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHO.CheckedChanged
        SetControls(cbHO.Checked)
    End Sub

    Private Sub SetPWChar(ByVal Ctrl As Control, ByVal sPWChar As String, ByVal bSet As Boolean)
        Try
            If bSet Then
                CType(Ctrl, TextBox).PasswordChar = sPWChar
            Else
                CType(Ctrl, TextBox).PasswordChar = ""
            End If
        Catch
        End Try
    End Sub

    Private Sub SetControls(ByVal bChecked As Boolean)
        SetPWChar(tbString2Hash, "*", cbHI.Checked)
        SetPWChar(tbHash1, "*", bChecked)
        SetPWChar(tbHash2, "*", bChecked)
        SetPWChar(tbHash3, "*", bChecked)
        SetPWChar(tbHash4, "*", bChecked)
        SetPWChar(tbHash5, "*", bChecked)
    End Sub

    Private Function ComputeMD5HashForString(ByVal String2Hash As String) As String
        Try
            Dim MD5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()

            Dim oEncoder As New System.Text.ASCIIEncoding()
            Dim bytes As Byte() = oEncoder.GetBytes(String2Hash)

            Dim myHash As Byte() = MD5Hasher.ComputeHash(bytes)
            Dim myCapacity As Integer = (myHash.Length * 2 + (myHash.Length / 8))
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(myCapacity)
            Dim I As Integer
            For I = 0 To myHash.Length - 1
                sb.Append(BitConverter.ToString(myHash, I, 1))
            Next I
            Return sb.ToString().TrimEnd(New Char() {" "c})
        Catch ex As Exception
            Return "0"
        End Try
    End Function


    Private Sub pbToClipBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbToClipBoard.Click
        If tbString2Hash.Text = "" Then
            Clipboard.SetDataObject("")
            Exit Sub
        End If

        If tbHash1.Text = "" Then
            pbHash_Click(sender, e)
        End If

        Select Case tbHNo.Text
            Case "1"
                sText = tbHash1.Text
            Case "2"
                sText = tbHash2.Text
            Case "3"
                sText = tbHash3.Text
            Case "4"
                sText = tbHash4.Text
            Case "5"
                sText = tbHash5.Text
            Case Else
                tbHNo.Text = "5"
                sText = tbHash5.Text
        End Select
        Clipboard.SetDataObject(sText)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If sText <> "" AndAlso Clipboard.GetDataObject.GetData(System.Windows.Forms.DataFormats.Text, True) = sText Then
            Clipboard.SetDataObject("")
        End If
        nCounter += 1
        If nCounter > 5 Then
            tbString2Hash.Text = ""
            sText = ""
            nCounter = 0
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        pbToClipBoard_Click(sender, e)
        Timer2.Enabled = False
    End Sub

End Class
