<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Revolution_.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
    <div class="Absolute-Center is-Responsive">
    <h1 class="font-weight-bold">Add Product</h1>
    <br/>
    <div class="col-xs-4">
     <label for="inputISBN">ISBN</label>
     <input class="form-control" id="txtISBN" runat="server" placeholder="ISBN" type="text"/>
     <br/>
     <label for="inputProductName">Product Name</label>
     <input class="form-control" id="txtProductName" runat="server" placeholder="Product Name" type="text"/>
     <br/>
     <label for="inputPrice">Price</label>
     <input class="form-control" id="txtPrice" runat="server" placeholder="Price" type="text"/>
     <br/>
     <label for="inputQuantity">Quantity</label>
     <input class="form-control" id="txtQuantity" runat="server" placeholder="Quantity" type="text"/>
     <br/>
     <label class="control-label">Select Image</label>
     <asp:FileUpload ID="upload" runat="server" />
     <br/>
     <asp:Button ID="btnAddProduct" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAddProduct_Click" />
     </div>
     </div>
     </div>
     </div>
</asp:Content>
