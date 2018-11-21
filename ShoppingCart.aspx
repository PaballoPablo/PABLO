<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Revolution_.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvShoppingCart" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvShoppingCart_RowCancelingEdit" OnRowDeleting="gvShoppingCart_RowDeleting" OnRowEditing="gvShoppingCart_RowEditing" OnRowUpdating="gvShoppingCart_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="661px">
        <Columns>
            <asp:BoundField DataField="ISBN" HeaderText="Isbn" ReadOnly="True" />
            <asp:BoundField DataField="NAME" HeaderText="Product Name" />
            <asp:BoundField DataField="PRICE" HeaderText="Price" ReadOnly="True" />
            <asp:BoundField DataField="QUANTITY" HeaderText="Quantity" />
            <asp:ImageField DataImageUrlField="IMAGE" HeaderText="Image" ReadOnly="True">
            </asp:ImageField>
            <asp:BoundField DataField="TOTAL" HeaderText="Total" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <EmptyDataTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# double.Parse(Eval("PRICE").ToString()) * Int32.Parse(Eval("QUANTITY").ToString()) %>'></asp:Label>
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:Label ID="lblGrandTotal" runat="server"></asp:Label>
</asp:Content>
