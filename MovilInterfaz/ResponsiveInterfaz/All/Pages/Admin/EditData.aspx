﻿<%@ Page Title="" Language="C#" MasterPageFile="~/All/MasterPages/EditData.Master" AutoEventWireup="true" CodeBehind="EditData.aspx.cs" Inherits="ResponsiveInterfaz.All.Pages.Admin.EditData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="Centrar">
    <h1>Nuevo nombre  usuario:</h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <h1>Nueva contraseña:</h1>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar cambios" BackColor="#303A52" BorderStyle="Solid" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="White" Font-Bold="True" Width="150px" OnClick="Button1_Click" />
    </div>
</asp:Content>