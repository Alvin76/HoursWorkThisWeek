'Name of Project: Hari Hour CalCulator
'Author:          Adam Davies
'Date:            3-29-2020
'Purpos:          Calculate hours worked in the week and be able to store them/ load them. It will be eported as an app
Option Strict On
Imports System.IO
''' <summary>
''' imporatant notes to rember:
''' Punch in Ture | Punch out is False
''' </summary>

Public Class PrimeCat
    Private objectReader As StreamReader
    Private FlagLoad As Boolean
    Private FlagSave As Boolean
    Private FlagClockedin As Boolean = False
    Private ReadOnly filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
    Private ReadOnly strPur As String = "Purrfict"
    Private ReadOnly strCat As String = "Catastorfic"
    Private ReadOnly strH As String = "Hari:"
    Private ReadOnly dbTimeConvert As Double = 100D / 60D ' this will let min become 00:30 to 0.5
    'This is an array of the days to hold the data of each day into it
    Private _DaysofWeek() As DaysOfWeek = {Mon, Tue, Wed, Thu, Fri, Sat, Sun}
    Private Mon As DaysOfWeek
    Private Tue As DaysOfWeek
    Private Wed As DaysOfWeek
    Private Thu As DaysOfWeek
    Private Fri As DaysOfWeek
    Private Sat As DaysOfWeek
    Private Sun As DaysOfWeek

    'Private 
    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Hari()
        FlagLoad = True
        btnEntery.Visible = True
        txtTime.Text = "Enter save files name here"
        txtTime.Visible = True


    End Sub

    Private Sub btnEntery_Click(sender As Object, e As EventArgs) Handles btnEntery.Click
        Dim strStart As String
        Dim strEnd As String
        If FlagLoad Then
            strStart = txtTime.Text
            'strStart = FileValadator(strStart)
            If IO.File.Exists(filePath + strStart + ".txt") = True Then
                objectReader = IO.File.OpenText(filePath + "testme.txt")
                MsgBox(strH + " The file was loaded",, strPur)
                Hari()
            Else
                MsgBox("The file was not found",, strCat)
            End If
        ElseIf FlagSave Then

        Else
            If TimeValadator() Then
                MsgBox(strH + " Your Punch was recoreded",, strPur)
            End If
        End If

    End Sub
    Private Function FileValadator(Var1 As String) As String
        'add a method to make sure the data is valad string No periods or slashes 
        Return Var1
    End Function
    Private Function TimeValadator() As Boolean
        ' make sure the time is less the 24:00 
        ' make sure there is no more then 5 chare and no less then 5 char 
        Dim bdDayOfWeeek As Boolean = False
        Dim bdTimeEntry As Boolean = False
        Dim intdays As Int32
        Dim strTimeEnterd As String
        Dim strBadTime As String = strH + "Please enter a time"
        Dim intStrLen As Int32
        'vars for spliting the string for vladation
        Dim strFirst2 As String
        Dim timeArray() As String
        Dim strCols As String
        Dim strLast2 As String
        Dim intTest As Int32

        Try 'This is to make sure the user clicked on a day 
            intdays = Convert.ToInt32(lstDays.SelectedIndex)
            bdDayOfWeeek = True
        Catch ex As Exception
            MsgBox(strH + " You need to select a day",, strCat)
            bdDayOfWeeek = False
        End Try
        strTimeEnterd = txtTime.Text
        intStrLen = strTimeEnterd.Length
        If intStrLen > 5 Then
            MsgBox(strBadTime,, strCat)
            bdTimeEntry = False
        ElseIf intStrLen < 3 Then
            MsgBox(strBadTime,, strCat)
            bdTimeEntry = False
        Else
            If intStrLen = 3 Then
                strTimeEnterd = "0" + strTimeEnterd
            End If
            timeArray = strBadTime.Split()


        End If
        If bdDayOfWeeek And bdTimeEntry Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Hari()
        Dim testme As String = "testme.txt"
        Dim x As FileStream
        x = File.Create(filePath + testme)
        x.Close()
        If File.Exists(filePath + testme) Then
            MsgBox("it worked",, strPur)
        Else
            MsgBox("it didn't work",, strCat)
        End If
    End Sub

    Private Sub btnPunchIn_Click(sender As Object, e As EventArgs) Handles btnPunchIn.Click
        Hari()
        TimePunch(True)
        'clocks in'
    End Sub

    Private Sub btnPunchOut_Click(sender As Object, e As EventArgs) Handles btnPunchOut.Click
        Hari()
        TimePunch(False)
        'clocks out'
    End Sub
    Private Sub TimePunch(Status As Boolean)
        Dim strCurentDay As String
        Dim strCurentHour As String
        Dim dbCurentHour As Double
        Dim strCurentMin As String
        Dim dbCurentMin As Double
        Dim dbClockedTime As Double
        strCurentDay = Format(Now, "dddd")
        strCurentHour = Format(Now, "hh")
        dbCurentHour = Convert.ToDouble(strCurentHour)
        strCurentMin = Format(Now, "mm")
        dbCurentMin = Convert.ToDouble(strCurentHour)
        dbCurentMin *= dbTimeConvert
        dbClockedTime = dbCurentHour + dbCurentMin
        Select Case strCurentDay
            Case "Monday"
                Mon.enterTime(dbClockedTime, Status)
            Case "Tuesday"
                Tue.enterTime(dbClockedTime, Status)
            Case "Wednesday"
                Wed.enterTime(dbClockedTime, Status)
            Case "Thursday"
                Thu.enterTime(dbClockedTime, Status)
            Case "Friday"
                Fri.enterTime(dbClockedTime, Status)
            Case "Saturday"
                Sat.enterTime(dbClockedTime, Status)
            Case "Sunday"
                Sun.enterTime(dbClockedTime, Status)
        End Select
        MsgBox(Mon.CalculateHours())
        'Switch nowish as String = strCurentDate
        'End
        'MsgBox("The formatted date is " & Format(Now, "dddd, d MMM yyyy"))
        'MsgBox("The formatted time is " & Format(Now, "hh.mm.ss.fff tt"))
        ' more info on this at 
        'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.dateandtime.timestring?view=netframework-4.8
    End Sub

    Private Sub btnEnterTime_Click(sender As Object, e As EventArgs) Handles btnEnterTime.Click
        Hari()
        FlagLoad = False
        FlagSave = False
        lstDays.Visible = True
        radPM.Visible = True
        radAM.Visible = True
        txtTime.Visible = True
        btnEntery.Text = "Punch In"
        btnEntery.Visible = True
        btnClear.Text = "Punch Out"
        btnClear.Visible = True
        If FlagClockedin Then
            btnEntery.Enabled = False
        Else
            btnClear.Enabled = False
        End If
        lblHelpBox2.Text = "Hari: Enter a time here!"
        lblHelpBox2.Visible = True
        lblHelp.Text = "Select a Day, enter time, and select am/pm then click enter"
        lblHelp.Visible = True
    End Sub
    'This sub is to make all them elments visible to False 
    Private Sub Hari()
        lstDays.Visible = False
        LstEntreys.Visible = False
        radPM.Visible = False
        radAM.Visible = False
        txtTime.Visible = False
        btnEntery.Visible = False
        btnClear.Visible = False
        lblHelpBox2.Visible = False
        lblHelp.Visible = False
    End Sub
    Private Function RecoredTime(strday As String, dbTime As Double, boState As Boolean) As Boolean
        Dim Saved As Boolean

        Return Saved
    End Function
    Private Function TimeConvert(strday As String, strTime As String, boState As Boolean) As Boolean
        Dim Saved As Boolean
        Dim dbtime As Double = 0D
        'This will take in the string and return a double to be used fir the next funtion to recored a time 
        Saved = RecoredTime(strday, dbtime, boState)
        Return Saved
    End Function
