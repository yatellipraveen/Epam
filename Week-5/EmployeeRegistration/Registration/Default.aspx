<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Registration._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div style="height: 86px">
        <h1 style="text-align:center">Employee Registration Page</h1>
    </div>

    <div class="form-group">
      <asp:label runat="server" for="firstname">First Name:</asp:label>
      <asp:TextBox runat="server" class="form-control" id="firstname" placeholder="Enter First Name"></asp:TextBox>
    </div>
    <div class="form-group">
      <asp:label runat="server" for="lastname">First Name:</asp:label>
      <asp:TextBox runat="server" class="form-control" id="lastname" placeholder="Enter Last Name"></asp:TextBox>
    </div>
      <div class="gender" style="height: 43px">
          <asp:label runat="server" for="gender">Gender:</asp:label>
          <asp:RadioButton runat="server" text="Male"  style="margin-left:10px" GroupName="gender"></asp:RadioButton> 
          <asp:RadioButton runat="server" text="Female"  style="margin-left:10px" GroupName="gender"></asp:RadioButton>
      </div>
 
    <div class="stream" style="height: 36px">
        <asp:Label runat="server" Text="Stream :" ></asp:Label>
        <asp:CheckBox runat="server" text=".Net " style="margin-left:10px"> </asp:CheckBox>
        <asp:CheckBox runat="server" text="Java" style="margin-left:10px"> </asp:CheckBox>
        <asp:CheckBox runat="server" text="Sales Force" style="margin-left:10px"> </asp:CheckBox>
        <asp:CheckBox runat="server" text="DEP" style="margin-left:10px"> </asp:CheckBox>
    </div>
    <div class="dob" style="height: 49px">
        <asp:Label runat="server" Text="Date of Birth :" ></asp:Label>
        <asp:TextBox TextMode="Date" ID="calender" runat="server"  style="margin-left:10px" BorderColor="White" BorderStyle="Groove"></asp:TextBox>
    </div>

    <div class="location" style="height: 47px">
        <asp:Label runat="server" Text="Location" ></asp:Label>
        <asp:DropDownList ID="countrylist" runat="server" OnSelectedIndexChanged="countrylist_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        <asp:DropDownList ID="statelist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="statelist_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="citylist" runat="server"  AutoPostBack="True"></asp:DropDownList>
    </div>

    <div>

        <asp:Button class="btn btn-success" ID="Submit" runat="server" BorderColor="#996600" ForeColor="Black" Text="Submit" />

    </div>

</asp:Content>
