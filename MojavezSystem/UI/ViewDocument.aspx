<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDocument.aspx.cs" Inherits="MojavezSystem.UI.ViewDocument" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">نام سند</asp:Label>
    <asp:Label runat="server" ID="lblName"></asp:Label>
    <br />
    <asp:Label runat="server">شناسه سند</asp:Label>
    <asp:Label runat="server" ID="lblID"></asp:Label>
    <br />
    <asp:Label runat="server">نام صاحب کالا</asp:Label>
    <asp:Label runat="server" ID="lblOwner"></asp:Label>
    <br />
    <asp:Label runat="server">مجوز ها</asp:Label>
    <asp:Label runat="server" ID="lblPermissions"></asp:Label>
    <br />
    <br />


    <ul runat="server" id="permissionUl"></ul>

    <br />
    <br />
    <asp:Button runat="server" Text="افزودن مجوز" ID="btnAddPermission" OnClick="btnAddPermission_OnClick" />
    <asp:Panel runat="server" ID="PermissionPanels" Visible="False">
        <asp:Label runat="server"> نام مجوز</asp:Label>
        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
        <br />
        <asp:Label runat="server">نام سازمان</asp:Label>
        <asp:TextBox runat="server" ID="txtOrgan"></asp:TextBox>
        <br />
        <asp:Label runat="server">مبلغ</asp:Label>
        <asp:TextBox runat="server" ID="txtPrice"></asp:TextBox>
        <br />
        <asp:Label runat="server">وزن</asp:Label>
        <asp:TextBox runat="server" ID="txtWeight"></asp:TextBox>
        <br />
        <asp:Label runat="server">تاریخ ورود</asp:Label>
        <asp:TextBox runat="server" ID="txtDischargeDate"></asp:TextBox>
        <br />
        <asp:Label runat="server">کشور</asp:Label>
        <asp:TextBox runat="server" ID="txtOriginCountry"></asp:TextBox>
        <br />
        <asp:Button runat="server" Text="تایید" ID="SubmitPermission" OnClick="SubmitPermission_OnClick" />
    </asp:Panel>

</asp:Content>
