<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Documents.aspx.cs" Inherits="MojavezSystem.UI.Documents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <br/>

    <br/>
    

    <h4>صفحه اسناد شما</h4>
    <h5>این صفحه مشخص میکند هر سند شما در چه وضعیتی قرار دارد و وضعیت مجوز های آن چگونه است</h5>
    <div class="text-right">
        <asp:Button runat="server" Text="افزودن سند" OnClick="OnClick" CssClass="glyphicon-align-right"/>
        <asp:Panel runat="server" ID="pnl" Visible="False">
            <asp:TextBox runat="server" ID="Doctxt"></asp:TextBox>
            <asp:Label runat="server">نام سند</asp:Label>
            <br/>
            <asp:Button runat="server" Text="submitDocument" OnClick="OnClickSubmit"/>
        </asp:Panel>
        <ul runat="server" ID="ulDocument">
            
        </ul>
    </div>
</asp:Content>
