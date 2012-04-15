Public NotInheritable Class frmSplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).


        'Version info (Also includes type of build)
        Version.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
