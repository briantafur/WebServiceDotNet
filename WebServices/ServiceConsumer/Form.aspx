<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="ServiceConsumer.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/Jquery.js"></script>
    <script src="Scripts/WebService.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <input type="text" value="Brian" id="txtNombre" />
            <input type="button" value="llamar" onclick="callService();" />
            <asp:Label ID="lblRespuesta" runat="server" Text=""></asp:Label>


        </div>
        <asp:Button ID="Button1" runat="server" Text="Llamar ws Hello world" OnClick="helloWorld" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Llamar ws fecha" OnClick="obtenerFecha" />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Llamar ws Hello" OnClick="hello" />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
