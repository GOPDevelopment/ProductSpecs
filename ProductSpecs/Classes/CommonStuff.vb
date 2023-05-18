Imports System.Runtime.InteropServices
Imports System.IO
Imports System.IO.Ports



Module CommonStuff

    Public inTest As Boolean = False


    Function FixNull(ByVal szValue)
        If IsDBNull(szValue) Then
            Return ""
        Else
            Return szValue
        End If
    End Function
    Function FixNullInteger(ByVal szValue)
        If IsDBNull(szValue) Then
            Return 0
        ElseIf IsNumeric(szvalue) Then
            Return CInt(szValue)
        Else
            Return 0
        End If
    End Function
    Function FixNullDecimal(ByVal szValue)
        If IsDBNull(szValue) Then
            Return 0
        ElseIf IsNumeric(szValue) Then
            Return CDec(szValue)
        Else
            Return 0
        End If
    End Function
    Function CheckBit(ByVal b As Boolean, ByVal endchar As String)
        If b Then
            Return "1" & endchar
        Else
            Return "0" & endchar
        End If
    End Function
    Function CheckString(ByVal s As String)
        Return CheckString(s, "")
    End Function
    Function CheckString(ByVal s As String, ByVal endchar As String)
        Dim pos = InStr(s, "'")
        While pos > 0
            s = Mid(s, 1, pos) & "'" & Mid(s, pos + 1)
            pos = InStr(pos + 2, s, "'")
        End While
        CheckString = "'" & s & "'" & endchar
    End Function
    Function CheckDate(ByVal szValue) As Nullable(Of Date)
        If szValue Is Nothing Or IsDBNull(szValue) Then
            Return Nothing
        Else
            Return Convert.ToDateTime(szValue.ToString).ToString("MM/dd/yyyy")
        End If
    End Function
    Function CheckValueForNull(ByVal s As String, ByVal endchar As String, ByVal IsString As Boolean)
        If String.IsNullOrEmpty(s) Then
            Return "NULL" & endchar
        Else
            If IsString Then
                Return CheckString(s, endchar)
            Else
                Return s & endchar
            End If
        End If
    End Function
    Public Function RemoveAllAlphas(sValue As String) As String
        Dim sReturn As String = ""
        For i = 0 To sValue.Length - 1
            If IsNumeric(sValue(i)) Or sValue(i) = "." Then
                sReturn += sValue(i)
            End If
        Next
        Return sReturn
    End Function


    'Sub CleanWorkFolder(tempWorkFolder As String, ByVal machineInfo As String)
    '    Dim OldFiles() As String = Directory.GetFiles(Environment.CurrentDirectory & tempWorkFolder, "*.palco.lbl*")
    '    For Each ThisFile As String In OldFiles
    '        Try
    '            If DateDiff(DateInterval.DayOfYear, File.GetLastWriteTime(ThisFile), Now) > 15 Then
    '                File.Delete(ThisFile)
    '            End If
    '        Catch ex As Exception
    '            WriteToErrorLog("ERROR", ex.Message, ex.StackTrace, machineInfo)
    '        End Try
    '    Next
    'End Sub

    'Sub CleanErrLogFolder(ByVal machineInfo As String)

    '    'clean out old err files
    '    Dim OldFiles() As String = Directory.GetFiles(Environment.CurrentDirectory & "\Errors\", "*.txt")
    '    For Each ThisFile As String In OldFiles
    '        Try
    '            If DateDiff(DateInterval.DayOfYear, File.GetLastWriteTime(ThisFile), Now) > 30 Then
    '                File.Delete(ThisFile)
    '            End If

    '        Catch ex As Exception
    '            WriteToErrorLog("ERROR", ex.Message, ex.StackTrace, machineInfo)
    '        End Try
    '    Next

    'End Sub

    'Public Sub WriteToErrorLog(ByVal title As String, ByVal msg As String, ByVal stkTrace As String, ByVal machineInfo As String)
    '    Try

    '        If Not System.IO.Directory.Exists(Application.StartupPath & "\Errors\") Then
    '            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors\")
    '        End If

    '        Dim fn As String = "errlog_" & machineInfo & "_" & DateTime.Now.ToString("yyyyMMdd") & ".txt"

    '        'check the file
    '        Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.OpenOrCreate, FileAccess.ReadWrite)
    '        Dim s As StreamWriter = New StreamWriter(fs)
    '        s.Close()
    '        fs.Close()

    '        'log it
    '        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.Append, FileAccess.Write)
    '        Dim s1 As StreamWriter = New StreamWriter(fs1)
    '        s1.Write("===== " & DateTime.Now.ToString() & "============== E R R O R ===================================" & vbCrLf)
    '        s1.Write(title & " - " & msg & " - " & stkTrace & vbCrLf & vbCrLf)
    '        s1.Close()
    '        fs1.Close()

    '    Catch ex As Exception
    '        'do nothing, carry on
    '    End Try
    'End Sub

    'Public Sub WriteToLog(ByVal title As String, ByVal msg As String, ByVal stkTrace As String, ByVal machineInfo As String)
    '    Try

    '        If Not System.IO.Directory.Exists(Application.StartupPath & "\Errors\") Then
    '            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors\")
    '        End If

    '        Dim fn As String = "errlog_" & machineInfo & "_" & DateTime.Now.ToString("yyyyMMdd") & ".txt"

    '        'check the file
    '        Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.OpenOrCreate, FileAccess.ReadWrite)
    '        Dim s As StreamWriter = New StreamWriter(fs)
    '        s.Close()
    '        fs.Close()

    '        'log it
    '        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\" & fn, FileMode.Append, FileAccess.Write)
    '        Dim s1 As StreamWriter = New StreamWriter(fs1)
    '        s1.Write(DateTime.Now.ToString() & " ===== " & title & " - " & msg & " - " & stkTrace & vbCrLf)
    '        s1.Close()
    '        fs1.Close()

    '    Catch ex As Exception
    '        'do nothing, carry on
    '    End Try
    'End Sub

End Module


