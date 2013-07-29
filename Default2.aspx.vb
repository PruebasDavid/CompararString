
Partial Class Default2
    Inherits System.Web.UI.Page

Function GenerateCSVFile() As String
        Dim strFileName As String = System.IO.Path.GetRandomFileName().Replace(".", "")
        Dim strResult As String = ""

        Dim paymentYear As String = ""


        With Response
            .Clear()
            Dim strFriendlyName As String = Date.Now.ToString("MM-dd-yyyy") & ".csv"
            .AddHeader("Content-disposition", "attachment;filename=" & strFriendlyName)
            .ContentType = "application/octet-stream"

            Dim lineValue As StringBuilder = New StringBuilder

            lineValue.Append(Textbox1.Text & "," & Textbox2.Text & "," & Textbox3.Text & "," & Textbox4.Text & "," & Textbox5.Text & "," & Textbox6.Text)

            .Write(lineValue.ToString)

            .End()
        End With
        Return strResult
    End Function

    Protected Sub btn_Generar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Generar.Click
        GenerateCSVFile()
    End Sub

    Protected Sub btn_Volver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Volver.Click
        Response.Redirect("~/Default.aspx/")
    End Sub
End Class
