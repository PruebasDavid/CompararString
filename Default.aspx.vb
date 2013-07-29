
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btn_Mostrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        tb_3.Text = Class1.CompararString(tb_1.Text, tb_2.Text)
    End Sub

    Protected Sub btn_csv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_csv.Click
        Response.Redirect("~/Default2.aspx")
    End Sub


End Class
