<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNETWEBSQL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server"></asp:DataList>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Öğrenci No"></asp:Label>
            <br />
            <asp:TextBox ID="txtOgrenciNo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Öğrenci Ad Soyad"></asp:Label>
            <br />
            <asp:TextBox ID="txtOgrenciAd" runat="server"></asp:TextBox>
             <br />
            <asp:Label ID="Label3" runat="server" Text="Öğrenci Adres"></asp:Label>
            <br />
              <asp:TextBox ID="txtOgrenciAdres" runat="server"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
            <br />
            <br />
            <asp:Button ID="btnSil" runat="server" Text="Sil"  OnClick="btnSil_Click1"/>
         <br />
            <br />
             <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
        </div>
    </form>
</body>
</html>
