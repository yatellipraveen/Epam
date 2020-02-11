<%@ Page Title="Home Page" ClientIDMode="Static" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Registration._Default" %>

   

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     
     <div style="height: 86px">
        <h1 style="text-align:center">Employee Registration Page</h1>
    </div>
    <form  onsubmit="">   
        <div class="form-group">
          <asp:label runat="server" for="firstname">First Name:</asp:label>
          <asp:TextBox runat="server" class="form-control" id="firstname" placeholder="Enter First Name"></asp:TextBox>
            <asp:Label runat="server" ID="fnameerror" Style="color: red"></asp:Label>
        </div>
        <div class="form-group">
          <asp:label runat="server" for="lastname">Last Name:</asp:label>
          <asp:TextBox runat="server" class="form-control" id="lastname" placeholder="Enter Last Name"></asp:TextBox>
            <asp:Label ID="lnameerror" runat="server" style="color:red"></asp:Label>
        </div>
          <div class="gender" style="height: 43px">
              <asp:label runat="server" for="gender">Gender:</asp:label>
              <asp:RadioButton runat="server" text="Male"  style="margin-left:10px" GroupName="gender"></asp:RadioButton> 
              <asp:RadioButton runat="server" text="Female"  style="margin-left:10px" GroupName="gender"></asp:RadioButton>
          </div>
 
        <div class="stream" style="height: 36px">
            <asp:Label runat="server" Text="Stream :" ></asp:Label>
            <asp:CheckBox ID="dotnet" runat="server" text=".Net " style="margin-left:10px"> </asp:CheckBox>
            <asp:CheckBox ID="java" runat="server" text="Java" style="margin-left:10px"> </asp:CheckBox>
            <asp:CheckBox ID="salesforce" runat="server" text="Sales Force" style="margin-left:10px"> </asp:CheckBox>
            <asp:CheckBox ID="DEP" runat="server" text="DEP" style="margin-left:10px"> </asp:CheckBox>
            <asp:Label ID="streamerror" runat="server" style="color:red"></asp:Label>
        </div>
        <div class="dob" style="height: 49px">
            <asp:Label runat="server" Text="Date of Birth :" ></asp:Label>
            <asp:TextBox TextMode="Date" ID="calender" runat="server"  style="margin-left:10px" BorderColor="White" BorderStyle="Groove"></asp:TextBox>
            <asp:Label ID="doberror" runat="server" style="color:red"></asp:Label>
        </div>

        <div class="location" style="height: 47px">
            <asp:Label runat="server" Text="Location" ></asp:Label>
            <asp:DropDownList id="countrylist" runat="server" OnSelectedIndexChanged="countrylist_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList ID="statelist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="statelist_SelectedIndexChanged"></asp:DropDownList>
            <asp:DropDownList ID="citylist" runat="server"  AutoPostBack="True"></asp:DropDownList>
            <asp:Label ID="Locerror" runat="server" style="color:red"></asp:Label>
        </div>

        <div>

            <asp:Button class="btn btn-success" ID="Submit" runat="server" BorderColor="#996600" ForeColor="Black" Text="Submit" OnClientClick="" OnClick="Submit_Click" />

        </div>
    </form>

    <script >
        //jquery
        $(document).ready(function () {
            $("#Submit").click(
                function () {
                    var result = true;
                    if ($("#firstname").val() == "") {
                        result = false;
                        $("#fnameerror").html("Enter Valid Name");
                    }
                    else $("#fnameerror").html("");

                    if ($("#lastname").val() == "") {
                        result = false;
                        $("#lnameerror").html("Enter a valid name");
                    }
                    else $("#lnameerror").html("");

                    if ($("#java").prop("checked") == false && $("#dotnet").prop("checked") == false && $("#salesforce").prop("checked") == false&& $("#DEP").prop("checked")==false) {
                        result = false;
                        $("#streamerror").html("Select a stream");
                    }
                    else $("streamerror").html("");

                    if ($("calender").val() == "") {
                        result = false;
                        $("#doberror").html("Select DOB");
                    }
                    else $("#doberror").html("Select DOB");


                    return result;
                })
        });

        
    </script>

</asp:Content>
