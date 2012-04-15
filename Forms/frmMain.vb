Imports Microsoft.VisualBasic.ControlChars
Imports System.Deployment.Application
Imports System.Deployment
Public Class frmMain


#Region " Form Events (Empty) "

#End Region

#Region " Menus and Toolbars "

    Private Sub OpenProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProfileToolStripMenuItem.Click

        'Shows the result dialog.
        frmResults.Show()

        'Displays insructions for opening the profile.
        frmResults.OutputBox.Text = "Click the open button to open and view your profile."
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Exits the entire application.
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click

        'Opens the help window.
        frmHelp.Show()
    End Sub

    Private Sub DevLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevLoginToolStripMenuItem.Click

        'Opens the developer mode login form.
        frmDevLogin.Show()
    End Sub

    Private Sub ReleaseNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseNotesToolStripMenuItem.Click

        'Opens the release notes.
        frmReleaseNotes.Show()
    End Sub

    Private Sub ApplicationSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationSiteToolStripMenuItem.Click

        'Opens the FullForce website in the default web browser.
        Process.Start("http://www.fullforceapps.com/")
    End Sub

    Private Sub ContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactToolStripMenuItem.Click

        'Opens the FullForce Contact form 
        Process.Start("http://www.fullforceapps.com/?q=contact")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Opens the about box.
        frmAbout.Show()
    End Sub

#End Region

#Region " Updating "

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click

        'Initializes the error catching system.
        Try
            frmUpdate.Show()
        Catch exp As Exception
            MsgBox("Error: " + Err.Description + Environment.NewLine + "Error number:  " + Err.Number.ToString + Environment.NewLine + Environment.NewLine + "Please submit this error to the FullForce Development team using the online error reporting system.")
        End Try
    End Sub

#End Region

