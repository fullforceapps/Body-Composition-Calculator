Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.Printing

Public Class frmResults


    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Closes this specific window.
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.FileName = "" + ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog1.Filter = "Body Composition Profile Files (*.bcp)|*.bcp|All Files (*.*)|*.*"
        'Display dialog
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'If OKed, Open the .txt file and dipslay it in the tempresults window in the DemoOputputBox.
            OutputBox.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

        'Use name in NameBox as suggestion for filename.
        SaveFileDialog1.FileName = frmMain.NameBox.Text + ""
        'Sets the initial directory that the dialog will point to.
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'Sets the file types that will be shown.
        SaveFileDialog1.Filter = "Body Composition Profile Files (*.bcp)|*.bcp|Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*"
        'Display dialog
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'If OKed, save text in DemoOutputBox to path specified by SaveFileDialog1.FileName
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, OutputBox.Text, False)
        End If
    End Sub

    Friend WithEvents printdocument1 As New System.Drawing.Printing.PrintDocument
    Dim TheStringToPrint As String

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripButton.Click
        Try
            PrintPreviewDialog1.Document = printdocument1
            PrintPreviewDialog1.ShowDialog()
        Catch exp As Exception
            MsgBox("Error: There are currently no printers installed.")
        End Try
    End Sub
    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Try
            Dim PrintDialog1 As New PrintDialog()
            PrintDialog1.Document = printdocument1
            Dim dr As DialogResult
            dr = PrintDialog1.ShowDialog()
            If dr = System.Windows.Forms.DialogResult.OK Then
                printdocument1.Print()
            End If
        Catch exp As Exception
            MsgBox("Error: " + Err.Description + Environment.NewLine + "Error Number: " + Err.Number.ToString)
        End Try
    End Sub
    Private Sub printdocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printdocument1.PrintPage
        Static intCurrentChar As Int32
        Dim font As New Font("Segoe UI", 10)
        Dim intPrintAreaHeight, intPrintAreaWidth, marginLeft, marginTop As Int32
        With printdocument1.DefaultPageSettings
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
            marginLeft = .Margins.Left
            marginTop = .Margins.Top
        End With
        If printdocument1.DefaultPageSettings.Landscape Then
            Dim intTemp As Int32
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / font.Height)
        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight)
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Mid(OutputBox.Text, intCurrentChar + 1), font, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, _
                    intCharsFitted, intLinesFilled)
        e.Graphics.DrawString(Mid(OutputBox.Text, intCurrentChar + 1, intCharsFitted), font, _
            Brushes.Black, rectPrintingArea, fmt)
        intCurrentChar += intCharsFitted
        If intCurrentChar < OutputBox.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            intCurrentChar = 0
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        Me.OutputBox.SelectionStart = 0
        Me.OutputBox.SelectionLength = 4000
        Me.OutputBox.Copy()
    End Sub
End Class