End Class

Public Class DaysOfWeek
    Private _dbStartTime() As Double 'Look into this here maybe
    Private _dbEndTime() As Double
    Private _dbWorkedTime As Double
    Public Sub enterTime(bdStartTime As Double, EntryType As Boolean)
        If EntryType Then ' if the entry type is true it is a start time else it is a end time
            _dbStartTime.Append(bdStartTime)
        Else
            _dbEndTime.Append(bdStartTime)
        End If
    End Sub
    Public Function requestTime(EntryType As Boolean) As Double()
        If EntryType Then
            Return _dbStartTime
        Else
            Return _dbEndTime
        End If
    End Function
    Public Function CalculateHours() As Double
        Dim dbPunchIn As Double
        Dim dbPunchOut As Double
        For i As Int32 = 1 To Len(_dbStartTime)
            dbPunchIn = _dbStartTime(i)
            Try
                dbPunchOut = _dbEndTime(i)
            Catch ex As Exception
                dbPunchOut = -1D
            End Try
            If dbPunchOut = -1D Then
                If dbPunchOut > dbPunchIn Then
                    _dbWorkedTime = dbPunchOut - dbPunchIn
                Else 'need to added a cut off for 24:00 and punch back in as the data is stored per day
                    dbPunchOut += 24D
                    _dbWorkedTime = dbPunchOut - dbPunchIn
                End If
            End If

        Next
        Return _dbWorkedTime
    End Function

End Class

