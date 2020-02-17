<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SQLInjection._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       
        <asp:Label ID="Details" runat="server" Text="Details"  style=" text-align:center; font-size:50px"></asp:Label>
       
        <br />
        <br />
        <asp:Label ID="StudentLabel" runat="server" Text="Enter student ID"  ></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       
        <asp:Button ID="Button1" runat="server"  Text="GetDetails" OnClick="Button1_Click1" />
       
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />
                <asp:BoundField DataField="Strem" HeaderText="Strem" SortExpression="Strem" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLInjectionDatabaseConnectionString %>" SelectCommand="SELECT * FROM [SQLTEST]"></asp:SqlDataSource>
       
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
       
    </div>

</asp:Content>
