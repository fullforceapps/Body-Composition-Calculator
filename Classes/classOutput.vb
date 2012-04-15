Imports System.Environment
Imports BodyComp.frmMain

Public Class classOutput

    Dim GInfoOutput As String
    Dim Moutput As String
    Dim Uoutput As String

    Public Sub CreateOutput()
        Try

            'Performs general information insertion.
            GInfoOutput = CStr("Name: ") + CStr(My.Settings.name) + NewLine + NewLine + CStr("Gender: ") + CStr(My.Settings.gender) + NewLine + CStr("Age: ") + CStr(My.Settings.age) + NewLine + _
            CStr("Height: ") + CStr(My.Settings.heightfoot) + CStr(" feet ") + CStr(My.Settings.heightinch) + CStr(" inches") + NewLine + _
            CStr("Weight: ") + CStr(My.Settings.weight) + CStr(" pounds") + NewLine + NewLine

            'Performs modal calculations.
            If frmMain.BMIRBtn.Checked = True Then
                'Performs BMI calculations.
                Moutput = CStr("You have a BMI of ") + Math.Round(My.Settings.bmi, 2).ToString + CStr(".") + NewLine + NewLine + My.Settings.classifv + NewLine + NewLine
            ElseIf frmMain.SkinfoldRBtn.Checked = True Then
                'Performs Skinfold calculations.
                Moutput = CStr("You have ") + Math.Round(My.Settings.fatpercent, 2).ToString + CStr("% body fat.") + NewLine + NewLine + _
                        CStr("Your body composition statistics:") + NewLine + _
                        CStr("   Abdominal: ") + CStr(My.Settings.abdominal) + CStr("mm ") + NewLine + _
                        CStr("   Triceps: ") + CStr(My.Settings.triceps) + CStr("mm ") + NewLine + _
                        CStr("   Chest: ") + CStr(My.Settings.chest) + CStr("mm ") + NewLine + _
                        CStr("   Midauxillary: ") + CStr(My.Settings.midauxillary) + CStr("mm ") + NewLine + _
                        CStr("   Subscapular: ") + CStr(My.Settings.subscapular) + CStr("mm ") + NewLine + _
                        CStr("   Suprailic: ") + CStr(My.Settings.Suprailiac) + CStr("mm ") + NewLine + _
                        CStr("   Thigh: ") + CStr(My.Settings.thigh) + CStr("mm ") + NewLine + NewLine + _
                        CStr("Of your total body weight:") + NewLine + _
                        CStr("   ") + Math.Round(My.Settings.fatmass, 2).ToString + CStr(" lbs. is fat weight.") + NewLine + _
                        CStr("   ") + Math.Round(My.Settings.fatfreemass, 2).ToString + CStr(" lbs. is lean body mass. (i.e. muscle and other tissues)") + NewLine + NewLine + _
                        CStr(My.Settings.classifv) + NewLine + NewLine + _
                        CStr("Your fat energy store is about ") + Math.Round(My.Settings.fatenergystore, 0).ToString + CStr(" calories.") + NewLine + CStr("This is the number of calories stored in your fat cells.") + NewLine + NewLine

            End If

            'Sets the activity level for output.
            Dim alvl As String
            If My.Settings.activitiylevel = "s" Then alvl = "Sedentary"
            If My.Settings.activitiylevel = "l" Then alvl = "Lightly Active"
            If My.Settings.activitiylevel = "m" Then alvl = "Moderately Active"
            If My.Settings.activitiylevel = "h" Then alvl = "Highly Active"

            'Determines if acwarn is to be displayed
            Dim acwarn
            If My.Settings.acwarn = True Then acwarn = NewLine + "Due to the low activity level you have selected, it is recommended that you increase " + NewLine + "your activity level to maintain a healthy lifestyle."
            If My.Settings.acwarn = False Then acwarn = ""

            'Performs universal calculations.
            Uoutput = CStr("Your basal metabolic rate is ") + Math.Round(My.Settings.bmrv, 0).ToString + CStr(" calories.") + NewLine + CStr("BMR is the calculation of the number of calories required to sustain your body's vital functions.") + NewLine + NewLine + _
                    CStr("The activity level you selected was ") + CStr(alvl) + CStr(". ") + CStr(acwarn) + NewLine + NewLine + _
                    CStr("Based on your activity level, your active caloric intake should be ") + Math.Round(My.Settings.acr, 0).ToString + CStr(" calories.") + NewLine + CStr("This provides a more realistic estimate of your caloric need than BMR.") + NewLine + NewLine + _
                    CStr("Exercise is critical to your overall health. Performing some form of exercise for at least ") + NewLine + CStr("30 minutes three times a week is ideal. There are plenty of activities for you to choose ") + NewLine + CStr("from. Below are listed some activities, along with how many calories you'll burn.") + NewLine + _
                    CStr("   Bowling:  ") + Math.Round(My.Settings.bowlingv, 0).ToString + CStr(" calories.") + NewLine + _
                    CStr("   Walking:  ") + Math.Round(My.Settings.walkv, 0).ToString + CStr(" calories (at 3 mph).") + NewLine + _
                    CStr("   Biking:  ") + Math.Round(My.Settings.bikev, 0).ToString + CStr(" calories (at 10 mph).") + NewLine + _
                    CStr("   Singles Tennis:  ") + Math.Round(My.Settings.tennisv, 0).ToString + CStr(" calories.") + NewLine + _
                    CStr("   Basketball:  ") + Math.Round(My.Settings.bballv, 0).ToString + CStr(" calories.") + NewLine + _
                    CStr("   Running:  ") + Math.Round(My.Settings.runv, 0).ToString + CStr(" calories (at 5.5 mph).") + NewLine + NewLine + _
                    CStr("Your maximum heart rate is ") + CStr(My.Settings.mhrv) + CStr(" beats per minute.")

            OutputDialogCreator()
        Catch ex As Exception
            MsgBox("An error has occured!" + NewLine + "Error Number: " + Err.Number.ToString + NewLine + "Error Description: " + Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub OutputDialogCreator()
        frmResults.OutputBox.Text = GInfoOutput + Moutput + Uoutput
        frmResults.Show()

        'Resets the status text.
        frmMain.StatusLabel.Text = "Ready"
    End Sub




    'Public Sub BMIOutput()

    'End Sub

    'Public Sub SkinfoldOutput()

    '    Try
    '        'Opens the results dialog.
    '        frmResults.Show()
    '        'Inserts the text into the output box and displays the varibles.
    '        'Notes:
    '        'Any variables with numerals must follow this style. CStr(The variable)
    '        'To break a line of text insert  + NewLine +
    '        frmResults.OutputBox.Text = "Name: " + My.Settings.name + NewLine + _
    '        "You are a " + My.Settings.gender + ", and you are " + CStr(My.Settings.age) + " years of age." + NewLine + NewLine + _
    '        "You have " + Math.Round(My.Settings.fatpercent, 2).ToString + "% body fat." + NewLine + NewLine + _
    '        "Your body composition statistics:" + NewLine + _
    '        "   Height: " + CStr(My.Settings.heightfoot) + " feet " + CStr(My.Settings.heightinch) + " inches " + NewLine + _
    '        "   Weight: " + CStr(My.Settings.weight) + " pounds " + NewLine + _
    '        "   Abdominal: " + CStr(My.Settings.Abdominal) + "mm " + NewLine + _
    '        "   Triceps: " + CStr(My.Settings.Triceps) + "mm " + NewLine + _
    '        "   Chest: " + CStr(My.Settings.Chest) + "mm " + NewLine + _
    '        "   Midauxillary: " + CStr(My.Settings.Midauxillary) + "mm " + NewLine + _
    '        "   Subscapular: " + CStr(My.Settings.Subscapular) + "mm " + NewLine + _
    '        "   Suprailic: " + CStr(My.Settings.Suprailiac) + "mm " + NewLine + _
    '        "   Thigh: " + CStr(My.Settings.Thigh) + "mm " + NewLine + NewLine + _
    '        "Of your total body weight:" + NewLine + _
    '        "   " + Math.Round(My.Settings.fatmass, 2).ToString + " lbs. is fat weight." + NewLine + _
    '        "   " + Math.Round(My.Settings.fatfreemass, 2).ToString + " lbs. is lean body mass. (i.e. muscle and other tissues)" + NewLine + NewLine + _
    '        My.Settings.classifsettings.ToString + NewLine + NewLine + _
    '        "Your fat energy store is about " + Math.Round(My.Settings.fatenergystore, 0).ToString + " calories." + NewLine + "This is the number of calories stored in your fat cells." + NewLine + NewLine + _
    '        "Your basal metabolic rate is " + Math.Round(My.Settings.bmrsettings, 0).ToString + " calories." + NewLine + "BMR is the calculation of the number of calories required to sustain your body's vital functions." + NewLine + NewLine + _
    '        "The activity level you selected was " + My.Settings.activitiylevel + ". " + NewLine + My.Settings.acwarnsettings + NewLine + NewLine + _
    '        "Based on your activity level, your active caloric intake should be " + Math.Round(My.Settings.acmultsettings, 0).ToString + " calories." + NewLine + "This provides a more realistic estimate of your caloric need than BMR." + NewLine + NewLine + _
    '        "Exercise is critical to your overall health. Performing some form of exercise for at least " + NewLine + "30 minutes three times a week is ideal. There are plenty of activities for you to choose " + NewLine + "from. Below are listed some activities, along with how many calories you'll burn." + NewLine + _
    '        "   Bowling:  " + Math.Round(My.Settings.bowlingsettings, 0).ToString + " calories." + NewLine + _
    '        "   Walking:  " + Math.Round(My.Settings.walkingsettings, 0).ToString + " calories (at 3 mph)." + NewLine + _
    '        "   Biking:  " + Math.Round(My.Settings.bikingsettings, 0).ToString + " calories (at 10 mph)." + NewLine + _
    '        "   Singles Tennis:  " + Math.Round(My.Settings.tennissettings, 0).ToString + " calories." + NewLine + _
    '        "   Basketball:  " + Math.Round(My.Settings.bballsettings, 0).ToString + " calories." + NewLine + _
    '        "   Running:  " + Math.Round(My.Settings.runsettings, 0).ToString + " calories (at 5.5 mph)." + NewLine + NewLine + _
    '        "Your maximum heart rate is " + My.Settings.mhrsettings.ToString + " beats per minute."

    '        'Catches the error and asks the user to corect it
    '    Catch exp As Exception
    '        MessageBox.Show("Please complete all fields to continue.")
    '        frmMain.StatusLabel.Text = "Error"
    '    End Try

    '    'MsgBox
    '    'Resets the status text.
    '    frmMain.StatusLabel.Text = "Ready"
    'End Sub

End Class
