﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/bootstrap.css" rel="stylesheet"  />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 text-center text-warning">Listado de precursores y químicos esenciales</div>
            <div class="span5 text-left">
                Original<br /><asp:TextBox ID="tb_1" TextMode="MultiLine" runat="server" Rows="3" width="300px"></asp:TextBox><br />
                Cambiado<br /><asp:TextBox ID="tb_2" TextMode="MultiLine" runat="server" Rows="3" width="300px"></asp:TextBox><br />
                Diferencias<br /><asp:TextBox ID="tb_3" TextMode="MultiLine" runat="server" Rows="3" width="300px"></asp:TextBox>
            </div>
            <div class="span10 text-center">
                <asp:LinkButton ID="btn_Mostrar" runat="server" Text="Mostrar Cambios" CssClass="btn"></asp:LinkButton>
                <asp:LinkButton ID="btn_csv" runat="server" Text="Crear CSV" CssClass="btn"></asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