#Region " GUI Effects and Settings "

    Dim measuretype As String

    Private Sub NameBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameBox.TextChanged

        'Enables Gender selection controls when text is entered into box.
        Me.CalculationCtPanel.Enabled = True

        'Sets the name setting.
        My.Settings.name = NameBox.Text
    End Sub

    Private Sub SkinfoldRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkinfoldRBtn.CheckedChanged

        'Sets the measuretype variable.
        measuretype = "Skinfold"

        'Disables any other options set by the BMI option being chosen before.
        Me.HeightLBL.Enabled = False
        Me.HeightFTNumUpDown.Enabled = False
        Me.HeightFTLBL.Enabled = False
        Me.HeightINLBL.Enabled = False
        Me.HeightINNumUpDown.Enabled = False
        Me.WeightLBL.Enabled = False
        Me.WeightBox.Enabled = False
        Me.WeightLBSLBL.Enabled = False
        Me.AgeLBL.Enabled = False
        Me.AgeBox.Enabled = False
        Me.AgeYrsLBL.Enabled = False
        Me.AbLBL.Enabled = False
        Me.AbBox.Enabled = False
        Me.AbMMLBL.Enabled = False
        Me.TriLBL.Enabled = False
        Me.TriBox.Enabled = False
        Me.TriMMLBL.Enabled = False
        Me.ChestLBL.Enabled = False
        Me.ChestBox.Enabled = False
        Me.ChestMMLBL.Enabled = False
        Me.MidLBL.Enabled = False
        Me.MidBox.Enabled = False
        Me.MidMMLBL.Enabled = False
        Me.SubLBL.Enabled = False
        Me.SubBox.Enabled = False
        Me.SubMMLBL.Enabled = False
        Me.SupLBL.Enabled = False
        Me.SupBox.Enabled = False
        Me.SupMMLBL.Enabled = False
        Me.ThighLBL.Enabled = False
        Me.ThighBox.Enabled = False
        Me.ThighMMLBL.Enabled = False
        Me.ActivityLBL.Enabled = False
        Me.ActivityDropDown.Enabled = False
        Me.BCSGroupBox.Enabled = False

        'Enables Gender selection controls when text is entered into box.
        Me.GenderCtPanel.Enabled = True

        'Sets the calculation method status label to skinfold.
        Me.SkinfoldStatusLabel.Visible = True
        Me.CalculationStatusLabel.Text = ("Skinfold Calculation Method Chosen")
    End Sub

    Private Sub BMIRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMIRBtn.CheckedChanged

        'Sets the measuretype variable.
        measuretype = "BMI"

        'Enable BMI specific input fields and labels.
        Me.BCSGroupBox.Enabled = True
        Me.HeightLBL.Enabled = True
        Me.HeightFTNumUpDown.Enabled = True
        Me.HeightFTLBL.Enabled = True
        Me.HeightINLBL.Enabled = True
        Me.HeightINNumUpDown.Enabled = True
        Me.WeightLBL.Enabled = True
        Me.WeightBox.Enabled = True
        Me.WeightLBSLBL.Enabled = True
        Me.AgeLBL.Enabled = True
        Me.AgeBox.Enabled = True
        Me.AgeYrsLBL.Enabled = True
        Me.ActivityLBL.Enabled = True
        Me.ActivityDropDown.Enabled = True
        Me.GenderCtPanel.Enabled = True

        'Disable any options set by the Skinfold option being chosen before.
        Me.SkinfoldCtPanel.Enabled = False
        Me.AbLBL.Enabled = False
        Me.AbBox.Enabled = False
        Me.AbMMLBL.Enabled = False
        Me.TriLBL.Enabled = False
        Me.TriBox.Enabled = False
        Me.TriMMLBL.Enabled = False
        Me.ChestLBL.Enabled = False
        Me.ChestBox.Enabled = False
        Me.ChestMMLBL.Enabled = False
        Me.MidLBL.Enabled = False
        Me.MidBox.Enabled = False
        Me.MidMMLBL.Enabled = False
        Me.SubLBL.Enabled = False
        Me.SubBox.Enabled = False
        Me.SubMMLBL.Enabled = False
        Me.SupLBL.Enabled = False
        Me.SupBox.Enabled = False
        Me.SupMMLBL.Enabled = False
        Me.ThighLBL.Enabled = False
        Me.ThighBox.Enabled = False
        Me.ThighMMLBL.Enabled = False

        'Sets the calculation method status label to BMI.
        Me.SkinfoldStatusLabel.Visible = False
        Me.CalculationStatusLabel.Text = ("BMI Calculation Method Chosen")
    End Sub

    'Enables Skinfold # selection controls when button is selected. (Next two Subs)
    Private Sub MaleRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleRBtn.CheckedChanged
        'Checks to see if the skinfold panel should be enabled.
        If measuretype = "Skinfold" Then SkinfoldCtPanel.Enabled = True
        'Sets the gender setting to "Male"
        My.Settings.gender = "Male"
        GenderStatusLabel.Text = "Male"
        GenderStatusLabel.Image = My.Resources.resimUserMale
        'Check and see if skinfold measurement is set. It will be if we're coming back to change things here.
        If My.Settings.genskinv = "3Fem" Or My.Settings.genskinv = "3Male" Then StatusLabel.Text = "You must reset the Skinfold number now."
        If My.Settings.genskinv = "3Fem" Or My.Settings.genskinv = "3Male" Then StatusLabel.Image = My.Resources.resimInfo
    End Sub

    Private Sub FemRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FemRBtn.CheckedChanged
        'Checks to see if the skinfold panel should be enabled.
        If measuretype = "Skinfold" Then Me.SkinfoldCtPanel.Enabled = True
        'Sets the gender setting to "Female"
        My.Settings.gender = "Female"
        GenderStatusLabel.Text = "Female"
        GenderStatusLabel.Image = My.Resources.resimUserFemale
        'Check and see if skinfold measurement is set. It will be if we're coming back to change things here.
        If My.Settings.genskinv = "3Fem" Or My.Settings.genskinv = "3Male" Then StatusLabel.Text = "You must reset the Skinfold number now."
        If My.Settings.genskinv = "3Fem" Or My.Settings.genskinv = "3Male" Then StatusLabel.Image = My.Resources.resimInfo
    End Sub

    Private Sub ThreeRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreeRBtn.CheckedChanged

        'Female: Triceps, suprailiac, thigh
        If FemRBtn.Checked Then BCSGroupBox.Enabled = True
        If FemRBtn.Checked Then HeightLBL.Enabled = True
        If FemRBtn.Checked Then HeightFTNumUpDown.Enabled = True
        If FemRBtn.Checked Then HeightFTLBL.Enabled = True
        If FemRBtn.Checked Then HeightINNumUpDown.Enabled = True
        If FemRBtn.Checked Then HeightINLBL.Enabled = True
        If FemRBtn.Checked Then WeightLBL.Enabled = True
        If FemRBtn.Checked Then WeightBox.Enabled = True
        If FemRBtn.Checked Then WeightLBSLBL.Enabled = True
        If FemRBtn.Checked Then AgeLBL.Enabled = True
        If FemRBtn.Checked Then AgeBox.Enabled = True
        If FemRBtn.Checked Then AgeYrsLBL.Enabled = True
        If FemRBtn.Checked Then AbLBL.Enabled = False
        If FemRBtn.Checked Then AbBox.Enabled = False
        If FemRBtn.Checked Then AbMMLBL.Enabled = False
        If FemRBtn.Checked Then TriLBL.Enabled = True
        If FemRBtn.Checked Then TriBox.Enabled = True
        If FemRBtn.Checked Then TriMMLBL.Enabled = True
        If FemRBtn.Checked Then ChestLBL.Enabled = False
        If FemRBtn.Checked Then ChestBox.Enabled = False
        If FemRBtn.Checked Then ChestMMLBL.Enabled = False
        If FemRBtn.Checked Then MidLBL.Enabled = False
        If FemRBtn.Checked Then MidBox.Enabled = False
        If FemRBtn.Checked Then MidMMLBL.Enabled = False
        If FemRBtn.Checked Then SubLBL.Enabled = False
        If FemRBtn.Checked Then SubBox.Enabled = False
        If FemRBtn.Checked Then SubMMLBL.Enabled = False
        If FemRBtn.Checked Then SupLBL.Enabled = True
        If FemRBtn.Checked Then SupBox.Enabled = True
        If FemRBtn.Checked Then SupMMLBL.Enabled = True
        If FemRBtn.Checked Then ThighLBL.Enabled = True
        If FemRBtn.Checked Then ThighBox.Enabled = True
        If FemRBtn.Checked Then ThighMMLBL.Enabled = True
        If FemRBtn.Checked Then ActivityLBL.Enabled = True
        If FemRBtn.Checked Then ActivityDropDown.Enabled = True

        'Sets the gender and the skinfold number.
        If FemRBtn.Checked Then My.Settings.genskinv = "3Fem"


        'Female:    Chest, Abdomen, thigh
        If MaleRBtn.Checked Then BCSGroupBox.Enabled = True
        If MaleRBtn.Checked Then HeightLBL.Enabled = True
        If MaleRBtn.Checked Then HeightFTNumUpDown.Enabled = True
        If MaleRBtn.Checked Then HeightFTLBL.Enabled = True
        If MaleRBtn.Checked Then HeightINNumUpDown.Enabled = True
        If MaleRBtn.Checked Then HeightINLBL.Enabled = True
        If MaleRBtn.Checked Then WeightLBL.Enabled = True
        If MaleRBtn.Checked Then WeightBox.Enabled = True
        If MaleRBtn.Checked Then WeightLBSLBL.Enabled = True
        If MaleRBtn.Checked Then AgeLBL.Enabled = True
        If MaleRBtn.Checked Then AgeBox.Enabled = True
        If MaleRBtn.Checked Then AgeYrsLBL.Enabled = True
        If MaleRBtn.Checked Then AbLBL.Enabled = True
        If MaleRBtn.Checked Then AbBox.Enabled = True
        If MaleRBtn.Checked Then AbMMLBL.Enabled = True
        If MaleRBtn.Checked Then TriLBL.Enabled = False
        If MaleRBtn.Checked Then TriBox.Enabled = False
        If MaleRBtn.Checked Then TriMMLBL.Enabled = False
        If MaleRBtn.Checked Then ChestLBL.Enabled = True
        If MaleRBtn.Checked Then ChestBox.Enabled = True
        If MaleRBtn.Checked Then ChestMMLBL.Enabled = True
        If MaleRBtn.Checked Then MidLBL.Enabled = False
        If MaleRBtn.Checked Then MidBox.Enabled = False
        If MaleRBtn.Checked Then MidMMLBL.Enabled = False
        If MaleRBtn.Checked Then SubLBL.Enabled = False
        If MaleRBtn.Checked Then SubBox.Enabled = False
        If MaleRBtn.Checked Then SubMMLBL.Enabled = False
        If MaleRBtn.Checked Then SupLBL.Enabled = False
        If MaleRBtn.Checked Then SupBox.Enabled = False
        If MaleRBtn.Checked Then SupMMLBL.Enabled = False
        If MaleRBtn.Checked Then ThighLBL.Enabled = True
        If MaleRBtn.Checked Then ThighBox.Enabled = True
        If MaleRBtn.Checked Then ThighMMLBL.Enabled = True
        If MaleRBtn.Checked Then ActivityLBL.Enabled = True
        If MaleRBtn.Checked Then ActivityDropDown.Enabled = True

        'Sets the gender and the skinfold number.
        If MaleRBtn.Checked Then My.Settings.genskinv = "3Male"

        'Set Statusbar texts.
        Me.StatusLabel.Text = "Ready"
        Me.SkinfoldStatusLabel.Text = "3 Skinfold Measurements"
    End Sub

    Private Sub SevenRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SevenRBtn.CheckedChanged

        'Enables all 7 input fields for both male and female.
        Me.BCSGroupBox.Enabled = True
        Me.HeightLBL.Enabled = True
        Me.HeightFTNumUpDown.Enabled = True
        Me.HeightFTLBL.Enabled = True
        Me.HeightINNumUpDown.Enabled = True
        Me.HeightINLBL.Enabled = True
        Me.WeightLBL.Enabled = True
        Me.WeightBox.Enabled = True
        Me.WeightLBSLBL.Enabled = True
        Me.AgeLBL.Enabled = True
        Me.AgeBox.Enabled = True
        Me.AgeYrsLBL.Enabled = True
        Me.AbLBL.Enabled = True
        Me.AbBox.Enabled = True
        Me.AbMMLBL.Enabled = True
        Me.TriLBL.Enabled = True
        Me.TriBox.Enabled = True
        Me.TriMMLBL.Enabled = True
        Me.ChestLBL.Enabled = True
        Me.ChestBox.Enabled = True
        Me.ChestMMLBL.Enabled = True
        Me.MidLBL.Enabled = True
        Me.MidBox.Enabled = True
        Me.MidMMLBL.Enabled = True
        Me.SubLBL.Enabled = True
        Me.SubBox.Enabled = True
        Me.SubMMLBL.Enabled = True
        Me.SupLBL.Enabled = True
        Me.SupBox.Enabled = True
        Me.SupMMLBL.Enabled = True
        Me.ThighLBL.Enabled = True
        Me.ThighBox.Enabled = True
        Me.ThighMMLBL.Enabled = True
        Me.ActivityLBL.Enabled = True
        Me.ActivityDropDown.Enabled = True

        'Sets the gender and the skinfold number.
        If FemRBtn.Checked Then My.Settings.genskinv = "7Fem"
        If MaleRBtn.Checked Then My.Settings.genskinv = "7Male"


        'Set Statusbar texts.
        Me.StatusLabel.Text = "Ready"
        Me.SkinfoldStatusLabel.Text = "7 Skinfold Measurements"
    End Sub

    Private Sub WeightBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WeightBox.TextChanged

        'Make the WeightBox only accept numeric input.
        If Not IsNumeric(WeightBox.Text) Then
            WeightBox.Text = ""
        End If
    End Sub

    Private Sub AgeBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgeBox.TextChanged

        'Make the AgeBox only accept only numeric input.
        If Not IsNumeric(AgeBox.Text) Then
            AgeBox.Text = ""
        End If
    End Sub


