
<%-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <div style="height: 86px">
        <h1 style="text-align:center">Employee Registration Page</h1>
    </div>--%>


<div class="container">
  <form id="form" runat="server">
    <div class="form-group">
      <asp:label runat="server" for="firstname">First Name:</asp:label>
      <asp:TextBox runat="server" class="form-control" id="firstname" placeholder="Enter First Name"></asp:TextBox>
    </div>
    <div class="form-group">
      <asp:label runat="server" for="lastname">First Name:</asp:label>
      <asp:TextBox runat="server" class="form-control" id="lastname" placeholder="Enter Last Name"></asp:TextBox>
    </div>
      <div class="gender">
          <asp:label runat="server" for="gender">Gender:</asp:label>
          <asp:RadioButton runat="server" text="Male"  style="margin-left:10px" GroupName="gender"></asp:RadioButton> 
          <asp:RadioButton runat="server" text="Male"  style="margin-left:10px" GroupName="gender"></asp:RadioButton>
      </div>
    <asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
 
    <div class="stream">
        <asp:Label runat="server" Text="Stream :" ></asp:Label>
        <asp:CheckBox runat="server" text=".Net " style="margin-left:10px"> </asp:CheckBox>
        <asp:CheckBox runat="server" text="Java" style="margin-left:10px"> </asp:CheckBox>
    </div>
    
       
  </form>
</div>






