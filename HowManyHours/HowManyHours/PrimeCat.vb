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
    'Private odaName As New OleDb.OleDbDataAdapter(Sql Select command, Path statment)
    Private strSql As String = "SELECT * FROM TimeStamps"
    Private strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ; - & Data Source = HariWorkHours.accdb"
    Private odaTimeStamp As New OleDb.OleDbDataAdapter(strSql, strPath)
    Private DataValue As New DataTable
    Private intcount As Int32
    Private intNumberOfRows As Int32 = DataValue.Rows.Count
    Private intNumberOfColumns As Int32 = DataValue.Columns.Count
    Private objectReader As StreamReader
    Private FlagLoad As Boolean
    Private FlagSave As Boolean
    Private FlagClockedin As Boolean = False
    Private ReadOnly strPur As String = "Purrfict"
    Private ReadOnly strCat As String = "Catastorfic"
    Private ReadOnly strH As String = "Hari:"
    Private ReadOnly dbTimeConvert As Double = 100D / 60D ' this will let min become 00:30 to 0.5

    'Private 
    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        'THIS KILLS THE PROGRAM
        Close()
    End Sub

    Private Function FileValadator(Var1 As String) As String
        'add a method to make sure the data is valad string No periods or slashes 
        Return Var1
    End Function
    'Private Function TimeValadator() As Boolean
    '    'make sure the time Is less the 24:  00 
    '     'make sure there Is no more then 5 chare And no less then 5 char 
    '    Dim bdDayOfWeeek As Boolean = False
    '    Dim bdTimeEntry As Boolean = False
    '    Dim intdays As Int32
    '    Dim strTimeEnterd As String
    '    Dim strBadTime As String = strH + "Please enter a time"
    '    Dim intStrLen As Int32
    '    'vars for spliting the string for vladation
    '    Dim strFirst2 As String
    '    Dim timeArray() As String
    '    Dim strCols As String
    '    Dim strLast2 As String
    '    Dim intTest As Int32

    '    Try 'This is to make sure the user clicked on a day 
    '        intdays = Convert.ToInt32(lstDays.SelectedIndex)
    '        bdDayOfWeeek = True
    '    Catch ex As Exception
    '        MsgBox(strH + " You need to select a day",, strCat)
    '        bdDayOfWeeek = False
    '    End Try
    '    strTimeEnterd = txtTime.Text
    '    intStrLen = strTimeEnterd.Length
    '    If intStrLen > 5 Then
    '        MsgBox(strBadTime,, strCat)
    '        bdTimeEntry = False
    '    ElseIf intStrLen < 3 Then
    '        MsgBox(strBadTime,, strCat)
    '        bdTimeEntry = False
    '    Else
    '        If intStrLen = 3 Then
    '            strTimeEnterd = "0" + strTimeEnterd
    '        End If
    '        timeArray = strBadTime.Split()


    '    End If
    '    If bdDayOfWeeek And bdTimeEntry Then
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function

    'Puch system
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
        'Data Formats
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
        'MsgBox(dbClockedTime,, "Testing")
        Dim row As DataRow
        row = HariWorkHoursDataSet.TimeStamps.NewRow()
        row("EnteredDate") = Today
        row("DayOfWeek") = strCurentDay
        If Status Then
            row("TimeIN") = dbClockedTime
        Else
            row("TimeOut") = dbClockedTime
        End If
        row("EditedOn") = Today
        HariWorkHoursDataSet.TimeStamps.Rows.Add(row)
        row.AcceptChanges()
        row.SetAdded()
        HariWorkHoursDataSet.TimeStamps.AcceptChanges()
        MsgBox(dbClockedTime,, "Testing")

        'DataView
        'odaTimeStamp.f
        'Switch nowish as String = strCurentDate
        'End
        'MsgBox("The formatted date is " & Format(Now, "dddd, d MMM yyyy"))
        'MsgBox("The formatted time is " & Format(Now, "hh.mm.ss.fff tt"))
        ' more info on this at 
        'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.dateandtime.timestring?view=netframework-4.8
    End Sub


    'This sub is to make all them elments visible to False 
    Private Sub Hari()

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

    Private Sub PrimeCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HariWorkHoursDataSet.TimeStamps' table. You can move, or remove it, as needed.
        Me.TimeStampsTableAdapter.Fill(Me.HariWorkHoursDataSet.TimeStamps)

    End Sub

    Private Sub EnteredDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles EnteredDateDateTimePicker.ValueChanged

    End Sub
End Class

