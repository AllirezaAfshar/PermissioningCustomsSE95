<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddRule.aspx.cs" Inherits="MojavezSystem.UI.AddRule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server"> نام سازمان</asp:Label>
    <asp:TextBox runat="server" ID="txtOrganName"></asp:TextBox>
    <br />
    <asp:Label runat="server">مبلغ</asp:Label>
    <asp:TextBox runat="server"></asp:TextBox>
    <span>تا </span>
    <asp:TextBox runat="server"></asp:TextBox>
    <br />
    <asp:Label runat="server">وزن</asp:Label>
    <asp:TextBox runat="server"></asp:TextBox>
    <span>تا </span>
    <asp:TextBox runat="server"></asp:TextBox>
    <br />
    <asp:Label runat="server">تاریخ ورود</asp:Label>
    <asp:TextBox runat="server"></asp:TextBox>
    <span>تا </span>
    <asp:TextBox runat="server"></asp:TextBox>
    <br />
    <asp:Label runat="server">کشور ها</asp:Label>
    <asp:TextBox runat="server"></asp:TextBox>


    <span></span>
</asp:Content>
