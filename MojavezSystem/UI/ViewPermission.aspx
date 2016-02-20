<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPermission.aspx.cs" Inherits="MojavezSystem.UI.ViewPermission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">شناسه</asp:Label>
    <asp:Label runat="server" ID="lblID"></asp:Label>
    <br/>
    <asp:Label runat="server">نام</asp:Label>
    <asp:Label runat="server" ID="lblName"></asp:Label>
    <br/>
    <asp:Label runat="server" >سازمان</asp:Label>
    <asp:Label runat="server" ID="lblOrg"></asp:Label>
    <br/>
    <asp:Label runat="server">وضعیت</asp:Label>
    <asp:Label runat="server" ID="lblStatus"></asp:Label>
    <br/>
    <asp:Button runat="server" Text="تایید مجوز" ID="btnPass" OnClick="btnPass_OnClick"/>
</asp:Content>
