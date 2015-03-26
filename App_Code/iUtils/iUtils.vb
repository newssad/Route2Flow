Imports Microsoft.VisualBasic
Imports System.Data
Public Class iUtils
    Shared cabinetname As String = ConfigurationManager.AppSettings("ifmflow_Cabinet")
    Shared tempxmlname As String = "TempXML2.0"
    Shared uid As String = ConfigurationManager.AppSettings("UID")
    Shared pwd As String = ConfigurationManager.AppSettings("PWD")
    Shared IPDBServer As String = ConfigurationManager.AppSettings("IPDBServer")
    'Shared ifmCab As New InfomaLibrary.INFOMA.iDatabase.iDbInterfacer(IPDBServer, cabinetname, uid, pwd, 1, 1)
    'Shared tempxmlInterfacer As New InfomaLibrary.INFOMA.iDatabase.iDbInterfacer(IPDBServer, tempxmlname, uid, pwd, 1, 1)

    Public Shared Function TodayDATETIME() As String
        Dim strReturn As String = String.Empty
        Dim d As Date = Now
        Dim strYear As String = Year(d)
        Dim strMonth As String = Month(d)
        Dim strDay As String = Day(d)
        Dim StrTime As String = Format(Now, "HH:MM:ss")
        If Len(strMonth) = 1 Then strMonth = "0" & strMonth
        If Len(strDay) = 1 Then strDay = "0" & strDay
        strReturn = strYear & strMonth & strDay & Replace(StrTime, ":", "")
        Return strReturn
    End Function

    Public Shared Function FullTextFormat(ByVal strMsg As String) As String
        Dim strTmpMsg As String = ""
        Dim strTmpMsg1 As String = ""
        Dim strReturn As String = String.Empty
        strTmpMsg = strMsg
        Do While InStr(strTmpMsg, " ") > 0
            strTmpMsg1 = strTmpMsg1 & Trim(Mid(strTmpMsg, 1, InStr(strTmpMsg, " ") - 1))
            strTmpMsg = Mid(strTmpMsg, InStr(strTmpMsg, " ") + 1)
        Loop
        strReturn = Trim(strTmpMsg1 & strTmpMsg)
        Return strReturn
    End Function

    Public Shared Function FindContentType(ByVal LetterMimeType As String) As String
        Dim strReturn As String = String.Empty
        Select Case LetterMimeType
            Case "application/msword"
                strReturn = "DOC"
            Case "application/pdf"
                strReturn = "PDF"
            Case "application/rtf", "text/rtf"
                strReturn = "RTF"
            Case "application/vnd.ms-excel"
                strReturn = "XLS"
            Case "application/vnd.ms-outlook"
                strReturn = "MSG"
            Case "application/vnd.ms-powerpoint"
                strReturn = "PPT"
            Case "application/vnd.ms-project"
                strReturn = "MPP"
            Case "application/x-msaccess"
                strReturn = "MDB"
            Case "application/x-msmetafile"
                strReturn = "WMF"
            Case "application/x-tex", "text/plain"
                strReturn = "TXT"
            Case "application/zip", "application/x-zip"
                strReturn = "ZIP"
            Case "audio/mpeg"
                strReturn = "MP3"
            Case "image/bmp"
                strReturn = "BMP"
            Case "image/gif"
                strReturn = "GIF"
            Case "image/jpeg"
                strReturn = "JPG"
            Case "image/tiff"
                strReturn = "TIF"
            Case "text/html"
                strReturn = "HTM"
            Case "text/plain"
                strReturn = "TXT"
            Case "text/richtext"
                strReturn = "RTF"
            Case "text/webviewhtml"
                strReturn = "HTM"
            Case "video/mpeg"
                strReturn = "MPG"
            Case "video/x-msvideo"
                strReturn = "AVI"
            Case "video/x-ms-wmv"
                strReturn = "WMV"
            Case "image/png"
                strReturn = "PNG"
            Case "text/javascript"
                strReturn = "JS"
            Case "application/java-archive"
                strReturn = "JAR"
            Case "application/x-gzip"
                strReturn = "GZ"
            Case Else
                strReturn = ""
        End Select
        Return strReturn
    End Function

    Public Shared Function SendFindContentType(ByVal LetterMimeType As String) As String
        SendFindContentType = ""
        Select Case UCase(LetterMimeType)
            Case ".DOC"
                SendFindContentType = "application/msword"
            Case ".PDF"
                SendFindContentType = "application/pdf"
            Case ".RTF"
                SendFindContentType = "application/rtf"
            Case ".XLS"
                SendFindContentType = "application/vnd.ms-excel"
            Case ".MSG"
                SendFindContentType = "application/vnd.ms-outlook"
            Case ".PPT"
                SendFindContentType = "application/vnd.ms-powerpoint"
            Case ".MPP"
                SendFindContentType = "application/vnd.ms-project"
            Case ".MDB"
                SendFindContentType = "application/x-msaccess"
            Case ".WMF"
                SendFindContentType = "application/x-msmetafile"
            Case ".TXT"
                SendFindContentType = "text/plain"
            Case ".ZIP"
                SendFindContentType = "application/zip"
            Case ".MP3"
                SendFindContentType = "audio/mpeg"
            Case ".BMP"
                SendFindContentType = "image/bmp"
            Case ".GIF"
                SendFindContentType = "image/gif"
            Case ".JPG"
                SendFindContentType = "image/jpeg"
            Case ".TIF"
                SendFindContentType = "image/tiff"
            Case ".HTM"
                SendFindContentType = "text/html"
            Case ".TXT"
                SendFindContentType = "text/plain"
            Case ".RTX"
                SendFindContentType = "text/richtext"
            Case ".HTM"
                SendFindContentType = "text/webviewhtml"
            Case ".MPG"
                SendFindContentType = "video/mpeg"
            Case ".AVI"
                SendFindContentType = "video/x-msvideo"
            Case Else
                SendFindContentType = "application/octet-stream"
        End Select
    End Function

    Public Shared Function CheckBudhaYear(ByVal Sdate As String) As String
        Dim Sbudhayear As String = ""
        Dim Sbudhadate As String = ""
        'CheckBudhaYear = "-"
        Dim strReturn As String = "-"
        If Trim(Sdate) <> "" Then
            If (Mid(Sdate, 1, 4) > "2000") And (Mid(Sdate, 1, 4) < "2500") Then
                Sbudhayear = Mid(Sdate, 1, 4) + 543
                Sbudhadate = Sbudhayear & "/" & Mid(Sdate, 6, 2) & "/" & Mid(Sdate, 9, 2)
            Else
                Sbudhadate = Mid(Sdate, 1, 4) & "/" & Mid(Sdate, 6, 2) & "/" & Mid(Sdate, 9, 2)
            End If
            strReturn = Sbudhadate
        End If
        Return strReturn
    End Function

    Public Shared Function TodayYYYYMMDD(ByVal d As String) As String
        If IsDate(d) Then
            Dim strYear As String = Year(d)
            Dim strMonth As String = Month(d)
            Dim strDay As String = Day(d)
            Dim StrTime As String = Format(Now, "HH:MM:ss")
            If Len(strMonth) = 1 Then strMonth = "0" & strMonth
            If Len(strDay) = 1 Then strDay = "0" & strDay

            d = strYear & "-" & strMonth & "-" & strDay
            Return d
        Else
            Return ""
        End If
    End Function

    Public Shared Function TodayYYYYMMDD_C(ByVal d As String) As String
        If IsDate(d) Then
            Dim strYear As String = Year(d) - 543
            Dim strMonth As String = Month(d)
            Dim strDay As String = Day(d)
            Dim StrTime As String = Format(Now, "HH:MM:ss")
            If Len(strMonth) = 1 Then strMonth = "0" & strMonth
            If Len(strDay) = 1 Then strDay = "0" & strDay

            d = strYear & "-" & strMonth & "-" & strDay
            Return d
        Else
            Return ""
        End If
    End Function

    Public Shared Function FormatRegisterNo(ByVal SRegno As String) As String
        FormatRegisterNo = "-"
        If Len(SRegno) > 0 And Len(SRegno) < 15 Then
            If IsNumeric(SRegno) Then
                FormatRegisterNo = Mid("000000000000", 1, 15 - Len(SRegno)) & CInt(SRegno)
            Else
                FormatRegisterNo = (SRegno)
            End If

        ElseIf Len(SRegno) = 15 Then
            Try
                FormatRegisterNo = CInt(SRegno)
            Catch ex As Exception
                FormatRegisterNo = SRegno
            End Try

        End If
    End Function

    

    

    

    

    Public Shared Function Todaydate() As String

        Dim d As Date = Now
        Dim strYear As String = ""
        If Year(d) < 2500 Then
            strYear = Year(d) + 543
        Else
            strYear = Year(d)
        End If
        Dim strMonth As String = Month(d)
        Dim strDay As String = Day(d)

        If Len(strMonth) = 1 Then strMonth = "0" & strMonth
        If Len(strDay) = 1 Then strDay = "0" & strDay

        Todaydate = strYear & "/" & strMonth & "/" & strDay


    End Function

    

    Public Shared Function TodaydateEng() As String

        Dim d As Date = Now
        Dim strYear As String = ""
        If Year(d) > 2500 Then
            strYear = Year(d) - 543
        Else
            strYear = Year(d)
        End If
        Dim strMonth As String = Month(d)
        Dim strDay As String = Day(d)

        If Len(strMonth) = 1 Then strMonth = "0" & strMonth
        If Len(strDay) = 1 Then strDay = "0" & strDay

        TodaydateEng = strYear & "/" & strMonth & "/" & strDay


    End Function

    Public Shared Function TodayTime() As String        
        Dim tmptime As String = TimeOfDay
        Dim h As String = Hour(tmptime) : If Len(h) = 1 Then h = "0" & h
        Dim m As String = Minute(tmptime) : If Len(m) = 1 Then m = "0" & m
        Dim s As String = Second(tmptime) : If Len(s) = 1 Then s = "0" & s
        Return h & ":" & m & ":" & s
    End Function

    

    

    Public Shared Function CopyImageFile(ByVal SCurDir As String, ByVal Sdocuname As String, ByVal SourceFileInbound As String) As Integer
        Dim Ret As Integer = -1
        Dim DriveLetter As String = ConfigurationManager.AppSettings("DriveLetter")
        Dim ECMSDriveLetter As String = ConfigurationManager.AppSettings("ifmWeb_ifmflow_ecmstemp")
        Dim sExtension As String = System.IO.Path.GetExtension(SourceFileInbound)
        If sExtension <> "" Then
            Dim Tdir As String = System.IO.Path.GetFullPath(SCurDir)
            Dim lenip As Integer = Len(System.IO.Path.GetPathRoot(Tdir))
            Dim lenupddatepath As Integer = Len(ConfigurationManager.AppSettings("Updatepath"))
            Dim TargetPath As String = DriveLetter & Mid(Tdir, (lenip + 1), (len(Tdir) - lenip))

            Dim TargetFname As String = TargetPath & "\" & Sdocuname & sExtension
            Dim s5 As String = System.IO.Path.GetDirectoryName(SourceFileInbound)
            Dim lenupdecmspath As Integer = Len(ConfigurationManager.AppSettings("strConIISECMSTemp"))
            Dim PhysicalSource As String = ECMSDriveLetter & "\IMAGEPATH\" & System.IO.Path.GetFileName(SourceFileInbound)
            Dim SourcePath = PhysicalSource & System.IO.Path.GetFileName(SourceFileInbound)
            '    response.write(" Main=" & PhysicalSource &" DOc=" &TargetFname &"  TargetPath=" & TargetPath  & "  Tdir =" & Tdir  )
            '           response.end
            If System.IO.File.Exists(PhysicalSource) Then
                FileCopy(PhysicalSource, TargetFname)
                '  response.write(" Main=" & PhysicalSource &" DOc=" &TargetFname )
                '    response.end
                Ret = 0
            End If
        End If
        Return Ret
    End Function

    Public Shared Function ddmmyyyyNoPlus(ByVal s As String) As String
        If s <> "" And s <> "-" Then
            Dim syy As String = Mid(s, 1, 4)
            Dim smm As String = Mid(s, 6, 2)
            Dim sdd As String = Mid(s, 9, 2)

            ddmmyyyyNoPlus = sdd & "-" & smm & "-" & syy
        Else
            ddmmyyyyNoPlus = ""
        End If
    End Function

    Public Shared Function CheckFormatECMSDate(ByVal d As String) As Boolean
        If InStr(d, "-") > 0 Then
            If d.Split("-")(0).Length = 4 And d.Split("-")(1).Length = 2 And d.Split("-")(2).Length = 2 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class

