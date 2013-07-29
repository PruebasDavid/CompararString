
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("TextoInicial") = tb_Quimicos.Text
        End If
    End Sub

    Protected Sub btn_Mostrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Dim TextoActual As String = tb_Quimicos.Text
        tb_Cambios.Text = Class1.CompararString(ViewState("TextoInicial"), TextoActual)
    End Sub

    Protected Sub btn_csv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_csv.Click
        Response.Redirect("~/Default2.aspx")
    End Sub

End Class
