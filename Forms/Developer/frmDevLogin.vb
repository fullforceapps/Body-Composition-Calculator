Public Class frmDevLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Compares the username and password with the ones set. 
        'If correct the fields will be cleared and developer mode will be entered and the login form will close.
        If UsernameTextBox.Text = "bccdev" And PasswordTextBox.Text = "1stapp" Then
            UsernameTextBox.Select()
            UsernameTextBox.Clear()
            PasswordTextBox.Select()
            PasswordTextBox.Clear()
            frmDevMode.Show()
            Me.Hide()

            'If the username and/or password isincorrect it will clear the fields and display a warning message.
        ElseIf UsernameTextBox.Text <> "bccdebug" Or PasswordTextBox.Text <> "testpass" Then
            UsernameTextBox.Select()
            UsernameTextBox.Clear()
            PasswordTextBox.Select()
            PasswordTextBox.Clear()
            MsgBox("Username or password is incorrect.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Closes the login form.
        Me.Close()
    End Sub

    'No functional code will go below this line. This is for eastereggs only...

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This is a 5x5 pixel that allows you to bypass logging in to developer mode, it also hides the logon form.
        frmDevMode.Show()
        Me.Hide()
    End Sub
End Class