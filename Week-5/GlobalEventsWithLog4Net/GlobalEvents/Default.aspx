<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GlobalEvents._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    
        <asp:Button ID="SessionEndButton" runat="server" OnClick="SessionEndButton_Click" Text="SessionEnd" />
    
    </div>

</asp:Content>
