Imports System.Environment

Public Class classCalc
    Dim classif As String = ""
    Public Sub BMICalc()
        'Start the error handling system.
        Try
            'Changes Statusbar text to "Calculating"
            frmMain.StatusLabel.Text = "Calculating..."

            'Set up all global settings
            'The following are unchanging.
            My.Settings.name = frmMain.NameBox.Text
            My.Settings.age = frmMain.AgeBox.Text
            My.Settings.weight = frmMain.WeightBox.Text

            'Define height variables.
            My.Settings.heightfoot = Convert.ToDecimal(frmMain.HeightFTNumUpDown.Value)
            My.Settings.heightinch = Convert.ToDecimal(frmMain.HeightINNumUpDown.Value)
            'Convert feet to proper format and add value to inches and set a value for height..
            My.Settings.height = Convert.ToDecimal((frmMain.HeightFTNumUpDown.Value * 12 + frmMain.HeightINNumUpDown.Value))

            'Define bmi variable.
            Dim bmi As Decimal
            bmi = Convert.ToDecimal(703 * (My.Settings.weight / My.Settings.height ^ 2))
            My.Settings.bmi = bmi

            'Determine BMI Classification.
            If bmi <= 18.4 Then
                classif = "You are in the Underweight BMI classification. Adding body mass is recommended."
            ElseIf bmi <= 24.9 And bmi >= 18.5 Then
                classif = "You are in the Normal BMI classification. This is normally the most ideal classification level."
            ElseIf bmi <= 29.9 AndAlso bmi >= 25.0 Then
                'Very very long. Probably needs clean line breaks.
                classif = "You are in the Overweight BMI classification. Depending on your build, you may or may not be over-fat. We strongly recommend you use another method of measurement for more accurate results."
            ElseIf bmi >= 30.0 Then
                classif = "You are in the Obese BMI classification. While there is a chance you may not be over-fat, weight reduction is recommended."
            End If
            My.Settings.classifv = classif

            GeneralCalc()

        Catch When Err.Number = 13 'Type Mismatch (Fields not completed)
            MsgBox("Please fill out all of the necessary fields to continue.", MsgBoxStyle.Information)
        Catch
            MsgBox("An error has occured!" + NewLine + "Error Number: " + Err.Number.ToString + NewLine + "Error Description: " + Err.Description, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub SkinCalc()
        'Start the error handling system.
        Try
            'Changes Statusbar text to "Calculating"
            frmMain.StatusLabel.Text = "Calculating..."
            'Set up all global settings
            'The following are unchanging.
            My.Settings.name = frmMain.NameBox.Text
            My.Settings.age = Convert.ToInt32(frmMain.AgeBox.Text)
            My.Settings.thigh = frmMain.ThighBox.Text
            My.Settings.height = (frmMain.HeightFTNumUpDown.Value * 12 + frmMain.HeightINNumUpDown.Value)
            My.Settings.heightfoot = frmMain.HeightFTNumUpDown.Value
            My.Settings.heightinch = frmMain.HeightINNumUpDown.Value
            My.Settings.weight = Convert.ToInt32(frmMain.WeightBox.Text)


            'All of these apply to 7 skinfolds
            If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then
                My.Settings.abdominal = frmMain.AbBox.Text
                My.Settings.triceps = frmMain.TriBox.Text
                My.Settings.chest = frmMain.ChestBox.Text
                My.Settings.midauxillary = frmMain.MidBox.Text
                My.Settings.subscapular = frmMain.SubBox.Text
                My.Settings.Suprailiac = frmMain.SupBox.Text
            End If

            If My.Settings.genskinv = "3Male" Then
                My.Settings.abdominal = frmMain.AbBox.Text
                My.Settings.chest = frmMain.ChestBox.Text
            End If


            If My.Settings.genskinv = "3Fem" Then
                My.Settings.triceps = frmMain.TriBox.Text
                My.Settings.Suprailiac = frmMain.SupBox.Text
            End If

            'Figure out which equation and Add Up All the Measurements
            Dim addition As Integer
            If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then addition = My.Settings.abdominal + My.Settings.chest + My.Settings.midauxillary + My.Settings.subscapular + My.Settings.Suprailiac + My.Settings.thigh + My.Settings.triceps
            If My.Settings.genskinv = "3Male" Then addition = My.Settings.abdominal + My.Settings.chest + My.Settings.thigh
            If My.Settings.genskinv = "3Fem" Then addition = My.Settings.Suprailiac + My.Settings.thigh + My.Settings.triceps

            'Next put it in the equation.
            If My.Settings.genskinv = "7Male" Then My.Settings.bodydense = 1.112 - 0.00043499 * addition + 0.00000055 * (addition ^ 2) - 0.00028826 * My.Settings.age
            If My.Settings.genskinv = "7Fem" Then My.Settings.bodydense = 1.097 - 0.00046971 * addition + 0.00000056 * (addition ^ 2) - 0.00012828 * My.Settings.age
            If My.Settings.genskinv = "3Fem" Then My.Settings.bodydense = 1.099421 - 0.0009929 * addition + 0.0000023 * (addition ^ 2) - 0.0001392 * My.Settings.age
            If My.Settings.genskinv = "3Male" Then My.Settings.bodydense = 1.10938 - 0.0008267 * addition + 0.0000016 * (addition ^ 2) - 0.0002574 * My.Settings.age

            'Finally, figure out the Body Fat Percentage and "print" it.
            'This is using the Siri equation.
            My.Settings.fatpercent = (495 / My.Settings.bodydense) - 450

            'Determine Fat & Fat Free Masses
            My.Settings.fatmass = My.Settings.weight * (My.Settings.fatpercent / 100)
            My.Settings.fatfreemass = My.Settings.weight - My.Settings.fatmass

            'Determine what Body Fat Classificiation user fits into
            If My.Settings.gender = "Male" Then
                If My.Settings.fatpercent <= "5.9" Then
                    classif = "You have a very low body fat level. Additional weight reduction is not recommended."
                ElseIf My.Settings.fatpercent <= "11.9" AndAlso My.Settings.fatpercent >= "6.0" Then
                    classif = "You have a low body fat level. Adding muscle mass is recommended as an alternative to weight loss."
                ElseIf My.Settings.fatpercent <= "18.9" AndAlso My.Settings.fatpercent >= "12.0" Then
                    classif = "You have a moderate body fat level. This is near optimal. At most, minor weight reduction is recommended."
                ElseIf My.Settings.fatpercent <= "24.9" AndAlso My.Settings.fatpercent >= "19.0" Then
                    classif = "You have a 'potential risk' body fat level. This means that you are beginning to place extra strain on your heart and joints. Weight loss is recommended."
                ElseIf My.Settings.fatpercent >= "25.0" Then
                    classif = "You are at the Obese body fat level. Continuing to live at this level could prove hazardous to your overall health. Weight loss is strongly recommended."
                End If
            ElseIf My.Settings.gender = "Female" Then
                If My.Settings.fatpercent <= "11.9" Then
                    classif = "You have a very low body fat level. Additional weight reduction is not recommended."
                ElseIf My.Settings.fatpercent <= "15.9" AndAlso My.Settings.fatpercent >= "12.0" Then
                    classif = "You have a low body fat level. Adding muscle mass is recommended as an alternative to weight loss."
                ElseIf My.Settings.fatpercent <= "25.9" AndAlso My.Settings.fatpercent >= "16.0" Then
                    classif = "You have a moderate body fat level. This is near optimal. At most, minor weight reduction is recommended."
                ElseIf My.Settings.fatpercent <= "31.9" AndAlso My.Settings.fatpercent >= "26.0" Then
                    classif = "You have a 'potential risk' body fat level. This means that you are beginning to place extra strain on your heart and joints. Weight loss is recommended."
                ElseIf My.Settings.fatpercent >= "32.0" Then
                    classif = "You are at the Obese body fat level. Continuing to live at this level could prove hazardous to your overall health. Weight loss is strongly recommended."
                End If
            End If
            My.Settings.classifv = classif

            'Figure out how large the Fat Engergy Store is
            My.Settings.fatenergystore = My.Settings.fatmass * 3500

            GeneralCalc()

        Catch When Err.Number = 13 'Type Mismatch (Fields not completed)
            MsgBox("Please fill out all of the necessary fields to continue.", MsgBoxStyle.Information)
        Catch
            MsgBox("An error has occured!" + NewLine + "Error Number: " + Err.Number.ToString + NewLine + "Error Description: " + Err.Description, MsgBoxStyle.Information)
        End Try

    End Sub
    Dim oclass As New BodyComp.classOutput
    Public Sub GeneralCalc()
        'This sub performs calculations occuring in both the BMI and Skinfold routines.

        'Figure out what activity level and set the setting as such.
        If frmMain.ActivityDropDown.Text = "Sedentary" Then My.Settings.activitiylevel = "s"
        If frmMain.ActivityDropDown.Text = "Lightly Active" Then My.Settings.activitiylevel = "l"
        If frmMain.ActivityDropDown.Text = "Moderately Active" Then My.Settings.activitiylevel = "m"
        If frmMain.ActivityDropDown.Text = "Highly Active" Then My.Settings.activitiylevel = "h"

        'Calculate BMR (explained in text below).
        Dim BMR As Decimal
        Dim heightCM As Decimal
        Dim weightKG As Decimal
        Dim ACR As Decimal
        Dim AcWarn As Boolean
        heightCM = My.Settings.height * 2.54
        weightKG = My.Settings.weight / 2.2
        If My.Settings.gender = "Male" Then BMR = 66 + (13.7 * (weightKG)) + (5 * heightCM) - (6.8 * My.Settings.age)
        If My.Settings.gender = "Female" Then BMR = 655 + (9.6 * (weightKG)) + (1.8 * heightCM) - (4.7 * My.Settings.age)
        'Now, based on energy level, calculate the active caloric need.
        If My.Settings.activitiylevel = "s" Then
            ACR = BMR * 1.2
            AcWarn = True
        End If
        If My.Settings.activitiylevel = "l" Then ACR = BMR * 1.375
        If My.Settings.activitiylevel = "m" Then ACR = BMR * 1.55
        If My.Settings.activitiylevel = "h" Then ACR = BMR * 1.725
        My.Settings.bmrv = BMR
        My.Settings.acr = ACR
        My.Settings.acwarn = AcWarn

        'Calculate the amount of calories burned doing certain activities.
        Dim bowling As Decimal
        Dim walking As Decimal
        Dim biking As Decimal
        Dim tennis As Decimal
        Dim basketball As Decimal
        Dim running As Decimal
        'Formula: *activity* = ((*METS* -based on chart, in order- * 3.5 * weightKG)/200) * 30
        bowling = ((3 * 3.5 * weightKG) / 200) * 30
        walking = ((4 * 3.5 * weightKG) / 200) * 30
        biking = ((5 * 3.5 * weightKG) / 200) * 30
        tennis = ((6 * 3.5 * weightKG) / 200) * 30
        basketball = ((7 * 3.5 * weightKG) / 200) * 30
        running = ((8 * 3.5 * weightKG) / 200) * 30

        'Set up the settings for the activities.
        My.Settings.bowlingv = bowling
        My.Settings.walkv = walking
        My.Settings.bikev = biking
        My.Settings.tennisv = tennis
        My.Settings.bballv = basketball
        My.Settings.runv = running

        'Calculate maximum heart rate.
        'Calcualtes the maximum heart rate.
        'Variables: 'mhrnoact' is the max heart rate before the activity level is considered; 'mhr' is the final max heart rate; 'actvar' is modifier based on activity level
        Dim mhrnoact As Integer
        Dim mhr As Integer
        Dim actvar As Integer
        If My.Settings.activitiylevel = "s" Then
            actvar = -5
        ElseIf My.Settings.activitiylevel = "l" Then
            actvar = 0
        ElseIf My.Settings.activitiylevel = "m" Then
            actvar = 5
        ElseIf My.Settings.activitiylevel = "h" Then
            actvar = 10
        End If
        mhrnoact = 205 - (My.Settings.age / 2)
        mhr = mhrnoact + actvar
        If mhr < 0 Then mhr = 0
        My.Settings.mhrv = mhr

        'Jumps to output class.
        oclass.CreateOutput()
    End Sub
    'Public Sub BMICalculate()

    ''Public Sub BMICalculate()

    ''    MsgBox("The BMICalculate Sub has been activated inside another class.")
    ''End Sub

    ''Dim addition As Integer
    ''Public Sub SkinfoldCalculate()

    ''    'Catches the error and keeps the application from crashing.
    ''    Try
    ''        'Changes Statusbar text to "Calculating"
    ''        frmMain.StatusLabel.Text = "Calculating..."
    ''        'Set up all global settings
    ''        'The following are unchanging.
    ''        My.Settings.name = frmMain.NameBox.Text
    ''        My.Settings.age = frmMain.AgeBox.Text
    ''        My.Settings.Thigh = frmMain.ThighBox.Text
    ''        My.Settings.heightfoot = frmMain.HeightFTNumUpDown.Value
    ''        My.Settings.heightinch = frmMain.HeightINNumUpDown.Value
    ''        My.Settings.weight = frmMain.WeightBox.Text

    ''        'Figure out what activity level and set the setting as such.
    ''        If frmMain.ActivityDropDown.Text = "Sedentary" Then My.Settings.activitiylevel = "Sedentary"
    ''        If frmMain.ActivityDropDown.Text = "Lightly Active" Then My.Settings.activitiylevel = "Lightly Active"
    ''        If frmMain.ActivityDropDown.Text = "Moderately Active" Then My.Settings.activitiylevel = "Moderately Active"
    ''        If frmMain.ActivityDropDown.Text = "Highly Active" Then My.Settings.activitiylevel = "Highly Active"

    ''        'All of these apply to 7 skinfolds
    ''        If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then My.Settings.Abdominal = frmMain.AbBox.Text
    ''        If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then My.Settings.Triceps = frmMain.TriBox.Text
    ''        If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then My.Settings.Chest = frmMain.ChestBox.Text
    ''        If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then My.Settings.Midauxillary = frmMain.MidBox.Text
    ''        If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then My.Settings.Subscapular = frmMain.SubBox.Text
    ''        If My.Settings.genskinv = "7Male" Or My.Settings.genskinv = "7Fem" Then My.Settings.Suprailiac = frmMain.SupBox.Text

    ''        'These Apply to 3Fem
    ''        If My.Settings.genskinv = "3Fem" Then frmMain.AbBox.Text = My.Settings.Abdominal
    ''        If My.Settings.genskinv = "3Fem" Then frmMain.ChestBox.Text = My.Settings.Chest

    ''        'These apply to 3Male
    ''        If My.Settings.genskinv = "3Male" Then frmMain.TriBox.Text = My.Settings.Triceps
    ''        If My.Settings.genskinv = "3Male" Then frmMain.SupBox.Text = My.Settings.Suprailiac



    ''        'Figure out which equation and Add Up All the Measurements
    ''        If My.Settings.genskinv = "7Male" Then addition = My.Settings.Abdominal + My.Settings.Chest + My.Settings.Midauxillary + My.Settings.Subscapular + My.Settings.Suprailiac + My.Settings.Thigh + My.Settings.Triceps
    ''        If My.Settings.genskinv = "7Fem" Then addition = My.Settings.Abdominal + My.Settings.Chest + My.Settings.Midauxillary + My.Settings.Subscapular + My.Settings.Suprailiac + My.Settings.Thigh + My.Settings.Triceps
    ''        If My.Settings.genskinv = "3Male" Then addition = My.Settings.Abdominal + My.Settings.Chest + My.Settings.Thigh
    ''        If My.Settings.genskinv = "3Fem" Then addition = My.Settings.Suprailiac + My.Settings.Thigh + My.Settings.Triceps

    ''        'Next put it in the equation.
    ''        If My.Settings.genskinv = "7Male" Then My.Settings.bodydense = 1.112 - 0.00043499 * addition + 0.00000055 * (addition ^ 2) - 0.00028826 * My.Settings.age
    ''        If My.Settings.genskinv = "7Fem" Then My.Settings.bodydense = 1.097 - 0.00046971 * addition + 0.00000056 * (addition ^ 2) - 0.00012828 * My.Settings.age
    ''        If My.Settings.genskinv = "3Fem" Then My.Settings.bodydense = 1.099421 - 0.0009929 * addition + 0.0000023 * (addition ^ 2) - 0.0001392 * My.Settings.age
    ''        If My.Settings.genskinv = "3Male" Then My.Settings.bodydense = 1.10938 - 0.0008267 * addition + 0.0000016 * (addition ^ 2) - 0.0002574 * My.Settings.age

    ''        'Finally, figure out the Body Fat Percentage and "print" it.
    ''        'This is using the Siri equation.
    ''        My.Settings.fatpercent = (495 / My.Settings.bodydense) - 450

    ''        'Determine Fat & Fat Free Masses
    ''        My.Settings.fatmass = My.Settings.weight * (My.Settings.fatpercent / 100)
    ''        My.Settings.fatfreemass = My.Settings.weight - My.Settings.fatmass

    ''        'Determine what Body Fat Classificiation user fits into
    ''        Dim classif As String = ""
    ''        If My.Settings.gender = "Female" And My.Settings.fatpercent <= "11.9" Then classif = "You have a very low body fat level. Additional weight reduction is not recommended."
    ''        If My.Settings.gender = "Male" And My.Settings.fatpercent <= "5.9" Then classif = "You have a very low body fat level. Additional weight reduction is not recommended."
    ''        If My.Settings.gender = "Female" And My.Settings.fatpercent <= "15.9" AndAlso My.Settings.fatpercent >= "12.0" Then classif = "You have a low body fat level. Adding muscle mass is recommended as an alternative to weight loss."
    ''        If My.Settings.gender = "Male" And My.Settings.fatpercent <= "11.9" AndAlso My.Settings.fatpercent >= "6.0" Then classif = "You have a low body fat level. Adding muscle mass is recommended as an alternative to weight loss."
    ''        If My.Settings.gender = "Female" And My.Settings.fatpercent <= "25.9" AndAlso My.Settings.fatpercent >= "16.0" Then classif = "You have a moderate body fat level. This is near optimal. At most, minor weight reduction is recommended."
    ''        If My.Settings.gender = "Male" And My.Settings.fatpercent <= "18.9" AndAlso My.Settings.fatpercent >= "12.0" Then classif = "You have a moderate body fat level. This is near optimal. At most, minor weight reduction is recommended."
    ''        If My.Settings.gender = "Female" And My.Settings.fatpercent <= "31.9" AndAlso My.Settings.fatpercent >= "26.0" Then classif = "You have a 'potential risk' body fat level. This means that you are beginning to place extra strain on your heart and joints. Weight loss is recommended."
    ''        If My.Settings.gender = "Male" And My.Settings.fatpercent <= "24.9" AndAlso My.Settings.fatpercent >= "19.0" Then classif = "You have a 'potential risk' body fat level. This means that you are beginning to place extra strain on your heart and joints. Weight loss is recommended."
    ''        If My.Settings.gender = "Female" And My.Settings.fatpercent >= "32.0" Then classif = "You are at the Obese body fat level. Continuing to live at this level could prove hazardous to your overall health. Weight loss is strongly recommended."
    ''        If My.Settings.gender = "Male" And My.Settings.fatpercent >= "25.0" Then classif = "You are at the Obese body fat level. Continuing to live at this level could prove hazardous to your overall health. Weight loss is strongly recommended."
    ''        My.Settings.classifsettings = classif
    ''        'Figure out how large the Fat Engergy Store is
    ''        My.Settings.fatenergystore = My.Settings.fatmass * 3500

    ''        'Calculate BMR (explained in text below).
    ''        Dim BMR As Decimal
    ''        Dim heightCM As Decimal
    ''        Dim weightKG
    ''        Dim AcMult As Decimal
    ''        Dim AcWarn As String = ""
    ''        heightCM = ((My.Settings.heightfoot * 12) + My.Settings.heightinch) * 2.54
    ''        weightKG = My.Settings.weight / 2.2
    ''        If My.Settings.gender = "Male" Then BMR = 66 + (13.7 * (weightKG)) + (5 * heightCM) - (6.8 * My.Settings.age)
    ''        If My.Settings.gender = "Female" Then BMR = 655 + (9.6 * (weightKG)) + (1.8 * heightCM) - (4.7 * My.Settings.age)
    ''        'Now, based on energy level, calculate the active caloric need.
    ''        If My.Settings.activitiylevel = "Sedentary" Then AcMult = BMR * 1.2
    ''        If My.Settings.activitiylevel = "Sedentary" Then AcWarn = "Due to the low activity level you have selected, it is recommended that you increase " + NewLine + "your activity level to maintain a healthy lifestyle."
    ''        If My.Settings.activitiylevel = "Lightly Active" Then AcMult = BMR * 1.375
    ''        If My.Settings.activitiylevel = "Moderately Active" Then AcMult = BMR * 1.55
    ''        If My.Settings.activitiylevel = "Highly Active" Then AcMult = BMR * 1.725
    ''        My.Settings.bmrsettings = BMR
    ''        My.Settings.acmultsettings = AcMult
    ''        My.Settings.acwarnsettings = AcWarn

    ''        'Calculate the amount of calories burned doing certain activities.
    ''        Dim bowling As Decimal
    ''        Dim walking As Decimal
    ''        Dim biking As Decimal
    ''        Dim tennis As Decimal
    ''        Dim basketball As Decimal
    ''        Dim running As Decimal
    ''        'Formula: *activity* = ((*METS* -based on chart, in order- * 3.5 * weightKG)/200) * 30
    ''        bowling = ((3 * 3.5 * weightKG) / 200) * 30
    ''        walking = ((4 * 3.5 * weightKG) / 200) * 30
    ''        biking = ((5 * 3.5 * weightKG) / 200) * 30
    ''        tennis = ((6 * 3.5 * weightKG) / 200) * 30
    ''        basketball = ((7 * 3.5 * weightKG) / 200) * 30
    ''        running = ((8 * 3.5 * weightKG) / 200) * 30

    ''        'Set up the settings for the activities.
    ''        My.Settings.bowlingsettings = bowling
    ''        My.Settings.walkingsettings = walking
    ''        My.Settings.bikingsettings = biking
    ''        My.Settings.tennissettings = tennis
    ''        My.Settings.bballsettings = basketball
    ''        My.Settings.runsettings = running

    ''        'Calculate maximum heart rate.
    ''        'Calcualtes the maximum heart rate.
    ''        'Variables: 'mhrnoact' is the max heart rate before the activity level is considered; 'mhr' is the final max heart rate; 'actvar' is modifier based on activity level
    ''        Dim mhrnoact As Integer
    ''        Dim mhr As Integer
    ''        Dim actvar As Integer
    ''        If My.Settings.activitiylevel = "Sedentary" Then actvar = -5
    ''        If My.Settings.activitiylevel = "Lightly Active" Then actvar = 0
    ''        If My.Settings.activitiylevel = "Moderately Active" Then actvar = 5
    ''        If My.Settings.activitiylevel = "Highly Active" Then actvar = 10
    ''        mhrnoact = 205 - (My.Settings.age / 2)
    ''        mhr = mhrnoact + actvar
    ''        If mhr < 0 Then mhr = 0
    ''        My.Settings.mhrsettings = mhr

    ''        'Begin generating the output by activating it through the external sub.
    ''        Dim obj2 As New BodyComp.classOutput
    ''        obj2.SkinfoldOutput()

    ''    Catch exp As Exception
    ''        MsgBox("Error: " + Err.Description + NewLine + "Error Number: " + "error number")
    ''    End Try
    ''End Sub
End Class
