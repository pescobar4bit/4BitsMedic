Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections

Public Class clsTicket
    Private headerLines As ArrayList = New ArrayList
    Private subHeaderLines As ArrayList = New ArrayList
    Private items As ArrayList = New ArrayList
    Private totales As ArrayList = New ArrayList
    Private footerLines As ArrayList = New ArrayList
    Private headerImage As Image = Nothing
    Private count As Integer = 0
    Private maxChar As Integer = 32
    Private maxCharDescription As Integer = 22
    Private imageHeight As Integer = 0
    Private leftMargin As Single = 0
    Private topMargin As Single = 0
    Private fontName As String = "Lucida Console"
    Private fontSize As Integer = 9
    Private printFont As Font = Nothing
    Private myBrush As SolidBrush = New SolidBrush(Color.Black)
    Private gfx As Graphics = Nothing
    Private line As String = Nothing
    '' Private myBrush2 As SolidBrush = New SolidBrush(Color.Red)
    Private wColor As Integer = 1
    Public Sub New()
        MyBase.New()
    End Sub
    Public Property cambiarColorImpresion() As Integer
        Get
            Return wColor
        End Get
        Set(ByVal value As Integer)
            If value = 1 Then
                myBrush = Nothing
                myBrush = New SolidBrush(Color.Black)
            Else
                myBrush = Nothing
                myBrush = New SolidBrush(Color.Red)
            End If
            wColor = value
        End Set
    End Property
    Public Property T_MaxChar() As Integer
        Get
            Return maxChar
        End Get
        Set(ByVal value As Integer)
            If (value <> maxChar) Then
                maxChar = value
            End If
        End Set
    End Property
    Public Property T_MaxCharDescription() As Integer
        Get
            Return maxCharDescription
        End Get
        Set(ByVal value As Integer)
            If (value <> maxCharDescription) Then
                maxCharDescription = value
            End If
        End Set
    End Property
    Public Property T_FontSize() As Integer
        Get
            Return fontSize
        End Get
        Set(ByVal value As Integer)
            If (value <> fontSize) Then
                fontSize = value
            End If
        End Set
    End Property
    Public Property T_FontName() As String
        Get
            Return fontName
        End Get
        Set(ByVal value As String)
            If (value <> fontName) Then
                fontName = value
            End If
        End Set
    End Property
    Public Sub AddHeaderLine(ByVal line As String)
        headerLines.Add(line)
    End Sub
    Public Sub AddSubHeaderLine(ByVal line As String)
        subHeaderLines.Add(line)
    End Sub
    Public Sub AddItem(ByVal cantidad As String, ByVal item As String, ByVal price As String, Optional ByVal Descripcion2 As String = "")
        Dim newItem As OrderItem = New OrderItem(Microsoft.VisualBasic.ChrW(63))

        If Descripcion2 <> "" Then
            items.Add(newItem.GenerateItem(cantidad, item, price, Descripcion2))
        Else
            items.Add(newItem.GenerateItem(cantidad, item, price))
        End If
    End Sub
    Public Sub AddTotal(ByVal name As String, ByVal price As String)
        Dim newTotal As OrderTotal = New OrderTotal(Microsoft.VisualBasic.ChrW(63))
        totales.Add(newTotal.GenerateTotal(name, price))
    End Sub
    Public Sub AddFooterLine(ByVal line As String)
        footerLines.Add(line)
    End Sub
    Public Sub AddLineaTexto(ByVal line As String)
        DrawLineaEspecifica(line)
    End Sub
    Private Function AlignRightText(ByVal lenght As Integer) As String
        Dim espacios As String = ""
        Dim spaces As Integer = (maxChar - lenght)
        Dim x As Integer = 0
        Do While (x < spaces)
            espacios = (espacios + " ")
            x = (x + 1)
        Loop
        Return espacios
    End Function
    Private Function AjustarEspacios(ByVal lenght As Integer, ByVal spaces As Integer) As String
        Dim espacios As String = ""
        spaces = (spaces - lenght)
        Dim x As Integer = 0
        Do While (x < spaces)
            espacios = (espacios + " ")
            x = (x + 1)
        Loop
        Return espacios
    End Function
    Private Function DottedLine() As String
        Dim dotted As String = ""
        Dim x As Integer = 0
        Do While (x < maxChar)
            dotted = (dotted + "=")
            x = (x + 1)
        Loop
        Return dotted
    End Function
    Public Function PrinterExists(ByVal impresora As String) As Boolean
        For Each strPrinter As String In PrinterSettings.InstalledPrinters
            If (impresora = strPrinter) Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub PrintTicket(ByVal impresora As String)
        printFont = New Font(fontName, fontSize, FontStyle.Regular)
        Dim PageRanking As PrintDocument = New PrintDocument
        'Dim ps As New PaperSize("Custom", 269, 8000)'para cambiar tamano

        '        PageRanking.DefaultPageSettings.PaperSize = ps

        PageRanking.PrinterSettings.PrinterName = impresora
        AddHandler PageRanking.PrintPage, AddressOf Me.pr_PrintPage
        PageRanking.Print()

    End Sub
    Public Sub PrintTicketEntrega(ByVal impresora As String)
        printFont = New Font(fontName, fontSize, FontStyle.Regular)
        Dim PageRanking As PrintDocument = New PrintDocument
        PageRanking.PrinterSettings.PrinterName = impresora
        AddHandler PageRanking.PrintPage, AddressOf Me.pr_PrintPageTicket
        PageRanking.Print()
    End Sub
    Public Sub PrintTicketDevolucion(ByVal impresora As String)
        printFont = New Font(fontName, fontSize, FontStyle.Regular)
        Dim PageRanking As PrintDocument = New PrintDocument
        PageRanking.PrinterSettings.PrinterName = impresora
        AddHandler PageRanking.PrintPage, AddressOf Me.pr_PrintPageDev
        PageRanking.Print()
    End Sub
    Private Sub pr_PrintPageTicket(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.PageUnit = GraphicsUnit.Millimeter
        gfx = e.Graphics
        'DrawImage()
        DrawHeader()
        DrawSubHeader()
        'DrawItems()
        DibujaItems()
        'DrawTotales()
        DibujaTotales()
        DrawFooter()
        'If (Not (headerImage) Is Nothing) Then
        ' headerImage.Dispose()
        ' headerImage.Dispose()
        'End If
    End Sub
    Private Sub pr_PrintPageDev(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.PageUnit = GraphicsUnit.Millimeter
        gfx = e.Graphics
        DrawHeader()
        DrawSubHeader()
        DibujaItemsDev()
        DibujaTotales()
        DrawFooter()
    End Sub
    Private Sub pr_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.PageUnit = GraphicsUnit.Millimeter
        gfx = e.Graphics
        DrawHeader()
        DrawSubHeader()
        DrawLine()
        DrawItems()
        DrawTotales()
        DrawFooter()

    End Sub
    Private Function YPosition() As Single
        Return (topMargin _
        + ((count * printFont.GetHeight(gfx)) _
        + imageHeight))
    End Function
    Private Sub DrawImage()
        If (Not (headerImage) Is Nothing) Then
            Try
                gfx.DrawImage(headerImage, New Point(CType(leftMargin, Integer), CType(YPosition(), Integer)))
                Dim height As Double = ((CType(headerImage.Height, Double) / 58) _
                * 15)
                imageHeight = (CType(Math.Round(height), Integer) + 3)
            Catch e As Exception
            End Try
        End If
    End Sub
    Private Sub DrawHeader()

        Dim printFontHeader = New Font(fontName, fontSize, FontStyle.Regular)


        For Each header As String In headerLines
            If (header.Length > maxChar) Then
                Dim currentChar As Integer = 0
                Dim headerLenght As Integer = header.Length

                While (headerLenght > maxChar)
                    line = header.Substring(currentChar, maxChar)
                    ''*****************************
                    If Len(line) = 0 Then

                        myBrush = Nothing
                        myBrush = New SolidBrush(Color.Black)
                    ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                        myBrush = Nothing
                        myBrush = New SolidBrush(Color.Red)
                        line = Mid(line, 1, Len(line) - 1)
                    Else
                        myBrush = Nothing
                        myBrush = New SolidBrush(Color.Black)
                    End If
                    ''***********************
                    gfx.DrawString(line, printFontHeader, myBrush, leftMargin, YPosition, New StringFormat)
                    count = (count + 1)
                    currentChar = (currentChar + maxChar)
                    headerLenght = (headerLenght - maxChar)
                End While
                line = header
                ''*****************************
                If Len(line) = 0 Then

                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Red)
                    line = Mid(line, 1, Len(line) - 1)
                Else
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                End If
                ''***********************
                gfx.DrawString(line.Substring(currentChar, (line.Length - currentChar)), printFontHeader, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            Else
                line = header
                ''*****************************
                If Len(line) = 0 Then

                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Red)
                    line = Mid(line, 1, Len(line) - 1)
                Else
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                End If
                ''***********************
                gfx.DrawString(line, printFontHeader, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            End If
        Next
        DrawEspacio()
    End Sub
    Private Sub DrawLine()
        line = DottedLine()
        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
    End Sub
    Private Sub DrawSubHeader()
        For Each subHeader As String In subHeaderLines
            If (subHeader.Length > maxChar) Then
                Dim currentChar As Integer = 0
                Dim subHeaderLenght As Integer = subHeader.Length
                While (subHeaderLenght > maxChar)
                    line = subHeader
                    ''*****************************
                    If Len(line) = 0 Then

                        myBrush = Nothing
                        myBrush = New SolidBrush(Color.Black)
                    ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                        myBrush = Nothing
                        myBrush = New SolidBrush(Color.Red)
                        line = Mid(line, 1, Len(line) - 1)
                    Else
                        myBrush = Nothing
                        myBrush = New SolidBrush(Color.Black)
                    End If
                    ''***********************
                    gfx.DrawString(line.Substring(currentChar, maxChar), printFont, myBrush, leftMargin, YPosition, New StringFormat)
                    count = (count + 1)
                    currentChar = (currentChar + maxChar)
                    subHeaderLenght = (subHeaderLenght - maxChar)
                End While
                line = subHeader
                ''*****************************
                If Len(line) = 0 Then

                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Red)
                    line = Mid(line, 1, Len(line) - 1)
                Else
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                End If
                ''***********************
                gfx.DrawString(line.Substring(currentChar, (line.Length - currentChar)), printFont, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            Else
                line = subHeader
                ''*****************************
                If Len(line) = 0 Then

                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Red)
                    line = Mid(line, 1, Len(line) - 1)
                Else
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                End If
                ''***********************
                gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
                'line = DottedLine()
                'gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
                'count = (count + 1)
            End If
        Next
        DrawEspacio()
    End Sub
    Private Sub DrawItems()
        Dim maxCharDescriptionPersona As Integer = maxCharDescription
        Dim ordIt As OrderItem = New OrderItem(Microsoft.VisualBasic.ChrW(63))
        gfx.DrawString("CANT. PRODUCTO  TOTAL", printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
        DrawEspacio()
        Dim myBrushOri As SolidBrush = myBrush
        Dim printFontPersona = New Font(fontName, fontSize, FontStyle.Regular)
        For Each item As String In items
            line = ordIt.GetItemBoni(item)
            If line <> "" Then
                myBrush = Nothing
                myBrush = New SolidBrush(Color.Red)
            Else
                myBrush = Nothing
                myBrush = myBrushOri
            End If
            line = ordIt.GetItemCantidad(item)
            gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            line = ordIt.GetItemPrice(item)
            If line.Length >= 8 Then
                maxCharDescriptionPersona = maxCharDescriptionPersona - 2
            Else
                maxCharDescriptionPersona = maxCharDescription
            End If
            line = (AlignRightText(line.Length) + line)
            gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            Dim name As String = ordIt.GetItemName(item)
            leftMargin = 0
            If (name.Length > maxCharDescriptionPersona) Then
                Dim currentChar As Integer = 0
                Dim itemLenght As Integer = name.Length
                While (itemLenght > maxCharDescriptionPersona)
                    line = ordIt.GetItemName(item)
                    gfx.DrawString(("   " + line.Substring(currentChar, maxCharDescriptionPersona)), printFontPersona, myBrush, leftMargin, YPosition, New StringFormat)
                    count = (count + 1)
                    currentChar = (currentChar + maxCharDescriptionPersona)
                    itemLenght = (itemLenght - maxCharDescriptionPersona)
                End While
                line = ordIt.GetItemName(item)
                gfx.DrawString(("   " + line.Substring(currentChar, (line.Length - currentChar))), printFontPersona, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            Else
                gfx.DrawString(("   " + ordIt.GetItemName(item)), printFontPersona, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            End If
            myBrush = myBrushOri
        Next
        leftMargin = 0
        DrawEspacio()
        line = DottedLine()
        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
        DrawEspacio()
    End Sub
    Private Sub DibujaItems()
        Dim lineas As String
        Dim ordIt As OrderItem = New OrderItem(Microsoft.VisualBasic.ChrW(63))
        gfx.DrawString("PRODUCTO       CANTIDAD", printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
        DrawEspacio()
        For Each item As String In items
            lineas = ""
            line = ordIt.GetItemCantidad(item)
            line = (AjustarEspacios(line.Length, 2) + line)
            lineas += line
            line = ordIt.GetItemName(item)
            line = (line + AjustarEspacios(line.Length, 25))
            line = line.Substring(0, 25)
            lineas += line
            line = ordIt.GetItemPrice(item)
            line = (AjustarEspacios(line.Length, 5) + line)
            lineas += line
            gfx.DrawString(lineas, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            count = (count + 1)
        Next
        leftMargin = 0
        DrawEspacio()
        line = DottedLine()
        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
        DrawEspacio()
    End Sub
    Private Sub DibujaItemsDev()
        Dim lineas As String
        Dim ordIt As OrderItem = New OrderItem(Microsoft.VisualBasic.ChrW(63))
        gfx.DrawString("Edición Devolución DevTardia", printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
        DrawEspacio()
        For Each item As String In items
            lineas = ""
            line = ordIt.GetItemCantidad(item)
            line = (line + AjustarEspacios(line.Length, 10))
            line = line.Substring(0, 10)
            lineas += line
            line = ordIt.GetItemName(item)
            line = (AjustarEspacios(line.Length, 11) + line)
            'line = line.Substring(0, 25)
            lineas += line
            line = ordIt.GetItemPrice(item)
            line = (AjustarEspacios(line.Length, 11) + line)
            lineas += line
            gfx.DrawString(lineas, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            count = (count + 1)
        Next
        leftMargin = 0
        DrawEspacio()
        line = DottedLine()
        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
        DrawEspacio()
    End Sub
    Private Sub DrawTotales()
        Dim ordTot As OrderTotal = New OrderTotal(Microsoft.VisualBasic.ChrW(63))
        For Each total As String In totales

            line = ordTot.GetTotalCantidad(total)
            ''*****************************


            myBrush = Nothing
            myBrush = New SolidBrush(Color.Black)
          
            ''***********************
            line = (AlignRightText(line.Length) + line)
            gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            leftMargin = 0
            line = (" " + ordTot.GetTotalName(total))
            gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            count = (count + 1)
        Next
        leftMargin = 0
        DrawEspacio()
        DrawEspacio()
    End Sub
    Private Sub DibujaTotales()
        Dim ordTot As OrderTotal = New OrderTotal(Microsoft.VisualBasic.ChrW(63))
        Dim lineas As String
        For Each total As String In totales
            lineas = ""
            leftMargin = 0
            line = ordTot.GetTotalName(total)
            line = (line + AjustarEspacios(line.Length, 27))
            lineas += line
            line = ordTot.GetTotalCantidad(total)
            line = (AjustarEspacios(line.Length, 5) + line)
            lineas += line
            gfx.DrawString(lineas, printFont, myBrush, leftMargin, YPosition, New StringFormat)
            count = (count + 1)
        Next
        leftMargin = 0
        DrawEspacio()
        DrawEspacio()
    End Sub
    Private Sub DrawFooter()
        Dim printFontPersona = New Font(fontName, fontSize, FontStyle.Regular)
        For Each footer As String In footerLines
            If (footer.Length > maxChar) Then
                Dim currentChar As Integer = 0
                Dim footerLenght As Integer = footer.Length
                While (footerLenght > maxChar)
                    line = footer
                    gfx.DrawString(line.Substring(currentChar, maxChar), printFontPersona, myBrush, leftMargin, YPosition, New StringFormat)
                    count = (count + 1)
                    currentChar = (currentChar + maxChar)
                    footerLenght = (footerLenght - maxChar)
                End While
                line = footer
                gfx.DrawString(line.Substring(currentChar, (line.Length - currentChar)), printFontPersona, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            Else
                line = footer
                ''*****************************
                If Len(line) = 0 Then

                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                ElseIf Mid(line, Len(line), 1) = "ʎ" Then
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Red)
                    line = Mid(line, 1, Len(line) - 1)
                Else
                    myBrush = Nothing
                    myBrush = New SolidBrush(Color.Black)
                End If
                ''***********************
                gfx.DrawString(line, printFontPersona, myBrush, leftMargin, YPosition, New StringFormat)
                count = (count + 1)
            End If
        Next
        leftMargin = 0
        DrawEspacio()
    End Sub
    Private Sub DrawEspacio()
        line = ""
        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
    End Sub
    Private Sub DrawLineaEspecifica(ByVal line As String)
        gfx.DrawString(line, printFont, myBrush, leftMargin, YPosition, New StringFormat)
        count = (count + 1)
    End Sub
End Class
Public Class OrderItem
    Private delimitador() As Char = New Char() {Microsoft.VisualBasic.ChrW(63)}
    Public Sub New(ByVal delimit As Char)
        MyBase.New()
        delimitador = New Char() {delimit}
    End Sub
    Public Function GetItemCantidad(ByVal orderItem As String) As String
        Dim delimitado() As String = orderItem.Split(delimitador)
        Return delimitado(0)
    End Function
    Public Function GetItemName(ByVal orderItem As String) As String
        Dim delimitado() As String = orderItem.Split(delimitador)
        Return delimitado(1)
    End Function
    Public Function GetItemPrice(ByVal orderItem As String) As String
        Dim delimitado() As String = orderItem.Split(delimitador)
        Return delimitado(2)
    End Function
    Public Function GetItemBoni(ByVal orderItem As String) As String
        Try
            Dim delimitado() As String = orderItem.Split(delimitador)
            Return delimitado(3)
        Catch ex As Exception
            Return ""
        End Try
        
    End Function
    Public Function GenerateItem(ByVal cantidad As String, ByVal itemName As String, ByVal price As String, Optional ByVal boni As String = "") As String
        If boni = "" Then
            Return (cantidad + (delimitador(0) + (itemName + (delimitador(0) + price))))
        Else
            Return (cantidad + (delimitador(0) + (itemName + (delimitador(0) + price + (delimitador(0) + boni)))))
        End If
        'Return (cantidad & "" & itemName + (delimitador(0) + price))
    End Function
End Class

Public Class OrderTotal
    Private delimitador() As Char = New Char() {Microsoft.VisualBasic.ChrW(63)}
    Public Sub New(ByVal delimit As Char)
        MyBase.New()
        delimitador = New Char() {delimit}
    End Sub
    Public Function GetTotalName(ByVal totalItem As String) As String
        Dim delimitado() As String = totalItem.Split(delimitador)
        Return delimitado(0)
    End Function
    Public Function GetTotalCantidad(ByVal totalItem As String) As String
        Dim delimitado() As String = totalItem.Split(delimitador)
        Return delimitado(1)
    End Function
    Public Function GenerateTotal(ByVal totalName As String, ByVal price As String) As String
        Return (totalName _
        + (delimitador(0) + price))
    End Function
End Class