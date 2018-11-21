<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="Revolution_.RegistrationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
     <div class="row">
     <div class="Absolute-Center is-Responsive">
     <h1 class="font-weight-bold">Registration page</h1>
     <br/>
     <div class="col-xs-4">
     <label for="inputFirstName">First Name</label>
     <input class="form-control" id="txtFirstName" placeholder="First Name" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Provide *  First Name" ForeColor="Red"></asp:RequiredFieldValidator>
     <br/>
     <label for="inputLastName">Last Name</label>
     <input class="form-control" id="txtLastName" placeholder="Last Name" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Provide * Last Name" ForeColor="Red"></asp:RequiredFieldValidator>
     <br/>
     <label for="inputTitle">Title</label>
     <input class="form-control" id="txtTitle" placeholder="Title" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTitle" ErrorMessage="Provide * Title" ForeColor="Red"></asp:RequiredFieldValidator>
     <br/>
     <label for="inputEmail">Email</label>
     <input class="form-control" id="txtEmail" placeholder="Email" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="Provide * Email" ForeColor="Red"></asp:RequiredFieldValidator>
         &nbsp;
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Provide * correct Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
     <br/>
     <label for="inputUsername">Username</label>
     <input class="form-control" id="txtUsername" placeholder="Username" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUsername" ErrorMessage="Provide * Username" ForeColor="Red"></asp:RequiredFieldValidator>
         &nbsp;
         <asp:Label ID="lblError" runat="server"></asp:Label>
     <br/>
     <label for="inputPassword">Password</label>
     <input class="form-control" id="txtPassword" placeholder="Password" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" ErrorMessage="Provide * Password" ForeColor="Red"></asp:RequiredFieldValidator>
     <br/>
     <label for="inputConfirmPassword">Confirm Password</label>
     <input class="form-control" id="txtConfirmPassword" placeholder="ConfirmPassword" runat="server" type="text"/>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPassword" ErrorMessage="Provide * Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
         &nbsp;
         <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Password do not match" ForeColor="Red"></asp:CompareValidator>
     <br/>
     <asp:Button ID="btnRegister" class="btn btn-primary" runat="server" Text="Register" OnClick="btnRegister_Click1" />
     <br/>
     </div>
     </div>
     </div>
     </div>
</asp:Content>
