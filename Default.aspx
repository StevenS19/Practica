<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CursoASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />

        <asp:TextBox ID="txtConteo" runat="server"></asp:TextBox>
        <asp:Button ID="btnIncrementar" runat="server" OnClick="btnIncrementar_Click" Text="Button" />

    </p>

    <p>
        Esto es un ejemplo

    </p>


</asp:Content>
