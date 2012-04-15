Imports System.Xml
Imports System.Xml.Linq

Public Class frmUpdate

#Region " Initialization And Setup "

    Private Sub update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Shows the information about the current version of the application.
        Me.CurAppNameLbl.Text = My.Application.Info.ProductName
        Me.CurVerNumLbl.Text = String.Format(My.Application.Info.Version.ToString)
        Me.UpdAppNameLbl.Text = "Gathering information..."
        Me.UpdVerNumLbl.Text = "Gathering information..."
        Me.UpdNUpdDescLbl.Text = "Gathering information..."

        'Initialize the timers. Used to give time for the code to execute.
        Timer1.Enabled = True
        Timer1.Start()
        Timer2.Enabled = False
        Timer2.Stop()
        Timer3.Enabled = True
        Timer3.Start()

        'Set up the buttons.
        'Currently disabled, icons implimented  Me.btnmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmain.Text = "Close"
        Me.UpdEULAUpdLbl.Visible = False
        Me.AdminPrivBTN.Visible = False
        Me.btnsecondary.Visible = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        'Shows the status 1 second before the program begins updating.
        Me.statuslabel.Text = "Checking for available updates..."
        Me.statuslabel.Image = My.Resources.resimLoading
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Launches the update checking process after a 2 second delay.
        downloadUpdateStatus()
    End Sub

#End Region

#Region " XML Check And UI Effects "

    'Sets a boolean variable to see if updates are indeed available. This is neccessary for the actual updating process.
    Dim UpdateAv As String


    Public Sub downloadUpdateStatus()
        Try
            'Shut down the timers.
            Timer1.Stop()
            Timer1.Enabled = False
            Timer3.Stop()
            Timer3.Enabled = False

            'Catch and hold contents of the XML file.
            Dim UpdateDoc As XDocument
            UpdateDoc = XDocument.Load("http://update.fullforceapps.com/bcc/en/v15/update.xml")

            'Capture the product name.
            Dim UpdateProdName As String
            UpdateProdName = UpdateDoc.<ProductUpdate>.<Product>.<ProductName>.Value.ToString

            'Capture the available update version.
            Dim UpdateVer As String
            UpdateVer = UpdateDoc.<ProductUpdate>.<Update>.<Version>.Value.ToString

            'Is the update required?
            Dim UpdateReq As String
            UpdateReq = UpdateDoc.<ProductUpdate>.<Update>.<IsRequired>.Value.ToString

            'What is the update description captain?
            Dim UpdateDesc As String
            UpdateDesc = UpdateDoc.<ProductUpdate>.<Update>.<UpdateDescription>.Value.ToString

            'Has the EULA been updated this time?
            Dim UpdateEULA As String
            UpdateEULA = UpdateDoc.<ProductUpdate>.<Update>.<NewEULA>.Value.ToString

            'Does this app need admin privelages?
            Dim AdmInst As String
            AdmInst = UpdateDoc.<ProductUpdate>.<Update>.<AdminReq>.Value.ToString


            'Checks to see if update are applicable.
            Dim CurrVer = My.Application.Info.Version.ToString
            If UpdateVer > CurrVer Then
                If UpdateReq = True Then

                    'An update IS available.
                    UpdateAv = "True"

                    'Write the available updates name, version number, description, and EULA notice if necessary.
                    Me.UpdAppNameLbl.Text = UpdateProdName
                    Me.UpdVerNumLbl.Text = UpdateVer
                    Me.UpdNUpdDescLbl.Text = UpdateDesc
                    If AdmInst = True Then AdminPrivBTN.Visible = True Else AdminPrivBTN.Visible = False
                    If UpdateEULA = True Then UpdEULAUpdLbl.Visible = True Else UpdEULAUpdLbl.Visible = False

                    'Change all necessary gui elements.
                    Me.btnmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
                    Me.btnmain.Text = "Updating..."
                    Me.btnsecondary.Visible = False
                    Me.statuslabel.Text = "A required update is available. Please wait while it is downloaded and applied."
                    Me.statuslabel.Image = My.Resources.resimUpdateReq

                    'Enable a 2 second delay before downloading the update.
                    Me.Timer2.Enabled = True
                    Me.Timer2.Start()

                ElseIf UpdateReq = False Then

                    'An update IS available.
                    UpdateAv = "True"

                    'Write the available updates name, version number, description, and EULA notice if necessary.
                    Me.UpdAppNameLbl.Text = UpdateProdName
                    Me.UpdVerNumLbl.Text = UpdateVer
                    Me.UpdNUpdDescLbl.Text = UpdateDesc
                    If AdmInst = True Then AdminPrivBTN.Visible = True Else AdminPrivBTN.Visible = False
                    If UpdateEULA = True Then UpdEULAUpdLbl.Visible = True Else UpdEULAUpdLbl.Visible = False

                    'Change all necessary gui elements.
                    Me.btnmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
                    Me.btnmain.Text = "Update Now"
                    Me.btnsecondary.Visible = True
                    Me.statuslabel.Text = "An optional update is available."
                    Me.statuslabel.Image = My.Resources.resimUpdateOpt

                    'This update will not automatically run so make sure the timer is stopped..
                    Me.Timer2.Stop()

                End If

            ElseIf UpdateVer <= CurrVer Then

                'An update is NOT available.
                UpdateAv = "False"

                'Write the available updates name, version number, description, and EULA notice if necessary.
                Me.UpdAppNameLbl.Text = UpdateProdName
                Me.UpdVerNumLbl.Text = UpdateVer
                Me.UpdNUpdDescLbl.Text = UpdateDesc
                If UpdateEULA = True Then UpdEULAUpdLbl.Visible = True Else UpdEULAUpdLbl.Visible = False

                'Change all necessary gui elements.
                Me.btnmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(61, Byte), Integer))
                Me.btnmain.Text = "Close"
                Me.btnsecondary.Visible = False
                Me.statuslabel.Text = "The program is up to date."
                Me.statuslabel.Image = My.Resources.resimUpdateNone

            End If

        Catch exp As Exception
            If Err.Number = 5 Then _
                'Chane all necessary gui elements.
                statuslabel.Text = "Please connect to the Internet."
                statuslabel.Image = My.Resources.resimUpdateReq
                UpdAppNameLbl.Text = "Please connect to the Internet."
                UpdVerNumLbl.Text = "Please connect to the Internet."
                UpdNUpdDescLbl.Text = "Please connect to the Internet."

                'Tell the people they fail! TURN ON THE FREAKING WIRELESS!!!
                MsgBox("Please connect to the Internet and check for updates again.", MsgBoxStyle.Exclamation)

                'Set up the button to reinitiate the update sequence.
                UpdateAv = "Error"
                btnmain.Text = "Check for updates"

            End If
        End Try
    End Sub

