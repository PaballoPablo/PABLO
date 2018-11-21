<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Revolution_.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
    <div class="Absolute-Center is-Responsive">
    <h1 class="font-weight-bold">Login page</h1>
    <br/>
    <div class="col-xs-4">
     <label for="inputUsername">Username</label>
     <input class="form-control" id="txtUsername" runat="server" placeholder="Username" type="text"/>
     <br/>
     <label for="inputPassword">Password</label>
     <input class="form-control" id="txtPassword" runat="server" placeholder="Password" type="text"/>
     <br/>
        <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-primary" OnClick="btnLogin_Click" />
     </div>
     </div>
     </div>
     </div>
</asp:Content>
