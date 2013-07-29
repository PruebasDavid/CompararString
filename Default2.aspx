<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/bootstrap.css" rel="stylesheet"  />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="text-center">Texto Para crear el archivo CSV</div>
            <br />
            <asp:Panel ID="pnl_Texto" runat="server">
                <asp:TextBox ID="Textbox1" runat="server"></asp:TextBox>
                <asp:TextBox ID="Textbox2" runat="server"></asp:TextBox>
                <asp:TextBox ID="Textbox3" runat="server"></asp:TextBox>
                <asp:TextBox ID="Textbox4" runat="server"></asp:TextBox>
                <asp:TextBox ID="Textbox5" runat="server"></asp:TextBox>
                <asp:TextBox ID="Textbox6" runat="server"></asp:TextBox>
            </asp:Panel>
            <div><asp:LinkButton ID="btn_Generar" runat="server" CssClass="btn" Text="Generar CSV"></asp:LinkButton></div>
            <div><asp:LinkButton ID="btn_Volver" runat="server" CssClass="btn" Text="Volver"></asp:LinkButton></div>
        </div>
    </form>
</body>
</html>