#End Region

#Region " Updating The Program "

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        updateApp()
    End Sub
    Public Sub updateApp()
        'Initializes the try catch method to catch and display any errors.
        Try
            'Stop the timers so we don't flood the server with requests or crash the program.
            Me.Timer1.Stop()
            Me.Timer2.Stop()
            Me.Timer3.Stop()

            'Gets the name of the file to download and downloads it to TODO: LOCATION.
            Dim UpdateDoc As XDocument
            UpdateDoc = XDocument.Load("http://update.fullforceapps.com/bcc/en/v15/update.xml")

            Dim FileToDownload As String
            FileToDownload = UpdateDoc.<ProductUpdate>.<Update>.<File>.Value.ToString

            'Download the update file.
            My.Computer.Network.DownloadFile(FileToDownload, My.Computer.FileSystem.SpecialDirectories.Temp & "\bccsetup.msi", "", "", True, 100, True)

            MsgBox("The program will now close and install the update.", MsgBoxStyle.Information)

            'Launch the "update" file in repair mode.
            'Uses the -f command line trigger to initiate repair mode.
            Dim options As String
            options = " /f " & Chr(34) & My.Computer.FileSystem.SpecialDirectories.Desktop & "\bccsetup.msi" & Chr(34) & ""
            Process.Start("msiexec.exe", options)

            System.Windows.Forms.Application.Exit()

        Catch exp As Exception
            MsgBox("Error:" + Environment.NewLine + Err.Description + Environment.NewLine + "Error number:  " + Err.Number.ToString + Environment.NewLine + Environment.NewLine + "Please submit this to the FullForce team using the online error reporting system.")
        End Try

    End Sub

#End Region

#Region " User Input "

    Private Sub btnmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmain.Click

        'If UpdateAv = "True" Then Timer2.Start()Elseif Me.Close()
        If UpdateAv = "True" Then
            'Start updating if one is available.
            Timer2.Start()
        ElseIf UpdateAv = "Error" Then
            'Allow the user to check for the update if an error has occured.
            Me.UpdAppNameLbl.Text = "Gathering information..."
            Me.UpdVerNumLbl.Text = "Gathering information..."
            Me.UpdNUpdDescLbl.Text = "Gathering information..."
            Timer1.Start()
            Timer3.Start()
        ElseIf UpdateAv = "False" Then
            'If no update is available then let the user close the update dialog.
            Me.Close()
        End If


    End Sub

    Private Sub btnsecondary_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnsecondary.LinkClicked
        Me.Close()
        MsgBox("It is highly recommended that any available updates be installed at a later time.", MsgBoxStyle.Information)
    End Sub

    Private Sub UpdEULAUpdLbl_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles UpdEULAUpdLbl.LinkClicked
        Process.Start("http://support.fullforceapps.com/bcc-eula/")
    End Sub

    Private Sub AdminPrivBTN_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AdminPrivBTN.LinkClicked
        Process.Start("http://suport.fullforceapps.com/bcc-update/")
    End Sub

#End Region

End Class