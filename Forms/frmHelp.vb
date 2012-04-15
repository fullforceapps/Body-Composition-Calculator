Public Class frmHelp

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        HelpBrowser.GoBack()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        HelpBrowser.GoForward()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        HelpBrowser.Refresh()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        HelpBrowser.Stop()
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick
        HelpBrowser.Navigate("http://support.fullforceapps.com/bcc/en/")
    End Sub

    Private Sub BCCSupportHomeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCCSupportHomeToolStripMenuItem1.Click
        HelpBrowser.Navigate("http://support.fullforceapps.com/bcc/en/")
    End Sub

    Private Sub FullForceSupportHomeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullForceSupportHomeToolStripMenuItem1.Click
        HelpBrowser.Navigate("http://support.fullforceapps.com/")
    End Sub

    Private Sub FullForceProductPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullForceProductPageToolStripMenuItem.Click
        HelpBrowser.Navigate("http://www.fullforceapps.com/?q=project")
    End Sub

    Private Sub FullForceApplicationsHomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullForceApplicationsHomeToolStripMenuItem.Click
        HelpBrowser.Navigate("http://www.fullforceapps.com/")
    End Sub
End Class