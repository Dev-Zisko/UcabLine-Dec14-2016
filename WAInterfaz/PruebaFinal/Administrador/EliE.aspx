﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Administrador.master" AutoEventWireup="true" CodeBehind="EliE.aspx.cs" Inherits="PruebaFinal.Administrador.EliE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="Centrar"> 
    <h1>Elija la línea de la estación:</h1>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    &nbsp;
    <asp:Button ID="Button2" runat="server" Text="Seleccionar" BackColor="#303A52" BorderStyle="Solid" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="White" Font-Bold="True" Width="150px" OnClick="Button2_Click" />
    <h1>Elija la estación a eliminar:</h1>
        <asp:DropDownList ID="DropDownList2" runat="server" Enabled="False">
        </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Eliminar Estacion" BackColor="#303A52" BorderStyle="Solid" Font-Names="Times New Roman" Font-Size="Medium" ForeColor="White" Font-Bold="True" Width="150px" OnClick="Button1_Click" />
    </div>
    
</asp:Content>