#End Region

#Region " Calculate Button Setup "

    Dim exclass As New BodyComp.classCalc

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click

        'No skinfolds are chosen. Calculation Method warning is shown.
        If SkinfoldRBtn.Checked = False And BMIRBtn.Checked = False Then
            MsgBox("Please choose a calculation method to continue.", MsgBoxStyle.Information)
            'BMI method is chosen. Run the BMICalc sub.
        ElseIf BMIRBtn.Checked = True And SkinfoldRBtn.Checked = False Then
            exclass.BMICalc()
            'Skinfold button is chosen. Check for gender.
        ElseIf BMIRBtn.Checked = False And SkinfoldRBtn.Checked = True Then
            'No gender is chosen. Gender warning is shown.
            If MaleRBtn.Checked = False And FemRBtn.Checked = False Then
                MsgBox("Please choose a gender to continue", MsgBoxStyle.Information)
                'Male gender is chosen. Check for skinfold number.
            ElseIf MaleRBtn.Checked = True And FemRBtn.Checked = False Then
                'Skinfold number not chosen. Skinfold number warning is shown.
                If ThreeRBtn.Checked = False And SevenRBtn.Checked = False Then
                    MsgBox("Please choose a skinfold number to continue.", MsgBoxStyle.Information)
                    'Three skinfold method checked. Run the SkinCalc sub.
                ElseIf ThreeRBtn.Checked = True And SevenRBtn.Checked = False Then
                    exclass.SkinCalc()
                    'Seven skinfold method checked. Run the SkinCalc Sub.
                ElseIf ThreeRBtn.Checked = False And SevenRBtn.Checked = True Then
                    exclass.SkinCalc()
                End If
                'Female gender is chosen. Check for skinfold number.
            ElseIf MaleRBtn.Checked = False And FemRBtn.Checked = True Then
                'Skinfold number not chosen. Skinfold number warning is shown.
                If ThreeRBtn.Checked = False And SevenRBtn.Checked = False Then
                    MsgBox("Please choose a skinfold number to continue.", MsgBoxStyle.Information)
                    'Three skinfold method checked. Run the SkinCalc sub.
                ElseIf ThreeRBtn.Checked = True And SevenRBtn.Checked = False Then
                    exclass.SkinCalc()
                    'Seven skinfold method checked. Run the SkinCalc Sub.
                ElseIf ThreeRBtn.Checked = False And SevenRBtn.Checked = True Then
                    exclass.SkinCalc()
                End If
            End If
        End If
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click

        'No skinfolds are chosen. Calculation Method warning is shown.
        If SkinfoldRBtn.Checked = False And BMIRBtn.Checked = False Then
            MsgBox("Please choose a calculation method to continue.", MsgBoxStyle.Information)
            'BMI method is chosen. Run the BMICalc sub.
        ElseIf BMIRBtn.Checked = True And SkinfoldRBtn.Checked = False Then
            exclass.BMICalc()
            'Skinfold button is chosen. Check for gender.
        ElseIf BMIRBtn.Checked = False And SkinfoldRBtn.Checked = True Then
            'No gender is chosen. Gender warning is shown.
            If MaleRBtn.Checked = False And FemRBtn.Checked = False Then
                MsgBox("Please choose a gender to continue", MsgBoxStyle.Information)
                'Male gender is chosen. Check for skinfold number.
            ElseIf MaleRBtn.Checked = True And FemRBtn.Checked = False Then
                'Skinfold number not chosen. Skinfold number warning is shown.
                If ThreeRBtn.Checked = False And SevenRBtn.Checked = False Then
                    MsgBox("Please choose a skinfold number to continue.", MsgBoxStyle.Information)
                    'Three skinfold method checked. Run the SkinCalc sub.
                ElseIf ThreeRBtn.Checked = True And SevenRBtn.Checked = False Then
                    exclass.SkinCalc()
                    'Seven skinfold method checked. Run the SkinCalc Sub.
                ElseIf ThreeRBtn.Checked = False And SevenRBtn.Checked = True Then
                    exclass.SkinCalc()
                End If
                'Female gender is chosen. Check for skinfold number.
            ElseIf MaleRBtn.Checked = False And FemRBtn.Checked = True Then
                'Skinfold number not chosen. Skinfold number warning is shown.
                If ThreeRBtn.Checked = False And SevenRBtn.Checked = False Then
                    MsgBox("Please choose a skinfold number to continue.", MsgBoxStyle.Information)
                    'Three skinfold method checked. Run the SkinCalc sub.
                ElseIf ThreeRBtn.Checked = True And SevenRBtn.Checked = False Then
                    exclass.SkinCalc()
                    'Seven skinfold method checked. Run the SkinCalc Sub.
                ElseIf ThreeRBtn.Checked = False And SevenRBtn.Checked = True Then
                    exclass.SkinCalc()
                End If
            End If
        End If
    End Sub

#End Region

#Region " Eastereggs "

    'No crirical code will go insode this region. This is for eastereggs only...
    'Eastereggs are POSTPONED as there are more important tasks currently.

#End Region

End Class