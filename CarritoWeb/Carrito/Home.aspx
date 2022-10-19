<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Carrito.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Home</h1>
    <asp:GridView ID="dgvArticulos" runat="server" CssClass="table"></asp:GridView>
</asp:Content>
