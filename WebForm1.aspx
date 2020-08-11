<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="LeerPDF.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <form method="post"> 
                
                <h3>PDF visual:</h3>
                <br />
                <input type="submit" value="cargar" />
                <br />
                <b>Densidad</b>
                <asp:Label ID="lblPosicionDensidad" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lblDensidad" runat="server" Text=""></asp:Label><br />
                <b>Ruta</b>
                <asp:Label ID="lblPosicionRuta" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lblRuta" runat="server" Text=""></asp:Label>
                <br /><br />
                <b>Texto del PDF</b><br />
                <asp:Label ID="TXTPDF" runat="server" Text=""></asp:Label>
            </form>
        </div>
    </form>
</body>
</html>
