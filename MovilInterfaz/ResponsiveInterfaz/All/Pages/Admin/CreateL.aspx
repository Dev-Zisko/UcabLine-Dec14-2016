﻿<%@ Page Title="" Language="C#" MasterPageFile="~/All/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="CreateL.aspx.cs" Inherits="ResponsiveInterfaz.All.Pages.Admin.CreateL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="Centrar"> 
    <h1>Nombre de la línea:</h1>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>   
    <br />
    <h1>Número de trenes:</h1>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <h1>Seleccione tipo de línea:</h1>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Lineal</asp:ListItem>
            <asp:ListItem>Circular</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    <asp:Button ID="Button2" runat="server" Text="Guardar" OnClick="Button2_Click" BackColor="#303A52" BorderStyle="Solid" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="White" Font-Bold="True" Width="150px" />
    </div>
</asp:Content>
