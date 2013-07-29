Imports Microsoft.VisualBasic

Public Class Class1

    Shared Function CompararString(str1 As String, str2 As String) As String

        Dim _str1 As String() = str1.Split({vbNewLine}, StringSplitOptions.None)
        Dim _str2 As String() = str2.Split({vbNewLine}, StringSplitOptions.None)
        Dim str3 As String = ""

        For i = 0 To Math.Max(_str1.Length, _str2.Length) - 1 ' Circulo entre la mayor cantidad de lineas 
            If i <= Math.Min(_str1.Length, _str2.Length) - 1 Then ' Si estoy dentro del area comun comparo valores
                If _str1(i) = _str2(i) Then ' Si el nuevo valor es igual al original
                    str3 = str3 & "= " & _str1(i) & vbNewLine ' lo marco con =
                Else
                    If _str2(i) = "" Then ' Si el nuevo valor fue borrado
                        str3 = str3 & "- " & _str2(i) & vbNewLine ' los marco con -
                    Else ' Si es distinto
                        str3 = str3 & "+ " & _str2(i) & vbNewLine ' los marco con +
                    End If
                End If
            Else ' Cuando loopeo en lineas nuevas/eliminadas
                If _str1.Length > _str2.Length Then ' Si el texto tiene menos linea
                    str3 = str3 & "- " & vbNewLine ' Marco como las que faltan con -
                Else ' Si el texto nuevo tiene mas lineas
                    str3 = str3 & "+ " & _str2(i) & vbNewLine ' Marco las nuevas con + 
                End If
            End If

        Next

        Return str3

    End Function

    'Shared Function CompararString(ByVal TextoInicial As String, ByVal TextoActual As String) As String
    '    Dim A() As String = Split(TextoActual, vbCrLf, -1, vbTextCompare) 'Cuento las lineas
    '    Dim B() As String = Split(TextoInicial, vbCrLf, -1, vbTextCompare)
    '    Dim str_Cantidad As Integer = (UBound(A) + 1) 'Guardo las lineas actuales, en una variable integer, sumando 1 salto de linea que no es contado
    '    Dim str_CantidadOld As Integer = (UBound(B) + 1)
    '    Dim i As Integer
    '    Dim LineaNEW As String, LineaOLD As String, TextoFinal As String, ChrActual As Integer, ChrInicial As Integer, chrActualAnt As Integer, chrInicialAnt As Integer

    '    If str_CantidadOld > str_Cantidad Then 'si hay menos lineas
    '        For i = 1 To str_CantidadOld
    '            If i = 1 Then
    '                If InStr(TextoActual, vbCrLf) > 0 Then ChrActual = InStr(TextoActual, vbCrLf)
    '                If InStr(TextoInicial, vbCrLf) > 0 Then ChrInicial = InStr(TextoInicial, vbCrLf)
    '                If i <= str_Cantidad Then LineaNEW = Trim(Left(TextoActual, ChrActual - 1)) 'Probar si es -1 -2 o -3
    '                LineaOLD = Trim(Left(TextoInicial, ChrInicial - 1)) 'Probar si es -1 -2 o -3

    '                If LineaNEW = LineaOLD Then
    '                    TextoFinal = LineaOLD
    '                Else
    '                    If Not InStr(TextoActual, LineaOLD) > 0 Then TextoFinal = "-" & Trim(LineaOLD)
    '                    If i <= str_Cantidad Then
    '                        If Not InStr(TextoInicial, LineaNEW) > 0 Then TextoFinal = "+" & Trim(LineaNEW)
    '                    End If
    '                End If

    '            ElseIf i = str_CantidadOld Then
    '                If Len(TextoActual) > ChrActual Then LineaNEW = Trim(Mid(TextoActual, chrActualAnt + 2))
    '                If Len(TextoInicial) > ChrInicial Then LineaOLD = Trim(Mid(TextoInicial, chrInicialAnt + 2))

    '                If LineaNEW = LineaOLD Then
    '                    TextoFinal = TextoFinal & vbCrLf & LineaOLD
    '                Else
    '                    If Not InStr(TextoActual, LineaOLD) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "-" & Trim(LineaOLD)
    '                    If Not InStr(TextoInicial, LineaNEW) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "+" & Trim(LineaNEW)
    '                End If
    '            Else
    '                If InStr(ChrActual + 1, TextoActual, vbCrLf) > 0 Then
    '                    ChrActual = InStr(ChrActual + 1, TextoActual, vbCrLf)
    '                    If Len(TextoActual) > ChrActual Then LineaNEW = Trim(Mid(TextoActual, chrActualAnt + 2, (ChrActual - chrActualAnt) - 1))
    '                End If
    '                If InStr(ChrInicial + 2, TextoInicial, vbCrLf) > 0 Then
    '                    ChrInicial = InStr(ChrInicial + 2, TextoInicial, vbCrLf)
    '                    If Len(TextoInicial) > ChrInicial Then LineaOLD = Trim(Mid(TextoInicial, chrInicialAnt + 2, (ChrInicial - chrInicialAnt) - 1))
    '                End If

    '                If LineaNEW = LineaOLD Then
    '                    TextoFinal = TextoFinal & vbCrLf & LineaOLD
    '                Else
    '                    If Not InStr(TextoActual, LineaOLD) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "-" & Trim(LineaOLD)
    '                    If Not InStr(TextoInicial, LineaNEW) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "+" & Trim(LineaNEW)
    '                End If

    '            End If
    '            chrActualAnt = ChrActual
    '            chrInicialAnt = ChrInicial
    '        Next
    '    ElseIf str_CantidadOld < str_Cantidad Then 'si hay mas lineas
    '        For i = 1 To str_Cantidad
    '            If i = 1 Then
    '                If InStr(TextoActual, vbCrLf) > 0 Then ChrActual = InStr(TextoActual, vbCrLf)
    '                If InStr(TextoInicial, vbCrLf) > 0 Then ChrInicial = InStr(TextoInicial, vbCrLf)
    '                If i <= str_Cantidad Then LineaNEW = Trim(Left(TextoActual, ChrActual - 1)) 'Probar si es -1 -2 o -3
    '                LineaOLD = Trim(Left(TextoInicial, ChrInicial - 1)) 'Probar si es -1 -2 o -3

    '                If LineaNEW = LineaOLD Then
    '                    TextoFinal = LineaOLD
    '                Else
    '                    If Not InStr(TextoActual, LineaOLD) > 0 Then TextoFinal = "-" & Trim(LineaOLD)
    '                    If i <= str_Cantidad Then
    '                        If Not InStr(TextoInicial, LineaNEW) > 0 Then TextoFinal = "+" & Trim(LineaNEW)
    '                    End If
    '                End If

    '            ElseIf i = str_CantidadOld Then
    '                If Len(TextoActual) > ChrActual Then LineaNEW = Trim(Mid(TextoActual, chrActualAnt + 2))
    '                If Len(TextoInicial) > ChrInicial Then LineaOLD = Trim(Mid(TextoInicial, chrInicialAnt + 2))

    '                If LineaNEW = LineaOLD Then
    '                    TextoFinal = TextoFinal & vbCrLf & LineaOLD
    '                Else
    '                    If Not InStr(TextoActual, LineaOLD) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "-" & Trim(LineaOLD)
    '                    If Not InStr(TextoInicial, LineaNEW) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "+" & Trim(LineaNEW)
    '                End If
    '            Else
    '                If InStr(ChrActual + 1, TextoActual, vbCrLf) > 0 Then
    '                    ChrActual = InStr(ChrActual + 1, TextoActual, vbCrLf)
    '                    If Len(TextoActual) > ChrActual Then LineaNEW = Trim(Mid(TextoActual, chrActualAnt + 2, (ChrActual - chrActualAnt) - 1))
    '                End If
    '                If InStr(ChrInicial + 2, TextoInicial, vbCrLf) > 0 Then
    '                    ChrInicial = InStr(ChrInicial + 2, TextoInicial, vbCrLf)
    '                    If Len(TextoInicial) > ChrInicial Then LineaOLD = Trim(Mid(TextoInicial, chrInicialAnt + 2, (ChrInicial - chrInicialAnt) - 1))
    '                End If

    '                If LineaNEW = LineaOLD Then
    '                    TextoFinal = TextoFinal & vbCrLf & LineaOLD
    '                Else
    '                    If Not InStr(TextoActual, LineaOLD) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "-" & Trim(LineaOLD)
    '                    If Not InStr(TextoInicial, LineaNEW) > 0 Then TextoFinal = Trim(TextoFinal) & vbCrLf & "+" & Trim(LineaNEW)
    '                End If

    '            End If
    '            chrActualAnt = ChrActual
    '            chrInicialAnt = ChrInicial
    '        Next
    '    End If

    '    Return TextoFinal
    'End Function

End Class
