Imports Microsoft.VisualBasic.ControlChars
Imports System.Deployment.Application
Imports System.Deployment
Imports Microsoft.Win32

Public Class frmDevMode

    '    Dim GenSkin As String
    '    Dim complete As String

    '    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    '        'Opens the about box.
    '        frmAbout.Show()
    '    End Sub

    '    Private Sub NameBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameBox.TextChanged
    '        'Enables Gender selection controls when text is entered into box.
    '        Me.GenderPanel.Enabled = True
    '        'Sets the name setting.
    '        My.Settings.name = NameBox.Text
    '    End Sub

    '    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    '        'Exits the entire application.
    '        Me.Close()
    '    End Sub

    '    'Enables Skinfold # selection controls when button is selected. (Next two Subs)
    '    Private Sub MaleRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleRBtn.CheckedChanged
    '        Me.SkinfoldCtPanel.Enabled = True
    '        'Sets the gender setting to "Male"
    '        My.Settings.gender = "Male"
    '        GenderStatusLabel.Text = "Male"
    '        GenderStatusLabel.Image = My.Resources.resimUserMale
    '        'Check and see if skinfold measurement is set. It will be if we're coming back to change things here.
    '        If GenSkin = "3Fem" Or GenSkin = "3Male" Then StatusLabel.Text = "You must reset the Skinfold number now."
    '        If GenSkin = "3Fem" Or GenSkin = "3Male" Then StatusLabel.Image = My.Resources.resimInfo
    '    End Sub

    '    Private Sub FemRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FemRBtn.CheckedChanged
    '        Me.SkinfoldCtPanel.Enabled = True
    '        'Sets the gender setting to "Female"
    '        My.Settings.gender = "Female"
    '        GenderStatusLabel.Text = "Female"
    '        GenderStatusLabel.Image = My.Resources.resimUserFemale
    '        'Check and see if skinfold measurement is set. It will be if we're coming back to change things here.
    '        If GenSkin = "3Fem" Or GenSkin = "3Male" Then StatusLabel.Text = "You must reset the Skinfold number now."
    '        If GenSkin = "3Fem" Or GenSkin = "3Male" Then StatusLabel.Image = My.Resources.resimInfo
    '    End Sub

    '    Private Sub ThreeRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreeRBtn.CheckedChanged

    '        'Women: Triceps, suprailiac, thigh
    '        If FemRBtn.Checked Then GroupBox2.Enabled = True
    '        If FemRBtn.Checked Then Label13.Enabled = True
    '        If FemRBtn.Checked Then NumericUpDown1.Enabled = True
    '        If FemRBtn.Checked Then Label15.Enabled = True
    '        If FemRBtn.Checked Then NumericUpDown2.Enabled = True
    '        If FemRBtn.Checked Then Label16.Enabled = True
    '        If FemRBtn.Checked Then Label14.Enabled = True
    '        If FemRBtn.Checked Then TextBox1.Enabled = True
    '        If FemRBtn.Checked Then Label11.Enabled = True
    '        If FemRBtn.Checked Then AgeBox.Enabled = True
    '        If FemRBtn.Checked Then Label3.Enabled = False
    '        If FemRBtn.Checked Then AbBox.Enabled = False
    '        If FemRBtn.Checked Then Label5.Enabled = True
    '        If FemRBtn.Checked Then TriBox.Enabled = True
    '        If FemRBtn.Checked Then Label6.Enabled = False
    '        If FemRBtn.Checked Then ChestBox.Enabled = False
    '        If FemRBtn.Checked Then Label7.Enabled = False
    '        If FemRBtn.Checked Then MidBox.Enabled = False
    '        If FemRBtn.Checked Then Label8.Enabled = False
    '        If FemRBtn.Checked Then SubBox.Enabled = False
    '        If FemRBtn.Checked Then Label9.Enabled = True
    '        If FemRBtn.Checked Then SupBox.Enabled = True
    '        If FemRBtn.Checked Then Label10.Enabled = True
    '        If FemRBtn.Checked Then ThighBox.Enabled = True
    '        If FemRBtn.Checked Then Label12.Enabled = True
    '        If FemRBtn.Checked Then ActivityDropDown.Enabled = True
    '        If FemRBtn.Checked Then Label17.Enabled = True
    '        If FemRBtn.Checked Then Label18.Enabled = False
    '        If FemRBtn.Checked Then Label19.Enabled = True
    '        If FemRBtn.Checked Then Label20.Enabled = False
    '        If FemRBtn.Checked Then Label21.Enabled = False
    '        If FemRBtn.Checked Then Label22.Enabled = False
    '        If FemRBtn.Checked Then Label23.Enabled = True
    '        If FemRBtn.Checked Then Label24.Enabled = True
    '        If FemRBtn.Checked Then Label25.Enabled = True
    '        If FemRBtn.Checked Then GenSkin = "3Fem"

    '        'Men:    Chest, Abdomen, thigh
    '        If MaleRBtn.Checked Then GroupBox2.Enabled = True
    '        If MaleRBtn.Checked Then Label13.Enabled = True
    '        If MaleRBtn.Checked Then NumericUpDown1.Enabled = True
    '        If MaleRBtn.Checked Then Label15.Enabled = True
    '        If MaleRBtn.Checked Then NumericUpDown2.Enabled = True
    '        If MaleRBtn.Checked Then Label16.Enabled = True
    '        If MaleRBtn.Checked Then Label14.Enabled = True
    '        If MaleRBtn.Checked Then TextBox1.Enabled = True
    '        If MaleRBtn.Checked Then Label11.Enabled = True
    '        If MaleRBtn.Checked Then AgeBox.Enabled = True
    '        If MaleRBtn.Checked Then Label3.Enabled = True
    '        If MaleRBtn.Checked Then AbBox.Enabled = True
    '        If MaleRBtn.Checked Then Label5.Enabled = False
    '        If MaleRBtn.Checked Then TriBox.Enabled = False
    '        If MaleRBtn.Checked Then Label6.Enabled = True
    '        If MaleRBtn.Checked Then ChestBox.Enabled = True
    '        If MaleRBtn.Checked Then Label7.Enabled = False
    '        If MaleRBtn.Checked Then MidBox.Enabled = False
    '        If MaleRBtn.Checked Then Label8.Enabled = False
    '        If MaleRBtn.Checked Then SubBox.Enabled = False
    '        If MaleRBtn.Checked Then Label9.Enabled = False
    '        If MaleRBtn.Checked Then SupBox.Enabled = False
    '        If MaleRBtn.Checked Then Label10.Enabled = True
    '        If MaleRBtn.Checked Then ThighBox.Enabled = True
    '        If MaleRBtn.Checked Then Label12.Enabled = True
    '        If MaleRBtn.Checked Then ActivityDropDown.Enabled = True
    '        If MaleRBtn.Checked Then Label17.Enabled = True
    '        If MaleRBtn.Checked Then Label18.Enabled = True
    '        If MaleRBtn.Checked Then Label19.Enabled = False
    '        If MaleRBtn.Checked Then Label20.Enabled = True
    '        If MaleRBtn.Checked Then Label21.Enabled = False
    '        If MaleRBtn.Checked Then Label22.Enabled = False
    '        If MaleRBtn.Checked Then Label23.Enabled = False
    '        If MaleRBtn.Checked Then Label24.Enabled = True
    '        If MaleRBtn.Checked Then Label25.Enabled = True
    '        If MaleRBtn.Checked Then GenSkin = "3Male"

    '        'Set Statusbar texts
    '        StatusLabel.Text = "Ready"
    '        Me.SkinfoldStatusLabel.Text = "3 Skinfold Measurements"
    '    End Sub

    '    Private Sub SevenRBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SevenRBtn.CheckedChanged
    '        'Enables all 7 input fields for both male and female.
    '        Me.GroupBox2.Enabled = True
    '        Me.Label13.Enabled = True
    '        Me.NumericUpDown1.Enabled = True
    '        Me.Label15.Enabled = True
    '        Me.NumericUpDown2.Enabled = True
    '        Me.Label16.Enabled = True
    '        Me.Label14.Enabled = True
    '        Me.TextBox1.Enabled = True
    '        Me.Label11.Enabled = True
    '        Me.AgeBox.Enabled = True
    '        Me.Label3.Enabled = True
    '        Me.AbBox.Enabled = True
    '        Me.Label5.Enabled = True
    '        Me.TriBox.Enabled = True
    '        Me.Label6.Enabled = True
    '        Me.ChestBox.Enabled = True
    '        Me.Label7.Enabled = True
    '        Me.MidBox.Enabled = True
    '        Me.Label8.Enabled = True
    '        Me.SubBox.Enabled = True
    '        Me.Label9.Enabled = True
    '        Me.SupBox.Enabled = True
    '        Me.Label10.Enabled = True
    '        Me.ThighBox.Enabled = True
    '        Me.Label12.Enabled = True
    '        Me.ActivityDropDown.Enabled = True
    '        Me.Label17.Enabled = True
    '        Me.Label18.Enabled = True
    '        Me.Label19.Enabled = True
    '        Me.Label20.Enabled = True
    '        Me.Label21.Enabled = True
    '        Me.Label22.Enabled = True
    '        Me.Label23.Enabled = True
    '        Me.Label24.Enabled = True
    '        Me.Label25.Enabled = True

    '        If FemRBtn.Checked Then GenSkin = "7Fem"
    '        If MaleRBtn.Checked Then GenSkin = "7Male"

    '        'Set Statusbar texts
    '        StatusLabel.Text = "Ready"
    '        Me.SkinfoldStatusLabel.Text = "7 Skinfold Measurements"
    '    End Sub
    '    Dim Addition As Integer

    '    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
    '        BodyCompositionCalculate()
    '    End Sub

    '    Private Sub ResetProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetProfileToolStripMenuItem.Click
    '        'Resets all of the application settings.


    '        'Clears all user input fields.
    '        NameBox.ResetText()
    '        NumericUpDown1.Value = (5)
    '        NumericUpDown2.Value = (0)
    '        TextBox1.ResetText()
    '        AgeBox.ResetText()
    '        AbBox.ResetText()
    '        TriBox.ResetText()
    '        ChestBox.ResetText()
    '        MidBox.ResetText()
    '        SubBox.ResetText()
    '        SupBox.ResetText()
    '        ThighBox.ResetText()

    '        'Re-Disables all fields in the application.
    '        Me.GroupBox2.Enabled = False
    '        Me.Label13.Enabled = False
    '        Me.NumericUpDown1.Enabled = False
    '        Me.Label15.Enabled = False
    '        Me.NumericUpDown2.Enabled = False
    '        Me.Label16.Enabled = False
    '        Me.Label14.Enabled = False
    '        Me.TextBox1.Enabled = False
    '        Me.Label11.Enabled = False
    '        Me.AgeBox.Enabled = False
    '        Me.Label3.Enabled = False
    '        Me.AbBox.Enabled = False
    '        Me.Label5.Enabled = False
    '        Me.TriBox.Enabled = False
    '        Me.Label6.Enabled = False
    '        Me.ChestBox.Enabled = False
    '        Me.Label7.Enabled = False
    '        Me.MidBox.Enabled = False
    '        Me.Label8.Enabled = False
    '        Me.SubBox.Enabled = False
    '        Me.Label9.Enabled = False
    '        Me.SupBox.Enabled = False
    '        Me.Label10.Enabled = False
    '        Me.ThighBox.Enabled = False
    '        Me.Label2.Enabled = False
    '        Me.Label4.Enabled = False

    '    End Sub

    '    Private Sub ApplicationSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationSiteToolStripMenuItem.Click
    '        'Opens the applications website in the default web browser.
    '        Process.Start("http://www.fullforceapps.com/")

    '    End Sub

    '    Private Sub ReleaseNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseNotesToolStripMenuItem.Click
    '        'Opens the release notes.
    '        frmReleaseNotes.Show()
    '    End Sub

    '    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
    '        'Guides the application to the apperoperate website to download and install updates.
    '        Try
    '            'Guides the application to the apperoperiate location to download and install updates.
    '            Dim ad As ApplicationDeployment
    '            Dim info As UpdateCheckInfo

    '            ad = ApplicationDeployment.CurrentDeployment
    '            info = ad.CheckForDetailedUpdate

    '            If Not info.UpdateAvailable Then
    '                MsgBox("The software is currently up to date.")
    '                Return
    '            End If

    '            Dim doupdate As Boolean = True
    '            If info.IsUpdateRequired Then
    '                MsgBox("A required update is available." + Environment.NewLine + "This update requires an automatic restart of this software.")
    '            Else
    '                If MsgBox("An optional update is available. Download now?" + Environment.NewLine + "This update requires an automatic restart of this software.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then doupdate = False
    '            End If

    '            If doupdate Then
    '                MsgBox("The updates are being downloaded. Please wait..." + Environment.NewLine + "Depending on the speed of your internet connection this may take several minutes")
    '                Me.Enabled = False
    '                ad.Update()
    '                MsgBox("Update successfully downloaded. The application will now restart.")
    '                System.Windows.Forms.Application.Restart()
    '            End If
    '        Catch exp As Exception
    '            MsgBox("Error: " + Err.Description + Environment.NewLine + "Error number:  " + Err.Number.ToString + Environment.NewLine + Environment.NewLine + "Please submit this error to the FullForce Development team using the online error reporting system.")
    '        End Try
    '    End Sub

    '    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
    '        frmHelp.Show()
    '    End Sub

    '    Private Sub HToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HToolStripMenuItem.Click
    '        'Opens the developer mode login form.
    '        frmDevLogin.Show()
    '    End Sub

    '    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
    '        'Calls the event which will begin calculations. (Calculate Buton)
    '        BodyCompositionCalculate()
    '    End Sub

    '    Private Sub RestartApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartApplicationToolStripMenuItem.Click
    '        System.Windows.Forms.Application.Restart()
    '    End Sub

    '    Private Sub TestResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestResultsToolStripMenuItem.Click
    '        BodyCompositionCalculate()
    '    End Sub

    '    Private Sub OpenProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProfileToolStripMenuItem.Click
    '        'Shows the result dialog.
    '        frmTempResults.Show()
    '        frmTempResults.DemoOutputBox.Text = "Click the open button to open and view your profile."
    '    End Sub
    '    Private Sub CheckForUpdatesDialogDevelopmentalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesDialogDevelopmentalToolStripMenuItem.Click
    '        frmUpdate.Show()
    '    End Sub
    '    Private Sub SettingsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem1.Click
    '        'Opens the settings dialog.
    '        frmDevSettings.Show()
    '    End Sub
    '    Private Sub ContactFullForceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactFullForceToolStripMenuItem.Click
    '        Process.Start("http://www.fullforceapps.com/?q=contact")
    '    End Sub
    '    Public Sub BodyCompositionCalculate()
    '        'Catches the error and keeps the application from crashing.
    '        Try
    '            'Changes Statusbar text to "Calculating"
    '            Me.StatusLabel.Text = "Calculating..."
    '            'Set up all global settings
    '            'The following are unchanging.
    '            My.Settings.name = Me.NameBox.Text
    '            My.Settings.age = Me.AgeBox.Text
    '            My.Settings.Thigh = Me.ThighBox.Text
    '            My.Settings.heightfoot = Me.NumericUpDown1.Value
    '            My.Settings.heightinch = Me.NumericUpDown2.Value
    '            My.Settings.weight = Me.TextBox1.Text

    '            'Figure out what activity level and set the setting as such.
    '            If ActivityDropDown.Text = "Sedentary" Then My.Settings.activitiylevel = "Sedentary"
    '            If ActivityDropDown.Text = "Lightly Active" Then My.Settings.activitiylevel = "Lightly Active"
    '            If ActivityDropDown.Text = "Moderately Active" Then My.Settings.activitiylevel = "Moderately Active"
    '            If ActivityDropDown.Text = "Highly Active" Then My.Settings.activitiylevel = "Highly Active"

    '            'All of these apply to 7 skinfolds
    '            If GenSkin = "7Male" Or GenSkin = "7Fem" Then My.Settings.Abdominal = Me.AbBox.Text
    '            If GenSkin = "7Male" Or GenSkin = "7Fem" Then My.Settings.Triceps = Me.TriBox.Text
    '            If GenSkin = "7Male" Or GenSkin = "7Fem" Then My.Settings.Chest = Me.ChestBox.Text
    '            If GenSkin = "7Male" Or GenSkin = "7Fem" Then My.Settings.Midauxillary = Me.MidBox.Text
    '            If GenSkin = "7Male" Or GenSkin = "7Fem" Then My.Settings.Subscapular = Me.SubBox.Text
    '            If GenSkin = "7Male" Or GenSkin = "7Fem" Then My.Settings.Suprailiac = Me.SupBox.Text

    '            'These Apply to 3Fem
    '            If GenSkin = "3Fem" Then Me.AbBox.Text = My.Settings.Abdominal
    '            If GenSkin = "3Fem" Then Me.ChestBox.Text = My.Settings.Chest

    '            'These apply to 3Male
    '            If GenSkin = "3Male" Then Me.TriBox.Text = My.Settings.Triceps
    '            If GenSkin = "3Male" Then Me.SupBox.Text = My.Settings.Suprailiac



    '            'Figure out which equation and Add Up All the Measurements
    '            If GenSkin = "7Male" Then Addition = My.Settings.Abdominal + My.Settings.Chest + My.Settings.Midauxillary + My.Settings.Subscapular + My.Settings.Suprailiac + My.Settings.Thigh + My.Settings.Triceps
    '            If GenSkin = "7Fem" Then Addition = My.Settings.Abdominal + My.Settings.Chest + My.Settings.Midauxillary + My.Settings.Subscapular + My.Settings.Suprailiac + My.Settings.Thigh + My.Settings.Triceps
    '            If GenSkin = "3Male" Then Addition = My.Settings.Abdominal + My.Settings.Chest + My.Settings.Thigh
    '            If GenSkin = "3Fem" Then Addition = My.Settings.Suprailiac + My.Settings.Thigh + My.Settings.Triceps

    '            'Next put it in the equation.
    '            If GenSkin = "7Male" Then My.Settings.bodydense = 1.112 - 0.00043499 * Addition + 0.00000055 * (Addition ^ 2) - 0.00028826 * My.Settings.age
    '            If GenSkin = "7Fem" Then My.Settings.bodydense = 1.097 - 0.00046971 * Addition + 0.00000056 * (Addition ^ 2) - 0.00012828 * My.Settings.age
    '            If GenSkin = "3Fem" Then My.Settings.bodydense = 1.099421 - 0.0009929 * Addition + 0.0000023 * (Addition ^ 2) - 0.0001392 * My.Settings.age
    '            If GenSkin = "3Male" Then My.Settings.bodydense = 1.10938 - 0.0008267 * Addition + 0.0000016 * (Addition ^ 2) - 0.0002574 * My.Settings.age

    '            'Finally, figure out the Body Fat Percentage and "print" it.
    '            'This is using the Siri equation.
    '            My.Settings.fatpercent = (495 / My.Settings.bodydense) - 450

    '            'Determine Fat & Fat Free Masses
    '            My.Settings.fatmass = My.Settings.weight * (My.Settings.fatpercent / 100)
    '            My.Settings.fatfreemass = My.Settings.weight - My.Settings.fatmass

    '            'Determine what Body Fat Classificiation user fits into
    '            Dim classif As String = ""
    '            If My.Settings.gender = "Female" And My.Settings.fatpercent <= "11.9" Then classif = "You have a very low body fat level. Additional weight reduction is not recommended."
    '            If My.Settings.gender = "Male" And My.Settings.fatpercent <= "5.9" Then classif = "You have a very low body fat level. Additional weight reduction is not recommended."
    '            If My.Settings.gender = "Female" And My.Settings.fatpercent <= "15.9" AndAlso My.Settings.fatpercent >= "12.0" Then classif = "You have a low body fat level. Adding muscle mass is recommended as an alternative to weight loss."
    '            If My.Settings.gender = "Male" And My.Settings.fatpercent <= "11.9" AndAlso My.Settings.fatpercent >= "6.0" Then classif = "You have a low body fat level. Adding muscle mass is recommended as an alternative to weight loss."
    '            If My.Settings.gender = "Female" And My.Settings.fatpercent <= "25.9" AndAlso My.Settings.fatpercent >= "16.0" Then classif = "You have a moderate body fat level. This is near optimal. At most, minor weight reduction is recommended."
    '            If My.Settings.gender = "Male" And My.Settings.fatpercent <= "18.9" AndAlso My.Settings.fatpercent >= "12.0" Then classif = "You have a moderate body fat level. This is near optimal. At most, minor weight reduction is recommended."
    '            If My.Settings.gender = "Female" And My.Settings.fatpercent <= "31.9" AndAlso My.Settings.fatpercent >= "26.0" Then classif = "You have a 'potential risk' body fat level. This means that you are beginning to place extra strain on your heart and joints. Weight loss is recommended."
    '            If My.Settings.gender = "Male" And My.Settings.fatpercent <= "24.9" AndAlso My.Settings.fatpercent >= "19.0" Then classif = "You have a 'potential risk' body fat level. This means that you are beginning to place extra strain on your heart and joints. Weight loss is recommended."
    '            If My.Settings.gender = "Female" And My.Settings.fatpercent >= "32.0" Then classif = "You are at the Obese body fat level. Continuing to live at this level could prove hazardous to your overall health. Weight loss is strongly recommended."
    '            If My.Settings.gender = "Male" And My.Settings.fatpercent >= "25.0" Then classif = "You are at the Obese body fat level. Continuing to live at this level could prove hazardous to your overall health. Weight loss is strongly recommended."

    '            'Figure out how large the Fat Engergy Store is
    '            My.Settings.fatenergystore = My.Settings.fatmass * 3500

    '            'Calculate BMR (explained in text below).
    '            Dim BMR As Decimal
    '            Dim heightCM As Decimal
    '            Dim weightKG
    '            Dim AcMult As Decimal
    '            Dim AcWarn As String = ""
    '            heightCM = ((My.Settings.heightfoot * 12) + My.Settings.heightinch) * 2.54
    '            weightKG = My.Settings.weight / 2.2
    '            If My.Settings.gender = "Male" Then BMR = 66 + (13.7 * (weightKG)) + (5 * heightCM) - (6.8 * My.Settings.age)
    '            If My.Settings.gender = "Female" Then BMR = 655 + (9.6 * (weightKG)) + (1.8 * heightCM) - (4.7 * My.Settings.age)
    '            'Now, based on energy level, calculate the active caloric need.
    '            If My.Settings.activitiylevel = "Sedentary" Then AcMult = BMR * 1.2
    '            If My.Settings.activitiylevel = "Sedentary" Then AcWarn = "Due to the low activity level you have selected, it is recommended that you increase " + NewLine + "your activity level to maintain a healthy lifestyle."
    '            If My.Settings.activitiylevel = "Lightly Active" Then AcMult = BMR * 1.375
    '            If My.Settings.activitiylevel = "Moderately Active" Then AcMult = BMR * 1.55
    '            If My.Settings.activitiylevel = "Highly Active" Then AcMult = BMR * 1.725

    '            'Calculate the amount of calories burned doing certain activities.
    '            Dim bowling As Decimal
    '            Dim walking As Decimal
    '            Dim biking As Decimal
    '            Dim tennis As Decimal
    '            Dim basketball As Decimal
    '            Dim running As Decimal
    '            'Formula: *activity* = ((*METS* -based on chart, in order- * 3.5 * weightKG)/200) * 30
    '            bowling = ((3 * 3.5 * weightKG) / 200) * 30
    '            walking = ((4 * 3.5 * weightKG) / 200) * 30
    '            biking = ((5 * 3.5 * weightKG) / 200) * 30
    '            tennis = ((6 * 3.5 * weightKG) / 200) * 30
    '            basketball = ((7 * 3.5 * weightKG) / 200) * 30
    '            running = ((8 * 3.5 * weightKG) / 200) * 30

    '            'Calculate maximum heart rate.
    '            'Calcualtes the maximum heart rate.
    '            'Variables: 'mhrnoact' is the max heart rate before the activity level is considered; 'mhr' is the final max heart rate; 'actvar' is modifier based on activity level
    '            Dim mhrnoact As Integer
    '            Dim mhr As Integer
    '            Dim actvar As Integer
    '            If My.Settings.activitiylevel = "Sedentary" Then actvar = -5
    '            If My.Settings.activitiylevel = "Lightly Active" Then actvar = 0
    '            If My.Settings.activitiylevel = "Moderately Active" Then actvar = 5
    '            If My.Settings.activitiylevel = "Highly Active" Then actvar = 10
    '            mhrnoact = 205 - (My.Settings.age / 2)
    '            mhr = mhrnoact + actvar
    '            If mhr < 0 Then mhr = 0

    '            'Opens the results dialog.
    '            frmTempResults.Show()
    '            'Inserts the text into the output box and displays the varibles.
    '            'Notes:
    '            'Any variables with numerals must follow this style. CStr(The variable)
    '            'To break a line of text insert  + NewLine +
    '            frmTempResults.DemoOutputBox.Text = "Name: " + My.Settings.name + NewLine + _
    '            "You are a " + My.Settings.gender + ", and you are " + CStr(My.Settings.age) + " years of age." + NewLine + NewLine + _
    '            "You have " + Math.Round(My.Settings.fatpercent, 2).ToString + "% body fat." + NewLine + NewLine + _
    '            "Your body composition statistics:" + NewLine + _
    '            "   Height: " + CStr(My.Settings.heightfoot) + " feet " + CStr(My.Settings.heightinch) + " inches " + NewLine + _
    '            "   Weight: " + CStr(My.Settings.weight) + " pounds " + NewLine + _
    '            "   Abdominal: " + CStr(My.Settings.Abdominal) + "mm " + NewLine + _
    '            "   Triceps: " + CStr(My.Settings.Triceps) + "mm " + NewLine + _
    '            "   Chest: " + CStr(My.Settings.Chest) + "mm " + NewLine + _
    '            "   Midauxillary: " + CStr(My.Settings.Midauxillary) + "mm " + NewLine + _
    '            "   Subscapular: " + CStr(My.Settings.Subscapular) + "mm " + NewLine + _
    '            "   Suprailic: " + CStr(My.Settings.Suprailiac) + "mm " + NewLine + _
    '            "   Thigh: " + CStr(My.Settings.Thigh) + "mm " + NewLine + NewLine + _
    '            "Of your total body weight:" + NewLine + _
    '            "   " + Math.Round(My.Settings.fatmass, 2).ToString + " lbs. is fat weight." + NewLine + _
    '            "   " + Math.Round(My.Settings.fatfreemass, 2).ToString + " lbs. is lean body mass. (i.e. muscle and other tissues)" + NewLine + NewLine + _
    '            classif.ToString + NewLine + NewLine + _
    '            "Your fat energy store is about " + Math.Round(My.Settings.fatenergystore, 0).ToString + " calories." + NewLine + "This is the number of calories stored in your fat cells." + NewLine + NewLine + _
    '            "Your basal metabolic rate is " + Math.Round(BMR, 0).ToString + " calories." + NewLine + "BMR is the calculation of the number of calories required to sustian your body's vital functions." + NewLine + NewLine + _
    '            "The activity level you selected was " + My.Settings.activitiylevel + ". " + NewLine + AcWarn + NewLine + NewLine + _
    '            "Based on your activity level, your active caloric intake should be " + Math.Round(AcMult, 0).ToString + " calories." + NewLine + "This provides a more realistic estimate of your caloric need than BMR." + NewLine + NewLine + _
    '            "Exercise is critical to your overall heatlth. Performing some form of exercise for at least " + NewLine + "30 minutes three times a week is ideal. There are plenty of activities for you to choose " + NewLine + "from. Below are listed some activites, along with how many calories you'll burn." + NewLine + _
    '            "   Bowling:  " + Math.Round(bowling, 0).ToString + " calories." + NewLine + _
    '            "   Walking:  " + Math.Round(walking, 0).ToString + " calories (at 3 mph)." + NewLine + _
    '            "   Biking:  " + Math.Round(biking, 0).ToString + " calories (at 10 mph)." + NewLine + _
    '            "   Singles Tennis:  " + Math.Round(tennis, 0).ToString + " calories." + NewLine + _
    '            "   Basketball:  " + Math.Round(basketball, 0).ToString + " calories." + NewLine + _
    '            "   Running:  " + Math.Round(running, 0).ToString + " calories (at 5.5 mph)." + NewLine + NewLine + _
    '            "Your maximum heart rate is " + mhr.ToString + " beats per minute."

    '        Catch exp As Exception
    '            MsgBox("Error Number: " + Err.Number + Environment.NewLine + "Error Description: " + Err.Description + Environment.NewLine + "Please complete all fields to continue.")
    '        End Try

    '        'MsgBox
    '        'Resets the status text.
    '        Me.StatusLabel.Text = "Ready"
    '    End Sub

    '    'No functional code will go below this line. This is for eastereggs only...

    Private Sub RestartApplicationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartApplicationToolStripMenuItem1.Click
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub TestOutpotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestOutpotToolStripMenuItem.Click
        frmTempResults.Show()
    End Sub

    Private Sub MD5HashGeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5HashGeneratorToolStripMenuItem.Click
        frmMD5Hasher.Show()
    End Sub

    Private Sub CheckRegistryKeysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRegistryKeysToolStripMenuItem.Click
        'Try
        '    MsgBox("Checking activation keys:   " + "OK!" + Environment.NewLine + "Registry Key Path:   " + "HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC\FullForce PAS" + Environment.NewLine + "Registry Key Value:   " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC", "FullForce PAS", Nothing), MsgBoxStyle.Information)
        'Catch ex As Exception
        '    MsgBox("Checking activation keys:   " + "Failed!" + Environment.NewLine + "Error Number:   " + Err.Number.ToString + Environment.NewLine + "Error Description:   " + Err.Description + Environment.NewLine + Environment.NewLine + "In English Please!!!:   " + "The registry key does not exist.", MsgBoxStyle.Exclamation)
        'End Try
        Dim activation As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC", "FullForce PAS", Nothing)
        If activation = "213FD3E4843C4FC611377485354B1BA4" Then
            MsgBox("Checking activation keys:   " + "OK!" + Environment.NewLine + "Registry Key Path:   " + "HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC\FullForce PAS" + Environment.NewLine + "Registry Key Value:   " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC", "FullForce PAS", Nothing), MsgBoxStyle.Information)
        Else
            MsgBox("Checking activation keys:   " + "Failed!" + Environment.NewLine + "Error Number:   " + Err.Number.ToString + Environment.NewLine + "Error Description:   " + Err.Description + Environment.NewLine + Environment.NewLine + "In English Please!!!:   " + "The registry key does not exist.", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub frmDevMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("NOTICE!!!" + Environment.NewLine + "Developer Mode is severely out of date." + Environment.NewLine + " All functions have been disabled except for the developer console.", MsgBoxStyle.Information)
    End Sub

    Private Sub DeleteActivationKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteActivationKeyToolStripMenuItem.Click
        Try
            'Deletes the key (and all contained values). To only delete the BCC subkey, comment out the second code line.
            Registry.LocalMachine.DeleteSubKey("SOFTWARE\FullForce Applications\BCC")
            Registry.LocalMachine.DeleteSubKey("SOFTWARE\FullForce Applications")
            MsgBox("The registry key has been successfully deleted." + Environment.NewLine + "The program is no longer activated and will ask for reactivation upon startup." + Environment.NewLine + "The program will now restart to apply the changes.", MsgBoxStyle.Information)
            System.Windows.Forms.Application.Restart()
        Catch ex As Exception
            MsgBox("ERROR! The key you tried to delete does not exist.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

#Region " Write to Registry Function "
    Public Function WriteToRegistry(ByVal _
ParentKeyHive As RegistryHive, _
ByVal SubKeyName As String, _
ByVal ValueName As String, _
ByVal Value As Object) As Boolean


        Dim objSubKey As RegistryKey
        Dim sException As String
        Dim objParentKey As RegistryKey
        Dim bAns As Boolean


        Try

            Select Case ParentKeyHive
                Case RegistryHive.ClassesRoot
                    objParentKey = Registry.ClassesRoot
                Case RegistryHive.CurrentConfig
                    objParentKey = Registry.CurrentConfig
                Case RegistryHive.CurrentUser
                    objParentKey = Registry.CurrentUser
                Case RegistryHive.DynData
                    objParentKey = Registry.DynData
                Case RegistryHive.LocalMachine
                    objParentKey = Registry.LocalMachine
                Case RegistryHive.PerformanceData
                    objParentKey = Registry.PerformanceData
                Case RegistryHive.Users
                    objParentKey = Registry.Users

            End Select


            'Open 
            objSubKey = objParentKey.OpenSubKey(SubKeyName, True)
            'create if doesn't exist
            If objSubKey Is Nothing Then
                objSubKey = objParentKey.CreateSubKey(SubKeyName)
            End If


            objSubKey.SetValue(ValueName, Value)
            bAns = True
        Catch ex As Exception
            bAns = False

        End Try

        Return True

    End Function
#End Region

    Private Sub WriteActivationKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteActivationKeyToolStripMenuItem.Click
        'Writes the key to the subkey noted.
        WriteToRegistry(RegistryHive.LocalMachine, "SOFTWARE\FullForce Applications\BCC", "FullForce PAS", "213FD3E4843C4FC611377485354B1BA4")
        MsgBox("The registry key has been successfully written." + Environment.NewLine + "The program is now activated!" + Environment.NewLine + "The program will now restart to apply the changes.", MsgBoxStyle.Information)
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub CheckRegistryKeysToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRegistryKeysToolStripMenuItem1.Click
        Try
            MsgBox("Checking welcome keys:   " + "OK!" + Environment.NewLine + "Registry Key Path:   " + "HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC\Welcome Center" + Environment.NewLine + "Registry Key Value:   " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\FullForce Applications\BCC", "Wecome Center", Nothing).ToString, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Checking welcome keys:   " + "Failed!" + Environment.NewLine + "Error Number:   " + Err.Number.ToString + Environment.NewLine + "Error Description:   " + Err.Description + Environment.NewLine + Environment.NewLine + "In English Please!!!:   " + "The registry key does not exist.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmGUIDGen.Show()
    End Sub
End Class