Partial Public Class iStringSystem
    Inherits System.Web.UI.Page
    Public Shared Function frontzero(ByVal s As String, ByVal n As Integer) As String
        Dim ifzr As Integer
        For ifzr = Len(s) To n - 1
            s = "0" & s
        Next
        Return s
    End Function
    Public Shared Function unQuote(ByVal strTmp As String) As String
        'TOMMY
        strTmp = strTmp
        If (strTmp = "") Then
            strTmp = "-"
        Else
            Dim intPos = InStr(strTmp, "'")
            Do While intPos > 0
                strTmp = Mid(strTmp, 1, intPos) & "'" & Mid(strTmp, intPos + 1)
                intPos = InStr(intPos + 2, strTmp, "'")
            Loop
        End If
        unQuote = Trim(strTmp)
    End Function
    Public Shared Function unCarryReturn(ByVal strTmp As String) As String
        Dim newstr = ""
        Dim lenstr As Integer = 0
        Dim cutstr = ""
        If InStr(Trim(strTmp), Chr(13)) > 0 Then
            For lenstr = 1 To Len(Trim(strTmp))
                cutstr = Trim(Mid(Trim(strTmp), lenstr, 1))
                If cutstr <> Chr(13) And cutstr <> Chr(10) Then
                    newstr = Trim(newstr) & Trim(cutstr)
                End If
            Next
            unCarryReturn = Trim(newstr)
        Else
            unCarryReturn = Trim(strTmp)
        End If
    End Function
    Public Shared Function getVstr(ByVal s As String) As String
        If (s = "") Then
            getVstr = "-"
        Else
            getVstr = s
        End If
    End Function
    Public Shared Function get_bid(ByVal s As String) As String
        If (s = "-") Then
            get_bid = "-"
        Else
            get_bid = s
        End If
    End Function
    Public Shared Function ext(ByVal s As String) As String
        If (InStr(Right(Trim(s), 4), ".") > 0) Then
            'ext=mid(s,(trim(s),4),".")+1)
            ext = Mid(s, Len(Mid(Trim(s), 1, Len(Trim(s)) - 3)) + 1, 3)
        ElseIf (InStr(Right(Trim(s), 5), ".") > 0) Then
            ext = Mid(s, Len(Mid(Trim(s), 1, Len(Trim(s)) - 4)) + 1, 4)
        Else
            ext = ""
        End If
    End Function
    'IMGFLOW\14000\00000002.DOC
    Public Shared Function chgSlash(ByVal s As String) As String
        Dim fileName = "/"
        Do While (InStr(s, "\") <> 0)
            fileName = fileName + Mid(s, 1, InStr(s, "\") - 1)
            fileName = fileName + "/"
            s = Mid(s, InStr(s, "\") + 1)
        Loop
        chgSlash = fileName + s
    End Function
    Public Shared Function cut2(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim indxcut As Integer
        Dim cuts As String
        cut2 = ""
        For indxcut = 0 To Len(s)
            cuts = Mid(s, Len(s) - indxcut, 1)
            If (cuts = "\") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 2) Then
                cut2 = Right(s, indxcut)
                cut2 = chgSlash(cut2)
                Exit Function
            End If
        Next
    End Function
    Public Shared Function cut1(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim indxcut As Integer
        Dim cuts As String
        cut1 = ""
        For indxcut = 0 To Len(s)
            On Error Resume Next
            cuts = Mid(s, Len(s) - indxcut, 1)
            If (cuts = "\") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 1) Then
                cut1 = Right(s, indxcut)
                Exit Function
            End If
        Next
    End Function
    Public Shared Function cut1noChg(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim indxcut As Integer
        Dim cuts As String
        cut1noChg = ""
        For indxcut = 0 To Len(s)
            cuts = Mid(s, Len(s) - indxcut, 1)
            If (cuts = "\") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 1) Then
                cut1noChg = Right(s, indxcut)
                Exit Function
            End If
        Next
    End Function
    Public Shared Function cut2noChg(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim indxcut As Integer
        Dim cuts As String
        cntlastslash = 0
        cut2noChg = ""
        For indxcut = 0 To Len(s)
            cuts = Mid(s, Len(s) - indxcut, 1)
            If (cuts = "\") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 2) Then
                cut2noChg = Right(s, indxcut)
                Exit Function
            End If
        Next
    End Function
    Public Shared Function cut3noChg(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim indxcut As Integer
        Dim cuts As String
        cut3noChg = ""
        For indxcut = 0 To Len(s)
            cuts = Mid(s, Len(s) - indxcut, 1)
            If cuts = "\" Then
                cntlastslash = cntlastslash + 1
            End If
            If cntlastslash = 3 Then
                cut3noChg = Right(s, indxcut)
                Exit Function
            End If
        Next
    End Function
    ' cut image path ..\<Drawer>\DATA\..
    '                       ^ this will be the shared directory (alias) on IIS
    Public Shared Function rat3(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim cuts As String
        Dim i As Integer
        rat3 = ""
        For i = 0 To Len(s)
            cuts = Mid(s, Len(s) - i, 1)
            If (cuts = "\") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 3) Then
                rat3 = Right(s, i)
                rat3 = chgSlash(rat3)
                Exit For
            End If
        Next

    End Function

    Public Shared Function ratBackSlash(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim cuts As String
        Dim i As Integer
        ratBackSlash = ""
        For i = 0 To Len(s)
            cuts = Mid(s, Len(s) - i, 1)
            If (cuts = "/") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 3) Then
                ratBackSlash = Right(s, i)
                ratBackSlash = chgSlash(ratBackSlash)
                Exit For
            End If
        Next

    End Function
    Public Shared Function ChgBackSlash(ByVal s As String) As String  ' 450924 tws
        ChgBackSlash = ""
        Dim i As Integer
        Dim c As String
        For i = 1 To Len(s)
            c = Mid(s, i, 1)
            If c = "\" Then
                c = "/"
            End If
            ChgBackSlash = ChgBackSlash + c
        Next
    End Function
    Public Shared Function ChgBackSlashSave(ByVal s As String) As String  ' 450924 tws
        ChgBackSlashSave = ""
        Dim i As Integer
        Dim c As String
        For i = 1 To Len(s)
            c = Mid(s, i, 1)
            If c = "/" Then
                c = "\"
            End If
            ChgBackSlashSave = ChgBackSlashSave + c
        Next
    End Function

    Public Shared Function rat2(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim cuts As String
        Dim i As Integer
        For i = 0 To Len(s)
            cuts = Mid(s, Len(s) - i, 1)
            If (cuts = "\") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 2) Then
                rat2 = Right(s, i)
                Exit For
            End If
        Next
        rat2 = ""
    End Function

    Public Shared Function rat4(ByVal s As String) As String
        Dim cntlastslash As Integer = 0
        Dim i As Integer
        Dim cuts As String
        rat4 = ""
        For i = 0 To Len(s)
            cuts = Mid(s, Len(s) - i, 1)
            If (cuts = "/") Then cntlastslash = cntlastslash + 1
            If (cntlastslash = 1) Then
                rat4 = Right(s, i)
                Exit For
            End If
        Next
    End Function

    Public Shared Function space2line(ByVal s As String) As String
        Dim new_s = ""
        Dim tmp_s = ""
        Dim i As Integer
        For i = 1 To Len(s)
            tmp_s = Mid(s, i, 1)
            If (tmp_s = " ") Then
                new_s = new_s & "_"
            Else
                new_s = new_s & tmp_s
            End If
        Next
        space2line = new_s
    End Function
    Public Shared Function line2space(ByVal s As String) As String
        Dim new_s = ""
        Dim tmp_s = ""
        Dim i As Integer
        For i = 1 To Len(s)
            tmp_s = Mid(s, i, 1)
            If (tmp_s = "_") Then
                new_s = new_s & " "
            Else
                new_s = new_s & tmp_s
            End If
        Next
        line2space = new_s
    End Function
    Public Shared Function IsRegisterNoNumeric(ByVal REGNO As String)
        'On Error Resume Next
        Dim pos As Integer = InStr(REGNO, "/")
        If (pos = 0) Then ' No slash.  It has no year prefix
            If (IsNumeric(REGNO)) Then
                If (Not (IsNumeric(REGNO)) Or (FormatCurrency(REGNO) <= 0)) Then ' yjb 98/09/22
                    IsRegisterNoNumeric = False '0
                Else
                    IsRegisterNoNumeric = True '-1
                End If
            Else
                IsRegisterNoNumeric = False '0
            End If
        Else
            If (InStr(Trim(REGNO), "/") <> 3) Then
                IsRegisterNoNumeric = False '0
            Else
                If (IsNumeric(Mid(Trim(REGNO), 1, 2)) And IsNumeric(Mid(Trim(REGNO), 4))) Then
                    If (Not IsNumeric(Mid(Trim(REGNO), 1, 2)) Or CDbl(Mid(Trim(REGNO), 4, 12)) <= 0) Then
                        IsRegisterNoNumeric = False '0
                    Else
                        IsRegisterNoNumeric = True '-1 is numeric
                    End If
                Else
                    IsRegisterNoNumeric = False '0
                End If
            End If
        End If
    End Function
    Public Shared Function ccurconvregno(ByVal s As String) As String
        If (s = "") Or (s = "-") Then
            ccurconvregno = "-"
        Else
            If ((InStr(Trim(s), "/") = 3)) Then
                Dim prestr = Mid(Trim(s), 1, 3)
                Dim tmpstr = Mid(Trim(s), 4)
                Dim tmpStr1 = ""
                If (InStr(tmpstr, ".") <> 0) And (CDbl(Mid(tmpstr, InStr(tmpstr, ".") + 1)) <> 0) Then
                    If (Len(Mid(tmpstr, InStr(tmpstr, ".") + 1)) < 2) Then
                        tmpStr1 = CDbl(Mid(tmpstr, 1, InStr(tmpstr, ".") - 1)) & ".0" & Mid(tmpstr, InStr(tmpstr, ".") + 1).ToString
                    Else
                        tmpStr1 = CDbl(Mid(tmpstr, 1, InStr(tmpstr, ".") - 1)) & "." & Mid(tmpstr, InStr(tmpstr, ".") + 1).ToString
                    End If
                Else
                    tmpStr1 = CDbl(tmpstr).ToString
                End If
                ccurconvregno = prestr & tmpStr1
            Else
                Dim lasts As String = CDbl(Mid(s, InStr(s, ".") + 1)).ToString
                If (InStr(s, ".") <> 0) And (lasts <> 0) Then
                    If (Len(Mid(s, InStr(s, ".") + 1)) < 2) Then
                        ccurconvregno = CDbl(Mid(s, 1, InStr(s, ".") - 1)) & ".0" & Mid(s, InStr(s, ".") + 1)
                    Else
                        ccurconvregno = CDbl(Mid(s, 1, InStr(s, ".") - 1)) & "." & Mid(s, InStr(s, ".") + 1)
                    End If
                Else
                    ccurconvregno = CType(s, Integer).ToString
                End If
            End If
        End If
    End Function
    Public Shared Function convregno(ByVal s As String) As String
        If (s = "") Or (s = "-") Then
            convregno = "-"
        Else
            Dim prestr = Mid(Trim(s), 1, 3)
            Dim tmpstr = Mid(Trim(s), 4)
            Dim tmpStr1 = ""
            Dim tmpStr2 = ""
            Dim i As Integer
            If ((InStr(Trim(s), "/") = 3)) Then
                prestr = Mid(Trim(s), 1, 3)
                tmpstr = Mid(Trim(s), 4)
                If (InStr(tmpstr, ".") <> 0) Then
                    If (Len(Mid(tmpstr, InStr(tmpstr, ".") + 1)) < 2) Then
                        tmpStr1 = CDbl(Mid(tmpstr, 1, InStr(tmpstr, ".") - 1)) & ".0" & Mid(tmpstr, InStr(tmpstr, ".") + 1).ToString
                    Else
                        tmpStr1 = CDbl(Mid(tmpstr, 1, InStr(tmpstr, ".") - 1)) & "." & Mid(tmpstr, InStr(tmpstr, ".") + 1).ToString
                    End If
                Else
                    tmpStr1 = Trim(s)
                End If
                For i = 1 To 12 - Len(tmpStr1)
                    tmpStr2 = tmpStr2 & "0"
                Next
                If ((InStr(Trim(s), "/") = 3)) Then
                    If InStr(Trim(s), ".") > 0 Then
                        convregno = prestr & Trim(tmpStr2) & tmpstr
                    Else
                        convregno = prestr & Trim(tmpStr2) & tmpstr & ".00"
                    End If
                Else
                    convregno = prestr & Trim(tmpStr2) & tmpStr1
                End If
            Else
                tmpstr = s
                On Error Resume Next
                tmpStr1 = FormatNumber(tmpstr, 2, 0, 0, 0)
                If Err.Number = 0 Then
                    For i = 1 To 15 - Len(tmpStr1)
                        tmpStr2 = tmpStr2 & "0"
                    Next
                    convregno = tmpStr2 & tmpStr1
                Else
                    convregno = s
                End If
            End If
        End If
    End Function
    Public Shared Function convregno7(ByVal s As String) As String
        If (Trim(s) = "") Or (Trim(s) = "-") Then
            convregno7 = "0000000.00"
        Else
            Dim tmpstr As String = s
            Dim tmpStr1 As String = FormatNumber(tmpstr, 2, 0, 0, 0).ToString
            Dim tmpstr2 As String = ""
            Dim i As Integer
            For i = 1 To 10 - Len(tmpStr1)
                tmpstr2 = tmpstr2 & "0"
            Next
            convregno7 = tmpstr2 & tmpStr1
        End If
    End Function
    
    'Public Shared Function getControlBookdate() As String
    '    Dim strtmpdate = ""
    '    Dim Firstshowdate = ""
    '    Dim ShowCtrlBookDate As Date
    '    Firstshowdate = Today - ShowCtrlBookDate
    '    strtmpdate = Mid(Firstshowdate, 1, 6) & CInt(Right(Firstshowdate, 4))
    '    Dim iDateTime As New iDateTimeSystem
    '    getControlBookdate = iDateTimeSystem.convertdate(strtmpdate)
    'End Function
    Public Shared Function FullTextFormat(ByVal strMsg As String) As String
        Dim strTmpMsg As String = strMsg
        Dim strTmpMsg1 As String = ""
        Do While InStr(strTmpMsg, " ") > 0
            strTmpMsg1 = strTmpMsg1 & Trim(Mid(strTmpMsg, 1, InStr(strTmpMsg, " ") - 1))
            strTmpMsg = Mid(strTmpMsg, InStr(strTmpMsg, " ") + 1)
        Loop
        FullTextFormat = Trim(strTmpMsg1 & strTmpMsg)
    End Function
    Public Shared Function FormatRegTTandT(ByVal DocRegisterno As String) As String
        FormatRegTTandT = ""
        If CLng(DocRegisterno) < 1000 Then
            If CLng(DocRegisterno) < 10 Then
                FormatRegTTandT = "00" & CLng(DocRegisterno).ToString
            ElseIf CLng(DocRegisterno) >= 10 And CLng(DocRegisterno) < 100 Then
                FormatRegTTandT = "0" & CLng(DocRegisterno).ToString
            ElseIf CLng(DocRegisterno) >= 100 And CLng(DocRegisterno) < 1000 Then
                FormatRegTTandT = CLng(DocRegisterno).ToString
            End If
        Else
            FormatRegTTandT = CLng(DocRegisterno).ToString
        End If
    End Function
    Public Shared Function CutSign(ByVal strTmp)  '460306
        strTmp = Trim(strTmp)
        If (strTmp = "") Then
            strTmp = "-"
        Else
            Dim intPos As Integer = InStr(strTmp, "'")
            Do While intPos > 0
                strTmp = Mid(strTmp, 1, intPos - 2) & Mid(strTmp, intPos + 2)
                intPos = InStr(intPos + 3, strTmp, "'")
            Loop
        End If
        CutSign = Trim(strTmp)
    End Function
    Public Shared Function Cutminus(ByVal strTmp)  '460402
        strTmp = Trim(strTmp)
        If (strTmp = "") Then
            strTmp = "-"
        Else
            Dim intPos As Integer = InStr(strTmp, "-")
            If intPos > 0 And Trim(strTmp) <> "-" Then
                Do While intPos > 0
                    If intPos = 1 Then
                        strTmp = Mid(strTmp, intPos + 1)
                        intPos = InStr(intPos, strTmp, "-")
                    Else
                        strTmp = Mid(strTmp, 1, intPos - 2) & Mid(strTmp, intPos + 2)
                        intPos = InStr(intPos + 3, strTmp, "-")
                    End If

                Loop
            End If
        End If
        Cutminus = Trim(strTmp)
    End Function
    Public Shared Function Cutatmarksign(ByVal strTmp)  '460402
        strTmp = Trim(strTmp)
        If (strTmp = "") Then
            strTmp = ""
        Else
            Dim intPos As Integer = InStr(strTmp, "@")
            Do While intPos > 0
                strTmp = Mid(strTmp, 1, intPos - 2) & Mid(strTmp, intPos + 2)
                intPos = InStr(intPos + 3, strTmp, "@")
            Loop
        End If
        Cutatmarksign = Trim(strTmp)
    End Function
    Public Shared Function CutCommaSign(ByVal Strtmp, ByVal Signpos)
        Strtmp = Trim(Strtmp)
        Dim ResultstrTmp As String = ""
        If (Strtmp = "") Then
            Strtmp = "-"
        Else
            Dim intPos As Integer = InStr(Strtmp, ",")
            Dim itempos As Integer

            Do While intPos > 0
                itempos = itempos + 1
                If itempos = Signpos Then
                    ResultstrTmp = Mid(Strtmp, 1, intPos - 1)
                Else
                    Strtmp = Mid(Strtmp, intPos + 2)
                    intPos = InStr(Strtmp, ",")
                End If
            Loop
        End If
        CutCommaSign = Trim(ResultstrTmp)
    End Function
    Public Shared Function ratdot(ByVal s, ByVal p) As String   ' 450610 tws
        Dim cntdot As Integer = 0
        Dim cuts As String
        Dim i As Integer
        Dim strReturn As String = ""
        For i = 0 To Len(s)
            cuts = Mid(s, Len(s) - i, 1)
            If cuts = "." Then
                cntdot = cntdot + 1
            End If
            If cntdot = p Then
                strReturn = UCase(Right(s, i))
                Return strReturn
                Exit Function
            End If
        Next
        Return strReturn
    End Function
    Public Shared Function getString(ByVal StringBin)
        getString = ""
        For intCount As Integer = 1 To Len(StringBin)
            getString = getString & Chr(Asc(Mid(StringBin, intCount, 1)))
        Next
    End Function

    
    
    
    



    
    Public Shared Function stateicon(ByVal statecode As String, ByVal viewstatus As String, ByVal registerdate As String, ByVal maxtime As String) As HyperLink
        Dim HpLink As New HyperLink
        Dim yr As String
        Dim maxyy As String
        Dim d1 As String
        Dim d2 As String
        Select Case statecode
            Case "00"
                If (viewstatus = 0) Then
                    If (Trim(maxtime) <> "-") And (Trim(maxtime) <> "") Then
                        yr = Year(Today).ToString
                        maxyy = Mid(Trim(maxtime), 1, 4)
                        d1 = DateSerial(yr, Month(Today), Day(Today)).ToString   ' today date
                        d2 = DateSerial(maxyy, Mid(Trim(maxtime), 6, 2), Mid(Trim(maxtime), 9, 2)).ToString  ' maxtime
                        If (d2 < d1) Then
                            HpLink.ImageUrl = "images/receive!.gif"
                            HpLink.ToolTip = "เรื่องนี้ยังไม่ได้เปิดอ่าน และเลยเวลาที่กำหนด"
                            'stateicon = "<img src='../images/skin1/icons/receive!.gif' alt='เรื่องนี้ยังไม่ได้เปิดอ่าน และเลยเวลาที่กำหนด'>"
                        Else
                            HpLink.ImageUrl = "images/receive.gif"
                            HpLink.ToolTip = "เรื่องนี้ยังไม่ได้เปิดอ่าน"
                            'stateicon = "<img src='../images/skin1/icons/receive.gif' alt='เรื่องนี้ยังไม่ได้เปิดอ่าน'>"
                        End If
                    Else
                        HpLink.ImageUrl = "images/receive.gif"
                        HpLink.ToolTip = "เรื่องนี้ยังไม่ได้เปิดอ่าน"
                        'stateicon = "<img src='../images/skin1/icons/receive.gif' alt='เรื่องนี้ยังไม่ได้เปิดอ่าน'>"
                    End If
                Else
                    HpLink.ImageUrl = "images/open.gif"
                    HpLink.ToolTip = "เรื่องนี้เปิดอ่านแล้ว"
                    'stateicon = "<img src='../images/skin1/icons/open.gif' alt='เรื่องนี้เปิดอ่านแล้ว'>"
                End If
            Case "01"
                HpLink.ImageUrl = "images/check2.gif"
                HpLink.ToolTip = "อยู่ระหว่างการตรวจสอบ"
                'stateicon = "<img src='../images/skin1/icons/check2.gif' alt='อยู่ระหว่างการตรวจสอบ'>"
            Case "02"
                If (Trim(maxtime) <> "-") And (Trim(maxtime) <> "") Then
                    yr = Year(Today)
                    maxyy = Mid(Trim(maxtime), 1, 4)
                    d1 = DateSerial(yr, Month(Today), Day(Today)).ToString   ' today date
                    d2 = DateSerial(maxyy, Mid(Trim(maxtime), 6, 2), Mid(Trim(maxtime), 9, 2)).ToString  ' maxtime
                    If (d2 < d1) Then
                        HpLink.ImageUrl = "images/process!.gif"
                        HpLink.ToolTip = "งานล่าช้า"
                        'stateicon = "<img src='../images/skin1/icons/process!.gif' alt='งานล่าช้า'>"
                    Else
                        HpLink.ImageUrl = "images/process.gif"
                        HpLink.ToolTip = "กำลังดำเนินการ"
                        'stateicon = "<img src='../images/skin1/icons/process.gif' alt='กำลังดำเนินการ'>"
                    End If
                Else
                    HpLink.ImageUrl = "images/process.gif"
                    HpLink.ToolTip = "กำลังดำเนินการ"
                    'stateicon = "<img src='../images/skin1/icons/process.gif' alt='กำลังดำเนินการ'>"
                End If
            Case "03"  ',"09"  
                HpLink.ImageUrl = "images/finish.gif"
                HpLink.ToolTip = "ส่งเรื่องต่อไปแล้ว"
                'stateicon = "<img src='../images/skin1/icons/finish.gif' alt='ส่งเรื่องต่อไปแล้ว'>"
            Case "09"
                HpLink.ImageUrl = "images/finish2.gif"
                HpLink.ToolTip = "ปิดงานแล้ว"
                'stateicon = "<img src='../images/skin1/icons/finish2.gif' alt='ปิดงานแล้ว'>"
            Case "10"
                HpLink.ImageUrl = "images/deleted.gif"
                HpLink.ToolTip = "ลบทิ้งแล้ว"
                'stateicon = "<img src='../images/skin1/icons/deleted.gif' alt='ลบทิ้งแล้ว'>"
            Case "11"
                HpLink.ImageUrl = "images/canceled.gif"
                HpLink.ToolTip = "ยกเลิกแล้ว"
                'stateicon = "<img src='../images/skin1/icons/canceled.gif' alt='ยกเลิกแล้ว'>"
            Case "12"
                HpLink.ImageUrl = "images/hold.gif"
                HpLink.ToolTip = "ดึงกลับ/ตีกลับเอกสาร"
                'stateicon = "<img src='../images/skin1/icons/hold.gif' alt='ดึงกลับ/ตีกลับเอกสาร'>"
            Case "99"
                HpLink.ImageUrl = "images/filing.gif"
                HpLink.ToolTip = "จัดเก็บเรื่องในตู้เอกสารแล้ว"
                'stateicon = "<img src='../images/skin1/icons/filing.gif' alt='จัดเก็บเรื่องในตู้เอกสารแล้ว'>"
            Case "92"
                HpLink.ImageUrl = "images/filing18.gif"
                HpLink.ToolTip = "เก็บลงแฟ้มเลข 18 หลัก"
                'stateicon = "<img src='../images/skin1/icons/filing18.gif' alt='เก็บลงแฟ้มเลข 18 หลัก'>"
            Case "98"
                HpLink.ImageUrl = "images/moved1.gif"
                HpLink.ToolTip = "โอนเอกสารข้ามปี"
                'stateicon = "<img src='../images/skin1/icons/moved1.gif' alt='โอนเอกสารข้ามปี'>"
        End Select
        Return HpLink
    End Function
    Public Shared Function priorityicon(ByVal prioritycode As String) As HyperLink
        Dim HpLink As New HyperLink
        Select Case prioritycode
            Case "00"
                HpLink.ImageUrl = "images/idle.gif"
                HpLink.ToolTip = "ปกติ"
                'priorityicon = "<img src='../images/skin1/icons/idle.gif' alt='ปกติ'>"
            Case "01"
                HpLink.ImageUrl = "images/urgent1.gif"
                HpLink.ToolTip = "ด่วน"
                'priorityicon = "<img src='../images/skin1/icons/urgent1.gif' alt='ด่วน'>"
            Case "02"
                HpLink.ImageUrl = "images/urgent2.gif"
                HpLink.ToolTip = "ด่วนมาก"
                'priorityicon = "<img src='../images/skin1/icons/urgent2.gif' alt='ด่วนมาก'>"
            Case "03"
                HpLink.ImageUrl = "images/urgent3.gif"
                HpLink.ToolTip = "ด่วนที่สุด"
                'priorityicon = "<img src='../images/skin1/icons/urgent3.gif' alt='ด่วนที่สุด'>"
            Case Else
                HpLink.ImageUrl = ""
                HpLink.ToolTip = ""
                'priorityicon = ""
        End Select
        Return HpLink
    End Function
    

    Public Shared Function getwtypeicon(ByVal s, ByVal bid, ByVal sbid, ByVal actioncode, ByVal registerbid, ByVal flagdelete) As String
        Dim Strflagdelete As String = ""
        Dim strReturn As String = ""
        If flagdelete = "1" Then
            Strflagdelete = "-ไม่มีเอกสารฉบับจริงส่งมา"
        Else
            Strflagdelete = "-"
        End If
        If (bid = sbid) Then
            Select Case s
                Case "01" : strReturn = "ลงรับเอกสาร"
                Case "00" : strReturn = "สร้างเอกสารภายใน"
                Case "02" : strReturn = "บันทึกเอกสารส่งภายนอก"
            End Select

            If (bid <> registerbid) Then strReturn = "รับสำเนา"
        Else
            Select Case actioncode
                Case "01"
                    If flagdelete = "1" Then
                        Strflagdelete = "-ไม่ส่งฉบับสำเนา"
                    Else
                        Strflagdelete = "-พร้อมส่งฉบับสำเนา"
                    End If
                    strReturn = "สำเนาถึง" & Strflagdelete
                Case Else
                    If flagdelete = "1" Then
                        Strflagdelete = "-ไม่ส่งต้นฉบับ"
                    Else
                        Strflagdelete = "-พร้อมส่งต้นฉบับ"
                    End If
                    strReturn = "ส่งถึง" & Strflagdelete
            End Select
        End If
        Return strReturn
    End Function

    
    
    Public Shared Function DisplayCountAttacment(ByVal strLanguage As String, ByVal intDocCount As Integer) As String
        'Add by tommy @2002207 for docadmin.aspx
        If (strLanguage = "EN") Then
            DisplayCountAttacment = intDocCount & " attachment(s)"
        Else
            DisplayCountAttacment = "<br> มีเอกสารแนบจำนวน <b>" & intDocCount & "</b> รายการ"
        End If
    End Function

    Public Shared Sub iAlert(ByRef page As Web.UI.Page, ByVal Message As String, Optional ByVal closePage As Boolean = False)
        If closePage = True Then
            page.ClientScript.RegisterStartupScript(page.GetType(), "clientScript", "alert('" & Message & "');self.close();", True)
        Else
            page.ClientScript.RegisterStartupScript(page.GetType(), "clientScript", "alert('" & Message & "');", True)
        End If
    End Sub

    Public Shared Sub iAlert(ByVal MyUpdatePanel As UpdatePanel, ByVal Message As String)
        ScriptManager.RegisterStartupScript(MyUpdatePanel, MyUpdatePanel.GetType(), "keyValue", "alert('" & Message & "')", True)
    End Sub

    Public Shared Sub RadAlert(ByRef page As Web.UI.Page, ByVal Message As String, Optional ByVal closePage As Boolean = False)
        If closePage = True Then
            page.ClientScript.RegisterStartupScript(page.GetType(), "clientScript", "window.top.radalert('" & Message & "');self.close();", True)
        Else
            page.ClientScript.RegisterStartupScript(page.GetType(), "clientScript", "window.top.radalert('" & Message & "');", True)
        End If
    End Sub

    'Public Shared Sub RadAlert(ByVal MyUpdatePanel As RadAjaxPanel, ByVal Message As String)
    '    'ScriptManager.RegisterStartupScript(MyUpdatePanel, MyUpdatePanel.GetType(), "keyValue", "window.top.radalert('" & Message & "',0,0 , 'INFOMA Alert')", True)
    '    'MyUpdatePanel.ResponseScripts.Add("window.top.radalert('" & Message & "')")
    '    MyUpdatePanel.ResponseScripts.Add("window.top.radalert('" & Message & "',0,0 , 'INFOMA : iWebFlow.NET')")
    'End Sub
    ''' <summary>
    ''' target window
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LinkTargetWindow
        Self = 1
        Opener = 2
        Parent = 3
        Top = 4
    End Enum

    Public Shared Sub Confirm(ByVal MyUpdatePanel As UpdatePanel, ByVal Message As String)
        Dim strJavaScript = "results=confirm('" & Message & "');" & _
                            "if (results=='1'){alert('True')}else{alert('False')}"
        ScriptManager.RegisterStartupScript(MyUpdatePanel, MyUpdatePanel.GetType(), "keyValue", strJavaScript, True)
    End Sub

    Public Shared Sub Confirm(ByRef page As Web.UI.Page, ByVal Message As String, ByVal TrueURL As String, _
                    Optional ByVal FalseURL As String = "", _
                    Optional ByVal TargetWindow As LinkTargetWindow = LinkTargetWindow.Self)

        Dim strCallBackFunction As String = ""
        Select Case TargetWindow
            Case LinkTargetWindow.Self : TrueURL = "window.location.href='" & TrueURL & "'"
            Case LinkTargetWindow.Opener : TrueURL = "window.opener.location.href='" & TrueURL & "'"
            Case LinkTargetWindow.Parent : TrueURL = "window.parent.location.href='" & TrueURL & "'"
            Case LinkTargetWindow.Top : TrueURL = "window.top.location.href='" & TrueURL & "'"
        End Select
        If FalseURL <> "" Then
            Select Case TargetWindow
                Case LinkTargetWindow.Self : FalseURL = "window.location.href='" & FalseURL & "'"
                Case LinkTargetWindow.Opener : FalseURL = "window.opener.location.href='" & FalseURL & "'"
                Case LinkTargetWindow.Parent : FalseURL = "window.parent.location.href='" & FalseURL & "'"
                Case LinkTargetWindow.Top : FalseURL = "window.top.location.href='" & FalseURL & "'"
            End Select
        End If
        strCallBackFunction = "function confirmCallBackFn(arg)" & _
                                "{" & _
                                    "if (arg==true){" & TrueURL & "}else{" & FalseURL & "}" & _
                                "}"

        Dim strJavaScript = "results=window.top.radconfirm('" & Message & "',confirmCallBackFn);" & _
                            "" & strCallBackFunction & ""
        page.ClientScript.RegisterStartupScript(page.GetType(), "clientScript", strJavaScript, True)
    End Sub

    'Public Shared Sub RadConfirm(ByRef MyUpdatePanel As RadAjaxPanel, ByVal Message As String, Optional ByVal TrueURL As String = "", _
    '                Optional ByVal FalseURL As String = "", _
    '                Optional ByVal TargetWindow As LinkTargetWindow = LinkTargetWindow.Self)

    '    Dim strCallBackFunction As String = ""
    '    If TrueURL <> "" Then
    '        Select Case TargetWindow
    '            Case LinkTargetWindow.Self : TrueURL = "window.location.href='" & TrueURL & "'"
    '            Case LinkTargetWindow.Opener : TrueURL = "window.opener.location.href='" & TrueURL & "'"
    '            Case LinkTargetWindow.Parent : TrueURL = "window.parent.location.href='" & TrueURL & "'"
    '            Case LinkTargetWindow.Top : TrueURL = "window.top.location.href='" & TrueURL & "'"
    '        End Select
    '    End If

    '    If FalseURL <> "" Then
    '        Select Case TargetWindow
    '            Case LinkTargetWindow.Self : FalseURL = "window.location.href='" & FalseURL & "'"
    '            Case LinkTargetWindow.Opener : FalseURL = "window.opener.location.href='" & FalseURL & "'"
    '            Case LinkTargetWindow.Parent : FalseURL = "window.parent.location.href='" & FalseURL & "'"
    '            Case LinkTargetWindow.Top : FalseURL = "window.top.location.href='" & FalseURL & "'"
    '        End Select
    '    End If
    '    strCallBackFunction = "function confirmCallBackFn(arg)" & _
    '                            "{" & _
    '                                "if (arg==true){" & TrueURL & "}else{" & FalseURL & "}" & _
    '                            "}"
    '    Dim strJavaScript = "results=window.top.radconfirm('" & Message & "', confirmCallBackFn, 0, 0, null,'INFOMA : WebFlow.NET');" & _
    '                        "" & strCallBackFunction & ""
    '    MyUpdatePanel.ResponseScripts.Add(strJavaScript)
    'End Sub
End Class
